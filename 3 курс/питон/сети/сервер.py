import socket
import threading

sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
host = "192.168.2.35"
port = 12345

sock.bind((host, port))
sock.listen(1)
conn, addr = sock.accept()
print('connected: ', addr)

def client_listen(conn):
    while True:
        data = conn.recv(1024).decode()
        if not data: 
            break
        conn.sendall(("Получено!").encode("utf-8"))
        print(data)
     
#client_listen(conn)
t = threading.Thread(target=client_listen,args=(conn,))
t.start()

sock.close()