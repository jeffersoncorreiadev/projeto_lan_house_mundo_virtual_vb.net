Public Class Form11
    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregagrid5()
    End Sub
    Private Sub txtnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        ds = New DataSet
        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM empresa WHERE nome_fantasia LIKE '" & txtnome.Text & "%'", conecta, ADODB.CursorTypeEnum.adOpenStatic,
ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, tabela, "ITEM")
        grids.DataSource = ds.Tables(0)
    End Sub
    Sub LinhaSelecionadaDoGrid()
        Form18.Show()
        With Form18
            .txtcodigo.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(0).Value.ToString()
            .txtnome.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(1).Value.ToString()
            .txtrazao.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(2).Value.ToString()
            .txtcnpj.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(3).Value.ToString()
            .txttelefone.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(4).Value.ToString()
            .txtequipamento.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(5).Value.ToString()
            .txtposicao.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(6).Value.ToString()
            .txtfax.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(7).Value.ToString()
            .txtemail.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(8).Value.ToString()
            .txtendereco.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(9).Value.ToString()
            .txtnumero.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(10).Value.ToString()
            .txtbairro.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(11).Value.ToString()
            .txtcep.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(12).Value.ToString()
            .txtcidade.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(13).Value.ToString()
            .txtuf.Text =
            grids.Rows(grids.SelectedCells(0).RowIndex).Cells(14).Value.ToString()

            .btnalterar.Enabled = True
            .btnsalvar.Enabled = True
            .btnexcluir.Enabled = True

        End With
        Me.Hide()
    End Sub
    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grids.CellContentClick
        LinhaSelecionadaDoGrid()
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class