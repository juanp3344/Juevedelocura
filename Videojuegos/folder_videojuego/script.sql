CREATE DATABASE videojuegos;
GO 
USE videojuegos;
GO

CREATE TABLE [Categorias] (
[IdCategoria] INT PRIMARY KEY IDENTITY(1, 1),
[Nombre] NVARCHAR(30) NOT NULL,
);

CREATE TABLE [Productos] (
	[IdProducto] INT PRIMARY KEY IDENTITY(1, 1),
	[Nombre] NVARCHAR(30) NOT NULL,
	[Precio] DECIMAL(10, 2) NOT NULL,
	[IdCategoria] INT NOT NULL REFERENCES [Categorias] ([IdCategoria]),
);

CREATE TABLE [Ventas] (
    [IdVenta] INT PRIMARY KEY IDENTITY(1,1),
    [IdProducto] INT NOT NULL REFERENCES [Productos] ([IdProducto]),
    [Cantidad] INT NOT NULL
);

INSERT INTO [Categorias] ([Nombre])
VALUES 
('Accion/horror'),
('Action');

INSERT INTO [Productos] ([Nombre], [Precio], [IdCategoria])
VALUES
('Resident Evil Village', 150000.0, 1),
('Batman Arkham Knight', 100000, 2);


SELECT * FROM Categorias
SELECT * FROM Productos

