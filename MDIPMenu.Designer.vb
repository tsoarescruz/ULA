<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPMenu
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
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SkinEngine = New Sunisoft.IrisSkin.SkinEngine(CType(Me, System.ComponentModel.Component))
        Me.TxtOp = New System.Windows.Forms.TextBox
        Me.LstMenu = New System.Windows.Forms.ListBox
        Me.LblOpcao = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.LblFlags = New System.Windows.Forms.Label
        Me.LblFlag = New System.Windows.Forms.Label
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 392)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(383, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'SkinEngine
        '
        Me.SkinEngine.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText
        Me.SkinEngine.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SkinEngine.SerialNumber = ""
        Me.SkinEngine.SkinFile = Nothing
        '
        'TxtOp
        '
        Me.TxtOp.Location = New System.Drawing.Point(127, 341)
        Me.TxtOp.Name = "TxtOp"
        Me.TxtOp.Size = New System.Drawing.Size(100, 20)
        Me.TxtOp.TabIndex = 10
        Me.TxtOp.Visible = False
        '
        'LstMenu
        '
        Me.LstMenu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LstMenu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstMenu.FormattingEnabled = True
        Me.LstMenu.ItemHeight = 16
        Me.LstMenu.Location = New System.Drawing.Point(72, 32)
        Me.LstMenu.Name = "LstMenu"
        Me.LstMenu.Size = New System.Drawing.Size(216, 180)
        Me.LstMenu.TabIndex = 11
        Me.LstMenu.Visible = False
        '
        'LblOpcao
        '
        Me.LblOpcao.AutoSize = True
        Me.LblOpcao.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LblOpcao.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOpcao.Location = New System.Drawing.Point(132, 310)
        Me.LblOpcao.Name = "LblOpcao"
        Me.LblOpcao.Size = New System.Drawing.Size(92, 16)
        Me.LblOpcao.TabIndex = 12
        Me.LblOpcao.Text = "Informe a Opção :"
        Me.LblOpcao.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 141)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(144, 20)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 178)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 20)
        Me.TextBox2.TabIndex = 19
        '
        'LblFlags
        '
        Me.LblFlags.AutoSize = True
        Me.LblFlags.Location = New System.Drawing.Point(144, 248)
        Me.LblFlags.Name = "LblFlags"
        Me.LblFlags.Size = New System.Drawing.Size(46, 13)
        Me.LblFlags.TabIndex = 21
        Me.LblFlags.Text = "LblFlags"
        '
        'LblFlag
        '
        Me.LblFlag.AutoSize = True
        Me.LblFlag.Location = New System.Drawing.Point(12, 280)
        Me.LblFlag.Name = "LblFlag"
        Me.LblFlag.Size = New System.Drawing.Size(41, 13)
        Me.LblFlag.TabIndex = 22
        Me.LblFlag.Text = "LblFlag"
        '
        'MDIPMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(383, 414)
        Me.Controls.Add(Me.LblFlag)
        Me.Controls.Add(Me.LblFlags)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblOpcao)
        Me.Controls.Add(Me.LstMenu)
        Me.Controls.Add(Me.TxtOp)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "MDIPMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu ULA"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents SkinEngine As Sunisoft.IrisSkin.SkinEngine
    Friend WithEvents TxtOp As System.Windows.Forms.TextBox
    Friend WithEvents LstMenu As System.Windows.Forms.ListBox
    Friend WithEvents LblOpcao As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LblFlags As System.Windows.Forms.Label
    Friend WithEvents LblFlag As System.Windows.Forms.Label

End Class
