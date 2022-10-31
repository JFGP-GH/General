USE [dbFastFood]
GO
/****** Object:  StoredProcedure [dbo].[pCajeroUpd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pCajeroUpd](
    @IdCajero int, 
    @Nombres varchar(50), 
    @ApellidoPaterno varchar(50), 
    @ApellidoMaterno varchar(50), 
    @Direccion varchar(50), 
    @Telefono varchar(20))
AS 
BEGIN
    UPDATE Cajero SET Nombres=@Nombres, ApellidoPaterno=@ApellidoPaterno, ApellidoMaterno=@ApellidoMaterno, Direccion=@Direccion, Telefono=@Telefono
        WHERE  IdCajero= @IdCajero
END
GO
/****** Object:  StoredProcedure [dbo].[pCajeroDel]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pCajeroDel](@IdCajero int)
AS 
BEGIN 
    DELETE FROM Cajero   WHERE  IdCajero= @IdCajero
END
GO
/****** Object:  StoredProcedure [dbo].[pCajeroAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------dbFastFood---------------------------

-----------------------Cajero---------------------------
CREATE PROC [dbo].[pCajeroAdd](
    @IdCajero int, 
    @Nombres varchar(50), 
    @ApellidoPaterno varchar(50), 
    @ApellidoMaterno varchar(50), 
    @Direccion varchar(50), 
    @Telefono varchar(20))
AS
BEGIN
    INSERT INTO Cajero VALUES( @Nombres, @ApellidoPaterno, @ApellidoMaterno, @Direccion, @Telefono)
END
GO
/****** Object:  StoredProcedure [dbo].[pClienteUpd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pClienteUpd](
    @IdCliente decimal, 
    @NIT varchar(50), 
    @RazonSocial varchar(50),
    @NombreCliente varchar(70))
AS 
BEGIN
    UPDATE Cliente SET NIT=@NIT, RazonSocial=@RazonSocial, NombreCliente=@NombreCliente
        WHERE IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[pClienteDel]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pClienteDel](
    @IdCliente decimal 
)
AS 
BEGIN 
    DELETE FROM Cliente   WHERE IdCliente = @IdCliente
END
GO
/****** Object:  StoredProcedure [dbo].[pClienteAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pClienteAdd](
    @IdCliente decimal OUTPUT, 
    @NIT varchar(50), 
    @RazonSocial varchar(50),
    @NombreCliente varchar(70))
AS
BEGIN
    INSERT INTO Cliente VALUES( @NIT, @RazonSocial,@NombreCliente)
    SET @IdCliente = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pCategoriaUpd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pCategoriaUpd](
    @IdCategoria int, 
    @NombreCategoria varchar(50))
AS 
BEGIN
    UPDATE Categoria SET NombreCategoria=@NombreCategoria
        WHERE  IdCategoria= @IdCategoria
END
GO
/****** Object:  StoredProcedure [dbo].[pCategoriaDel]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[pCategoriaDel](@IdCategoria int)
AS 
BEGIN 
    DELETE FROM Categoria   WHERE IdCategoria = @IdCategoria
END
GO
/****** Object:  StoredProcedure [dbo].[pCategoriaAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------dbFastFood---------------------------

-----------------------Categoria---------------------------
CREATE PROC [dbo].[pCategoriaAdd](
    @IdCategoria int OUTPUT, 
    @NombreCategoria varchar(50))
AS
BEGIN
    INSERT INTO Categoria VALUES( @NombreCategoria)
	 SET @IdCategoria = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pguGrupoUpd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguGrupoUpd](
    @IdGrupo decimal, 
    @NombreGrupo varchar(50), 
    @fkIdUsuarioModificador decimal, 
    @FechaModificado datetime)
AS 
BEGIN
    UPDATE guGrupo SET NombreGrupo=@NombreGrupo, fkIdUsuarioModificador=@fkIdUsuarioModificador, FechaModificado=@FechaModificado
        WHERE IdGrupo = @IdGrupo
END
GO
/****** Object:  StoredProcedure [dbo].[pguGrupoDel]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguGrupoDel](
    @IdGrupo decimal 
)
AS 
BEGIN 
    DELETE FROM guGrupo   WHERE IdGrupo = @IdGrupo
END
GO
/****** Object:  StoredProcedure [dbo].[pguGrupoAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguGrupoAdd](
    @IdGrupo decimal OUTPUT, 
    @NombreGrupo varchar(50), 
    @fkIdUsuarioCreador decimal, 
    @FechaCreado datetime)
AS
BEGIN
    INSERT INTO guGrupo VALUES( @NombreGrupo, @fkIdUsuarioCreador, @FechaCreado, NULL, NULL)
    SET @IdGrupo = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pguFormularioUpd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguFormularioUpd](
    @IdFormulario decimal, 
    @NombreFormulario varchar(200), 
    @Descripcion varchar(400), 
    @fkIdUsuarioModificador decimal, 
    @FechaModificado datetime)
AS 
BEGIN
    UPDATE guFormulario SET NombreFormulario=@NombreFormulario, Descripcion=@Descripcion, fkIdUsuarioModificador=@fkIdUsuarioModificador, FechaModificado=@FechaModificado
        WHERE IdFormulario = @IdFormulario
END
GO
/****** Object:  StoredProcedure [dbo].[pguFormularioDel]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguFormularioDel](
    @IdFormulario decimal 
)
AS 
BEGIN 
    DELETE FROM guFormulario   WHERE IdFormulario = @IdFormulario
END
GO
/****** Object:  StoredProcedure [dbo].[pguFormularioAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguFormularioAdd](
    @IdFormulario decimal OUTPUT, 
    @NombreFormulario varchar(200), 
    @Descripcion varchar(400), 
    @fkIdUsuarioCreador decimal, 
    @FechaCreado datetime)
AS
BEGIN
    INSERT INTO guFormulario VALUES( @NombreFormulario, @Descripcion, @fkIdUsuarioCreador, @FechaCreado, NULL, NULL)
    SET @IdFormulario = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pProveedorUpd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pProveedorUpd](
    @IdProveedor decimal, 
    @NombreProveedor varchar(50), 
    @Direccion varchar(50), 
    @Telefono varchar(20))
AS 
BEGIN
    UPDATE Proveedor SET NombreProveedor=@NombreProveedor, Direccion=@Direccion, Telefono=@Telefono
        WHERE IdProveedor = @IdProveedor
END
GO
/****** Object:  StoredProcedure [dbo].[pProveedorDel]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pProveedorDel](
    @IdProveedor decimal 
)
AS 
BEGIN 
    DELETE FROM Proveedor   WHERE IdProveedor = @IdProveedor
END
GO
/****** Object:  StoredProcedure [dbo].[pProveedorAdd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pProveedorAdd](
    @IdProveedor decimal OUTPUT, 
    @NombreProveedor varchar(50), 
    @Direccion varchar(50), 
    @Telefono varchar(20))
AS
BEGIN
    INSERT INTO Proveedor VALUES( @NombreProveedor, @Direccion, @Telefono)
    SET @IdProveedor = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[BuscarGrupoFormularioPorNombreFormulario]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Creado por:  David Ribera Blanco
Fecha 10-Octubre-2010
*/
CREATE Procedure [dbo].[BuscarGrupoFormularioPorNombreFormulario]
@IdGrupo NUMERIC,
@NombreFormulario VARCHAR(50)
as
BEGIN
select guGrupoFormulario.IdGrupoFormulario,guFormulario.IdFormulario, guFormulario.NombreFormulario,
	guGrupoFormulario.PermisoNuevo,guGrupoFormulario.PermisoModificar,
	guGrupoFormulario.PermisoEliminar,guGrupoFormulario.PermisoImprimir,guGrupoFormulario.PermisoBuscar
