import random
from tkinter import *
from tkinter import ttk
from tkinter.messagebox import showerror, showinfo
from tkinter import filedialog

class ECPoint:
    def __init__(self, x=0, y=0, a=0, b=0, p=0, is_polynomial_basis=False):
        self.x = x
        self.y = y
        self.a = a
        self.b = b
        self.p = p
        self.pol_basis = is_polynomial_basis

    # inverse int b modulo p
    @staticmethod
    def _mod_inverse(b, p):
        x0, x1, y0, y1, n = 1, 0, 0, 1, p
        while n != 0:
            q, b, n = b // n, n, b % n
            x0, x1 = x1, x0 - q * x1
            y0, y1 = y1, y0 - q * y1
        return x0 % p

    # addition of two EC points
    def __add__(self, other):
        p_result = ECPoint()
        p_result.a = self.a
        p_result.b = self.b
        p_result.p = self.p
        p_result.pol_basis = self.pol_basis
        if self.pol_basis:
            if self.x == other.x and self.y == other.y:
                x_sqr = self.mult_field(self.x, self.x, self.p)
                p_result.x = self.sum_field(x_sqr,
                                            self.mult_field(self.b, self.inv_field(x_sqr, self.p), self.p))
                tmp1 = self.mult_field(self.y, self.inv_field(self.x, self.p), self.p)
                tmp2 = self.mult_field(self.sum_field(self.x, tmp1), p_result.x, self.p)
                p_result.y = self.sum_field(x_sqr, tmp2, p_result.x)
            else:
                if self.x == other.x:
                    return float('inf')
                l = self.mult_field(self.sum_field(self.y, other.y),
                                    self.inv_field(self.sum_field(self.x, other.x), self.p), self.p)
                p_result.x = self.sum_field(self.mult_field(l, l, self.p), l, self.x, other.x, self.a)
                l2 = self.mult_field(self.sum_field(self.y, other.y),
                                     self.inv_field(self.sum_field(self.x, other.x), self.p), self.p)
                p_result.y = self.sum_field(self.mult_field(l2, self.sum_field(self.x, p_result.x), self.p),
                                            p_result.x, self.y)
        else:
            dx = (other.x - self.x) % self.p
            dy = (other.y - self.y) % self.p
            if self.x == other.x and self.y == other.y:
                l = ((3 * self.x ** 2 + self.a) * ECPoint._mod_inverse(2 * self.y, self.p)) % self.p
            else:
                if self.x == other.x:
                    return float('inf')
                dx_inverse = ECPoint._mod_inverse(dx, self.p)
                l = (dy * dx_inverse) % self.p
            p_result.x = (l * l - self.x - other.x) % self.p
            p_result.y = (l * (self.x - p_result.x) - self.y) % self.p
        return p_result

    # multiplication EC point and integer
    def __rmul__(self, other):
        p_result = ECPoint(self.x, self.y, self.a, self.b, self.p, self.pol_basis)
        temp = ECPoint(self.x, self.y, self.a, self.b, self.p, self.pol_basis)
        x = other - 1
        while x != 0:
            if x % 2 != 0:
                p_result += temp
                x -= 1
            x //= 2
            temp = temp + temp
        return p_result

    # Multiplication in polynomial basis
    def mult_field(self, x, y, n):
        mask = 1 << (n.bit_length() - 2)
        p = 0
        while x:
            if x & 1:
                p ^= y
            if y & mask:
                y = (y << 1) ^ n
            else:
                y <<= 1
            x >>= 1
        return p

    # Addition in polynomial basis
    def sum_field(self, *x):
        res = 0
        for el in x:
            res ^= el
        return res

    # Inverse polynomial a modulo polynomial f
    def inv_field(self, a, f):
        u, v = a, f
        g1, g2, = 1, 0
        while u != 1:
            j = u.bit_length() - v.bit_length()
            if j < 0:
                u, v = v, u
                g1, g2 = g2, g1
                j = - j
            u = self.sum_field(u, (v << j))
            g1 = self.sum_field(g1, (g2 << j))
        return g1


class DSGOST:
    # p - int, EC module
    # a, b - int, EC coefficients
    # q - int, order of point P
    # p_x, p_y - int, point P coordinates
    def __init__(self, p, a, b, q, p_x, p_y):
        self.p_point = ECPoint(p_x, p_y, a, b, p)
        self.q = q
        self.a = a
        self.b = b
        self.p = p

    # generate key pair
    def gen_keys(self):
        d = random.randint(1, self.q - 1)
        q_point = d * self.p_point
        return d, q_point

    # sign message
    # message - int
    # private_key - int
    def sign(self, message, private_key, k=0):
        e = message % self.q
        if e == 0:
            e = 1
        if k == 0:
            k = random.randint(1, self.q - 1)
        r, s = 0, 0
        while r == 0 or s == 0:
            c_point = k * self.p_point
            r = c_point.x % self.q
            s = (r * private_key + k * e) % self.q
        return r, s

    # verify signed message
    # message - int
    # sign - tuple
    # public_key - ECPoint
    def verify(self, message, sign, public_key):
        e = message % self.q
        if e == 0:
            e = 1
        nu = ECPoint._mod_inverse(e, self.q)
        z1 = (sign[1] * nu) % self.q
        z2 = (-sign[0] * nu) % self.q
        c_point = z1 * self.p_point + z2 * public_key
        r = c_point.x % self.q
        if r == sign[0]:
            return True
        return False
    
