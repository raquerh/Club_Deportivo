DROP DATABASE IF EXISTS Proyecto;
CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE roles(
RolUsuario INT,
NombreRol VARCHAR(30),
CONSTRAINT PRIMARY KEY(RolUsuario)
);

INSERT INTO roles VALUES
(120,'ADMIN'),
(121,'Empleado');

CREATE TABLE usuarios(
CodigoUsuario INT AUTO_INCREMENT,
NombreUsuario VARCHAR (20),
PasswordUsuario VARCHAR (15),
RolUsuario INT,
Activo BOOLEAN DEFAULT TRUE,
CONSTRAINT pk_usuario PRIMARY KEY (CodigoUsuario),
CONSTRAINT fk_usuario FOREIGN KEY(RolUsuario) references roles(RolUsuario)
);

INSERT INTO usuarios(CodigoUsuario,NombreUsuario,PasswordUsuario,RolUsuario) VALUES
(1,'Ema2025','123456',120);


-- Tabla Persona (base para Socio)
CREATE TABLE Personas (
    idPersona INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(30) NOT NULL,
    apellido VARCHAR(30) NOT NULL,
    tipoDocumento VARCHAR(20) NOT NULL,
    nroDocumento VARCHAR(20) NOT NULL,
    fechaNacimiento DATE NOT NULL,
    direccion VARCHAR(50) NOT NULL,
    email VARCHAR(30) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    CONSTRAINT UQ_Personas_nroDocumento UNIQUE (nroDocumento)
);


-- Tabla Socios (hereda de Persona)
CREATE TABLE Socios (
    idSocio INT PRIMARY KEY AUTO_INCREMENT,
    idPersona INT NOT NULL,
    numeroSocio INT NOT NULL,
    tipoSocio VARCHAR(20) NOT NULL,
    fechaAlta DATE NOT NULL DEFAULT (CURRENT_DATE),
    fechaPago DATE NOT NULL,
    estadoCuota VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Socios_Personas FOREIGN KEY (idPersona) REFERENCES Personas(idPersona),
    CONSTRAINT UQ_Socios_numeroSocio UNIQUE (numeroSocio),
    CONSTRAINT UQ_Socios_idPersona UNIQUE (idPersona)
);

-- Insertar 5 personas en la tabla Personas
-- Cada registro genera un idPersona único (AUTO_INCREMENT) y cumple con la restricción UQ_Personas_nroDocumento
INSERT INTO Personas (nombre, apellido, tipoDocumento, nroDocumento, fechaNacimiento, direccion, email, telefono) VALUES
('Juan', 'Pérez', 'DNI', '30123456', '1990-05-15', 'Av. Libertad 123, Buenos Aires', 'juan.perez@email.com', '1151234567'),
('María', 'Gómez', 'DNI', '32165487', '1985-08-22', 'Calle San Martín 456, Córdoba', 'maria.gomez@email.com', '3512345678'),
('Carlos', 'López', 'DNI', '28765432', '1992-03-10', 'Av. Colón 789, Mendoza', 'carlos.lopez@email.com', '2612345678'),
('Ana', 'Martínez', 'DNI', '34123456', '1988-11-30', 'Calle Belgrano 101, Rosario', 'ana.martinez@email.com', '3412345678'),
('Lucas', 'Rodríguez', 'DNI', '30987654', '1995-07-05', 'Av. Rivadavia 202, La Plata', 'lucas.rodriguez@email.com', '2212345678');

-- Insertar 5 socios en la tabla Socios
-- Cada registro usa un idPersona existente (1 a 5), cumple con FK_Socios_Personas, UQ_Socios_numeroSocio y UQ_Socios_idPersona
INSERT INTO Socios (idPersona, numeroSocio, tipoSocio, fechaAlta, fechaPago, estadoCuota) VALUES
(1, 1001, 'Activo', '2025-01-01', '2025-05-01', 'Al día'),
(2, 1002, 'Adherente', '2025-02-15', '2025-04-15', 'Vencida'),
(3, 1003, 'Activo', '2025-03-10', '2025-05-10', 'Al día'),
(4, 1004, 'Adherente', '2025-04-20', '2025-04-20', 'Vencida'),
(5, 1005, 'Activo', '2025-05-01', '2025-05-01', 'Al día');


-- Tabla AptoFisico
CREATE TABLE AptoFisico (
    idAptoFisico INT PRIMARY KEY AUTO_INCREMENT,
    numeroSocio INT NOT NULL,
    esApto VARCHAR(20) NOT NULL,
    vtoAptoFisico DATE NOT NULL,
    CONSTRAINT UQ_AptoFisico_numeroSocio UNIQUE (numeroSocio)
);

-- Insertar 5 registros en la tabla AptoFisico
-- Cada registro corresponde a un socio existente (numeroSocio: 1001 a 1005)
INSERT INTO AptoFisico (numeroSocio, esApto, vtoAptoFisico) VALUES
(1001, 'Apto', '2026-05-01'), -- Juan Pérez, apto hasta 1 año después de la fecha actual
(1002, 'No apto', '2025-04-15'), -- María Gómez, no apto, vencimiento reciente
(1003, 'Apto', '2026-05-10'), -- Carlos López, apto hasta 1 año después
(1004, 'Apto', '2026-04-20'), -- Ana Martínez, apto hasta 1 año después
(1005, 'Apto', '2026-05-01'); -- Lucas Rodríguez, apto hasta 1 año después

CREATE TABLE Pagos (
    nro_comprobante INT PRIMARY KEY AUTO_INCREMENT,
    numeroSocio INT,
    tipo VARCHAR(20),
    actividad VARCHAR(50),
    importe DECIMAL(10,2),
    metodo_pago VARCHAR(20),
    cuotas INT,
    fecha DATE,
    vencimiento DATE,
    FOREIGN KEY (numeroSocio) REFERENCES socios(numeroSocio)
);