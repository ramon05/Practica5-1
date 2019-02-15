CREATE Database EstudianteDB
GO

USE EstudianteDB
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblEstudiante](
     [EstudianteId] [int] IDENTITY(1,1) NOT NULL,
	 [Nombre] [nvarchar](50) NULL,
	 [Apellido] [nvarchar](50) NULL,
	 [Direccion] [nvarchar](50) NULL,
	 [Telefono] [NVARCHAR](15) Null,
	 [Cedula] [NVARCHAR](13) NULL,
	 [ImageUrl] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED
(
     [EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)

ON [PRIMARY]
) ON [PRIMARY]

GO

