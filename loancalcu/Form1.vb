Public Class Form1
    'H stand for handler
    Dim ML1
    Dim YPH
    Dim IRH
    Dim ALH
    Dim ALHH
    Dim TLH
    Dim TALH
    Dim MPL
    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles YP2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox8.Text = TextBox1.Text

        TextBox16.Text = TextBox3.Text
        TextBox10.Text = TextBox2.Text
        TextBox9.Text = TextBox7.Text
        AL2.Text = amountL.Text
        IT2.Text = IR.Text & "%"
        AL2.Text = AL2.Text






        ALH = CDbl(amountL.Text)
        YPH = YP.Text * 12
        YP2.Text = (YP.Text) & ("Year/s or 24months")



        IRH = IR.Text / 100

        ALHH = amountL.Text * IRH * YPH

        TL.Text = (ALHH)


        ' ML1 = TLH / YP.Text
        ' MP.Text = (ML1)

        TLH = ALHH + amountL.Text
        TotalLP.Text = (TLH)

        TALH = TLH / YP.Text
        TAP.Text = (TALH)


        MPL = TotalLP.Text / 24
        MP.Text = (MPL)





    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TAP.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles amountL.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles IR.TextChanged

    End Sub

    Private Sub TL_TextChanged(sender As Object, e As EventArgs) Handles TL.TextChanged

    End Sub

    Private Sub TotalLP_TextChanged(sender As Object, e As EventArgs) Handles TotalLP.TextChanged

    End Sub
End Class
