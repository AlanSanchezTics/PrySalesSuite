<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProvedores
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
        Me.ButAgregar = New System.Windows.Forms.Button()
        Me.ButMod = New System.Windows.Forms.Button()
        Me.ButEliminar = New System.Windows.Forms.Button()
        Me.ButSalir = New System.Windows.Forms.Button()
        Me.DtgProveedores = New System.Windows.Forms.DataGridView()
        Me.ProvID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.provTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provexiste = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TblProveedoresTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter()
        CType(Me.DtgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButAgregar
        '
        Me.ButAgregar.Image = Global.PrySalesSuite.My.Resources.Resources.contact_new
        Me.ButAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButAgregar.Location = New System.Drawing.Point(960, 487)
        Me.ButAgregar.Name = "ButAgregar"
        Me.ButAgregar.Size = New System.Drawing.Size(86, 105)
        Me.ButAgregar.TabIndex = 0
        Me.ButAgregar.Text = "Agregar Provedor"
        Me.ButAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButAgregar.UseVisualStyleBackColor = True
        '
        'ButMod
        '
        Me.ButMod.Image = Global.PrySalesSuite.My.Resources.Resources.Edit_Male_User
        Me.ButMod.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButMod.Location = New System.Drawing.Point(1052, 487)
        Me.ButMod.Name = "ButMod"
        Me.ButMod.Size = New System.Drawing.Size(86, 105)
        Me.ButMod.TabIndex = 1
        Me.ButMod.Text = "Modificar Proveedor "
        Me.ButMod.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButMod.UseVisualStyleBackColor = True
        '
        'ButEliminar
        '
        Me.ButEliminar.Image = Global.PrySalesSuite.My.Resources.Resources.delete_user
        Me.ButEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButEliminar.Location = New System.Drawing.Point(1144, 487)
        Me.ButEliminar.Name = "ButEliminar"
        Me.ButEliminar.Size = New System.Drawing.Size(86, 105)
        Me.ButEliminar.TabIndex = 2
        Me.ButEliminar.Text = "Eliminar Proveedor"
        Me.ButEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButEliminar.UseVisualStyleBackColor = True
        '
        'ButSalir
        '
        Me.ButSalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit__1_
        Me.ButSalir.Location = New System.Drawing.Point(1236, 487)
        Me.ButSalir.Name = "ButSalir"
        Me.ButSalir.Size = New System.Drawing.Size(86, 105)
        Me.ButSalir.TabIndex = 3
        Me.ButSalir.Text = "Salir"
        Me.ButSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButSalir.UseVisualStyleBackColor = True
        '
        'DtgProveedores
        '
        Me.DtgProveedores.AllowUserToAddRows = False
        Me.DtgProveedores.AllowUserToDeleteRows = False
        Me.DtgProveedores.AllowUserToOrderColumns = True
        Me.DtgProveedores.AllowUserToResizeColumns = False
        Me.DtgProveedores.AllowUserToResizeRows = False
        Me.DtgProveedores.AutoGenerateColumns = False
        Me.DtgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DtgProveedores.BackgroundColor = System.Drawing.Color.White
        Me.DtgProveedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProvID, Me.ProvNombre, Me.ProvRFC, Me.ProvDireccion, Me.provTel, Me.Provexiste})
        Me.DtgProveedores.DataSource = Me.TblProveedoresBindingSource
        Me.DtgProveedores.GridColor = System.Drawing.Color.Silver
        Me.DtgProveedores.Location = New System.Drawing.Point(3, 116)
        Me.DtgProveedores.MultiSelect = False
        Me.DtgProveedores.Name = "DtgProveedores"
        Me.DtgProveedores.ReadOnly = True
        Me.DtgProveedores.RowHeadersVisible = False
        Me.DtgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgProveedores.Size = New System.Drawing.Size(1319, 355)
        Me.DtgProveedores.TabIndex = 4
        '
        'ProvID
        '
        Me.ProvID.DataPropertyName = "provID"
        Me.ProvID.HeaderText = "provID"
        Me.ProvID.Name = "ProvID"
        Me.ProvID.ReadOnly = True
        Me.ProvID.Visible = False
        '
        'ProvNombre
        '
        Me.ProvNombre.DataPropertyName = "provNombre"
        Me.ProvNombre.HeaderText = "Nombre"
        Me.ProvNombre.Name = "ProvNombre"
        Me.ProvNombre.ReadOnly = True
        '
        'ProvRFC
        '
        Me.ProvRFC.DataPropertyName = "provRFC"
        Me.ProvRFC.HeaderText = "RFC"
        Me.ProvRFC.Name = "ProvRFC"
        Me.ProvRFC.ReadOnly = True
        '
        'ProvDireccion
        '
        Me.ProvDireccion.DataPropertyName = "provDireccion"
        Me.ProvDireccion.HeaderText = "Direccion"
        Me.ProvDireccion.Name = "ProvDireccion"
        Me.ProvDireccion.ReadOnly = True
        '
        'provTel
        '
        Me.provTel.DataPropertyName = "provTel"
        Me.provTel.HeaderText = "Telefono"
        Me.provTel.Name = "provTel"
        Me.provTel.ReadOnly = True
        '
        'Provexiste
        '
        Me.Provexiste.DataPropertyName = "provexiste"
        Me.Provexiste.HeaderText = "provexiste"
        Me.Provexiste.Name = "Provexiste"
        Me.Provexiste.ReadOnly = True
        Me.Provexiste.Visible = False
        '
        'TblProveedoresBindingSource
        '
        Me.TblProveedoresBindingSource.DataMember = "tblProveedores"
        Me.TblProveedoresBindingSource.DataSource = Me.BdSaleSuitDataSet
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
        Me.Label1.Location = New System.Drawing.Point(0, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 114)
        Me.Label1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(892, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 62)
        Me.Panel1.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(112, 18)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(295, 27)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'TblProveedoresTableAdapter
        '
        Me.TblProveedoresTableAdapter.ClearBeforeFill = True
        '
        'FrmProvedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1334, 604)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtgProveedores)
        Me.Controls.Add(Me.ButSalir)
        Me.Controls.Add(Me.ButEliminar)
        Me.Controls.Add(Me.ButMod)
        Me.Controls.Add(Me.ButAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProvedores"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de provedores"
        CType(Me.DtgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButAgregar As System.Windows.Forms.Button
    Friend WithEvents ButMod As System.Windows.Forms.Button
    Friend WithEvents ButEliminar As System.Windows.Forms.Button
    Friend WithEvents ButSalir As System.Windows.Forms.Button
    Friend WithEvents DtgProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProveedoresTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter
    Friend WithEvents ProvID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvRFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents provTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provexiste As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
