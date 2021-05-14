CREATE PROC uspIniciar_Sesion--LISTO
@prmUsuario VARCHAR(25),
@prmContrasena VARCHAR(10)
	AS
		SELECT * FROM Usuario AS u
		INNER JOIN Empleado AS e ON u.Id_Empleado=e.Id_empleado
		INNER JOIN Rol AS r ON e.Id_Rol=r.Id_Rol
		WHERE  u.nombre_Usuario=@prmUsuario AND u.Contrasena_Usuario=@prmContrasena
GO

CREATE PROCEDURE [dbo].[uspEliminarUsuario]---LISTO----
		@prmId_Usuario int
		AS
		 BEGIN
			DELETE Usuario WHERE Id_Usuario=@prmId_Usuario
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

ALTER PROCEDURE [dbo].[uspCambiarContrasena] ---LISTO
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

CREATE PROCEDURE [dbo].[uspListaRol] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT * FROM Rol
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
CREATE PROCEDURE [dbo].[uspObtenerIdEmpleado] ----Listo
  AS
	  BEGIN
		SET NOCOUNT ON
			SELECT TOP 1 Id_empleado FROM Empleado ORDER BY Id_empleado DESC
		SET NOCOUNT OFF
	  END 
GO

CREATE PROCEDURE [dbo].[uspVerificarAcceso] --LISTO VERIFICAR USO
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