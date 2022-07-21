Public Class Form6
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtuf.Enabled = False
        txtcep.Enabled = False
        txtcidade.Enabled = False
        txttelefone.Enabled = False
        txtemail.Enabled = False
        txtusuario.Enabled = False
        txtsenha.Enabled = False
        txttelefone.Enabled = False
        txtcivil.Enabled = False
        txtescola.Enabled = False
        txtturno.Enabled = False




        btnalterar.Enabled = False
        btnexcluir.Enabled = False
        btnfiltro.Enabled = True
        btnsalvar.Enabled = False
        status = True
        abrebanco()
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnsalvar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
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
        If txtcivil.Text = "" Then
            MsgBox("Campo ESTADO CIVIL em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcivil.Focus()
            Exit Sub
        End If
        If txtescola.Text = "" Then
            MsgBox("Campo FORMAÇÃO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtescola.Focus()
            Exit Sub
        End If
        If txtturno.Text = "" Then
            MsgBox("Campo TURNO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtturno.Focus()
            Exit Sub
        End If
        If txtemail.Text = "" Then
            MsgBox("Campo E-MAIL em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtemail.Focus()
            Exit Sub
        End If
        If txttelefone.Text = "" Then
            MsgBox("Campo TELEFONE em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txttelefone.Focus()
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
        If txtcep.Text = "" Then
            MsgBox("Campo CEP em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcep.Focus()
            Exit Sub
        End If
        If txtbairro.Text = "" Then
            MsgBox("Campo BAIRRO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtbairro.Focus()
            Exit Sub
        End If
        If txtcidade.Text = "" Then
            MsgBox("Campo CIDADE em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcivil.Focus()
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
            strsql = "insert into funcionario (codigo,nome,rg,cpf,data,sexo,civil,formacao,endereco,numero,cep,bairro,cidade,uf,telefone,turno,email,Usuario,Senha)" & "values (" & txtcodigo.Text & ",'" & txtnome.Text & "','" & txtrg.Text & "','" & txtcpf.Text & "','" & txtdata.Text & "','" & txtsexo.Text & "','" & txtcivil.Text & "','" & txtescola.Text & "','" & txtendereco.Text & "','" & txtnumero.Text & "','" & txtcep.Text & "','" & txtbairro.Text & "','" & txtcidade.Text & "','" & txtuf.Text & "','" & txttelefone.Text & "','" & txtturno.Text & "','" & txtemail.Text & "','" & txtusuario.Text & "','" & txtsenha.Text & "')"
            conecta.Execute(strsql)
            MsgBox("Dados incluídos com sucesso",
            MsgBoxStyle.Information, "Lan House Mundo Virtual")
        ElseIf status = False Then
            strsql = "update funcionario set nome='" & txtnome.Text & "', rg = '" & txtrg.Text & "', cpf = '" & txtcpf.Text & "', data = '" & txtdata.Text & "', sexo = '" & txtsexo.Text & "', civil = '" & txtcivil.Text & "', formacao = '" & txtescola.Text & "', endereco = '" & txtendereco.Text & "', numero = '" & txtnumero.Text & "', cep = '" & txtcep.Text & "', bairro = '" & txtbairro.Text & "', cidade = '" & txtcidade.Text & "', uf = '" & txtuf.Text & "', telefone = '" & txttelefone.Text & "', turno = '" & txtturno.Text & "', email = '" & txtemail.Text & "', Usuario = '" & txtusuario.Text & "', Senha = '" & txtsenha.Text & "'  where codigo = " & txtcodigo.Text & ""
            conecta.Execute(strsql)
            MsgBox("Dados atualizados com sucesso", MsgBoxStyle.Information,
            "Lan House Mundo Virtual")
        End If

        btnlimpar.PerformClick()
    End Sub
    Private Sub btnnovo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        tabela = New ADODB.Recordset
        tabela.Open("select max(codigo)+1 as NOVO from funcionario", conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
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
        txtcep.Enabled = True
        txttelefone.Enabled = True
        txtemail.Enabled = True
        txtusuario.Enabled = True
        txtsenha.Enabled = True
        txttelefone.Enabled = True
        txtcivil.Enabled = True
        txtescola.Enabled = True
        txtturno.Enabled = True

        btnsalvar.Enabled = True
        btnalterar.Enabled = False
        btnexcluir.Enabled = False
    End Sub
    Private Sub btnconsultar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        btnalterar.Enabled = True
        btnexcluir.Enabled = True
        btnnovo.Enabled = True
        Form8.Show()
    End Sub
    Private Sub btnlimpar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
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
        txtcep.Enabled = False
        txttelefone.Enabled = False
        txtemail.Enabled = False
        txtusuario.Enabled = False
        txtsenha.Enabled = False
        txttelefone.Enabled = False
        txtcivil.Enabled = False
        txtescola.Enabled = False
        txtturno.Enabled = False
        btnalterar.Enabled = False
        btnsalvar.Enabled = False
        btnexcluir.Enabled = False

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
        txtcep.Text = ""
        txtemail.Text = ""
        txtusuario.Text = ""
        txtsenha.Text = ""
        txttelefone.Text = ""
        txtcivil.Text = ""
        txtescola.Text = ""
        txtturno.Text = ""
        txtnome.Focus()
    End Sub
    Private Sub btnalterar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalterar.Click
        status = False
        txtcodigo.Focus()
        btnsalvar.Enabled = True
        btnsalvar.Enabled = True
        btnalterar.Enabled = True
        txtcodigo.Enabled = True
        txtnome.Enabled = True
        txtrg.Enabled = True
        txtcpf.Enabled = True
        txtdata.Enabled = True
        txtsexo.Enabled = True
        txtemail.Enabled = True
        txtusuario.Enabled = True
        txtsenha.Enabled = True
        txtsexo.Enabled = True
        txtendereco.Enabled = True
        txtnumero.Enabled = True
        txtbairro.Enabled = True
        txtcidade.Enabled = True
        txtuf.Enabled = True
        txtcep.Enabled = True
        txttelefone.Enabled = True
        txtemail.Enabled = True
        txttelefone.Enabled = True
        txtcivil.Enabled = True
        txtescola.Enabled = True
        txtturno.Enabled = True
    End Sub
    Private Sub btnexcluir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click
        Dim resposta As String
        resposta = MsgBox("Confirma exclusão deste Funcionário?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lan House Mundo Virtual")
        If resposta = vbNo Then
            Exit Sub
        Else
            tabela = New ADODB.Recordset
            tabela.Open("DELETE from funcionario where codigo = " & txtcodigo.Text & "",
            conecta)
            MsgBox("Funcionário Excluido", MsgBoxStyle.Information, "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnfiltro_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfiltro.Click
        Form7.Show()
    End Sub
    Private Sub btnrelatorio_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatorio.Click
        Form20.Show()
    End Sub
    Private Sub btnsair_Click_1(sender As System.Object, e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
    Private Sub txtcodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Asc(e.KeyChar) = 8 Then


            Exit Sub


        End If


        If Not Char.IsDigit(e.KeyChar) Then


            e.Handled = True


        End If
    End Sub
    Private Sub txtturno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtturno.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtturno_Leave(sender As Object, e As System.EventArgs) Handles txtturno.Leave
        If txtturno.Text = "MANHÃ" Or txtturno.Text = "TARDE" Or txtturno.Text = "NOITE" Then
        Else
            MsgBox("Campo TURNO inválido, por favor preencha corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtturno.Text = ""
            txtturno.Focus()
            Exit Sub
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
            txtsexo.Text = ""
            txtsexo.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub txtcivil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcivil.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtcivil_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcivil.Leave
        If txtcivil.Text = "CASADO(A)" Or txtcivil.Text = "DIVORCIADO(A)" Or txtcivil.Text = "SOLTEIRO(A)" Or txtcivil.Text = "UNIÃO ESTÁVEL" Or txtcivil.Text = "VIÚVO(A)" Then
        Else
            MsgBox("Campo ESTADO CIVIL inválido, por favor preencha corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcivil.Text = ""
            txtcivil.Focus()
            Exit Sub
        End If
    End Sub
    Private Sub txtescola_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtescola.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtescola_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtescola.Leave
        If txtescola.Text >= "1º GRAU COMPLETO" And txtescola.Text <= "3º GRAU INCOMPLETO" Then
        Else
            MsgBox("Campo FORMAÇÃO inválido, por favor preencha corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtescola.Text = ""
            txtescola.Focus()
            Exit Sub
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
            txtuf.Text = ""
            txtuf.Focus()
            Exit Sub
        End If
        txtusuario.Focus()
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
    Private Sub txtuf_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuf.SelectedIndexChanged

    End Sub
End Class