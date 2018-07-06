Public Class VisualReport

    Private Sub VisualReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdSaleSuitDataSet.tblArticulos' table. You can move, or remove it, as needed.
        Me.tblArticulosTableAdapter.Fill(Me.bdSaleSuitDataSet.tblArticulos)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class