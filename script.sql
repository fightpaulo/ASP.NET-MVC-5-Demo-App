USE [master]
GO
/****** Object:  Database [CadeMeuMedicoDB]    Script Date: 31/12/2019 15:00:00 ******/
CREATE DATABASE [CadeMeuMedicoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CadeMeuMedicoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CadeMeuMedicoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CadeMeuMedicoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\CadeMeuMedicoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CadeMeuMedicoDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CadeMeuMedicoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CadeMeuMedicoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET  MULTI_USER 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CadeMeuMedicoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CadeMeuMedicoDB] SET QUERY_STORE = OFF
GO
USE [CadeMeuMedicoDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CadeMeuMedicoDB]
GO
/****** Object:  Table [dbo].[BannersPublicitarios]    Script Date: 31/12/2019 15:00:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BannersPublicitarios](
	[IDBanner] [bigint] IDENTITY(1,1) NOT NULL,
	[TituloCampanha] [varchar](60) NOT NULL,
	[BannerCampanha] [varchar](200) NOT NULL,
	[LinkBanner] [varchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBanner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 31/12/2019 15:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cidade](
	[IDCidade] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidade]    Script Date: 31/12/2019 15:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidade](
	[IDEspecialidade] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDEspecialidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medico]    Script Date: 31/12/2019 15:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[IDMedico] [bigint] IDENTITY(1,1) NOT NULL,
	[CRM] [varchar](30) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
	[Endereco] [varchar](100) NOT NULL,
	[Bairro] [varchar](60) NOT NULL,
	[Email] [varchar](100) NULL,
	[AtendePorConvenio] [bit] NOT NULL,
	[TemClinica] [bit] NOT NULL,
	[WebsiteBlog] [varchar](80) NULL,
	[IDCidade] [int] NOT NULL,
	[IDEspecialidade] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 31/12/2019 15:00:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IDUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](80) NOT NULL,
	[Login] [varchar](30) NOT NULL,
	[Senha] [varchar](100) NOT NULL,
	[Email] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BannersPublicitarios] ON 

INSERT [dbo].[BannersPublicitarios] ([IDBanner], [TituloCampanha], [BannerCampanha], [LinkBanner]) VALUES (1, N'Go to the Google', N'degel.jpg', N'http://www.google.com.br')
INSERT [dbo].[BannersPublicitarios] ([IDBanner], [TituloCampanha], [BannerCampanha], [LinkBanner]) VALUES (2, N'Go to the JJ Consulting website', N'degel_oculos.jpg', N'http://www.jjconsulting.com.br')
SET IDENTITY_INSERT [dbo].[BannersPublicitarios] OFF
SET IDENTITY_INSERT [dbo].[Cidade] ON 

INSERT [dbo].[Cidade] ([IDCidade], [Nome]) VALUES (2, N'São José do Rio Preto')
INSERT [dbo].[Cidade] ([IDCidade], [Nome]) VALUES (3, N'Blumenau')
INSERT [dbo].[Cidade] ([IDCidade], [Nome]) VALUES (4, N'São Paulo')
INSERT [dbo].[Cidade] ([IDCidade], [Nome]) VALUES (5, N'Mococa')
INSERT [dbo].[Cidade] ([IDCidade], [Nome]) VALUES (6, N'Suzano')
INSERT [dbo].[Cidade] ([IDCidade], [Nome]) VALUES (7, N'Mogi das Cruzes')
SET IDENTITY_INSERT [dbo].[Cidade] OFF
SET IDENTITY_INSERT [dbo].[Especialidade] ON 

INSERT [dbo].[Especialidade] ([IDEspecialidade], [Nome]) VALUES (1, N'Cardiologista')
INSERT [dbo].[Especialidade] ([IDEspecialidade], [Nome]) VALUES (2, N'Neurologista')
INSERT [dbo].[Especialidade] ([IDEspecialidade], [Nome]) VALUES (3, N'Endrocrinologista')
INSERT [dbo].[Especialidade] ([IDEspecialidade], [Nome]) VALUES (4, N'Oftalmologista')
INSERT [dbo].[Especialidade] ([IDEspecialidade], [Nome]) VALUES (5, N'Ortopedista')
INSERT [dbo].[Especialidade] ([IDEspecialidade], [Nome]) VALUES (6, N'Nefrologista')
INSERT [dbo].[Especialidade] ([IDEspecialidade], [Nome]) VALUES (8, N'Urologista')
SET IDENTITY_INSERT [dbo].[Especialidade] OFF
SET IDENTITY_INSERT [dbo].[Medico] ON 

INSERT [dbo].[Medico] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (5, N'123456', N'Paulo Silas dos Anjos', N'Rua das Aboboreiras', N'San Joaquín', N'paulo.teste@teste.com.br', 1, 1, NULL, 2, 2)
INSERT [dbo].[Medico] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (8, N'123456', N'Fernanda Santos', N'Rua das Aboboreiras', N'San Joaquín', N'fernanda@teste.com.br', 0, 1, NULL, 2, 1)
INSERT [dbo].[Medico] ([IDMedico], [CRM], [Nome], [Endereco], [Bairro], [Email], [AtendePorConvenio], [TemClinica], [WebsiteBlog], [IDCidade], [IDEspecialidade]) VALUES (12, N'ABC123', N'Felipe Candido', N'Rua Paraíso', N'Vila Mariana', N'felipe.candido@jjconsulting.com.br', 1, 1, N'www.jjconsulting.com.br', 4, 5)
SET IDENTITY_INSERT [dbo].[Medico] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IDUsuario], [Nome], [Login], [Senha], [Email]) VALUES (1, N'Administrador', N'admin', N'senha', N'admin@cdmm.com')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
ALTER TABLE [dbo].[Medico]  WITH CHECK ADD  CONSTRAINT [fk_medicos_cidades] FOREIGN KEY([IDCidade])
REFERENCES [dbo].[Cidade] ([IDCidade])
GO
ALTER TABLE [dbo].[Medico] CHECK CONSTRAINT [fk_medicos_cidades]
GO
ALTER TABLE [dbo].[Medico]  WITH CHECK ADD  CONSTRAINT [fk_medicos_especialidades] FOREIGN KEY([IDEspecialidade])
REFERENCES [dbo].[Especialidade] ([IDEspecialidade])
GO
ALTER TABLE [dbo].[Medico] CHECK CONSTRAINT [fk_medicos_especialidades]
GO
USE [master]
GO
ALTER DATABASE [CadeMeuMedicoDB] SET  READ_WRITE 
GO
