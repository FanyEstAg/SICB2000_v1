--usp INVENTARIO
ALTER PROCEDURE [dbo].[uspEliminarProducto]---LISTO----
		@prmId_Producto	 int
		AS
		 BEGIN
			UPDATE Producto 
			SET
			Estado='A'
			WHERE Id_Prod=@prmId_Producto
		 END
GO
CREATE PROCEDURE [dbo].[uspBuscarProducto] ---LISTO
	 @prmBusqueda varchar(25)
	 AS
	   BEGIN
			SELECT p.Id_Prod AS ID, p.Nom_producto AS Nombre, p.[Descp_producto ] AS Descripcion, um.Descripcion_Umed AS ud_Medida, p.Existencia,
			m.Nom_marca AS Marca, p.Costo AS Costo, p.Precio AS Precio
			FROM Producto p
			INNER JOIN Marca AS m ON p.Id_Marca=m.Id_Marca
			INNER JOIN UnidadMedida AS um ON p.Id_Umed=um.Id_Umed
			
			WHERE p.Nom_producto LIKE '%'+@prmBusqueda+'%' OR m.Nom_marca LIKE '%'+@prmBusqueda+'%'
			OR um.Abreviatura_Umed LIKE '%'+@prmBusqueda+'%' OR um.Descripcion_Umed LIKE '%'+@prmBusqueda+'%'
			AND p.Estado='C'
	END
GOCREATE PROCEDURE [dbo].[uspBuscarProductoExistencia] ---LISTO
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