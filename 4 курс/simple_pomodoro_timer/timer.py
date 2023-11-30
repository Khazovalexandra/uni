import time
from tkinter import *

def clicked():
    current_value = int(spin.get())
    for i in range(current_value):
        lbl1.configure(text="Время работы")
        t = 25*60
        while t:
            mins = t // 60
            sec = t % 60
            timer = '{:02d}:{:02d}'.format(mins, sec)
            lbl.configure(text=str(timer))  
            window.update()
            time.sleep(1)
            t-=1
        lbl1.configure(text="Время перерыва")
        t = 5*60
        while t:
            window.config(background="#3cb371")
            txt.config(background="#3cb371")
            btn.config(background="#b3e3ba")
            spin.config(background="#b3e3ba")
            lbl1.config(background="#3cb371")
            lbl.config(background="#3cb371")
            mins = t // 60
            sec = t % 60
            timer = '{:02d}:{:02d}'.format(mins, sec)
            lbl.configure(text=str(timer)) 
            window.update() 
            time.sleep(1)
            t-=1
        lbl1.configure(text="Время работы")
    lbl1.configure(text="ВРЕМЯ ВЫШЛО!")
    window.config(background="#5e5e5e")
    txt.config(background="#5e5e5e")
    btn.config(background="#a3acad")
    spin.config(background="#a3acad")
    lbl1.config(background="#5e5e5e")
    lbl.config(background="#5e5e5e")

window = Tk()
window.title("Помидоро таймер")
window.geometry('300x150')
window.config(background="#ccb3e6")
txt = Label(window, text="Выберите сколько раз повторять таймер: ", font=("Arial Bold", 10), background="#ccb3e6")  
txt.grid(column=0, row=0) 
spin = Spinbox(window, from_=1, to=10, width=2, background="#ede1ed")  
spin.grid(column=1, row=0)
btn = Button(window, text="Запустить таймер", command=clicked, background="#ede1ed")
btn.grid(column=0, row=1) 
lbl = Label(window, text="", font=("Arial Bold", 20), background="#ccb3e6")  
lbl.grid(column=0, row=2) 
lbl1 = Label(window, text="", font=("Arial Bold", 20), background="#ccb3e6")  
lbl1.grid(column=0, row=3) 
window.attributes('-topmost', True)
window.mainloop()