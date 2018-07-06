Public Class FrmmProveedores

    Private Sub FrmmProveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BapApro_Click(sender As System.Object, e As System.EventArgs) Handles BapApro.Click
        If Not (TxapNombre.Text = "" Or TxapDireccion.Text = "" Or txtRFC.Text = "" Or MtxapTel.Text = "") Then
            If idbusqueda = 0 Then
                strSQL = "proAltaProveedor"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                strSQL = "proModProveedor"
                comando = New SqlClient.SqlCommand(strSQL, conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@provID", SqlDbType.BigInt).Value = idbusqueda
            End If
            comando.Parameters.Add("@provRFC", SqlDbType.VarChar, 13).Value = Me.txtRFC.Text
            comando.Parameters.Add("@provNombre", SqlDbType.VarChar, 100).Value = Me.TxapNombre.Text
            comando.Parameters.Add("@provDireccion", SqlDbType.VarChar, 20).Value = Me.TxapDireccion.Text
            comando.Parameters.Add("@provTel", SqlDbType.VarChar, 20).Value = Me.MtxapTel.Text

            comando.Parameters.Add("@retorno", SqlDbType.Int).Direction = ParameterDirection.Output
            If conectar() = True Then
                If comando.Parameters("@Retorno").Value = 0 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                    MsgBox("Proveedor Registrado", MsgBoxStyle.Exclamation, "")
                End If
            Else
                MsgBox("Error al realizar la operacion", MsgBoxStyle.Critical, "")
            End If
        End If
    End Sub

    Private Sub BapSalir_Click(sender As System.Object, e As System.EventArgs) Handles BapSalir.Click
        Me.Close()
    End Sub

    Private Sub TxapDireccion_LostFocus(sender As Object, e As System.EventArgs) Handles TxapDireccion.LostFocus
        TxapDireccion.Text = UCase(TxapDireccion.Text)
    End Sub

    Private Sub txtRFC_LostFocus(sender As Object, e As System.EventArgs) Handles txtRFC.LostFocus
        txtRFC.Text = UCase(txtRFC.Text)
    End Sub
End Class