CREATE DATABASE db_Prestamos_PC
GO
USE db_Prestamos_PC
GO

CREATE TABLE [Clientes](
[Id] INT PRIMARY KEY IDENTITY(1, 1),
[Nombre] NVARCHAR (30) NOT NULL,
[Direccion] NVARCHAR (30) NOT NULL,
[Correo] NVARCHAR (30) NOT NULL,

);


CREATE TABLE [Marcas](
[Id] INT PRIMARY KEY IDENTITY(1, 1),
[Nombre] NVARCHAR (30) NOT NULL,
[PaisOrigen] NVARCHAR (30) NOT NULL,
[Fundacion] SMALLDATETIME NOT NULL,
);

CREATE TABLE [Equipos](
[Id] INT PRIMARY KEY IDENTITY(1, 1),
[Descripcion] NVARCHAR (90) NOT NULL,
[Color] NVARCHAR (30) NOT NULL,
[Marca] INT NOT NULL REFERENCES [Marcas]([Id]),

);


CREATE TABLE [Prestamos](
[Id] INT PRIMARY KEY IDENTITY(1, 1),
[Fecha_Inicio] SMALLDATETIME NOT NULL,
[Fecha_Fin] SMALLDATETIME NOT NULL,
[Estado] NVARCHAR (30) NOT NULL,
[Equipo] INT NOT NULL REFERENCES [Equipos]([Id]),
[Cliente] INT NOT NULL REFERENCES [Clientes]([Id]),
);


INSERT INTO [Clientes] ([Nombre],[Direccion],[Correo])
VALUES ('PEPE', 'Medellin', 'Pepe@gmail.com');

INSERT INTO [Clientes] ([Nombre],[Direccion],[Correo])
VALUES ('PACO', 'Bogota', 'Paco@gmail.com');



INSERT INTO [Marcas] ([Nombre], [PaisOrigen], [Fundacion])
VALUES ('Lenovo', 'China', GETDATE());
INSERT INTO [Marcas] ([Nombre], [PaisOrigen], [Fundacion])
VALUES ('ASUS', 'Taiwan', GETDATE());



INSERT INTO [Equipos] ([Descripcion], [Color], [Marca])
VALUES ('procesador Intel Core i5, 16GB RAM, 1TB SSD, pantalla 15.6"', 'Rojo', 1);
INSERT INTO [Equipos] ([Descripcion], [Color], [Marca])
VALUES (' Intel® Core™ i5-1240P (hasta 4.4 GHz).', 'Verde', 2);
INSERT INTO [Equipos] ([Descripcion], [Color], [Marca])
VALUES (' Intel® Core™ i5-1240P (hasta 4.4 GHz).', 'Verde', 2);

INSERT INTO [Prestamos] ([Fecha_Inicio],[Fecha_Fin],[Estado],[Equipo],[Cliente])
VALUES (GETDATE(), 2026-30-03, 'Prestamo', 5, 1);
INSERT INTO [Prestamos] ([Fecha_Inicio],[Fecha_Fin],[Estado],[Equipo],[Cliente])
VALUES ('2026-02-18 14:30:00', GETDATE(), 'Atrasado', 2, 2);


ALTER TABLE Equipos 
ADD Disponibilidad BIT NOT NULL DEFAULT 0;


select * FROM EQUIPOS;

UPDATE Equipos
SET Disponibilidad = 1
WHERE Color = 'azul';