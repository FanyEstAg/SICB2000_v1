---PROCEDIMEINTOS ALMACENADOS
---DROP PROC uspIniciar_Sesion
GO
CREATE PROC uspIniciar_Sesion--LISTO
@prmUsuario VARCHAR(25),
@prmContrasena VARCHAR(10)
	AS
		SELECT * FROM Usuario AS u
		INNER JOIN Empleado AS e ON u.Id_Empleado=e.Id_empleado
		INNER JOIN Rol AS r ON e.Id_Rol=r.Id_Rol
		WHERE  u.nombre_Usuario=@prmUsuario AND u.Contrasena_Usuario=@prmContrasena
GO
--SELECT * FROM Empleado
--------------------------------------------------------

CREATE PROCEDURE [dbo].[uspEliminarVentaXid]---LISTO
		@prmId_venta int
		AS
		 BEGIN
			 UPDATE Venta set Id_Estado='A'--Anulado
			 WHERE Id_Venta=@prmId_venta
		 END

GO
CREATE PROCEDURE [dbo].[uspEliminarUsuario]---LISTO----
		@prmId_Usuario int
		AS
		 BEGIN
			DELETE Usuario WHERE Id_Usuario=@prmId_Usuario
		 END
GO
CREATE PROCEDURE [dbo].[uspEliminarMesa]---LISTO----
		@prmId_Mesa	 int
		AS
		 BEGIN
			DELETE Mesa WHERE Id_mesa=@prmId_Mesa
		 END
GO
CREATE PROCEDURE [dbo].[uspEliminarProducto]---LISTO----
		@prmId_Producto	 int
		AS
		 BEGIN
			DELETE Producto WHERE Id_Prod=@prmId_Producto
		 END
GO
--DROP PROCEDURE  [dbo].[uspEliminarProducto]
SELECT * FROM Producto
SELECT * FROM Mesa
SELECT * FROM Usuario
GO
CREATE PROCEDURE [dbo].[uspBuscarProd] --3,'15.20' MODIFICAR
	@prmTipEntrada int,
	@prmValorEntrada nvarchar(50)
	as  
	BEGIN
	 SET NOCOUNT ON
	 IF(@prmTipEntrada = 1)
	  BEGIN -------------------------------------------------------
	  SELECT p.Id_Prod,Codigo_Prod, p.Nombre_Prod, p.Marca_Prod,c.Nombre_Cat,um.Descripcion_Umed,p.Precio_Prod,p.Stock_Prod,m.Nombre_Material
	  FROM Producto p INNER JOIN Categoria c ON p.Id_Cat_prod=c.Id_Cat
	                  INNER JOIN UnidadMedida um ON p.Id_Umed_prod=um.Id_Umed
					  INNER JOIN Proveedor pr ON p.Id_Proveedor_Producto = pr.Id_Proveedor 
					  INNER JOIN Material m ON p.IdMaterial = m.Id_Material
					  where p.Nombre_Prod LIKE '%'+@prmValorEntrada+'%' AND p.Estado_Prod=1		 
        END ----------------------------------------------------------
		 ELSE IF(@prmTipEntrada = 2)
		  BEGIN-------------------------------------------------------
		   	  SELECT p.Id_Prod,Codigo_Prod, p.Nombre_Prod, p.Marca_Prod,c.Nombre_Cat,um.Descripcion_Umed,p.Precio_Prod,p.Stock_Prod,m.Nombre_Material
	             FROM Producto p INNER JOIN Categoria c ON p.Id_Cat_prod=c.Id_Cat
	                  INNER JOIN UnidadMedida um ON p.Id_Umed_prod=um.Id_Umed
					  INNER JOIN Proveedor pr ON p.Id_Proveedor_Producto = pr.Id_Proveedor 
					  INNER JOIN Material m ON p.IdMaterial = m.Id_Material
					  where c.Nombre_Cat LIKE '%'+@prmValorEntrada+'%' AND p.Estado_Prod=1	
		  END---------------------------------------------------------
		   ELSE
		    BEGIN----------------------------------------------------
				  SELECT p.Id_Prod,Codigo_Prod, p.Nombre_Prod, p.Marca_Prod,c.Nombre_Cat,um.Descripcion_Umed,p.Precio_Prod,p.Stock_Prod,m.Nombre_Material
	              FROM Producto p INNER JOIN Categoria c ON p.Id_Cat_prod=c.Id_Cat
	                  INNER JOIN UnidadMedida um ON p.Id_Umed_prod=um.Id_Umed
					  INNER JOIN Proveedor pr ON p.Id_Proveedor_Producto = pr.Id_Proveedor 
					  INNER JOIN Material m ON p.IdMaterial = m.Id_Material
					  where p.Precio_Prod LIKE '%'+@prmValorEntrada+'%' AND p.Estado_Prod=1	
			END-------------------------------------------------------
	 SET NOCOUNT OFF
	END

