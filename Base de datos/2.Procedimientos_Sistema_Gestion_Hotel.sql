--PROCEDIMIENTO ALMACENADO DE LOGUEAR
CREATE PROCEDURE USP_Usuario_Loguear
    @pnombre varchar(150),
    @pclave varchar(12) 
AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
        SELECT u.id_usuario,u.nombre,u.apellido,p.nombre_tipo_usuario
        FROM dbo.Usuario as u   
		INNER JOIN dbo.Tipo_Usuario as p
		ON u.id_tipo_usuario = p.id_tipo_usuario
        WHERE nombre = @pnombre AND clave = @pclave
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

--PROCEDIMIENTO LISTAR HOTELES DE EMPRESA
CREATE PROCEDURE USP_Empresa_Listar
    @pid_usuario int

AS
BEGIN
        SELECT h.nombre,h.direccion,h.ciudad,h.pais,h.categoria,h.imagen,h.horario,h.descripcion FROM dbo.Hotel as h 
		JOIN dbo.Usuario as u
		ON u.id_usuario = h.id_usuario
        WHERE u.id_usuario = @pid_usuario
END
GO
--PROCEDIMIENTO AGREGAR EMPRESA
CREATE PROCEDURE USP_Empresa_I
@pid_hotel int,
@pid_usuario int
AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO dbo.Empresa
            VALUES(@pid_usuario, @pid_hotel)
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

--PROCEDIMIENTO ALMACENADO DE INSERTAR EN LA TABAL USUARIO
CREATE PROCEDURE USP_Usuario_I
@ptipo_usuario int,
@ptipo_documento int,
@pnombre varchar(150),
@papellido varchar(250),
@ptelefono char(9),
@pdireccion varchar(250),
@pclave char(12),
@pnumero_documento varchar(25)
AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO dbo.Usuario
            VALUES(@ptipo_usuario, @ptipo_documento, @pnombre, @papellido, @ptelefono,@pdireccion,@pclave,@pnumero_documento)
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

--INSERTAR TIPO USUARIO
CREATE PROCEDURE USP_Tipo_I
@pnombre_tipo varchar(150)
AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO dbo.Tipo_Usuario
            VALUES(@pnombre_tipo)
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

--PROCEDIMIENTO ALMACENADO DE VERIFICAR EN LA TABLA USUARIO
CREATE PROCEDURE USP_Usuario_verificar
    @pvalor varchar(100),
    @existe bit output

AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
        if EXISTS(SELECT numero_documento FROM Usuario WHERE numero_documento=LTRIM(rtrim(@pvalor)))
            BEGIN
                SET @existe=1
            END
        ELSE
            BEGIN
                SET @existe=0
            END
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

-- listar hotel
CREATE PROCEDURE USP_Hotel_S
	AS
BEGIN
	SELECT id_hotel,nombre,direccion,ciudad,pais,categoria,imagen,horario,descripcion FROM Hotel
END
GO

-- BUSCAR HOTEL
CREATE PROCEDURE USP_Hotel_S_Buscar
  @pbusqueda varchar(150)
AS
BEGIN	
	SELECT id_hotel, nombre, direccion, ciudad, pais, categoria, imagen, horario, descripcion
	FROM dbo.Hotel
	WHERE 
	nombre LIKE '%' + @pbusqueda + '%'
	OR
	descripcion LIKE '%' + @pbusqueda + '%'
END
GO

--BUscar empresa
CREATE PROCEDURE USP_Empresa_S_Buscar
  @pbusqueda varchar(150),
  @pidusuario int
AS
BEGIN	
	SELECT h.nombre, h.direccion, h.ciudad, h.pais, h.categoria, h.imagen, h.horario, h.descripcion
	FROM dbo.Hotel as h
	JOIN dbo.Usuario as u
	ON u.id_usuario=h.id_usuario
	WHERE 
	(h.nombre LIKE '%' + @pbusqueda + '%'
	OR
	descripcion LIKE '%' + @pbusqueda + '%') AND u.id_usuario=@pidusuario
END
GO

--PROCEDIMIENTO ALMACENADO DE VERIFICAR EN LA TABLA HOTEL
CREATE PROCEDURE USP_Hotel_Verificar
    @pvalor varchar(100),
    @existe bit output

AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
        if EXISTS(SELECT nombre FROM Hotel WHERE nombre=LTRIM(rtrim(@pvalor)))
            BEGIN
                SET @existe=1
            END
        ELSE
            BEGIN
                SET @existe=0
            END
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

