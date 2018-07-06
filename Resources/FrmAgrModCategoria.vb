Public Class FrmAgrModCategoria

    Private Sub FrmAgrModCategoria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Icon = Nothing

    End Sub

    Private Sub btnGuardar_Click(sender As System.Object, e As System.EventArgs) Handles btnGuardar.Click
        If Not (txtNombre.Text = "" Or txtdes.Text = "") Then
            If idbusqueda = 0 Then
                strSQL = "proAltaCat"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                strSQL = "proActCat"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@catID", SqlDbType.BigInt).Value = idbusqueda
            End If
            comando.Parameters.Add("@catNombre", SqlDbType.VarChar, 20).Value = txtNombre.Text
            comando.Parameters.Add("@catDescripcion", SqlDbType.Text).Value = txtdes.Text
            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
            If conectar() = True Then
                If comando.Parameters("@retorno").Value = 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                    MsgBox("Categoria registrada con exito", MsgBoxStyle.Information, "")
                Else
                    MsgBox("Ya existe esa categoria", MsgBoxStyle.Critical, "")
                    txtNombre.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnsalir_Click(sender As System.Object, e As System.EventArgs) Handles btnsalir.Click
        Me.Close()
    End Sub
End Class