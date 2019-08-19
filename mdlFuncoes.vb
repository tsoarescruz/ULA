Module mdlFuncoes

    Function Bin2Dec(ByVal Num As String) As Integer
        ' Funcao que converte de Binário para Decimal

        Dim n, a As Integer
        Dim x As Long

        n = Len(Num) - 1
        a = n
        Do While n > -1
            x = Mid(Num, ((a + 1) - n), 1)
            Bin2Dec = IIf((x = "1"), Bin2Dec + (2 ^ (n)), Bin2Dec)
            n = n - 1
        Loop
    End Function

    Function zeros(ByVal binario As String) As String
        ' Funcao que acrescenta "0" na frente do numero informado.

        Dim esquerda As String
        Dim bits As Integer = 4


        While (binario.Length) < bits

            esquerda = "0"
            binario = esquerda + binario

        End While

        'MessageBox.Show(binario, "O Valor do Acumulador A", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Return binario

    End Function

    Function dec2bin(ByVal x As Integer) As String
        ' Funcao para Converter de Decimal para Binário

        Dim bin As String = ""
        Dim i As Long
        Const maxpower = 4      ' Maximum number of binary digits supported.

        'Here is the heart of the conversion from decimal to binary:

        'Negative numbers have "1" in the 32nd left-most digit:
        ' If x < 0 Then bin = "1" Else bin = "0"
        If x < 0 Then x = -x

        For i = maxpower To 0 Step -1

            If x And (2 ^ i) Then   ' Use the logical "AND" operator.
                bin = bin + "1"
            Else
                bin = bin + "0"
            End If
        Next


        '  MessageBox.Show(bin, "O Valor do Acumulador A", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Return bin
       
    End Function

    Function FlagsToString(ByVal flags() As Boolean) As String
        ' Funcao que informa os flags

        Dim str As String = ""

        For x As Integer = 0 To UBound(flags)
            str &= IIf(flags(x), "1", "0")
        Next

        Return str

    End Function

End Module
