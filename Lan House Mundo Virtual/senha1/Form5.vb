Public Class Form5
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcodigo.Focus()
    End Sub
    Private Sub txtcodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Asc(e.KeyChar) = 8 Then


            Exit Sub


        End If


        If Not Char.IsDigit(e.KeyChar) Then


            e.Handled = True


        End If

        If Asc(e.KeyChar) = 13 Then
            btnconsultar.PerformClick()
        End If
    End Sub
    Private Sub btnconsultar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If txtcodigo.Text = "" Then
            MsgBox("Campo Código em branco", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
            Exit Sub

        End If
        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM usuario WHERE codigo=" & txtcodigo.Text & "",
        conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If tabela.EOF = False Then
            With Form3

                .txtcodigo.Text = tabela.Fields("codigo").Value()

                If Not IsDBNull(tabela.Fields("nome").Value()) Then
                    .txtnome.Text = tabela.Fields("nome").Value()
                End If

                If Not IsDBNull(tabela.Fields("rg").Value()) Then
                    .txtrg.Text = tabela.Fields("rg").Value()
                End If

                If Not IsDBNull(tabela.Fields("cpf").Value()) Then
                    .txtcpf.Text = tabela.Fields("cpf").Value()
                End If

                If Not IsDBNull(tabela.Fields("data").Value()) Then
                    .txtdata.Text = tabela.Fields("data").Value()
                End If

                If Not IsDBNull(tabela.Fields("sexo").Value()) Then
                    .txtsexo.Text = tabela.Fields("sexo").Value()
                End If

                If Not IsDBNull(tabela.Fields("endereco").Value()) Then
                    .txtendereco.Text = tabela.Fields("endereco").Value()
                End If

                If Not IsDBNull(tabela.Fields("numero").Value()) Then
                    .txtnumero.Text = tabela.Fields("numero").Value()
                End If

                If Not IsDBNull(tabela.Fields("bairro").Value()) Then
                    .txtbairro.Text = tabela.Fields("bairro").Value()
                End If

                If Not IsDBNull(tabela.Fields("cidade").Value()) Then
                    .txtcidade.Text = tabela.Fields("cidade").Value()
                End If

                If Not IsDBNull(tabela.Fields("uf").Value()) Then
                    .txtuf.Text = tabela.Fields("uf").Value()
                End If

                If Not IsDBNull(tabela.Fields("Usuario").Value()) Then
                    .txtusuario.Text = tabela.Fields("Usuario").Value()
                End If

                If Not IsDBNull(tabela.Fields("Senha").Value()) Then
                    .txtsenha.Text = tabela.Fields("Senha").Value()
                End If

                If Not IsDBNull(tabela.Fields("cep").Value()) Then
                    .txtcep.Text = tabela.Fields("cep").Value()
                End If
                If Not IsDBNull(tabela.Fields("telefone").Value()) Then
                    .txttelefone.Text = tabela.Fields("telefone").Value()
                End If

                If Not IsDBNull(tabela.Fields("email").Value()) Then
                    .txtemail.Text = tabela.Fields("email").Value()
                End If
            End With
            Me.Hide()
            txtcodigo.Text = ""
        Else
            MsgBox("Registro não encontrado", MsgBoxStyle.Information, "Lan House Mundo Virtual")
            txtcodigo.Text = ""
            txtcodigo.Focus()
        End If
    End Sub

    Private Sub btnlimpar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        txtcodigo.Text = ""
        txtcodigo.Focus()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class