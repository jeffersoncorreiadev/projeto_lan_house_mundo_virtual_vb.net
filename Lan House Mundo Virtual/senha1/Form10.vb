Public Class Form10

    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If txtcodigo.Text = "" Then
            MsgBox("Campo Código em branco", MsgBoxStyle.Critical)
            Exit Sub

        End If
        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM empresa WHERE codigo=" & txtcodigo.Text & "",
        conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If tabela.EOF = False Then
            With Form18

                .txtcodigo.Text = tabela.Fields("codigo").Value()

                If Not IsDBNull(tabela.Fields("nome_fantasia").Value()) Then
                    .txtnome.Text = tabela.Fields("nome_fantasia").Value()
                End If

                If Not IsDBNull(tabela.Fields("razao_social").Value()) Then
                    .txtrazao.Text = tabela.Fields("razao_social").Value()
                End If

                If Not IsDBNull(tabela.Fields("cnpj").Value()) Then
                    .txtcnpj.Text = tabela.Fields("cnpj").Value()
                End If

                If Not IsDBNull(tabela.Fields("equipamento").Value()) Then
                    .txtequipamento.Text = tabela.Fields("equipamento").Value()
                End If

                If Not IsDBNull(tabela.Fields("telefone").Value()) Then
                    .txttelefone.Text = tabela.Fields("telefone").Value()
                End If

                If Not IsDBNull(tabela.Fields("fax").Value()) Then
                    .txtfax.Text = tabela.Fields("fax").Value()
                End If

                If Not IsDBNull(tabela.Fields("email").Value()) Then
                    .txtemail.Text = tabela.Fields("email").Value()
                End If

                If Not IsDBNull(tabela.Fields("posicao").Value()) Then
                    .txtposicao.Text = tabela.Fields("posicao").Value()
                End If

                If Not IsDBNull(tabela.Fields("endereco").Value()) Then
                    .txtendereco.Text = tabela.Fields("endereco").Value()
                End If

                If Not IsDBNull(tabela.Fields("numero").Value()) Then
                    .txtnumero.Text = tabela.Fields("numero").Value()
                End If

                If Not IsDBNull(tabela.Fields("numero").Value()) Then
                    .txtnumero.Text = tabela.Fields("numero").Value()
                End If

                If Not IsDBNull(tabela.Fields("bairro").Value()) Then
                    .txtbairro.Text = tabela.Fields("bairro").Value()
                End If
                If Not IsDBNull(tabela.Fields("cep").Value()) Then
                    .txtcep.Text = tabela.Fields("cep").Value()
                End If

                If Not IsDBNull(tabela.Fields("cidade").Value()) Then
                    .txtcidade.Text = tabela.Fields("cidade").Value()
                End If

                If Not IsDBNull(tabela.Fields("uf").Value()) Then
                    .txtuf.Text = tabela.Fields("uf").Value()
                End If
                If Not IsDBNull(tabela.Fields("marca").Value()) Then
                    .txtmarca.Text = tabela.Fields("marca").Value()
                End If

                If Not IsDBNull(tabela.Fields("modelo").Value()) Then
                    .txtmodelo.Text = tabela.Fields("modelo").Value()
                End If
                If Not IsDBNull(tabela.Fields("quantidade").Value()) Then
                    .txtquantidade.Text = tabela.Fields("quantidade").Value()
                End If

                If Not IsDBNull(tabela.Fields("valor").Value()) Then
                    .txtvalor.Text = tabela.Fields("valor").Value()
                End If
                If Not IsDBNull(tabela.Fields("total").Value()) Then
                    .lbtotal.Text = tabela.Fields("total").Value()
                End If

            End With
            Me.Hide()
            txtcodigo.Text = ""
        Else
            MsgBox("Registro não encontrado")
            txtcodigo.Text = ""
            txtcodigo.Focus()
        End If
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        txtcodigo.Text = ""
        txtcodigo.Focus()
    End Sub

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtcodigo.Focus()
    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo.KeyPress
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

    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub
End Class