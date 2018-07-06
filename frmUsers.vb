Public Class frmUsers

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Not (TxtName.Text = "" Or TxtLogin.Text = "" Or TxtPass.Text = "" Or CmbType.Text = "") Then
            If idbusqueda = 0 Then
                strSQL = "proAltaUsuario"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                strSQL = "proModUsuario"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@usuID", SqlDbType.BigInt).Value = idbusqueda
            End If
            comando.Parameters.Add("@usuNombre", SqlDbType.VarChar, 100).Value = Me.TxtName.Text
            comando.Parameters.Add("@usuLogin", SqlDbType.VarChar, 20).Value = Me.TxtLogin.Text
            comando.Parameters.Add("@usuClave", SqlDbType.VarChar, 20).Value = Me.TxtPass.Text
            If CmbType.Text = "Encargado" Then
                comando.Parameters.Add("@usuTipo", SqlDbType.Char, 1).Value = "A"
            Else
                comando.Parameters.Add("@usuTipo", SqlDbType.Char, 1).Value = "O"
            End If
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
            If conectar() = True Then
                If comando.Parameters("@Retorno").Value = 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                    MsgBox("Usuario Registrado", MsgBoxStyle.Exclamation, "")
                Else
                    MsgBox("Usuario Existente", MsgBoxStyle.Critical, "")
                    TxtLogin.Focus()
                End If
            Else
                MsgBox("Error al realizar la operacion", MsgBoxStyle.Critical, "")
            End If
        End If
    End Sub
End Class