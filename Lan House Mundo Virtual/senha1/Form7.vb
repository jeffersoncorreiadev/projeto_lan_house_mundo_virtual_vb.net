Public Class Form7

    Private Sub txtnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        ds = New DataSet
        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM funcionario WHERE Nome LIKE '" & txtnome.Text & "%'", conecta, ADODB.CursorTypeEnum.adOpenStatic,
ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, tabela, "ITEM")
        grid.DataSource = ds.Tables(0)
    End Sub
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregagri1d()
    End Sub
    Sub LinhaSelecionadaDoGrid()
        Form6.Show()
        With Form6
            .txtcodigo.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(0).Value.ToString()
            .txtnome.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(1).Value.ToString()
            .txtrg.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(2).Value.ToString()
            .txtcpf.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(3).Value.ToString()
            .txtdata.Text =
           grid.Rows(grid.SelectedCells(0).RowIndex).Cells(4).Value.ToString()
            .txtsexo.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(5).Value.ToString()
            .txtcivil.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(6).Value.ToString()
            .txtescola.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(7).Value.ToString()
            .txtendereco.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(8).Value.ToString()
            .txtnumero.Text =
            grid.Rows(grid.SelectedCells(0).RowIndex).Cells(9).Value.ToString()
            .txtcidade.Text =
           grid.Rows(grid.SelectedCells(0).RowIndex).Cells(10).Value.ToString()
            .txtuf.Text =
           grid.Rows(grid.SelectedCells(0).RowIndex).Cells(11).Value.ToString()
            .txtcep.Text =
           grid.Rows(grid.SelectedCells(0).RowIndex).Cells(12).Value.ToString()
            .txtbairro.Text =
           grid.Rows(grid.SelectedCells(0).RowIndex).Cells(13).Value.ToString()
            .txttelefone.Text =
           grid.Rows(grid.SelectedCells(0).RowIndex).Cells(14).Value.ToString()
            .txtturno.Text =
           grid.Rows(grid.SelectedCells(0).RowIndex).Cells(15).Value.ToString()
            .txtemail.Text =
          grid.Rows(grid.SelectedCells(0).RowIndex).Cells(16).Value.ToString()
            .txtusuario.Text =
          grid.Rows(grid.SelectedCells(0).RowIndex).Cells(17).Value.ToString()
            .txtsenha.Text =
          grid.Rows(grid.SelectedCells(0).RowIndex).Cells(18).Value.ToString()


            .btnalterar.Enabled = True
            .btnsalvar.Enabled = True
            .btnexcluir.Enabled = True
            
        End With
        Me.Hide()
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick
        LinhaSelecionadaDoGrid()
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class