use HundeDB
go


/*
***** STORED PROCEDURES *******
*/

--CLIENTE

--insertar


CREATE PROCEDURE usp_InsertarCliente

--@vtipo_cliente INT,
@vnom_cliente VARCHAR(50),
@vape_cli VARCHAR(50),
@vdir_cli VARCHAR(100),
@vcel_cli VARCHAR(9),
@vemail_cli VARCHAR(50),
@ves_dueno INT,
@vid_ubigeo VARCHAR(6),
@vdni_cli CHAR(8),
@vusu_reg_cli VARCHAR(15),
@vestado_cli INT

AS
DECLARE @vcod_cli VARCHAR(4)
DECLARE @vcont INT
set @vcont=(SELECT count(*) FROM Tb_Cliente)
IF @vcont=0 
	SET @vcod_cli ='C001'
ELSE
    SET @vcod_cli=(SELECT 'C' +Right(Max (Right(cod_cli,3)+ 1001 ),3) 
    FROM Tb_Cliente)
INSERT INTO Tb_Cliente VALUES(@vcod_cli,@vnom_cliente,@vape_cli,@vdir_cli,@vcel_cli,@vemail_cli,
@ves_dueno,@vid_ubigeo,@vdni_cli,@vusu_reg_cli,GETDATE(),Null,Null,@vestado_cli)
GO

--listar cliente

CREATE PROCEDURE usp_ListarClientes
AS
SELECT * FROM Tb_Cliente
ORDER BY ape_cliente
GO


--actualizar cliente

CREATE PROCEDURE usp_ActualizarCliente

--@vtipo_cliente INT,
@vnom_cliente VARCHAR(50),
@vape_cli VARCHAR(50), 
@vdir_cli VARCHAR(100),
@vcel_cli VARCHAR(9),
@vemail_cli VARCHAR(50),
@ves_dueno INT,
@vid_ubigeo VARCHAR(6),
@vdni_cli CHAR(8),
@vusu_ult_mod VARCHAR(15),
@vestado_cli INT,
@vcod_cli VARCHAR(4)

AS

UPDATE Tb_Cliente
SET 
	nom_cliente=@vnom_cliente, ape_cliente=@vape_cli, direccion_cliente=@vdir_cli, cel_cliente=@vcel_cli,
	email_cliente=@vemail_cli, es_dueno=@ves_dueno,
	id_ubigeo=@vid_ubigeo, dni_cliente=@vdni_cli, usu_ult_modificacion_cli=@vusu_ult_mod,
	fecha_ult_modificacion_cli=GETDATE(), estado_cli=@vestado_cli
WHERE 
	cod_cli=@vcod_cli
GO

--eliminar cliente
CREATE PROCEDURE usp_EliminarCliente
@vcod_cli VARCHAR(4)
AS
DELETE FROM Tb_Cliente
WHERE cod_cli=@vcod_cli
GO

--PACIENTE
--insertar

CREATE PROCEDURE usp_InsertarPaciente

@vnom_pac VARCHAR(50),
@vcod_raza INT,
@vfec_nac_pac DATE,
@vsexo INT,
@vcod_color INT,
@vlongitud FLOAT,
@vpeso FLOAT,
@vult_vis_pac DATE,
@vfoto IMAGE,
@vobservaciones_pac VARCHAR(300) ,
@vest_pac INT

AS
DECLARE @vcod_pac VARCHAR(4)
DECLARE @vcont INT
SET @vcont=(SELECT COUNT(*) FROM Tb_Paciente)
IF @vcont=0 
	SET @vcod_pac ='P001'
ELSE
    SET @vcod_pac=(SELECT 'P' +Right(MAX (Right(cod_pac,3)+ 1001 ),3) 
    FROM Tb_Paciente)
INSERT INTO Tb_Paciente VALUES(@vcod_pac,@vnom_pac,@vcod_raza,@vfec_nac_pac,@vsexo,@vcod_color,@vlongitud,@vpeso,
@vult_vis_pac,@vfoto,@vobservaciones_pac,@vest_pac)
GO

--listar

CREATE PROCEDURE usp_ListarPacientes
AS
SELECT * FROM Tb_Paciente
ORDER BY nom_pac
GO


