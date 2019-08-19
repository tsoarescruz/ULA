<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeitura
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
        Me.LblLeitura = New System.Windows.Forms.Label
        Me.TxtLeitura = New System.Windows.Forms.TextBox
        Me.LblInforme = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LblLeitura
        '
        Me.LblLeitura.AutoSize = True
        Me.LblLeitura.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLeitura.Location = New System.Drawing.Point(21, 22)
        Me.LblLeitura.Name = "LblLeitura"
        Me.LblLeitura.Size = New System.Drawing.Size(54, 16)
        Me.LblLeitura.TabIndex = 0
        Me.LblLeitura.Text = "LblLeitura"
        '
        'TxtLeitura
        '
        Me.TxtLeitura.Location = New System.Drawing.Point(24, 53)
        Me.TxtLeitura.Name = "TxtLeitura"
        Me.TxtLeitura.Size = New System.Drawing.Size(184, 20)
        Me.TxtLeitura.TabIndex = 1
        '
        'LblInforme
        '
        Me.LblInforme.AutoSize = True
        Me.LblInforme.Location = New System.Drawing.Point(6, 93)
        Me.LblInforme.Name = "LblInforme"
        Me.LblInforme.Size = New System.Drawing.Size(227, 13)
        Me.LblInforme.TabIndex = 2
        Me.LblInforme.Text = "Informe um valor de até 4 dígitos e press Enter"
        '
        'FrmLeitura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 121)
        Me.Controls.Add(Me.LblInforme)
        Me.Controls.Add(Me.TxtLeitura)
        Me.Controls.Add(Me.LblLeitura)
        Me.Name = "FrmLeitura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Leitura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblLeitura As System.Windows.Forms.Label
    Friend WithEvents TxtLeitura As System.Windows.Forms.TextBox
    Friend WithEvents LblInforme As System.Windows.Forms.Label
End Class
