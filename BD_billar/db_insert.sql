--INSERTAR VALORES POR DEFAULT
USE bd_billar;

INSERT [dbo].[Disponibilidad] VALUES
('Sí','Desocupada'),
('No', 'Ocupada')

INSERT [dbo].Estado VALUES
('A', 'Anulado'),
('C','Confirmado')

INSERT [dbo].Rol(Nom_puesto,Descrp_rol) VALUES
('Admin','Administrador - Control total'),
('Cajero','Cajero - Manejo de dinero'),
('Jefe Inventario','Inventario - Gestión de productos ')

INSERT [dbo].UnidadMedida VALUES
('Kilo', 'Kg')

INSERT [dbo].Empleado VALUES
('José','Estralar','Aguilera','2311135646','Aurora #2',1)
