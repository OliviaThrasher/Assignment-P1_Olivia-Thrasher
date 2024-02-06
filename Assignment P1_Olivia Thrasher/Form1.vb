'Olivia Thrasher
'Assignment P1
'GUI Development

Public Class Form1
    'Pressing Button 1 will reveal Un and move to the front
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Text1Un.Visible = True
        Text1Un.BringToFront()
    End Sub

    'Pressing Button 2 will reveal De and move to the front 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Text2De.Visible = True
        Text2De.BringToFront()
    End Sub

    'Pressing Button 3 will reveal Tr and move to the front
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Text3Tr.Visible = True
        Text3Tr.BringToFront()
    End Sub

    'Pressing Button 4 will reveal Qu and move to the front
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Text4Qu.Visible = True
        Text4Qu.BringToFront()
    End Sub

    'Pressing Button 5 will reveal Ci and move to the front
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Text5Ci.Visible = True
        Text5Ci.BringToFront()
    End Sub

    'Pressing Exit button will close the program
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Close()
    End Sub

End Class
