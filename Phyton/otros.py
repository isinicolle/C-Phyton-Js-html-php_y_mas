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

    


























 



