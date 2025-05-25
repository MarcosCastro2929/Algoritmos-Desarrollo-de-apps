CREATE TABLE Cliente (
    Id_cliente INT IDENTITY (1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Direccion VARCHAR(255),
    Telefono VARCHAR(20),
    Correo VARCHAR(100),
	Estado bit
);

CREATE TABLE Factura (
    Id INT IDENTITY (1,1) PRIMARY KEY,
    Fecha DATE NOT NULL,
    Id_cliente INT NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
	Estado bit
);



CREATE TABLE Articulo (
    Id_articulo INT IDENTITY (1,1) PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Precio DECIMAL(10,2) NOT NULL,
    Stock INT NOT NULL,
	Estado bit
);

CREATE TABLE Detalle (
    IdDetalle INT PRIMARY KEY IDENTITY(1,1),
    IdFactura INT NOT NULL,
    IdProducto INT NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(10,2) NOT NULL,
    Subtotal DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IdFactura) REFERENCES Factura(Id),
    FOREIGN KEY (IdProducto) REFERENCES Articulo(Id_articulo)
);

select * from Detalle
select * from Factura
select * from Cliente





CREATE PROCEDURE BuscarCliente (
    @p_TerminoBusqueda VARCHAR(100)
)
As
BEGIN
    SELECT Id_cliente, Nombre, Direccion, Telefono, Correo
    FROM Cliente
    WHERE Nombre LIKE CONCAT('%', @p_TerminoBusqueda, '%')
       OR Telefono LIKE CONCAT('%', @p_TerminoBusqueda, '%')
       OR Correo LIKE CONCAT('%', @p_TerminoBusqueda, '%');
END;


-- ...


CREATE PROCEDURE RegistrarFactura (
    @p_Id_cliente INT,
    @p_Total DECIMAL(10,2),
    @p_Fecha DATE
)
As
BEGIN
    INSERT INTO Factura (Fecha, Id_cliente, Total)
    VALUES (@p_Fecha, @p_Id_cliente, @p_Total);
    
    SELECT SCOPE_IDENTITY() AS IdFactura;   
END;

-- .......

CREATE PROCEDURE RegistrarDetalleFactura (
    @p_IdFactura INT,
    @p_IdArticulo INT,
    @p_Cantidad INT,
    @p_Precio DECIMAL(10,2)
)
As
BEGIN
    INSERT INTO Detalle (Id_factura, Id_articulo, Cantidad, Precio)
    VALUES (@p_IdFactura, @p_IdArticulo, @p_Cantidad, @p_Precio);
END;

-- ...

CREATE PROCEDURE ActualizarStock (
    @p_IdArticulo INT,
    @p_CantidadVendida INT
)
As
BEGIN
    UPDATE Articulo
    SET Stock = Stock - @p_CantidadVendida
    WHERE Id_articulo = @p_IdArticulo;
END;

-- ..........


CREATE PROCEDURE CalcularTotalVenta (
    @p_IdFactura INT
)
AS
BEGIN
   
    DECLARE @total DECIMAL(10,2);

    SELECT @total = SUM(D.Cantidad * D.Precio)
    FROM Detalle D
    WHERE D.Id_factura = @p_IdFactura;

    UPDATE Factura
    SET Total = @total
    WHERE Id = @p_IdFactura;
    
    SELECT @total AS TotalVenta;
END;













-- Procedimientos para la tabla Cliente

-- Insertar Cliente
CREATE PROCEDURE InsertarCliente
    @Nombre VARCHAR(100),
    @Direccion VARCHAR(255),
    @Telefono VARCHAR(20),
    @Correo VARCHAR(100),
    @Estado BIT
AS
BEGIN
    INSERT INTO Cliente (Nombre, Direccion, Telefono, Correo, Estado)
    VALUES (@Nombre, @Direccion, @Telefono, @Correo, @Estado);
END;

-- Actualizar Cliente
CREATE PROCEDURE ActualizarCliente
    @Id_cliente INT,                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
    @Nombre VARCHAR(100),
    @Direccion VARCHAR(255),
    @Telefono VARCHAR(20),
    @Correo VARCHAR(100),
    @Estado BIT