from guFormulario INNER JOIN guGrupoFormulario on guFormulario.IdFormulario=guGrupoFormulario.fkIdFormulario
where guGrupoFormulario.fkIdGrupo  = @IdGrupo
AND guFormulario.NombreFormulario  = @NombreFormulario 
ORDER BY guFormulario.NombreFormulario

END
GO
/****** Object:  StoredProcedure [dbo].[pProductoUpd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pProductoUpd](
    @IdProducto decimal, 
    @NombreProducto varchar(50), 
    @Descripcion varchar(100), 
    @Foto varbinary(MAX), 
    @fkIdCategoria int,
	@PrecioCompra money,
	@PrecioVenta money,
	@CantidadStock decimal)
AS 
BEGIN
    UPDATE Producto SET NombreProducto=@NombreProducto, Descripcion=@Descripcion, Foto=@Foto, fkIdCategoria=@fkIdCategoria, PrecioCompra=@PrecioCompra,PrecioVenta=@PrecioVenta,CantidadStock=@CantidadStock
        WHERE IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[pProductoDel]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pProductoDel](
    @IdProducto decimal 
)
AS 
BEGIN 
    DELETE FROM Producto   WHERE IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[pProductoAdd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pProductoAdd](
    @IdProducto decimal OUTPUT, 
    @NombreProducto varchar(50), 
    @Descripcion varchar(100), 
    @Foto varbinary(MAX), 
    @fkIdCategoria int,
	@PrecioCompra money,
	@PrecioVenta money,
	@CantidadStock decimal
	)

AS
BEGIN
    INSERT INTO Producto VALUES( @NombreProducto, @Descripcion, @Foto, @fkIdCategoria, @PrecioCompra ,@PrecioVenta, @CantidadStock)
    SET @IdProducto = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pguUsuarioUpd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguUsuarioUpd](
    @IdUsuario decimal, 
    @Nombres varchar(100), 
    @ApellidoPaterno varchar(100), 
    @ApellidoMaterno varchar(100), 
    @Direccion varchar(1000), 
    @Email varchar(200), 
    @Estado tinyint, 
    @fkIdGrupo decimal, 
    @Usuario varchar(15), 
    @Clave varchar(15), 
    @ForzarCambioContrasena bit, 
    @fkIdUsuarioModificador decimal, 
    @FechaModificado datetime)
AS 
BEGIN
    UPDATE guUsuario SET Nombres=@Nombres, ApellidoPaterno=@ApellidoPaterno, ApellidoMaterno=@ApellidoMaterno, Direccion=@Direccion, Email=@Email, Estado=@Estado, fkIdGrupo=@fkIdGrupo, Usuario=@Usuario, Clave=@Clave, ForzarCambioContrasena=@ForzarCambioContrasena, fkIdUsuarioModificador=@fkIdUsuarioModificador, FechaModificado=@FechaModificado
        WHERE IdUsuario = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[pguUsuarioDel]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguUsuarioDel](
    @IdUsuario decimal 
)
AS 
BEGIN 
    DELETE FROM guUsuario   WHERE IdUsuario = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[pguUsuarioAdd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguUsuarioAdd](
    @IdUsuario decimal OUTPUT, 
    @Nombres varchar(100), 
    @ApellidoPaterno varchar(100), 
    @ApellidoMaterno varchar(100), 
    @Direccion varchar(1000), 
    @Email varchar(200), 
    @Estado tinyint, 
    @fkIdGrupo decimal, 
    @Usuario varchar(15), 
    @Clave varchar(15), 
    @ForzarCambioContrasena bit, 
    @fkIdUsuarioCreador decimal, 
    @FechaCreado datetime)
AS
BEGIN
    INSERT INTO guUsuario VALUES( @Nombres, @ApellidoPaterno, @ApellidoMaterno, @Direccion, @Email, @Estado, @fkIdGrupo, @Usuario, @Clave, @ForzarCambioContrasena, @fkIdUsuarioCreador, @FechaCreado, NULL, NULL)
    SET @IdUsuario = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[ListarGrupoFormularioPorIdGrupo]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Creado por:  David Ribera Blanco
Fecha 10-Octubre-2010
*/
CREATE Procedure [dbo].[ListarGrupoFormularioPorIdGrupo]
@IdGrupo Numeric
as
BEGIN
select 0 AS IdGrupoFormulario,guFormulario.IdFormulario, guFormulario.NombreFormulario,
	0 AS PermisoNuevo,0 AS PermisoModificar,0 AS PermisoEliminar,
	0 AS PermisoImprimir,0 AS PermisoBuscar
