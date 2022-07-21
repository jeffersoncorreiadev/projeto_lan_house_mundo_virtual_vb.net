Public Class Form3
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcodigo.Enabled = False
        txtnome.Enabled = False
        txtrg.Enabled = False
        txtcpf.Enabled = False
        txtdata.Enabled = False
        txtsexo.Enabled = False
        txtemail.Enabled = False
        txtendereco.Enabled = False
        txtnumero.Enabled = False
        txtbairro.Enabled = False
        txtcidade.Enabled = False
        txtuf.Enabled = False
        txtusuario.Enabled = False
        txtsenha.Enabled = False
        txtcep.Enabled = False
        txttelefone.Enabled = False
        txtemail.Enabled = False
        txttelefone.Enabled = False

        btnalterar.Enabled = False
        btnexcluir.Enabled = False
        btnfiltro.Enabled = True
        btnsalvar.Enabled = False
        lbdata.Text = Date.Today
        status = True
        abrebanco()
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        If txtcodigo.Text = "" Then
            MsgBox("Campo CÓDIGO em branco, campo obrigatorio", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            Exit Sub
        End If
        If txtnome.Text = "" Then
            MsgBox("Campo NOME em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtnome.Focus()
            Exit Sub
        End If
        If txtrg.Text = "" Then
            MsgBox("Campo RG em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtrg.Focus()
            Exit Sub
        End If
        If txtcpf.Text = "" Then
            MsgBox("Campo CPF em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcpf.Focus()
            Exit Sub
        End If
        If txtsexo.Text = "" Then
            MsgBox("Campo SEXO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtsexo.Focus()
            Exit Sub
        End If
        If txtdata.Text = "" Then
            MsgBox("Campo DATA DE NASCIMENTO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtdata.Focus()
            Exit Sub
        End If
        If txttelefone.Text = "" Then
            MsgBox("Campo TELEFONE em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txttelefone.Focus()
            Exit Sub
        End If
        If txtemail.Text = "" Then
            MsgBox("Campo E-MAIL em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtemail.Focus()
            Exit Sub
        End If
        If txtendereco.Text = "" Then
            MsgBox("Campo ENDEREÇO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtendereco.Focus()
            Exit Sub
        End If
        If txtnumero.Text = "" Then
            MsgBox("Campo Nº em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtnumero.Focus()
            Exit Sub
        End If
        If txtbairro.Text = "" Then
            MsgBox("Campo BAIRRO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtbairro.Focus()
            Exit Sub
        End If
        If txtcep.Text = "" Then
            MsgBox("Campo CEP de Nascimento em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcep.Focus()
            Exit Sub
        End If
        If txtcidade.Text = "" Then
            MsgBox("Campo CIDADE em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcidade.Focus()
            Exit Sub
        End If
        If txtuf.Text = "" Then
            MsgBox("Campo UF em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtuf.Focus()
            Exit Sub
        End If
        If txtusuario.Text = "" Then
            MsgBox("Campo USUÁRIO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtusuario.Focus()
            Exit Sub
        End If
        If txtsenha.Text = "" Then
            MsgBox("Campo SENHA em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtsenha.Focus()
            Exit Sub
        End If
        Dim strsql As String
        If status = True Then
            strsql = "insert into usuario (codigo,nome,rg,cpf,data,sexo,endereco,numero,bairro,cidade,uf,Usuario,Senha,cep,telefone,email,dia)" & "values (" & txtcodigo.Text & ",'" & txtnome.Text & "','" & txtrg.Text & "','" & txtcpf.Text & "','" & txtdata.Text & "','" & txtsexo.Text & "','" & txtendereco.Text & "','" & txtnumero.Text & "','" & txtbairro.Text & "','" & txtcidade.Text & "','" & txtuf.Text & "','" & txtusuario.Text & "','" & txtsenha.Text & "','" & txtcep.Text & "','" & txttelefone.Text & "','" & txtemail.Text & "','" & lbdata.Text & "')"
            conecta.Execute(strsql)
            MsgBox("Dados incluídos com sucesso",
            MsgBoxStyle.Information, "Lan House Mundo Virtual")
        ElseIf status = False Then
            strsql = "update usuario set nome='" & txtnome.Text & "', rg = '" & txtrg.Text & "', cpf = '" & txtcpf.Text & "', data = '" & txtdata.Text & "', sexo = '" & txtsexo.Text & "', endereco = '" & txtendereco.Text & "', numero = '" & txtnumero.Text & "', bairro = '" & txtbairro.Text & "', cidade = '" & txtcidade.Text & "', uf = '" & txtuf.Text & "', Usuario = '" & txtusuario.Text & "', Senha = '" & txtsenha.Text & "', cep = '" & txtcep.Text & "', telefone = '" & txttelefone.Text & "', email = '" & txtemail.Text & "', dia = '" & lbdata.Text & "'  where codigo = " & txtcodigo.Text & ""
            conecta.Execute(strsql)
            MsgBox("Dados atualizados com sucesso", MsgBoxStyle.Information,
            "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click
        Dim resposta As String
        resposta = MsgBox("Confirma exclusão deste Usuário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lan House Mundo Virtual")
        If resposta = vbNo Then
            Exit Sub
        Else
            tabela = New ADODB.Recordset
            tabela.Open("DELETE from usuario where codigo = " & txtcodigo.Text & "",
            conecta)
            MsgBox("Usuário Excluido", MsgBoxStyle.Information, "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        tabela = New ADODB.Recordset
        tabela.Open("select max(codigo)+1 as NOVO from usuario", conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        txtcodigo.Text = tabela.Fields("NOVO").Value()
        txtcodigo.Enabled = True
        txtnome.Enabled = True
        txtrg.Enabled = True
        txtcpf.Enabled = True
        txtdata.Enabled = True
        txtsexo.Enabled = True
        txtemail.Enabled = True
        txtendereco.Enabled = True
        txtnumero.Enabled = True
        txtbairro.Enabled = True
        txtcidade.Enabled = True
        txtuf.Enabled = True
        txtusuario.Enabled = True
        txtsenha.Enabled = True
        txtcep.Enabled = True
        txttelefone.Enabled = True
        txtemail.Enabled = True
        txttelefone.Enabled = True

        btnsalvar.Enabled = True
    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalterar.Click
        status = False
        txtcodigo.Focus()
        btnsalvar.Enabled = True
        btnsalvar.Visible = True
        btnalterar.Enabled = True
        txtcodigo.Enabled = True
        txtnome.Enabled = True
        txtrg.Enabled = True
        txtcpf.Enabled = True
        txtdata.Enabled = True
        txtsexo.Enabled = True
        txtemail.Enabled = True
        txtsexo.Enabled = True
        txtendereco.Enabled = True
        txtnumero.Enabled = True
        txtbairro.Enabled = True
        txtcidade.Enabled = True
        txtuf.Enabled = True
        txtusuario.Enabled = True
        txtsenha.Enabled = True
        txtcep.Enabled = True
        txttelefone.Enabled = True
        txtemail.Enabled = True
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        btnalterar.Enabled = True
        btnexcluir.Enabled = True

        btnnovo.Enabled = True
        Form5.Show()
    End Sub
    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        txtcodigo.Enabled = False
        txtnome.Enabled = False
        txtrg.Enabled = False
        txtcpf.Enabled = False
        txtdata.Enabled = False
        txtsexo.Enabled = False
        txtemail.Enabled = False
        txtendereco.Enabled = False
        txtnumero.Enabled = False
        txtbairro.Enabled = False
        txtcidade.Enabled = False
        txtuf.Enabled = False
        txtusuario.Enabled = False
        txtsenha.Enabled = False
        txtcep.Enabled = False
        txttelefone.Enabled = False
        txtemail.Enabled = False
        txttelefone.Enabled = False
        btnalterar.Enabled = False
        btnexcluir.Enabled = False
        btnsalvar.Enabled = False

        'limpar todos os campos
        txtcodigo.Text = ""
        txtnome.Text = ""
        txtrg.Text = ""
        txtcpf.Text = ""
        txtdata.Text = ""
        txtsexo.Text = ""
        txtemail.Text = ""
        txtendereco.Text = ""
        txtnumero.Text = ""
        txtbairro.Text = ""
        txtcidade.Text = ""
        txtuf.Text = ""
        txtusuario.Text = ""
        txtsenha.Text = ""
        txtcep.Text = ""
        txtemail.Text = ""
        txttelefone.Text = ""
        txtnome.Focus()
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub btnfiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfiltro.Click
        Form4.Show()
        btnalterar.Enabled = True
        btnsalvar.Enabled = True
        btnexcluir.Enabled = True
    End Sub
    Private Sub btnsair_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
    Private Sub txtcodigo_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Asc(e.KeyChar) = 8 Then


            Exit Sub


        End If


        If Not Char.IsDigit(e.KeyChar) Then


            e.Handled = True


        End If
    End Sub
    Private Sub txtsexo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsexo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtsexo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsexo.Leave
        If txtsexo.Text = "MASCULINO" Or txtsexo.Text = "FEMININO" Then
        Else
            MsgBox("Campo SEXO inválido, por favor preencha corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtsexo.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub txtmaquina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 8 Then


            Exit Sub


        End If


        If Not Char.IsDigit(e.KeyChar) Then


            e.Handled = True


        End If
    End Sub

    Private Sub txtuf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuf.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtuf_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuf.Leave
        If txtuf.Text >= "AC" And txtuf.Text <= "TO" Then
        Else
            MsgBox("Campo UF inválido, por favor preencha corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtuf.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub txttotalrecebido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btninternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninternet.Click
        Form14.Show()
    End Sub
    Private Sub btnrelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatorio.Click
        Form19.Show()
    End Sub
    Private Sub txtnome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnome.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtbairro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbairro.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcidade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcidade.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class