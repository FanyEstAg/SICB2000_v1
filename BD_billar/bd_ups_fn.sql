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
CREATE PROCEDURE [dbo].[uspObtenerIdUsuario] ----Listo
@prmUsuario VARCHAR(25),
@prmContrasena VARCHAR(10)
  AS
	  BEGIN
		SELECT u.Id_Usuario FROM Usuario AS u
		INNER JOIN Empleado AS e ON u.Id_Empleado=e.Id_empleado
		INNER JOIN Rol AS r ON e.Id_Rol=r.Id_Rol
		WHERE  u.nombre_Usuario=@prmUsuario AND u.Contrasena_Usuario=@prmContrasena
	  END 
GO
--SELECT * FROM Empleado
--SELECT * FROM Usuario
--------------------------------------------------------
GO
CREATE PROCEDURE [dbo].[uspEliminarVentaXid]---LISTO
@prmId_venta int,
@prmId_producto int
	AS
		DECLARE @smsError nvarchar(300) --, @i int=0
			BEGIN
				BEGIN TRY
					BEGIN TRANSACTION
					PRINT @prmId_producto
					PRINT @prmId_venta 
						 UPDATE Venta set Id_Estado='A'--Anulado
						 WHERE folio=@prmId_venta
						UPDATE Producto SET Existencia=(SELECT p.Existencia+v.Cantidad FROM Venta AS v 
													INNER JOIN Producto AS p ON p.Id_Prod=v.Id_Prod
													WHERE v.folio=@prmId_venta AND P.Id_Prod=@prmId_producto)
						WHERE Id_Prod=@prmId_producto
						IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
				 END TRY

				 BEGIN CATCH
					IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
					SET @smsError= ERROR_MESSAGE()
					RAISERROR(@smsError,16,1)
				 END CATCH
END
		 --SELECT * FROM Producto
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
			UPDATE Producto 
			SET
			Estado='A'
			WHERE Id_Prod=@prmId_Producto
		 END
GO
--DROP PROCEDURE  [dbo].[uspEliminarProducto]
--SELECT * FROM Producto
--SELECT * FROM Mesa
--SELECT * FROM Usuario
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
CREATE PROCEDURE [dbo].[uspBuscarProducto] ---LISTO
	 @prmBusqueda varchar(25)
	 AS
	   BEGIN
			SELECT p.Id_Prod AS ID, 
			p.Nom_producto AS Nombre, 
			um.Descripcion_Umed AS ud_Medida, 
			p.[Descp_producto ] AS Descripcion, 
			p.Existencia,
			m.Nom_marca AS Marca, 
			p.Costo AS Costo, 
			p.Precio AS Precio
			FROM Producto p
			INNER JOIN Marca AS m ON p.Id_Marca=m.Id_Marca
			INNER JOIN UnidadMedida AS um ON p.Id_Umed=um.Id_Umed
			
			WHERE p.Nom_producto LIKE '%'+@prmBusqueda+'%' OR m.Nom_marca LIKE '%'+@prmBusqueda+'%'
			OR um.Abreviatura_Umed LIKE '%'+@prmBusqueda+'%' OR um.Descripcion_Umed LIKE '%'+@prmBusqueda+'%'
			AND p.Estado='C'
	END
GO
CREATE PROCEDURE [dbo].[uspBuscarProductoExistencia] ---LISTO
	 @prmBusqueda int
	 AS
	   BEGIN
			SELECT p.Id_Prod AS ID, p.Nom_producto AS Nombre,p.[Descp_producto ] AS Descripcion, 
			um.Descripcion_Umed AS ud_Medida, p.Existencia, m.Nom_marca AS Marca
			FROM Producto p
			INNER JOIN Marca AS m ON p.Id_Marca=m.Id_Marca
			INNER JOIN UnidadMedida AS um ON p.Id_Umed=um.Id_Umed
			WHERE @prmBusqueda=p.Id_Prod AND p.Estado='C'
	END