CREATE PROCEDURE usp_ListarPacientesPorCliente
@vcod_cli VARCHAR(4)
AS
SELECT P.*, CP.cod_cli 
FROM Tb_Paciente P
INNER JOIN tb_Cliente_Paciente CP ON P.cod_pac=CP.cod_pac
INNER JOIN Tb_Cliente C ON CP.cod_cli=C.cod_cli
WHERE CP.cod_cli=@vcod_cli
ORDER BY nom_pac
GO

--actualizar

CREATE PROCEDURE usp_ActualizarPaciente

@vnom_pac VARCHAR(50),
@vcod_raza INT,
@vfec_nac_pac DATE,
@vsexo INT,
@vcod_color INT,
@vlongitud FLOAT,
@vpeso FLOAT,
@vfoto IMAGE,
@vobservaciones_pac VARCHAR(300) ,
@vest_pac INT,
@vcod_pac VARCHAR(4)

AS

UPDATE Tb_Paciente
SET 
	nom_pac=@vnom_pac, cod_raza=@vcod_raza, fec_nac_pac=@vfec_nac_pac, sexo=@vsexo,
	cod_color=@vcod_color, longitud=@vlongitud, peso=@vpeso, foto=@vfoto,
	observaciones_pac=@vobservaciones_pac, est_pac=@vest_pac
WHERE 
	cod_pac=@vcod_pac
GO

--eliminar
CREATE PROCEDURE usp_EliminarPaciente
@vcod_pac VARCHAR(4)
AS
DELETE FROM Tb_Paciente
WHERE cod_pac=@vcod_pac
GO


--EMPLEADO

CREATE PROCEDURE usp_InsertarEmpleado

@vcod_rol INT,
@vtipo_emp INT,
@vnom_emp VARCHAR(50),
@vape_emp VARCHAR(50),
@vdir_emp varchar(100),
@vid_ubigeo varchar(6),
@vfecha_ingreso DATETIME,
@vsueldo MONEY,
@vemail_emp VARCHAR(50),
@vcod_sup VARCHAR(4),
@vusu_reg VARCHAR(15),
@vestado_emp INT

AS

declare @vcod_emp VARCHAR(4)
declare @vcont2 int
set @vcont2=(Select count(*) from Tb_Empleado)
if @vcont2=0
	set @vcod_emp ='E001'
else
	set @vcod_emp=(Select 'E' +Right(Max (Right(cod_emp,3)+ 1001 ),3) 
    From Tb_Empleado)
INSERT INTO Tb_Empleado values(@vcod_emp, @vcod_rol, @vtipo_emp,
@vnom_emp, @vape_emp, @vdir_emp, @vid_ubigeo, @vfecha_ingreso, @vsueldo,
@vemail_emp, @vcod_sup, @vusu_reg, GETDATE(), Null,Null, @vestado_emp)
GO


--listar

CREATE PROCEDURE usp_ListarEmpleado
AS
SELECT E.*, R.nom_rol
FROM Tb_Empleado E
INNER JOIN Tb_Rol R ON E.cod_rol=R.cod_rol
ORDER BY ape_empleado
GO

--actualizar

CREATE PROCEDURE usp_ActualizarEmpleado

@vcod_rol INT,
@vtipo_emp INT,
@vnom_emp VARCHAR(50),
@vape_emp VARCHAR(50),
@vdir_emp varchar(100),
@vid_ubigeo varchar(6),
@vfecha_ingreso DATETIME,
@vsueldo MONEY,
@vemail_emp VARCHAR(50),
@vcod_sup VARCHAR(4),
@vusu_ult_mod VARCHAR(15),
@vestado_emp INT,
@vcod_emp VARCHAR(4)

AS

UPDATE Tb_Empleado
SET 
	cod_rol=@vcod_rol, tipo_emp=@vtipo_emp, nom_empleado=@vnom_emp, ape_empleado=@vape_emp, direccion_empleado=@vdir_emp,
	id_ubigeo=@vid_ubigeo, fecha_ingreso=@vfecha_ingreso, sueldo=@vsueldo, email_emp=@vemail_emp,
	cod_supervisor= @vcod_sup, usu_ult_modificacion_emp=@vusu_ult_mod, 
	fecha_ult_modificacion_emp=GETDATE(), estado_emp=@vestado_emp
