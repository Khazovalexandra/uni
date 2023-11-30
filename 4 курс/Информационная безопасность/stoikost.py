import random
from tkinter import *
from math import floor, ceil
from tkinter import scrolledtext 

# Стойкость парольных систем 
# Дано: вероятность Р - 10**(-5)
# скорость V - 11 паролей/минуту, 
# время T - 20 дней
# Найти:
# А - мощность пароля
# L - минимальную длину пароля
# после получения L сгенерировать N паролей(вводит пользователей с клавиатуры)

p, v, t = 10**(-5), 11, 20
str_a = 'abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ!#$%&*+-=?@^_АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЭЮЯабвгдеёжзийклмнопрстуфхцчшщьъыэюя'

def generate_password(l, a):
    password = ''
    for _ in range(l):
        password += random.choice(a)
    return password

def clicked():
    
    p, v, t = float(txt1.get()), int(txt2.get()), int(txt3.get())

    s = floor((v*t)/p)

    print(s)
    lbl5 = Label(window, text=str(s), font=("Arial Bold", 12), background='#fbceb1')
    lbl5.grid(column=1, row=6)

    pwd_quantity = int(txt_v.get())
    if not 1<pwd_quantity<10000:
        print('Таково не может быть...')

    pas=''
    l = int(txt_l.get())
    a = pow(s,1/l)
    print(a)
    txt = scrolledtext.ScrolledText(window, width=l+1, height=(pwd_quantity%10))  
    txt.grid(row=8)

    res = f'Мощность = {a}, символов, длина = {l}'
    lbl_res = Label(window, font=("Arial Bold", 15), background='#fbceb1')
    lbl_res.grid(row=7)  
    lbl_res.configure(text=res)
    a  = ceil(a)
    strA = random.sample(str_a, a)
    lbl_A = Label(window, text='Алфавит:', font=("Arial Bold", 15), background='#fbceb1')
    lbl_A.grid(row=7, column = 1) 
    lbl_A = Label(window, text=strA, font=("Arial Bold", 12), background='#fbceb1')
    lbl_A.grid(row=7, column = 2)  
    print(strA)
    for i in range(pwd_quantity):
        pas += generate_password(l, strA)
        pas += ' '
    print(*pas.split(), sep='\n')
    txt.insert('end', pas)    

window = Tk()
window.title("Генератор паролей")
window['background']='#fbceb1'

lbl_v = Label(window, text="Сколько паролей вам нужно сгенерировать?", font=("Arial Bold", 15), background='#fbceb1')
lbl_v.grid(row=0)
txt_v = Entry(window, width=20)  
txt_v.grid(row=1)  

lbl1 = Label(window, text="Вероятность Р = ", font=("Arial Bold", 12), background='#fbceb1')
lbl1.grid(column=0, row=2)  
txt1 = Entry(window, width=12)  
txt1.grid(column=1, row=2)  
txt1.insert(0, "0.00001")

lbl2 = Label(window, text="Скорость V = ", font=("Arial Bold", 12), background='#fbceb1')
lbl2.grid(column=0, row=3) 
txt2 = Entry(window, width=12)  
txt2.grid(column=1, row=3)
lbl2_2 = Label(window, text=" паролей/минуту", font=("Arial Bold", 12), background='#fbceb1')
lbl2_2.grid(column=2, row=3)
txt2.insert(0, "11")

lbl3 = Label(window, text="Время T = ", font=("Arial Bold", 12), background='#fbceb1')
lbl3.grid(column=0, row=4) 
txt3 = Entry(window, width=12)  
txt3.grid(column=1, row=4)
lbl3_3 = Label(window, text="дней", font=("Arial Bold", 12), background='#fbceb1')
lbl3_3.grid(column=2, row=4)
txt3.insert(0, "20")

btn = Button(window, text="РАССЧИТАТЬ", command=clicked)
btn.grid(column=0, row=6)
lbl4 = Label(window, text="Нижняя граница количества паролей", font=("Arial Bold", 12), background='#fbceb1')
lbl4.grid(column=0, row=7)

lbl_l = Label(window, text="Выбирите длину пароля", font=("Arial Bold", 12), background='#fbceb1')
lbl_l.grid(column=0, row=5) 
txt_l = Entry(window, width=12)  
txt_l.grid(column=1, row=5)

window.mainloop()