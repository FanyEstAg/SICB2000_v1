--USP MESAS
GO
CREATE PROCEDURE [dbo].[uspEliminarMesa]---LISTO----
		@prmId_Mesa	 int
		AS
		 BEGIN
			DELETE Mesa WHERE Id_mesa=@prmId_Mesa
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

CREATE PROCEDURE [dbo].[uspCargarMesas]  ---LISTO
	 
	 AS
	   BEGIN
		SELECT m.Id_mesa,t.Nom_tipo AS Tipo,d.Id_Disponibilidad AS Disponibilidad
		FROM Mesa m 
		INNER JOIN Tipo AS t ON m.Id_tipo=t.Id_tipo
		INNER JOIN Disponibilidad AS d ON  m.Id_Disponibilidad=d.Id_Disponibilidad
		
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