AS
BEGIN
    UPDATE Cliente
    SET Nombre = @Nombre, Direccion = @Direccion, Telefono = @Telefono, Correo = @Correo, Estado = @Estado
    WHERE Id_cliente = @Id_cliente;
END;

-- Eliminar Cliente
CREATE PROCEDURE EliminarCliente
    @Id_cliente INT
AS
BEGIN
    DELETE FROM Cliente WHERE Id_cliente = @Id_cliente;
END;





-- Obtener Clientes
CREATE PROCEDURE ObtenerClientesCombo2
AS
BEGIN
    SELECT Id_cliente, Nombre, Direccion, Telefono, Correo 
    FROM Cliente
    WHERE Estado = 1;
END;










-- Procedimientos para la tabla Articulo

-- Insertar Articulo
CREATE PROCEDURE InsertarArticulo
    @Nombre VARCHAR(100),
    @Precio DECIMAL(10,2),
    @Stock INT,
    @Estado BIT
AS
BEGIN
    INSERT INTO Articulo (Nombre, Precio, Stock, Estado)
    VALUES (@Nombre, @Precio, @Stock, @Estado);
END;

-- Actualizar Articulo
CREATE PROCEDURE ActualizarArticulo
    @Id_articulo INT,
    @Nombre VARCHAR(100),
    @Precio DECIMAL(10,2),
    @Stock INT,
    @Estado BIT
AS
BEGIN
    UPDATE Articulo
    SET Nombre = @Nombre, Precio = @Precio, Stock = @Stock, Estado = @Estado
    WHERE Id_articulo = @Id_articulo;
END;

-- Eliminar Articulo
CREATE PROCEDURE EliminarArticulo
    @Id_articulo INT
AS
BEGIN
    DELETE FROM Articulo WHERE Id_articulo = @Id_articulo;
END;

-- Obtener Articulos
CREATE PROCEDURE ObtenerArticulosCombo2
AS
BEGIN
    SELECT * From Articulo WHERE Estado = 1;
END;






-- Procedimientos para la tabla Factura

-- Insertar Factura
CREATE PROCEDURE InsertarFactura
    @Fecha DATE,
    @Id_cliente INT,
    @Total DECIMAL(10,2),
    @Estado BIT
AS
BEGIN
    INSERT INTO Factura (Fecha, Id_cliente, Total, Estado)
    VALUES (@Fecha, @Id_cliente, @Total, @Estado);
END;

-- Actualizar Factura
CREATE PROCEDURE ActualizarFactura
    @Id INT,
    @Fecha DATE,
    @Id_cliente INT,
    @Total DECIMAL(10,2),
    @Estado BIT
AS
BEGIN
    UPDATE Factura
    SET Fecha = @Fecha, Id_cliente = @Id_cliente, Total = @Total, Estado = @Estado
    WHERE Id = @Id;
END;

-- Eliminar Factura
CREATE PROCEDURE EliminarFactura
    @Id INT
AS
BEGIN
    DELETE FROM Factura WHERE Id = @Id;
END;

-- Obtener Facturas
CREATE PROCEDURE ObtenerFacturas
AS
BEGIN
    SELECT * FROM Factura;
END;

-- Procedimientos para la tabla Detalle

-- Insertar Detalle
CREATE PROCEDURE InsertarDetalle
    @Id_factura INT,
    @Id_articulo INT,
    @Cantidad INT,
    @Precio DECIMAL(10,2),
    @Estado BIT
AS
BEGIN
    INSERT INTO Detalle (Id_factura, Id_articulo, Cantidad, Precio, Estado)
    VALUES (@Id_factura, @Id_articulo, @Cantidad, @Precio, @Estado);
END;

-- Actualizar Detalle
CREATE PROCEDURE ActualizarDetalle
    @Id_detalle INT,
    @Id_factura INT,
    @Id_articulo INT,
    @Cantidad INT,
    @Precio DECIMAL(10,2),
    @Estado BIT
