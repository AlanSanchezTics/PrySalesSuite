Public Class FrmReportes
    Private Sub btnGenerar_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerar.Click
        If cbReporte.Text = "Ventas" Or cbReporte.Text = "Compras" Then
            fechai = dtpFechaI.Value
            fechaf = dtpFechaF.Value
        End If
        Dim v As New FrmGenerador
        v.reporte = cbReporte.Text
        v.ShowDialog()
        Me.Close()
    End Sub

    Private Sub cbReporte_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbReporte.SelectedIndexChanged
        If cbReporte.Text = "Ventas" Or cbReporte.Text = "Compras" Then
            lbl1.Visible = True
            lbl2.Visible = True
            dtpFechaI.Visible = True
            dtpFechaF.Visible = True
        Else
            lbl1.Visible = False
            lbl2.Visible = False
            dtpFechaI.Visible = False
            dtpFechaF.Visible = False
        End If
    End Sub
End Class
