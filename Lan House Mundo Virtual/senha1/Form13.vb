Public Class Form13

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        timer_kup.Start()
        Button1.Enabled = False
        btnsair.Enabled = False
        Label3.Text = ""
        ProgressBar1.Value = 0
        Label2.Text = "0 %"
    End Sub
    Private Sub timer_kup_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_kup.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Label3.Text = "Backup Efetuado com Sucesso"
            timer_kup.Stop()
            Label2.Text = "0 %"
            Button1.Enabled = True
            btnsair.Enabled = True
        End If
        Label2.Text = ProgressBar1.Value & " %"
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class