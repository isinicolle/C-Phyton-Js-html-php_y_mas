import tkinter as tk
from tkinter import filedialog
import os.path

#ejercicio que muestra una ventana de dialogo para seleccionar un archivo y muestra el contenido del archivo
def ejercicio1():
    root = tk.Tk()
    root.withdraw()
    file_path = filedialog.askopenfilename()
    if os.path.isfile(file_path):
        with open(file_path, 'r') as f:
            print(f.read())
    else:
        print("No se ha seleccionado ningun archivo")   #si no se selecciona ningun archivo se muestra este mensaje en pantalla


#funcion que sume los numeros de una lista
def ejercicio2():
    lista = [1,2,3,4,5,6,7,8,9,10]
    suma = 0
    for i in lista:
        suma += i
    print(suma)


#ingresar el nombre y edad de una persona a un arreglo y mostrarlo en pantalla
def ejercicio3():
    nombre = input("Ingrese su nombre: ")
    edad = int(input("Ingrese su edad: "))
    persona = [nombre, edad]
    print(persona)

#mostrar en que posicion del arreglo se encuentra una persona 
def ejercicio4():
    nombre = input("Ingrese su nombre: ")
    edad = int(input("Ingrese su edad: "))
    persona = [nombre, edad]
    lista = [persona, persona, persona, persona, persona]
    for i in lista:
        if i == persona:
            print(lista.index(i))

#borrar un elemento de un arreglo por su posicion
def ejercicio5():
    lista = [1,2,3,4,5,6,7,8,9,10]
    lista.pop(5)
    print(lista)

#pedirle al usuario que ingrese el nombre y posicion del arreglo de la persona a eliminar cuando se borre mostrar un mensaje que diga que se a borrado con exito o que no se encontro la persona
def ejercicio6():
    nombre = input("Ingrese su nombre: ")
    edad = int(input("Ingrese su edad: "))
    persona = [nombre, edad]
    lista = [persona, persona, persona, persona, persona]
    for i in lista:
        if i == persona:
            lista.remove(i)
            print("Se a borrado con exito")
            break
    else:
        print("No se encontro la persona")



#reservar las habitaciones de un hotel y mostrar en pantalla el numero de habitaciones disponibles el hotel debe tener 5 pisos y por cada piso 7 habitaciones cada habitacion tiene un numero de habitacion utilizar una matriz , el indice de la matriz determina el numero de habitacion y el valor de la matriz determina el numero de piso y el numero de habitacion al final mostrar en pantalla el numero de habitaciones disponibles y el numero de habitaciones ocupadas
def ejercicio7():
    hotel = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
    for i in hotel:
        for j in i:
            if j == 0:
                print("Habitacion disponible")
            else:
                print("Habitacion ocupada")


#reservar habitacion del hotel pedirle al usuario que ingrese el numero de habitacion a reservar y mostrar en pantalla el numero de habitaciones disponibles y el numero de habitaciones ocupadas , cada habitacion se va registrar con el nombre del usuario
def ejercicio8():
    hotel = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
    for i in hotel:
        for j in i:
            if j == 0:
                print("Habitacion disponible")
            else:
                print("Habitacion ocupada")
    numero = int(input("Ingrese el numero de habitacion a reservar: "))
    if numero > 0 and numero < 6:
        hotel[numero-1][0] = 1
        for i in hotel:
            for j in i:
                if j == 0:
                    print("Habitacion disponible")
                else:
                    print("Habitacion ocupada")
    else:
        print("Numero de habitacion no valido")


#reservar habitacion de un hotel pedirle al usuario que ingrese un numero , si la habitacion se encuentra disponible pedirle que registre su nombre en caso contrario pedirle que elija otra habitacion
def ejercicio9():
    hotel = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
    for i in hotel:
        for j in i:
            if j == 0:
                print("Habitacion disponible")
            else:
                print("Habitacion ocupada")
    numero = int(input("Ingrese el numero de habitacion a reservar: "))
    if numero > 0 and numero < 6:
        hotel[numero-1][0] = 1
        for i in hotel:
            for j in i:
                if j == 0:
                    print("Habitacion disponible")
                else:
                    print("Habitacion ocupada")
    else:
        print("Numero de habitacion no valido")   #si el numero de habitacion no es valido se muestra este mensaje en pantalla


#mostrarle al usuario cual habitacion reservo y el nombre de quien la reservo
def ejercicio10():
    hotel = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
    for i in hotel:
        for j in i:
            if j == 0:
                print("Habitacion disponible")
            else:
                print("Habitacion ocupada")
    numero = int(input("Ingrese el numero de habitacion a reservar: "))
    if numero > 0 and numero < 6:
        hotel[numero-1][0] = 1
        for i in hotel:
            for j in i:
                if j == 0:
                    print("Habitacion disponible")
                else:
                    print("Habitacion ocupada")
    else:
        print("Numero de habitacion no valido")   #si el numero de habitacion no es valido se muestra este mensaje en pantalla


