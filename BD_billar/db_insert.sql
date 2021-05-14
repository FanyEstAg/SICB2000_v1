--INSERTAR VALORES POR DEFAULT
USE bd_billar;

--INSERTAR REGISTROS PARA TABLA Rol
--SOLO SE INGRESAN 3 VALORES PORQUE SOLO HAY 3 ROLES EN EL SISTEMA
INSERT INTO Rol VALUES ('Administrador','Control total')
INSERT INTO Rol VALUES ('Cajero','Manejo de dinero')
INSERT INTO Rol VALUES ('Jefe de inventario','Inventario - Gestión de productos')

--INSERTAR 10 REGISTROS PARA TABLA Empleado
INSERT INTO Empleado VALUES('David','Rivera','Perez','225-123-08-44','Lazaro Cardenas No.3',1)
INSERT INTO Empleado VALUES('Juan Manuel','Hernandez','Solis','225-178-70-12','Calle Los Pinos No. 28',2)
INSERT INTO Empleado VALUES('Abigail','Ramirez','Quezada','225-100-14-12','Calle Benito Juarez No.78',2)
INSERT INTO Empleado VALUES('Veronica','Sandoval','Hernandez','225-783-02-14','Calle 22 de Noviembre No.96',2)
INSERT INTO Empleado VALUES('José','Huerta','Carreon','225-123-78-41','Calle Vicente Guerrero No.32',2)
INSERT INTO Empleado VALUES('Pablo','Perdomo','Campos','225-363-50-12','Calle Fco. I Madero No.12',2)
INSERT INTO Empleado VALUES('Esmeralda','Ramos','Arrieta','225-107-56-92','Calle 18 de Marzo No.45',2)
INSERT INTO Empleado VALUES('Manuel','Diaz','Ortiz','225-130-43-48','Calle Plutarco Elias No.2',2)
INSERT INTO Empleado VALUES('Orlando','Soto','Ortiz','225-150-20-74','Calle 16 de Septiembre No.23',3)
INSERT INTO Empleado VALUES('Monserrat','Arellano','Carlos','225-107-78-41','Calle Alamo No.34',3)

--INSERTAR 10 REGISTROS PARA TABLA Usuario
INSERT INTO Usuario VALUES('Admin','A123',1)
INSERT INTO Usuario VALUES('EmpJM','J9H8S7987',2)
INSERT INTO Usuario VALUES('EmpAB','A6R5Q4654',2)
INSERT INTO Usuario VALUES('EmpVE','V3S2H1321',2)
INSERT INTO Usuario VALUES('EmpJO','J9H8C7987',2)
INSERT INTO Usuario VALUES('EmpPA','P6P5C4654',2)
INSERT INTO Usuario VALUES('EmpES','E3R2A1321',2)
INSERT INTO Usuario VALUES('EmpMA','M9D8O7987',2)
INSERT INTO Usuario VALUES('EmpOR','O6S5O4654',3)
INSERT INTO Usuario VALUES('EmpMO','M3A2C1321',3)

--INSERTAR 10 REGISTROS PARA TABLA Marca
INSERT INTO Marca VALUES('Coca Cola')
INSERT INTO Marca VALUES('Pepsi')
INSERT INTO Marca VALUES('Sabritas')
INSERT INTO Marca VALUES('Gatorade')
INSERT INTO Marca VALUES('Bachoco')
INSERT INTO Marca VALUES('Marinela')
INSERT INTO Marca VALUES('Holanda')
INSERT INTO Marca VALUES('Jumex')
INSERT INTO Marca VALUES('Corona')
INSERT INTO Marca VALUES('Barcel')

--INSERTAR REGISTROS PARA TABLA UnidadMedida (DATOS POR DEFAULT)
--SOLO SE INGRESARON 6 POR LOS TIPOS DE PRODUCTOS QUE SE MANEJAN
INSERT INTO UnidadMedida VALUES ('Kilo', 'Kg')
INSERT INTO UnidadMedida VALUES ('Gramo','g')
INSERT INTO UnidadMedida VALUES ('Miligramo','mg')
INSERT INTO UnidadMedida VALUES ('Pieza', 'Pz')
INSERT INTO UnidadMedida VALUES ('Litro', 'L')
INSERT INTO UnidadMedida VALUES ('mililitro', 'ml')

--INSERTAR REGISTROS PARA TABLA Producto
INSERT INTO Producto VALUES ('Coca cola',6,25,1,15,20,'Coca Cola de 600 ml')
INSERT INTO Producto VALUES ('Sabritas sal',4,18,3,11,15,'Bolsa de sabritas de sal')
INSERT INTO Producto VALUES ('Alitas',1,120,5,150,230,'Alitas en varios sabores')
INSERT INTO Producto VALUES ('Cerveza',5,18,9,30,55,'Vaso de cerveza de 1L')
INSERT INTO Producto VALUES ('Paleta Magnun',4,12,7,19,32,'Paleta Magnum de almendras')
INSERT INTO Producto VALUES ('Jugo Jumex',6,17,7,8,15,'Jugo de durazno de 250 ml')
INSERT INTO Producto VALUES ('Ruffles',4,8,3,12,18,'Bolsa de ruffles')
INSERT INTO Producto VALUES ('Gatorade de uva',5,9,4,15,24,'Gatorade sabor uva de 1L')
INSERT INTO Producto VALUES ('Gansito',4,7,2,7,12,'Gansito marinela de 50g')
INSERT INTO Producto VALUES ('Pepsi',6,14,2,10,15,'Pepsi de 600 ml')

--INSERTAR REGISTROS TIPOS DE MESA
INSERT INTO Tipo VALUES ('Carambola')
INSERT INTO Tipo VALUES ('Americana(Pool)')
INSERT INTO Tipo VALUES ('Inglés(Snooker)')
INSERT INTO Tipo VALUES ('Automática')
INSERT INTO Tipo VALUES ('Con Monedero')
INSERT INTO Tipo VALUES ('Convertible')
INSERT INTO Tipo VALUES ('Fija')
INSERT INTO Tipo VALUES ('Plegable')
INSERT INTO Tipo VALUES ('Multijuego')
INSERT INTO Tipo VALUES ('Portátil')

--INSERTAR REGISTROS PARA TABLA Estado
--SOLO SE AGREGAN 2 VALORES YA QUE SON LAS UNICAS OPCIONES (DATOS POR DEFAULT)
INSERT INTO Estado VALUES ('A','Anulado')
INSERT INTO Estado VALUES ('C','Confirmado')

--INSERTAR REGISTROS PARA TABLA Disponibilidad
--SOLO SE AGREGAN 2 VALORES YA QUE SON LAS UNICAS OPCIONES (DATOS POR DEFAULT)
INSERT INTO Disponibilidad VALUES ('Si','Desocupada')
INSERT INTO Disponibilidad VALUES ('No','Ocupada')
select * from disponibilidad
--INSERTAR REGISTROS DE MESAS
INSERT INTO Mesa (Id_tipo, Id_Disponibilidad) VALUES (1,'Si')
INSERT INTO Mesa VALUES (2,'Si')
INSERT INTO Mesa VALUES (3,'Si')
INSERT INTO Mesa VALUES (4,'Si')
INSERT INTO Mesa VALUES (5,'Si')
INSERT INTO Mesa VALUES (6,'Si')
INSERT INTO Mesa VALUES (7,'Si')
INSERT INTO Mesa VALUES (8,'Si')
INSERT INTO Mesa VALUES (9,'Si')
INSERT INTO Mesa VALUES (10,'Si')