WHERE 
	cod_emp=@vcod_emp
GO

--eliminar
CREATE PROCEDURE usp_EliminarEmpleado
@vcod_emp VARCHAR(4)
AS
DELETE FROM Tb_Empleado
WHERE cod_emp=@vcod_emp
GO

--USUARIO

--insertar

CREATE PROCEDURE usp_InsertarUsuario

@vlogin_usu VARCHAR(10),
@vpass_usu VARCHAR(20),
@vniv_usu int,
@vest_usu int,
@vusu_reg_usu VARCHAR(4),
@vcod_emp VARCHAR(4)

AS
INSERT INTO Tb_Usuario values(@vlogin_usu,@vpass_usu,@vniv_usu,@vest_usu,GETDATE(),@vusu_reg_usu,@vcod_emp)
GO

--listar

CREATE PROCEDURE usp_ListarUsuarios
AS
SELECT * FROM Tb_Usuario
ORDER BY login_usuario
GO

--actualizar

CREATE PROCEDURE usp_ActualizarUsuario

@vlogin_usu VARCHAR(10),
@vpass_usu VARCHAR(20),
@vniv_usu int,
@vest_usu int,
@vcod_emp VARCHAR(4)
AS
UPDATE Tb_Usuario
SET 
	login_usuario=@vlogin_usu, pass_usuario=@vpass_usu, niv_usuario=@vniv_usu, 
	est_usuario=@vest_usu
WHERE 
	cod_emp=@vcod_emp
GO

--eliminar
CREATE PROCEDURE usp_eliminarUsuario
@vcod_emp VARCHAR(4)
AS
DELETE FROM Tb_Usuario
WHERE cod_emp=@vcod_emp
GO


--PROVEEDOR

CREATE PROCEDURE usp_InsertarProveedor

@vraz_soc VARCHAR(50),
@vruc_prov VARCHAR(11),
@vdir_prov VARCHAR(100),
@vid_ubigeo varchar(6),
@vtel_prov VARCHAR(9),
@vemail_prov VARCHAR(50), 
@vrep_ven VARCHAR(50),
@vusu_reg VARCHAR(15),
@vestado_prov INT

AS
declare @vcod_prov VARCHAR(4)
declare @vcont int
set @vcont=(Select count(*) from Tb_Proveedor)
if @vcont=0 
       set @vcod_prov ='PR01'
else
        set @vcod_prov=(Select 'PR' +Right(Max (Right(cod_prov,2)+ 101 ),2) 
    From Tb_Proveedor)
INSERT INTO Tb_Proveedor values(@vcod_prov,@vraz_soc,@vruc_prov,@vdir_prov,@vid_ubigeo,@vtel_prov,@vemail_prov,
@vrep_ven,@vusu_reg,GETDATE(),Null,Null,@vestado_prov)
GO


--listar

CREATE PROCEDURE usp_ListarProveedor
AS
Select *
from Tb_Proveedor 
ORDER BY cod_prov ASC
GO


--actualizar

CREATE PROCEDURE usp_ActualizarProveedor

@vraz_soc VARCHAR(50),
@vruc_prov VARCHAR(11),
@vdir_prov VARCHAR(100),
@vid_ubigeo varchar(6),
@vtel_prov VARCHAR(9),
@vemail_prov VARCHAR(50), 
@vrep_ven_prov VARCHAR(50),
@vusu_ult_mod VARCHAR(15),
@vestado_prov INT,
@vcod_prov VARCHAR(4)

AS

UPDATE Tb_Proveedor
SET
	raz_soc=@vraz_soc, ruc_prov=@vruc_prov, direccion_prov=@vdir_prov, id_ubigeo=@vid_ubigeo, tel_prov=@vtel_prov,
	email_prov=@vemail_prov, rep_ven_prov=@vrep_ven_prov, usu_ult_modificacion_prov=@vusu_ult_mod,
	fecha_ult_modificacion_prov=GETDATE(), estado_prov=@vestado_prov
WHERE 
	cod_prov=@vcod_prov
GO

--eliminar
CREATE PROCEDURE usp_EliminarProveedor
@vcod_prov VARCHAR(4)
AS
DELETE FROM Tb_Proveedor
WHERE cod_prov=@vcod_prov
GO

