Public Class Form18
    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        txtcodigo.Enabled = False
        txtcnpj.Enabled = False
        txtnome.Enabled = False
        txtrazao.Enabled = False
        txttelefone.Enabled = False
        txtfax.Enabled = False
        txtemail.Enabled = False
        txtendereco.Enabled = False
        txtequipamento.Enabled = False
        txtposicao.Enabled = False
        txtnumero.Enabled = False
        txtbairro.Enabled = False
        txtcep.Enabled = False
        txtuf.Enabled = False
        txtcep.Enabled = False
        txtcidade.Enabled = False
        txtuf.Enabled = False


        txtmarca.Enabled = False
        txtmodelo.Enabled = False
        txtquantidade.Enabled = False
        txtvalor.Enabled = False


        btnalterar.Enabled = False
        btnexcluir.Enabled = False
        btnfiltro.Enabled = True
        btnsalvar.Enabled = False

        txtcodigo.Text = ""
        txtcnpj.Text = ""
        txtnome.Text = ""
        txtrazao.Text = ""
        txttelefone.Text = ""
        txtfax.Text = ""
        txtequipamento.Text = ""
        txtposicao.Text = ""
        txtemail.Text = ""
        txtendereco.Text = ""
        txtnumero.Text = ""
        txtbairro.Text = ""
        txtcep.Text = ""
        txtuf.Text = ""
        txtcep.Text = ""
        txtcidade.Text = ""
        txtuf.Text = ""
        txtmarca.Text = ""
        txtmodelo.Text = ""
        txtquantidade.Text = ""
        txtvalor.Text = ""
        lbtotal.Text = ""
        txtcodigo.Focus()

    End Sub
    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        Form10.Show()

        btnalterar.Enabled = True
        btnexcluir.Enabled = True
        btnnovo.Enabled = True
    End Sub
    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcodigo.Enabled = False
        txtcnpj.Enabled = False
        txtnome.Enabled = False
        txtrazao.Enabled = False
        txttelefone.Enabled = False
        txtfax.Enabled = False
        txtequipamento.Enabled = False
        txtposicao.Enabled = False
        txtemail.Enabled = False
        txtendereco.Enabled = False
        txtnumero.Enabled = False
        txtbairro.Enabled = False
        txtcep.Enabled = False
        txtuf.Enabled = False
        txtcep.Enabled = False
        txtcidade.Enabled = False
        txtuf.Enabled = False
        txtmarca.Enabled = False
        txtmodelo.Enabled = False
        txtquantidade.Enabled = False
        txtvalor.Enabled = False


        btnalterar.Enabled = False
        btnexcluir.Enabled = False
        btnfiltro.Enabled = True
        btnsalvar.Enabled = False
        lbdata.Text = Date.Today
        status = True
        abrebanco()
    End Sub

    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        tabela = New ADODB.Recordset
        tabela.Open("select max(codigo)+1 as NOVO from empresa", conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        txtcodigo.Text = tabela.Fields("NOVO").Value()
        txtcodigo.Enabled = True
        txtcnpj.Enabled = True
        txtnome.Enabled = True
        txtrazao.Enabled = True
        txttelefone.Enabled = True
        txtfax.Enabled = True
        txtequipamento.Enabled = True
        txtposicao.Enabled = True
        txtemail.Enabled = True
        txtendereco.Enabled = True
        txtnumero.Enabled = True
        txtbairro.Enabled = True
        txtcep.Enabled = True
        txtuf.Enabled = True
        txtcep.Enabled = True
        txtcidade.Enabled = True
        txtuf.Enabled = True
        txtmarca.Enabled = True
        txtmodelo.Enabled = True
        txtquantidade.Enabled = True
        txtvalor.Enabled = True

        btnsalvar.Enabled = True
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        If txtcodigo.Text = "" Then
            MsgBox("Campo CÓDIGO em branco, campo obrigatorio", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            Exit Sub
        End If
        If txtnome.Text = "" Then
            MsgBox("Campo NOME FANTASIA em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtnome.Focus()
            Exit Sub
        End If
        If txtrazao.Text = "" Then
            MsgBox("Campo RAZÃO SOCIAL em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtrazao.Focus()
            Exit Sub
        End If
        If txtcnpj.Text = "" Then
            MsgBox("Campo CNPJ em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcnpj.Focus()
            Exit Sub
        End If
        If txtequipamento.Text = "" Then
            MsgBox("Campo EQUIPAMENTOS em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtequipamento.Focus()
            Exit Sub
        End If
        If txttelefone.Text = "" Then
            MsgBox("Campo TELEFONE em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txttelefone.Focus()
            Exit Sub
        End If
        If txtfax.Text = "" Then
            MsgBox("Campo FAX em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtfax.Focus()
            Exit Sub
        End If
        If txtemail.Text = "" Then
            MsgBox("Campo E-MAIL em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtemail.Focus()
            Exit Sub
        End If
        If txtposicao.Text = "" Then
            MsgBox("Campo STATUS em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtposicao.Focus()
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
        If txtmarca.Text = "" Then
            MsgBox("Campo MARCA em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtmarca.Focus()
            Exit Sub
        End If
        If txtmodelo.Text = "" Then
            MsgBox("Campo MODELO em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtmarca.Focus()
            Exit Sub
        End If
        If txtquantidade.Text = "" Then
            MsgBox("Campo QUANTIDADE em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtquantidade.Focus()
            Exit Sub
        End If
        If txtvalor.Text = "" Then
            MsgBox("Campo VALOR em branco, campo obrigatorio!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtvalor.Focus()
            Exit Sub
        End If


        Dim strsql As String
        If status = True Then
            strsql = "insert into empresa (codigo,nome_fantasia,razao_social,cnpj,telefone,fax,equipamento,posicao,email,endereco,numero,bairro,cep,cidade,uf,marca,modelo,quantidade,valor,total,dia)" & "values (" & txtcodigo.Text & ",'" & txtnome.Text & "','" & txtrazao.Text & "','" & txtcnpj.Text & "','" & txttelefone.Text & "','" & txtfax.Text & "','" & txtequipamento.Text & "','" & txtposicao.Text & "','" & txtemail.Text & "','" & txtendereco.Text & "','" & txtnumero.Text & "','" & txtbairro.Text & "','" & txtcep.Text & "','" & txtcidade.Text & "','" & txtuf.Text & "','" & txtmarca.Text & "','" & txtmodelo.Text & "','" & txtquantidade.Text & "','" & txtvalor.Text & "','" & lbtotal.Text & "','" & lbdata.Text & "')"
            conecta.Execute(strsql)
            MsgBox("Dados incluídos com sucesso",
            MsgBoxStyle.Information, "Lan House Mundo Virtual")
        ElseIf status = False Then
            strsql = "update empresa set nome_fantasia ='" & txtnome.Text & "', razao_social = '" & txtrazao.Text & "', cnpj = '" & txtcnpj.Text & "', telefone = '" & txttelefone.Text & "', fax = '" & txtfax.Text & "', equipamento ='" & txtequipamento.Text & "', posicao = '" & txtposicao.Text & "', email = '" & txtemail.Text & "', endereco = '" & txtendereco.Text & "', numero = '" & txtnumero.Text & "', bairro = '" & txtbairro.Text & "', cep = '" & txtcep.Text & "', cidade = '" & txtcidade.Text & "', uf = '" & txtuf.Text & "', marca = '" & txtmarca.Text & "', modelo = '" & txtmodelo.Text & "', quantidade = '" & txtquantidade.Text & "', valor = '" & txtvalor.Text & "', total = '" & lbtotal.Text & "', dia = '" & lbdata.Text & "' where codigo = " & txtcodigo.Text & ""
            conecta.Execute(strsql)
            MsgBox("Dados atualizados com sucesso", MsgBoxStyle.Information,
            "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub

    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click

        Dim resposta As String
        resposta = MsgBox("Confirma exclusão deste Fornecedor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lan House Mundo Virtual")
        If resposta = vbNo Then
            Exit Sub
        Else
            tabela = New ADODB.Recordset
            tabela.Open("DELETE from empresa where codigo = " & txtcodigo.Text & "",
            conecta)
            MsgBox("Fornecedor Excluido ", MsgBoxStyle.Information, "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalterar.Click
        status = False
        txtcodigo.Focus()
        btnsalvar.Enabled = True
        btnalterar.Enabled = True
        txtcodigo.Enabled = True
        txtcnpj.Enabled = True
        txtnome.Enabled = True
        txtrazao.Enabled = True
        txttelefone.Enabled = True
        txtfax.Enabled = True
        txtequipamento.Enabled = True
        txtposicao.Enabled = True
        txtemail.Enabled = True
        txtendereco.Enabled = True
        txtnumero.Enabled = True
        txtbairro.Enabled = True
        txtcep.Enabled = True
        txtuf.Enabled = True
        txtcep.Enabled = True
        txtcidade.Enabled = True
        txtuf.Enabled = True
        txtmarca.Enabled = True
        txtmodelo.Enabled = True
        txtquantidade.Enabled = True
        txtvalor.Enabled = True
    End Sub
    Private Sub btnfiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfiltro.Click
        Form11.Show()
        btnalterar.Enabled = True
        btnsalvar.Enabled = True
        btnexcluir.Enabled = True
    End Sub
    Private Sub txtcodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Asc(e.KeyChar) = 8 Then


            Exit Sub


        End If


        If Not Char.IsDigit(e.KeyChar) Then


            e.Handled = True


        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub txtvalor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvalor.Click
        txtvalor.Text = ""
        lbtotal.Text = ""
    End Sub
    Private Sub txtvalor_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalor.KeyPress
        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtvalor_Leave1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvalor.Leave
        txtvalor.Text = String.Format("{0:c}", Double.Parse(txtvalor.Text))

        Dim quantidade, valor, total
        quantidade = txtquantidade.Text
        valor = txtvalor.Text
        total = (quantidade * valor)
        lbtotal.Text = FormatCurrency(total)
    End Sub
    Private Sub txtquantidade_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtquantidade.KeyPress
        If Asc(e.KeyChar) = 8 Then


            Exit Sub


        End If


        If Not Char.IsDigit(e.KeyChar) Then


            e.Handled = True


        End If
    End Sub
    Private Sub btnrelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatorio.Click
        Form21.Show()
    End Sub
    Private Sub txtnome_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnome.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtrazao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrazao.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtequipamento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtequipamento.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtposicao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtposicao.KeyPress
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
    Private Sub txtuf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuf.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtmarca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmarca.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtuf_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuf.Leave
        txtmarca.Focus()
    End Sub
End Class