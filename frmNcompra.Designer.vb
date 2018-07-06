<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNcompra
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.cbProveedores = New System.Windows.Forms.ComboBox()
        Me.TblProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtgListCompras = New System.Windows.Forms.DataGridView()
        Me.cArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nudcantidad = New System.Windows.Forms.NumericUpDown()
        Me.cbArticulo = New System.Windows.Forms.ComboBox()
        Me.TblArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TblArticulosTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter()
        Me.TblProveedoresTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.TblProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgListCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAñadir)
        Me.Panel1.Controls.Add(Me.cbProveedores)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCosto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtgListCompras)
        Me.Panel1.Controls.Add(Me.nudcantidad)
        Me.Panel1.Controls.Add(Me.cbArticulo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 212)
        Me.Panel1.TabIndex = 0
        '
        'btnAñadir
        '
        Me.btnAñadir.Location = New System.Drawing.Point(62, 170)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(127, 35)
        Me.btnAñadir.TabIndex = 12
        Me.btnAñadir.Text = "Añadir ››"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'cbProveedores
        '
        Me.cbProveedores.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblProveedoresBindingSource, "provNombre", True))
        Me.cbProveedores.DataSource = Me.TblProveedoresBindingSource
        Me.cbProveedores.DisplayMember = "provNombre"
        Me.cbProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProveedores.FormattingEnabled = True
        Me.cbProveedores.Location = New System.Drawing.Point(118, 96)
        Me.cbProveedores.Name = "cbProveedores"
        Me.cbProveedores.Size = New System.Drawing.Size(121, 26)
        Me.cbProveedores.TabIndex = 11
        Me.cbProveedores.ValueMember = "provNombre"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Proveedor:"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(118, 137)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(121, 27)
        Me.txtCosto.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Costo:"
        '
        'dtgListCompras
        '
        Me.dtgListCompras.AllowUserToAddRows = False
        Me.dtgListCompras.AllowUserToDeleteRows = False
        Me.dtgListCompras.AllowUserToOrderColumns = True
        Me.dtgListCompras.AllowUserToResizeColumns = False
        Me.dtgListCompras.AllowUserToResizeRows = False
        Me.dtgListCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgListCompras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtgListCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgListCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cArticulo, Me.cCantidad, Me.cProveedor, Me.cCosto, Me.cTotal})
        Me.dtgListCompras.Location = New System.Drawing.Point(248, 18)
        Me.dtgListCompras.MultiSelect = False
        Me.dtgListCompras.Name = "dtgListCompras"
        Me.dtgListCompras.ReadOnly = True
        Me.dtgListCompras.RowHeadersVisible = False
        Me.dtgListCompras.Size = New System.Drawing.Size(638, 187)
        Me.dtgListCompras.TabIndex = 7
        '
        'cArticulo
        '
        Me.cArticulo.HeaderText = "Articulo"
        Me.cArticulo.Name = "cArticulo"
        Me.cArticulo.ReadOnly = True
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad(lts)"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        '
        'cProveedor
        '
        Me.cProveedor.HeaderText = "Proveedor"
        Me.cProveedor.Name = "cProveedor"
        Me.cProveedor.ReadOnly = True
        '
        'cCosto
        '
        Me.cCosto.HeaderText = "Costo"
        Me.cCosto.Name = "cCosto"
        Me.cCosto.ReadOnly = True
        '
        'cTotal
        '
        Me.cTotal.HeaderText = "Total"
        Me.cTotal.Name = "cTotal"
        Me.cTotal.ReadOnly = True
        '
        'nudcantidad
        '
        Me.nudcantidad.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudcantidad.Location = New System.Drawing.Point(118, 55)
        Me.nudcantidad.Name = "nudcantidad"
        Me.nudcantidad.Size = New System.Drawing.Size(121, 27)
        Me.nudcantidad.TabIndex = 6
        '
        'cbArticulo
        '
        Me.cbArticulo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblArticulosBindingSource, "artNombre", True))
        Me.cbArticulo.DataSource = Me.TblArticulosBindingSource
        Me.cbArticulo.DisplayMember = "artNombre"
        Me.cbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArticulo.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbArticulo.FormattingEnabled = True
        Me.cbArticulo.Location = New System.Drawing.Point(118, 19)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.Size = New System.Drawing.Size(121, 26)
        Me.cbArticulo.TabIndex = 5
        Me.cbArticulo.ValueMember = "artCodigo"
        '
        'TblArticulosBindingSource
        '
        Me.TblArticulosBindingSource.DataMember = "tblArticulos"
        Me.TblArticulosBindingSource.DataSource = Me.BdSaleSuitDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Articulo:"
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit
        Me.btnSalir.Location = New System.Drawing.Point(857, 230)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(64, 70)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.PrySalesSuite.My.Resources.Resources.save
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(787, 230)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 70)
        Me.btnGuardar.TabIndex = 3
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'TblArticulosTableAdapter
        '
        Me.TblArticulosTableAdapter.ClearBeforeFill = True
        '
        'TblProveedoresTableAdapter
        '
        Me.TblProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total: $"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(103, 233)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(40, 19)
        Me.lbltotal.TabIndex = 6
        Me.lbltotal.Text = "0.00"
        '
        'frmNcompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(933, 314)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNcompra"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de nueva compra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TblProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgListCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents nudcantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbArticulo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblArticulosTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblArticulosTableAdapter
    Friend WithEvents cbProveedores As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtgListCompras As System.Windows.Forms.DataGridView
    Friend WithEvents cArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TblProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProveedoresTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbltotal As System.Windows.Forms.Label
End Class