GO
CREATE PROCEDURE [dbo].[uspBuscarVentas]  ---LISTO
@prmIdVenta int
	 AS
	   BEGIN
		SELECT v.folio, v.fecha,p.Id_Prod,p.[Descp_producto ],p.Precio,v.Cantidad,v.Subtotal 
		FROM Venta v
		INNER JOIN Producto AS p ON v.Id_Prod=p.Id_Prod
		WHERE v.Id_Estado='C' AND v.folio=@prmIdVenta
	END
GO
CREATE PROCEDURE [dbo].[uspBuscarCobro]  ---LISTO
@prmIdCobro int
	 AS
	   BEGIN
		SELECT pm.Id_pagoMesa AS ID, pm.fecha AS Fecha, pm.Id_mesa AS 'Id Mesa', t.Nom_tipo AS Tipo, pm.Tiempo_total AS 'Tiempo Total', pm.PagoTotal AS Pago
		FROM PagoMesa pm
		INNER JOIN Mesa AS m ON pm.Id_mesa=m.Id_mesa
		INNER JOIN Tipo AS t ON m.Id_tipo=t.Id_tipo
		WHERE pm.Id_pagoMesa=@prmIdCobro
	END
GO
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
CREATE PROCEDURE [dbo].[uspCargarProductos]  ---LISTO
	 AS
	   BEGIN
		SELECT p.Id_Prod AS ID,
		p.Nom_producto AS Nombre, 
		um.Descripcion_Umed AS ud_Medida,  
		p.[Descp_producto ] AS Descripcion,
		p.Existencia, 
		m.Nom_marca AS Marca, 
		p.Costo AS Costo, 
		p.Precio AS Precio,
		e.Nom_estado AS Estado
		FROM Producto p
		INNER JOIN Marca AS m ON p.Id_Marca=m.Id_Marca
		INNER JOIN UnidadMedida AS um ON p.Id_Umed=um.Id_Umed
		INNER JOIN Estado AS e ON p.Estado=e.Id_Estado
		WHERE e.Id_Estado='C'
	END
GO
CREATE PROCEDURE [dbo].[uspCargarVentas]  ---LISTO
AS
	   BEGIN
		SELECT v.folio, v.fecha,p.Id_Prod,p.[Descp_producto ],p.Precio,v.Cantidad,v.Subtotal 
		FROM Venta v
		INNER JOIN Producto AS p ON v.Id_Prod=p.Id_Prod
		WHERE v.Id_Estado='C' 
	END
GO
CREATE PROCEDURE [dbo].[uspCargarCobros]  ---LISTO
AS
	   BEGIN
		SELECT pm.Id_pagoMesa AS ID, pm.fecha AS Fecha, pm.Id_mesa AS 'Id Mesa', t.Nom_tipo AS Tipo, pm.Tiempo_total AS 'Tiempo Total', pm.PagoTotal AS Pago
		FROM PagoMesa pm
		INNER JOIN Mesa AS m ON pm.Id_mesa=m.Id_mesa
		INNER JOIN Tipo AS t ON m.Id_tipo=t.Id_tipo
		
	END