def test_gost_sign():
    p = int(txt_p.get())
    a = int(txt_a.get())
    b = int(txt_b.get())
    x = int(txt_x.get())
    y = int(txt_y.get())
    q = int(txt_q.get())
    gost = DSGOST(p, a, b, q, x, y)
    key = int(txt_key.get())
    message = str(hash(txt_message.get('1.0', 'end')))
    message2 = str(hash(txt_message2.get('1.0', 'end')))
    if int(message)<0:
        message = -int(message)
    if int(message2)<0:
        message2 = -int(message2)
    print(message)
    print(message2)
    k = int(txt_k.get())
    sign = gost.sign(int(message), key, k)
    print(sign)
    if message == message2:
        expected = sign
    else:
        expected = (29700980915817952874371204983938256990422752107994319651632687982059210933395, 
                    55276416536732666760764290921278809844584601882710706741437556351022812740112)
    if sign != expected:
        open_error_sing()
        print("Тест НЕ пройден! Ожидаемый вывод НЕ подтвержден! Электронная подпись НЕ верна")
        assert sign == expected
    return int(message2), sign


def test_gost_verify():
    p = int(txt_p.get())
    a = int(txt_a2.get())
    b = int(txt_b2.get())
    x = int(txt_x2.get())
    y = int(txt_y2.get())
    q = int(txt_q2.get())
    gost = DSGOST(p, a, b, q, x, y)
    message2, sign = test_gost_sign()
    q_x = int(txt_q_x.get())
    q_y = int(txt_q_y.get())
    public_key = ECPoint(q_x, q_y, a, b, p)
    txt_public_key.insert(1.0, public_key.__dict__)
    if gost.verify(int(message2), sign, public_key) == True:
        open_info()
        print('Верификация прошла! Электронная подпись верна')
    else:
        open_error()
        print("Верификация НЕ прошла! Электронная подпись НЕ верна")

def open_info(): 
    showinfo(title="Информация", message="Верификация прошла! Электронная подпись верна")
 
def open_error(): 
    showerror(title="Ошибка", message="Верификация НЕ прошла! Электронная подпись НЕ верна")

def open_error_sing(): 
    showerror(title="Ошибка", message="Тест НЕ пройден! Ожадаемый вывод НЕ подтвержден! Электронная подпись НЕ верна")

def clicked():
    txt_public_key.delete("1.0", END)
    test_gost_sign()
    test_gost_verify()

def clicked2():
    txt_message.delete("1.0", END)
    tf = filedialog.askopenfilename(
        title="Open Text file", 
        filetypes=(("Text Files", "*.txt"),)
    )
    txt_path.insert(END, tf)
    tf = open(tf, encoding='utf-8')  # or tf = open(tf, 'r')
    data = tf.read()
    txt_message.insert(END, data)
    tf.close()

def clicked3():
    txt_message2.delete("1.0", END)
    tf = filedialog.askopenfilename(
        title="Open Text file", 
        filetypes=(("Text Files", "*.txt"),)
    )
    txt_path2.insert(END, tf)
    tf = open(tf, encoding='utf-8')  # or tf = open(tf, 'r')
    data = tf.read()
    txt_message2.insert(END, data)
    tf.close()

#Создание окна
window = Tk()
#Данные для входа
lbl1 = Label(window, text="На вход:", font=("Arial Bold", 14))
lbl1.grid(column=1, row=0) 
lbl_p = Label(window, text="p=", font=("Arial Bold", 12), width=3)
lbl_p.grid(column=0, row=1) 
txt_p = Entry(window, width=78)  
txt_p.insert(0, "57896044618658097711785492504343953926634992332820282019728792003956564821041")
txt_p.grid(column=1, row=1)
lbl_a = Label(window, text="a=", font=("Arial Bold", 12), width=3)
lbl_a.grid(column=0, row=2) 
txt_a = Entry(window, width=78)  
txt_a.insert(0, "7")
txt_a.grid(column=1, row=2)
lbl_b = Label(window, text="b=", font=("Arial Bold", 12), width=3)
lbl_b.grid(column=0, row=3) 
txt_b = Entry(window, width=78)  
txt_b.insert(0, "43308876546767276905765904595650931995942111794451039583252968842033849580414")
txt_b.grid(column=1, row=3)
lbl_x = Label(window, text="x=", font=("Arial Bold", 12), width=3)
lbl_x.grid(column=0, row=4) 
txt_x = Entry(window, width=78)  
txt_x.insert(0, "2")
txt_x.grid(column=1, row=4)
txt_path = Entry(window, width=78)  
txt_path.grid(column=3, row=2) 
lbl_y = Label(window, text="y=", font=("Arial Bold", 12), width=3)
lbl_y.grid(column=0, row=5) 
txt_y = Entry(window, width=78)  
txt_y.insert(0, "4018974056539037503335449422937059775635739389905545080690979365213431566280")
txt_y.grid(column=1, row=5)
lbl_q = Label(window, text="q=", font=("Arial Bold", 12), width=3)
lbl_q.grid(column=0, row=6) 
txt_q = Entry(window, width=78)  
txt_q.insert(0, "57896044618658097711785492504343953927082934583725450622380973592137631069619")
txt_q.grid(column=1, row=6)
lbl_key = Label(window, text="key=", font=("Arial Bold", 12), width=5)
lbl_key.grid(column=2, row=3) 
txt_key = Entry(window, width=78)  
txt_key.insert(0, "55441196065363246126355624130324183196576709222340016572108097750006097525544")
txt_key.grid(column=3, row=3)
lbl_message = Label(window, text="message=", font=("Arial Bold", 12), width=8)
lbl_message.grid(column=2, row=4) 
txt_message = Text(window, height=3, width=50)  
txt_message.grid(column=3, row=4)
lbl_k = Label(window, text="k=", font=("Arial Bold", 12), width=5)
lbl_k.grid(column=2, row=5) 
txt_k = Entry(window, width=78)  
txt_k.insert(0, "53854137677348463731403841147996619241504003434302020712960838528893196233395")
txt_k.grid(column=3, row=5)
btn2 = Button(window, text="Найти файл...", command=clicked2)
btn2.grid(column=3, row=1)

