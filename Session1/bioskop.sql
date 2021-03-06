USE [bioskop]
GO
/****** Object:  Table [dbo].[detailschedule]    Script Date: 8/23/2017 2:34:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detailschedule](
	[detailid] [int] IDENTITY(1,1) NOT NULL,
	[scheduleid] [int] NULL,
	[nokursi] [nvarchar](50) NULL,
 CONSTRAINT [PK_detailschedule] PRIMARY KEY CLUSTERED 
(
	[detailid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[headerschedule]    Script Date: 8/23/2017 2:34:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[headerschedule](
	[scheduleid] [int] IDENTITY(1,1) NOT NULL,
	[mappingid] [int] NULL,
	[time] [datetime] NULL,
 CONSTRAINT [PK_headerschedule] PRIMARY KEY CLUSTERED 
(
	[scheduleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mapping]    Script Date: 8/23/2017 2:34:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mapping](
	[mappingid] [int] IDENTITY(1,1) NOT NULL,
	[studiono] [int] NULL,
	[filmid] [int] NULL,
 CONSTRAINT [PK_mapping] PRIMARY KEY CLUSTERED 
(
	[mappingid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[msfilm]    Script Date: 8/23/2017 2:34:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[msfilm](
	[filmid] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
	[duration] [int] NULL,
 CONSTRAINT [PK_msfilm] PRIMARY KEY CLUSTERED 
(
	[filmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mstudio]    Script Date: 8/23/2017 2:34:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mstudio](
	[studiono] [int] NOT NULL,
	[group] [int] NULL,
	[row] [int] NULL,
	[column] [int] NULL,
 CONSTRAINT [PK_mstudio] PRIMARY KEY CLUSTERED 
(
	[studiono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[detailschedule] ON 

INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (1, 4, N'40')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (2, 4, N'41')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (3, 4, N'42')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (4, 4, N'43')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (5, 4, N'44')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (6, 4, N'60')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (7, 4, N'61')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (8, 4, N'62')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (9, 4, N'63')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (10, 4, N'64')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (11, 4, N'65')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (12, 4, N'66')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (13, 4, N'67')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (14, 4, N'68')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (15, 4, N'69')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (16, 4, N'82')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (17, 4, N'83')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (18, 4, N'84')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (19, 4, N'1')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (20, 1, N'7')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (21, 1, N'8')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (22, 1, N'47')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (23, 1, N'48')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (24, 1, N'10')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (25, 1, N'135')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (26, 1, N'43')
INSERT [dbo].[detailschedule] ([detailid], [scheduleid], [nokursi]) VALUES (27, 1, N'44')
SET IDENTITY_INSERT [dbo].[detailschedule] OFF
SET IDENTITY_INSERT [dbo].[headerschedule] ON 

INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (1, 1, CAST(N'2017-08-20T11:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (2, 1, CAST(N'2017-08-20T13:30:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (3, 1, CAST(N'2017-08-20T16:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (4, 1, CAST(N'2017-08-20T18:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (5, 1, CAST(N'2017-08-20T21:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (6, 2, CAST(N'2017-08-20T11:20:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (7, 2, CAST(N'2017-08-20T13:20:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (8, 2, CAST(N'2017-08-20T15:20:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (9, 2, CAST(N'2017-08-20T17:20:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (10, 2, CAST(N'2017-08-20T19:20:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (11, 3, CAST(N'2017-08-20T11:40:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (12, 3, CAST(N'2017-08-20T14:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (13, 3, CAST(N'2017-08-20T16:20:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (14, 3, CAST(N'2017-08-20T18:40:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (15, 3, CAST(N'2017-08-20T21:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (16, 4, CAST(N'2017-08-20T12:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (17, 4, CAST(N'2017-08-20T14:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (18, 4, CAST(N'2017-08-20T16:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (19, 4, CAST(N'2017-08-20T18:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (20, 4, CAST(N'2017-08-20T20:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (21, 5, CAST(N'2017-08-20T11:30:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (22, 5, CAST(N'2017-08-20T13:40:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (23, 5, CAST(N'2017-08-20T15:50:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (24, 5, CAST(N'2017-08-20T18:00:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (25, 5, CAST(N'2017-08-20T20:10:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (32, 11, CAST(N'2017-08-10T11:30:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (33, 11, CAST(N'2017-08-10T13:50:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (34, 11, CAST(N'2017-08-10T16:10:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (35, 11, CAST(N'2017-08-10T18:30:00.000' AS DateTime))
INSERT [dbo].[headerschedule] ([scheduleid], [mappingid], [time]) VALUES (36, 11, CAST(N'2017-08-10T20:50:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[headerschedule] OFF
SET IDENTITY_INSERT [dbo].[mapping] ON 

INSERT [dbo].[mapping] ([mappingid], [studiono], [filmid]) VALUES (1, 1, 3)
INSERT [dbo].[mapping] ([mappingid], [studiono], [filmid]) VALUES (2, 2, 1)
INSERT [dbo].[mapping] ([mappingid], [studiono], [filmid]) VALUES (3, 3, 1)
INSERT [dbo].[mapping] ([mappingid], [studiono], [filmid]) VALUES (4, 4, 2)
INSERT [dbo].[mapping] ([mappingid], [studiono], [filmid]) VALUES (5, 5, 4)
INSERT [dbo].[mapping] ([mappingid], [studiono], [filmid]) VALUES (11, 1, 5)
SET IDENTITY_INSERT [dbo].[mapping] OFF
SET IDENTITY_INSERT [dbo].[msfilm] ON 

INSERT [dbo].[msfilm] ([filmid], [title], [duration]) VALUES (1, N'DUNKIRK', 120)
INSERT [dbo].[msfilm] ([filmid], [title], [duration]) VALUES (2, N'VALERIAN AND THE CITY OF A THOUSAND PLANETS', 100)
INSERT [dbo].[msfilm] ([filmid], [title], [duration]) VALUES (3, N'WAR FOR THE PLANET OF THE APES', 130)
INSERT [dbo].[msfilm] ([filmid], [title], [duration]) VALUES (4, N'THE CRUCIFIXION', 110)
INSERT [dbo].[msfilm] ([filmid], [title], [duration]) VALUES (5, N'SPIDER-MAN: HOMECOMING', 120)
INSERT [dbo].[msfilm] ([filmid], [title], [duration]) VALUES (6, N'DESPICABLE ME 3', 90)
SET IDENTITY_INSERT [dbo].[msfilm] OFF
INSERT [dbo].[mstudio] ([studiono], [group], [row], [column]) VALUES (1, 3, 9, 5)
INSERT [dbo].[mstudio] ([studiono], [group], [row], [column]) VALUES (2, 2, 11, 7)
INSERT [dbo].[mstudio] ([studiono], [group], [row], [column]) VALUES (3, 3, 10, 6)
INSERT [dbo].[mstudio] ([studiono], [group], [row], [column]) VALUES (4, 2, 9, 8)
INSERT [dbo].[mstudio] ([studiono], [group], [row], [column]) VALUES (5, 3, 11, 6)
ALTER TABLE [dbo].[detailschedule]  WITH CHECK ADD  CONSTRAINT [FK_detailschedule_headerschedule] FOREIGN KEY([scheduleid])
REFERENCES [dbo].[headerschedule] ([scheduleid])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detailschedule] CHECK CONSTRAINT [FK_detailschedule_headerschedule]
GO
ALTER TABLE [dbo].[headerschedule]  WITH CHECK ADD  CONSTRAINT [FK_headerschedule_mapping] FOREIGN KEY([mappingid])
REFERENCES [dbo].[mapping] ([mappingid])
GO
ALTER TABLE [dbo].[headerschedule] CHECK CONSTRAINT [FK_headerschedule_mapping]
GO
ALTER TABLE [dbo].[mapping]  WITH CHECK ADD  CONSTRAINT [FK_mapping_msfilm] FOREIGN KEY([filmid])
REFERENCES [dbo].[msfilm] ([filmid])
GO
ALTER TABLE [dbo].[mapping] CHECK CONSTRAINT [FK_mapping_msfilm]
GO
ALTER TABLE [dbo].[mapping]  WITH CHECK ADD  CONSTRAINT [FK_mapping_mstudio] FOREIGN KEY([studiono])
REFERENCES [dbo].[mstudio] ([studiono])
GO
ALTER TABLE [dbo].[mapping] CHECK CONSTRAINT [FK_mapping_mstudio]
GO
