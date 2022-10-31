Public Class Config

#Region "Base datos Server"
    Protected Function getStringConexion() As String
        Return My.MySettings.Default.StringConexion
    End Function
    Protected Sub setStringConexion(ByVal valor As String)
        My.MySettings.Default.StringConexion = valor
        My.MySettings.Default.Save()
    End Sub


    Protected Function getStringConexionBASE() As String
        Return My.MySettings.Default.StringConexionBASE
    End Function
    Protected Sub setStringConexionBASE(ByVal valor As String)
        My.MySettings.Default.StringConexionBASE = valor
        My.MySettings.Default.Save()
    End Sub

    Protected Function getSERVIDOR() As String

        Return My.MySettings.Default.Servidor
    End Function
    Protected Sub setSERVIDOR(ByVal valor As String)
        My.MySettings.Default.Servidor = valor
        My.MySettings.Default.Save()
    End Sub


    Protected Function getBaseDatos() As String
        Return My.MySettings.Default.BaseDatos
    End Function
    Protected Sub setBaseDatos(ByVal valor As String)
        My.MySettings.Default.BaseDatos = valor
        My.MySettings.Default.Save()
    End Sub


    Protected Function getUSUARIO() As String
        Return My.MySettings.Default.UsuarioSQL
    End Function
    Protected Sub setUSUARIO(ByVal valor As String)
        My.MySettings.Default.UsuarioSQL = valor
        My.MySettings.Default.Save()
    End Sub


    Protected Function getCLAVE() As String
        Return My.MySettings.Default.ClaveSQL
    End Function
    Protected Sub setCLAVE(ByVal valor As String)
        My.MySettings.Default.ClaveSQL = valor
        My.MySettings.Default.Save()
    End Sub


    Protected Function getVerInformacion() As Boolean
        Return My.MySettings.Default.VerInformacionUsuarioRegistros
    End Function
    Protected Sub setVerInformacion(ByVal valor As Boolean)
        My.MySettings.Default.VerInformacionUsuarioRegistros = valor
        My.MySettings.Default.Save()
    End Sub
#End Region

  

End Class