from guFormulario
where guFormulario.IdFormulario NOT IN (select guGrupoFormulario.fkIdFormulario from guGrupoFormulario where guGrupoFormulario.fkIdGrupo = @IdGrupo)
UNION
select guGrupoFormulario.IdGrupoFormulario,guFormulario.IdFormulario, guFormulario.NombreFormulario,
	guGrupoFormulario.PermisoNuevo,guGrupoFormulario.PermisoModificar,
	guGrupoFormulario.PermisoEliminar,guGrupoFormulario.PermisoImprimir,guGrupoFormulario.PermisoBuscar
from guFormulario INNER JOIN guGrupoFormulario on guFormulario.IdFormulario=guGrupoFormulario.fkIdFormulario
where guGrupoFormulario.fkIdGrupo = @IdGrupo
ORDER BY guFormulario.NombreFormulario

END
GO
/****** Object:  StoredProcedure [dbo].[ListarFormulariosPermisosAsignados]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
Trae un listado de los formularios asignados a los grupos y sus permisos
Creado por:  
Fecha 10-Octubre-2010
*/
CREATE Procedure [dbo].[ListarFormulariosPermisosAsignados]
@IdFormulario Numeric
as
BEGIN
	SELECT distinct gg.IdGrupo,gg.NombreGrupo,gf.IdFormulario, gf.NombreFormulario,ggf.PermisoNuevo,
		ggf.PermisoModificar,ggf.PermisoEliminar,ggf.PermisoImprimir,ggf.PermisoBuscar
	  FROM guFormulario gf INNER JOIN guGrupoFormulario ggf ON ggf.fkIdFormulario = gf.IdFormulario
	INNER JOIN guGrupo gg ON gg.IdGrupo=ggf.fkIdGrupo
	WHERE gf.IdFormulario = @IdFormulario
	ORDER BY gg.NombreGrupo

