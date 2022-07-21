Public Class Form16

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
    Private Sub btnconsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconsultar.Click
        If txtcodigo.Text = "" Then
            MsgBox("Campo Código em branco", MsgBoxStyle.Critical)
            Exit Sub

        End If
        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM contas WHERE codigo=" & txtcodigo.Text & "",
        conecta, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If tabela.EOF = False Then
            With Form15

                .txtcodigo.Text = tabela.Fields("codigo").Value()

                If Not IsDBNull(tabela.Fields("fornecedor").Value()) Then
                    .txtfornecedor.Text = tabela.Fields("fornecedor").Value()
                End If

                If Not IsDBNull(tabela.Fields("tipo").Value()) Then
                    .txttipo.Text = tabela.Fields("tipo").Value()
                End If

                If Not IsDBNull(tabela.Fields("valor").Value()) Then
                    .txtvalor.Text = tabela.Fields("valor").Value()
                End If

                If Not IsDBNull(tabela.Fields("numero").Value()) Then
                    .txtnota.Text = tabela.Fields("numero").Value()
                End If

                If Not IsDBNull(tabela.Fields("pagamento").Value()) Then
                    .txtpagamento.Text = tabela.Fields("pagamento").Value()
                End If

                If Not IsDBNull(tabela.Fields("vencimento").Value()) Then
                    .txtvencimento.Text = tabela.Fields("vencimento").Value()
                End If

                If Not IsDBNull(tabela.Fields("lancamento").Value()) Then
                    .lbdata.Text = tabela.Fields("lancamento").Value()
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

    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub

    Private Sub txtcodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcodigo.TextChanged

    End Sub
End Class