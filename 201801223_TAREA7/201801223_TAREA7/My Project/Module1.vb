Module Module1
    Public descuento(10) As Integer
    Public ropa(10) As String
    Public pedesedero(10) As String
    Public plastico(10) As String
    Public lociones(10) As String
    Public camion(10) As Integer
    Public motocicleta(10) As Integer

    Public Totalpeso As Integer = 0
    Public enviouno As Integer = 0
    Public enviodos As Integer = 0
    Public contadoruno As Integer = 0
    Public contadordos As Integer = 0


    Sub calcular()

        If (Totalpeso < 5) Then

        End If
        descuento(Totalpeso) = Form1.RadioButton1.Checked Or Form1.RadioButton2.Checked
        ropa(Totalpeso) = Form1.ComboBox1.Text
        pedesedero(Totalpeso) = Form1.ComboBox2.Text

        If Form1.RadioButton1.Checked Then
            descuento(Totalpeso) = "0.015"
        ElseIf Form1.RadioButton2.Checked Then
            descuento(Totalpeso) = "0.015"
        End If

        If Form1.RadioButton1.Checked And Form1.ComboBox2.Text = "1" Then
            camion(Totalpeso) = 50
            enviouno = enviouno + 50
        ElseIf Form1.RadioButton1.Checked And Form1.ComboBox2.Text = "2" Then
            camion(Totalpeso) = 50
            enviouno = enviouno + 50
        ElseIf Form1.RadioButton1.Checked And Form1.ComboBox2.Text = "3" Then
            camion(Totalpeso) = 50
            enviouno = enviouno + 50
        ElseIf Form1.RadioButton2.Checked And Form1.ComboBox2.Text = "1" Then
            motocicleta(Totalpeso) = 15
            enviodos = enviodos + 15
        ElseIf Form1.RadioButton2.Checked And Form1.ComboBox2.Text = "2" Then
            motocicleta(Totalpeso) = 15
            enviodos = enviodos + 15
        ElseIf Form1.RadioButton2.Checked And Form1.ComboBox2.Text = "3" Then
            motocicleta(Totalpeso) = 15
            enviodos = enviodos + 15





        End If
    End Sub
    Public Sub Limpiar_entradas()
        Form1.ComboBox2.Text = ""

        Form1.RadioButton1.Checked = False
        Form1.RadioButton1.Checked = False
        Form1.RadioButton1.Checked = False




        enviouno = 0
        enviodos = 0
    End Sub
    Sub Estadistica1()
        For index = 0 To 8

            If descuento(index) = "5 - 10" And ropa(index) = "3" Then
                contadoruno += 1
            End If
            If ropa(index) = "1" Then
                contadordos += 1
            End If

        Next


        contadoruno = 0
        contadordos = 0

    End Sub
End Module
