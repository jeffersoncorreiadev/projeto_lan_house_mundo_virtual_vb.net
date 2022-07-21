Public Class Form15
    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcodigo.Enabled = False
        txtfornecedor.Enabled = False
        txttipo.Enabled = False
        txtpagamento.Enabled = False
        txtvalor.Enabled = False
        txtnota.Enabled = False
        txtvencimento.Enabled = False

        btnalterar.Enabled = False
        btnexcluir.Enabled = False
        btnfiltro.Enabled = True
        btnsalvar.Enabled = False
        status = True
        abrebanco()
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        If txtcodigo.Text = "" Then
            MsgBox("Campo Código em branco, preencha corretamente!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtcodigo.Focus()
            Exit Sub
        End If
        If txtfornecedor.Text = "" Then
            MsgBox("Campo Fornecedor em branco, preencha corretamente!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtfornecedor.Focus()
            Exit Sub
        End If
        If txttipo.Text = "" Then
            MsgBox("Campo Tipo de Conta em branco, preencha corretamente!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txttipo.Focus()
            Exit Sub
        End If
        If txtvalor.Text = "" Then
            MsgBox("Campo Valor em branco, preencha corretamente!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtvalor.Focus()
            Exit Sub
        End If
        If txtnota.Text = "" Then
            MsgBox("Campo Nº da Nota em branco, preencha corretamente!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtnota.Focus()
            Exit Sub
        End If
        If txtpagamento.Text = "" Then
            MsgBox("Campo Forma de Pagamento em branco, preencha corretamente!", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtpagamento.Focus()
            Exit Sub
        End If
        Dim strsql As String
        If status = True Then
            strsql = "insert into contas (codigo,fornecedor,tipo,valor,numero,pagamento,vencimento,lancamento)" & "values (" & txtcodigo.Text & ",'" & txtfornecedor.Text & "','" & txttipo.Text & "','" & txtvalor.Text & "','" & txtnota.Text & "','" & txtpagamento.Text & "','" & txtvencimento.Text & "','" & lbdata.Text & "')"
            conecta.Execute(strsql)
            MsgBox("Nota Fiscal incluída com sucesso",
            MsgBoxStyle.Information, "Lan House Mundo Virtual")
        ElseIf status = False Then
            strsql = "update contas set fornecedor ='" & txtfornecedor.Text & "', tipo = '" & txttipo.Text & "', valor = '" & txtvalor.Text & "', numero = '" & txtnota.Text & "', pagamento = '" & txtpagamento.Text & "', vencimento ='" & txtvencimento.Text & "', lancamento = '" & lbdata.Text & "' where codigo = " & txtcodigo.Text & ""
            conecta.Execute(strsql)
            MsgBox("Nota Fiscal atualizada com sucesso", MsgBoxStyle.Information,
            "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
    Private Sub txtvalor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtvalor.KeyPress
        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtvalor_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvalor.Leave
        If txtvalor.Text = "" Then
            MsgBox("Campo VALOR em branco, por favor preencha corretamente", MsgBoxStyle.Exclamation, "Lan House Mundo Virtual")
            txtvalor.Focus()
            Exit Sub
        End If
        txtvalor.Text = String.Format("{0:c}", Double.Parse(txtvalor.Text))
    End Sub
    Private Sub txtnota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnota.KeyPress
        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnovo.Click
        tabela = New ADODB.Recordset
        tabela.Open("select max(codigo)+1 as NOVO from contas", conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        txtcodigo.Text = tabela.Fields("NOVO").Value()
        txtcodigo.Enabled = True
        txtfornecedor.Enabled = True
        txttipo.Enabled = True
        txtpagamento.Enabled = True
        txtvalor.Enabled = True
        txtnota.Enabled = True
        txtvencimento.Enabled = True

        btnsalvar.Enabled = True
        btnalterar.Enabled = False
        btnexcluir.Enabled = False
        btnlimpar.Enabled = True

        btnsalvar.Enabled = True
    End Sub
    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        txtcodigo.Enabled = False
        txtfornecedor.Enabled = False
        txttipo.Enabled = False
        txtpagamento.Enabled = False
        txtvalor.Enabled = False
        txtnota.Enabled = False
        txtvencimento.Enabled = False

        txtcodigo.Text = ""
        txtfornecedor.Text = ""
        txttipo.Text = ""
        txtpagamento.Text = ""
        txtvalor.Text = ""
        txtnota.Text = ""
        txtvencimento.Text = ""
        lbdata.Text = ""

        btnsalvar.Enabled = False
        btnexcluir.Enabled = False
        btnalterar.Enabled = False


    End Sub
    Private Sub btnalterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnalterar.Click
        status = False
        txtcodigo.Focus()
        txtcodigo.Enabled = True
        txtfornecedor.Enabled = True
        txttipo.Enabled = True
        txtpagamento.Enabled = True
        txtvalor.Enabled = True
        txtnota.Enabled = True
        txtvencimento.Enabled = True



        txtvalor.Text = ""

    End Sub
    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcluir.Click
        Dim resposta As String
        resposta = MsgBox("Confirma a exclusão?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Lan House Mundo Virtual")
        If resposta = vbNo Then
            Exit Sub
        Else
            tabela = New ADODB.Recordset
            tabela.Open("DELETE from contas where codigo = " & txtcodigo.Text & "",
            conecta)
            MsgBox("Nota Fiscal Excluida ",
            MsgBoxStyle.Information, "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub
    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        Form16.Show()
        btnalterar.Enabled = True
        btnexcluir.Enabled = True
        btnsalvar.Enabled = True
    End Sub
    Private Sub btnfiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfiltro.Click
        Form17.Show()

        btnalterar.Enabled = True
        btnsalvar.Enabled = True
        btnexcluir.Enabled = True
    End Sub
    Private Sub txtvencimento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtvencimento.Leave
        lbdata.Text = Date.Today
    End Sub
    Private Sub btnrelatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnrelatorio.Click
        Form22.Show()
    End Sub
    Private Sub txtfornecedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfornecedor.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txttipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttipo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtpagamento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpagamento.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class