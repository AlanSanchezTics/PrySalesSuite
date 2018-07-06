Public Class frmLogin

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub btnEntrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEntrar.Click
        strSQL = "proLogin"
        comando = New SqlClient.SqlCommand(strSQL, conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@usuLogin", SqlDbType.VarChar, 30).Value = txtLogin.Text
        comando.Parameters.Add("@usuClave", SqlDbType.VarChar, 20).Value = txtclave.Text
        If cbTipo.Text = "Encargado" Then
            comando.Parameters.Add("@usuTipo", SqlDbType.Char, 1).Value = "A"
            tipo = "A"
        ElseIf cbTipo.Text = "Cajero" Then
            comando.Parameters.Add("@usuTipo", SqlDbType.Char, 1).Value = "O"
            tipo = "O"
        End If
        comando.Parameters.Add("@usuNombre", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output
        comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
        If conectar() = True Then
            If comando.Parameters("@retorno").Value = 1 Then
                usuNombre = comando.Parameters("@usuNombre").Value
                Me.Hide()
                Dim ventana As New frmMenu
                ventana.Show()
            Else
                MsgBox("Datos de usuario incorrectos", MsgBoxStyle.Critical, "")
                txtLogin.Focus()
            End If
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call inicio()
    End Sub
End Class