USE [csharp-db]
GO
/****** Object:  Table [dbo].[tbl_book]    Script Date: 05/06/2010 16:38:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_book](
	[isbn] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[name] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[author] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[description] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[borrowed_by] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[borrowed_date] [nchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
