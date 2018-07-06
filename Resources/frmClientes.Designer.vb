<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.dtgClientes = New System.Windows.Forms.DataGridView()
        Me.CliID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CliExiste = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TblClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtrfc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblClientesTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblClientesTableAdapter()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgClientes
        '
        Me.dtgClientes.AllowUserToAddRows = False
        Me.dtgClientes.AllowUserToDeleteRows = False
        Me.dtgClientes.AllowUserToOrderColumns = True
        Me.dtgClientes.AllowUserToResizeColumns = False
        Me.dtgClientes.AllowUserToResizeRows = False
        Me.dtgClientes.AutoGenerateColumns = False
        Me.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgClientes.BackgroundColor = System.Drawing.Color.White
        Me.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CliID, Me.CliNombre, Me.CliRFC, Me.CliDireccion, Me.CliEmail, Me.CliTel, Me.CliExiste})
        Me.dtgClientes.DataSource = Me.TblClientesBindingSource
        Me.dtgClientes.GridColor = System.Drawing.Color.White
        Me.dtgClientes.Location = New System.Drawing.Point(12, 124)
        Me.dtgClientes.Name = "dtgClientes"
        Me.dtgClientes.ReadOnly = True
        Me.dtgClientes.RowHeadersVisible = False
        Me.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgClientes.Size = New System.Drawing.Size(1325, 355)
        Me.dtgClientes.TabIndex = 0
        '
        'CliID
        '
        Me.CliID.DataPropertyName = "cliID"
        Me.CliID.HeaderText = "cliID"
        Me.CliID.Name = "CliID"
        Me.CliID.ReadOnly = True
        Me.CliID.Visible = False
        '
        'CliNombre
        '
        Me.CliNombre.DataPropertyName = "cliNombre"
        Me.CliNombre.HeaderText = "Nombre"
        Me.CliNombre.Name = "CliNombre"
        Me.CliNombre.ReadOnly = True
        '
        'CliRFC
        '
        Me.CliRFC.DataPropertyName = "cliRFC"
        Me.CliRFC.HeaderText = "RFC"
        Me.CliRFC.Name = "CliRFC"
        Me.CliRFC.ReadOnly = True
        '
        'CliDireccion
        '
        Me.CliDireccion.DataPropertyName = "cliDireccion"
        Me.CliDireccion.HeaderText = "Direccion"
        Me.CliDireccion.Name = "CliDireccion"
        Me.CliDireccion.ReadOnly = True
        '
        'CliEmail
        '
        Me.CliEmail.DataPropertyName = "cliEmail"
        Me.CliEmail.HeaderText = "Email"
        Me.CliEmail.Name = "CliEmail"
        Me.CliEmail.ReadOnly = True
        '
        'CliTel
        '
        Me.CliTel.DataPropertyName = "cliTel"
        Me.CliTel.HeaderText = "Telefono"
        Me.CliTel.Name = "CliTel"
        Me.CliTel.ReadOnly = True
        '
        'CliExiste
        '
        Me.CliExiste.DataPropertyName = "cliExiste"
        Me.CliExiste.HeaderText = "cliExiste"
        Me.CliExiste.Name = "CliExiste"
        Me.CliExiste.ReadOnly = True
        Me.CliExiste.Visible = False
        '
        'TblClientesBindingSource
        '
        Me.TblClientesBindingSource.DataMember = "tblClientes"
        Me.TblClientesBindingSource.DataSource = Me.BdSaleSuitDataSet
        '
        'BdSaleSuitDataSet
        '
        Me.BdSaleSuitDataSet.DataSetName = "bdSaleSuitDataSet"
        Me.BdSaleSuitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit__1_
        Me.btnSalir.Location = New System.Drawing.Point(1231, 497)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 105)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtrfc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(660, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 69)
        Me.Panel1.TabIndex = 6
        '
        'txtrfc
        '
        Me.txtrfc.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrfc.Location = New System.Drawing.Point(117, 15)
        Me.txtrfc.MaxLength = 13
        Me.txtrfc.Name = "txtrfc"
        Me.txtrfc.Size = New System.Drawing.Size(538, 33)
        Me.txtrfc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Image = Global.PrySalesSuite.My.Resources.Resources.delete_user
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(1129, 497)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(86, 105)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "Eliminar Registro"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Image = Global.PrySalesSuite.My.Resources.Resources.Edit_Male_User
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(1027, 497)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 105)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar Datos"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Image = Global.PrySalesSuite.My.Resources.Resources.contact_new
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(924, 497)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(86, 105)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Nuevo cliente"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Image = Global.PrySalesSuite.My.Resources.Resources.images
        Me.Label1.Location = New System.Drawing.Point(-2, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 122)
        Me.Label1.TabIndex = 1
        '
        'TblClientesTableAdapter
        '
        Me.TblClientesTableAdapter.ClearBeforeFill = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 614)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtgClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmClientes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de clientes"
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblClientesTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblClientesTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrfc As System.Windows.Forms.TextBox
    Friend WithEvents CliID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliRFC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliEmail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliTel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CliExiste As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
