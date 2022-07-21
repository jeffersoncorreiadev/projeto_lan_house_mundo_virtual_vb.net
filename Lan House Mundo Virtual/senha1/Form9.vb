Public Class Form9
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninternet.Click
        If Shell("C:\Program Files\Internet Explorer\iexplore.exe") Then
        Else
            Shell("C:\Program Files (x86)\Internet Explorer\iexplore.exe")
        End If
    End Sub
    Private Sub Form9_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbhora.Text = lbtempo.Text
        tempo_02.Enabled = True
        tempo_02.Interval = 1000
        If lbhora.Text = "" Then
            tempo_02.Enabled = False
            MsgBox("Você não tem tempo para navegação!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            Me.Close()
            Form1.Show()
            With Form1
                .txttipo.Text = ""
                .txtusuario.Text = ""
                .txtsenha.Text = ""
                .txttipo.Focus()
            End With
        End If
    End Sub
    Private Sub RectangleShape1_Click_1(sender As System.Object, e As System.EventArgs)
        If Shell("C:\Program Files\Internet Explorer\iexplore.exe") Then
        Else
            Shell("C:\Program Files (x86)\Internet Explorer\iexplore.exe")
        End If
    End Sub
    Private Sub btnmsn_Click(sender As System.Object, e As System.EventArgs) Handles btnmsn.Click
        Shell("C:\Program Files (x86)\Windows Live\Messenger\msnmsgr.exe")
    End Sub

    Private Sub btnword_Click(sender As System.Object, e As System.EventArgs) Handles btnword.Click
        Shell("C:\Program Files\Microsoft Office\Office14\WINWORD.exe")
    End Sub
    Private Sub btnexcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcel.Click
        Shell("C:\Program Files\Microsoft Office\Office14\EXCEL.exe")
    End Sub
    Private Sub btnpower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpower.Click
        Shell("C:\Program Files\Microsoft Office\Office14\POWERPNT.exe")
    End Sub
    Private Sub btnplayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplayer.Click
        Shell("C:\Program Files\Windows Media Player\wmplayer.exe")
    End Sub
    Private Sub btnnotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnotepad.Click
        Shell("notepad.exe")
    End Sub
    Private Sub btnlogoff_Click_1(sender As System.Object, e As System.EventArgs) Handles btnlogoff.Click
        If MsgBox("Deseja Efetuar Logoff?", MsgBoxStyle.YesNo, "Lan House Mundo Virtual") = vbYes Then
            Form1.Show()
            Me.Close()
            With Form1
                .txttipo.Text = ""
                .txtusuario.Text = ""
                .txtsenha.Text = ""
                .txttipo.Focus()
            End With
        End If
    End Sub
    Private Sub tempo_02_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tempo_02.Tick
        lbhora.Text = DateAdd("S", -1, CDate(lbhora.Text))
        If CDate(lbhora.Text) = "00:00:00" Then
            tempo_02.Enabled = False
            MsgBox("Seu tempo acabou!")
            Me.Close()
            Form1.Show()
            With Form1
                .txttipo.Text = ""
                .txtusuario.Text = ""
                .txtsenha.Text = ""
                .txttipo.Focus()
            End With
        End If
        If lbhora.Text = "00:10:00" Then
            MsgBox("Você tem 10 minutos, salve seus arquivos", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
        End If
        If lbhora.Text = "00:05:00" Then
            MsgBox("Você tem 5 minutos, salve seus arquivos", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
        End If
        If lbhora.Text = "00:01:00" Then
            MsgBox("Você tem 1 minuto, salve seus arquivos", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
        End If
    End Sub
End Class