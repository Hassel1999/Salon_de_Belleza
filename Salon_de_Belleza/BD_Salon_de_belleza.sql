Create database salon_de_belleza
go

use salon_de_belleza
go

Create table Sexos
(
 idSexo int IDENTITY(1,1) primary key NOT NULL,
 descripcionSexo varchar(10) NOT NULL,
 )
 go

 Create table TipoEmpleados
(
 idTipoEmpleado int IDENTITY(1,1) primary key NOT NULL,
 descripcionTipoEmpleado varchar(10) NOT NULL,
 )
 go

 Create table Estados
(
 idEstado int IDENTITY(1,1) primary key NOT NULL,
 descripcionEstado varchar(10) NOT NULL,
 )
 go

Create table Servicios
(
idServicio int IDENTITY(1,1) primary key NOT NULL,
descripcionServicio varchar(50) NOT NULL,
precioServicio int NOT NULL,
FK_idEstado int foreign key references Estados(idEstado) NOT NULL
)
go

Create table Clientes
(
 idCliente int IDENTITY(1,1) primary key NOT NULL,
 DNICliente varchar(15) NOT NULL UNIQUE,
 primerNombreCliente varchar(30) NOT NULL,
 segundoNombreCliente varchar(30) NULL,
 primerApellidoCliente varchar(30) NOT NULL,
 segundoApellidoCliente varchar(30) NULL,
 edadCliente int NOT NULL,
 turno varchar(5) NOT NULL,
 telefonoCliente varchar(10) NULL,
 FK_idSexo int foreign key references Sexos(idSexo) NOT NULL,
 FK_idEstado int foreign key references Estados(idEstado) NOT NULL
 )
 go

 Create table Empleados
(
 idEmpleado int IDENTITY(1,1) primary key NOT NULL,
 DNIEmpleado varchar(15) UNIQUE NOT NULL,
 primerNombreEmpleado varchar(30) NOT NULL,
 segundoNombreEmpleado varchar(30) NULL,
 primerApellidoEmpleado varchar(30) NOT NULL,
 segundoApellidoEmpleado varchar(30) NULL,
 telefonoEmpleado varchar(10) NULL,
 FK_idTipoEmpleado int foreign key references TipoEmpleados(idTipoEmpleado) NOT NULL,
 FK_idSexo int foreign key references Sexos(idSexo) NOT NULL,
 FK_idEstado int foreign key references Estados(idEstado) NOT NULL
 )
 go

  Create table Usuarios
(
 idUsuarios int IDENTITY(1,1) primary key,
 Usuario varchar(10) NOT NULL,
 Contraseña varchar(10) NOT NULL,
 FK_idEmpleado int foreign key references Empleados(idEmpleado) NOT NULL,
 FK_idEstado int foreign key references Estados(idEstado) NOT NULL
 )
 go

Create table Facturas
(
idFactura int IDENTITY(1,1) primary key,
NoFactura int NOT NULL,
fechaEmision datetime NOT NULL,
FK_idCliente int foreign key references Clientes(idCliente) NOT NULL,
FK_idEmpleado int foreign key references Empleados(idEmpleado) NOT NULL
)
go

Create table Detalle_Facturas
(
FK_idFactura int foreign key references Facturas(idFactura),
 FK_idServicio int foreign key references Servicios(idServicio),
 total int
)
go

ALTER TABLE Detalle_Facturas
	ADD CONSTRAINT Pk_myConstraint PRIMARY KEY(FK_idFactura,FK_idServicio)
	GO