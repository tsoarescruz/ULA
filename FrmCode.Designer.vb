<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCode
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
        Me.LstCodigo = New System.Windows.Forms.ListBox
        Me.LblOpcode = New System.Windows.Forms.Label
        Me.TxtOpcode = New System.Windows.Forms.TextBox
        Me.LblInforme = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LstCodigo
        '
        Me.LstCodigo.FormattingEnabled = True
        Me.LstCodigo.Location = New System.Drawing.Point(23, 12)
        Me.LstCodigo.Name = "LstCodigo"
        Me.LstCodigo.Size = New System.Drawing.Size(215, 225)
        Me.LstCodigo.TabIndex = 0
        '
        'LblOpcode
        '
        Me.LblOpcode.AutoSize = True
        Me.LblOpcode.Location = New System.Drawing.Point(74, 247)
        Me.LblOpcode.Name = "LblOpcode"
        Me.LblOpcode.Size = New System.Drawing.Size(90, 13)
        Me.LblOpcode.TabIndex = 1
        Me.LblOpcode.Text = "Escolha o Código"
        '
        'TxtOpcode
        '
        Me.TxtOpcode.Location = New System.Drawing.Point(70, 270)
        Me.TxtOpcode.Name = "TxtOpcode"
        Me.TxtOpcode.Size = New System.Drawing.Size(100, 20)
        Me.TxtOpcode.TabIndex = 2
        '
        'LblInforme
        '
        Me.LblInforme.AutoSize = True
        Me.LblInforme.Location = New System.Drawing.Point(12, 306)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(227, 13)
        Me.LblInforme.TabIndex = 3
        Me.LblInforme.Text = "Informe um valor de até 4 dígitos e press Enter"
        '
        'FrmCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 333)
        Me.Controls.Add(Me.LblInforme)
        Me.Controls.Add(Me.TxtOpcode)
        Me.Controls.Add(Me.LblOpcode)
        Me.Controls.Add(Me.LstCodigo)
        Me.Name = "FrmCode"
        Me.Text = "Informe o Código"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstCodigo As System.Windows.Forms.ListBox
    Friend WithEvents LblOpcode As System.Windows.Forms.Label
    Friend WithEvents TxtOpcode As System.Windows.Forms.TextBox
    Friend WithEvents LblInforme As System.Windows.Forms.Label

End Class
