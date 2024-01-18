Public Class Form1
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click

        Dim A As Double
        Dim H As Double
        Dim L As Double
        Dim P As Double
        L = Val(txtLength.Text)
        H = Val(txtHeight.Text)


        A = L * H
        P = 2 * (L + H)
        txtArea.Text = A
    End Sub

    Private Sub btnParameter_Click(sender As Object, e As EventArgs) Handles btnParameter.Click

        Dim A As Double
        Dim H As Double
        Dim L As Double
        Dim P As Double
        L = Val(txtLength.Text)
        H = Val(txtHeight.Text)


        A = L * H
        P = 2 * (L + H)
        txtParameter.Text = P

    End Sub
End Class
