Public Class Form2
    Private Sub CadastroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem.Click
        Form3.Show()
    End Sub
    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsair.Click
        If MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo, "Lan House Mundo Virtual") = vbYes Then
            End
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, data.Click
        data.Text = Date.Today
        horas.Text = DateTime.Now.ToLongTimeString
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        horas.Text = DateTime.Now.ToLongTimeString
    End Sub
    Private Sub FiltroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub
    Private Sub CadastroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem1.Click
        Form6.Show()
    End Sub
    Private Sub FiltoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form7.Show()
    End Sub
    Private Sub LocaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub ContasÀPagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContasÀPagarToolStripMenuItem.Click
        Form15.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form18.Show()
    End Sub
    Private Sub CadastroToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem3.Click
        Form18.Show()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form11.Show()
    End Sub
    Private Sub ConsultarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub
    Private Sub btnlogoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogoff.Click
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
    Private Sub FiltroToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
    End Sub
    Private Sub SiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SiteToolStripMenuItem.Click
        Form13.Show()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form15.Show()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form13.Show()
    End Sub
    Private Sub CaixaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form23.Show()
    End Sub
    Private Sub ConsultaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem.Click
        Form3.Show()
        Form4.Show()
    End Sub
    Private Sub ConsultaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem1.Click
        Form6.Show()
        Form7.Show()
    End Sub
    Private Sub ConsultaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem2.Click
        Form18.Show()
        Form11.Show()
    End Sub
    Private Sub ConsultaToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaToolStripMenuItem3.Click
        Form15.Show()
        Form17.Show()
    End Sub
    Private Sub InternetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetToolStripMenuItem.Click
        Form3.Show()
        Form12.Show()
    End Sub
    Private Sub InternetToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternetToolStripMenuItem1.Click
        Form23.Show()
    End Sub
    Private Sub UsuáriosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuáriosToolStripMenuItem1.Click
        Form19.Show()
    End Sub
    Private Sub RelatórioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatórioToolStripMenuItem.Click
        Form20.Show()
    End Sub
    Private Sub RelatórioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatórioToolStripMenuItem1.Click
        Form21.Show()
    End Sub
    Private Sub RelatórioToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RelatórioToolStripMenuItem2.Click
        Form22.Show()
    End Sub
End Class