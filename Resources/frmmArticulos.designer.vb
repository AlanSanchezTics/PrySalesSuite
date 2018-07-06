<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmArticulos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.CbxUni = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPreu = New System.Windows.Forms.TextBox()
        Me.CbxCat = New System.Windows.Forms.ComboBox()
        Me.TblCategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BdSaleSuitDataSet = New PrySalesSuite.bdSaleSuitDataSet()
        Me.TblProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButCom = New System.Windows.Forms.Button()
        Me.BtnSal = New System.Windows.Forms.Button()
        Me.TblCategoriasTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblCategoriasTableAdapter()
        Me.TblProveedoresTableAdapter = New PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter()
        Me.CachedRptVentas1 = New PrySalesSuite.CachedRptVentas()
        CType(Me.TblCategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(117, 23)
        Me.TxtNom.MaxLength = 50
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(267, 20)
        Me.TxtNom.TabIndex = 3
        '
        'CbxUni
        '
        Me.CbxUni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxUni.FormattingEnabled = True
        Me.CbxUni.Items.AddRange(New Object() {"LS", "KG", "PZ"})
        Me.CbxUni.Location = New System.Drawing.Point(117, 75)
        Me.CbxUni.Name = "CbxUni"
        Me.CbxUni.Size = New System.Drawing.Size(218, 21)
        Me.CbxUni.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio de venta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Categoria"
        '
        'TxtPreu
        '
        Me.TxtPreu.Location = New System.Drawing.Point(150, 120)
        Me.TxtPreu.MaxLength = 10
        Me.TxtPreu.Name = "TxtPreu"
        Me.TxtPreu.Size = New System.Drawing.Size(158, 20)
        Me.TxtPreu.TabIndex = 10
        '
        'CbxCat
        '
        Me.CbxCat.DataSource = Me.TblCategoriasBindingSource
        Me.CbxCat.DisplayMember = "catNombre"
        Me.CbxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCat.FormattingEnabled = True
        Me.CbxCat.Location = New System.Drawing.Point(118, 165)
        Me.CbxCat.Name = "CbxCat"
        Me.CbxCat.Size = New System.Drawing.Size(218, 21)
        Me.CbxCat.TabIndex = 11
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
        'TblProveedoresBindingSource
        '
        Me.TblProveedoresBindingSource.DataMember = "tblProveedores"
        Me.TblProveedoresBindingSource.DataSource = Me.BdSaleSuitDataSet
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxtNom)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CbxCat)
        Me.Panel1.Controls.Add(Me.CbxUni)
        Me.Panel1.Controls.Add(Me.TxtPreu)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 256)
        Me.Panel1.TabIndex = 16
        '
        'ButCom
        '
        Me.ButCom.Image = Global.PrySalesSuite.My.Resources.Resources.save
        Me.ButCom.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButCom.Location = New System.Drawing.Point(283, 283)
        Me.ButCom.Name = "ButCom"
        Me.ButCom.Size = New System.Drawing.Size(64, 70)
        Me.ButCom.TabIndex = 0
        Me.ButCom.Text = "Guardar"
        Me.ButCom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButCom.UseVisualStyleBackColor = True
        '
        'BtnSal
        '
        Me.BtnSal.Image = Global.PrySalesSuite.My.Resources.Resources.application_exit
        Me.BtnSal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSal.Location = New System.Drawing.Point(369, 283)
        Me.BtnSal.Name = "BtnSal"
        Me.BtnSal.Size = New System.Drawing.Size(64, 70)
        Me.BtnSal.TabIndex = 17
        Me.BtnSal.Text = "Salir"
        Me.BtnSal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSal.UseVisualStyleBackColor = True
        '
        'TblCategoriasTableAdapter
        '
        Me.TblCategoriasTableAdapter.ClearBeforeFill = True
        '
        'TblProveedoresTableAdapter
        '
        Me.TblProveedoresTableAdapter.ClearBeforeFill = True
        '
        'frmmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(446, 362)
        Me.Controls.Add(Me.BtnSal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButCom)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmArticulos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta"
        CType(Me.TblCategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BdSaleSuitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButCom As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents CbxUni As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtPreu As System.Windows.Forms.TextBox
    Friend WithEvents CbxCat As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnSal As System.Windows.Forms.Button
    Friend WithEvents BdSaleSuitDataSet As PrySalesSuite.bdSaleSuitDataSet
    Friend WithEvents TblCategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCategoriasTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblCategoriasTableAdapter
    Friend WithEvents TblProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblProveedoresTableAdapter As PrySalesSuite.bdSaleSuitDataSetTableAdapters.tblProveedoresTableAdapter
    Friend WithEvents CachedRptVentas1 As PrySalesSuite.CachedRptVentas
End Class
