Public Class Form17

    Private Sub txtnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        ds = New DataSet
        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM contas WHERE fornecedor LIKE '" & txtnome.Text & "%'", conecta, ADODB.CursorTypeEnum.adOpenStatic,
ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, tabela, "ITEM")
        grids1.DataSource = ds.Tables(0)
    End Sub
    Private Sub Form17_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregagrid6()
    End Sub
    Sub LinhaSelecionadaDoGrid()
        With Form15
            .txtcodigo.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(0).Value.ToString()
            .txtfornecedor.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(1).Value.ToString()
            .txttipo.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(2).Value.ToString()
            .txtvalor.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(3).Value.ToString()
            .txtnota.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(4).Value.ToString()
            .txtpagamento.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(5).Value.ToString()
            .txtvencimento.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(6).Value.ToString()
            .lbdata.Text =
            grids1.Rows(grids1.SelectedCells(0).RowIndex).Cells(7).Value.ToString()

            .btnalterar.Enabled = True
            .btnsalvar.Enabled = True
            .btnexcluir.Enabled = True

        End With
        Me.Hide()
    End Sub
    Private Sub grids1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grids1.CellContentClick
        LinhaSelecionadaDoGrid()
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class