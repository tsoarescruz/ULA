Public Class FrmCode

    Public op As Integer


    Private Sub FrmCode_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        MDIPMenu.Mostrar_itens()
        MDIPMenu.TxtOp.Focus()
    End Sub

    Private Sub FrmCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.TxtOpcode.Focus()
    End Sub

    Private Sub FrmCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TxtOpcode.Focus()
        CarregaCodigo()

    End Sub

    Public Sub CarregaCodigo()

        Me.LstCodigo.Items.Insert(0, "0000 = Incrementar A")
        Me.LstCodigo.Items.Insert(1, "0001 = Decrementar A")
        Me.LstCodigo.Items.Insert(2, "0010 = Incrementar B")
        Me.LstCodigo.Items.Insert(3, "0011 = Decrementar B")
        Me.LstCodigo.Items.Insert(4, "0100 = A + B")
        Me.LstCodigo.Items.Insert(5, "0101 = A - B")
        Me.LstCodigo.Items.Insert(6, "0110 = A * B")
        Me.LstCodigo.Items.Insert(7, "0111 = A / B")
        Me.LstCodigo.Items.Insert(8, "1000 = A * A")
        Me.LstCodigo.Items.Insert(9, "1001 = B * B")
        Me.LstCodigo.Items.Insert(10, "1010 = NOT A")
        Me.LstCodigo.Items.Insert(11, "1011 = NOT B")
        Me.LstCodigo.Items.Insert(12, "1100 = A OR B")
        Me.LstCodigo.Items.Insert(13, "1101 = A AND B ")
        Me.LstCodigo.Items.Insert(14, "1110 = A > B")
        Me.LstCodigo.Items.Insert(15, "1111 = A < B")


        Me.TxtOpcode.Focus()


    End Sub

    Private Sub TxtOpcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtOpcode.KeyDown
        If e.KeyCode = Keys.Enter Then

            ' 
            If (Len(TxtOpcode.Text) > 4 Or Not IsNumeric(TxtOpcode.Text)) Then
                MessageBox.Show("Informe um numero com quantidade máxima de dígitos igual a 4", "Quantidade de Dígitos Inválida", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxtOpcode.Clear()

            Else

                MDIPMenu.operacao = Bin2Dec(TxtOpcode.Text)
                Me.Close()
            End If

            ' 
            Me.Close()
            Return

        End If

    End Sub

    Private Sub TxtOpcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOpcode.LostFocus
        
    End Sub

    Private Sub TxtOpcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOpcode.TextChanged

    End Sub
End Class
