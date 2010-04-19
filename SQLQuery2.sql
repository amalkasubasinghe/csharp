SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_employee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_employee](
	[id] [smallint] NOT NULL,
	[name] [nchar](10) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_borrowings]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_borrowings](
	[book_id] [nchar](10) NOT NULL,
	[employee_id] [nchar](10) NOT NULL,
	[borrowed_date] [nchar](10) NOT NULL,
	[returned_date] [nchar](10) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_book]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_book](
	[id] [nchar](10) NOT NULL,
	[name] [nchar](10) NOT NULL,
	[author] [nchar](10) NOT NULL,
	[description] [nchar](10) NOT NULL
) ON [PRIMARY]
END
