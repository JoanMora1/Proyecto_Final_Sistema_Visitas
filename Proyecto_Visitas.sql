CREATE DATABASE VISITAS_ITLA
USE VISITAS_ITLA

CREATE TABLE USUARIOS(
ID_USUARIO INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
NOMBRE NVARCHAR(50) NOT NULL,
APELLIDO NVARCHAR(50) NOT NULL,
NACIMIENTO DATE NOT NULL,
TIPO_USUARIO NVARCHAR(20) NOT NULL,
NOMBRE_USUARIO NVARCHAR(50) NOT NULL,
CONTRASENA NVARCHAR(50) NOT NULL
CONSTRAINT USUARIO_UNICO UNIQUE(NOMBRE_USUARIO),
CONSTRAINT CONTRASENA_UNICA UNIQUE(CONTRASENA)
)

CREATE TABLE EDIFICIO(
ID_EDIFICIO INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
NUMERO_EDIFICIO INT NOT NULL
CONSTRAINT EDIFICIO_UNICO UNIQUE(NUMERO_EDIFICIO)
)

CREATE TABLE AULAS(
ID_AULAS INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
NOMBRE NVARCHAR(50) NOT NULL,
NUMERO_EDIFICIO INT NOT NULL
CONSTRAINT NOMBRE_UNICO UNIQUE(NOMBRE)
CONSTRAINT AULAS_EDIFICIO FOREIGN KEY (NUMERO_EDIFICIO) REFERENCES EDIFICIO(ID_EDIFICIO)
)

CREATE TABLE VISITAS(
ID_VISITA INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
NOMBRE NVARCHAR(50) NOT NULL,
APELLIDO NVARCHAR(50) NOT NULL,
CARRERA NVARCHAR(50) NULL,
EDIFICIO INT NOT NULL,
FECHA_Y_HORA_DE_ENTRADA DATETIME NOT NULL,
FECHA_Y_HORA_DE_SALIDA DATETIME NULL,
MOTIVO_VISITA NVARCHAR(100) NOT NULL,
AULA_LUGAR NVARCHAR(50) NOT NULL,
FOTO IMAGE NULL,
CONSTRAINT VISITAS_EDIFICIO FOREIGN KEY(EDIFICIO) REFERENCES EDIFICIO(ID_EDIFICIO),
CONSTRAINT VISITAS_AULA_LUGAR FOREIGN KEY(AULA_LUGAR) REFERENCES AULAS(NOMBRE)
)

--STORED PROCEDURES

CREATE PROC SP_INSERTAR_USUARIO
@NOMBRE NVARCHAR(50),
@APELLIDO NVARCHAR(50),
@FECHA_NACIMIENTO DATE,
@TIPO_USUARIO NVARCHAR(13),
@NOMBRE_USUARIO NVARCHAR(50),
@CONTRASENA NVARCHAR(50)
AS
INSERT INTO USUARIOS(NOMBRE,APELLIDO,NACIMIENTO,TIPO_USUARIO,NOMBRE_USUARIO,CONTRASENA) VALUES (@NOMBRE,@APELLIDO,@FECHA_NACIMIENTO,@TIPO_USUARIO,@NOMBRE_USUARIO,@CONTRASENA)

CREATE PROCEDURE SP_INSERTAR_EDIFICIO
@NUMERO_EDIFICIO INT,
@NOMBRE_AULA NVARCHAR(50)
AS
INSERT INTO EDIFICIO VALUES(@NUMERO_EDIFICIO)
INSERT INTO AULAS(NOMBRE, NUMERO_EDIFICIO) VALUES(@NOMBRE_AULA,@NUMERO_EDIFICIO)

DROP PROC SP_INSERTAR_EDIFICIO

CREATE PROCEDURE SP_MODIFICAR_EDIFICIO
@NUMERO_EDIFICIO INT,
@NOMBRE_AULA NVARCHAR(50),
@NEW_AULA NVARCHAR(50)
AS
UPDATE AULAS SET NOMBRE=@NEW_AULA
WHERE NUMERO_EDIFICIO=@NUMERO_EDIFICIO AND NOMBRE=@NOMBRE_AULA

CREATE PROCEDURE SP_AGREGAR_AULAS
@NUMERO_EDIFICIO INT,
@NOMBRE_AULA NVARCHAR(50)
AS
INSERT INTO AULAS(NOMBRE,NUMERO_EDIFICIO) VALUES(@NOMBRE_AULA,@NUMERO_EDIFICIO)

DROP PROC SP_AGREGAR_AULAS

CREATE PROCEDURE SP_AGREGAR_VISITA
@NOMBRE NVARCHAR(50),
@APELLIDO NVARCHAR(50),
@CARRERA NVARCHAR(50),
@EDIFICIO INT,
@FECHA_Y_HORA_DE_ENTRADA DATETIME,
@FECHA_Y_HORA_DE_SALIDA DATETIME,
@MOTIVO_VISITA NVARCHAR(100),
@AULA_LUGAR NVARCHAR(50)
AS
INSERT INTO VISITAS(NOMBRE, APELLIDO,CARRERA,EDIFICIO,FECHA_Y_HORA_DE_ENTRADA,FECHA_Y_HORA_DE_SALIDA,MOTIVO_VISITA,AULA_LUGAR) VALUES(@NOMBRE,@APELLIDO,@CARRERA,@EDIFICIO,@FECHA_Y_HORA_DE_ENTRADA,@FECHA_Y_HORA_DE_SALIDA,@MOTIVO_VISITA,@AULA_LUGAR)

CREATE PROCEDURE SP_BUSCAR_VISITAS_X_EDIFICIO
@EDIFICIO INT
AS
SELECT * FROM VISITAS WHERE EDIFICIO = @EDIFICIO

CREATE PROCEDURE SP_VALIDAR_USUARIO
@NOMBRE_USUARIO NVARCHAR(30),
@CONTRASENA NVARCHAR(50)
AS
SELECT TIPO_USUARIO FROM USUARIOS WHERE NOMBRE_USUARIO=@NOMBRE_USUARIO AND CONTRASENA=@CONTRASENA

CREATE PROCEDURE SP_VER_EDIFICIOS
AS
SELECT NUMERO_EDIFICIO FROM EDIFICIO

CREATE PROCEDURE SP_VER_AULAS
AS
SELECT NOMBRE FROM AULAS

CREATE PROCEDURE SP_BUSCAR_AULAS_X_EDIFICIO
@NUMERO_EDIFICIO INT
AS
SELECT NOMBRE FROM AULAS WHERE NUMERO_EDIFICIO = @NUMERO_EDIFICIO