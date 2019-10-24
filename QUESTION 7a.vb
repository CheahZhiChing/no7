Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim WEIGHT As Double
        Dim PAYMENT As Double
        WEIGHT = Val(TextBox1.Text)
        PAYMENT = Val(TextBox2.Text)
        If WEIGHT >= 0 And WEIGHT <= 2 Then
            TextBox2.Text = "2.5"
        ElseIf WEIGHT >= 2.1 And WEIGHT <= 5 Then
            TextBox2.Text = "3.80"

        ElseIf WEIGHT >= 5.1 And WEIGHT <= 10 Then
            TextBox2.Text = "6.00"
        ElseIf WEIGHT >= 10.1 And WEIGHT <= 20 Then
            TextBox2.Text = "10.00"
        ElseIf WEIGHT > 20 Then
            TextBox2.Text = "VOID"
            MsgBox("INVALID!")

        End If



    End Sub
End Class