#darle la facturacion delos clientes de su habitacion , si ellos se ubican de la habitacion 00 a la 10 cobrarles 100$ m si se ubican de la habitacion 10 a la 20 cobrarles 200$ m si se ubican de la habitacion 20 a la 30 cobrarles 300$ m si se ubican de la habitacion 30 a la 40 cobrarles 400$ m si se ubican de la habitacion 40 a la 50 cobrarles 500$ m si se ubican de la habitacion 50 a la 60 cobrarles 600$ m si se ubican de la habitacion 60 a la 70 cobrarles 700$ m si se ubican de la habitacion 70 a la 80 cobrarles 800$ m si se ubican de la habitacion 80 a la 90 cobrarles 900$ m si se ubican de la habitacion 90 a la 100 cobrarles 1000$ m si se ubican de la habitacion 100 a la 110 cobrarles 1100$ m si se ubican de la habitacion 110 a la 120 cobrarles 1200$ m si se ubican de la habitacion 120 a la 130 cobrarles 1300$ m si se ubican de la habitacion 130 a la 140 cobrarles 1400$ m si se ubican de la habitacion 140 a la 150 cobrarles 1500$ m si se ubican de la habitacion 150 a la 160 cobrarles 1600$ m si se ubican de la habitacion 160 a la 170 cobrarles 1700$ m si se ubican de la habitacion 170 a la 180 cobrarles 1800$ m si se ubican de la habitacion 180 a la 190 cobrarles 1900$ m si se ubican de la habitacion 190 a la 200 cobrarles 2000$ m si se ubican de la habitacion 200 a la 210 cobrarles 2100$ m si se ubican de la habitacion 210 a la 220 cobrarles 2200$ m si se ubican de la habitacion 220 a la 230 cobrarles 2300$ m si se ubican de la habitacion 230 a la 240 cobrarles 2400$ m si se ubican de la habitacion 240 a la 250 cobrarles 2500$ m si se ubican de la habitacion 250 a la 260 cobrarles 2600$ m si se ubican de la habitacion 260 a la 270 cobrarles 2700$ m si se ubican de la habitacion 270 a la 280 cobrarles 2800$ m si se ubican de la habitacion 280 a la 290 cobrarles 29 al momento de facturar se le pide la edad del cliente , darle descuento si es adulto mayor de 60 
def ejercicio11(): #si el numero de habitacion no es valido se muestra este mensaje en pantalla
    hotel = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
    for i in hotel:
        for j in i:
            if j == 0:
                print("Habitacion disponible")
            else:
                print("Habitacion ocupada")
    numero = int(input("Ingrese el numero de habitacion a reservar: "))
    if numero > 0 and numero < 6: 
        hotel[numero-1][0] = 1
        for i in hotel:
            for j in i:
                if j == 0:
                    print("Habitacion disponible")
                else:
                    print("Habitacion ocupada") 
    else:
        print("Numero de habitacion no valido")
    edad = int(input("Ingrese la edad del cliente: ")) #si el numero de habitacion no es valido se muestra este mensaje en pantalla
    if edad > 60:
        print("Descuento de 20%")
    else:
        print("No tiene descuento")

#con el ejercicio anterior mostrarle el total a pagar al cliente restarle descuento en caso de tenerlo el resultado almacenar en una variable y mostrarle el total a pagar
def ejercicio12():
    hotel = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
    for i in hotel:
        for j in i:
            if j == 0:
                print("Habitacion disponible")
            else:
                print("Habitacion ocupada")
    numero = int(input("Ingrese el numero de habitacion a reservar: "))
    if numero > 0 and numero < 6:
        hotel[numero-1][0] = 1
        for i in hotel:
            for j in i:
                if j == 0:
                    print("Habitacion disponible")
                else:
                    print("Habitacion ocupada")
    else:
        print("Numero de habitacion no valido")   #si el numero de habitacion no es valido se muestra este mensaje en pantalla
    edad = int(input("Ingrese la edad del cliente: "))
    if edad > 60:
        print("Descuento de 20%")
    else:
        print("No tiene descuento")
    total = int(input("Ingrese el total a pagar: "))
    if edad > 60:
        total = total - (total * 0.2)
        print("El total a pagar es: ", total)
    else:
        print("El total a pagar es: ", total)

#el total a pagar dependera de la posicion de la habitacion en la matriz , el precio sera el numero de la matriz agregandole 00 al final (dos ceros)
def ejercicio13():
    hotel = [[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0],[0,0,0,0,0]]
    for i in hotel:
        for j in i:
            if j == 0:
                print("Habitacion disponible")
            else:
                print("Habitacion ocupada")
    numero = int(input("Ingrese el numero de habitacion a reservar: "))
    if numero > 0 and numero < 6:
        hotel[numero-1][0] = 1
        for i in hotel:
            for j in i:
                if j == 0:
                    print("Habitacion disponible")
                else:
                    print("Habitacion ocupada")
    else:
        print("Numero de habitacion no valido")   #si el numero de habitacion no es valido se muestra este mensaje en pantalla
    edad = int(input("Ingrese la edad del cliente: "))
    if edad > 60:
        print("Descuento de 20%")
    else:
        print("No tiene descuento")
    total = 0
    if numero == 1:
        total = total + 100
        print("El total a pagar es: ", total)
    elif numero == 2:
        total = total + 200
        print("El total a pagar es: ", total)
    elif numero == 3:
        total = total + 300
        print("El total a pagar es: ", total)
    elif numero == 4:
        total = total + 400
        print("El total a pagar es: ", total)
    elif numero == 5:
        total = total + 500
        print("El total a pagar es: ", total)
    if edad > 60:
        total = total - (total * 0.2)
        print("El total a pagar es: ", total)
    else:
        print("El total a pagar es: ", total)






 



