Public Class FrmLeitura

    Public Reg As Integer '// Variável que define se está lendo o Registrador - 1: Registrador A; 0: Registrador B;
    Public Modo_leitura As Boolean = False

    Private Sub FrmLeitura_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        MDIPMenu.Mostrar_itens()
        MDIPMenu.TxtOp.Focus()

    End Sub

    Private Sub FrmLeitura_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.TxtLeitura.Focus()
    End Sub

    Private Sub FrmLeitura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
       

    End Sub

   
    Private Sub FrmLeitura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtLeitura.Focus()
    End Sub

    Private Sub TxtLeitura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtLeitura.KeyDown

        If e.KeyCode = Keys.Enter Then

            If Modo_leitura Then

                Me.Close()
                Return

            End If

            If Reg = 1 Then

                If (TxtLeitura.Text <> "") Then

                    If (TxtLeitura.Text.Length > 4) Then

                        MessageBox.Show("Informe uma valor menor que 4 para o Registrador A", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TxtLeitura.Text = ""

                    Else

                        MDIPMenu.A = Bin2Dec(zeros(TxtLeitura.Text))
                        'MDIPMenu.accA = Bin2Dec(zeros(TxtLeitura.Text))

                        Me.Close()

                    End If

                Else

                    MessageBox.Show("Informe uma valor válido para o Registrador A ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtLeitura.Text = ""

                End If
            End If


            If Reg = 0 Then

                If (TxtLeitura.Text <> "") Then

                    If (TxtLeitura.Text.Length > 4) Then

                        MessageBox.Show("Informe uma valor menor que 4 para o Registrador B", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TxtLeitura.Text = ""

                    Else

                        MDIPMenu.B = Bin2Dec(zeros(TxtLeitura.Text))
                        'MDIPMenu.accA = Bin2Dec(zeros(TxtLeitura.Text))

                        Me.Close()

                    End If

                Else
                    MessageBox.Show("Informe uma valor válido para o Registrador B ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TxtLeitura.Text = ""

                    ' Reg 0
                End If
            End If


            ' E
        End If

    End Sub

End Class


