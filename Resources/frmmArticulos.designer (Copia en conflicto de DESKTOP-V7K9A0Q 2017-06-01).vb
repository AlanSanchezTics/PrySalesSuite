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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.CbxUni = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPreu = New System.Windows.Forms.TextBox()
        Me.CbxCat = New System.Windows.Forms.ComboBox()
        Me.CbxPro = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButCom = New System.Windows.Forms.Button()
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
        Me.TxtNom.Location = New System.Drawing.Point(132, 25)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(267, 20)
        Me.TxtNom.TabIndex = 3
        '
        'CbxUni
        '
        Me.CbxUni.FormattingEnabled = True
        Me.CbxUni.Items.AddRange(New Object() {"Litros", "Kilos", "Piezas"})
        Me.CbxUni.Location = New System.Drawing.Point(132, 65)
        Me.CbxUni.Name = "CbxUni"
        Me.CbxUni.Size = New System.Drawing.Size(218, 21)
        Me.CbxUni.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Precio Venta"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Categoria"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Proveedor"
        '
        'TxtPreu
        '
        Me.TxtPreu.Location = New System.Drawing.Point(132, 109)
        Me.TxtPreu.Name = "TxtPreu"
        Me.TxtPreu.Size = New System.Drawing.Size(158, 20)
        Me.TxtPreu.TabIndex = 10
        '
        'CbxCat
        '
        Me.CbxCat.FormattingEnabled = True
        Me.CbxCat.Location = New System.Drawing.Point(132, 145)
        Me.CbxCat.Name = "CbxCat"
        Me.CbxCat.Size = New System.Drawing.Size(218, 21)
        Me.CbxCat.TabIndex = 11
        '
        'CbxPro
        '
        Me.CbxPro.FormattingEnabled = True
        Me.CbxPro.Location = New System.Drawing.Point(132, 193)
        Me.CbxPro.Name = "CbxPro"
        Me.CbxPro.Size = New System.Drawing.Size(218, 21)
        Me.CbxPro.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 18)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Precio Costos"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(132, 243)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(157, 20)
        Me.TxtTotal.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtNom)
        Me.Panel1.Controls.Add(Me.TxtTotal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CbxPro)
        Me.Panel1.Controls.Add(Me.CbxCat)
        Me.Panel1.Controls.Add(Me.CbxUni)
        Me.Panel1.Controls.Add(Me.TxtPreu)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(12, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 284)
        Me.Panel1.TabIndex = 16
        '
        'ButCom
        '
        Me.ButCom.Image = Global.PrySalesSuite.My.Resources.Resources.save
        Me.ButCom.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButCom.Location = New System.Drawing.Point(369, 311)
        Me.ButCom.Name = "ButCom"
        Me.ButCom.Size = New System.Drawing.Size(64, 86)
        Me.ButCom.TabIndex = 0
        Me.ButCom.Text = "Guardar alta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButCom.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButCom.UseVisualStyleBackColor = True
        '
        'frmmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(459, 403)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButCom)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmmArticulos"
        Me.Text = "Alta"
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPreu As System.Windows.Forms.TextBox
    Friend WithEvents CbxCat As System.Windows.Forms.ComboBox
    Friend WithEvents CbxPro As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
