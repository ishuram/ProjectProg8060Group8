USE [Project]
GO

/****** Object:  Table [dbo].[Student]    Script Date: 2020-04-15 9:31:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Student](
	[Email] [varchar](50) NOT NULL,
	[Start] [varchar](50) NULL,
	[Dest] [varchar](50) NULL,
	[DateCreated] [datetime] NULL,
	[SType] [varchar](50) NULL
) ON [PRIMARY]
GO