GO
--SELECT * FROM PagoMesa
GO
--SELECT * FROM Venta WHERE Id_Estado='C' 
GO
--SELECT * FROM Producto
GO
CREATE PROCEDURE [dbo].[uspGuardarVenta]----LISTO
	@Cadxml varchar(max)--se recibe el xml
	AS
	 BEGIN
	  DECLARE @out int, @smsmError nvarchar(500) --se declaran variables que se requeriran
	   EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml --permite procesar un documento XML y obtener una representación del mismo,
	    BEGIN TRY--inicio de la excepción
		 BEGIN TRANSACTION--se inicia una transacción
		  --Control para venta no sea mayor que stock
		 IF(SELECT COUNT(*) FROM OpenXML(@out,'root/venta',1)WITH(
			   idproducto int,
			   cantidad int
			   )dt INNER JOIN Producto p on p.Id_Prod=dt.idproducto WHERE p.Existencia<dt.cantidad)>0
		  BEGIN
				RAISERROR('Uno ó mas productos no cuentan con existencia suficiente',16,1)
		  END
		ELSE
			BEGIN
			  INSERT INTO Venta(folio,Id_Usuario,fecha,Cantidad,Subtotal,Id_Prod,Id_Estado)
			   SELECT v.folio, v.idusuario, v.fecha, v.cantidad,v.subtotal, v.idproducto, v.idestado
			   FROM OpenXML(@out,'root/venta',1)WITH(
			   folio int,
			   idusuario int,
			   fecha date,
			   cantidad int,
			   subtotal money,
			   idproducto int,
			   idestado varchar(1)
		  
			   )v  
				UPDATE p--ACTUALIZAR INVENTARIO
				  SET 
				  p.Existencia=(SELECT Existencia-dt.cantidad FROM OpenXML(@out,'root/venta',1)WITH(
			   idproducto int,
			   cantidad int
			   )dt INNER JOIN Producto p on p.Id_Prod=dt.idproducto WHERE p.Id_Prod=dt.idproducto)
				  FROM OpenXML(@out,'root/venta',1)WITH(idproducto int, existencia int) cp
			  INNER JOIN Producto p ON cp.idproducto=p.Id_Prod
			  WHERE cp.idproducto=p.Id_Prod
		  END
		 	   
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
CREATE PROCEDURE [dbo].[uspGuardarCobroMesa] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO PagoMesa(Id_Usuario, fecha, Id_mesa, Tiempo_inicio, Tiempo_fin, Tiempo_total, PagoTotal)
		  SELECT  m.idusuario, m.fecha, m.idmesa, m.tiempoInicio, m.tiempoFinal, m.tiempoTotal, m.pagoTotal --seleccionar ciertas partes del XML
		  FROM OpenXML(@out,'root/cobroMesa', 1) WITH(idusuario int, fecha date, idmesa int, tiempoInicio time,
		  tiempoFinal time, tiempoTotal int, pagoTotal money) m
		--SELECT* FROM PagoMesa
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END
GO
CREATE PROCEDURE [dbo].[uspInsertarProducto] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO Producto(Nom_producto,Id_Umed,Existencia,Id_Marca,Costo,Precio,[Descp_producto ], Estado)
		  SELECT p.nomproducto, p.idumed, p.existencia, p.idmarca, p.costo, p.precio, p.descripcion, p.idestado --seleccionar ciertas partes del XML
		  FROM OpenXML(@out,'root/producto', 1) WITH( nomproducto varchar(25),
		  idumed int, existencia int, idmarca int, costo money, precio money,descripcion varchar(50), idestado varchar(1)) p
		--SELECT* FROM Producto
		 --SELECT * FROM Marca
		 --SELECT * FROM UnidadMedida
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
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
CREATE PROCEDURE [dbo].[uspInsertarTipoMesa] ---LISTO
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
CREATE PROCEDURE [dbo].[uspInsertarMarca] ---LISTO
  @prmNombre varchar(25)
  AS
  DECLARE @smsError nvarchar(300)
  BEGIN
	  BEGIN TRY
	   BEGIN TRANSACTION
	      -- Insertando nuevo usuario
		  INSERT INTO Marca
		  VALUES (@prmNombre)
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
CREATE PROCEDURE [dbo].[uspActualizarVenta]----LISTO
	@Cadxml varchar(max)--se recibe el xml
	AS
	 BEGIN
	  DECLARE @out int, @smsmError nvarchar(500) --se declaran variables que se requeriran
	   EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml --permite procesar un documento XML y obtener una representación del mismo,
	    BEGIN TRY--inicio de la excepción
		 BEGIN TRANSACTION--se inicia una transacción
		  --Control para venta no sea mayor que stock
		 IF(SELECT COUNT(*) FROM OpenXML(@out,'root/actVenta',1)WITH(
			   idproducto int,
			   cantidad int
			   )dt INNER JOIN Producto p on p.Id_Prod=dt.idproducto WHERE p.Existencia<dt.cantidad)>0
		  BEGIN
				RAISERROR('Uno ó mas productos no cuentan con existencia suficiente',16,1)
		  END
		ELSE
			BEGIN
			----ANULAR VENTA
			UPDATE Venta 
			set Id_Estado='A'--Anulado 
			FROM OpenXML(@out,'root/actVenta',1)WITH(folio int,
			   idusuario int,
			   fecha date,
			   cantidad int,
			   subtotal money,
			   idproducto int,
			   idestado varchar(1)) va 
		  INNER JOIN Venta v ON va.folio=v.folio
		  WHERE v.folio=va.folio

		  --ACTUALIZAR INVENTARIO TRAS ANULACION --verificar funcionamiento
			UPDATE p
			SET 
			 p.Existencia=(SELECT Existencia-dt.cantidad FROM OpenXML(@out,'root/actVenta',1)WITH(
			   idproducto int,
			   cantidad int
			   )dt INNER JOIN Producto p on p.Id_Prod=dt.idproducto WHERE p.Id_Prod=dt.idproducto)
				  FROM OpenXML(@out,'root/actVenta',1)WITH(idproducto int, existencia int) cp
			  INNER JOIN Producto p ON cp.idproducto=p.Id_Prod
			  WHERE cp.idproducto=p.Id_Prod

		  ---INSERTAR/ACTUALIZAR LA VENTA
			 INSERT INTO Venta(folio,Id_Usuario,fecha,Cantidad,Subtotal,Id_Prod,Id_Estado)
			   SELECT v.folio, v.idusuario, v.fecha, v.cantidad,v.subtotal, v.idproducto, v.idestado
			   FROM OpenXML(@out,'root/actVenta',1)WITH(
			   folio int,
			   idusuario int,
			   fecha date,
			   cantidad int,
			   subtotal money,
			   idproducto int,
			   idestado varchar(1)
			   )v  
			 			  
				UPDATE p--ACTUALIZAR INVENTARIO--verificar funcionamiento
				  SET 
				  p.Existencia=(SELECT Existencia-dt.cantidad FROM OpenXML(@out,'root/actVenta',1)WITH(
			   idproducto int,
			   cantidad int
			   )dt INNER JOIN Producto p on p.Id_Prod=dt.idproducto WHERE p.Id_Prod=dt.idproducto)
				  FROM OpenXML(@out,'root/actVenta',1)WITH(idproducto int, existencia int) cp
			  INNER JOIN Producto p ON cp.idproducto=p.Id_Prod
			  WHERE cp.idproducto=p.Id_Prod
		  END
		 	   
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
--SELECT * FROM Producto WHERE Estado='C'
GO
  CREATE PROCEDURE [dbo].[uspAgregarExistencia] ---LISTO
  @prmExistencia int,
  @prmId int
  AS
  DECLARE @smsError nvarchar(300)
  BEGIN
	  BEGIN TRY
	   BEGIN TRANSACTION
	      
		  UPDATE Producto 
		  SET
		  Existencia= @prmExistencia
		  WHERE Id_Prod=@prmId
		--SELECT* FROM Producto
		 
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
CREATE PROCEDURE [dbo].[uspActualizarEmpleado] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
		  -- editando usuario
		  UPDATE em
		      SET 
			  em.Nom_empleado=ae.nombre,
			  em.apepatEmpleado=ae.apepat,
			  em.apematEmpleado=ae.apemat,
			  em.telefonoEmpleado=ae.telefono,
			  em.direccionEmpleado=ae.direccion,
			  em.Id_Rol=ae.idrol
			  FROM OpenXML(@out,'root/actEmpleado',1)WITH(idempleado int,nombre varchar(25), 
			  apepat varchar(25), apemat varchar(25), telefono varchar(25), direccion varchar(25), 
			  idrol int) ae
		  INNER JOIN Empleado em ON ae.idempleado=em.Id_empleado
		  WHERE em.Id_empleado = ae.idempleado
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END


