'********************************************************************************
'* Universidade Veiga de Almeida                                                *
'* Projeto    : ULA                                                             *
'* Alunos     : Thiago Soares da Cruz e Italo Nunes Leite                       *
'* Matriculas : 20111100428 e 20122100794                                       *
'* Professor  : Miguel                                                          *
'* Curso      : Ciência da Computação                                           *
'********************************************************************************



Imports System.Windows.Forms

Public Class MDIPMenu


    Public Linha As String = ""
    Public op, n As Integer
    Public accA, accB As Integer
    Public A, B As Integer
    Public flags() As Boolean = {False, False, False, False}
    Public operacao As Integer = 0

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MDIPMenu_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        Me.TxtOp.Focus()
    End Sub

    Private Sub MDIPMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        skin()
        Mostrar_itens()

        Me.TxtOp.Focus()
    End Sub

    Public Sub skin()
        Me.SkinEngine.SerialNumber = ("kUb2DF5pvGF3X9dKPFvIdkXQ0sE8LkAVp9fMme9wCnjZ+ArdRVlxKw==")
        Me.SkinEngine.Active = True

        '// Carregar o Arquivo TXT de skin

        Try
            FileOpen(1, "settings.ini", OpenMode.Input)
            While Not EOF(1)
                Linha = LineInput(1)
                If Linha <> "" Then
                    Me.SkinEngine.SkinFile = (Linha)
                End If
            End While
        Catch ex As Exception
            MsgBox("Erro ao Abrir o Arquivo", MsgBoxStyle.OkOnly, "Skins")
        Finally
            FileClose(2)
        End Try

        'SplashScreen.SkinEngine.SkinFile = "SKins\Vista2_color5.ssk"
    End Sub

    Private Sub TxtOp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOp.TextChanged

        If TxtOp.Text = "1" Then

            '//  Gravar o Registrador A
            ' MessageBox.Show("Opção 1 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtOp.Text = ""

            FrmLeitura.LblLeitura.Text = ("Informe o valor do Registrador A: ")
            FrmLeitura.Reg = 1 ' Variável que indica que é o Registrdor A
            FrmLeitura.Modo_leitura = False

            esconder_itens()
            FrmLeitura.MdiParent = Me
            FrmLeitura.StartPosition = FormStartPosition.CenterScreen
            FrmLeitura.WindowState = FormWindowState.Normal

            FrmLeitura.Show()
        ElseIf TxtOp.Text = "2" Then
            '// Gravar o Registrador B
            'MessageBox.Show("Opção 2 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtOp.Text = ""

            FrmLeitura.LblLeitura.Text = ("Informe o valor do Registrador B: ")
            FrmLeitura.Reg = 0 '// Variável que indica que é o Regristrador B
            FrmLeitura.Modo_leitura = False

            esconder_itens()
            FrmLeitura.MdiParent = Me

            FrmLeitura.StartPosition = FormStartPosition.CenterScreen
            FrmLeitura.WindowState = FormWindowState.Normal

            FrmLeitura.Show()
        ElseIf TxtOp.Text = "3" Then
            '//Mostrar Registrador A
            'MessageBox.Show("Opção 3 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtOp.Text = ""

            FrmLeitura.LblLeitura.Text = ("O valor do Registrador A: ")

            Me.accA = dec2bin(zeros(A))
            FrmLeitura.TxtLeitura.Text = Me.accA

            FrmLeitura.Modo_leitura = True

            '  FrmLeitura.Reg = 1 '// Variável que indica que é o Reg A


            esconder_itens()
            FrmLeitura.MdiParent = Me

            FrmLeitura.StartPosition = FormStartPosition.CenterScreen
            FrmLeitura.WindowState = FormWindowState.Normal

            FrmLeitura.LblInforme.Visible = False

            FrmLeitura.Show()

        ElseIf TxtOp.Text = "4" Then
            '//Mostrar Registrador B
            'MessageBox.Show("Opção 4 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtOp.Text = ""
            FrmLeitura.LblLeitura.Text = ("O valor do Registrador B: ")

            Me.accB = dec2bin(zeros(B))
            FrmLeitura.TxtLeitura.Text = Me.accB

            FrmLeitura.Modo_leitura = True
            esconder_itens()
            FrmLeitura.MdiParent = Me

            FrmLeitura.StartPosition = FormStartPosition.CenterScreen
            FrmLeitura.WindowState = FormWindowState.Normal

            FrmLeitura.LblInforme.Visible = False

            FrmLeitura.Show()

        ElseIf TxtOp.Text = "5" Then
            '//Definir Operação
            'MessageBox.Show("Opção 5 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtOp.Text = ""
            esconder_itens()
            FrmCode.MdiParent = Me

            FrmCode.StartPosition = FormStartPosition.CenterScreen
            FrmCode.WindowState = FormWindowState.Normal

            FrmCode.Show()
        ElseIf TxtOp.Text = "6" Then
            '//Executar Operação
            'MessageBox.Show("Opção 6 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtOp.Text = ""
            ExecutarOp()

        ElseIf TxtOp.Text = "7" Then
            '//Mostrar FLAGS
            'MessageBox.Show("Opção 7 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            MessageBox.Show(FlagsToString(flags))
            TxtOp.Text = ""

        ElseIf TxtOp.Text = "8" Then
            '//Sair da Aplicação
            'MessageBox.Show("Opção 8 Selecionada", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)

            TxtOp.Text = ""
            Me.Close()
            Application.Exit()

        ElseIf (TxtOp.Text <> "1") And (TxtOp.Text <> "2") And (TxtOp.Text <> "3") And (TxtOp.Text <> "4") And (TxtOp.Text <> "5") And (TxtOp.Text <> "6") And (TxtOp.Text <> "7") And (TxtOp.Text <> "8") And (TxtOp.Text <> "") Then
            MessageBox.Show("Informe uma Opção Válida", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtOp.Text = ""
        End If

    End Sub

    Public Sub Carrega_lista_Menu()

        '//Carrega a o LIstBox do Menu da Aplicação
        Me.LstMenu.Items.Clear()
        Me.LstMenu.Items.Insert(0, "Menu")
        Me.LstMenu.Items.Insert(1, " ")
        Me.LstMenu.Items.Insert(2, "1 - Definir Registrador A")
        Me.LstMenu.Items.Insert(3, "2 - Definir Registrador B")
        Me.LstMenu.Items.Insert(4, "3 - Ler Registrador A")
        Me.LstMenu.Items.Insert(5, "4 - Ler Registrador B")
        Me.LstMenu.Items.Insert(6, "5 - Definir Operação")
        Me.LstMenu.Items.Insert(7, "6 - Executar")
        Me.LstMenu.Items.Insert(8, "7 - Ler Registradores de FLAGS")
        Me.LstMenu.Items.Insert(9, "8 - Sair")

    End Sub

    Public Sub Carrega_Lista_Flags()

        Me.LblFlags.Text = ""
        Me.LblFlag.Text = ""

        Me.LblFlags.Text = "Lista de Flags"

        LblFlag.Text = ("1--- = Overflow/-1-- = Negativo/--1- = Comparacao/---1 = Divisão por Zero")

    End Sub

    Public Sub esconder_itens()

        '// Esconde todos os objetos do Form para poder Usar o MdiParent

        Me.LstMenu.Visible = False
        Me.LblFlags.Visible = False
        Me.LblFlag.Visible = False
        Me.LblOpcao.Visible = False
        Me.TxtOp.Visible = False

        Me.TextBox1.Visible = False
        Me.TextBox2.Visible = False

    End Sub


    Public Sub Mostrar_itens()
        '// Carrega todos os objetos do Form para poder Usar o MdiParent

        Me.Carrega_lista_Menu()
        Me.Carrega_Lista_Flags()

        Me.TxtOp.Focus()

        Me.LstMenu.Visible = True
        Me.LblFlags.Visible = True
        Me.LblFlag.Visible = True

        Me.LblOpcao.Visible = True
        Me.TxtOp.Visible = True

        Me.TextBox1.Visible = False
        Me.TextBox2.Visible = False

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim i As Long, x As Long, bin As String
        Const maxpower = 4      ' Maximum number of binary digits supported.

        TextBox1.MaxLength = 9   ' Maximum number of decimal digits allowed.
        TextBox2.Enabled = False ' Prevent typing in second text box.
        bin = ""  'Build the desired binary number in this string, bin.

        x = Val(TextBox1.Text) 'Convert decimal string in text1 to long integer

        If x > 2 ^ maxpower Then
            MsgBox("Number must be no larger than " & Str$(2 ^ maxpower))
            TextBox2.Text = ""
            Exit Sub
        End If


        TextBox2.Text = dec2bin(x)  ' The bin string contains the binary number.
    End Sub

    Public Sub ExecutarOp()

        'Me.LstCodigo.Items.Insert
        'Me.LstCodigo.Items.Insert
        'Me.LstCodigo.Items.Insert(15, "1111 = ")


        '("1--- = Overflow/-1-- = Negativo/--1- = Comparacao/---1 = Divisão por Zero")

        Me.accA = Me.A
        Me.accB = Me.B

        flags(0) = False
        flags(1) = False
        flags(2) = False
        flags(3) = False

        Select Case operacao
            Case 0 '(0, "0000 = Incrementar A")
                accA = accA + 1
                flags(0) = False
                If accA > 15 Then
                    accA = 0
                    flags(0) = True
                End If

            Case 1 '(1, "0001 = Decrementar A")
                accA = accA - 1
                flags(0) = False
                flags(1) = False

                If accA < 0 Then
                    accA = 15
                    flags(0) = True
                    flags(1) = True
                End If


            Case 2 '(2, "0010 = Incrementar B")
                accB = accB + 1
                flags(0) = False
                If accB > 15 Then
                    accB = 0
                    flags(0) = True
                End If


            Case 3 '(3, "0011 = Decrementar B")

                accB = accB - 1
                flags(0) = False
                flags(1) = False

                If accB < 0 Then
                    accB = 15
                    flags(0) = True
                    flags(1) = True
                End If

            Case 4 '(4, "0100 = A + B")
                accA += accB
                flags(0) = False
                If accA > 15 Then
                    accA -= 16
                    flags(0) = True
                End If
            Case 5 '(5, "0101 = A - B")
                accA -= accB
                flags(0) = False
                flags(1) = False
                If accA < 0 Then
                    accA += 16
                    flags(0) = True
                    flags(1) = True
                End If

            Case 6 '(6, "0110 = A * B")
                accA *= accB
                flags(0) = False
                If accA > 15 Then
                    accA -= 16
                    flags(0) = True
                End If

            Case 7 '(7, "0111 = A / B")
                ' Testar accB = 0, se tentar fazer divisão por zero irá gerar um erro no programa.

                If accB = 0 Then
                    flags(3) = True
                Else
                    flags(3) = False
                    accA /= accB
                End If

            Case 8 '(8, "1000 = A * A")
                accA *= accA
                flags(0) = False
                If accA > 15 Then
                    accA -= 16
                    flags(0) = True
                End If

            Case 9 '(9, "1001 = B * B")
                accB *= accB
                flags(0) = False
                If accB > 15 Then
                    accB -= 16
                    flags(0) = True

                End If
                accA = 0
                accA = accB


            Case 10 '(10, "1010 = NOT A")
                accA = -accA
                flags(0) = False
                flags(1) = False

                If accA < 0 Then
                    accA = 15
                    flags(0) = True
                    flags(1) = True
                End If

            Case 11 '(11, "1011 = NOT B")
                accB = -accB
                flags(0) = False
                flags(1) = False

                If accB < 0 Then
                    accB = 15
                    flags(0) = True
                    flags(1) = True

                End If

            Case 12 '(12, "1100 = A OR B")

                If accA Or accB Then
                    flags(2) = False
                End If


            Case 13 '(13, "1101 = A AND B ")

                If accA And accB Then
                    flags(0) = False
                    flags(1) = False
                    flags(2) = True

                End If

            Case 14 '(14, "1110 = A > B")

                flags(0) = False
                If (accA) > (accB) Then
                    If accA > 15 Then
                        accA -= 16
                        flags(0) = True
                    End If
                End If

            Case 15 '(15, "1110 = A < B")

                flags(0) = False
                If (accA) < (accB) Then
                    If accB > 15 Then
                        accB -= 16
                        flags(0) = True
                    End If
                    accA = 0
                    accA = accB
                End If


        End Select
    End Sub

End Class


