Public Class Form1
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calcular()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (MsgBox("¿DESEA SALIR DEL SISTEMA?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End

        End If
    End Sub
End Class
