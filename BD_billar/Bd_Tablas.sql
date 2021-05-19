--Nombre de la base de datos bd_billar
--Fecha de creación de la base de datos 28.03.2021
--Fecha de entrega 06.05.2021
--Número de equipo Equipo #6

CREATE DATABASE [bd_billar]
GO
USE bd_billar;
GO
CREATE TABLE [dbo].[Rol](
	[Id_Rol] [int] IDENTITY(1,1),
	[Nom_puesto] [varchar](25) NOT NULL,
	[Descrp_rol] [varchar](50) NOT NULL,
	CONSTRAINT pk_rol PRIMARY KEY (Id_Rol)
);

GO
CREATE TABLE [dbo].[Empleado](
	[Id_empleado] [int] IDENTITY(1,1),
	[Nom_empleado] [varchar](25) NOT NULL,
	[apepatEmpleado] [varchar](25) NOT NULL,
	[apematEmpleado] [varchar](25) NOT NULL,
	[telefonoEmpleado] [varchar](25) NOT NULL,
	[direccionEmpleado] [varchar](25) NOT NULL,
	[Id_Rol] [int] NOT NULL CONSTRAINT fk_empleado_rol FOREIGN KEY (Id_Rol) REFERENCES Rol
	CONSTRAINT pk_empleado PRIMARY KEY (Id_empleado)
);
GO

CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_Usuario] [varchar](25) NOT NULL,
	[Contrasena_Usuario] [varchar](10) NOT NULL,
	[Id_Empleado] [int] NOT NULL,
	CONSTRAINT pk_usuario PRIMARY KEY (Id_Usuario),
	CONSTRAINT fk_usuario_empleado FOREIGN KEY (Id_empleado) REFERENCES Empleado
);



GO
CREATE TABLE [dbo].[Marca](
	[Id_Marca] [int] IDENTITY(1,1),
	[Nom_marca] [varchar](25) NOT NULL,
	CONSTRAINT pk_marca PRIMARY KEY (Id_Marca)
);
GO
CREATE TABLE [dbo].[UnidadMedida](
	[Id_Umed] [int] IDENTITY(1,1),
	[Descripcion_Umed] [varchar](50) NOT NULL,
	[Abreviatura_Umed] [varchar](5) NOT NULL,
	CONSTRAINT pk_umed PRIMARY KEY (Id_Umed)
);
GO

CREATE TABLE [dbo].[Producto](
	[Id_Prod] [int] IDENTITY(1,1),
	[Nom_producto] [varchar](25) NOT NULL,
	[Id_Umed] [int] CONSTRAINT fk_producto_Umed FOREIGN KEY (Id_Umed) REFERENCES UnidadMedida,
	[Existencia] [int] NOT NULL,
	[Id_Marca] [int] CONSTRAINT fk_producto_marca FOREIGN KEY (Id_Marca) REFERENCES Marca,
	[Costo] [money] NOT NULL,
	[Precio] [money]NOT NULL,
	[Descp_producto ] [varchar](50) NOT NULL,
	[Estado][varchar](1) NOT NULL,--Correcion no se puede eliminar los productos por la fk en ventas
	CONSTRAINT pk_producto PRIMARY KEY (Id_Prod)
);
--SELECT * FROM ESTADO
GO
CREATE TABLE [dbo].[Estado](
	[Id_Estado] [varchar] (1) NOT NULL,
	[Nom_estado] [varchar](11) NOT NULL,
	CONSTRAINT pk_estado PRIMARY KEY (Id_Estado)
);
GO
CREATE TABLE [dbo].[Venta](
	[Id_venta] [int] IDENTITY(1,1) NOT NULL,--mantener la llave primaria como única
	[folio] [int] NOT NULL,--varios productos de la venta llevaran el mismo FOLIO para identificar la venta
	[Id_Usuario] [int] NOT NULL CONSTRAINT fk_venta_usuario FOREIGN KEY (Id_Usuario) REFERENCES Usuario,
	[fecha] [date] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Subtotal] [money] NOT NULL,
	[Id_Prod] [int] NOT NULL CONSTRAINT fk_venta_producto FOREIGN KEY (Id_Prod) REFERENCES Producto,
	[Id_Estado] [varchar](1) NOT NULL CONSTRAINT fk_venta_estado FOREIGN KEY (Id_Estado) REFERENCES Estado,
	CONSTRAINT pk_venta PRIMARY KEY (Id_venta)
);
GO
CREATE TABLE [dbo].[Tipo](
	[Id_tipo] [int] IDENTITY(1,1),
	[Nom_tipo] [varchar] (15) NOT NULL,
	CONSTRAINT pk_tipo PRIMARY KEY (Id_tipo)
);

CREATE TABLE [dbo].[Disponibilidad](
	[Id_Disponibilidad] [varchar](2) NOT NULL,
	[Descp_disponibilidad] [varchar] (11) NOT NULL,
	CONSTRAINT pk_disponibilidad PRIMARY KEY (Id_Disponibilidad)
);
GO
CREATE TABLE [dbo].[Mesa](
	[Id_mesa] [int] IDENTITY(1,1),
	[Id_tipo] [int] NOT NULL CONSTRAINT fk_mesa_tipo FOREIGN KEY (Id_tipo) REFERENCES Tipo,
	[Id_Disponibilidad] [varchar] (2) NOT NULL CONSTRAINT fk_mesa_disp FOREIGN KEY (Id_Disponibilidad) REFERENCES Disponibilidad,
	CONSTRAINT pk_mesa PRIMARY KEY (Id_Mesa)
);
GO
CREATE TABLE [dbo].[PagoMesa](
	[Id_pagoMesa] [int] IDENTITY(1,1),
	[Id_Usuario] [int] NOT NULL CONSTRAINT fk_pagoMesa_usuario FOREIGN KEY (Id_Usuario) REFERENCES Usuario,
	[fecha] [date] NOT NULL,
	[Id_mesa] [int] NOT NULL CONSTRAINT fk_pago_mesa FOREIGN KEY (Id_mesa) REFERENCES Mesa,
	[Tiempo_inicio] [time] NOT NULL,
	[Tiempo_fin] [time] NOT NULL,
	[Tiempo_total] [int] NOT NULL,
	[PagoTotal] [money] NOT NULL,
	CONSTRAINT pk_pago_mesa PRIMARY KEY (Id_pagoMesa)
);
GO