--procedimiento insertar hotel
CREATE PROCEDURE USP_Hotel_I

@pnombre_hotel varchar(150),
@pdireccion_hotel varchar(250),
@pciudad varchar(250),
@ppais varchar(50),
@pcategoria varchar(25),
@pimagen image,
@phorario varchar(50),
@pdescripcion varchar(250),
@pidusuario int
AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO dbo.Hotel
            VALUES(@pnombre_hotel, @pdireccion_hotel, @pciudad, @ppais, @pcategoria,@pimagen,@phorario,@pdescripcion,@pidusuario)
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

SELECT * FROM dbo.Hotel
WHERE id_usuario=24
GO

--Contador
CREATE PROCEDURE USP_Contador
	AS
BEGIN
	SELECT COUNT(id_hotel) FROM Hotel
END
GO

--LISTAR HABITACIONES
CREATE PROCEDURE USP_Habitacion_S
@pidhotel int
	AS
BEGIN
	SELECT h.id_habitacion,t.tipo_nombre_habitacion,h.cantidad,h.precio,h.disponibilidad,h.descripcion FROM dbo.Habitacion as h
	JOIN dbo.Tipo_Hab as t
	ON t.id_tipo_habitacion=h.id_tipo_habitacion
	JOIN dbo.Hotel as ht
	ON ht.id_hotel=h.id_hotel
	WHERE h.id_hotel=@pidhotel
END
GO

--INSERTAR RESERVA
CREATE PROCEDURE USP_Reserva_I

@pidreserva int,
@pidusuario int,
@pestado varchar(250),
@pfecha date

AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO dbo.Reserva
            VALUES(@pidreserva,@pidusuario, @pestado, @pfecha)
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END

GO

--procedimiento insertar hotel
CREATE PROCEDURE USP_Habitacion_I
@pid_hotel int,
@pid_tipo_habitacion int,
@pcantidad int,
@pprecio decimal,
@pdisponibilidad varchar(25),
@pdescripcion varchar(250)
AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO dbo.Habitacion
            VALUES(@pid_hotel, @pid_tipo_habitacion, @pcantidad, @pprecio, @pdisponibilidad,@pdescripcion)
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

--Ver Hotel id de Hotel Registrado
CREATE PROCEDURE USP_Hotel_Registrado
@pnombre varchar(150)
AS
SELECT id_hotel FROM dbo.Hotel
WHERE nombre = @pnombre
GO
--Actualizar Hotel
CREATE PROCEDURE USP_Hotel_U
@pid_hotel int,
@pnombre int,
@pdireccion varchar(150),
@pciudad varchar(100),
@ppais varchar(50),
@pcategoria varchar(25),
@pimagen image,
@phorario varchar(50),
@pdescripcion varchar(250),
@pidusuario int
AS
BEGIN
BEGIN TRAN
BEGIN TRY
UPDATE dbo.Hotel SET 
nombre = @pnombre,
direccion = @pdireccion,
ciudad = @pciudad,
pais = @ppais,
categoria = @pcategoria,
imagen = @pimagen,
horario = @phorario,
descripcion = @pdescripcion,
id_usuario = @pidusuario
WHERE id_hotel = @pid_hotel
COMMIT
END TRY
BEGIN CATCH
ROLLBACK
END CATCH
END
GO


--PROCEDIMIENTO LISTAR RESERVAS
CREATE PROCEDURE USP_Reserva_Listar
    @pid_usuario int

AS
BEGIN
        SELECT r.id_reserva,u.id_usuario,r.estado,r.fecha FROM dbo.Reserva as r 
		JOIN dbo.Usuario as u
		ON u.id_usuario = r.id_usuario
        WHERE u.id_usuario = @pid_usuario
END
GO


--INSERTAR DETALLE RESERVA
CREATE PROCEDURE USP_Detalle_Reserva_I

@pidhabitacion int,
@pidreserva int

AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
            INSERT INTO dbo.Detalle_Reserva
            VALUES(@pidhabitacion, @pidreserva)
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END

GO

--LISTAR RESERVAS PARA EMPRESA
CREATE PROCEDURE USP_ReservaEmpresa_Listar
    @pid_usuario int

