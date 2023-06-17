USE [master]
GO
/****** Object:  Database [ExamenFinal_DB]    Script Date: 17/06/2023 9:56:56 ******/
CREATE DATABASE [ExamenFinal_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ExamenFinal_DB', FILENAME = N'C:\SQLServer2022\Data\ExamenFinal_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ExamenFinal_DB_log', FILENAME = N'C:\SQLServer2022\Data\Log\ExamenFinal_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ExamenFinal_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ExamenFinal_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ExamenFinal_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ExamenFinal_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ExamenFinal_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ExamenFinal_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ExamenFinal_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [ExamenFinal_DB] SET  MULTI_USER 
GO
ALTER DATABASE [ExamenFinal_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ExamenFinal_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ExamenFinal_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ExamenFinal_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ExamenFinal_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ExamenFinal_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ExamenFinal_DB', N'ON'
GO
ALTER DATABASE [ExamenFinal_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [ExamenFinal_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ExamenFinal_DB]
GO
/****** Object:  Table [dbo].[TablaRegistro]    Script Date: 17/06/2023 9:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TablaRegistro](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[codigoDeProducto] [varchar](50) NOT NULL,
	[nombreProducto] [varchar](50) NOT NULL,
	[categoría] [varchar](50) NOT NULL,
	[fechaRegistro] [date] NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ExamenFinal_DB] SET  READ_WRITE 
GO
