--Ejercicio #1
--Crear una base de datos contenida y crear un usuario

CREATE DATABASE [Base_Datos_Contenida_Tarea]
 CONTAINMENT = PARTIAL

USE [Base_Datos_Contenida_Tarea]
GO

Create User [Isis Zapata] with password = '123' ; 

--Ejercicio #2
--Crear un indice en una tabla

	Use [VehiculosUnicah]
	
	
	CREATE NONCLUSTERED INDEX Indice_tabla_marcas
	ON [Marcas] ([MarcaDescripcion] ASC)

	--Verificar que el indice se creo
	EXECUTE sp_helpindex [Marcas]

--Ejercicio #3
--Crear una tabla con 4 archivos para almacenar información

use VehiculosUnicah
Alter Database VehiculosUnicah
add filegroup Ejercicio4

Alter database VehiculosUnicah
Add file (name=archivo1,
		  filename=N'C:\Users\Isis\Desktop\Ejercicio\Archivo1.ndf',
		  size =10mb,
		  filegrowth=1mb
		  )
		  ,(name=Archivo2,
		  filename=N'C:\Users\Isis\Desktop\Ejercicio\Archivo2.ndf',
		  size= 10mb,
		filegrowth =5mb),
		(name=Archivo3,
		filename=N'C:\Users\Isis\Desktop\Ejercicio\Archivo3.ndf',
		size=20mb,
		filegrowth = 10mb),
		(name=Archivo4,
		filename=N'C:\Users\Isis\Desktop\Ejercicio\Archivo4.ndf',
		size=25mb,
		filegrowth=10mb)
		  TO filegroup Ejercicio4


		 
	CREATE TABLE TablaArchi
	(Id int identity (1,1) not null,
	name nvarchar(128) not null,
	StandardCost money not null,
	ListPrice money not null)
	ON Ejercicio4
	go

--Verificar a que filegroup pertenece la tabla creada
	Select i.data_space_id,i.name as nombre,
	s.name as filegroup
	From sys.indexes as i
	INNER JOIN sys.data_spaces as s
	on i.data_space_id = s.data_space_id
	Where i.object_id=object_id(N'dbo.TablaArchi');
Go

--0801200108392 Isis Nicolle Zapata Florentino 