GO
CREATE PROCEDURE [dbo].[uspBuscarProducto] --MODIFICAR
	@prmId_Prod int
	as
	 BEGIN
	  SET NOCOUNT ON
	   SELECT p.Id_Prod,p.Codigo_Prod, p.Nombre_Prod, p.Marca_Prod,p.PrecioCompra_Prod,p.Precio_Prod,
	   p.Stock_Prod,p.StockProm_Prod,p.StockMin_Prod,c.Id_Cat,um.Id_Umed,pr.Id_Proveedor,m.Id_Material
	  FROM Producto p INNER JOIN Categoria c ON p.Id_Cat_prod=c.Id_Cat
	                  INNER JOIN UnidadMedida um ON p.Id_Umed_prod=um.Id_Umed
					  INNER JOIN Proveedor pr ON p.Id_Proveedor_Producto = pr.Id_Proveedor
					  INNER JOIN Material m ON p.IdMaterial = m.Id_Material  where Estado_Prod=1
					  AND p.Id_Prod = @prmId_Prod
	  SET NOCOUNT OFF
	 END 

GO
GO
CREATE PROCEDURE [dbo].[uspBuscarUsuario] ---LISTO
	 @prmBusqueda varchar(25)
	 AS
	   BEGIN
		SELECT u.nombre_Usuario AS Usuario, Contrasena_Usuario AS Contraseña,
		e.Id_empleado, e.Nom_empleado AS Nnombre, e.apepatEmpleado AS Apellido_Pat, 
		e.apematEmpleado AS Apellido_Mat, e.telefonoEmpleado AS Teléfono, e.direccionEmpleado AS Dirección,
		 r.Nom_puesto AS Rol, r.Descrp_rol AS Descripción
		FROM Usuario u 
		INNER JOIN Empleado AS e ON u.Id_Empleado=e.Id_empleado
		INNER JOIN Rol AS r ON  r.Id_Rol=e.Id_Rol
		WHERE u.nombre_Usuario = @prmBusqueda OR u.Id_Usuario=@prmBusqueda OR e.Nom_empleado=@prmBusqueda

	END
GO
CREATE PROCEDURE [dbo].[uspBuscarMesa] ---LISTO
	 @prmBusqueda varchar(25)
	 AS
	   BEGIN
		SELECT m.Id_mesa,t.Nom_tipo,d.Id_Disponibilidad
		FROM Mesa m 
		INNER JOIN Tipo AS t ON m.Id_tipo=t.Id_tipo
		INNER JOIN Disponibilidad AS d ON  m.Id_Disponibilidad=d.Id_Disponibilidad
		WHERE m.Id_mesa = @prmBusqueda OR t.Nom_tipo=@prmBusqueda OR d.Descp_disponibilidad=@prmBusqueda

	END
GO
CREATE PROCEDURE [dbo].[uspCargarUsuarios]  ---LISTO
	 
	 AS
	   BEGIN
		SELECT u.nombre_Usuario AS Usuario, Contrasena_Usuario AS Contraseña,
		e.Id_empleado, e.Nom_empleado AS Nnombre, e.apepatEmpleado AS Apellido_Pat, 
		e.apematEmpleado AS Apellido_Mat, e.telefonoEmpleado AS Teléfono, e.direccionEmpleado AS Dirección,
		 r.Nom_puesto AS Rol, r.Descrp_rol AS Descripción
		FROM Usuario u 
		INNER JOIN Empleado AS e ON u.Id_Empleado=e.Id_empleado
		INNER JOIN Rol AS r ON  r.Id_Rol=e.Id_Rol
		
	END

