SET QUOTED_IDENTIFIER ON

go

/* Create BeLife database.                                                                  */
use master  
go

create database "MySite"  
go

use "MySite"  
go
-- Sección de Creación de tablas --

-- Tabla Region --
CREATE TABLE Region
(
 codigo VARCHAR(10) NOT NULL,
 nombre VARCHAR(80) NOT NULL,
);

-- Agregar restricciones de PK
ALTER TABLE Region ADD CONSTRAINT COD_REGION_PK PRIMARY KEY (codigo);

-- Tabla Comuna --
CREATE TABLE Comuna
(
 codigo VARCHAR(10) NOT NULL,
 nombre VARCHAR(80) NOT NULL,
 cod_region VARCHAR(10) NOT NULL
);

-- Agregar restricciones de PK
ALTER TABLE Comuna ADD CONSTRAINT COD_COMUNA_PK PRIMARY KEY (codigo);
-- Agregar restricciones de PK
ALTER TABLE Comuna ADD CONSTRAINT FK_COMUNA_REGION FOREIGN KEY (cod_region)
REFERENCES Region(codigo);
go

-- Tabla Usuario --
CREATE TABLE Usuario
(
 nombre_usuario VARCHAR(40) NOT NULL,
 pass VARCHAR(80) NOT NULL,
);

-- Agregar restricciones de PK
ALTER TABLE Usuario ADD CONSTRAINT NOM_USUARIO_PK PRIMARY KEY (nombre_usuario);

INSERT INTO Usuario (nombre_usuario, pass) VALUES ('admin', '123456');