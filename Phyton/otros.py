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




