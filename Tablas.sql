USE MASTER
GO

--DROP database HundeDB

--Creacion de Base de Datos para el profesor--
create database HundeDB
go

--Creacion de Tablas--
USE HundeDB
GO

CREATE TABLE Tb_Usuario
(	login_usuario varchar(15),
	pass_usuario varchar (20),
	niv_usuario int,
	est_usuario int,
	fec_registro datetime,
	usu_reg_usu varchar(4),
	cod_emp varchar(4)
	CONSTRAINT PK_Usuario PRIMARY KEY (login_usuario)
)
GO 

CREATE TABLE Tb_Cliente
   (cod_cli						VARCHAR(4)		NOT NULL,
	--tipo_cliente				INT			    NOT NULL, -- 1->persona natural | 2 -> persona juridica
	nom_cliente					VARCHAR(50)		NOT NULL,  
	ape_cliente					VARCHAR(50)		NOT NULL, 
	direccion_cliente			varchar(100)	NOT NULL,
	cel_cliente					VARCHAR(9)		NOT NULL,
	email_cliente				VARCHAR(50)		NOT NULL, 
	es_dueno					int				NOT NULL, -- 1-> due?o | 2-> familiar
	id_ubigeo					varchar(6)		NOT NULL,
	dni_cliente					char(8)			not null,
	usu_reg_cli					VARCHAR(15)				,
	fec_reg_cli					DATETIME				,
	usu_ult_modificacion_cli	VARCHAR(15)				,
	fecha_ult_modificacion_cli	DATETIME				,
	estado_cli					INT

	CONSTRAINT PK_Cliente PRIMARY KEY (cod_cli)
)   
GO 

CREATE TABLE Tb_Empleado
   (cod_emp						VARCHAR(4)		NOT NULL,
	cod_rol						INT				NOT NULL,
	tipo_emp					INT				NOT NULL, -- 1-> supervisor 2-> empleado
	nom_empleado				VARCHAR(50)		NOT NULL,
	ape_empleado				VARCHAR(50)		NOT NULL,
	direccion_empleado			varchar(100)	NOT NULL,
	id_ubigeo					varchar(6)		NOT NULL,
	fecha_ingreso				DATETIME		NOT NULL,
	sueldo						money					,
	email_emp					VARCHAR(50)				,
	cod_supervisor				VARCHAR(4)				,
	usu_reg_cli					VARCHAR(15)				,
	fec_reg_cli					DATETIME				,
	usu_ult_modificacion_emp	VARCHAR(15)				,
	fecha_ult_modificacion_emp	DATETIME				,
	estado_emp					INT				NOT NULL	-- 1 -> activo | 0 -> inactivo
	
	CONSTRAINT PK_Empleado PRIMARY KEY (cod_emp)
)   
GO 

CREATE TABLE Tb_Rol(
	cod_rol	INT PRIMARY KEY IDENTITY(1,1),
	nom_rol VARCHAR(50) NOT NULL
)

CREATE TABLE Tb_Paciente
   (cod_pac					VARCHAR(4)		NOT NULL,
	nom_pac					VARCHAR(50)		NOT NULL,
	cod_raza				INT						,
	fec_nac_pac				date			NOT NULL,
	sexo					INT				NOT NULL, -- 1-> macho | 2-> hembra
	cod_color				INT 			NOT NULL,
	longitud				FLOAT			NOT NULL,
	peso					FLOAT			NOT NULL,
	ult_vis_pac				date					,
	foto					IMAGE					,
	observaciones_pac		VARCHAR(300)			,
	est_pac					INT				NOT NULL
	
	CONSTRAINT PK_Paciente PRIMARY KEY (cod_pac)
)   
GO

CREATE TABLE Tb_Color(
	cod_color INT PRIMARY KEY IDENTITY(1,1),
	nom_color VARCHAR(40)
)


CREATE TABLE Tb_Tipo_Paciente
(	cod_tipo INT PRIMARY KEY IDENTITY(1,1),
	nom_tipo VARCHAR(40)
)
GO 


CREATE TABLE Tb_Raza
(	cod_raza INT PRIMARY KEY IDENTITY(1,1),
	nom_raza VARCHAR(40),
	cod_tipo INT
)
GO 

CREATE TABLE Tb_Cliente_Paciente
(	cod_cli varchar(4),
	cod_pac varchar(4)		
)
GO 


CREATE TABLE Tb_Cita
(	cod_cita				INT IDENTITY (1,1)	NOT NULL,
	fec_reserva				DATETIME			NOT NULL,
	fec_cita				DATE				NOT NULL,
	hor_cita				TIME				NOT NULL,
	est_cita				INT					NOT NULL, -- 1-> ACEPTADA | 2 -> PENDIENTE | 3 -> CANCELADA 
	cod_cli					VARCHAR(4)			NOT NULL
	
	CONSTRAINT PK_Cita PRIMARY KEY (cod_cita)
)
GO


CREATE TABLE Tb_Consulta
   (cod_cons				INT	IDENTITY(1,1)	NOT NULL,
	fec_cons				DATE				NOT NULL,
	hor_cons				TIME				NOT NULL,
	cod_pac					VARCHAR(4)          NOT NULL,
	cod_emp					VARCHAR(4)			NOT NULL,
	cod_cita				INT					NOT NULL,
	est_cons				INT					NOT NULL  -- 1-> REALIZADA | 2 -> PENDIENTE | 3 -> CANCELADA 
	
	CONSTRAINT PK_Consulta PRIMARY KEY (cod_cons)
)   
GO  


CREATE TABLE Tb_Tratamiento
(
	cod_trat				INT IDENTITY (1,1)	NOT NULL,
	nombre_trat				VARCHAR(50)			NOT NULL,
	estado_trat				INT 	
	CONSTRAINT PK_Tratamiento PRIMARY KEY (cod_trat)
)
GO


