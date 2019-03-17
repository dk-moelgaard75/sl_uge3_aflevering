USE [smartlearning]
GO

/****** Object:  Table [dbo].[productreview]    Script Date: 17-03-2019 07:55:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[productreview](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[reviewid] [varchar](50) NULL,
	[name] [varchar](250) NULL,
	[product] [varchar](250) NULL,
	[score] [int] NULL
) ON [PRIMARY]
GO

