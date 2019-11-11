USE [master]
GO
/****** Object:  Database [MyTestDB]    Script Date: 11.11.2019 20:11:29 ******/
CREATE DATABASE [MyTestDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MyTestDB', FILENAME = N'C:\Users\juris\MyTestDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MyTestDB_log', FILENAME = N'C:\Users\juris\MyTestDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MyTestDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyTestDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyTestDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyTestDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyTestDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyTestDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyTestDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyTestDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyTestDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyTestDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyTestDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyTestDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyTestDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyTestDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyTestDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyTestDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyTestDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyTestDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyTestDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyTestDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyTestDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyTestDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyTestDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyTestDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyTestDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyTestDB] SET  MULTI_USER 
GO
ALTER DATABASE [MyTestDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyTestDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyTestDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyTestDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MyTestDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MyTestDB] SET QUERY_STORE = OFF
GO
USE [MyTestDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [MyTestDB]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11.11.2019 20:11:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Find_Users]    Script Date: 11.11.2019 20:11:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Find_Users]
	-- Add the parameters for the stored procedure here
	@name NVARCHAR
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id, Name
	FROM Users
	WHERE Name Like '%'+@name+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Users]    Script Date: 11.11.2019 20:11:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Get_Users]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT *
	FROM Users
	ORDER BY Name asc;
END
GO
USE [master]
GO
ALTER DATABASE [MyTestDB] SET  READ_WRITE 
GO
