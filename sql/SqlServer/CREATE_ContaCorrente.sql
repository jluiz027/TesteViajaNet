USE [TesteDBServer]
GO

/****** Object:  Table [dbo].[ContaCorrente]    Script Date: 14/11/2019 03:02:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContaCorrente](
	[id] [uniqueidentifier]  Not NULL,
	[saldoinicial] money NOT NULL,
	PRIMARY KEY (id)
) ON [PRIMARY]
GO


