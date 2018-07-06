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
        Me.DtgArticulos = New System.Windows.Forms.DataGridView()
        Me.TblArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtMod = New System.Windows.Forms.Button()
        Me.ButtSalir = New System.Windows.Forms.Button()
        Me.ButtBaja = New System.Windows.Forms.Button()
        Me.ButtAlta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TblArticulosTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter()
        Me.ArtCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtExiste = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DtgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtgArticulos
        '
        Me.DtgArticulos.AllowUserToAddRows = False
        Me.DtgArticulos.AllowUserToDeleteRows = False
        Me.DtgArticulos.AllowUserToOrderColumns = True
        Me.DtgArticulos.AllowUserToResizeColumns = False
        Me.DtgArticulos.AllowUserToResizeRows = False
        Me.DtgArticulos.AutoGenerateColumns = False
        Me.DtgArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgArticulos.BackgroundColor = System.Drawing.Color.White
        Me.DtgArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ArtCodigo, Me.ArtNombre, Me.ArtPrecio, Me.ArtUnidad, Me.ArtStock, Me.ProvNombre, Me.CatNombre, Me.ArtExiste})
        Me.DtgArticulos.DataSource = Me.TblArticulosBindingSource
        Me.DtgArticulos.Location = New System.Drawing.Point(12, 133)
        Me.DtgArticulos.MultiSelect = False
        Me.DtgArticulos.Name = "DtgArticulos"
        Me.DtgArticulos.ReadOnly = True
        Me.DtgArticulos.RowHeadersVisible = False
        Me.DtgArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgArticulos.Size = New System.Drawing.Size(1310, 355)
        Me.DtgArticulos.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(868, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 79)
        Me.Panel1.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(112, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(319, 27)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'TblArticulosTableAdapter
        '
        Me.TblArticulosTableAdapter.ClearBeforeFill = True
        '
        'ArtCodigo
        '
        Me.ArtCodigo.DataPropertyName = "artCodigo"
        Me.ArtCodigo.HeaderText = "artCodigo"
        Me.ArtCodigo.Name = "ArtCodigo"
        Me.ArtCodigo.ReadOnly = True
        Me.ArtCodigo.Visible = False
        '
        'ArtNombre
        '
        Me.ArtNombre.DataPropertyName = "artNombre"
        Me.ArtNombre.HeaderText = "Producto"
        Me.ArtNombre.Name = "ArtNombre"
        Me.ArtNombre.ReadOnly = True
        '
        'ArtPrecio
        '
        Me.ArtPrecio.DataPropertyName = "artPrecio"
        Me.ArtPrecio.HeaderText = "Precio al publico"
        Me.ArtPrecio.Name = "ArtPrecio"
        Me.ArtPrecio.ReadOnly = True
        '
        'ArtUnidad
        '
        Me.ArtUnidad.DataPropertyName = "artUnidad"
        Me.ArtUnidad.HeaderText = "Unidad"
        Me.ArtUnidad.Name = "ArtUnidad"
        Me.ArtUnidad.ReadOnly = True
        '
        'ArtStock
        '
        Me.ArtStock.DataPropertyName = "artStock"
        Me.ArtStock.HeaderText = "Existencia"
        Me.ArtStock.Name = "ArtStock"
        Me.ArtStock.ReadOnly = True
        '
        'ProvNombre
        '
        Me.ProvNombre.DataPropertyName = "provNombre"
        Me.ProvNombre.HeaderText = "Proveedor"
        Me.ProvNombre.Name = "ProvNombre"
        Me.ProvNombre.ReadOnly = True
        Me.ProvNombre.Visible = False
        '
        'CatNombre
        '
        Me.CatNombre.DataPropertyName = "catNombre"
        Me.CatNombre.HeaderText = "Categoria"
        Me.CatNombre.Name = "CatNombre"
        Me.CatNombre.ReadOnly = True
        '
        'ArtExiste
        '
        Me.ArtExiste.DataPropertyName = "artExiste"
        Me.ArtExiste.HeaderText = "artExiste"
        Me.ArtExiste.Name = "ArtExiste"
        Me.ArtExiste.ReadOnly = True
        Me.ArtExiste.Visible = False
        '
        'frmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1334, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtMod)
        Me.Controls.Add(Me.ButtSalir)
        Me.Controls.Add(Me.ButtBaja)
        Me.Controls.Add(Me.ButtAlta)
        Me.Controls.Add(Me.DtgArticulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmArticulos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        Me.TransparencyKey = System.Drawing.Color.White
        CType(Me.DtgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtgArticulos As System.Windows.Forms.DataGridView
    Friend WithEvents ButtAlta As System.Windows.Forms.Button
    Friend WithEvents ButtBaja As System.Windows.Forms.Button
    Friend WithEvents ButtSalir As System.Windows.Forms.Button
    Friend WithEvents ButtMod As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblArticulosTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter
    Friend WithEvents ArtCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArtExiste As System.Windows.Forms.DataGridViewCheckBoxColumn

End Class
