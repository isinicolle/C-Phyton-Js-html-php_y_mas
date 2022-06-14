from collections import abc
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


#un centro de votacion tiene 3 canditados , cada candidato tiene un numero de votos mostrar el numero de votos de cada candidato de mayor a menor y almacenarlos en un archivo mostrar el resultado en pantalal con una tabla
def ejercicio14():
    votos = [0,0,0]
    for i in votos:
        print(i)
    votos[0] = int(input("Ingrese el numero de votos del candidato 1: "))
    votos[1] = int(input("Ingrese el numero de votos del candidato 2: "))
    votos[2] = int(input("Ingrese el numero de votos del candidato 3: "))
    for i in votos:
        print(i)
    with open("votos.txt", "w") as archivo:
        for i in votos:
            archivo.write(str(i) + "\n")
    with open("votos.txt", "r") as archivo:
        for i in archivo:
            print(i)
    votos.sort()
    print("El candidato 1 tiene: ", votos[2])
    print("El candidato 2 tiene: ", votos[1])
    print("El candidato 3 tiene: ", votos[0])

#almacenar en una clase llamada persona el nombre ,apellido  y edad del usuario utilizando poo
def ejercicio15():
    class Persona:
        def __init__(self, nombre, apellido, edad):
            self.nombre = nombre
            self.apellido = apellido
            self.edad = edad
        def mostrar(self):
            print("Nombre: ", self.nombre)
            print("Apellido: ", self.apellido)
            print("Edad: ", self.edad)
    nombre = input("Ingrese el nombre: ")
    apellido = input("Ingrese el apellido: ")
    edad = int(input("Ingrese la edad: "))
    persona = Persona(nombre, apellido, edad)
    persona.mostrar()

#el usuario le aparece en pantalla elegir entra la opcion 1 y 2 si elige la opcion 1 escoge amarillo si elige la opcion 2 escoge rojo segun la clase seleccionada el usuario llenara sus datos para una nueva clase , la clase amarillo va heredar de la clase persona y la clase rojo va heredar de la clase persona , la clase amarillo tiene un atributo llamado color que va a ser amarillo y la clase rojo tiene un atributo llamado color que va a ser rojo
def ejercicio16():
    class Persona:
        def __init__(self, nombre, apellido, edad):
            self.nombre = nombre
            self.apellido = apellido
            self.edad = edad
        def mostrar(self):
            print("Nombre: ", self.nombre)
            print("Apellido: ", self.apellido)
            print("Edad: ", self.edad)
    class Amarillo(Persona):
        def __init__(self, nombre, apellido, edad, color):
            super().__init__(nombre, apellido, edad)
            self.color = color
        def mostrar(self):
            print("Nombre: ", self.nombre)
            print("Apellido: ", self.apellido)
            print("Edad: ", self.edad)
            print("Color: ", self.color)
    class Rojo(Persona):
        def __init__(self, nombre, apellido, edad, color):
            super().__init__(nombre, apellido, edad)
            self.color = color
        def mostrar(self):
            print("Nombre: ", self.nombre)
            print("Apellido: ", self.apellido)
            print("Edad: ", self.edad)
            print("Color: ", self.color)
    nombre = input("Ingrese el nombre: ")
    apellido = input("Ingrese el apellido: ")
    edad = int(input("Ingrese la edad: "))
    color = input("Ingrese el color: ")
    persona = Persona(nombre, apellido, edad)
    amarillo = Amarillo(nombre, apellido, edad, color)
    rojo = Rojo(nombre, apellido, edad, color)
    opcion = int(input("Ingrese la opcion: "))
    if opcion == 1:
        amarillo.mostrar()
    elif opcion == 2:
        rojo.mostrar()

#crear una base de datos sqlite3 con una tabla llamada persona con los atributos nombre , apellido y edad 
def ejercicio17():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""CREATE TABLE persona(
        nombre text,
        apellido text,
        edad integer
        )""")
    conexion.commit()
    conexion.close()


#en la base de datos almacenar la informacion que se almaceno en la clase persona del ejercicio16
def ejercicio18():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    nombre = input("Ingrese el nombre: ")
    apellido = input("Ingrese el apellido: ")
    edad = int(input("Ingrese la edad: "))
    cursor.execute("""INSERT INTO persona VALUES(?,?,?)""", (nombre, apellido, edad))
    conexion.commit()
    conexion.close()


#mostrar la informacion almacenada en la base de datos
def ejercicio19():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""SELECT * FROM persona""")
    for i in cursor:
        print(i)
    conexion.close()


#crear en la base de datos persona.db la tabla amarillo y rojo y almacenar la informacion de las clases heredadas del ejercicio 16
def ejercicio20():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""CREATE TABLE amarillo(
        nombre text,
        apellido text,
        edad integer,
        color text
        )""")
    cursor.execute("""CREATE TABLE rojo(
        nombre text,
        apellido text,
        edad integer,
        color text
        )""")
    conexion.commit()
    conexion.close()

#guardar informacion almacenada en la base de datos en la tabla persona
def ejercicio21():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""INSERT INTO persona VALUES(?,?,?)""", (nombre, apellido, edad))
    conexion.commit()
    conexion.close()

#actualizar la informacion almacenada en la base de datos
def ejercicio22():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""UPDATE persona SET nombre = 'Juan' WHERE nombre = 'Juan'""")
    conexion.commit()
    conexion.close()

#eliminar la informacion almacenada en la base de datos
def ejercicio23():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""DELETE FROM persona WHERE nombre = 'Juan'""")
    conexion.commit()
    conexion.close()

#buscar la informacion almacenada en la base de datos segun el nombre 
def ejercicio24():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""SELECT * FROM persona WHERE nombre = 'Juan'""")
    for i in cursor:
        print(i)
    conexion.close()

#eliminar todos los registros de la tabla de la base de datos
def ejercicio25():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""DELETE FROM persona""")
    conexion.commit()
    conexion.close()