AS
BEGIN
    UPDATE Detalle
    SET Id_factura = @Id_factura, Id_articulo = @Id_articulo, Cantidad = @Cantidad, Precio = @Precio, Estado = @Estado
    WHERE Id_detalle = @Id_detalle;
END;

-- Eliminar Detalle
CREATE PROCEDURE EliminarDetalle
    @Id_detalle INT
AS
BEGIN
    DELETE FROM Detalle WHERE Id_detalle = @Id_detalle;
END;

-- Obtener Detalles
CREATE PROCEDURE ObtenerDetalles
AS
BEGIN
    SELECT * FROM Detalle;
END;




--de la base de manuel


CREATE TYPE DetalleType AS TABLE (
    IdProducto INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2)
);
GO

CREATE TYPE DetalleFacturaType AS TABLE
(
    IdProducto INT,
    Cantidad INT,
    PrecioUnitario DECIMAL(10,2)
);



CREATE OR ALTER PROCEDURE InsertarFactura
    @IdCliente INT,
    @Detalles DetalleFacturaType READONLY,
    @Mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @IdFactura INT;
    DECLARE @Total DECIMAL(12,2) = 0;
    DECLARE @Error BIT = 0;
    DECLARE @MensajeError VARCHAR(500) = '';
    
    -- Validar cliente existente
    IF NOT EXISTS (SELECT 1 FROM Cliente WHERE Id_cliente = @IdCliente AND Estado = 1)
    BEGIN
        SET @MensajeError = 'El cliente no existe o está inactivo';
        GOTO ManejarError;
    END
    
    -- Validar que hay detalles
    IF NOT EXISTS (SELECT 1 FROM @Detalles)
    BEGIN
        SET @MensajeError = 'La factura debe contener al menos un producto';
        GOTO ManejarError;
    END
    
    -- Calcular el total
    SELECT @Total = SUM(Cantidad * PrecioUnitario) FROM @Detalles;
    
    -- Validar total positivo
    IF @Total <= 0
    BEGIN
        SET @MensajeError = 'El total de la factura debe ser mayor que cero';
        GOTO ManejarError;
    END
    
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Validar stock antes de procesar
        IF EXISTS (
            SELECT 1 FROM @Detalles d
            JOIN Articulo a ON d.IdProducto = a.Id_articulo
            WHERE a.Stock < d.Cantidad
        )
        BEGIN
            SET @MensajeError = 'Uno o más productos no tienen suficiente stock';
            GOTO ManejarError;
        END
        
        -- Insertar la factura
        INSERT INTO Factura (Fecha, Id_cliente, Total, Estado)
        VALUES (GETDATE(), @IdCliente, @Total, 1); -- Estado = 1 (activo)
        
        SET @IdFactura = SCOPE_IDENTITY();
        
        -- Insertar los detalles usando el precio actual del producto
        INSERT INTO Detalle (IdFactura, IdProducto, Cantidad, PrecioUnitario, Subtotal)
        SELECT 
            @IdFactura, 
            d.IdProducto, 
            d.Cantidad, 
            a.Precio, -- Precio actual del producto
            d.Cantidad * a.Precio
        FROM @Detalles d
        INNER JOIN Articulo a ON d.IdProducto = a.Id_articulo
        WHERE a.Estado = 1; -- Solo productos activos
        
        -- Actualizar el stock de los productos
        UPDATE a
        SET a.Stock = a.Stock - d.Cantidad
        FROM Articulo a
        INNER JOIN @Detalles d ON a.Id_articulo = d.IdProducto;
        
        COMMIT TRANSACTION;
        
        SET @Mensaje = 'Factura creada correctamente';
        RETURN @IdFactura;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        SET @Error = 1;
        SET @MensajeError = ERROR_MESSAGE();
        GOTO ManejarError;
    END CATCH
    
    ManejarError:
        SET @Mensaje = @MensajeError;
        RAISERROR(@MensajeError, 16, 1);
        RETURN -1;
END
GO




CREATE PROCEDURE ObtenerFacturaPorId
    @IdFactura INT
