USE [master]
GO
/****** Object:  Database [FootballManager]    Script Date: 2021/01/15 11:24:45 ******/
CREATE DATABASE [FootballManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FootballManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FootballManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FootballManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\FootballManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [FootballManager] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FootballManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FootballManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FootballManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FootballManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FootballManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FootballManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [FootballManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FootballManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FootballManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FootballManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FootballManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FootballManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FootballManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FootballManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FootballManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FootballManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FootballManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FootballManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FootballManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FootballManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FootballManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FootballManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FootballManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FootballManager] SET RECOVERY FULL 
GO
ALTER DATABASE [FootballManager] SET  MULTI_USER 
GO
ALTER DATABASE [FootballManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FootballManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FootballManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FootballManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FootballManager] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FootballManager', N'ON'
GO
ALTER DATABASE [FootballManager] SET QUERY_STORE = OFF
GO
USE [FootballManager]
GO
/****** Object:  Table [dbo].[Player]    Script Date: 2021/01/15 11:24:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[PlayerId] [bigint] IDENTITY(1,1) NOT NULL,
	[FKTeamId] [int] NULL,
	[PlayerName] [nvarchar](50) NULL,
	[PlayerSurname] [nvarchar](50) NULL,
	[PlayerBirthDate] [datetime] NULL,
	[PlayerNumber] [int] NULL,
	[FKPlayerPosition] [smallint] NULL,
	[PlayerHeightCm] [int] NULL,
	[PlayerWeightKg] [int] NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[PlayerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlayerPosition]    Script Date: 2021/01/15 11:24:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlayerPosition](
	[PlayerPosition] [smallint] IDENTITY(1,1) NOT NULL,
	[PlayerPositionName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PlayerPosition] PRIMARY KEY CLUSTERED 
(
	[PlayerPosition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stadium]    Script Date: 2021/01/15 11:24:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stadium](
	[StadiumId] [int] IDENTITY(1,1) NOT NULL,
	[StadiumName] [nvarchar](50) NULL,
	[StadiumCapacity] [int] NULL,
 CONSTRAINT [PK_Stadium] PRIMARY KEY CLUSTERED 
(
	[StadiumId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 2021/01/15 11:24:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Team](
	[TeamId] [int] IDENTITY(1,1) NOT NULL,
	[FKStadiumId] [int] NULL,
	[TeamName] [nvarchar](50) NULL,
	[TeamLocation] [nvarchar](50) NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_PlayerPosition] FOREIGN KEY([FKPlayerPosition])
REFERENCES [dbo].[PlayerPosition] ([PlayerPosition])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_PlayerPosition]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Team] FOREIGN KEY([FKTeamId])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Team]
GO
ALTER TABLE [dbo].[Team]  WITH CHECK ADD  CONSTRAINT [FK_Team_Stadium] FOREIGN KEY([FKStadiumId])
REFERENCES [dbo].[Stadium] ([StadiumId])
GO
ALTER TABLE [dbo].[Team] CHECK CONSTRAINT [FK_Team_Stadium]
GO
USE [master]
GO
ALTER DATABASE [FootballManager] SET  READ_WRITE 
GO
