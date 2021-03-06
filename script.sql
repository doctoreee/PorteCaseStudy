USE [PorteCaseStudy]
GO
/****** Object:  Table [dbo].[Boxes]    Script Date: 24.09.2020 21:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boxes](
	[BOX_ID] [int] NOT NULL,
	[WEIGHT] [int] NOT NULL,
	[PART_COUNT] [int] NOT NULL,
 CONSTRAINT [PK_Boxes] PRIMARY KEY CLUSTERED 
(
	[BOX_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShipmentParts]    Script Date: 24.09.2020 21:01:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShipmentParts](
	[BOX_ID] [int] NOT NULL,
	[PART_NUMBER] [int] NOT NULL,
	[PART_WEIGHT] [int] NOT NULL,
	[PART_COST] [int] NOT NULL,
 CONSTRAINT [PK_ShipmentParts] PRIMARY KEY CLUSTERED 
(
	[BOX_ID] ASC,
	[PART_NUMBER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