window.title("ГОСТ 34.10-94")
#Данные для проверки(верификации)
lbl2 = Label(window, text="Для проверки ЭЦП:", font=("Arial Bold", 14))
lbl2.grid(column=1, row=7) 
lbl_p2 = Label(window, text="p=", font=("Arial Bold", 12), width=3)
lbl_p2.grid(column=0, row=8) 
txt_p2 = Entry(window, width=78)  
txt_p2.insert(0, "57896044618658097711785492504343953926634992332820282019728792003956564821041")
txt_p2.grid(column=1, row=8)
lbl_a2 = Label(window, text="a=", font=("Arial Bold", 12), width=3)
lbl_a2.grid(column=0, row=9) 
txt_a2 = Entry(window, width=78)  
txt_a2.insert(0, "7")
txt_a2.grid(column=1, row=9)
lbl_b2 = Label(window, text="b=", font=("Arial Bold", 12), width=3)
lbl_b2.grid(column=0, row=10) 
txt_b2 = Entry(window, width=78)  
txt_b2.insert(0, "43308876546767276905765904595650931995942111794451039583252968842033849580414")
txt_b2.grid(column=1, row=10)
lbl_x2 = Label(window, text="x=", font=("Arial Bold", 12), width=3)
lbl_x2.grid(column=0, row=11) 
txt_x2 = Entry(window, width=78)  
txt_x2.insert(0, "2")
txt_x2.grid(column=1, row=11)
lbl_y2 = Label(window, text="y=", font=("Arial Bold", 12), width=3)
lbl_y2.grid(column=0, row=12) 
txt_y2 = Entry(window, width=78)  
txt_y2.insert(0, "4018974056539037503335449422937059775635739389905545080690979365213431566280")
txt_y2.grid(column=1, row=12)
lbl_q2= Label(window, text="q=", font=("Arial Bold", 12), width=3)
lbl_q2.grid(column=0, row=13) 
txt_q2 = Entry(window, width=78)  
txt_q2.insert(0, "57896044618658097711785492504343953927082934583725450622380973592137631069619")
txt_q2.grid(column=1, row=13)
btn = Button(window, text="РАССЧИТАТЬ", command=clicked)
btn.grid(column=1, row=14)
lbl_public_key = Label(window, text="Public key", font=("Arial Bold", 12), width=8)
txt_public_key = Text(window, width=78, height=5)
lbl_public_key.grid(column=2, row=14)
txt_public_key.grid(column=3, row=14)
lbl_message2 = Label(window, text="message=", font=("Arial Bold", 12), width=8)
lbl_message2.grid(column=2, row=9) 
txt_message2 = Text(window, height=3, width=50)  
txt_message2.grid(column=3, row=9)
btn3 = Button(window, text="Найти файл...", command=clicked3)
btn3.grid(column=3, row=7)
txt_path2 = Entry(window, width=78)  
txt_path2.grid(column=3, row=8) 
lbl_q_x = Label(window, text="q_x=", font=("Arial Bold", 12), width=5)
lbl_q_x.grid(column=2, row=10) 
txt_q_x = Entry(window, width=78)  
txt_q_x.insert(0, "57520216126176808443631405023338071176630104906313632182896741342206604859403")
txt_q_x.grid(column=3, row=10)
lbl_q_y = Label(window, text="q_y=", font=("Arial Bold", 12), width=5)
lbl_q_y.grid(column=2, row=11) 
txt_q_y = Entry(window, width=78)  
txt_q_y.insert(0, "17614944419213781543809391949654080031942662045363639260709847859438286763994")
txt_q_y.grid(column=3, row=11)
window.mainloop()