AS
BEGIN
    SELECT 
        f.Id AS IdFactura,
        f.Fecha,
        f.Id_cliente AS IdCliente,
        c.Nombre AS NombreCliente,
        c.Direccion,
        c.Telefono,
        f.Total,
        f.Estado
    FROM Factura f
    INNER JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    WHERE f.Id = @IdFactura;
END
GO



CREATE PROCEDURE ObtenerFacturasPorCliente
    @IdCliente INT
AS
BEGIN
    SELECT 
        f.Id AS IdFactura,
        f.Fecha,
        f.Total,
        f.Estado
    FROM Factura f
    WHERE f.Id_cliente = @IdCliente
    AND f.Estado = 1
    ORDER BY f.Fecha DESC;
END
GO



CREATE PROCEDURE ObtenerFacturasPorFecha
    @FechaInicio DATE,
    @FechaFin DATE
AS
BEGIN
    SELECT 
        f.Id AS IdFactura,
        f.Fecha,
        c.Nombre AS NombreCliente,
        f.Total,
        f.Estado
    FROM Factura f
    INNER JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    WHERE CAST(f.Fecha AS DATE) BETWEEN @FechaInicio AND @FechaFin
    ORDER BY f.Fecha DESC;
END
GO




CREATE OR ALTER PROCEDURE AnularFactura
    @IdFactura INT,
    @Mensaje VARCHAR(500) OUTPUT
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Verificar que la factura existe y está activa
    IF NOT EXISTS (SELECT 1 FROM Factura WHERE Id = @IdFactura AND Estado = 1)
    BEGIN
        SET @Mensaje = 'La factura no existe o ya está anulada';
        RETURN;
    END
    
    BEGIN TRANSACTION;
    BEGIN TRY
        -- Devolver stock a productos
        UPDATE p
        SET p.Stock = p.Stock + d.Cantidad
        FROM Articulo p
        INNER JOIN Detalle d ON p.Id_articulo = d.IdProducto
        WHERE d.IdFactura = @IdFactura;
        
        -- Marcar factura como anulada
        UPDATE Factura 
        SET Estado = 0 
        WHERE Id = @IdFactura;
        
        COMMIT TRANSACTION;
        SET @Mensaje = 'Factura anulada correctamente';
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
            
        SET @Mensaje = 'Error al anular factura: ' + ERROR_MESSAGE();
    END CATCH
END
GO





CREATE OR ALTER PROCEDURE sp_ObtenerUltimaFacturaCompleta
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @IdUltimaFactura INT = (SELECT MAX(Id) FROM Factura);
    
    -- Encabezado de la factura
    SELECT 
        f.Id AS IdFactura,
        CONVERT(VARCHAR, f.Fecha, 103) AS FechaFormateada,
        c.Nombre AS Cliente,
        c.Direccion,
        c.Telefono,
        c.Correo,
        f.Total
    FROM Factura f
    INNER JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    WHERE f.Id = @IdUltimaFactura;
    
    -- Detalles de la factura
    SELECT 
        p.Nombre AS Producto,
        df.Cantidad,
        df.PrecioUnitario,
        df.Subtotal
    FROM Detalle df
    INNER JOIN Articulo p ON df.IdProducto = p.Id_articulo
    WHERE df.IdFactura = @IdUltimaFactura
    ORDER BY df.IdDetalle;
END
GO




CREATE OR ALTER PROCEDURE sp_ReporteFacturaSimple
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        f.Id AS IdFactura,
        CONVERT(VARCHAR, f.Fecha, 103) AS FechaFormateada,
        c.Nombre AS Cliente,
        c.Direccion,
        c.Telefono,
        p.Nombre AS Producto,
        df.Cantidad,
        df.PrecioUnitario,
        df.Subtotal,
        f.Total
    FROM Factura f
    JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    JOIN Detalle df ON f.Id = df.IdFactura
    JOIN Articulo p ON df.IdProducto = p.Id_articulo
    WHERE f.Id = (SELECT MAX(Id) FROM Factura)
    ORDER BY df.IdDetalle;
END
GO






EXEC sp_GenerarUltimaFactura2;






