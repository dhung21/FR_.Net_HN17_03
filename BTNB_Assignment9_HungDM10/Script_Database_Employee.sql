USE [master]
GO
/****** Object:  Database [Employee_Winform]    Script Date: 29/08/2017 5:02:38 CH ******/
CREATE DATABASE [Employee_Winform]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Employee_Winform', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Employee_Winform.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Employee_Winform_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Employee_Winform_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Employee_Winform].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Employee_Winform] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Employee_Winform] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Employee_Winform] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Employee_Winform] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Employee_Winform] SET ARITHABORT OFF 
GO
ALTER DATABASE [Employee_Winform] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Employee_Winform] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Employee_Winform] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Employee_Winform] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Employee_Winform] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Employee_Winform] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Employee_Winform] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Employee_Winform] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Employee_Winform] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Employee_Winform] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Employee_Winform] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Employee_Winform] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Employee_Winform] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Employee_Winform] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Employee_Winform] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Employee_Winform] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Employee_Winform] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Employee_Winform] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Employee_Winform] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Employee_Winform] SET  MULTI_USER 
GO
ALTER DATABASE [Employee_Winform] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Employee_Winform] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Employee_Winform] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Employee_Winform] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Employee_Winform]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 29/08/2017 5:02:38 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmpID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NOT NULL,
	[Dob] [datetime] NOT NULL,
	[EmpAddress] [nchar](100) NOT NULL,
	[Salary] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmpID], [Name], [Dob], [EmpAddress], [Salary]) VALUES (1, N'fdsa                                              ', CAST(N'2017-08-29 14:55:07.360' AS DateTime), N'fdsa                                                                                                ', 321)
INSERT [dbo].[Employee] ([EmpID], [Name], [Dob], [EmpAddress], [Salary]) VALUES (4, N'hung                                              ', CAST(N'2017-08-02 16:51:00.000' AS DateTime), N'ha noi                                                                                              ', 444)
INSERT [dbo].[Employee] ([EmpID], [Name], [Dob], [EmpAddress], [Salary]) VALUES (5, N'viet nam                                          ', CAST(N'2017-08-29 16:51:19.000' AS DateTime), N'h                                                                                                   ', 2134)
INSERT [dbo].[Employee] ([EmpID], [Name], [Dob], [EmpAddress], [Salary]) VALUES (6, N'ádfgasdf                                          ', CAST(N'2017-08-29 16:51:26.267' AS DateTime), N'dfgdas                                                                                              ', 324)
SET IDENTITY_INSERT [dbo].[Employee] OFF
USE [master]
GO
ALTER DATABASE [Employee_Winform] SET  READ_WRITE 
GO