GO
CREATE PROCEDURE [dbo].[uspCargarMesas]  ---LISTO
	 
	 AS
	   BEGIN
		SELECT m.Id_mesa,t.Nom_tipo AS Tipo,d.Id_Disponibilidad AS Disponibilidad
		FROM Mesa m 
		INNER JOIN Tipo AS t ON m.Id_tipo=t.Id_tipo
		INNER JOIN Disponibilidad AS d ON  m.Id_Disponibilidad=d.Id_Disponibilidad
		
	END

GO
CREATE PROCEDURE [dbo].[uspGuardarVenta]----MODIFICAR
	@Cadxml varchar(max)--se recibe el xml
	AS
	 BEGIN
	  DECLARE @out int, @smsmError nvarchar(500),@idVenta int --se declaran variables que se requeriran
	   EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml --permite procesar un documento XML y obtener una representación del mismo,
	    BEGIN TRY--inicio de la excepción
		 BEGIN TRANSACTION--se inicia una transacción
		 -- Control para venta no sea mayor que stock
		 IF(SELECT COUNT(*) FROM OpenXML(@out,'root/venta/detalle',1)WITH(
		   idproducto int,
		   cantidad int
		   )dt INNER JOIN Producto p on p.Id_Prod=dt.idproducto WHERE p.Stock_Prod<dt.cantidad)>0
		  BEGIN
		   RAISERROR('Uno ó mas productos no cuentan con el stock suficiente',16,1)
		  END

		  INSERT INTO Venta(Codigo_Venta, Id_Cliente_Venta, Id_Usuario_Venta, Id_Suc_Venta, Id_TipCom_Venta, Id_Moneda_Venta, 
		                         Id_TipPago_Venta,Serie_Venta,Correlativo_Venta, Igv_Venta, FechaVenta, Estado_Venta,Descuento_Venta,Desc_Venta)
           SELECT dbo.fnGenCodVenta(),v.idcliente,v.idusuario,v.idsucursal,v.istipcom,v.idmoneda,v.idtipopago,v.serie,
		   dbo.fnGenerarCorrelativo(@TIPO_DOC_VENTA,v.serie),v.igv,GETDATE(),'E',v.descuento,v.descripcion
		   FROM OpenXML(@h,'root/venta',1)WITH(
		   idcliente int,
		   idusuario int,
		   idsucursal int,
		   istipcom int,
		   idmoneda int,
		   idtipopago int,
		   igv int,
		   serie nchar(4),
		   descuento decimal(10,2),
		   descripcion nvarchar(200)
		   )v  
		   set @idVenta=@@IDENTITY
		   
		   INSERT INTO DetalleVenta(Id_Prod_Det, Id_Venta_Det, PrecProd_Det, Cantidad_Det) 
		   SELECT dt.idproducto,@idVenta,dt.precioprod,dt.cantidad
		   FROM OpenXML(@h,'root/venta/detalle',1)WITH(
		   idproducto int,
		   precioprod decimal(5,2),
		   cantidad int
		   )dt   
		   
		   IF(@@TRANCOUNT>0) COMMIT TRANSACTION
		END TRY

		BEGIN CATCH
		 IF(@@TRANCOUNT>0)
		   BEGIN
			 ROLLBACK TRANSACTION
			 SELECT @smsmError = ERROR_MESSAGE()
			 RAISERROR(@smsmError,16,1)
		   END
		END CATCH
	 END

GO