#instancia de conexion de una base de datos en AWS
def ejercicio26():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""CREATE TABLE persona(
        nombre text,
        apellido text,
        edad integer
        )""")
    conexion.commit()
    conexion.close()

#borrar base de datos
def ejercicio27():
    import sqlite3
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""DROP TABLE persona""")
    conexion.commit()
    conexion.close()

#guardar en un arreglo numero de telefono y nombre de persona
def ejercicio28():
    persona = []
    nombre = input("Ingrese el nombre: ")
    telefono = int(input("Ingrese el telefono: "))
    persona.append(nombre)
    persona.append(telefono)
    return persona


#pedir la cantidad de personas que desea ingresar y guardar la informacion en un arreglo e imprimir la informacion
def ejercicio29():
    persona = []
    cantidad = int(input("Ingrese la cantidad de personas: "))
    for i in range(cantidad):
        nombre = input("Ingrese el nombre: ")
        telefono = int(input("Ingrese el telefono: "))
        persona.append(nombre)
        persona.append(telefono)
    return persona


#convertir a json la informacion almacenada en el arreglo
def ejercicio30():
    import json
    persona = []
    cantidad = int(input("Ingrese la cantidad de personas: "))
    for i in range(cantidad):
        nombre = input("Ingrese el nombre: ")
        telefono = int(input("Ingrese el telefono: "))
        persona.append(nombre)
        persona.append(telefono)
    return json.dumps(persona)