AS
BEGIN
		SELECT dr.id_reserva,re.estado,ho.nombre,tip.tipo_nombre_habitacion,h.disponibilidad,h.precio,tu.nombre,re.fecha FROM dbo.Usuario as u 
		JOIN dbo.Hotel as ho
		ON ho.id_usuario = u.id_usuario
		JOIN dbo.Habitacion as h
		ON h.id_hotel = ho.id_hotel
		LEFT JOIN dbo.Tipo_Hab as tip
		ON tip.id_tipo_habitacion = h.id_tipo_habitacion
		JOIN dbo.Detalle_Reserva as dr
		ON dr.id_habitacion=h.id_habitacion
		LEFT JOIN dbo.Reserva as re
		ON re.id_reserva=dr.id_reserva
		LEFT JOIN dbo.Usuario as tu
		ON tu.id_usuario =re.id_usuario
        WHERE u.id_usuario = @pid_usuario
END
GO

--LISTAR RESERVAS PARA EMPRESA REPORTE
CREATE PROCEDURE USP_ReservaEmpresa_Listar_Reporte

AS
BEGIN
		SELECT dr.id_reserva,re.estado,ho.nombre,tip.tipo_nombre_habitacion,h.disponibilidad,h.precio,tu.nombre,re.fecha FROM dbo.Usuario as u 
		JOIN dbo.Hotel as ho
		ON ho.id_usuario = u.id_usuario
		JOIN dbo.Habitacion as h
		ON h.id_hotel = ho.id_hotel
		LEFT JOIN dbo.Tipo_Hab as tip
		ON tip.id_tipo_habitacion = h.id_tipo_habitacion
		JOIN dbo.Detalle_Reserva as dr
		ON dr.id_habitacion=h.id_habitacion
		LEFT JOIN dbo.Reserva as re
		ON re.id_reserva=dr.id_reserva
		LEFT JOIN dbo.Usuario as tu
		ON tu.id_usuario =re.id_usuario
END
GO

--CANTIDAD DE RESERVAS POR CLIENTES 

CREATE PROCEDURE USP_Reserva_Cantidad

AS
BEGIN
    BEGIN TRAN
        BEGIN TRY
        SELECT u.nombre,count(r.id_reserva) AS cantidad_de_reservas,ROUND(( count(r.id_reserva)*100)/(SELECT count(r.id_reserva) FROM dbo.Reserva as r),2) AS porcentaje FROM dbo.Reserva as r 
		JOIN dbo.Usuario as u
		ON u.id_usuario = r.id_usuario
		GROUP BY u.nombre
    COMMIT
        END TRY 
        BEGIN CATCH
            ROLLBACK
        END CATCH
    END
GO

--LISTAR RESERVAS PARA EMPRESA REPORTE
CREATE PROCEDURE USP_ReservaEmpresa_Listar_Reporte_Parametro
    @pnombre varchar(100)
AS
BEGIN
		SELECT dr.id_reserva,re.estado,ho.nombre,tip.tipo_nombre_habitacion,h.disponibilidad,h.precio,tu.nombre,re.fecha FROM dbo.Usuario as u 
		JOIN dbo.Hotel as ho
		ON ho.id_usuario = u.id_usuario
		JOIN dbo.Habitacion as h
		ON h.id_hotel = ho.id_hotel
		LEFT JOIN dbo.Tipo_Hab as tip
		ON tip.id_tipo_habitacion = h.id_tipo_habitacion
		JOIN dbo.Detalle_Reserva as dr
		ON dr.id_habitacion=h.id_habitacion
		LEFT JOIN dbo.Reserva as re
		ON re.id_reserva=dr.id_reserva
		LEFT JOIN dbo.Usuario as tu
		ON tu.id_usuario =re.id_usuario
        WHERE u.nombre = @pnombre
END
GO

--LISTAR TOTAL PRECIO PARA EMPRESA
CREATE PROCEDURE USP_ReservaEmpresa_Listar_Reporte_Precio_Parametro
    @pnombre varchar(100)
AS
BEGIN
		SELECT ho.nombre as nombre_hotel,count(re.id_reserva) as total_reserva,SUM(h.precio) AS total FROM dbo.Usuario as u 
		JOIN dbo.Hotel as ho
		ON ho.id_usuario = u.id_usuario
		JOIN dbo.Habitacion as h
		ON h.id_hotel = ho.id_hotel
		LEFT JOIN dbo.Tipo_Hab as tip
		ON tip.id_tipo_habitacion = h.id_tipo_habitacion
		JOIN dbo.Detalle_Reserva as dr
		ON dr.id_habitacion=h.id_habitacion
		LEFT JOIN dbo.Reserva as re
		ON re.id_reserva=dr.id_reserva
		LEFT JOIN dbo.Usuario as tu
		ON tu.id_usuario =re.id_usuario
        WHERE u.nombre = @pnombre
		GROUP BY ho.nombre,h.precio
END
GO






