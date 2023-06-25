import socket
import threading

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock1 = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
host = "192.168.2.35"
port = 12345
sock.connect((host, port))

def send(sock):
    while True:
        message = input()
        sock.send(message.encode())

def listen(sock):
    # sock.bind((host, port))
    # conn, addr = sock.accept()
    # sock.listen(1)
    while True:
        data = sock.recv(1024)
        print(data.decode("utf-8"))

t = threading.Thread(target=send,args=(sock,))
#t1 = threading.Thread(target=listen,args=(sock1,))
t.start()
#t1.start()
listen(sock)
sock.close()