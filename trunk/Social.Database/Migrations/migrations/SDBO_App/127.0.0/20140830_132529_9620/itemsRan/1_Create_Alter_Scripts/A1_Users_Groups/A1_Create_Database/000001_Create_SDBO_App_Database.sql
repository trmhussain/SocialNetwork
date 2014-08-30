﻿/*************************************************************
** File:    000001_Create_SDBO_App_Database.sql
** Name:	DATABASE [SDBO_App]
** Desc:	
**
**
**
**
**
** Auth:	Justin Jarczyk
** Date:	8/29/2014
**************************
** Change History
**************************
** PR		Date			Author				Description	
** --		--------		-------				------------------------------------
** 1		8/29/2014		Justin Jarczyk		Created Script
**
**
**************************************************************/

USE [master]
GO


/****** Object:  Database [SDBO_App]    Script Date: 8/29/2014 4:52:24 PM ******/
/*
CREATE DATABASE [SDBO_App]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SDBO_App', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SDBO_App.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SDBO_App_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\SDBO_App_log.ldf' , SIZE = 784KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [SDBO_App] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SDBO_App].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [SDBO_App] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [SDBO_App] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [SDBO_App] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [SDBO_App] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [SDBO_App] SET ARITHABORT OFF 
GO

ALTER DATABASE [SDBO_App] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [SDBO_App] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [SDBO_App] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [SDBO_App] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [SDBO_App] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [SDBO_App] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [SDBO_App] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [SDBO_App] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [SDBO_App] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [SDBO_App] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [SDBO_App] SET  ENABLE_BROKER 
GO

ALTER DATABASE [SDBO_App] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [SDBO_App] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [SDBO_App] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [SDBO_App] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [SDBO_App] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [SDBO_App] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [SDBO_App] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [SDBO_App] SET RECOVERY FULL 
GO

ALTER DATABASE [SDBO_App] SET  MULTI_USER 
GO

ALTER DATABASE [SDBO_App] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [SDBO_App] SET DB_CHAINING OFF 
GO

ALTER DATABASE [SDBO_App] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [SDBO_App] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [SDBO_App] SET  READ_WRITE 
GO

*/