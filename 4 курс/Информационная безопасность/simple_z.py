m = int(input("Мощность перестановки по алфавиту(k): "))
first_str = input("Введите строку для шифрования: ").split()
str, d_str = '', ''

# al = [chr(1040 + i) for i in range(32)]
# print(al)

for j in first_str:
    for k in j:
        if k.isalpha() and k.islower():
            str += chr((ord(k) - 1072 + m) % 32 + 1072)
        elif k.isalpha() and k.isupper():
            str += chr((ord(k) - 1040 + m) % 32 + 1040)
        else:
            str += k
            
    str += ' '

str = str.rstrip(' ')
                 
print("Шифрование: "+str)

for d_j in str.split():
    for d_k in d_j:
        if d_k.isalpha() and d_k.islower():
            d_str += chr((ord(d_k) - 1072 - m) % 32 + 1072)
        elif d_k.isalpha() and d_k.isupper():
            d_str += chr((ord(d_k) - 1040 - m) % 32 + 1040)
        else:
            d_str += d_k
            
    d_str += ' '

d_str = d_str.rstrip(' ')

print("Дешифрование: "+d_str)