CREATE TABLE Tb_Estado
(
	cod_estado		INT	IDENTITY(1,1)	NOT NULL,
	conducta		VARCHAR(50)			NOT NULL,
	est_nutricional	VARCHAR(50)			NOT NULL,
	actividad		VARCHAR(50)			NOT NULL	

	CONSTRAINT PK_Estado PRIMARY KEY (cod_estado)
)
GO 

CREATE TABLE Tb_Medicina
(
	cod_med			INT	IDENTITY(1,1)	NOT NULL,
	nombre_medicina	VARCHAR(50)			NOT NULL,
	precio			MONEY 				NOT NULL

	CONSTRAINT PK_Medicina PRIMARY KEY (cod_med)
)
GO

CREATE TABLE Tb_Proveedor
(
	cod_prov					VARCHAR(4)		NOT NULL,
	raz_soc						VARCHAR(50)		NOT NULL,
	ruc_prov					CHAR(11)		NOT NULL,
	direccion_prov				varchar(100)	NOT NULL,
	id_ubigeo					varchar(6)		NOT NULL,
	tel_prov					VARCHAR(9)		NOT NULL,
	email_prov					VARCHAR(50)		NOT NULL, 
	rep_ven_prov				VARCHAR(50)		NOT NULL,
	usu_reg_prov				VARCHAR(15)				,
	fec_reg_prov				DATETIME				,
	usu_ult_modificacion_prov	VARCHAR(15)				,
	fecha_ult_modificacion_prov	DATETIME				,
	estado_prov					INT		

	CONSTRAINT PK_Proveedor PRIMARY KEY (cod_prov)
)
GO 

CREATE TABLE Tb_Proveedor_Medicina
(
	cod_prov varchar(4),
	cod_med	 INT
)

CREATE TABLE Tb_Detalle_Consulta
(
	cod_cons		INT 		NOT NULL,
	cod_trat		INT			NOT NULL,
	cod_estado		INT			NOT NULL,
	cod_med			INT					,
	obs_det_cons	VARCHAR(300)
)
GO 

CREATE TABLE Tb_Ubigeo(
Id_Ubigeo		varchar (6)		NOT NULL,
IdDepa			nvarchar(255)	NULL	,
IdProv			nvarchar(255)	NULL	,
IdDist			nvarchar(255)	NULL	,
Departamento	nvarchar(255)	NULL	,
Provincia		nvarchar(255)	NULL	,
Distrito		nvarchar(255)	NULL

 CONSTRAINT PK_Tb_Ubigeo PRIMARY KEY (Id_Ubigeo)
)
GO
		
-- ALTERACIONES en tablas para asignaciones de FOREIGN KEYS--

	/*FK para login_user en tablas*/

Alter table Tb_Usuario
ADD CONSTRAINT FK_Usuario_user
foreign key(cod_emp) references Tb_Empleado(cod_emp) 
go


Alter Table Tb_Cliente_Paciente
ADD CONSTRAINT FK_Cliente_Paciente
foreign key(cod_cli) references Tb_Cliente(cod_cli),
foreign key(cod_pac) references Tb_Paciente(cod_pac)
go

Alter table Tb_Cita
ADD CONSTRAINT FK_Cita_cliente
foreign key(cod_cli) references Tb_Cliente (cod_cli) 
go

Alter table Tb_Consulta
ADD CONSTRAINT FK_Consulta_cita
foreign key(cod_cita) references Tb_Cita (cod_cita),
foreign key(cod_pac) references Tb_Paciente(cod_pac),
foreign key(cod_emp) references tb_Empleado(cod_emp)
go

alter table Tb_Proveedor_Medicina
add constraint Fk_Proveedor_medicina
foreign key(cod_prov) references Tb_Proveedor(cod_prov),
foreign key(cod_med) references Tb_Medicina(cod_med)
go

alter table Tb_Detalle_Consulta
add constraint FK_Detalle_Consulta
foreign key(cod_cons) references Tb_Consulta(cod_cons),
foreign key(cod_trat) references Tb_Tratamiento(cod_trat),
foreign key(cod_estado) references Tb_Estado(cod_estado),
foreign key(cod_med) references Tb_Medicina(cod_med)
go

alter table Tb_Cliente
add constraint FK_Cliente_Ubigeo
foreign key(id_ubigeo) references Tb_Ubigeo(Id_Ubigeo)
go

alter table Tb_Empleado
add constraint FK_Empleado_Ubigeo
foreign key(id_ubigeo) references Tb_Ubigeo(Id_Ubigeo)
go

alter table Tb_Empleado
add constraint FK_Empleado_Supervisor
foreign key(cod_supervisor) references Tb_Empleado(cod_emp)
go

alter table Tb_Proveedor
add constraint FK_Proveedor_Ubigeo
foreign key(id_ubigeo) references Tb_Ubigeo(Id_Ubigeo)
go

ALTER TABLE Tb_Raza
ADD CONSTRAINT FK_TIPO_RAZA
FOREIGN KEY(cod_tipo) REFERENCES Tb_Tipo_Paciente(cod_tipo)
GO

ALTER TABLE Tb_Paciente
ADD CONSTRAINT FK_PACIENTE_RAZA
FOREIGN KEY(cod_raza) REFERENCES Tb_Raza(cod_raza)
GO

ALTER TABLE Tb_Empleado
ADD CONSTRAINT FK_ROL_EMPLEADO
FOREIGN KEY(cod_rol) REFERENCES Tb_Rol(cod_rol)
GO

ALTER TABLE Tb_Paciente
ADD CONSTRAINT FK_COLOR_PACIENTE
FOREIGN KEY(cod_color) REFERENCES Tb_Color(cod_color)
GO


