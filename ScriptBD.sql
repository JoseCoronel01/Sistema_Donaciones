CREATE TABLE DatosEmpresa
(
	Nombre varchar(80) NULL,
	Direccion varchar(500) NULL,
	RFC varchar(13) NULL,
	Ciudad varchar(40) NULL,
	CP varchar(5) NULL,
	RutaDirectorio varchar(max) NULL
)

CREATE TABLE Donaciones
(
	Donador int NOT NULL,
	Fecha datetime NOT NULL DEFAULT (getdate()),
	Monto money NULL,
	PRIMARY KEY CLUSTERED (Donador, Fecha)
)

CREATE TABLE Donadores
(
	Id int NOT NULL,
	TipoDonador varchar(15) NOT NULL,
	Matricula varchar(30) NOT NULL,
	ApellidoPat varchar(30) NULL,
	ApellidoMat varchar(30) NULL,
	Nombre varchar(80) NULL,
	Curp varchar(16) NULL,
	RFC varchar(13) NULL,
	FechaNac datetime NULL,
	FechaReg datetime NOT NULL CONSTRAINT DF__Donadores__Fecha__1367E606  DEFAULT (getdate()),
	Direccion varchar(500) NULL,
	Telefono varchar(25) NULL,
	TelefonoCel varchar(25) NULL,
	TelefonoOfi varchar(25) NULL,
	Correo varchar(35) NULL,
	CorreoAlt varchar(35) NULL,
	Sexo char(1) NULL,
	Ocupacion varchar(35) NULL,
	Importe float NULL,
	Perfil varchar(100) NULL,
	Estatus char(1) NULL,
	CONSTRAINT PK__Donadore__3214EC0725AC6997 PRIMARY KEY CLUSTERED (Id) 
)

CREATE TABLE Estados
(
	Clave varchar(2) NOT NULL,
	Estado varchar(50) NULL,
	CONSTRAINT PK_Estados PRIMARY KEY CLUSTERED (Clave) 
)

CREATE TABLE Relacion_Donadores
(
	Donador_Padre int NULL,
	Donador_Hijo int NOT NULL
)

CREATE TABLE TipoDonador
(
	Clave varchar(15) NOT NULL,
	Nombre varchar(35) NOT NULL,
	Descripcion varchar(100) NULL,
	PRIMARY KEY CLUSTERED (Clave) 
)

CREATE TABLE UsuariosSistema
(
	Usuario varchar(15) NOT NULL,
	Password varchar(15) NOT NULL,
	Tipo char(1) NOT NULL,
	PRIMARY KEY CLUSTERED (Usuario) 
)

CREATE TABLE Visitas
(
	Donador int NOT NULL,
	Donador_Vistante int NULL,
	Fecha datetime NOT NULL,
	Motivo varchar(30) NULL,
	Observaciones varchar(1000) NULL,
	PRIMARY KEY CLUSTERED (Donador, Fecha)
)

ALTER TABLE Donaciones  WITH CHECK ADD  CONSTRAINT FK__Donacione__Donad__1BFD2C07 FOREIGN KEY (Donador)
REFERENCES Donadores (Id)

ALTER TABLE Donaciones CHECK CONSTRAINT FK__Donacione__Donad__1BFD2C07

ALTER TABLE Donadores  WITH CHECK ADD  CONSTRAINT FK__Donadores__TipoD__1CF15040 FOREIGN KEY (TipoDonador)
REFERENCES TipoDonador (Clave)

ALTER TABLE Donadores CHECK CONSTRAINT FK__Donadores__TipoD__1CF15040

ALTER TABLE Relacion_Donadores  WITH CHECK ADD  CONSTRAINT FK__Relacion___Donad__1DE57479 FOREIGN KEY (Donador_Hijo)
REFERENCES Donadores (Id)

ALTER TABLE Relacion_Donadores CHECK CONSTRAINT FK__Relacion___Donad__1DE57479

ALTER TABLE Visitas  WITH CHECK ADD  CONSTRAINT FK__Visitas__Donador__1ED998B2 FOREIGN KEY (Donador)
REFERENCES Donadores (Id)

ALTER TABLE Visitas CHECK CONSTRAINT FK__Visitas__Donador__1ED998B2

ALTER TABLE Visitas  WITH CHECK ADD  CONSTRAINT FK__Visitas__Donador__1FCDBCEB FOREIGN KEY (Donador_Vistante)
REFERENCES Donadores (Id)

ALTER TABLE Visitas CHECK CONSTRAINT FK__Visitas__Donador__1FCDBCEB
