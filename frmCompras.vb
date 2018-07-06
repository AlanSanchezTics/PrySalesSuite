Public Class frmCompras
    Private Sub frmCompras_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblCompras' table. You can move, or remove it, as needed.
        Call inicio()
        Me.TblComprasTableAdapter.Connection = conexion
        Me.TblComprasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCompras, Format(Date.Now, "yyyy-MM-dd"), Format(Date.Now, "yyyy-MM-dd"))
    End Sub

    Private Sub BtnSalir_Click(sender As System.Object, e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnNCompra_Click(sender As System.Object, e As System.EventArgs) Handles btnNCompra.Click
        Dim ven As New frmNcompra
        If ven.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TblComprasTableAdapter.Connection = conexion
            Me.TblComprasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCompras, Format(Date.Now, "yyyy-MM-dd"), Format(Date.Now, "yyyy-MM-dd"))
        End If
    End Sub
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim ven As New frmSCompras
        If ven.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TblComprasTableAdapter.Connection = conexion
            Me.TblComprasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCompras, fechai, fechaf)
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha.ValueChanged
        Me.TblComprasTableAdapter.Connection = conexion
        Me.TblComprasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCompras, Format(dtpFecha.Value, "yyyy-MM-dd"), Format(dtpFecha.Value, "yyyy-MM-dd"))
    End Sub
End Class