GO
CREATE PROCEDURE [dbo].[uspActualizarUsuario] ---LISTO
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
			  u.nombre_Usuario=act.usuario,
			  u.Contrasena_Usuario=act.contrasena,
			  u.Id_Empleado=act.idempleado
			  FROM OpenXML(@out,'root/actUsuario',1)WITH( idusuario int,
		 usuario varchar(25), contrasena varchar(10), idempleado int) act
		  INNER JOIN Usuario u ON act.idusuario=u.Id_Usuario
		  WHERE u.Id_Usuario = act.idusuario
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END


GO
CREATE PROCEDURE [dbo].[uspActualizarProducto] ---LISTO
  @Cadxml varchar(max)
  AS
  BEGIN
    DECLARE @out int,@smsError nvarchar(300)
	EXEC SP_XML_PREPAREDOCUMENT @out output, @Cadxml--Crear el xml
	  BEGIN TRY
	   BEGIN TRANSACTION
		  -- editando producto
		  UPDATE p
		      SET 
			  p.Nom_producto=cp.nomproducto,
			  p.Id_Umed=cp.idumed,
			  p.Existencia=cp.existencia,
			  p.Id_Marca=cp.idmarca,
			  p.Costo= cp.costo,
			  p.Precio=cp.precio,
			  p.Descp_producto=cp.descripcion
			  FROM OpenXML(@out,'root/actProducto',1)WITH(idproducto int, nomproducto varchar(25),
		  idumed int, existencia int, idmarca int, costo money, precio money,descripcion varchar(50)) cp
		  INNER JOIN Producto p ON cp.idproducto=p.Id_Prod
		  WHERE cp.idproducto=p.Id_Prod
		 
		 IF @@TRANCOUNT > 0 COMMIT TRANSACTION
		
	  END TRY

	  BEGIN CATCH
	    IF @@TRANCOUNT>0 ROLLBACK TRANSACTION
		SET @smsError= ERROR_MESSAGE()
		RAISERROR(@smsError,16,1)
	  END CATCH
  END
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
--SET NOCOUNT ON
--SELECT COUNT(*) FROM Usuario AS u
		--WHERE  u.Id_Usuario=1 AND u.Contrasena_Usuario='A12'
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
CREATE PROCEDURE [dbo].[uspListaMesas] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT m.Id_mesa, m.Id_tipo, t.Nom_tipo FROM Mesa AS m
			INNER JOIN Tipo AS t ON m.Id_tipo=t.Id_tipo
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
CREATE PROCEDURE [dbo].[uspObtenerIdVenta] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT TOP 1 folio FROM Venta ORDER BY folio DESC
		SET NOCOUNT OFF
	  END 
