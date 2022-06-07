Public Class Form1

    'checkbutton functions
    Private Sub cbyes1_CheckedChanged(sender As Object, e As EventArgs) Handles cbyes1.CheckedChanged
        If cbyes1.Checked = True Then
            cbno1.CheckState = False

        End If
    End Sub

    Private Sub cbyes2_CheckedChanged(sender As Object, e As EventArgs) Handles cbyes2.CheckedChanged
        If cbyes2.Checked = True Then
            cbno2.CheckState = False
        End If

    End Sub
    Private Sub cbyes3_CheckedChanged(sender As Object, e As EventArgs) Handles cbyes3.CheckedChanged
        If cbyes3.Checked = True Then
            cbno3.CheckState = False

        End If
    End Sub
    Private Sub cbyes4_CheckedChanged(sender As Object, e As EventArgs) Handles cbyes4.CheckedChanged
        If cbyes4.Checked = True Then
            cbno4.CheckState = False

        End If
    End Sub
    Private Sub cbyes5_CheckedChanged(sender As Object, e As EventArgs) Handles cbyes5.CheckedChanged
        If cbyes5.Checked = True Then
            cbno5.CheckState = False

        End If
    End Sub
    Private Sub cbno1_CheckedChanged(sender As Object, e As EventArgs) Handles cbno1.CheckedChanged
        If cbno1.Checked = True Then
            cbyes1.CheckState = False

        End If
    End Sub
    Private Sub cbno2_CheckedChanged(sender As Object, e As EventArgs) Handles cbno2.CheckedChanged
        If cbno2.Checked = True Then
            cbyes2.CheckState = False

        End If
    End Sub
    Private Sub cbno3_CheckedChanged(sender As Object, e As EventArgs) Handles cbno3.CheckedChanged
        If cbno3.Checked = True Then
            cbyes3.CheckState = False

        End If
    End Sub
    Private Sub cbno4_CheckedChanged(sender As Object, e As EventArgs) Handles cbno4.CheckedChanged
        If cbno4.Checked = True Then
            cbyes4.CheckState = False

        End If
    End Sub
    Private Sub cbno5_CheckedChanged(sender As Object, e As EventArgs) Handles cbno5.CheckedChanged
        If cbno5.Checked = True Then
            cbyes5.CheckState = False

        End If
    End Sub

    'reset button click
    Private Sub resetbutton_Click(sender As Object, e As EventArgs) Handles resetbutton.Click

        lnbox.Clear()
        fnbox.Clear()
        mibox.Clear()
        addressbox.Clear()
        agebox.Clear()
        cnbox.Clear()
        emailbox.Clear()
        cbyes1.CheckState = False
        cbyes2.CheckState = False
        cbyes3.CheckState = False
        cbyes4.CheckState = False
        cbyes5.CheckState = False
        cbno1.CheckState = False
        cbno2.CheckState = False
        cbno3.CheckState = False
        cbno4.CheckState = False
        cbno5.CheckState = False
    End Sub

    Private Sub submitbutton_Click(sender As Object, e As EventArgs) Handles submitbutton.Click
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("E:\vb.net\Contact Tracing Form\records.txt", True)
        file.WriteLine("Contact Tracing Record")
        file.WriteLine(lnbox.Text)
        file.WriteLine(fnbox.Text)
        file.WriteLine(mibox.Text)
        file.WriteLine(addressbox.Text)
        file.WriteLine(agebox.Text)
        file.WriteLine(cnbox.Text)
        file.WriteLine(emailbox.Text)

        file.Close()
    End Sub
End Class
