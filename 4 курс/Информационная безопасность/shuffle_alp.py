import random

print("Реализация шифра простой замены")

alp = [chr(1040 + i) for i in range(32*2)]
sh_alp = [chr(1040 + i) for i in range(32*2)]
random.shuffle(sh_alp)
print("Изначальный алфавит")
print(*alp)
print("Кодируемый алфавит")
print(*sh_alp)

def shifr(first_str, sh_alp):
    str = ''
    for j in first_str:
        for k in j:
            if k.isalpha() and k.islower():
                str += sh_alp[(ord(k) - 1040) % 64]
            elif k.isalpha() and k.isupper():
                str += sh_alp[(ord(k) - 1040) % 64]
            else:
                str += k
                
        str += ' '

    str = str.rstrip(' ')
    print("Шифрование: "+str)
    return str

def deshifr(str, alp):
    d_str = ''
    for d_j in str:
        for d_k in d_j:
            if d_k.isalpha() and d_k.islower():
                d_str += alp[sh_alp.index(d_k)]
            elif d_k.isalpha() and d_k.isupper():
                d_str += alp[sh_alp.index(d_k)]
            else:
                d_str += d_k
                
        d_str += ' '

    d_str = d_str.rstrip(' ')

    print("Дешифрование: "+d_str)

while True:
    first_str = input("Введите строку: ").split()
    inp = input("Провести шифрование введенной строки?(Да/да/ДА/1/д/Д) ") 
    if inp == 'ДА' or inp == 'Да' or inp == 'да' or inp == '1' or inp == 'д' or inp == 'Д':
        shifr(first_str=first_str, sh_alp=sh_alp)
    else:
        inp1 = input("Провести дешифрование данной строки?(Да/да/ДА/1/д/Д) ")
        if inp1 == 'ДА' or inp1 == 'Да' or inp1 == 'да' or inp1 == '1' or inp1 == 'д' or inp1 == 'Д':
            deshifr(str=first_str, alp=alp)

    the_end = input("Ввести еще слово? ")
    if  the_end == 'ДА' or the_end == 'Да' or the_end == 'да' or the_end == '1' or the_end == 'д' or the_end == 'Д':
        continue
    else:
        break