CREATE PROCEDURE [dbo].[spInsEditElimProducto] ---MODIFICAR
   @prmCadXml nvarchar(max)
    as
	 BEGIN
	  DECLARE @h int, @smsError varchar(500)
	  EXEC SP_XML_PREPAREDOCUMENT @h output, @prmCadXml
	   BEGIN TRY
	     BEGIN TRANSACTION
		   --Ingresar nuevo registro 
		   INSERT INTO Producto(Id_Cat_prod, Id_Umed_prod, Id_Proveedor_Producto, Codigo_Prod, Nombre_Prod, Marca_Prod, 
		                        PrecioCompra_Prod, Precio_Prod, Stock_Prod, StockProm_Prod, StockMin_Prod,UsuarioCreacion_Prod,IdMaterial)
		   SELECT p.idcat,p.idunmed,p.idprov,dbo.fnGenCodProducto(),p.nombre,p.marca,p.preciocompra,p.precio,
		          p.stock,p.stockprom,p.stockmin,p.usuariocreacion,p.idmaterial
		   FROM OpenXml(@h,'root/producto',1)WITH(
		   idcat int,
		   idunmed int,
		   idprov int,
		   nombre nvarchar(100),
		   marca nvarchar(50),
		   preciocompra decimal(5,2),
		   precio decimal(5,2),
		   stock int,
		   stockprom int,
		   stockmin int,
		   usuariocreacion int,
		   tipoedicion int,
		   idmaterial int
		   )p WHERE tipoedicion=1

		   -- Actualizando registro
		   UPDATE pro
		          SET pro.Id_Cat_prod=p.idcat,
				      pro.Id_Umed_prod=p.idunmed,
					  pro.Id_Proveedor_Producto=p.idprov,
					  pro.Nombre_Prod=p.nombre,
					  pro.Marca_Prod=p.marca,
					  pro.PrecioCompra_Prod=p.preciocompra,
					  pro.Precio_Prod=p.precio,
					  pro.Stock_Prod=p.stock,
					  pro.StockProm_Prod=p.stockprom,
					  pro.StockMin_Prod=p.stockmin,
					  pro.UsuarioUpdate_Prod = p.usuarioupdate,
					  pro.IdMaterial=p.idmaterial
           FROM OpenXml(@h,'root/producto',1)with(
		   idproducto int,
		   idcat int,
		   idunmed int,
		   idprov int,
		   nombre nvarchar(100),
		   marca nvarchar(50),
		   preciocompra decimal(5,2),
		   precio decimal(5,2),
		   stock int,
		   stockprom int,
		   stockmin int,
		   usuarioupdate int,
		   tipoedicion int,
		   idmaterial int
		   )p INNER JOIN Producto pro ON p.idproducto = pro.Id_Prod WHERE p.tipoedicion=2

		   -- Elimnado registro (actualiza estado)
		    UPDATE  pro
		          SET pro.Estado_Prod=0
           FROM OpenXml(@h,'root/producto',1)with(
		   idproducto int,
		   tipoedicion int
		   )p INNER JOIN Producto pro ON p.idproducto = pro.Id_Prod WHERE p.tipoedicion=3

		   IF (@@TRANCOUNT>0) COMMIT TRANSACTION
	    END TRY
		BEGIN CATCH
		 IF (@@TRANCOUNT>0) ROLLBACK TRANSACTION
		 SELECT @smsError = ERROR_MESSAGE()
		 RAISERROR(@smsError,16,1)
		END CATCH
	 END

GO

 CREATE PROCEDURE [dbo].[uspInsEditElimUnidMed] ---MODIFICAR
   @prmCadXml nvarchar(max)
    as
	 BEGIN
	  DECLARE @h int, @smsError varchar(500)
	  EXEC SP_XML_PREPAREDOCUMENT @h output, @prmCadXml
	   BEGIN TRY
	     BEGIN TRANSACTION
		   --Ingresar nuevo registro 
		   INSERT INTO UnidadMedida(Codigo_Umed, Descripcion_Umed, Abreviatura_Umed)
		   SELECT dbo.fnGenCodUnidadMedida(),um.descripcion,um.abreviatura
		   FROM OpenXml(@h,'root/unmedida',1)WITH(
		   descripcion nvarchar(50),
		   abreviatura nchar(20),
		   tipoedicion int
		   )um WHERE tipoedicion=1

		   -- Actualizando registro
		   UPDATE umda
		          SET umda.Descripcion_Umed =um.descripcion,
				      umda.Abreviatura_Umed = um.abreviatura
           FROM OpenXml(@h,'root/unmedida',1)with(
		   idunmedida int,
		   descripcion nvarchar(50),
		   abreviatura nchar(20),
		   tipoedicion int
		   )um INNER JOIN UnidadMedida umda ON um.idunmedida=umda.Id_Umed  WHERE um.tipoedicion=2

		   -- Elimnado registro (actualiza estado)
		    UPDATE umda
		          SET umda.Estado_Umed = 0    
           FROM OpenXml(@h,'root/unmedida',1)with(
		   idunmedida int,
		   tipoedicion int
		   )um INNER JOIN UnidadMedida umda ON um.idunmedida=umda.Id_Umed  WHERE um.tipoedicion=3

		   IF (@@TRANCOUNT>0) COMMIT TRANSACTION
	    END TRY
		BEGIN CATCH
		 IF (@@TRANCOUNT>0) ROLLBACK TRANSACTION
		 SELECT @smsError = ERROR_MESSAGE()
		 RAISERROR(@smsError,16,1)
		END CATCH
	 END

