USE [CSharpTraining]
GO
 

CREATE TABLE [dbo].[YOUR TABLE NAME HERE!](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[InDate] [datetime] NOT NULL,
	[InUser] [varchar](15) NOT NULL,
	[LastEditDate] [datetime] NULL,
	[LastEditUser] [varchar](15) NULL,
 CONSTRAINT [PK_YOUR TABLE NAME HERE!] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
 

