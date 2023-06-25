import threading
import socket

def client(sock):
    while True:
        message = input()
        sock.send(message.encode())

def server(conn):
    while True:
        data = conn.recv(1024)
        if not data: 
            break
        print("Полученно!")

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
sock1 = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
host = "192.168.2.33"
port = 12345

sock.bind((host, port))
sock.listen(1)
sock1.connect((host, port))
conn, addr = sock.accept()
print('connected: ', addr)
socket_thread = threading.Thread(target=server, args=(conn, ))
socket1_thread = threading.Thread(target=client, args=(sock1, ))
socket_thread.start()
socket1_thread.start()