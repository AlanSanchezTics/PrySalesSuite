<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos
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
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.ArtCodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtPrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtCostoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtUnidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtExisteDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.TblArticulosTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtMod = New System.Windows.Forms.Button()
        Me.ButtSalir = New System.Windows.Forms.Button()
        Me.ButtBaja = New System.Windows.Forms.Button()
        Me.ButtAlta = New System.Windows.Forms.Button()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.AllowUserToOrderColumns = True
        Me.DgvArticulos.AllowUserToResizeColumns = False
        Me.DgvArticulos.AllowUserToResizeRows = False
        Me.DgvArticulos.AutoGenerateColumns = False
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArtCodigoDataGridViewTextBoxColumn, Me.ArtNombreDataGridViewTextBoxColumn, Me.ArtPrecioDataGridViewTextBoxColumn, Me.ArtCostoDataGridViewTextBoxColumn, Me.ArtUnidadDataGridViewTextBoxColumn, Me.ProvIDDataGridViewTextBoxColumn, Me.ArtStockDataGridViewTextBoxColumn, Me.CatIDDataGridViewTextBoxColumn, Me.ArtExisteDataGridViewCheckBoxColumn})
        Me.DgvArticulos.DataSource = Me.TblArticulosBindingSource
        Me.DgvArticulos.Location = New System.Drawing.Point(12, 133)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.Size = New System.Drawing.Size(1325, 355)
        Me.DgvArticulos.TabIndex = 0
        '
        'ArtCodigoDataGridViewTextBoxColumn
        '
        Me.ArtCodigoDataGridViewTextBoxColumn.DataPropertyName = "artCodigo"
        Me.ArtCodigoDataGridViewTextBoxColumn.FillWeight = 120.0!
        Me.ArtCodigoDataGridViewTextBoxColumn.HeaderText = "artCodigo"
        Me.ArtCodigoDataGridViewTextBoxColumn.Name = "ArtCodigoDataGridViewTextBoxColumn"
        Me.ArtCodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArtNombreDataGridViewTextBoxColumn
        '
        Me.ArtNombreDataGridViewTextBoxColumn.DataPropertyName = "artNombre"
        Me.ArtNombreDataGridViewTextBoxColumn.HeaderText = "artNombre"
        Me.ArtNombreDataGridViewTextBoxColumn.Name = "ArtNombreDataGridViewTextBoxColumn"
        '
        'ArtPrecioDataGridViewTextBoxColumn
        '
        Me.ArtPrecioDataGridViewTextBoxColumn.DataPropertyName = "artPrecio"
        Me.ArtPrecioDataGridViewTextBoxColumn.HeaderText = "artPrecio"
        Me.ArtPrecioDataGridViewTextBoxColumn.Name = "ArtPrecioDataGridViewTextBoxColumn"
        '
        'ArtCostoDataGridViewTextBoxColumn
        '
        Me.ArtCostoDataGridViewTextBoxColumn.DataPropertyName = "artCosto"
        Me.ArtCostoDataGridViewTextBoxColumn.HeaderText = "artCosto"
        Me.ArtCostoDataGridViewTextBoxColumn.Name = "ArtCostoDataGridViewTextBoxColumn"
        '
        'ArtUnidadDataGridViewTextBoxColumn
        '
        Me.ArtUnidadDataGridViewTextBoxColumn.DataPropertyName = "artUnidad"
        Me.ArtUnidadDataGridViewTextBoxColumn.HeaderText = "artUnidad"
        Me.ArtUnidadDataGridViewTextBoxColumn.Name = "ArtUnidadDataGridViewTextBoxColumn"
        '
        'ProvIDDataGridViewTextBoxColumn
        '
        Me.ProvIDDataGridViewTextBoxColumn.DataPropertyName = "provID"
        Me.ProvIDDataGridViewTextBoxColumn.HeaderText = "provID"
        Me.ProvIDDataGridViewTextBoxColumn.Name = "ProvIDDataGridViewTextBoxColumn"
        '
        'ArtStockDataGridViewTextBoxColumn
        '
        Me.ArtStockDataGridViewTextBoxColumn.DataPropertyName = "artStock"
        Me.ArtStockDataGridViewTextBoxColumn.HeaderText = "artStock"
        Me.ArtStockDataGridViewTextBoxColumn.Name = "ArtStockDataGridViewTextBoxColumn"
        '
        'CatIDDataGridViewTextBoxColumn
        '
        Me.CatIDDataGridViewTextBoxColumn.DataPropertyName = "catID"
        Me.CatIDDataGridViewTextBoxColumn.HeaderText = "catID"
        Me.CatIDDataGridViewTextBoxColumn.Name = "CatIDDataGridViewTextBoxColumn"
        '
        'ArtExisteDataGridViewCheckBoxColumn
        '
        Me.ArtExisteDataGridViewCheckBoxColumn.DataPropertyName = "artExiste"
        Me.ArtExisteDataGridViewCheckBoxColumn.HeaderText = "artExiste"
        Me.ArtExisteDataGridViewCheckBoxColumn.Name = "ArtExisteDataGridViewCheckBoxColumn"
        '
        'TblArticulosBindingSource
        '
        Me.TblArticulosBindingSource.DataMember = "tblArticulos"
        Me.TblArticulosBindingSource.DataSource = Me.BdSaleSuitDataSet
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
        'Label1
        '
        Me.Label1.Image = Global.PrySalesSuite.My.Resources.Resources.images
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label1.Location = New System.Drawing.Point(0, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 132)
        Me.Label1.TabIndex = 5
        '
        'ButtMod
        '
        Me.ButtMod.Image = Global.PrySalesSuite.My.Resources.Resources._mod
        Me.ButtMod.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtMod.Location = New System.Drawing.Point(1121, 494)
        Me.ButtMod.Name = "ButtMod"
        Me.ButtMod.Size = New System.Drawing.Size(86, 105)
        Me.ButtMod.TabIndex = 4
        Me.ButtMod.Text = "Modificar Producto"
        Me.ButtMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtMod.UseVisualStyleBackColor = True
        '
        'ButtSalir
        '
        Me.ButtSalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit__1_
        Me.ButtSalir.Location = New System.Drawing.Point(1236, 494)
        Me.ButtSalir.Name = "ButtSalir"
        Me.ButtSalir.Size = New System.Drawing.Size(86, 105)
        Me.ButtSalir.TabIndex = 3
        Me.ButtSalir.Text = "Salir"
        Me.ButtSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtSalir.UseVisualStyleBackColor = True
        '
        'ButtBaja
        '
        Me.ButtBaja.Image = Global.PrySalesSuite.My.Resources.Resources.elimin
        Me.ButtBaja.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtBaja.Location = New System.Drawing.Point(1001, 494)
        Me.ButtBaja.Name = "ButtBaja"
        Me.ButtBaja.Size = New System.Drawing.Size(86, 105)
        Me.ButtBaja.TabIndex = 2
        Me.ButtBaja.Text = "Eliminar Producto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtBaja.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtBaja.UseVisualStyleBackColor = True
        '
        'ButtAlta
        '
        Me.ButtAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtAlta.Image = Global.PrySalesSuite.My.Resources.Resources.registrar
        Me.ButtAlta.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtAlta.Location = New System.Drawing.Point(886, 494)
        Me.ButtAlta.Name = "ButtAlta"
        Me.ButtAlta.Size = New System.Drawing.Size(86, 105)
        Me.ButtAlta.TabIndex = 1
        Me.ButtAlta.Text = " Nuevo Producto"
        Me.ButtAlta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtAlta.UseVisualStyleBackColor = True
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1334, 604)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtMod)
        Me.Controls.Add(Me.ButtSalir)
        Me.Controls.Add(Me.ButtBaja)
        Me.Controls.Add(Me.ButtAlta)
        Me.Controls.Add(Me.DgvArticulos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents ButtAlta As System.Windows.Forms.Button
    Friend WithEvents ButtBaja As System.Windows.Forms.Button
    Friend WithEvents ButtSalir As System.Windows.Forms.Button
    Friend WithEvents ButtMod As System.Windows.Forms.Button
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblArticulosTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter
    Friend WithEvents ArtCodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtPrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtCostoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtUnidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtExisteDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
