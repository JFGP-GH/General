USE [dbFastFood]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NIT] [varchar](50) NOT NULL,
	[RazonSocial] [varchar](50) NOT NULL,
	[NombreCliente] [varchar](70) NOT NULL,
 CONSTRAINT [PK__Cliente__D5946642820A4CDF] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[NombreCategoria] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[guGrupo]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[guGrupo](
	[IdGrupo] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NombreGrupo] [varchar](50) NOT NULL,
	[fkIdUsuarioCreador] [numeric](18, 0) NULL,
	[FechaCreado] [datetime] NULL,
	[fkIdUsuarioModificador] [numeric](18, 0) NULL,
	[FechaModificado] [datetime] NULL,
 CONSTRAINT [PK_guGrupo] PRIMARY KEY CLUSTERED 
(
	[IdGrupo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[guFormulario]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[guFormulario](
	[IdFormulario] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NombreFormulario] [varchar](200) NOT NULL,
	[Descripcion] [varchar](400) NOT NULL,
	[fkIdUsuarioCreador] [numeric](18, 0) NULL,
	[FechaCreado] [datetime] NULL,
	[fkIdUsuarioModificador] [numeric](18, 0) NULL,
	[FechaModificado] [datetime] NULL,
 CONSTRAINT [PK_guFormulario] PRIMARY KEY CLUSTERED 
(
	[IdFormulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NombreProveedor] [varchar](50) NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
 CONSTRAINT [PK__Proveedo__E8B631AF3C806D57] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[fecha] [varchar](20) NOT NULL,
	[fkIdCliente] [numeric](18, 0) NOT NULL,
	[NIT] [varchar](50) NOT NULL,
	[razonSocial] [varchar](100) NOT NULL,
	[nombreCliente] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Venta__BC1240BD4A682A29] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Compra](
	[IdCompra] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Fecha] [varchar](20) NOT NULL,
	[fkIdProveedor] [numeric](18, 0) NOT NULL,
	[fkIdUsuario] [numeric](18, 0) NULL,
 CONSTRAINT [PK__Compra__0A5CDB5CBDED6971] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[NombreProducto] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
	[Foto] [varbinary](max) NOT NULL,
	[fkIdCategoria] [int] NOT NULL,
	[PrecioCompra] [money] NOT NULL,
	[PrecioVenta] [money] NOT NULL,
	[CantidadStock] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK__Producto__0988921067492168] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[guUsuario]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[guUsuario](
	[IdUsuario] [varchar](50) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[ApellidoPaterno] [varchar](100) NOT NULL,
	[ApellidoMaterno] [varchar](100) NULL,
	[Direccion] [varchar](1000) NULL,
	[Email] [varchar](200) NULL,
	[Estado] [tinyint] NOT NULL,
	[fkIdGrupo] [numeric](18, 0) NULL,
	[Usuario] [varchar](15) NOT NULL,
	[Clave] [varchar](15) NOT NULL,
	[ForzarCambioContrasena] [bit] NOT NULL,
	[fkIdUsuarioCreador] [numeric](18, 0) NULL,
	[FechaCreado] [datetime] NULL,
	[fkIdUsuarioModificador] [numeric](18, 0) NULL,
	[FechaModificado] [datetime] NULL,
 CONSTRAINT [PK_guUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[guGrupoFormulario]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[guGrupoFormulario](
	[IdGrupoFormulario] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[fkIdGrupo] [numeric](18, 0) NOT NULL,
	[fkIdFormulario] [numeric](18, 0) NOT NULL,
	[PermisoNuevo] [bit] NOT NULL,
	[PermisoModificar] [bit] NOT NULL,
	[PermisoEliminar] [bit] NOT NULL,
	[PermisoImprimir] [bit] NOT NULL,
	[PermisoBuscar] [bit] NOT NULL,
	[fkIdUsuarioCreador] [numeric](18, 0) NULL,
	[FechaCreado] [datetime] NULL,
	[fkIdUsuarioModificador] [numeric](18, 0) NULL,
	[FechaModificado] [datetime] NULL,
 CONSTRAINT [PK_guPermiso] PRIMARY KEY CLUSTERED 
(
	[IdGrupoFormulario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[IdVentadetalle] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[fkIdVenta] [numeric](18, 0) NOT NULL,
	[fkIdProducto] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK__VentaDet__D91C1320D52DFF87] PRIMARY KEY CLUSTERED 
(
	[IdVentadetalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompraDetalle]    Script Date: 10/31/2022 18:36:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompraDetalle](
	[IdCompraDetalle] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [float] NOT NULL,
	[fkIdProducto] [numeric](18, 0) NOT NULL,
	[fkIdCompra] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK__CompraDe__A1B840C594A3C463] PRIMARY KEY CLUSTERED 
(
	[IdCompraDetalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_guUsuarios_Forzar_Cambio_Contrasena]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[guUsuario] ADD  CONSTRAINT [DF_guUsuarios_Forzar_Cambio_Contrasena]  DEFAULT ((0)) FOR [ForzarCambioContrasena]
GO
/****** Object:  ForeignKey [FK__Compra__fkIdProv__286302EC]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK__Compra__fkIdProv__286302EC] FOREIGN KEY([fkIdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK__Compra__fkIdProv__286302EC]
GO
/****** Object:  ForeignKey [FK__CompraDet__fkIdC__29572725]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK__CompraDet__fkIdC__29572725] FOREIGN KEY([fkIdCompra])
REFERENCES [dbo].[Compra] ([IdCompra])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK__CompraDet__fkIdC__29572725]
GO
/****** Object:  ForeignKey [FK__CompraDet__fkIdP__2A4B4B5E]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[CompraDetalle]  WITH CHECK ADD  CONSTRAINT [FK__CompraDet__fkIdP__2A4B4B5E] FOREIGN KEY([fkIdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[CompraDetalle] CHECK CONSTRAINT [FK__CompraDet__fkIdP__2A4B4B5E]
GO
/****** Object:  ForeignKey [FK_guPermiso_guFormulario]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[guGrupoFormulario]  WITH CHECK ADD  CONSTRAINT [FK_guPermiso_guFormulario] FOREIGN KEY([fkIdFormulario])
REFERENCES [dbo].[guFormulario] ([IdFormulario])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[guGrupoFormulario] CHECK CONSTRAINT [FK_guPermiso_guFormulario]
GO
/****** Object:  ForeignKey [FK_guPermiso_guGrupo]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[guGrupoFormulario]  WITH CHECK ADD  CONSTRAINT [FK_guPermiso_guGrupo] FOREIGN KEY([fkIdGrupo])
REFERENCES [dbo].[guGrupo] ([IdGrupo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[guGrupoFormulario] CHECK CONSTRAINT [FK_guPermiso_guGrupo]
GO
/****** Object:  ForeignKey [FK_guUsuario_guGrupo]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[guUsuario]  WITH CHECK ADD  CONSTRAINT [FK_guUsuario_guGrupo] FOREIGN KEY([fkIdGrupo])
REFERENCES [dbo].[guGrupo] ([IdGrupo])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[guUsuario] CHECK CONSTRAINT [FK_guUsuario_guGrupo]
GO
/****** Object:  ForeignKey [FK__Producto__fkIdCa__2E1BDC42]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK__Producto__fkIdCa__2E1BDC42] FOREIGN KEY([fkIdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK__Producto__fkIdCa__2E1BDC42]
GO
/****** Object:  ForeignKey [FK_Venta_Cliente]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([fkIdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  ForeignKey [FK__VentaDeta__fkIdP__30F848ED]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK__VentaDeta__fkIdP__30F848ED] FOREIGN KEY([fkIdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK__VentaDeta__fkIdP__30F848ED]
GO
/****** Object:  ForeignKey [FK__VentaDeta__fkIdV__29572725]    Script Date: 10/31/2022 18:36:14 ******/
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK__VentaDeta__fkIdV__29572725] FOREIGN KEY([fkIdVenta])
REFERENCES [dbo].[Venta] ([IdVenta])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK__VentaDeta__fkIdV__29572725]
GO
