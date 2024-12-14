use FERRETERIA


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


select *from usuario