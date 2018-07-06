Module bDatos
    Public conexion As SqlClient.SqlConnection
    Public comando As SqlClient.SqlCommand
    Public strSQL As String
    Public dts As New DataSet
    Public idbusqueda As Long
    Public fechai As String
    Public fechaf As String
    Public usuNombre As String
    Public tipo As String
    Public pago As Double
    Public Sub inicio()
        conexion = New SqlClient.SqlConnection("server=ALANSANCHEZ\SQLEXPRESS; database=bdSaleSuit; uid=SA; pwd=12345;")
    End Sub

    Public Function conectar() As Boolean
        Dim ret As Boolean
        Try
            comando.Connection.Open()
            comando.ExecuteNonQuery()
            ret = True
        Catch ex As Exception
            ret = False
            MsgBox("Se ha producido el SIGUIENTE ERROR: " & ex.Message & " " & ex.StackTrace, MsgBoxStyle.Critical)
        End Try
        comando.Connection.Close()
        Return ret
    End Function

    Function leerArticulos(ByVal tabla As String) As Boolean
        dts.Clear()
        Dim ret As Boolean
        Dim adp As New SqlClient.SqlDataAdapter(strSQL, conexion)
        Try
            adp.Fill(dts, tabla)
            If dts.Tables(tabla).Rows.Count > 0 Then
                ret = True
            Else
                ret = False
            End If
        Catch ex As Exception
            MsgBox("Error al realizar la operacion, servidor no encontrado" & vbCr & ex.Message, MsgBoxStyle.Critical)
        End Try
        conexion.Close()
        Return ret
    End Function
End Module
