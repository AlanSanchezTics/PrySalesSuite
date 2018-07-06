<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerador
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.rvReportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.TblArticulosTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCategoriasTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblCategoriasTableAdapter()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblClientesTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblClientesTableAdapter()
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblComprasTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblComprasTableAdapter()
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProveedoresTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter()
        Me.BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuariosTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblUsuariosTableAdapter()
        Me.BindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProRptVentasTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.proRptVentasTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvReportes
        '
        Me.rvReportes.ActiveViewIndex = -1
        Me.rvReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rvReportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.rvReportes.DisplayStatusBar = False
        Me.rvReportes.DisplayToolbar = False
        Me.rvReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rvReportes.Location = New System.Drawing.Point(0, 0)
        Me.rvReportes.Name = "rvReportes"
        Me.rvReportes.Size = New System.Drawing.Size(355, 333)
        Me.rvReportes.TabIndex = 0
        Me.rvReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "tblArticulos"
        Me.BindingSource1.DataSource = Me.BdSaleSuitDataSet
        '
        'BdSaleSuitDataSet
        '
        Me.BdSaleSuitDataSet.DataSetName = "bdSaleSuitDataSet"
        Me.BdSaleSuitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblArticulosTableAdapter
        '
        Me.TblArticulosTableAdapter.ClearBeforeFill = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "tblCategorias"
        Me.BindingSource2.DataSource = Me.BdSaleSuitDataSet
        '
        'TblCategoriasTableAdapter
        '
        Me.TblCategoriasTableAdapter.ClearBeforeFill = True
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "tblClientes"
        Me.BindingSource3.DataSource = Me.BdSaleSuitDataSet
        '
        'TblClientesTableAdapter
        '
        Me.TblClientesTableAdapter.ClearBeforeFill = True
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "tblCompras"
        Me.BindingSource4.DataSource = Me.BdSaleSuitDataSet
        '
        'TblComprasTableAdapter
        '
        Me.TblComprasTableAdapter.ClearBeforeFill = True
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "tblProveedores"
        Me.BindingSource5.DataSource = Me.BdSaleSuitDataSet
        '
        'TblProveedoresTableAdapter
        '
        Me.TblProveedoresTableAdapter.ClearBeforeFill = True
        '
        'BindingSource6
        '
        Me.BindingSource6.DataMember = "tblUsuarios"
        Me.BindingSource6.DataSource = Me.BdSaleSuitDataSet
        '
        'TblUsuariosTableAdapter
        '
        Me.TblUsuariosTableAdapter.ClearBeforeFill = True
        '
        'BindingSource7
        '
        Me.BindingSource7.DataMember = "proRptVentas"
        Me.BindingSource7.DataSource = Me.BdSaleSuitDataSet
        '
        'ProRptVentasTableAdapter
        '
        Me.ProRptVentasTableAdapter.ClearBeforeFill = True
        '
        'frmGenerador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 333)
        Me.Controls.Add(Me.rvReportes)
        Me.Name = "frmGenerador"
        Me.Text = "frmGenerador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvReportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblArticulosTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblCategoriasTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblCategoriasTableAdapter
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientesTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblClientesTableAdapter
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents TblComprasTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblComprasTableAdapter
    Friend WithEvents BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents TblProveedoresTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter
    Friend WithEvents BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents TblUsuariosTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblUsuariosTableAdapter
    Friend WithEvents BindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents ProRptVentasTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.proRptVentasTableAdapter
End Class
