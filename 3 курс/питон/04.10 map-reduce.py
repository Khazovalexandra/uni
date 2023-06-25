data_ = []
for l in open(r'C:\Users\Сергей\Documents\flavors_of_cacao.csv', 'r').readlines()[1:]:
    data_.append(l.split(',')[5])
data1= []
for i in open(r'C:\Users\Сергей\Documents\flavors_of_cacao_2.csv', 'r').readlines()[1:]:
    data1.append(i.split(',')[5])
res = []
res = data1 + data_

data = list(map(lambda x: (x, 1), res))

data.sort()

i = 0
d2 = {}
while i < len(res):
    d2[res[i]] = data.count(data[i])
    i += data.count(data[i])
print(data)
