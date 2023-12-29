import pandas as pd
import seaborn as sns
import matplotlib.pyplot as plt
import numpy as np

df = pd.DataFrame(pd.read_excel(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\test4.xlsx'))
print(df)
df2 = df.iloc[:, 1:]
df2.plot()
plt.show()

df_section = pd.DataFrame(df.iloc[:, 0], index=None)
podpis = list(df_section['Unnamed: 0'])
df.index = podpis
df_posl = pd.DataFrame(data=df.iloc[:,1:4])
df_posl.plot(title='Последовательный код', figsize=(9,7))
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\Time_posl')
df_TPL = df.iloc[:,7:10]
df_Pool = df.iloc[:, 4:7]
print(df_posl)

df_TPL.plot(title='Параллельный TPL', figsize=(9,7))
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\Time_TPL')

df_Pool.plot(title='Параллельный Pool потоков', figsize=(9,7))
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\Time_Pool')

#Ускорение TPL относительно последовательного
df_S_TPL = pd.DataFrame()
df_S_TPL.index = podpis

for i in df_TPL:
    ind = i[7:8]
    df_S=pd.DataFrame(list(map(lambda x, y: x / y, df_posl[f'Последовательно на {ind} ядер'], df_TPL[i])))
    df_S.index = podpis
    df_S_TPL[f'Ускорение для {ind} ядер']=df_S

print(df_S_TPL)

ax = df_S_TPL.plot(title='Ускорение TPL', figsize=(9,7))
plt.legend(loc='best', fontsize=9)
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\S_TPL')

#Ускорение Pool относительно последовательного
df_S_Pool = pd.DataFrame()

for i in df_Pool:
    ind1 = i[8:9]
    df_S=pd.Series(list(map(lambda x, y: x / y, df_posl[f'Последовательно на {ind1} ядер'], df_Pool[i])))
    df_S.index = podpis
    df_S_Pool[f'Ускорение для {ind1} ядер']=df_S
    df_S_Pool.index = podpis

print(df_S_Pool)

ax = df_S_Pool.plot(title='Ускорение Pool', figsize=(9,7))
plt.legend(loc='best', fontsize=9)
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\S_Pool')

#Величина эффективности определяет среднюю долю времени выполнения параллельного алгоритма,
#в течение которого процессоры реально используются для решения задачи

#Эффективность TPL
df_E_TPL = pd.DataFrame()

for i in df_S_TPL:
    ind = i[14:15]
    df_E=pd.Series(list(map(lambda x: x / float(ind), df_S_TPL[f'Ускорение для {ind} ядер'])))
    df_E.index = podpis
    df_E_TPL[f'Эффективность для {ind} ядер']=df_E
    df_E_TPL.index = podpis

print(df_E_TPL)

ax = df_E_TPL.plot(title='Эффективность TPL', figsize=(9,7))
plt.legend(loc='best', fontsize=9)
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\E_TPL')

#Эффективность Pool
df_E_Pool = pd.DataFrame()

for i in df_S_Pool:
    ind = i[14:15]
    df_E=pd.Series(list(map(lambda x: x / float(ind), df_S_Pool[f'Ускорение для {ind} ядер'])))
    df_E.index = podpis
    df_E_Pool[f'Эффективность для {ind} ядер']=df_E
    df_E_Pool.index = podpis

print(df_E_Pool)

ax = df_E_Pool.plot(title='Эффективность Pool', figsize=(9,7))
plt.legend(loc='best', fontsize=9)
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\E_Pool')

#Стоимость TPL
df_С_TPL = pd.DataFrame()

for i in df_TPL:
    ind = i[7:8]
    df_С=pd.Series(list(map(lambda x: x * float(ind), df_TPL[i])))
    df_С.index = podpis
    df_С_TPL[f'Стоимость для {ind} ядер']=df_С
    df_С_TPL.index = podpis

print(df_С_TPL)

ax = df_С_TPL.plot(title='Стоимость TPL', figsize=(9,7))
plt.legend(loc='best', fontsize=9)
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\C_TPL')

#Стоимость Pool
df_C_Pool = pd.DataFrame()

for i in df_Pool:
    ind = i[8:9]
    df_C=pd.Series(list(map(lambda x: x * float(ind), df_Pool[i])))
    df_C.index = podpis
    df_C_Pool[f'Стоимость для {ind} ядер']=df_C
    df_C_Pool.index = podpis

print(df_C_Pool)

ax = df_С_TPL.plot(title='Стоимость Pool', figsize=(9,7))
plt.legend(loc='best', fontsize=9)
plt.xticks(ticks=podpis, labels=podpis, rotation=40)
#plt.show()
plt.savefig(r'C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\C_Pool')

#сохранение расчетов в Excel
with pd.ExcelWriter(r"C:\Users\admin\Desktop\майн\ННГАСУ\superparalel_zip\my\res.xlsx", mode='a') as writer:
    df_S_Pool.to_excel(writer, sheet_name='S_Pool')

    df_S_TPL.to_excel(writer, sheet_name='S_TPL')

    df_E_Pool.to_excel(writer, sheet_name='E_Pool')

    df_E_TPL.to_excel(writer, sheet_name='E_TPL')