use Registro
go

CREATE TABLE TipoDocumento (
IDTipoDocumento int not null PRIMARY KEY,
NombreDocumento varchar(50) not null,
)

CREATE TABLE Roles (
IDRoles int not null PRIMARY KEY,
NombreRol varchar(50) not null,
)

CREATE TABLE Usuario (
IDUsuario int not null PRIMARY KEY,
IDTipoDocumento int not null,
IDRoles int not null,
Cedula int not null,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Edad int not null,
Contraseña varchar(20) not null,

constraint FK_Usuario_IDTipoDocumento FOREIGN KEY (IDTipoDocumento) REFERENCES TipoDocumento (IDTipoDocumento),
constraint FK_Usuario_IDRoles FOREIGN KEY (IDRoles) REFERENCES Roles (IDRoles)
)

CREATE TABLE Buscador (
IDBuscador int not null PRIMARY KEY,
Nombre varchar(50) not null,
Apellido varchar(50) not null,
Edad int not null,
)

CREATE TABLE Parentezco (
IDParentezco int not null PRIMARY KEY,
NombreParentezco varchar(50) not null,
)

CREATE TABLE PersonaFamilia (
IDFamilia int not null PRIMARY KEY,
IDParentezco int not null,
Nombre varchar not null,
Edad int not null,

constraint FK_PersonaFamilia_IDParentezco FOREIGN KEY (IDParentezco) REFERENCES Parentezco (IDParentezco)
)
