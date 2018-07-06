Public Class frmGenerador
    Public reporte As String
    Private Sub frmGenerador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblUsuarios' table. You can move, or remove it, as needed.
        Me.TblUsuariosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblUsuarios)
        'TODO: This line of code loads data into the 'BdSaleSuitDataSet.tblProveedores' table. You can move, or remove it, as needed.
        Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)

        Select Case reporte
            Case "Usuarios"
                Dim rpt As New RptUsu
                Me.TblUsuariosTableAdapter.Connection = conexion
                Me.TblUsuariosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblUsuarios)
                rpt.SetDataSource(bdSaleSuitDataSet)
                rvReportes.ReportSource = rpt
            Case "Clientes"
                Dim rpt As New rptClientes
                Me.TblClientesTableAdapter.Connection = conexion
                Me.TblClientesTableAdapter.Fill(Me.BdSaleSuitDataSet.tblClientes)
                rpt.SetDataSource(bdSaleSuitDataSet)
                rvReportes.ReportSource = rpt
            Case "Ventas"
                Me.ProRptVentasTableAdapter.Connection = conexion
                Me.ProRptVentasTableAdapter.Fill(Me.BdSaleSuitDataSet.proRptVentas, fechai, fechaf)
                Dim rpt As New RptVentas
                rpt.SetDataSource(bdSaleSuitDataSet)
                rvReportes.ReportSource = rpt
            Case "Compras"
                TblComprasTableAdapter.Connection = conexion
                TblComprasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCompras, fechai, fechaf)
                Dim rpt As New RptCompras
                rpt.SetDataSource(bdSaleSuitDataSet)
                rvReportes.ReportSource = rpt
            Case "Articulos"
                Dim rpt As New RptArt
                Me.TblArticulosTableAdapter.Connection = conexion
                Me.TblArticulosTableAdapter.Fill(Me.BdSaleSuitDataSet.tblArticulos)

                rpt.SetDataSource(bdSaleSuitDataSet)
                rvReportes.ReportSource = rpt
            Case "Proveedores"
                Dim rpt As New RptProv
                Me.TblProveedoresTableAdapter.Connection = conexion
                Me.TblProveedoresTableAdapter.Fill(Me.BdSaleSuitDataSet.tblProveedores)

                rpt.SetDataSource(bdSaleSuitDataSet)
                rvReportes.ReportSource = rpt
            Case "Categorias"
                Dim rpt As New RptCatego
                Me.TblCategoriasTableAdapter.Connection = conexion
                Me.TblCategoriasTableAdapter.Fill(Me.BdSaleSuitDataSet.tblCategorias)

                rpt.SetDataSource(bdSaleSuitDataSet)
                rvReportes.ReportSource = rpt
        End Select
    End Sub
End Class