-- ************** CONSULTAS **************

--Listar medicinas por proveedor
CREATE PROCEDURE usp_ListarMedicinasPorProveedor
@vcod_prov VARCHAR(50)
as
Select M.* 
from Tb_Medicina M
INNER JOIN Tb_Proveedor_Medicina PM On M.cod_med = PM.cod_med
Inner Join Tb_Proveedor P ON P.cod_prov = PM.cod_prov 
where p.cod_prov=@vcod_prov
ORDER BY M.nombre_medicina ASC
GO

--Lista Pacientes por Raza
CREATE PROCEDURE usp_PacientesPorRaza
@vcod_raza INT
AS
SELECT P.*, R.nom_raza, R.cod_tipo, T.nom_tipo, C.nom_color
FROM Tb_Paciente P
INNER JOIN Tb_Raza R ON P.cod_raza=R.cod_raza
INNER JOIN Tb_Color C ON P.cod_color=C.cod_color
INNER JOIN Tb_Tipo_Paciente T ON R.cod_tipo=T.cod_tipo
WHERE R.cod_raza=@vcod_raza
ORDER BY nom_raza
GO


--Lista Pacientes por Tratamiento
CREATE PROCEDURE usp_ListarPacientePorTratamiento
@vcod_trat INT
AS
SELECT P.cod_pac,P.nom_pac,TP.nom_tipo AS tipo ,R.nom_raza AS raza ,P.fec_nac_pac,COL.nom_color AS color,
P.sexo,P.longitud,P.peso,P.est_pac,T.cod_trat, T.nombre_trat, T.estado_trat
FROM Tb_Tipo_Paciente TP
INNER JOIN Tb_Raza R ON TP.cod_tipo=R.cod_tipo
INNER JOIN Tb_Paciente P ON R.cod_raza=P.cod_raza
INNER JOIN Tb_Color COL ON P.cod_color=COL.cod_color
INNER JOIN Tb_Consulta C ON P.cod_pac = C.cod_pac
INNER JOIN Tb_Detalle_Consulta DC ON C.cod_cons = DC.cod_cons
INNER JOIN Tb_Tratamiento T ON DC.cod_trat = T.cod_trat
WHERE T.cod_trat=@vcod_trat
ORDER BY T.cod_trat
GO

--CONSULTAS POR MASCOTA
CREATE PROCEDURE usp_ConsultasPorMascota
@vcod_pac CHAR(4)
AS
SELECT * FROM vw_Consultas
WHERE cod_pac=@vcod_pac
GO

--CONSULTAS POR MEDICO
CREATE PROCEDURE usp_ConsultasPorMedico
@vcod_emp CHAR(4)
AS
SELECT * FROM vw_Consultas
WHERE cod_emp=@vcod_emp
GO

--CONSULTAS POR FECHA
CREATE PROCEDURE usp_ConsultasPorFecha
@vfec_con DATE
AS
SELECT * FROM vw_Consultas
WHERE Fecha=@vfec_con
GO

--CONSULTAS ENTRE FECHA
CREATE PROCEDURE usp_ConsultasEntreFechas
@vfec_ini DATE,
@vfec_fin DATE
AS
SELECT * FROM vw_Consultas
WHERE Fecha BETWEEN @vfec_ini AND @vfec_fin
GO

--CONSULTAS POR MASCOTA ENTRE FECHAS
CREATE PROCEDURE usp_ConsultasPorMascotaEntreFechas
@vcod_pac CHAR(4),
@vfec_ini DATE,
@vfec_fin DATE
AS
SELECT * FROM vw_Consultas
WHERE Fecha BETWEEN @vfec_ini AND @vfec_fin AND cod_pac=@vcod_pac
GO


--CONSULTAS POR MEDICO ENTRE FECHAS
CREATE PROCEDURE usp_ConsultasPorMedicoEntreFechas
@vcod_emp CHAR(4),
@vfec_ini DATE,
@vfec_fin DATE
AS
SELECT * FROM vw_Consultas
WHERE Fecha BETWEEN @vfec_ini AND @vfec_fin AND cod_emp=@vcod_emp
GO

