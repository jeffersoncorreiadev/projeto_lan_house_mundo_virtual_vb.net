Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim StrSenha As String
    Dim cont As Integer
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Form2.lbloga.Text = txtusuario.Text
        Form9.lbloga.Text = txtusuario.Text

        If txttipo.Text = "Usuário" Or txttipo.Text = "Administrador" Then
            txttipo.Focus()
        Else
            MsgBox("Digite corretamente seu TIPO DE LOGIN para ter acesso ao sistema!", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
            Exit Sub
        End If

        If txttipo.Text = "Usuário" Then
            If txttipo.Text = "" Then
                MsgBox("Campo TIPO DE LOGIN em branco, por favor digite corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
                txttipo.Focus()
                Exit Sub
            End If
            If txtusuario.Text = "" Then
                MsgBox("Campo USUÁRIO em branco, por favor corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
                txtusuario.Focus()
                Exit Sub
            End If
            If txtsenha.Text = "" Then
                MsgBox("Campo SENHA em branco, por favor digite corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
                txtsenha.Focus()
                Exit Sub
            End If
            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bd.mdb"
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim reader As OleDbDataReader
            Dim oCmd As OleDbCommand = myConnection.CreateCommand()
            oCmd.CommandText = "SELECT * FROM usuario where Usuario = '" & txtusuario.Text & "'"
            reader = oCmd.ExecuteReader
            While reader.Read
                StrSenha = reader("Senha")
            End While
            myConnection.Close()

            ' Verifica se o login e senha conferem 

            If Me.txtsenha.Text = StrSenha Then
                MsgBox("Acesso Liberado", MsgBoxStyle.Information, "Lan House Mundo Virtual")
                Me.Hide()
                Form9.Show()
            Else
                If txtsenha.Text <> StrSenha Then
                    MsgBox("Acesso negado, usuário ou senha inválido", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
                    cont = cont + 1
                End If
            End If
            If cont > 2 Then
                MsgBox("Tentativas esgotadas, por favor entre em contato com o Administrador para recuperar a sua senha", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
                End
            End If
            btnlimpar.PerformClick()
            txtusuario.Focus()
        Else
            If txttipo.Text = "Usuário" Or txttipo.Text = "Administrador" Then
                txttipo.Focus()
            Else
                MsgBox("Digite corretamente seu TIPO DE LOGIN para ter acesso ao sistema!", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
                Exit Sub
            End If
            If txttipo.Text = "" Then
                MsgBox("Campo TIPO DE LOGIN em branco, por favor digite corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
                txttipo.Focus()
                Exit Sub
            End If
            If txtusuario.Text = "" Then
                MsgBox("Campo USUÁRIO em branco, por favor digite corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
                txtusuario.Focus()
                Exit Sub
            End If
            If txtsenha.Text = "" Then
                MsgBox("Campo SENHA em branco, por favor digite corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
                txtsenha.Focus()
                Exit Sub
            End If
            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bd.mdb"
            Dim myConnection As OleDbConnection = New OleDbConnection
            myConnection.ConnectionString = connString
            myConnection.Open()
            Dim reader As OleDbDataReader
            Dim oCmd As OleDbCommand = myConnection.CreateCommand()
            oCmd.CommandText = "SELECT * FROM funcionario where Usuario = '" & txtusuario.Text & "'"
            reader = oCmd.ExecuteReader
            While reader.Read
                StrSenha = reader("Senha")
            End While
            myConnection.Close()

            ' Verifica se o login e senha conferem 

            If Me.txtsenha.Text = StrSenha Then
                MsgBox("Acesso Liberado", MsgBoxStyle.Information, "Lan House Mundo Virtual")
                Me.Hide()
                Form2.Show()
            Else
                If txtsenha.Text <> StrSenha Then
                    MsgBox("Acesso negado, usuário ou senha inválido", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
                    cont = cont + 1
                End If
            End If
            If cont > 2 Then
                MsgBox("Tentativas esgotadas, por favor entre em contato com o Administrador para recuperar a sua senha!", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
                End
            End If
            btnlimpar.PerformClick()
            txttipo.Focus()
        End If

    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        MsgBox("Sessão encerrada", MsgBoxStyle.Information, "Lan House Mundo Virtual")
        Me.Close()
    End Sub
    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        txttipo.Text = ""
        txtusuario.Text = ""
        txtsenha.Text = ""
        txttipo.Focus()
    End Sub
    Private Sub txtusuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtsenha.Enabled = True
            txtsenha.Focus()
        End If
    End Sub
    Private Sub txtsenha_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsenha.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnok.PerformClick()
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
    End Sub
    Private Sub txtusuario_Leave(sender As Object, e As System.EventArgs) Handles txtusuario.Leave
        txtusuario.Text = UCase(txtusuario.Text)
    End Sub
    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txttipo.Focus()
    End Sub
    Private Sub txttipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipo.KeyPress

        e.Handled = True

    End Sub
End Class