Alter PROCEDURE ObtenerUltimaFactura
AS
BEGIN
    -- Obtener los datos del cliente de la última factura
    SELECT 
        c.Nombre AS ClienteNombre,
        c.Direccion AS ClienteDireccion,
        c.Telefono AS ClienteTelefono,
        f.Id AS FacturaId,
        f.Fecha AS FacturaFecha,
        f.Total AS FacturaTotal
    FROM 
        Cliente c
    INNER JOIN 
        Factura f ON c.Id_cliente = f.Id_cliente
    WHERE 
        f.Id = (SELECT TOP 1 Id FROM Factura ORDER BY Fecha DESC);

    -- Obtener los productos (artículos) vendidos en la última factura
    SELECT 
        a.Nombre AS ArticuloNombre,
        a.Precio AS ArticuloPrecio,
        d.Cantidad AS DetalleCantidad,
        d.PrecioUnitario AS DetallePrecioUnitario,
        d.Subtotal AS DetalleSubtotal
    FROM 
        Detalle d
    INNER JOIN 
        Articulo a ON d.IdProducto = a.Id_articulo
    WHERE 
        d.IdFactura = (SELECT TOP 0 Id FROM Factura ORDER BY Fecha DESC);
END;


CREATE OR ALTER PROCEDURE sp_ReporteFacturaSimple2
AS
BEGIN
    SET NOCOUNT ON;

    -- Obtener los datos generales de la factura y el cliente (esto solo lo muestra una vez)
    SELECT 
        f.Id AS IdFactura,
        CONVERT(VARCHAR, f.Fecha, 103) AS FechaFormateada,
        c.Nombre AS Cliente,
        c.Direccion,
        c.Telefono,
        f.Total
    FROM Factura f
    JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    WHERE f.Id = (SELECT MAX(Id) FROM Factura);

    -- Obtener los detalles de los productos vendidos (esto puede tener varias filas por cada producto comprado)
    SELECT 
        p.Nombre AS Producto,
        df.Cantidad,
        df.PrecioUnitario,
        df.Subtotal
    FROM Detalle df
    JOIN Articulo p ON df.IdProducto = p.Id_articulo
    WHERE df.IdFactura = (SELECT MAX(Id) FROM Factura)
    ORDER BY df.IdDetalle;
END
GO


CREATE OR ALTER PROCEDURE sp_ReporteFacturaSimple3
AS
BEGIN
    SET NOCOUNT ON;

    -- Obtener los datos generales de la factura y el cliente junto con los detalles de los productos
    SELECT 
        f.Id AS IdFactura,
        CONVERT(VARCHAR, f.Fecha, 103) AS FechaFormateada,
        c.Nombre AS Cliente,
        c.Direccion,
        c.Telefono,
        f.Total,
        p.Nombre AS Producto,
        df.Cantidad,
        df.PrecioUnitario,
        df.Subtotal
    FROM Factura f
    JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    JOIN Detalle df ON f.Id = df.IdFactura
    JOIN Articulo p ON df.IdProducto = p.Id_articulo
    WHERE f.Id = (SELECT MAX(Id) FROM Factura)
    ORDER BY df.IdDetalle;
END
GO


CREATE PROCEDURE [dbo].[sp_GenerarUltimaFactura]
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @id_factura INT;
    
    -- Obtener el ID de la última factura registrada
    SELECT @id_factura = MAX(Id) FROM Factura;

    -- Obtener los datos de la última factura con sus detalles
    SELECT 
        f.Id AS NumeroFactura,
        f.Fecha AS Fecha,
        c.Nombre AS NombreCliente,
        c.Direccion AS DireccionCliente,
        c.Telefono AS TelefonoCliente,
        c.Correo AS CorreoCliente,
        a.Id_articulo AS CodigoArticulo,
        a.Nombre AS Descripcion,
        d.Cantidad AS Cantidad,
        d.PrecioUnitario AS PrecioUnitario,
        d.Subtotal AS Importe,
        f.Total AS TotalFactura
    FROM Factura f
    INNER JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    INNER JOIN Detalle d ON f.Id = d.IdFactura
    INNER JOIN Articulo a ON d.IdProducto = a.Id_articulo
    WHERE f.Id = @id_factura;
