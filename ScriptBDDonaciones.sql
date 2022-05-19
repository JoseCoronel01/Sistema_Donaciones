--Sql server 2019 18.11.1
CREATE DATABASE Donaciones;
GO

USE [Donaciones]
GO
/****** Object:  Table [dbo].[DatosEmpresa]    Script Date: 18/05/2022 10:33:14 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatosEmpresa](
	[Nombre] [varchar](80) NULL,
	[Direccion] [varchar](500) NULL,
	[RFC] [varchar](13) NULL,
	[Ciudad] [varchar](40) NULL,
	[CP] [varchar](5) NULL,
	[RutaDirectorio] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donaciones]    Script Date: 18/05/2022 10:33:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donaciones](
	[Donador] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Monto] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[Donador] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donadores]    Script Date: 18/05/2022 10:33:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donadores](
	[Id] [int] NOT NULL,
	[TipoDonador] [varchar](15) NOT NULL,
	[Matricula] [varchar](30) NOT NULL,
	[ApellidoPat] [varchar](30) NULL,
	[ApellidoMat] [varchar](30) NULL,
	[Nombre] [varchar](80) NULL,
	[Curp] [varchar](16) NULL,
	[RFC] [varchar](13) NULL,
	[FechaNac] [datetime] NULL,
	[FechaReg] [datetime] NOT NULL,
	[Direccion] [varchar](500) NULL,
	[Telefono] [varchar](25) NULL,
	[TelefonoCel] [varchar](25) NULL,
	[TelefonoOfi] [varchar](25) NULL,
	[Correo] [varchar](35) NULL,
	[CorreoAlt] [varchar](35) NULL,
	[Sexo] [char](1) NULL,
	[Ocupacion] [varchar](35) NULL,
	[Importe] [float] NULL,
	[Perfil] [varchar](100) NULL,
	[Estatus] [char](1) NULL,
 CONSTRAINT [PK__Donadore__3214EC0725AC6997] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 18/05/2022 10:33:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[Clave] [varchar](2) NOT NULL,
	[Estado] [varchar](50) NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[Clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relacion_Donadores]    Script Date: 18/05/2022 10:33:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relacion_Donadores](
	[Donador_Padre] [int] NULL,
	[Donador_Hijo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDonador]    Script Date: 18/05/2022 10:33:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDonador](
	[Clave] [varchar](15) NOT NULL,
	[Nombre] [varchar](35) NOT NULL,
	[Descripcion] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Clave] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosSistema]    Script Date: 18/05/2022 10:33:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosSistema](
	[Usuario] [varchar](15) NOT NULL,
	[Password] [varchar](15) NOT NULL,
	[Tipo] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitas]    Script Date: 18/05/2022 10:33:15 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitas](
	[Donador] [int] NOT NULL,
	[Donador_Vistante] [int] NULL,
	[Fecha] [datetime] NOT NULL,
	[Motivo] [varchar](30) NULL,
	[Observaciones] [varchar](1000) NULL,
PRIMARY KEY CLUSTERED 
(
	[Donador] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Donaciones] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Donadores] ADD  CONSTRAINT [DF__Donadores__Fecha__1367E606]  DEFAULT (getdate()) FOR [FechaReg]
GO
ALTER TABLE [dbo].[Donaciones]  WITH CHECK ADD  CONSTRAINT [FK__Donacione__Donad__1BFD2C07] FOREIGN KEY([Donador])
REFERENCES [dbo].[Donadores] ([Id])
GO
ALTER TABLE [dbo].[Donaciones] CHECK CONSTRAINT [FK__Donacione__Donad__1BFD2C07]
GO
ALTER TABLE [dbo].[Donadores]  WITH CHECK ADD  CONSTRAINT [FK__Donadores__TipoD__1CF15040] FOREIGN KEY([TipoDonador])
REFERENCES [dbo].[TipoDonador] ([Clave])
GO
ALTER TABLE [dbo].[Donadores] CHECK CONSTRAINT [FK__Donadores__TipoD__1CF15040]
GO
ALTER TABLE [dbo].[Relacion_Donadores]  WITH CHECK ADD  CONSTRAINT [FK__Relacion___Donad__1DE57479] FOREIGN KEY([Donador_Hijo])
REFERENCES [dbo].[Donadores] ([Id])
GO
ALTER TABLE [dbo].[Relacion_Donadores] CHECK CONSTRAINT [FK__Relacion___Donad__1DE57479]
GO
ALTER TABLE [dbo].[Visitas]  WITH CHECK ADD  CONSTRAINT [FK__Visitas__Donador__1ED998B2] FOREIGN KEY([Donador])
REFERENCES [dbo].[Donadores] ([Id])
GO
ALTER TABLE [dbo].[Visitas] CHECK CONSTRAINT [FK__Visitas__Donador__1ED998B2]
GO
ALTER TABLE [dbo].[Visitas]  WITH CHECK ADD  CONSTRAINT [FK__Visitas__Donador__1FCDBCEB] FOREIGN KEY([Donador_Vistante])
REFERENCES [dbo].[Donadores] ([Id])
GO
ALTER TABLE [dbo].[Visitas] CHECK CONSTRAINT [FK__Visitas__Donador__1FCDBCEB]
GO
