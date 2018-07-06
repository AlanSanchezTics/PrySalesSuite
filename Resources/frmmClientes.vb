Public Class frmmClientes

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Not (txtnombre.Text = "" Or txtrfc.Text = "" Or txtdireccion.Text = "" Or txtemail.Text = "" Or txttel.Text = "") Then
            If idbusqueda = 0 Then
                strSQL = "proAltaCliente"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                strSQL = "proActCliente"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@cliID", SqlDbType.BigInt).Value = idbusqueda
            End If
            comando.Parameters.Add("@cliNombre", SqlDbType.VarChar, 100).Value = Me.txtnombre.Text
            comando.Parameters.Add("@cliRFC", SqlDbType.VarChar, 13).Value = Me.txtrfc.Text
            comando.Parameters.Add("@cliDireccion", SqlDbType.VarChar, 200).Value = Me.txtdireccion.Text
            comando.Parameters.Add("@cliEmail", SqlDbType.VarChar, 100).Value = Me.txtemail.Text
            comando.Parameters.Add("@cliTel", SqlDbType.VarChar, 20).Value = Me.txttel.Text
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
            If conectar() = True Then
                If comando.Parameters("@Retorno").Value = 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                    MsgBox("Cliente Registrado", MsgBoxStyle.Exclamation, "")
                Else
                    MsgBox("El RFC ya existe en la base de datos", MsgBoxStyle.Critical, "Datos existentes")
                End If
            Else
                MsgBox("Error al realizar la operacion", MsgBoxStyle.Critical, "")
            End If
        End If
    End Sub

    Private Sub txtnombre_LostFocus(sender As Object, e As System.EventArgs) Handles txtnombre.LostFocus
        Me.txtnombre.Text = UCase(Me.txtnombre.Text)
    End Sub

    Private Sub txtrfc_LostFocus(sender As Object, e As System.EventArgs) Handles txtrfc.LostFocus
        Me.txtrfc.Text = UCase(Me.txtrfc.Text)
    End Sub

    Private Sub txtdireccion_LostFocus(sender As Object, e As System.EventArgs) Handles txtdireccion.LostFocus
        Me.txtdireccion.Text = UCase(Me.txtdireccion.Text)
    End Sub
End Class