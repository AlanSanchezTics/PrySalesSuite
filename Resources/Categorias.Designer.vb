<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categorias
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
        Me.dtgCategorias = New System.Windows.Forms.DataGridView()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNCategoria = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.CatID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CatExiste = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblCategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.TblCategoriasTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblCategoriasTableAdapter()
        CType(Me.dtgCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TblCategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgCategorias
        '
        Me.dtgCategorias.AllowUserToAddRows = False
        Me.dtgCategorias.AllowUserToDeleteRows = False
        Me.dtgCategorias.AllowUserToOrderColumns = True
        Me.dtgCategorias.AllowUserToResizeColumns = False
        Me.dtgCategorias.AllowUserToResizeRows = False
        Me.dtgCategorias.AutoGenerateColumns = False
        Me.dtgCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgCategorias.BackgroundColor = System.Drawing.Color.White
        Me.dtgCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CatID, Me.CatNombre, Me.CatDescripcion, Me.CatExiste})
        Me.dtgCategorias.DataSource = Me.TblCategoriasBindingSource
        Me.dtgCategorias.Location = New System.Drawing.Point(12, 134)
        Me.dtgCategorias.MultiSelect = False
        Me.dtgCategorias.Name = "dtgCategorias"
        Me.dtgCategorias.ReadOnly = True
        Me.dtgCategorias.RowHeadersVisible = False
        Me.dtgCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCategorias.Size = New System.Drawing.Size(1310, 331)
        Me.dtgCategorias.TabIndex = 1
        '
        'btnmodificar
        '
        Me.btnmodificar.Image = Global.PrySalesSuite.My.Resources.Resources.file_edit
        Me.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnmodificar.Location = New System.Drawing.Point(1052, 471)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(86, 105)
        Me.btnmodificar.TabIndex = 5
        Me.btnmodificar.Text = "Modificar Categoria"
        Me.btnmodificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit__1_
        Me.btnSalir.Location = New System.Drawing.Point(1236, 471)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 105)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnNCategoria
        '
        Me.btnNCategoria.Image = Global.PrySalesSuite.My.Resources.Resources.plus_add_green
        Me.btnNCategoria.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNCategoria.Location = New System.Drawing.Point(960, 471)
        Me.btnNCategoria.Name = "btnNCategoria"
        Me.btnNCategoria.Size = New System.Drawing.Size(86, 105)
        Me.btnNCategoria.TabIndex = 3
        Me.btnNCategoria.Text = "Nueva categoria"
        Me.btnNCategoria.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNCategoria.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Image = Global.PrySalesSuite.My.Resources.Resources.images
        Me.Label1.Location = New System.Drawing.Point(1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 132)
        Me.Label1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(812, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 75)
        Me.Panel1.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(123, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(359, 29)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.PrySalesSuite.My.Resources.Resources.elimin
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnEliminar.Location = New System.Drawing.Point(1144, 471)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 105)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar Categoria"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'CatID
        '
        Me.CatID.DataPropertyName = "catID"
        Me.CatID.HeaderText = "catID"
        Me.CatID.Name = "CatID"
        Me.CatID.ReadOnly = True
        Me.CatID.Visible = False
        '
        'CatNombre
        '
        Me.CatNombre.DataPropertyName = "catNombre"
        Me.CatNombre.FillWeight = 101.5228!
        Me.CatNombre.HeaderText = "Categoria"
        Me.CatNombre.Name = "CatNombre"
        Me.CatNombre.ReadOnly = True
        '
        'CatDescripcion
        '
        Me.CatDescripcion.DataPropertyName = "catDescripcion"
        Me.CatDescripcion.FillWeight = 98.47716!
        Me.CatDescripcion.HeaderText = "Descripcion"
        Me.CatDescripcion.Name = "CatDescripcion"
        Me.CatDescripcion.ReadOnly = True
        '
        'CatExiste
        '
        Me.CatExiste.DataPropertyName = "catExiste"
        Me.CatExiste.HeaderText = "catExiste"
        Me.CatExiste.Name = "CatExiste"
        Me.CatExiste.ReadOnly = True
        Me.CatExiste.Visible = False
        '
        'TblCategoriasBindingSource
        '
        Me.TblCategoriasBindingSource.DataMember = "tblCategorias"
        Me.TblCategoriasBindingSource.DataSource = Me.BdSaleSuitDataSet
        '
        'BdSaleSuitDataSet
        '
        Me.BdSaleSuitDataSet.DataSetName = "bdSaleSuitDataSet"
        Me.BdSaleSuitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCategoriasTableAdapter
        '
        Me.TblCategoriasTableAdapter.ClearBeforeFill = True
        '
        'Categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 604)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnNCategoria)
        Me.Controls.Add(Me.dtgCategorias)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Categorias"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Categorias"
        CType(Me.dtgCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblCategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgCategorias As System.Windows.Forms.DataGridView
    Friend WithEvents btnNCategoria As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblCategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCategoriasTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblCategoriasTableAdapter
    Friend WithEvents CatID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CatExiste As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
