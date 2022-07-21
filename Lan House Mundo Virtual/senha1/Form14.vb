Public Class Form14

    Private Sub txtcodigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtcodigo.Leave

        If txtcodigo.Text = "" Then
            MsgBox("Campo Código em branco, preencha corretamente", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
            Exit Sub
        End If

        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM usuario WHERE codigo=" & txtcodigo.Text & "",
        conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If tabela.EOF = False Then

            txtcodigo.Text = tabela.Fields("codigo").Value()

            If Not IsDBNull(tabela.Fields("nome").Value()) Then
                txtnome.Text = tabela.Fields("nome").Value()
            End If

            If Not IsDBNull(tabela.Fields("rg").Value()) Then
                txtrg.Text = tabela.Fields("rg").Value()
            End If

            If Not IsDBNull(tabela.Fields("cpf").Value()) Then
                txtcpf.Text = tabela.Fields("cpf").Value()
            End If

            If Not IsDBNull(tabela.Fields("data").Value()) Then
                txtdata.Text = tabela.Fields("data").Value()
            End If

            If Not IsDBNull(tabela.Fields("sexo").Value()) Then
                txtsexo.Text = tabela.Fields("sexo").Value()
            End If
        Else
            MsgBox("Registro não encontrado", MsgBoxStyle.Information, "Lan House Mundo Virtual")
        End If
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        tabela = New ADODB.Recordset
        tabela.Open("select max(codigo)+1 as NOVO from internet", conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        txtcodigo.Text = tabela.Fields("NOVO").Value()

        Dim strsql As String
        If status = True Then
            strsql = "insert into internet (codigo,nome,rg,cpf,data,sexo,maquina,hora,pagamento,valor,dia,troco)" & "values (" & txtcodigo.Text & ",'" & txtnome.Text & "','" & txtrg.Text & "','" & txtcpf.Text & "','" & txtdata.Text & "','" & txtsexo.Text & "','" & txtmaquina.Text & "','" & txthoras.Text & "','" & txtpagamento.Text & "','" & txtvalor.Text & "','" & lbdata.Text & "','" & lbtroco.Text & "')"
            conecta.Execute(strsql)
            MsgBox("Usuário. " + txtnome.Text + "  pagamento efetuado com sucesso, estará logado na maquina de número  " + txtmaquina.Text + " com o tempo total de navegação de " + txthoras.Text, MsgBoxStyle.Information, "Lan House Mundo Virtual")
        ElseIf status = False Then
            strsql = "insert into internet (codigo,nome,rg,cpf,data,sexo,maquina,hora,pagamento,valor,dia,troco)" & "values (" & txtcodigo.Text & ",'" & txtnome.Text & "','" & txtrg.Text & "','" & txtcpf.Text & "','" & txtdata.Text & "','" & txtsexo.Text & "','" & txtmaquina.Text & "','" & txthoras.Text & "','" & txtpagamento.Text & "','" & txtvalor.Text & "','" & lbdata.Text & "','" & lbtroco.Text & "')"
            conecta.Execute(strsql)
            MsgBox("Usuário " + txtnome.Text + " pagamento efetuado com sucesso, estará logado na maquina de número  " + txtmaquina.Text + " com o tempo total de navegação de " + txthoras.Text, MsgBoxStyle.Information, "Lan House Mundo Virtual")
        End If
        btnlimpar.PerformClick()
    End Sub
    Private Sub txtpagamento_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpagamento.Leave
        Form9.lbpago.Text = FormatCurrency(txtpagamento.Text)

        If txtpagamento.Text = "" Then
            MsgBox("Campo Pagamento em branco, por favor preencha corretamente", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
            txtpagamento.Focus()
            Exit Sub
        End If
        txtpagamento.Text = String.Format("{0:c}", Double.Parse(txtpagamento.Text))

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
            MsgBox("Campo Valor em branco, por favor preencha corretamente", MsgBoxStyle.Critical, "Lan House Mundo Virtual")
            txtvalor.Focus()
            Exit Sub
        End If
        txtvalor.Text = String.Format("{0:c}", Double.Parse(txtvalor.Text))
        Dim pagamento, valor, total1
        pagamento = txtpagamento.Text
        valor = txtvalor.Text
        total1 = (pagamento - valor)
        lbtroco.Text = FormatCurrency(total1)
    End Sub
    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbdata.Text = Date.Today
        txtcodigo.Enabled = True
        txtnome.Enabled = False
        txtrg.Enabled = False
        txtcpf.Enabled = False
        txtdata.Enabled = False
        txtsexo.Enabled = False
    End Sub
    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        txtcodigo.Text = ""
        txtnome.Text = ""
        txtrg.Text = ""
        txtcpf.Text = ""
        txtdata.Text = ""
        txtsexo.Text = ""
        txtmaquina.Text = ""
        txthoras.Text = ""
        txtpagamento.Text = ""
        txtvalor.Text = ""
        lbtroco.Text = ""

    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
    Private Sub txthoras_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txthoras.KeyPress
        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txthoras_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txthoras.Leave
        Form9.lbtempo.Text = txthoras.Text
    End Sub
    Private Sub txtmaquina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmaquina.KeyPress
        If Asc(e.KeyChar) = 3 Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 22 Or Asc(e.KeyChar) = 24 Or Asc(e.KeyChar) = 44 Then
            Exit Sub
        End If

        If Not Char.IsNumber(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class