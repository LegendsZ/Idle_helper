Imports System.Windows.Forms

Public Class myDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPos1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        frmIdle_Help.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        frmIdle_Help.Show()
        Me.Close()
    End Sub

    Private Sub btnPos2_Click(sender As Object, e As EventArgs) Handles btnPos2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        frmIdle_Help.Show()
        Me.Close()
    End Sub
End Class