GO

CREATE PROCEDURE [dbo].[uspInsertarUsuario] ---LISTO
  @Cadxml varchar(max)
  as
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO Usuario(nombre_Usuario, Contrasena_Usuario,Id_Empleado)
		  SELECT  u.usuario, u.contrasena, u.idempleado --seleccionar ciertas partes del XML
		  FROM OpenXML(@out,'root/usuario', 1) WITH(
		 usuario varchar(25), contrasena varchar(10), idempleado int) u 
		
		  -- editando usuario
		  --UPDATE u 
		  --    SET u.Id_nivelAcc_Usuario = us.idnivelacceso,
			 --     u.Id_Suc_Usuario = us.idsucusuario,
				--  u.Nombre_Usuario = us.nombre,
				--  u.Login_Usuario = us.logeo,
				--  u.Password_Usuario = dbo.fnEncriptarPass(us.pass),
				--  u.Telefono_Usuario = us.telefono,
				--  u.Celular_Usuario = us.celular,
				--  u.Correo_Usuario = us.correo,
				--  u.Estado_Usuario = us.estado,
				--  u.Expiracion_Usuario = us.expiracion,
				--  u.UsuarioCreacion_Usuario = us.usuariocreacion
		  --FROM OpenXML(@h,'root/usuario',1)WITH(
		  --idusuario int,idnivelacceso int, idsucusuario int, nombre nvarchar(200), logeo nchar(8), pass nvarchar(50),
		  --telefono nchar(8), celular nchar(9), correo nvarchar(100), estado bit, expiracion datetime,
		  --usuariocreacion int, tipoedicion int)us INNER JOIN Usuario u ON us.idusuario=u.Id_Usuario WHERE tipoedicion=2--end

		  --Eliminando usuario(Cambio estado)
		  -- --DELETE Usuario WHERE  Id_Usuario=u.
		  -- --   SET u.Estado_Usuario = 0
		  --FROM OpenXML(@h,'root/usuario',1)WITH(
		  --idusuario int, tipoedicion int)us INNER JOIN Usuario u ON us.idusuario=u.Id_Usuario WHERE tipoedicion=3--end

		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END


GO

CREATE PROCEDURE [dbo].[uspInsertarEmpleado] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO Empleado(Nom_empleado,apepatEmpleado,apematEmpleado,telefonoEmpleado,direccionEmpleado,Id_Rol)
		  SELECT  e.nombre, e.apepat, e.apemat, e.telefono, e.direccion, e.idrol  --seleccionar ciertas partes del XML
		  FROM OpenXML(@out,'root/empleado', 1) WITH(nombre varchar(25), apepat varchar(25), apemat varchar(25), telefono varchar(25), direccion varchar(25), idrol int) e 
		SELECT* FROM Empleado
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END


GO
CREATE PROCEDURE [dbo].[uspInsertarMesa] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO Mesa(Id_tipo,Id_Disponibilidad)
		  SELECT  m.idtipo, m.iddisponibilidad --seleccionar ciertas partes del XML
		  FROM OpenXML(@out,'root/mesa', 1) WITH( idtipo int, iddisponibilidad varchar(2)) m
		--SELECT* FROM Mesa
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END
GO
CREATE PROCEDURE [dbo].[uspTipoMesa] ---LISTO
  @prmNombreTipo varchar(15)
  AS
  DECLARE @smsError nvarchar(300)
  BEGIN
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO Tipo(Nom_tipo)
		  VALUES (@prmNombreTipo)
		--SELECT* FROM Tipo
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END
GO
CREATE PROCEDURE [dbo].[uspActualizarMesa] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
		  -- editando usuario
		  UPDATE m
		      SET 
			  m.Id_tipo=cm.idtipo,
			  m.Id_Disponibilidad=cm.iddisponibilidad
			  FROM OpenXML(@out,'root/actMesa',1)WITH(
		  idmesa int, idtipo int, iddisponibilidad varchar(2)) cm 
		  INNER JOIN Mesa m ON cm.idmesa=m.Id_mesa
		  WHERE m.Id_mesa = cm.idmesa
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END


