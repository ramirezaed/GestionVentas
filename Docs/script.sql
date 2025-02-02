create datAbase FERRETERIA


USE [FERRETERIA]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] NOT NULL,
	[descripcion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[dni_cliente] [int] NULL,
	[fecha_nac] [date] NULL,
	[telefono] [int] NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NULL,
	[id_producto] [int] NULL,
	[cantidad] [int] NULL,
	[precio_unitario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[stock] [int] NULL,
	[stock_minimo] [int] NULL,
	[precio_compra] [real] NULL,
	[precio_venta] [real] NULL,
	[estado] [bit] NOT NULL,
	[codigo_pro] [int] NULL
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_usuario]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_usuario](
	[id_tipo] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni_usuario] [int] NULL,
	[fecha_nac] [date] NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [int] NULL,
	[usuario] [varchar](20) NULL,
	[contraseña] [varchar](20) NULL,
	[estado] [bit] NOT NULL,
	[id_tipo] [int] NULL,
	[descripcionUsuario] [varchar](50) NULL,

PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NULL,
	[fecha_ven] [date] NULL,
	[id_usuario] [int] NULL,
	[precio_total] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalle]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[detalle]  WITH CHECK ADD FOREIGN KEY([id_venta])
REFERENCES [dbo].[venta] ([id_venta])
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipo_usuario] ([id_tipo])
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
/****** Object:  StoredProcedure [dbo].[ControProd]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[ControProd]
@estado as int,
@stockminimo as int

as	
begin

	SELECT * FROM Producto
	WHERE stock <= @stockminimo or estado = @estado
	end 
GO
/****** Object:  StoredProcedure [dbo].[reporte_prod]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROC [dbo].[reporte_prod]
@estado as int,
@minstock as int
as	
begin
	SELECT * from producto
	WHERE stock <=@minstock or estado = @estado 

end
GO
/****** Object:  StoredProcedure [dbo].[reporte_producto]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[reporte_producto]
as	
	SELECT * FROM Producto
	WHERE stock <= stock_minimo or estado = 0 


GO
/****** Object:  StoredProcedure [dbo].[reporte_usuario]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[reporte_usuario]
as	
	SELECT * FROM usuario
GO
/****** Object:  StoredProcedure [dbo].[reporte_ventas]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[reporte_ventas]
@fecha as date,
@fecha2 as date
as 
select *  from Venta where fecha_ven >= @fecha and fecha_ven <= @fecha2 
GO
/****** Object:  StoredProcedure [dbo].[reportefechas]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[reportefechas]
@fecha as date	,
@fecha2 as date
as
select * from venta where fecha_ven >= @fecha and fecha_ven <= @fecha
GO
/****** Object:  StoredProcedure [dbo].[sp_comprobante]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_comprobante]

as 
BEGIN
SELECT top (1)v.id_venta,
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle,
p.nombre ,
p.descripcion as 'producto',
d.cantidad as 'detalle',
v.fecha_ven  as 'venta',

d.precio_unitario,
v.precio_total

FROM Venta v INNER JOIN Usuario u ON (v.id_usuario = u.id_usuario)
			 INNER JOIN cliente	 c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN Detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN producto p ON (d.id_producto = p.id_producto)
		--	 WHERE v.id_venta = d.id_detalle
		order by v.id_venta desc
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_compUna]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_compUna]
@idVenta INT
AS

BEGIN
SELECT  v.id_venta,
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle,
p.nombre ,
p.descripcion as 'producto',
d.cantidad as 'detalle',
v.fecha_ven  as 'venta',

d.precio_unitario,
v.precio_total

FROM Venta v INNER JOIN Usuario u ON (v.id_usuario = u.id_usuario)
			 INNER JOIN cliente	 c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN Detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN producto p ON (d.id_producto = p.id_producto)
			 WHERE v.id_venta = @idVenta
	--	order by v.id_venta desc
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_unaVenta111]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_unaVenta111]

as 
BEGIN
SELECT top (1)v.id_venta,
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle ,
p.descripcion AS 'Producto',

d.precio_unitario,
v.precio_total

FROM Venta v INNER JOIN Usuario u ON (v.id_usuario = u.id_usuario)
			 INNER JOIN cliente	 c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN Detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN producto p ON (d.id_producto = p.id_producto)
		--	 WHERE v.id_venta = d.id_detalle
		order by v.id_venta desc
 end
GO
/****** Object:  StoredProcedure [dbo].[sp_unEmpleadoVentas]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_unEmpleadoVentas]
@idEmpleado INT,
@fechaDesde DATETIME,
@fechaHasta DATETIME
AS
BEGIN
SELECT v.id_venta,
v.fecha_ven,
--(DATEDIFF(,u.fecha_nac,GETDATE())) AS 'Edad',
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle ,
p.nombre AS 'Producto',
--cat.descripcion AS 'Categoria',
d.precio_unitario,
v.precio_total
FROM Usuario u INNER JOIN Venta v ON (u.id_usuario = v.id_usuario)
			 INNER JOIN cliente c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN producto p ON (d.id_producto = p.id_producto)
			 --INNER JOIN Categorias cat ON (p.idCategoria = cat.idCategoria)
 WHERE (u.id_usuario = @idEmpleado AND (v.fecha_ven BETWEEN @fechaDesde AND @fechaHasta))
END

GO
/****** Object:  StoredProcedure [dbo].[sp_Venta]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_Venta]
AS
BEGIN
SELECT v.id_venta,
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle ,
p.nombre AS 'Producto',
--cat.descripcion AS 'Categoria',
d.precio_unitario,
v.precio_total,
d.cantidad as 'cantidad'


FROM Venta v INNER JOIN  usuario u ON (v.id_usuario = u.id_usuario)
			 INNER JOIN cliente c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN producto p ON (d.id_producto = p.id_producto)
			 --INNER JOIN Categorias cat ON (p.idCategoria = cat.idCategoria)
order by d.cantidad desc
--ORDER BY u.apellido,c.apellido
END


GO
/****** Object:  StoredProcedure [dbo].[sp_ventaPorfecha]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_ventaPorfecha]
@fecha DATETIME,
@fecha2 DATETIME
AS
BEGIN
SELECT v.id_venta,
v.fecha_ven,
--(DATEDIFF(yy,u.fecha_nac,GETDATE())) AS 'Edad',
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle ,
p.nombre AS 'Producto',
--cat.descripcion AS 'Categoria',
d.precio_unitario,
v.precio_total
FROM usuario u INNER JOIN venta v ON (u.id_usuario = v.id_usuario)
			 INNER JOIN cliente c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN Producto p ON (d.id_producto = p.id_producto)
			 --INNER JOIN Categorias cat ON (p.idCategoria = cat.idCategoria)
 WHERE (v.fecha_ven >= @fecha and v.fecha_ven <= @fecha2)




END
GO
/****** Object:  StoredProcedure [dbo].[sp_ventaPorfecha1]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_ventaPorfecha1]
@fecha DATETIME,
@fecha2 DATETIME
AS
BEGIN
SELECT v.id_venta,
v.fecha_ven,
--(DATEDIFF(yy,u.fecha_nac,GETDATE())) AS 'Edad',
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle ,
p.nombre AS 'Producto',
--cat.descripcion AS 'Categoria',
d.precio_unitario,
v.precio_total
FROM usuario u INNER JOIN venta v ON (u.id_usuario = v.id_usuario)
			 INNER JOIN cliente c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN Producto p ON (d.id_producto = p.id_producto)
			 --INNER JOIN Categorias cat ON (p.idCategoria = cat.idCategoria)
 WHERE (v.fecha_ven >= @fecha) and (v.fecha_ven <= @fecha2)




END
GO
/****** Object:  StoredProcedure [dbo].[Vdeldia]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[Vdeldia]
@fecha DATE

AS
BEGIN
SELECT v.id_venta,
v.fecha_ven,
--(DATEDIFF(yy,u.fecha_nac,GETDATE())) AS 'Edad',
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle ,
p.nombre AS 'Producto',
--cat.descripcion AS 'Categoria',
d.precio_unitario,
v.precio_total
FROM usuario u INNER JOIN venta v ON (u.id_usuario = v.id_usuario)
			 INNER JOIN cliente c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN Producto p ON (d.id_producto = p.id_producto)
			 --INNER JOIN Categorias cat ON (p.idCategoria = cat.idCategoria)
 WHERE v.fecha_ven = @fecha


END
GO
/****** Object:  StoredProcedure [dbo].[VentasDelDia]    Script Date: 9/11/2020 5:46:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[VentasDelDia]
@fecha DATETIME

AS
BEGIN
SELECT v.id_venta,
v.fecha_ven,
--(DATEDIFF(yy,u.fecha_nac,GETDATE())) AS 'Edad',
u.apellido + ', ' + u.nombre AS 'Vendedor',
c.apellido + ', ' + c.nombre AS 'Cliente',
d.id_detalle ,
p.nombre AS 'Producto',
--cat.descripcion AS 'Categoria',
d.precio_unitario,
v.precio_total
FROM usuario u INNER JOIN venta v ON (u.id_usuario = v.id_usuario)
			 INNER JOIN cliente c ON (v.id_cliente = c.id_cliente)
			 INNER JOIN detalle d ON (v.id_venta = d.id_venta)
			 INNER JOIN Producto p ON (d.id_producto = p.id_producto)
			 --INNER JOIN Categorias cat ON (p.idCategoria = cat.idCategoria)
 WHERE (v.fecha_ven = @fecha )


END
GO


insert into categoria(id_categoria, descripcion)
values (1, 'inalambrica'), (2, 'manual'), (3, 'electricas');


insert into tipo_usuario(id_tipo, descripcion)
values (1, 'admin'), (2, 'gerente'), (3, 'vendedor');


insert into usuario(nombre, apellido, dni_usuario, fecha_nac, direccion, telefono, usuario, contraseña, estado, id_tipo, descripcionUsuario)
values ('alejandro', 'ramirez', 35186245, '1990-03-25', 'moreno 657', '15263215', 'admin', 'admin', 1, 1, 'administrador');

insert into usuario(nombre, apellido, dni_usuario, fecha_nac, direccion, telefono, usuario, contraseña, estado, id_tipo, descripcionUsuario)
values ('ricardo', 'aquino', 38569290, '1996-09-20', 'rivadavia 693', '127625', 'gerente', 'gerente', 1, 2, 'gerente');

insert into usuario(nombre, apellido, dni_usuario, fecha_nac, direccion, telefono, usuario, contraseña, estado, id_tipo, descripcionUsuario)
values ('mario', 'gomez', 3658245, '1990-05-15', 'san juan 156', '1563259', 'usuario', 'usuario', 1, 3, 'vendedor');

use FERRETERIA

insert into cliente (nombre,apellido, domicilio, email, dni_cliente, fecha_nac, telefono, estado)
values  ('s/n', 's/n','s/n','s/n', 00000001,'1940-09-20', '00000000', 1);


CREATE PROCEDURE MostrarProductoPorCodigo
    @cod_producto INT
AS
BEGIN
    SELECT *
    FROM dbo.producto
    WHERE codigo_pro = @cod_producto;
END;

 CREATE PROCEDURE sp_VentasPorUsuarioYFecha
    @usuario VARCHAR(20),
    @fechaDesde DATE,
    @fechaHasta DATE
AS
BEGIN
    SELECT v.id_venta, v.fecha_ven, u.apellido + ', ' + u.nombre AS 'Vendedor',
           c.apellido + ', ' + c.nombre AS 'Cliente', d.id_detalle,
           p.nombre AS 'Producto', d.precio_unitario, v.precio_total
    FROM venta v
    INNER JOIN usuario u ON v.id_usuario = u.id_usuario
    INNER JOIN cliente c ON v.id_cliente = c.id_cliente
    INNER JOIN detalle d ON v.id_venta = d.id_venta
    INNER JOIN producto p ON d.id_producto = p.id_producto
    WHERE u.usuario = @usuario AND v.fecha_ven BETWEEN @fechaDesde AND @fechaHasta
END


alter PROCEDURE unEmpleadoVentas2
    @usuario VARCHAR(20), -- Cambia el tipo de datos según tus necesidades
    @fechaDesde DATETIME,
    @fechaHasta DATETIME
AS
BEGIN
    SELECT v.id_venta,
        v.fecha_ven,
        u.apellido + ', ' + u.nombre AS 'Vendedor',
        c.apellido + ', ' + c.nombre AS 'Cliente',
        d.id_detalle,
        p.nombre AS 'Producto',
        d.precio_unitario,
        v.precio_total
    FROM Usuario u
    INNER JOIN Venta v ON (u.id_usuario = v.id_usuario)
    INNER JOIN cliente c ON (v.id_cliente = c.id_cliente)
    INNER JOIN detalle d ON (v.id_venta = d.id_venta)
    INNER JOIN producto p ON (d.id_producto = p.id_producto)
    WHERE (u.usuario = @usuario AND (v.fecha_ven BETWEEN @fechaDesde AND @fechaHasta))
END






CREATE PROCEDURE mostrarTOP10masvendidos
    @cod_producto INT,
    @fecha_inicio DATE,
    @fecha_final DATE
AS
BEGIN
    SELECT TOP 10
        p.codigo_pro AS cod_producto,
        p.nombre AS nombre_producto,
        SUM(d.cantidad) AS total_vendido
    FROM detalle AS d
    INNER JOIN producto AS p ON d.id_producto = p.id_producto
    INNER JOIN venta AS v ON d.id_venta = v.id_venta
    WHERE p.codigo_pro = @cod_producto
        AND v.fecha_ven >= @fecha_inicio
        AND v.fecha_ven <= @fecha_final
    GROUP BY p.codigo_pro, p.nombre
    ORDER BY total_vendido DESC;
END
GO

ALTER PROCEDURE mostrarTOP10masvendidos
    @fecha_inicio DATE,
    @fecha_final DATE
AS
BEGIN
    SELECT TOP 10
        p.codigo_pro AS cod_producto,
        p.nombre AS nombre_producto,
        SUM(d.cantidad) AS total_vendido
    FROM detalle AS d
    INNER JOIN producto AS p ON d.id_producto = p.id_producto
    INNER JOIN venta AS v ON d.id_venta = v.id_venta
    WHERE v.fecha_ven >= @fecha_inicio
        AND v.fecha_ven <= @fecha_final
    GROUP BY p.codigo_pro, p.nombre
    ORDER BY total_vendido DESC;
END


ALTER TABLE dbo.usuario
ALTER COLUMN usuario VARCHAR(20) COLLATE Latin1_General_CS_AS;


CREATE PROCEDURE [dbo].[sp_recibo_compra]
@idVenta INT
AS
BEGIN
    SELECT  v.id_venta,
            u.apellido + ', ' + u.nombre AS 'Vendedor',
            c.apellido + ', ' + c.nombre AS 'Cliente',
            d.id_detalle,
            p.nombre as 'Nombre de Producto',
            p.descripcion AS 'Descripcion',
            d.cantidad AS 'Cantidad',
            v.fecha_ven AS 'Fecha de venta',
            d.precio_unitario as 'Precio Unitario',
            (d.cantidad * d.precio_unitario) AS 'Subtotal',
            v.precio_total as 'Total'
    FROM Venta v
    INNER JOIN Usuario u ON (v.id_usuario = u.id_usuario)
    INNER JOIN Cliente c ON (v.id_cliente = c.id_cliente)
    INNER JOIN Detalle d ON (v.id_venta = d.id_venta)
    INNER JOIN Producto p ON (d.id_producto = p.id_producto)
    WHERE v.id_venta = @idVenta;
    --	order by v.id_venta desc
END