GO
CREATE PROCEDURE [dbo].[uspObtenerIdEmpleadoActualizar] ----Listo
@prmUsuario INT
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT  Id_empleado FROM Usuario WHERE @prmUsuario=Id_Usuario
		SET NOCOUNT OFF
	  END 
GO
--SELECT * FROM Usuario
--SELECT * FROM Empleado WHERE Id_empleado=2
--SELECT * FROM Disponibilidad
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
CREATE PROCEDURE [dbo].[uspListarUnidMed]---LISTO
	AS
		BEGIN
			SET NOCOUNT ON
			   SELECT * FROM UnidadMedida
			SET NOCOUNT OFF
		 END

GO
CREATE PROCEDURE [dbo].[uspListarMarca]---LISTO
	AS
		BEGIN
			 SET NOCOUNT ON
			   SELECT * FROM Marca
			 SET NOCOUNT OFF
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
CREATE PROCEDURE [dbo].[uspMostrarTipoMesa] --LISTO
 @prmMesa int
 AS
	 BEGIN
		  SELECT t.Nom_tipo FROM Mesa AS m
		  INNER JOIN Tipo t ON m.Id_tipo=t.Id_tipo
		  WHERE m.Id_mesa= @prmMesa
	 END
GO
--SELECT * FROM Rol
GO
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
GO
--SELECT * FROM Mesa m
--INNER JOIN Tipo t
--ON m.Id_tipo=t.Id_tipo
