Public Class frmSCompras

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        fechai = dtpFechaI.Value
        fechaf = dtpFechaF.Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class