END;
GO



Alter PROCEDURE [dbo].[sp_GenerarUltimaFactura2]
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @id_factura INT;
    
    -- Obtener el ID de la última factura registrada
    SELECT @id_factura = MAX(Id) FROM Factura;

    -- Obtener los datos de la última factura con sus detalles
    SELECT 
        f.Id AS NumeroFactura,                   -- Número de la factura
        f.Fecha AS Fecha,                        -- Fecha de la factura
        c.Nombre AS NombreCliente,               -- Nombre del cliente
        c.Direccion AS DireccionCliente,         -- Dirección del cliente
        c.Telefono AS TelefonoCliente,           -- Teléfono del cliente
        c.Correo AS CorreoCliente,               -- Correo del cliente
        a.Id_articulo AS CodigoArticulo,         -- Código del artículo (Id)
        a.Nombre AS NombreProducto,                 -- Descripción del artículo (Nombre)
        d.Cantidad AS Cantidad,                  -- Cantidad del producto
        d.PrecioUnitario AS PrecioUnitario,      -- Precio unitario del producto
        d.Subtotal AS Subtotal,                   -- Importe del producto (Cantidad * PrecioUnitario)
        f.Total AS TotalFactura                  -- Total de la factura
    FROM Factura f
    INNER JOIN Cliente c ON f.Id_cliente = c.Id_cliente
    INNER JOIN Detalle d ON f.Id = d.IdFactura
    INNER JOIN Articulo a ON d.IdProducto = a.Id_articulo
    WHERE f.Id = @id_factura;
END;
GO
INSERT INTO Cliente (Nombre, Direccion, Telefono, Correo, Estado) VALUES
('Carlos Pérez', 'Calle 10 #45, Santo Domingo', '3456789', 'carlos.perez@email.com', 1),
('María González', 'Av. Central #123, Santiago', '4567890', 'maria.gonzalez@email.com', 1),
('Juan Rodríguez', 'C/ Libertad #22, La Vega', '5678901', 'juan.rodriguez@email.com', 1),
('Ana Martínez', 'Km 8 Duarte, San Cristóbal', '6789012', 'ana.martinez@email.com', 1),
('Pedro Ramírez', 'Barrio Nuevo #34, San Pedro', '7890123', 'pedro.ramirez@email.com', 1),
('Laura Herrera', 'Zona Colonial, Santo Domingo', '8901234', 'laura.herrera@email.com', 1),
('José López', 'Villa Juana, Distrito Nacional', '9012345', 'jose.lopez@email.com', 1),
('Lucía Fernández', 'Ensanche Piantini, Santo Domingo', '0123456', 'lucia.fernandez@email.com', 1),
('Miguel Torres', 'C/ Principal #56, La Romana', '1234567', 'miguel.torres@email.com', 1),
('Elena Duarte', 'Los Jardines, Santiago', '2345678', 'elena.duarte@email.com', 1);


INSERT INTO Articulo (Nombre, Precio, Stock, Estado) VALUES
('Laptop Lenovo', 75000.00, 10, 1),
('Mouse Inalámbrico', 1500.00, 50, 1),
('Teclado Mecánico', 3500.00, 30, 1),
('Monitor 24 Pulgadas', 12000.00, 15, 1),
('Impresora HP', 8500.00, 20, 1),
('Disco Duro SSD 1TB', 9500.00, 25, 1),
('Memoria RAM 16GB', 4800.00, 40, 1),
('Tarjeta Gráfica RTX 3060', 32000.00, 5, 1),
('Silla Gamer', 18000.00, 12, 1),
('Auriculares Bluetooth', 3200.00, 35, 1),
('Micrófono Profesional', 7800.00, 18, 1),
('Router WiFi 6', 6200.00, 22, 1),
('Cámara Web HD', 4100.00, 28, 1),
('Fuente de Poder 650W', 9200.00, 14, 1),
('Escritorio para PC', 21500.00, 8, 1);