END
GO
/****** Object:  StoredProcedure [dbo].[pCompraUpd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pCompraUpd](
    @IdCompra decimal, 
    @Fecha varchar(20), 
    @fkIdProveedor decimal, 
    @fkIdUsuario decimal)
AS 
BEGIN
    UPDATE Compra SET Fecha=@Fecha, fkIdProveedor=@fkIdProveedor, fkIdUsuario=@fkIdUsuario
        WHERE IdCompra = @IdCompra
END
GO
/****** Object:  StoredProcedure [dbo].[pVentaDel]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pVentaDel](
    @IdVenta decimal 
)
AS 
BEGIN 
    DELETE FROM Venta   WHERE IdVenta = @IdVenta
END
GO
/****** Object:  StoredProcedure [dbo].[pVentaAdd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pVentaAdd](
    @IdVenta decimal OUTPUT, 
    @fecha varchar(20), 
    @fkIdCliente decimal, 
    @NIT varchar(50),  --fkIdUsuario
    @razonSocial varchar(100),
	@nombreCliente varchar(100)
    )
AS
BEGIN
    INSERT INTO Venta VALUES( @fecha, @fkIdCliente, @NIT, @razonSocial, @nombreCliente)
    SET @IdVenta = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pCompraDel]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pCompraDel](
    @IdCompra decimal 
)
AS 
BEGIN 
    DELETE FROM Compra   WHERE IdCompra = @IdCompra
END
GO
/****** Object:  StoredProcedure [dbo].[pCompraAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pCompraAdd](
    @IdCompra decimal OUTPUT, 
    @Fecha varchar(20), 
    @fkIdProveedor decimal, 
    @fkIdUsuario decimal)
AS
BEGIN
    INSERT INTO Compra VALUES( @Fecha, @fkIdProveedor, @fkIdUsuario)
    SET @IdCompra = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pguGrupoFormularioUpd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguGrupoFormularioUpd](
    @IdGrupoFormulario decimal, 
    @fkIdGrupo decimal, 
    @fkIdFormulario decimal, 
    @PermisoNuevo bit, 
    @PermisoModificar bit, 
    @PermisoEliminar bit, 
    @PermisoImprimir bit, 
    @PermisoBuscar bit, 
    @fkIdUsuarioModificador decimal, 
    @FechaModificado datetime)
AS 
BEGIN
    UPDATE guGrupoFormulario SET fkIdGrupo=@fkIdGrupo, fkIdFormulario=@fkIdFormulario, PermisoNuevo=@PermisoNuevo, PermisoModificar=@PermisoModificar, PermisoEliminar=@PermisoEliminar, PermisoImprimir=@PermisoImprimir, PermisoBuscar=@PermisoBuscar, fkIdUsuarioModificador=@fkIdUsuarioModificador, FechaModificado=@FechaModificado
        WHERE IdGrupoFormulario = @IdGrupoFormulario
END
GO
/****** Object:  StoredProcedure [dbo].[pguGrupoFormularioDel]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguGrupoFormularioDel](
    @IdGrupoFormulario decimal 
)
AS 
BEGIN 
    DELETE FROM guGrupoFormulario   WHERE IdGrupoFormulario = @IdGrupoFormulario
END
GO
/****** Object:  StoredProcedure [dbo].[pguGrupoFormularioAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   01/12/2016 17:38:17
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pguGrupoFormularioAdd](
    @IdGrupoFormulario decimal OUTPUT, 
    @fkIdGrupo decimal, 
    @fkIdFormulario decimal, 
    @PermisoNuevo bit, 
    @PermisoModificar bit, 
    @PermisoEliminar bit, 
    @PermisoImprimir bit, 
    @PermisoBuscar bit, 
    @fkIdUsuarioCreador decimal, 
    @FechaCreado datetime)
AS
BEGIN
    INSERT INTO guGrupoFormulario VALUES( @fkIdGrupo, @fkIdFormulario, @PermisoNuevo, @PermisoModificar, @PermisoEliminar, @PermisoImprimir, @PermisoBuscar, @fkIdUsuarioCreador, @FechaCreado, NULL, NULL)
    SET @IdGrupoFormulario = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pVentaUpd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pVentaUpd](
    @IdVenta decimal, 
    @fecha varchar(20), 
    @fkIdCliente decimal, 
    @NIT varchar(50), --fkIdUsuario
    @razonSocial varchar(100),
	@nombreCliente varchar(100)
	)
AS 
BEGIN
    UPDATE Venta SET fecha=@fecha, fkIdCliente=@fkIdCliente, NIT=@NIT,razonSocial=@razonSocial,nombreCliente=@nombreCliente
        WHERE IdVenta = @IdVenta
END
GO
/****** Object:  StoredProcedure [dbo].[pVentaDetalleUpd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pVentaDetalleUpd](
    @IdVentadetalle decimal, 
    @Cantidad int, 
    @Precio float, 
    @fkIdVenta decimal, 
    @fkIdProducto decimal)
AS 
BEGIN
    UPDATE VentaDetalle SET Cantidad=@Cantidad, Precio=@Precio, fkIdVenta=@fkIdVenta, fkIdProducto=@fkIdProducto
        WHERE IdVentadetalle = @IdVentadetalle
END
GO
/****** Object:  StoredProcedure [dbo].[pVentaDetalleDel]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pVentaDetalleDel](
    @IdVentadetalle decimal 
)
AS 
BEGIN 
    DELETE FROM VentaDetalle   WHERE IdVentadetalle = @IdVentadetalle
END
GO
/****** Object:  StoredProcedure [dbo].[pVentaDetalleAdd]    Script Date: 10/31/2022 18:37:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pVentaDetalleAdd](
    @IdVentadetalle decimal OUTPUT, 
    @Cantidad int, 
    @Precio float, 
    @fkIdVenta decimal, 
    @fkIdProducto decimal)
AS
BEGIN
    INSERT INTO VentaDetalle VALUES( @Cantidad, @Precio, @fkIdVenta, @fkIdProducto)
    SET @IdVentadetalle = SCOPE_IDENTITY()
END
GO
/****** Object:  StoredProcedure [dbo].[pCompraDetalleUpd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pCompraDetalleUpd](
    @IdCompraDetalle decimal, 
    @Cantidad int, 
    @Precio float, 
    @fkIdProducto decimal, 
    @fkIdCompra decimal)
AS 
BEGIN
    UPDATE CompraDetalle SET Cantidad=@Cantidad, Precio=@Precio, fkIdProducto=@fkIdProducto, fkIdCompra=@fkIdCompra
        WHERE IdCompraDetalle = @IdCompraDetalle
END
GO
/****** Object:  StoredProcedure [dbo].[pCompraDetalleDel]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pCompraDetalleDel](
    @IdCompraDetalle decimal 
)
AS 
BEGIN 
    DELETE FROM CompraDetalle   WHERE IdCompraDetalle = @IdCompraDetalle
END
GO
/****** Object:  StoredProcedure [dbo].[pCompraDetalleAdd]    Script Date: 10/31/2022 18:37:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		 Ing. David Ribera Blanco
-- Fecha Creado:   15/06/2022 21:17:18
-- Description:	 Generado por MiGenerador proceso ABM
-- =============================================
CREATE PROC [dbo].[pCompraDetalleAdd](
    @IdCompraDetalle decimal OUTPUT, 
    @Cantidad int, 
    @Precio float, 
    @fkIdProducto decimal, 
    @fkIdCompra decimal)
AS
BEGIN
    INSERT INTO CompraDetalle VALUES( @Cantidad, @Precio, @fkIdProducto, @fkIdCompra)
    SET @IdCompraDetalle = SCOPE_IDENTITY()
END
GO
