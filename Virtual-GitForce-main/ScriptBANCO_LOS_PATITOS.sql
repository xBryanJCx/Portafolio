CREATE DATABASE BANCO_LOS_PATITOS

GO

USE BANCO_LOS_PATITOS 

GO

CREATE TABLE COMERCIOS (
    IdComercio INT IDENTITY (1,1) NOT NULL,
    Identificacion VARCHAR(30) NOT NULL,
    TipoIdentificacion INT NOT NULL,  
    Nombre VARCHAR(200) NOT NULL,
    TipoDeComercio INT NOT NULL,      
    Telefono VARCHAR(20) NOT NULL,
    CorreoElectronico VARCHAR(200) NOT NULL,
    Direccion VARCHAR(500) NOT NULL,
    FechaDeRegistro DATETIME NOT NULL,
    FechaDeModificacion DATETIME NULL,
    Estado BIT NOT NULL
);
GO



