CREATE DATABASE Practica_De_Inventario_De_Productos
GO
USE Practica_De_Inventario_De_Productos

-- Creación de la tabla con eliminación lógica
CREATE TABLE Productos 
(
    Id INT IDENTITY (1,1) PRIMARY KEY,
    Nombre NVARCHAR (100),
    Descripcion NVARCHAR (100),
    Marca NVARCHAR (100),
    Precio FLOAT,
    Stock INT,
    Estado BIT DEFAULT 1 -- 1 = Activo, 0 = Inactivo
)

-- Inserción de datos de prueba
INSERT INTO Productos (Nombre, Descripcion, Marca, Precio, Stock) 
VALUES
('Gaseosa', '3 litros', 'marcacola', 7.5, 24),
('Chocolate', 'Tableta 100 gramos', 'iberica', 12.5, 36),
('Cereal', 'Caja 500g', 'Nestlé', 8.0, 50),
('Leche', '1 litro', 'LaVaquita', 4.5, 40),
('Pan', 'Bolsa de 10 unidades', 'Bimbo', 3.0, 30),
('Queso', '250g', 'La Serenísima', 5.5, 25),
('Mermelada', 'Frasco 300g', 'Dulcor', 6.0, 20),
('Galletas', 'Paquete 250g', 'Oreo', 4.0, 35),
('Café', 'Bolsa 500g', 'Nescafé', 10.0, 15),
('Azúcar', 'Bolsa 1kg', 'Domino', 3.5, 45),
('Sal', 'Bolsa 500g', 'Refisal', 2.0, 60),
('Arroz', 'Bolsa 1kg', 'Tío Rico', 4.2, 55),
('Harina', 'Bolsa 1kg', 'P.A.N.', 3.8, 48),
('Aceite', 'Botella 1 litro', 'Cocinero', 7.0, 38),
('Vinagre', 'Botella 500ml', 'Heinz', 2.5, 50),
('Mayonesa', 'Frasco 250g', 'Hellmann’s', 5.2, 28),
('Kétchup', 'Frasco 250g', 'Heinz', 4.8, 33),
('Mostaza', 'Frasco 250g', 'French’s', 4.6, 29),
('Atún', 'Lata 170g', 'Van Camp’s', 3.9, 41),
('Sardinas', 'Lata 200g', 'Calvo', 3.5, 37)

-- Procedimientos almacenados
--------------------------MOSTRAR SOLO ACTIVOS
CREATE PROC MostrarProductos
AS
SELECT * FROM Productos WHERE Estado = 1
GO

--------------------------INSERTAR 
CREATE PROCEDURE InsertarProductos
@nombre NVARCHAR(100),
@descrip NVARCHAR(100),
@marca NVARCHAR(100),
@precio FLOAT,
@stock INT,
@estado BIT
AS
INSERT INTO Productos (Nombre, Descripcion, Marca, Precio, Stock, Estado) 
VALUES (@nombre, @descrip, @marca, @precio, @stock, @estado)
GO


------------------------ELIMINACIÓN LÓGICA
CREATE PROC EliminarProducto
@idpro INT
AS
UPDATE Productos SET Estado = 0 WHERE Id = @idpro
GO

------------------EDITAR
CREATE PROC EditarProductos
@nombre NVARCHAR (100),
@descrip NVARCHAR (100),
@marca NVARCHAR (100),
@precio FLOAT,
@stock INT,
@id INT
AS
UPDATE Productos 
SET Nombre = @nombre, 
    Descripcion = @descrip, 
    Marca = @marca, 
    Precio = @precio, 
    Stock = @stock 
WHERE Id = @id AND Estado = 1
GO