GO
SELECT * FROM 
GO
CREATE PROCEDURE [dbo].[uspCambiarContrasena] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
		  -- editando usuario
		  UPDATE u 
		      SET 
			  u.Contrasena_Usuario = us.nuevaContrasena
			  FROM OpenXML(@out,'root/cambioContra',1)WITH(
		  usuario int,contrasena varchar(10), nuevaContrasena varchar(10))us 
		  INNER JOIN Usuario u ON us.usuario=u.Id_Usuario
		  WHERE u.Id_Usuario = us.usuario
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END


GO
--DROP PROC uspVerificarDatosCambioContrasena
CREATE PROC uspVerificarDatosCambioContrasena--LISTO
@prmUsuario INT,
@prmContrasena VARCHAR(10)
	AS
		SELECT * FROM Usuario AS u
		WHERE  u.Id_Usuario=@prmUsuario AND u.Contrasena_Usuario=@prmContrasena
GO
SET NOCOUNT ON
SELECT COUNT(*) FROM Usuario AS u
		WHERE  u.Id_Usuario=1 AND u.Contrasena_Usuario='A12'
GO

CREATE PROCEDURE [dbo].[uspListaRol] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT * FROM Rol
		SET NOCOUNT OFF
	  END 

GO
CREATE PROCEDURE [dbo].[uspListaTipo] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT * FROM Tipo
		SET NOCOUNT OFF
	  END 

GO
CREATE PROCEDURE [dbo].[uspObtenerIdMesa] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT TOP 1 Id_mesa FROM Mesa ORDER BY Id_mesa DESC
		SET NOCOUNT OFF
	  END 
GO
CREATE PROCEDURE [dbo].[uspObtenerIdEmpleado] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT TOP 1 Id_empleado FROM Empleado ORDER BY Id_empleado DESC
		SET NOCOUNT OFF
	  END 
GO
SELECT * FROM Disponibilidad

--DELETE Empleado WHERE Id_empleado= (SELECT TOP 1 Id_empleado FROM Empleado ORDER BY Id_empleado DESC)
GO
CREATE PROCEDURE [dbo].[uspInsertarMarca] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO Marca(Nom_marca)
		  SELECT  m.nombre --seleccionar ciertas partes del XML
		  FROM OpenXML(@out,'root/marca', 1) WITH(nombre varchar(25)) m 
		--SELECT* FROM Marca
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END
GO
CREATE PROCEDURE [dbo].[usplistarProdIndicador]--modificar
		  @prmname nvarchar(100)
		  as
		   BEGIN
		   SET NOCOUNT ON
		   SELECT p.Id_Prod,p.Codigo_Prod,p.Nombre_Prod,p.PrecioCompra_Prod,p.Precio_Prod,p.Stock_Prod,p.StockProm_Prod,p.StockMin_Prod,
		           c.Nombre_Cat,um.Abreviatura_Umed,m.Nombre_Material FROM Producto p INNER JOIN UnidadMedida um ON p.Id_Umed_prod = um.Id_Umed 
		                          INNER JOIN Categoria c ON p.Id_Cat_prod = c.Id_Cat 
								  INNER JOIN Material m ON p.IdMaterial= m.Id_Material WHERE p.Estado_Prod=1
								  AND Nombre_Prod LIKE '%'+@prmname+'%' ORDER BY p.Stock_Prod
		   SET NOCOUNT OFF
		   END
GO

CREATE PROCEDURE [dbo].[uspListarProducto]--MODIFICAR
	as
	 BEGIN
	  SET NOCOUNT ON
	  SELECT Id_Prod,Codigo_Prod, Nombre_Prod, Marca_Prod,c.Nombre_Cat,um.Descripcion_Umed,pr.RazSocial_Proveedor
	  FROM Producto p INNER JOIN Categoria c ON p.Id_Cat_prod=c.Id_Cat
	                  INNER JOIN UnidadMedida um ON p.Id_Umed_prod=um.Id_Umed
					  INNER JOIN Proveedor pr ON p.Id_Proveedor_Producto = pr.Id_Proveedor where Estado_Prod=1
GO

CREATE PROCEDURE [dbo].[uspListarUnidMed]---MODIFICAR
	as
	BEGIN
	 SET NOCOUNT ON
       SELECT Id_Umed, Codigo_Umed, Descripcion_Umed, Abreviatura_Umed,Estado_Umed FROM UnidadMedida WHERE Estado_Umed=1
	 SET NOCOUNT OFF
	 END