-- CONSULTAR empleados por departamento
CREATE PROCEDURE usp_EmpleadosPorDepartamento
@vdep char(2)
AS
SELECT E.*, U.Departamento, U.Provincia, U.Distrito
FROM Tb_Ubigeo U
INNER JOIN Tb_Empleado E ON U.Id_Ubigeo = E.id_ubigeo
WHERE U.IdDepa=@vdep
GO


-- ********* UBIGEO  ***********
-- Lista de departementos
CREATE PROCEDURE usp_UbigeoDepartamentos
AS
SELECT DISTINCT IdDepa, Departamento
FROM Tb_Ubigeo
ORDER BY Departamento
GO

--Lista de provincias por departamento
CREATE PROCEDURE usp_Ubigeo_ProvinciasDepartamento
@IdDepa char(2)
AS
SELECT DISTINCT IdProv,Provincia
FROM Tb_Ubigeo
WHERE IdDepa=@IdDepa
ORDER BY Provincia
GO

--Lista de distritos por provincia y departamento
CREATE PROCEDURE usp_Ubigeo_DistritosProvinciaDepartamento
@IdDepa char(2),
@IdProv char(2)
AS
SELECT IdDist,Distrito
FROM Tb_Ubigeo
WHERE IdDepa=@IdDepa AND IdProv=@IdProv
ORDER BY Distrito
GO

--RESERVAR DE CITA
CREATE PROCEDURE usp_ReservarCita
@vfec_cita DATE,
@vhor_cita TIME,
@vcod_cli VARCHAR(4)
AS
INSERT INTO Tb_Cita VALUES (GETDATE(), @vfec_cita, @vhor_cita, 2, @vcod_cli) -- POR DEFECTO QUEDA EL ESTADO ES PENDIENTE (2)
GO																			 -- HASTA SER ACEPTADA(1) O CANCELADA(3)

--ACTUALIZAR FECHA Y HORA DE RESERVA DE CITA
CREATE PROCEDURE usp_ActualizarReservarCita
@vfec_cita DATE,
@vhor_cita TIME,
@vcod_cli VARCHAR(4),
@vcod_cita INT
AS
UPDATE Tb_Cita SET fec_cita=@vfec_cita, hor_cita=@vhor_cita
WHERE cod_cli=@vcod_cli
GO

--CANCELAR CITA
CREATE PROCEDURE  usp_CancelarReserva
@vcod_cita INT
AS
UPDATE Tb_Cita SET est_cita=3
WHERE cod_cita=@vcod_cita
GO

--CONFIRMAR CITA Y GENERAR CONSULTA 
CREATE PROCEDURE usp_GenerarConsulta
@vcod_pac VARCHAR(4),
@vcod_emp VARCHAR(4),
@vcod_cita INT
AS
DECLARE @vfec_cons DATE
DECLARE @vhor_cons TIME
SET @vfec_cons=(SELECT fec_cita FROM Tb_Cita WHERE cod_cita=@vcod_cita)
SET @vhor_cons=(SELECT hor_cita FROM Tb_Cita WHERE cod_cita=@vcod_cita)

UPDATE Tb_Cita
SET est_cita=1
WHERE cod_cita=@vcod_cita

INSERT INTO Tb_Consulta VALUES (@vfec_cons, @vhor_cons, @vcod_pac, @vcod_emp, @vcod_cita, 2)
GO

--CANCELAR CONSULTA
CREATE PROCEDURE usp_CancelarConsulta
@vcod_cons INT
AS 
UPDATE Tb_Consulta
SET est_cons=3
WHERE cod_cons=@vcod_cons
GO

--AGREGAR DETALLES DE CONSULTA
CREATE PROCEDURE usp_AgregarDetallesDeConsulta
@vcod_cons INT,
@vcod_trat INT,
@vcod_estado INT,
@vcod_med INT,
@vobs_det_cons	VARCHAR(300)
AS
UPDATE Tb_Consulta
SET est_cons=1
WHERE cod_cons=@vcod_cons

UPDATE Tb_Paciente
SET observaciones_pac=@vobs_det_cons
WHERE cod_pac=(SELECT cod_pac FROM Tb_Consulta WHERE cod_cons=@vcod_cons)

INSERT INTO Tb_Detalle_Consulta VALUES (@vcod_cons, @vcod_trat, @vcod_estado, @vcod_med, @vobs_det_cons)
GO
