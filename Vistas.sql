

-- **************** VISTAS *********************

--vista de clientes con sus mascotas(pacientes)
create view vw_ClientesPacientes
as
select C.cod_cli, dni_cliente,
CONCAT( nom_cliente,' ', ape_cliente) as nombre_completo,
direccion_cliente, cel_cliente, es_dueno, 
P.cod_pac, nom_pac, R.nom_raza, estado_cli, est_pac 
from tb_Cliente_Paciente CP
left join Tb_Cliente C on C.cod_cli = CP.cod_cli
left join Tb_Paciente P on P.cod_pac = CP.cod_pac
INNER JOIN Tb_Raza R ON P.cod_raza=R.cod_raza
go


-- Vista de los clientes que son dueños de los pacientes (mascotas)
CREATE VIEW vw_ClientesSonDueños
AS
SELECT *
FROM Tb_Cliente
WHERE es_dueno = 1
GO


-- Vista de proveedor de cada medicina
CREATE VIEW vw_ProveedorMedicina
AS
SELECT P.*, M.*
FROM Tb_Proveedor P
INNER JOIN Tb_Proveedor_Medicina PM ON P.cod_prov = PM.cod_prov
INNER JOIN Tb_Medicina M ON PM.cod_med = M.cod_med
GO


-- Vista de proveedores aún activos
CREATE VIEW vw_ProveedorActivo
AS
SELECT * 
FROM Tb_Proveedor
WHERE estado_prov = 1
GO


-- Vista de cada cita realizada con su respectiva consulta, paciente y empleado a cargo
CREATE VIEW vw_CitaConsulta
AS
SELECT CI.fec_cita, CO.fec_cons, CO.cod_pac, CO.cod_emp
FROM Tb_Cita CI
INNER JOIN Tb_Consulta CO ON CI.cod_cita = CO.cod_cita
GO


-- Vista de consulta con su respectivo tratamiento y medicina
CREATE VIEW vw_ConsultaDetallada
AS
SELECT C.fec_cons, C.est_cons, T.nombre_trat, T.estado_trat, M.nombre_medicina, DC.*
FROM Tb_Consulta C
INNER JOIN Tb_Detalle_Consulta DC ON C.cod_cons = DC.cod_cons
INNER JOIN Tb_Tratamiento T ON DC.cod_trat = T.cod_trat
INNER JOIN Tb_Medicina M ON DC.cod_med = M.cod_med
GO

-- Vista más detallada de pacientes
CREATE VIEW vw_DetallesPaciente
AS
SELECT P.cod_pac AS 'codigo', P.nom_pac AS 'nombre', T.nom_tipo AS 'tipo', R.nom_raza, P.fec_nac_pac, P.sexo,
	   C.nom_color AS color, P.longitud, P.peso, E.conducta, E.est_nutricional AS 'nutricion', E.actividad, P.observaciones_pac AS 'observaciones',
	   DC.obs_det_cons AS 'det_obs', P.est_pac AS 'estado', P.foto
FROM Tb_Tipo_Paciente T
INNER JOIN Tb_Raza R ON T.cod_tipo=R.cod_tipo
LEFT JOIN Tb_Paciente P ON R.cod_raza=P.cod_raza
INNER JOIN Tb_Color C ON P.cod_color=C.cod_color
INNER JOIN Tb_Consulta CN ON P.cod_pac = CN.cod_pac
INNER JOIN Tb_Detalle_Consulta DC ON CN.cod_cons = DC.cod_cons
INNER JOIN Tb_Estado E ON DC.cod_estado = E.cod_estado
GO

--Vista consultas
CREATE VIEW vw_Consultas
AS
SELECT CO.cod_cita, CO.cod_cons, CO.fec_cons AS fecha, CO.hor_cons AS hora, CO.cod_emp,
	CONCAT(EMP.nom_empleado,' ', EMP.ape_empleado) AS medico, CO.cod_pac,
	P.nom_pac AS mascota, TP.nom_tipo AS tipo, R.nom_raza AS raza, COL.nom_color AS color, CI.cod_cli,
	CONCAT(CL.nom_cliente,' ', CL.ape_cliente) AS lo_trajo, CO.est_cons,	E.conducta, 
	E.est_nutricional, E.actividad, DC.obs_det_cons AS observaciones
FROM Tb_Cita CI
INNER JOIN Tb_Cliente CL ON CI.cod_cli=CL.cod_cli
INNER JOIN Tb_Consulta CO ON CI.cod_cita=CO.cod_cita
INNER JOIN Tb_Empleado EMP ON CO.cod_emp=EMP.cod_emp
INNER JOIN Tb_Paciente P ON CO.cod_pac=P.cod_pac
INNER JOIN Tb_Detalle_Consulta DC ON CO.cod_cons=DC.cod_cons
INNER JOIN Tb_Raza R ON P.cod_raza=R.cod_raza
INNER JOIN Tb_Tipo_Paciente TP ON R.cod_tipo=TP.cod_tipo
INNER JOIN Tb_Color COL ON P.cod_color=COL.cod_color
INNER JOIN Tb_Tratamiento T ON DC.cod_trat=T.cod_trat
INNER JOIN Tb_Estado E ON DC.cod_estado=E.cod_estado
GO