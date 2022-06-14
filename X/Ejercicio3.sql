 
 --Mediante script restaurar la base de datos VehiculosUnicah usando los archivos MDF y LOG.
CREATE DATABASE VehiculosUnica ON (filename= N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VehiculosUnicah.mdf'),
(filename= N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\VehiculosUnicah_log.ldf')
for attach

--Crear un respaldo FULL mediante script de la base de datos VehiculosUnicah.

--copia de seguridad de la base de datos completa en el disco
BACKUP DATABASE [VehiculosUnicah]
TO DISK = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\VehiculosUnicah.bak'
   WITH FORMAT,
      MEDIANAME = 'Backup',
      NAME = 'Full Backup VehicculosUnicah';
GO

--Script Generado por SQL
BACKUP DATABASE [VehiculosUnicah] 
TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\VehiculosUnicah.bak' WITH NOFORMAT, 
NOINIT,  
NAME = N'VehiculosUnicah-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10
GO


 --Crear un script para otorgar permisos a insertar un usuario de base de datos. 
CREATE LOGIN Isis_Nicolle
WITH PASSWORD= '1234', 
DEFAULT_DATABASE=[VehiculosUnicah],
DEFAULT_LANGUAGE=us_english, 
CHECK_POLICY=ON

CREATE USER Isis_Nicolle FOR LOGIN Isis_Nicolle
Grant insert on database::[VehiculosUnicah]to Isis_Nicolle
GO