GO

CREATE PROCEDURE [dbo].[uspListaVenta] -- MODIFICAR '2016-11-06','2016-12-08',0 
		@prmfinicio date,
		@prmfin date,
		@prmidsucursal int
		as
		 BEGIN
		   DECLARE @TotalVentas TABLE(Id_Venta int,Codigo_Venta nchar(11),Estado_Venta nchar(1),Id_TipCom int,Nombre_TipCom varchar(50),Correlativo_Venta int,FechaVenta datetime,Igv_Venta int,Descuento_Venta decimal(10,2),Total decimal(10,2),Id_TipPago int,Utilidad decimal(10,2),Inversion decimal(10,2))
		  if(@prmidsucursal = 0)
		    BEGIN
			INSERT INTO @TotalVentas(Id_Venta,Codigo_Venta,Estado_Venta,Id_TipCom ,Nombre_TipCom ,Correlativo_Venta ,FechaVenta ,Igv_Venta ,Descuento_Venta,Total,Id_TipPago)
				SELECT v.Id_Venta,v.Codigo_Venta,v.Estado_Venta,tc.Id_TipCom,tc.Nombre_TipCom,v.Correlativo_Venta,v.FechaVenta,
				v.Igv_Venta,v.Descuento_Venta,ISNULL(SUM(dt.Total_Det),0)Total, tp.Id_TipPago
				FROM Venta v LEFT JOIN DetalleVenta dt ON v.Id_Venta= dt.Id_Venta_Det
				INNER JOIN TipoComprobante tc ON v.Id_TipCom_Venta = tc.Id_TipCom 
				INNER JOIN TipoPago tp ON v.Id_TipPago_Venta=tp.Id_TipPago
				GROUP BY v.Id_Venta,v.Codigo_Venta,v.Igv_Venta,v.Estado_Venta,v.FechaVenta,v.Correlativo_Venta,tc.Nombre_TipCom,
				tp.Id_TipPago,tc.Id_TipCom,v.Descuento_Venta,v.Id_Suc_Venta
				HAVING CONVERT(date,v.FechaVenta) BETWEEN @prmfinicio and @prmfin
				ORDER BY v.FechaVenta DESC 
			END
			 ELSE 
			 BEGIN

			 INSERT INTO @TotalVentas(Id_Venta,Codigo_Venta,Estado_Venta,Id_TipCom ,Nombre_TipCom ,Correlativo_Venta ,FechaVenta ,Igv_Venta ,Descuento_Venta,Total,Id_TipPago)
			 SELECT v.Id_Venta,v.Codigo_Venta,v.Estado_Venta,tc.Id_TipCom,tc.Nombre_TipCom,v.Correlativo_Venta,v.FechaVenta,
				v.Igv_Venta,v.Descuento_Venta,ISNULL(SUM(dt.Total_Det),0)Total, tp.Id_TipPago
				FROM Venta v LEFT JOIN DetalleVenta dt ON v.Id_Venta= dt.Id_Venta_Det
				INNER JOIN TipoComprobante tc ON v.Id_TipCom_Venta = tc.Id_TipCom INNER JOIN TipoPago tp ON v.Id_TipPago_Venta=tp.Id_TipPago
				GROUP BY v.Id_Venta,v.Codigo_Venta,v.Igv_Venta,v.Estado_Venta,v.FechaVenta,v.Correlativo_Venta,tc.Nombre_TipCom,
				tp.Id_TipPago,tc.Id_TipCom,v.Descuento_Venta,v.Id_Suc_Venta
				HAVING CONVERT(date,v.FechaVenta) BETWEEN @prmfinicio and @prmfin and v.Id_Suc_Venta = @prmidsucursal
				ORDER BY v.FechaVenta DESC
			 END

			 /*CREAMOS CURSOR PARA RECORRER Y ACTUALIZAR UTILIDADES POR VENTA*/

			 DECLARE CursorVentas CURSOR FOR SELECT Id_Venta FROM @TotalVentas
			 OPEN CursorVentas
			   DECLARE @IDTemp int
			    FETCH CursorVentas INTO @IDTemp
				WHILE(@@FETCH_STATUS = 0)
				 BEGIN
				  DECLARE @Utilidad decimal(10,2)
				  DECLARE @MontoVendido decimal(10,2)
				  DECLARE @MontoComprado decimal(10,2)

				 SET @MontoVendido =  (SELECT Venta.Total - dscto.Descuento_Venta  FROM(SELECT SUM(Total_Det) total  FROM  DetalleVenta WHERE Id_Venta_Det = @IDTemp) AS Venta,  (SELECT Descuento_Venta FROM Venta  WHERE  Id_Venta = @IDTemp)as dscto)
			--	 SELECT @MontoVendido VENDIDO
				 SET @MontoComprado = (SELECT SUM(p.PrecioCompra_Prod * dt.Cantidad_Det) FROM Producto p 
				 INNER JOIN  DetalleVenta dt ON p.Id_Prod = dt.Id_Prod_Det 
                 WHERE dt.Id_Venta_Det = @IDTemp)
				-- SELECT @MontoComprado COMRADO
				 SET  @Utilidad = (@MontoVendido - @MontoComprado)
				-- SELECT @Utilidad UTILIDAD
				UPDATE @TotalVentas SET Utilidad = ISNULL(@Utilidad,0), Inversion = ISNULL(@MontoComprado,0) WHERE Id_Venta = @IDTemp
				 FETCH CursorVentas INTO @IDTemp
				 END
			 CLOSE CursorVentas
			 DEALLOCATE CursorVentas


		  SELECT * FROM @TotalVentas
		 END

