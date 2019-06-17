CREATE database db_signalr;

USE [db_signalr]
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 17/06/2019 3:01:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comentario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[texto] [varchar](250) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
