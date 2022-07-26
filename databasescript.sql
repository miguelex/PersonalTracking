USE [PERSONAL]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](50) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employe](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserNo] [int] NULL,
	[Name] [varchar](50) NULL,
	[SurName] [varchar](50) NULL,
	[imgPath] [varchar](max) NULL,
	[Department_id] [int] NULL,
	[Position_id] [int] NULL,
	[Salary] [decimal](18, 0) NULL,
	[Birthday] [date] NULL,
	[Adress] [varchar](max) NULL,
	[Password] [varchar](20) NULL,
	[isAdmin] [bit] NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpPosition]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpPosition](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](50) NULL,
	[Department_id] [int] NULL,
 CONSTRAINT [PK_EmpPosition] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Months]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Months](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MonthName] [varchar](20) NULL,
 CONSTRAINT [PK_Months] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisions]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Employe_id] [int] NULL,
	[PermisionStart] [date] NULL,
	[PermisionEnd] [date] NULL,
	[PermisionState] [int] NULL,
	[PermisionExplanation] [varchar](max) NULL,
	[permisionDay] [int] NULL,
 CONSTRAINT [PK_Permisions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermisionState]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermisionState](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NULL,
 CONSTRAINT [PK_PermisionState] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Employe_id] [int] NULL,
	[Amount] [int] NULL,
	[Year] [int] NULL,
	[Month_id] [int] NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TASK]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TASK](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[TaskTitle] [varchar](50) NOT NULL,
	[TaskContent] [varchar](max) NULL,
	[TaskStartDate] [date] NULL,
	[TaskDeliveryDate] [date] NULL,
	[TaskState] [int] NOT NULL,
 CONSTRAINT [PK_TASK] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TasksStates]    Script Date: 20/09/2022 19:43:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TasksStates](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](50) NULL,
 CONSTRAINT [PK_TasksStates] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