GO

CREATE PROCEDURE [dbo].[uspMostrarCabeceraVenta] ---MODIFICAR
		 @prmid_venta int
		 as
		  BEGIN
		   SELECT v.Codigo_Venta,v.Serie_Venta,v.Correlativo_Venta,v.Igv_Venta,v.FechaVenta,v.Estado_Venta,v.Descuento_Venta,v.Desc_Venta,
		          c.Nombre_Cliente,td.Nombre_TipDoc,c.NumeroDoc_Cliente,u.Nombre_Usuario,s.Direccion_Suc,tc.Nombre_TipCom,m.Descripcion_Moneda,
		          tp.Descripcion_TipPago
		   FROM Venta v INNER JOIN Cliente c ON v.Id_Cliente_Venta=c.Id_Cliente 
		   INNER JOIN TipDocumento td  ON td.Id_TipDoc=c.Id_TipDoc_Cliente 
		   INNER JOIN Usuario u ON v.Id_Usuario_Venta = u.Id_Usuario 
		   INNER JOIN Sucursal s ON v.Id_Suc_Venta = s.Id_Suc
		   INNER JOIN TipoComprobante TC ON v.Id_TipCom_Venta = tc.Id_TipCom
		   INNER JOIN Moneda m ON M.Id_Moneda = V.Id_Moneda_Venta
		   INNER JOIN TipoPago tp ON tp.Id_TipPago = v.Id_TipPago_Venta 
		   WHERE v.Id_Venta= @prmid_venta

		   SELECT p.Codigo_Prod,p.Nombre_Prod,p.Precio_Prod, dv.PrecProd_Det, dv.Cantidad_Det, dv.Total_Det 
			FROM DetalleVenta dv INNER JOIN Producto p ON dv.Id_Prod_Det=p.Id_Prod
			WHERE dv.Id_Venta_Det = @prmid_venta
		  END
GO
CREATE PROCEDURE [dbo].[uspMostrarDescrpRol] --LISTO
 @prmRol int
 AS
	 BEGIN
		  SELECT r.Descrp_rol FROM Rol AS r 
		  WHERE r.Id_Rol=@prmRol
	 END
 GO

 SELECT * FROM Rol

CREATE PROCEDURE [dbo].[uspVerificarAcceso] --LISTO
  @prmUsuario varchar(25),
  @prmpassword varchar(10)
  AS
   BEGIN
     SET NOCOUNT ON--sin mostrar filas afectadas - menos segundos de ejecución
	   SELECT u.Id_Usuario, nombre_Usuario,e.Id_Rol, r.Nom_puesto, e.Id_empleado, e.Id_Rol 
	   FROM Usuario AS u
	   INNER JOIN Empleado AS e ON Id_Usuario=@prmUsuario 
	   INNER JOIN Rol AS r ON e.Id_Rol =r.Id_Rol
	    WHERE u.nombre_Usuario = @prmUsuario AND u.Contrasena_Usuario = @prmpassword	                                  
	 SET NOCOUNT OFF
   END
