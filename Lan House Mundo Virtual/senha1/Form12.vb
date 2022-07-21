Public Class Form12
    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregagrid()
    End Sub
    Private Sub txtnome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnome.TextChanged
        ds = New DataSet
        tabela = New ADODB.Recordset
        tabela.Open("SELECT * FROM usuario WHERE Nome LIKE '" & txtnome.Text & "%'", conecta, ADODB.CursorTypeEnum.adOpenStatic,
ADODB.LockTypeEnum.adLockOptimistic)
        da.Fill(ds, tabela, "ITEM")
        grid.DataSource = ds.Tables(0)
    End Sub
    Sub LinhaSelecionadaDoGrid()
        Form14.Show()
        With Form14
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
        End With
        Form3.Close()
    End Sub
    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid.CellContentClick
        LinhaSelecionadaDoGrid()
    End Sub
    Private Sub btnsair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsair.Click
        Me.Close()
    End Sub
End Class