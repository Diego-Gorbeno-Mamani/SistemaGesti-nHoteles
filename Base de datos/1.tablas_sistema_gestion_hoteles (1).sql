--Creamos la base de datos
CREATE DATABASE db_sistema_gestion_hoteles
GO
USE db_sistema_gestion_hoteles

--Crear tabla Tipo Usuario
if(not exists(select 1 from SYS.tables where name = 'Tipo_Usuario'))
CREATE TABLE dbo.Tipo_Usuario(
id_tipo_usuario int identity(1,1)PRIMARY KEY,
nombre_tipo_usuario varchar(150) NOT NULL
)
GO
--Crear Tabla Tipo de documento
if (not exists(select 1 from SYS.tables where name = 'Tipo_Documento'))
    CREATE TABLE dbo.Tipo_Documento(
        id_tipo_documento int identity(1,1) PRIMARY KEY,
        nombre_tipo_documento varchar(100) NOT NULL
)
GO
--Crear tabala usuario
if(not exists(select 1 from SYS.tables where name = 'Usuario'))
CREATE TABLE dbo.Usuario(
id_usuario int identity(1,1)PRIMARY KEY,
id_tipo_usuario int,
id_tipo_documento int,
nombre varchar(150)NOT NULL,
apellido varchar(250)NOT NULL,
telefono char(9)NOT NULL,
direccion varchar(250) NOT NULL,
clave char(12) NOT NULL,
numero_documento varchar(25) UNIQUE NOT NULL,
FOREIGN KEY (id_tipo_usuario) REFERENCES Tipo_Usuario,
FOREIGN KEY (id_tipo_documento) REFERENCES Tipo_Documento
)
GO
--Crear Tabla Tipo de tarjeta
if (not exists(select 1 from SYS.tables where name = 'Tipo_Tarjeta'))
    CREATE TABLE dbo.Tipo_Tarjeta(
        id_tipo_tarjeta int identity(1,1) PRIMARY KEY,
        tipo_nombre_tarjeta varchar(100) NOT NULL
)
GO
--Crear Tabla Tipo de habitacion
if (not exists(select 1 from SYS.tables where name = 'Tipo_Hab'))
    CREATE TABLE dbo.Tipo_Hab(
        id_tipo_habitacion int identity(1,1) PRIMARY KEY,
        tipo_nombre_habitacion varchar(100) NOT NULL
)
GO
--Crear tabala Hotel
if(not exists(select 1 from SYS.tables where name = 'Hotel'))
CREATE TABLE dbo.Hotel(
id_hotel int identity(1,1)PRIMARY KEY,
nombre varchar(150)NOT NULL,
direccion varchar(250)NOT NULL,
ciudad varchar(250) NOT NULL,
pais varchar(50) NOT NULL,
categoria varchar(25) NOT NULL,
imagen image NOT NULL,
horario varchar(50) NOT NULL,
descripcion varchar(250) NOT NULL,
id_usuario int,
FOREIGN KEY (id_usuario) REFERENCES Usuario
)
GO
--Crear Tabla Detalle Hotel
if (not exists(select 1 from SYS.tables where name = 'Detalle_Hotel'))
    CREATE TABLE dbo.Detalle_Hotel(
        id_detalle int identity(1,1) ,
		id_hotel int,
        cantidad_Hab varchar(25) NOT NULL,
		PRIMARY KEY(id_detalle),
        FOREIGN KEY (id_hotel) REFERENCES Hotel
)
GO
--Crear Tabla Habitacion
if (not exists(select 1 from SYS.tables where name = 'Habitacion'))
    CREATE TABLE dbo.Habitacion(
        id_habitacion int identity(1,1) ,
		id_hotel int,
		id_tipo_habitacion int,
		cantidad int,
        precio decimal,
		disponibilidad varchar(25) NOT NULL,
		descripcion varchar(250)NOT NULL,
		PRIMARY KEY(id_habitacion),
		FOREIGN KEY (id_tipo_habitacion) REFERENCES Tipo_Hab,
		FOREIGN KEY (id_hotel) REFERENCES Hotel
)
GO
--Crear Tabla Tarjeta
if (not exists(select 1 from SYS.tables where name = 'Tarjeta'))
    CREATE TABLE dbo.Tarjeta(
        id_tarjeta int identity(1,1) PRIMARY KEY,
        nro_tarjeta varchar(15) NOT NULL,
        id_tipo_tarjeta int
        FOREIGN KEY (id_tipo_tarjeta) REFERENCES Tipo_Tarjeta
)
GO

--Crear Tabla Pago
if (not exists(select 1 from SYS.tables where name = 'Pago'))
    CREATE TABLE dbo.Pago(
        id_pago int identity(1,1) PRIMARY KEY,
        precio_total float,
        id_tarjeta int
        FOREIGN KEY (id_tarjeta) REFERENCES Tarjeta
)
GO
--Crear Tabla  Reserva
if (not exists(select 1 from SYS.tables where name = 'Reserva'))
    CREATE TABLE dbo.Reserva(
        id_reserva int PRIMARY KEY,
        id_usuario int,
		estado varchar(25),
		fecha date,
        FOREIGN KEY (id_usuario) REFERENCES Usuario		
)
GO
--Crear Tabla Detalle Reserva
if (not exists(select 1 from SYS.tables where name = 'Detalle_Reserva'))
    CREATE TABLE dbo.Detalle_Reserva(
        id_detalle_reserva int identity(1,1) PRIMARY KEY,        
		id_habitacion int,
		id_reserva int,        
		FOREIGN KEY (id_habitacion) REFERENCES Habitacion,
		FOREIGN KEY (id_reserva) REFERENCES Reserva
)
GO

--Crear Tabla empresa
if (not exists(select 1 from SYS.tables where name = 'Empresa'))
    CREATE TABLE dbo.Empresa(
        id_empresa int identity(1,1) PRIMARY KEY,        
		id_usuario int,
		id_hotel int,        
		FOREIGN KEY (id_usuario) REFERENCES Usuario,
		FOREIGN KEY (id_hotel) REFERENCES Hotel
)
GO