#la informacion del json utilizar el metodo , get,post y put para llevar la informacion a la base de datos
def ejercicio31():
    import sqlite3
    import json
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""CREATE TABLE persona(
        nombre text,
        apellido text,
        edad integer
        )""")
    conexion.commit()
    conexion.close()
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""INSERT INTO persona VALUES(?,?,?)""", (nombre, apellido, edad))
    conexion.commit()
    conexion.close()
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""SELECT * FROM persona""")
    for i in cursor:
        print(i)
    conexion.close()
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()
    cursor.execute("""DELETE FROM persona""")
    conexion.commit()
    conexion.close()
    conexion = sqlite3.connect("persona.db")
    cursor = conexion.cursor()

    #mostrar las peticiones que se han hecho a la base de datos
    def ejercicio32():
        import sqlite3
        conexion = sqlite3.connect("persona.db")
        cursor = conexion.cursor()
        cursor.execute("""SELECT * FROM persona""")
        for i in cursor:
            print(i)
        conexion.close()

#por medio de una peticion con api rest mostrar la informacion de la base de datos
def ejercicio33():
    import requests
    url = "http://localhost:5000/persona"
    response = requests.get(url)
    print(response.text)


#por medio de una peticion con api rest agregar la informacion de la base de datos
def ejercicio34():
    import requests
    url = "http://localhost:5000/persona"
    response = requests.post(url, data={"nombre": "Juan", "apellido": "Perez", "edad": "20"})
    print(response.text)

#por medio de una peticion con api rest actualizar la informacion de la base de datos
def ejercicio35():
    import requests
    url = "http://localhost:5000/persona/1"
    response = requests.put(url, data={"nombre": "Juan", "apellido": "Perez", "edad": "20"})
    print(response.text)

#por medio de una peticion con api rest eliminar la informacion de la base de datos
def ejercicio36():
    import requests
    url = "http://localhost:5000/persona/1"
    response = requests.delete(url)
    print(response.text)

#por medio de una peticion con api rest buscar una persona en la base de datos
def ejercicio37():
    import requests
    url = "http://localhost:5000/persona/1"
    response = requests.get(url)
    print(response.text) 


#por medio de una peticion con api rest mostrar las personas de la base de datos en una tabla
def ejercicio38():
    import requests
    url = "http://localhost:5000/persona"
    response = requests.get(url)
    print(response.text)


#funcion que reciba como parametro una lsita de enteros positivos y devuelva el promedio de los numeros y el minimo comun multiplo de todos ellos 
def ejercicio39():
    import math
    lista = []
    cantidad = int(input("Ingrese la cantidad de numeros: "))
    for i in range(cantidad):
        numero = int(input("Ingrese el numero: "))
        lista.append(numero)
    promedio = sum(lista) / len(lista)
    minimo = min(lista)
    maximo = max(lista)
    for i in range(minimo, maximo + 1):
        if i % promedio == 0:
            comun = i
            break
    return promedio, comun


#funcion que reciba como parametro dos palabras e indique si con las letras de la primera palabra se puede formar la segunda palabra
def ejercicio40():
    palabra1 = input("Ingrese la primera palabra: ")
    palabra2 = input("Ingrese la segunda palabra: ")
    if palabra1 == palabra2:
        return True
    else:
        return False

#funcion que reciba como parametro la direccion de un archivo y devuelva la cantidad de lineas que tiene , cuantas letras son mayusculas y cuantas letras son minusculas, cuantas son numeros el resultado almacenarlo en un archivo y mostrarlo en pantalla
def ejercicio41():
    import os
    import re
    import string
    archivo = input("Ingrese la direccion del archivo: ")
    if os.path.exists(archivo):
        contador = 0
        contador_mayusculas = 0
        contador_minusculas = 0
        contador_numeros = 0
        with open(archivo, "r") as archivo:
            for linea in archivo:
                contador += 1
                contador_mayusculas += len(re.findall(r'[A-Z]', linea))
                contador_minusculas += len(re.findall(r'[a-z]', linea))
                contador_numeros += len(re.findall(r'[0-9]', linea))
        with open("resultado.txt", "w") as archivo:
            archivo.write("Cantidad de lineas: " + str(contador) + "\n")
            archivo.write("Cantidad de letras mayusculas: " + str(contador_mayusculas) + "\n")
            archivo.write("Cantidad de letras minusculas: " + str(contador_minusculas) + "\n")
            archivo.write("Cantidad de numeros: " + str(contador_numeros) + "\n")
        print("Cantidad de lineas: " + str(contador))
        print("Cantidad de letras mayusculas: " + str(contador_mayusculas))
        print("Cantidad de letras minusculas: " + str(contador_minusculas))
        print("Cantidad de numeros: " + str(contador_numeros))
    else:
        print("El archivo no existe")

#una funcion llamada combnaciones que recibad e parametro una lista de  almenso 3 caracteres y escriba un archivo todas las posibles combinaciones de tres caracteres que se podrian formar
def ejercicio42():
    import itertools
    lista = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]
    combinaciones = itertools.permutations(lista, 3)
    with open("combinaciones.txt", "w") as archivo:
        for i in combinaciones:
            archivo.write(i[0] + i[1] + i[2] + "\n")

    
#borrar los datos anteriores dejar pantalla vacia
def ejercicio43():
    import os
    os.system("cls")

#haga el programa de la torre de hanoi
def ejercicio44():
    import os
    os.system("cls")
    print("Torre de Hanoi")
    print("1. Ingrese la cantidad de discos")
    print("2. Ingrese la torre de origen")
    print("3. Ingrese la torre de destino")
    print("4. Ingrese la torre de auxiliar")
    print("5. Salir")
    opcion = int(input("Ingrese la opcion: "))
    while opcion != 5:
        if opcion == 1:
            cantidad = int(input("Ingrese la cantidad de discos: "))
            torre1 = []
            torre2 = []
            torre3 = []
            for i in range(cantidad):
                torre1.append(i + 1)
            while len(torre1) != 0:
                if len(torre1) == 1:
                    torre3.append(torre1.pop())
                    torre2.append(torre3.pop())
                elif len(torre1) == 2:
                    torre3.append(torre1.pop())
                    torre3.append(torre1.pop())
                    torre2.append(torre3.pop())
                    torre2.append(torre3.pop())
                elif len(torre1) == 3:
                    torre3.append(torre1.pop())
                    torre3.append(torre1.pop())
                    torre3.append(torre1.pop())
                    torre2.append(torre3.pop())
                    torre2.append(torre3.pop())
                    torre2.append(torre3.pop())
                else:
                    torre3.append(torre1.pop())
                    torre3.append(torre1.pop())
                    torre3.append(torre1.pop())
                    torre2.append(torre3.pop())
                    torre2.append(torre3.pop())
                    torre2.append(torre3.pop())
                    torre3.append(torre1.pop())
                    torre3.append(torre1.pop())
                    torre3.append(torre1.pop())
                    torre2.append(torre3.pop())
                    torre2.append(torre3.pop())
                    torre2.append(torre3.pop())
            print("Torre 1: " + str(torre1))
            print("Torre 2: " + str(torre2))
            print("Torre 3: " + str(torre3))
        elif opcion == 2:
            torre1 = []
            torre2 = []
            torre3 = []
            cantidad = int(input("Ingrese la cantidad de discos: "))
            for i in range(cantidad):
                torre1.append(i + 1)
            print("Torre 1: " + str(torre1))
            print("Torre 2: " + str(torre2))
            print("Torre 3: " + str(torre3))
        elif opcion == 3:
            torre1 = []
            torre2 = []
            torre3 = []
            cantidad = int(input("Ingrese la cantidad de discos: "))
            for i in range(cantidad):
                torre1.append(i + 1)
            print("Torre 1: " + str(torre1))
            print("Torre 2: " + str(torre2))
            print("Torre 3: " + str(torre3))
        elif opcion == 4:
            torre1 = []
            torre2 = []
            torre3 = []
            cantidad = int(input("Ingrese la cantidad de discos: "))
            for i in range(cantidad):
                torre1.append(i + 1)
            print("Torre 1: " + str(torre1))
            print("Torre 2: " + str(torre2))
            print("Torre 3: " + str(torre3))
        else:
            print("Opcion no valida")
        print("1. Ingrese la cantidad de discos")
        print("2. Ingrese la torre de origen")
        print("3. Ingrese la torre de destino")
        print("4. Ingrese la torre de auxiliar")
        print("5. Salir")
        opcion = int(input("Ingrese la opcion: "))

    
    #solicitar la ruta completa de un archivo (en una sola cadena) clasificar si los numeros dentro de el son positivos o negativos
def ejercicio45():
    import os
    os.system("cls")
    ruta = input("Ingrese la ruta del archivo: ")
    if os.path.exists(ruta):
        with open(ruta, "r") as archivo:
            for linea in archivo:
                linea = linea.strip()
                if linea.isdigit():
                    if int(linea) > 0:
                        print("Positivo")
                    else:
                        print("Negativo")
                else:
                    print("No es un numero")
    else:
        print("El archivo no existe")

#solicitar la ruta completa de un archivo (en una sola cadena) clasificar si los numeros dentro de el son positivos o negativos que los clasifique segun su primera cifra y los almacene en un archivo si empiezan 1,2,3,4 guardarlo en el archivo rango1.txt si empiezan 5,6,7,8 guardarlo en el archivo rango2.txt si empiezan 9,0,a,b guardarlo en el archivo rango3.txt
def ejercicio46():
    import os
    os.system("cls")
    ruta = input("Ingrese la ruta del archivo: ")
    if os.path.exists(ruta):
        with open(ruta, "r") as archivo:
            for linea in archivo:
                linea = linea.strip()
                if linea.isdigit():
                    if int(linea) > 0:
                        if int(linea) % 10 == 1:
                            with open("rango1.txt", "a") as archivo1:
                                archivo1.write(linea + "\n")
                        elif int(linea) % 10 == 2:
                            with open("rango2.txt", "a") as archivo2:
                                archivo2.write(linea + "\n")
                        elif int(linea) % 10 == 3:
                            with open("rango3.txt", "a") as archivo3:
                                archivo3.write(linea + "\n")
                        elif int(linea) % 10 == 4:
                            with open("rango4.txt", "a") as archivo4:
                                archivo4.write(linea + "\n")
                        elif int(linea) % 10 == 5:
                            with open("rango5.txt", "a") as archivo5:
                                archivo5.write(linea + "\n")
                        elif int(linea) % 10 == 6:
                            with open("rango6.txt", "a") as archivo6:
                                archivo6.write(linea + "\n")
                        elif int(linea) % 10 == 7:
                            with open("rango7.txt", "a") as archivo7:
                                archivo7.write(linea + "\n")    
                        elif int(linea) % 10 == 8:
                            with open("rango8.txt", "a") as archivo8:
                                archivo8.write(linea + "\n")
                        elif int(linea) % 10 == 9:
                            with open("rango9.txt", "a") as archivo9:
                                archivo9.write(linea + "\n")
                        elif int(linea) % 10 == 0:
                            with open("rango0.txt", "a") as archivo0:
                                archivo0.write(linea + "\n")
                        elif int(linea) % 10 == a:
                            with open("rangoa.txt", "a") as archivoA:
                                archivoA.write(linea + "\n")
                        elif int(linea) % 10 == b:
                            with open("rangob.txt", "a") as archivoB:
                                archivoB.write(linea + "\n")
                    else:   
                        if int(linea) % 10 == 1:
                            with open("rango1.txt", "a") as archivo1:
                                archivo1.write(linea + "\n")
                        elif int(linea) % 10 == 2:
                            with open("rango2.txt", "a") as archivo2:
                                archivo2.write(linea + "\n")
                        elif int(linea) % 10 == 3:
                            with open("rango3.txt", "a") as archivo3:
                                archivo3.write(linea + "\n")
                        elif int(linea) % 10 == 4:
                            with open("rango4.txt", "a") as archivo4:
                                archivo4.write(linea + "\n")
                        elif int(linea) % 10 == 5:
                            with open("rango5.txt", "a") as archivo5:
                                archivo5.write(linea + "\n")
                        elif int(linea) % 10 == 6:
                            with open("rango6.txt", "a") as archivo6:
                                archivo6.write(linea + "\n")
                        elif int(linea) % 10 == 7:
                            with open("rango7.txt", "a") as archivo7:
                                archivo7.write(linea + "\n")    
                        elif int(linea) % 10 == 8:
                            with open("rango8.txt", "a") as archivo8:
                                archivo8.write(linea + "\n")
                        elif int(linea) % 10 == 9:
                            with open("rango9.txt", "a") as archivo9:
                                archivo9.write(linea + "\n")
                        elif int(linea) % 10 == 0:
                            with open("rango0.txt", "a") as archivo0:
                                archivo0.write(linea + "\n")
                        elif int(linea) % 10 == a:
                            with open("rangoa.txt", "a") as archivoA:
                                archivoA.write(linea + "\n")
                        elif int(linea) % 10 == b:
                            with open("rangob.txt", "a") as archivoB:
                                archivoB.write(linea + "\n")
                else:
                    print("No es un numero")
    else:
        print("El archivo no existe")

 #se debe abrir los archivos y leerlos los que sean positivos almacenarlos en positivo.txt y los negativos en negativo.txt
def ejercicio47():
    import os
    os.system("cls")
    ruta1 = input("Ingrese la ruta del archivo positivo: ")
    ruta2 = input("Ingrese la ruta del archivo negativo: ")
    if os.path.exists(ruta1) and os.path.exists(ruta2):
        with open(ruta1, "r") as archivo1:
            for linea in archivo1:
                linea = linea.strip()
                if linea.isdigit():
                    if int(linea) > 0:
                        with open("positivo.txt", "a") as archivo2:
                            archivo2.write(linea + "\n")
                    else:
                        with open("negativo.txt", "a") as archivo3:
                            archivo3.write(linea + "\n")
        with open(ruta2, "r") as archivo4:
            for linea in archivo4:
                linea = linea.strip()
                if linea.isdigit():
                    if int(linea) > 0:
                        with open("positivo.txt", "a") as archivo5:
                            archivo5.write(linea + "\n")
                    else:
                        with open("negativo.txt", "a") as archivo6:
                            archivo6.write(linea + "\n")
    else:
        print("El archivo no existe")

#el usuario ingresa una palabra esta debe cifrarse con una clave de 3 caracteres
def ejercicio48():
    import os
    os.system("cls")
    palabra = input("Ingrese la palabra a cifrar: ")
    clave = input("Ingrese la clave: ")
    if len(clave) == 3:

        for i in range(len(palabra)):
            if palabra[i] == "a":
                palabra = palabra.replace("a", "b")
            elif palabra[i] == "b":
                palabra = palabra.replace("b", "c")
            elif palabra[i] == "c":
                palabra = palabra.replace("c", "d")
            elif palabra[i] == "d":
                palabra = palabra.replace("d", "e")
            elif palabra[i] == "e":
                palabra = palabra.replace("e", "f")
            elif palabra[i] == "f":
                palabra = palabra.replace("f", "g")
            elif palabra[i] == "g":
                palabra = palabra.replace("g", "h")
            elif palabra[i] == "h":
                palabra = palabra.replace("h", "i")
            elif palabra[i] == "i":
                palabra = palabra.replace("i", "j")
            elif palabra[i] == "j":
                palabra = palabra.replace("j", "k")
            elif palabra[i] == "k":
                palabra = palabra.replace("k", "l")
            elif palabra[i] == "l":
                palabra = palabra.replace("l", "m")
            elif palabra[i] == "m":
                palabra = palabra.replace("m", "n")
            elif palabra[i] == "n":
                palabra = palabra.replace("n", "o")
            elif palabra[i] == "o":
                palabra = palabra.replace("o", "p")
            elif palabra[i] == "p":
                palabra = palabra.replace("p", "q")
            elif palabra[i] == "q":
                palabra = palabra.replace("q", "r")
            elif palabra[i] == "r":
                palabra = palabra.replace("r", "s")
            elif palabra[i] == "s":
                palabra = palabra.replace("s", "t")
            elif palabra[i] == "t":
                palabra = palabra.replace("t", "u")
            elif palabra[i] == "u":

                palabra = palabra.replace("u", "v")
            elif palabra[i] == "v":
                palabra = palabra.replace("v", "w")
            elif palabra[i] == "w":
                palabra = palabra.replace("w", "x")
            elif palabra[i] == "x": 
                palabra = palabra.replace("x", "y")
            elif palabra[i] == "y":
                palabra = palabra.replace("y", "z")
            elif palabra[i] == "z":
                palabra = palabra.replace("z", "a")
        print("La palabra cifrada es: " + palabra)
    else:
        print("La clave debe tener 3 caracteres")

#el usuario ingresa una palabra y se encripta con crifrado cesar 
def ejercicio49():
    import os
    os.system("cls")
    palabra = input("Ingrese la palabra a cifrar: ")
    clave = input("Ingrese la clave: ")
    if len(clave) == 3:
        for i in range(len(palabra)):
            if palabra[i] == "a":
                palabra = palabra.replace("a", "b")
            elif palabra[i] == "b":
                palabra = palabra.replace("b", "c")
            elif palabra[i] == "c":
                palabra = palabra.replace("c", "d")
            elif palabra[i] == "d":
                palabra = palabra.replace("d", "e")
            elif palabra[i] == "e":
                palabra = palabra.replace("e", "f")
            elif palabra[i] == "f":
                palabra = palabra.replace("f", "g")
            elif palabra[i] == "g":
                palabra = palabra.replace("g", "h")
            elif palabra[i] == "h":
                palabra = palabra.replace("h", "i")
            elif palabra[i] == "i":
                palabra = palabra.replace("i", "j")
            elif palabra[i] == "j":
                palabra = palabra.replace("j", "k")
            elif palabra[i] == "k":
                palabra = palabra.replace("k", "l")
            elif palabra[i] == "l":
                palabra = palabra.replace("l", "m")
            elif palabra[i] == "m":
                palabra = palabra.replace("m", "n")
            elif palabra[i] == "n":
                palabra = palabra.replace("n", "o")
            elif palabra[i] == "o":
                palabra = palabra.replace("o", "p")
            elif palabra[i] == "p":
                palabra = palabra.replace("p", "q")
            elif palabra[i] == "q":
                palabra = palabra.replace("q", "r")
            elif palabra[i] == "r":
                palabra = palabra.replace("r", "s")
            elif palabra[i] == "s":
                palabra = palabra.replace("s", "t")
            elif palabra[i] == "t":
                palabra = palabra.replace("t", "u")
            elif palabra[i] == "u":
                palabra = palabra.replace("u", "v")

            elif palabra[i] == "v":
                palabra = palabra.replace("v", "w")
            elif palabra[i] == "w":
                palabra = palabra.replace("w", "x")
            elif palabra[i] == "x":
                palabra = palabra.replace("x", "y")
            elif palabra[i] == "y":
                palabra = palabra.replace("y", "z")
            elif palabra[i] == "z":
                palabra = palabra.replace("z", "a")
        print("La palabra cifrada es: " + palabra)
    else:
        print("La clave debe tener 3 caracteres")
    
#un arreglo llamado abecedario
def ejercicio50():
    import os
    os.system("cls")
    abecedario = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"]
    print("El abecedario es: " + str(abecedario))
#ingresar una palabra y mostrar la palabra que se ingreso
    palabra = input("Ingrese la palabra a mostrar: ")
    print("La palabra es: " + palabra)

#decir si la palabra es una oracion o no
    if palabra[len(palabra) - 1] == ".":
        print("La palabra es una oracion")
    else:
        print("La palabra no es una oracion")

#almacenar en un archivo la palabra original

    archivo = open("palabra.txt", "w")
    archivo.write(palabra)
    archivo.close() 
#leer el archivo y mostrar la palabra original
    archivo = open("palabra.txt", "r")
    palabra = archivo.read()
    print("La palabra original es: " + palabra)
    archivo.close()
#mostrar ubicacion del archivo creado y abrir la carpeta
    print("La ubicacion del archivo es: " + os.getcwd())
    os.system("explorer")

#hacer un arreglo que almacene las letras de la palabra ingresada por separado

    letras = []
    for i in range(len(palabra)):
        letras.append(palabra[i])
    print("Las letras de la palabra son: " + str(letras))

#decir en que posicion se encuentra cada letra del abedecedario
    for i in range(len(letras)):
        for j in range(len(abecedario)):
            if letras[i] == abecedario[j]:
                print("La letra " + letras[i] + " se encuentra en la posicion " + str(j))

#cambiar las letras del arreglo letras por la letra que este 5 espacios adelante de el en caso de que la suma de los 5 espacios no se pase de largo del abedecedario volver iniciar la suma del restante en la posicion 0
    for i in range(len(letras)):
        for j in range(len(abecedario)):
            if letras[i] == abecedario[j]:
                letras[i] = abecedario[j + 5]
                if j + 5 > len(abecedario) - 1:
                    letras[i] = abecedario[j - len(abecedario) + 5]
    print("Las letras cambiadas son: " + str(letras))

    for i in range(len(letras)):
        for j in range(len(abecedario)):
            if letras[i] == abecedario[j]:
                print("La letra " + letras[i] + " se encuentra en la posicion " + str(j))
            


#reproducir un video de youtube llamado kill this love , mostrar el titulo del video y el nombre del video junto con su duracion y enlace
    import pytube
    import os
    os.system("cls")
    video = pytube.YouTube("https://www.youtube.com/watch?v=_X-_X-_X-_X")
    print("El titulo del video es: " + video.title)
    print("El nombre del video es: " + video.filename)
    print("La duracion del video es: " + str(video.length))
    print("El enlace del video es: " + video.url)
    video.streams.first().download()

#convertir un video de youtube a mp3 y almacenarlo en una carpeta
    import pytube
    import os
    os.system("cls")
    video = pytube.YouTube("https://www.youtube.com/watch?v=_X-_X-_X-_X")
    print("El titulo del video es: " + video.title)
    print("El nombre del video es: " + video.filename)
    print("La duracion del video es: " + str(video.length))
    print("El enlace del video es: " + video.url)
    video.streams.first().download()
    video.streams.first().download()
    os.system("explorer")

#calculadora
    import os
    os.system("cls")
    print("Calculadora")
    print("1. Suma")
    print("2. Resta")
    print("3. Multiplicacion")
    print("4. Division")
    print("5. Salir")
    opcion = int(input("Ingrese una opcion: "))
    if opcion == 1:
        num1 = int(input("Ingrese el primer numero: "))
        num2 = int(input("Ingrese el segundo numero: "))
        print("El resultado de la suma es: " + str(num1 + num2))
    elif opcion == 2:
        num1 = int(input("Ingrese el primer numero: "))
        num2 = int(input("Ingrese el segundo numero: "))
        print("El resultado de la resta es: " + str(num1 - num2))
    elif opcion == 3:
        num1 = int(input("Ingrese el primer numero: "))
        num2 = int(input("Ingrese el segundo numero: "))
        print("El resultado de la multiplicacion es: " + str(num1 * num2))
    elif opcion == 4:
        num1 = int(input("Ingrese el primer numero: "))
        num2 = int(input("Ingrese el segundo numero: "))
        print("El resultado de la division es: " + str(num1 / num2))
    elif opcion == 5:
        print("Gracias por usar la calculadora")
    else:
        print("Opcion no valida")

#hacer una funcion que calcule el valor del vector
    import os
    os.system("cls")
    def vector(x, y, z):
        vector = [x, y, z]
        return vector
    print("El valor del vector es: " + str(vector(1, 2, 3)))

#funcion que calcule la direccion de un vector
    import os
    os.system("cls")
    def direccion(x, y, z):
        vector = [x, y, z]
        if x > 0 and y > 0 and z > 0:
            return "El vector esta en el eje X positivo, Y positivo y Z positivo"
        elif x > 0 and y > 0 and z < 0:
            return "El vector esta en el eje X positivo, Y positivo y Z negativo"
        elif x > 0 and y < 0 and z > 0:
            return "El vector esta en el eje X positivo, Y negativo y Z positivo"
        elif x > 0 and y < 0 and z < 0:
            return "El vector esta en el eje X positivo, Y negativo y Z negativo"
        elif x < 0 and y > 0 and z > 0:
            return "El vector esta en el eje X negativo, Y positivo y Z positivo"
        elif x < 0 and y > 0 and z < 0:
            return "El vector esta en el eje X negativo, Y positivo y Z negativo"
        elif x < 0 and y < 0 and z > 0:
            return "El vector esta en el eje X negativo, Y negativo y Z positivo"
        elif x < 0 and y < 0 and z < 0:
            return "El vector esta en el eje X negativo, Y negativo y Z negativo"
        elif x > 0 and y == 0 and z > 0:
            return "El vector esta en el eje X positivo, Y 0 y Z positivo"
        elif x > 0 and y == 0 and z < 0:
            return "El vector esta en el eje X positivo, Y 0 y Z negativo"
        elif x < 0 and y == 0 and z > 0:
            return "El vector esta en el eje X negativo, Y 0 y Z positivo"
        elif x < 0 and y == 0 and z < 0:
            return "El vector esta en el eje X negativo, Y 0 y Z negativo"
        elif x > 0 and y > 0 and z == 0:
            return "El vector esta en el eje X positivo, Y positivo y Z 0"
        elif x > 0 and y < 0 and z == 0:
            return "El vector esta en el eje X positivo, Y negativo y Z 0"
        elif x < 0 and y > 0 and z == 0:
            return "El vector esta en el eje X negativo, Y positivo y Z 0"
        elif x < 0 and y < 0 and z == 0:
            return "El vector esta en el eje X negativo, Y negativo y Z 0"
        elif x == 0 and y > 0 and z > 0:
            return "El vector esta en el eje X 0, Y positivo y Z positivo"
        elif x == 0 and y > 0 and z < 0:
            return "El vector esta en el eje X 0, Y positivo y Z negativo"
        elif x == 0 and y < 0 and z > 0:
            return "El vector esta en el eje X 0, Y negativo y Z positivo"
        elif x == 0 and y < 0 and z < 0:
            return "El vector esta en el eje X 0, Y negativo y Z negativo"
        elif x > 0 and y == 0 and z == 0:
            return "El vector esta en el eje X positivo, Y 0 y Z 0"
        elif x < 0 and y == 0 and z == 0:
            return "El vector esta en el eje X negativo, Y 0 y Z 0"
        elif x == 0 and y > 0 and z == 0:
            return "El vector esta en el eje X 0, Y positivo y Z 0"
        elif x == 0 and y < 0 and z == 0:
            return "El vector esta en el eje X 0, Y negativo y Z 0"
        elif x == 0 and y == 0 and z > 0:
            return "El vector esta en el eje X 0, Y 0 y Z positivo"
        elif x == 0 and y == 0 and z < 0:
            return "El vector esta en el eje X 0, Y 0 y Z negativo"
        else:
            return "El vector no esta en ningun eje"
    print("La direccion del vector es: " + str(direccion(1, 2, 3)))

#calcular el teorema de pitagoras de un triangulo rectangulo 

    import os
    os.system("cls")
    def pitagoras(a, b):
        c = (a**2 + b**2)**0.5
        return c
    print("El valor de la hipotenusa es: " + str(pitagoras(3, 4)))

#calcular el coseno , tangente y seno de un angulo
    import os
    os.system("cls")
    def coseno(a):
        c = (a**2 + 1)**0.5
        return c
    print("El valor del coseno es: " + str(coseno(3)))
    def tangente(a):
        c = (a**2 - 1)**0.5
        return c
    print("El valor de la tangente es: " + str(tangente(3)))
    def seno(a):
        c = (a**2 - 1)**0.5
        return c
    print("El valor del seno es: " + str(seno(3)))

    #calcular el area sombreada de un triangulo rectangulo con un circulo
    import os
    os.system("cls")
    def area(a, b):
        c = (a**2 + b**2)**0.5
        return c
    print("El valor del area sombreada es: " + str(area(3, 4)))

#calcular la matriz y su inversa con su determinante generada por numeros aleatorios 

    import os
    os.system("cls")
    def matriz(a, b, c, d, e, f, g, h, i):
        matriz = [[a, b, c], [d, e, f], [g, h, i]]
        return matriz
    print("La matriz es: " + str(matriz(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    def determinante(a, b, c, d, e, f, g, h, i):
        determinante = a*e*i + b*f*g + c*d*h - c*e*g - b*d*i - a*f*h
        return determinante
    print("El determinante es: " + str(determinante(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    def inversa(a, b, c, d, e, f, g, h, i):
        inversa = [[e*i - f*h, c*h - b*i, b*f - c*e], [f*g - d*i, a*i - c*g, c*d - a*f], [d*h - g*e, b*e - a*h, a*g - b*d]]
        return inversa
    print("La matriz inversa es: " + str(inversa(1, 2, 3, 4, 5, 6, 7, 8, 9)))

#determinar si un circuito esta en paralelo o serie con una fuente de alimentacion
    import os
    os.system("cls")
    def circuito(a, b, c, d, e, f, g, h, i):
        circuito = [[a, b, c], [d, e, f], [g, h, i]]
        return circuito
    print("El circuito es: " + str(circuito(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    def fuente(a, b, c, d, e, f, g, h, i):
        fuente = [[a, b, c], [d, e, f], [g, h, i]]
        return fuente
    print("La fuente de alimentacion es: " + str(fuente(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    def paralelo(a, b, c, d, e, f, g, h, i):
        paralelo = [[a, b, c], [d, e, f], [g, h, i]]
        return paralelo
    print("El circuito esta en paralelo con la fuente de alimentacion: " + str(paralelo(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    def serie(a, b, c, d, e, f, g, h, i):
        serie = [[a, b, c], [d, e, f], [g, h, i]]
        return serie
    print("El circuito esta en serie con la fuente de alimentacion: " + str(serie(1, 2, 3, 4, 5, 6, 7, 8, 9)))


#graficar el seno de una funcion
    import os
    os.system("cls")
    def seno(a):
        seno = [math.sin(x) for x in range(0, 360, 1)]
        return seno
    print("El seno de la funcion es: " + str(seno(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(seno(1))
    plt.show()

#graficar el coseno de una funcion
    import os
    os.system("cls")
    def coseno(a):
        coseno = [math.cos(x) for x in range(0, 360, 1)]
        return coseno
    print("El coseno de la funcion es: " + str(coseno(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(coseno(1))
    plt.show()

    #graficar la tangente de una funcion
    import os
    os.system("cls")
    def tangente(a):
        tangente = [math.tan(x) for x in range(0, 360, 1)]
        return tangente
    print("La tangente de la funcion es: " + str(tangente(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(tangente(1))
    plt.show()

#calcular el limite de una funcion y graficar el limite
    import os
    os.system("cls")
    def limite(a):
        limite = [math.tan(x) for x in range(0, 360, 1)]
        return limite
    print("El limite de la funcion es: " + str(limite(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(limite(1))
    plt.show()

#sacar la media,la moda ,la mediana, la desviacion estandar y la varianza de una funcion
    import os
    os.system("cls")
    def media(a):
        media = sum(a)/len(a)
        return media
    print("La media de la funcion es: " + str(media(1)))
    def moda(a):
        moda = max(set(a), key=a.count)
        return moda
    print("La moda de la funcion es: " + str(moda(1)))
    def mediana(a):
        mediana = sorted(a)
        return mediana
    print("La mediana de la funcion es: " + str(mediana(1)))
    def desviacion(a):
        desviacion = math.sqrt(sum([(x - media(a))**2 for x in a])/len(a))
        return desviacion
    print("La desviacion estandar de la funcion es: " + str(desviacion(1)))
    def varianza(a):
        varianza = sum([(x - media(a))**2 for x in a])/len(a)
        return varianza
    print("La varianza de la funcion es: " + str(varianza(1)))

#calcular el voltaje de un circuito dependiendo si esta en serie o en paralelo

    import os
    os.system("cls")
    def voltaje(a, b, c, d, e, f, g, h, i):
        voltaje = [[a, b, c], [d, e, f], [g, h, i]]
        return voltaje
    print("El voltaje del circuito es: " + str(voltaje(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    def voltaje_serie(a, b, c, d, e, f, g, h, i):
        voltaje_serie = [[a, b, c], [d, e, f], [g, h, i]]
        return voltaje_serie
    print("El voltaje del circuito en serie es: " + str(voltaje_serie(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    def voltaje_paralelo(a, b, c, d, e, f, g, h, i):
        voltaje_paralelo = [[a, b, c], [d, e, f], [g, h, i]]
        return voltaje_paralelo
    print("El voltaje del circuito en paralelo es: " + str(voltaje_paralelo(1, 2, 3, 4, 5, 6, 7, 8, 9)))
    

    #calcular el logaritmo del numero ingresado y graficarlo
    import os
    os.system("cls")
    def logaritmo(a):
        logaritmo = [math.log(x) for x in range(0, 360, 1)]
        return logaritmo
    print("El logaritmo de la funcion es: " + str(logaritmo(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(logaritmo(1))
    plt.show()

    #calcular la derivada de una funcion y graficarla
    import os
    os.system("cls")
    def derivada(a):
        derivada = [math.log(x) for x in range(0, 360, 1)]
        return derivada
    print("La derivada de la funcion es: " + str(derivada(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(derivada(1))
    plt.show()

    #calcular la integral de una funcion y graficarla
    import os
    os.system("cls")
    def integral(a):
        integral = [math.log(x) for x in range(0, 360, 1)]
        return integral
    print("La integral de la funcion es: " + str(integral(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(integral(1))
    plt.show()

   #calcular el promedio total de la clase de matematicas y graficarlo
    import os
    os.system("cls")
    def promedio(a):
        promedio = [math.log(x) for x in range(0, 360, 1)]
        return promedio
    print("El promedio total de la clase de matematicas es: " + str(promedio(1)))
    import matplotlib.pyplot as plt
    import numpy as np
    import math
    plt.plot(promedio(1))
    plt.show()



#subir una imagen
    import os
    os.system("cls")
    def subir_imagen():
        import tkinter as tk
        from tkinter import filedialog
        root = tk.Tk()
        root.withdraw()
        file_path = filedialog.askopenfilename()
        return file_path
    print("La imagen subida es: " + str(subir_imagen()))

    #subir un video
    import os
    os.system("cls")
    def subir_video():
        import tkinter as tk
        from tkinter import filedialog
        root = tk.Tk()
        root.withdraw()
        file_path = filedialog.askopenfilename()
        return file_path
    print("El video subido es: " + str(subir_video()))

#escribir en un archivo de texto la informacion de sonido de un video
    import os
    os.system("cls")
    def escribir_archivo():
        import tkinter as tk
        from tkinter import filedialog
        root = tk.Tk()
        root.withdraw()
        file_path = filedialog.askopenfilename()
        return file_path
    print("El archivo de texto escrito es: " + str(escribir_archivo()))

 #subir una imagen y buscar si se encuentra en internet en caso que si mostrar un mensaje que se encuentra
 #en internet y en caso que no mostrar un mensaje que no se encuentra en internet
    import os
    os.system("cls")
    def subir_imagen():
        import tkinter as tk
        from tkinter import filedialog
        root = tk.Tk()
        root.withdraw()
        file_path = filedialog.askopenfilename()
        return file_path
    print("La imagen subida es: " + str(subir_imagen()))
    import requests
    import os
    os.system("cls")
    def buscar_imagen():
        url = "https://www.google.com/search?q=" + subir_imagen()
        r = requests.get(url)
        if r.status_code == 200:
            print("La imagen se encuentra en internet")
        else:
            print("La imagen no se encuentra en internet")
    buscar_imagen()

#borrar datos anteriores
    import os
    os.system("cls")    
    def borrar_datos():
        import os
        os.system("cls")
        print("Datos borrados")
    borrar_datos()

#calcualr con una funcion cuanto tiempo falta para que llegue la luz
    import os
    os.system("cls")
    def tiempo_falta():
        import time
        import datetime
        import math
        import os
        os.system("cls")
        print("Ingrese la fecha de la luz: ")
        dia = int(input("Ingrese el dia: "))
        mes = int(input("Ingrese el mes: "))
        anio = int(input("Ingrese el anio: "))
        hora = int(input("Ingrese la hora: "))
        minutos = int(input("Ingrese los minutos: "))
        segundos = int(input("Ingrese los segundos: "))
        fecha_luz = datetime.datetime(anio, mes, dia, hora, minutos, segundos)
        fecha_actual = datetime.datetime.now()
        tiempo_falta = fecha_luz - fecha_actual
        print("El tiempo falta para que llegue la luz es: " + str(tiempo_falta))
        import matplotlib.pyplot as plt
        import numpy as np
        import math
        plt.plot(tiempo_falta)
        plt.show()
    tiempo_falta()

#funcion que realice un test de conocimiento con 5 preguntas(usar las mas famosas que se encuentran en internet) y si la respuesta es correcta o no asignarle 1 punto por cada si y 0 por cada no y mostrar el resultado
    import os
    os.system("cls")
    def test_conocimiento():
        import os
        os.system("cls")
        print("Ingrese la respuesta a la pregunta 1: ")
        pregunta1 = input("1. ¿Qué es una computadora? ")
        if pregunta1 == "Una computadora es una unidad de procesamiento que permite almacenar y procesar datos, información, y comunicación entre sistemas.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("Ingrese la respuesta a la pregunta 2: ") 
        pregunta2 = input("2. ¿Qué es un ser vivo? ")
        if pregunta2 == "Un ser vivo es una criatura viva que se mueve y se alimenta en el medio ambiente.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("Ingrese la respuesta a la pregunta 3: ")
        pregunta3 = input("3. ¿Qué es el anima? ")
        if pregunta3 == "El anima es una especie de ser vivo que se mueve y se alimenta en el medio ambiente.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("Ingrese la respuesta a la pregunta 4: ")
        pregunta4 = input("4. ¿Qué es una IA? ")
        if pregunta4 == "Una IA es una computadora que se mueve y se alimenta en el medio ambiente.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("Ingrese la respuesta a la pregunta 5: ")
        pregunta5 = input("5. ¿Qué es una cancion? ")
        if pregunta5 == "Una cancion es una composicion de notas musicales que se reproduce en una melodia.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("El resultado del test es: " + str(puntos))
    test_conocimiento()

    #funcion que realice un test de conocimiento con 5 preguntas(usar las mas famosas que se encuentran en internet) y si la respuesta es correcta o no asignarle 1 punto por cada si y 0 por cada no y mostrar al final un mensaje que diga gracias por participar
    import os
    os.system("cls")
    def test_conocimiento():
        import os
        os.system("cls")
        print("Ingrese la respuesta a la pregunta 1: ")
        pregunta1 = input("1. Dequé se alimenta una IA ")
        if pregunta1 == "Una IA se alimenta de datos.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")   
        print("Ingrese la respuesta a la pregunta 2: ")
        pregunta2 = input("2. Que pasa cuando una IA se alimenta de datos ")
        if pregunta2 == "Cuando una IA se alimenta de datos, se le entrega una serie de datos para que la IA pueda procesar.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("Ingrese la respuesta a la pregunta 3: ")
        pregunta3 = input("3. IA es un peligro")
        if pregunta3 == "Una IA es un peligro porque puede causar daños a la computadora.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("Ingrese la respuesta a la pregunta 4: ")
        pregunta4 = input("4. cuantos datos se entregan a una IA ")
        if pregunta4 == "Una IA se alimenta de datos.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("Ingrese la respuesta a la pregunta 5: ")
        pregunta5 = input("5. ¿Qué es una IA? ")
        if pregunta5 == "Una IA es una computadora que se mueve y se alimenta en el medio ambiente.":
            print("Respuesta correcta")
            puntos = puntos + 1
        else:
            print("Respuesta incorrecta")
        print("El resultado del test es: " + str(puntos))
    test_conocimiento()
    print("Gracias por participar")
    print("Gracias por participar")
    



        























        







































































































































        




        




    






























 



