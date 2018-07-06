<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.dgtUsu = New System.Windows.Forms.DataGridView()
        Me.TblUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.cmdChg = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.TblUsuariosTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblUsuariosTableAdapter()
        Me.UsuID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuLogin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuClave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuExiste = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgtUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgtUsu
        '
        Me.dgtUsu.AllowUserToAddRows = False
        Me.dgtUsu.AllowUserToDeleteRows = False
        Me.dgtUsu.AllowUserToOrderColumns = True
        Me.dgtUsu.AllowUserToResizeColumns = False
        Me.dgtUsu.AllowUserToResizeRows = False
        Me.dgtUsu.AutoGenerateColumns = False
        Me.dgtUsu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtUsu.BackgroundColor = System.Drawing.Color.White
        Me.dgtUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtUsu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UsuID, Me.UsuNombre, Me.UsuLogin, Me.UsuClave, Me.UsuTipo, Me.UsuExiste})
        Me.dgtUsu.DataSource = Me.TblUsuariosBindingSource
        Me.dgtUsu.GridColor = System.Drawing.Color.White
        Me.dgtUsu.Location = New System.Drawing.Point(12, 142)
        Me.dgtUsu.MultiSelect = False
        Me.dgtUsu.Name = "dgtUsu"
        Me.dgtUsu.ReadOnly = True
        Me.dgtUsu.RowHeadersVisible = False
        Me.dgtUsu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtUsu.Size = New System.Drawing.Size(1313, 338)
        Me.dgtUsu.TabIndex = 0
        '
        'TblUsuariosBindingSource
        '
        Me.TblUsuariosBindingSource.DataMember = "tblUsuarios"
        Me.TblUsuariosBindingSource.DataSource = Me.BdSaleSuitDataSet
        '
        'BdSaleSuitDataSet
        '
        Me.BdSaleSuitDataSet.DataSetName = "bdSaleSuitDataSet"
        Me.BdSaleSuitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(645, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(677, 72)
        Me.Panel1.TabIndex = 6
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(180, 18)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(480, 40)
        Me.TxtSearch.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(16, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Image = Global.PrySalesSuite.My.Resources.Resources.images
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 130)
        Me.Label1.TabIndex = 5
        '
        'cmdExit
        '
        Me.cmdExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit__1_
        Me.cmdExit.Location = New System.Drawing.Point(1239, 487)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(86, 105)
        Me.cmdExit.TabIndex = 4
        Me.cmdExit.Text = "Salir"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdDel
        '
        Me.cmdDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = Global.PrySalesSuite.My.Resources.Resources.delete_user
        Me.cmdDel.Location = New System.Drawing.Point(1147, 486)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(86, 105)
        Me.cmdDel.TabIndex = 3
        Me.cmdDel.Text = "Eliminar"
        Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDel.UseVisualStyleBackColor = True
        '
        'cmdChg
        '
        Me.cmdChg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChg.Image = Global.PrySalesSuite.My.Resources.Resources.Edit_Male_User
        Me.cmdChg.Location = New System.Drawing.Point(1055, 486)
        Me.cmdChg.Name = "cmdChg"
        Me.cmdChg.Size = New System.Drawing.Size(86, 105)
        Me.cmdChg.TabIndex = 2
        Me.cmdChg.Text = "Modificar"
        Me.cmdChg.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdChg.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Image = Global.PrySalesSuite.My.Resources.Resources.contact_new
        Me.cmdAdd.Location = New System.Drawing.Point(963, 487)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(86, 105)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Agregrar"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'TblUsuariosTableAdapter
        '
        Me.TblUsuariosTableAdapter.ClearBeforeFill = True
        '
        'UsuID
        '
        Me.UsuID.DataPropertyName = "usuID"
        Me.UsuID.HeaderText = "ID"
        Me.UsuID.Name = "UsuID"
        Me.UsuID.ReadOnly = True
        Me.UsuID.Visible = False
        '
        'UsuNombre
        '
        Me.UsuNombre.DataPropertyName = "usuNombre"
        Me.UsuNombre.HeaderText = "Nombre"
        Me.UsuNombre.Name = "UsuNombre"
        Me.UsuNombre.ReadOnly = True
        '
        'UsuLogin
        '
        Me.UsuLogin.DataPropertyName = "usuLogin"
        Me.UsuLogin.HeaderText = "Login"
        Me.UsuLogin.Name = "UsuLogin"
        Me.UsuLogin.ReadOnly = True
        '
        'UsuClave
        '
        Me.UsuClave.DataPropertyName = "usuClave"
        Me.UsuClave.HeaderText = "Clave"
        Me.UsuClave.Name = "UsuClave"
        Me.UsuClave.ReadOnly = True
        Me.UsuClave.Visible = False
        '
        'UsuTipo
        '
        Me.UsuTipo.DataPropertyName = "usuTipo"
        Me.UsuTipo.HeaderText = "Tipo"
        Me.UsuTipo.Name = "UsuTipo"
        Me.UsuTipo.ReadOnly = True
        '
        'UsuExiste
        '
        Me.UsuExiste.DataPropertyName = "usuExiste"
        Me.UsuExiste.HeaderText = "Existe"
        Me.UsuExiste.Name = "UsuExiste"
        Me.UsuExiste.ReadOnly = True
        Me.UsuExiste.Visible = False
        '
        'frmUsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1334, 604)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdDel)
        Me.Controls.Add(Me.cmdChg)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.dgtUsu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsu"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Usuarios"
        CType(Me.dgtUsu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgtUsu As System.Windows.Forms.DataGridView
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdChg As System.Windows.Forms.Button
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblUsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblUsuariosTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblUsuariosTableAdapter
    Friend WithEvents UsuID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuLogin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuClave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuExiste As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
