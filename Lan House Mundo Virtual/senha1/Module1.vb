Imports System.Data.OleDb
Module Module1
    Public conecta As New ADODB.Connection
    Public tabela As New ADODB.Recordset
    Public status As Boolean
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public Sub abrebanco()
        conecta = New ADODB.Connection
        conecta.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bd.mdb")
    End Sub
    Public Sub limpa()
        With Form3
            .txtcodigo.Text = ""
            .txtcodigo.Text = ""
            .txtrg.Text = ""
            .txtcpf.Text = ""
            .txtdata.Text = ""
            .txtsexo.Text = ""
            .txtendereco.Text = ""
            .txtnumero.Text = ""
            .txtbairro.Text = ""
            .txtcidade.Text = ""
            .txtuf.Text = ""
            .txtcep.Text = ""
            .txttelefone.Text = ""
            .txtemail.Text = ""
        End With
        With Form6
            .txtcodigo.Text = ""
            .txtnome.Text = ""
            .txtrg.Text = ""
            .txtcpf.Text = ""
            .txtdata.Text = ""
            .txtsexo.Text = ""
            .txtcivil.Text = ""
            .txtescola.Text = ""
            .txtendereco.Text = ""
            .txtnumero.Text = ""
            .txtbairro.Text = ""
            .txtuf.Text = ""
            .txtcep.Text = ""
            .txttelefone.Text = ""
            .txtturno.Text = ""
            .txtemail.Text = ""
        End With
        With Form18
            .txtcodigo.Text = ""
            .txtcnpj.Text = ""
            .txtrazao.Text = ""
            .txtnome.Text = ""
            .txttelefone.Text = ""
            .txtfax.Text = ""
            .txtequipamento.Text = ""
            .txtposicao.Text = ""
            .txtemail.Text = ""
            .txtendereco.Text = ""
            .txtnumero.Text = ""
            .txtbairro.Text = ""
            .txtcep.Text = ""
            .txtuf.Text = ""
            .txtcep.Text = ""
            .txtcidade.Text = ""
            .txtuf.Text = ""
        End With
    End Sub
    Public Sub carregagrid()
        tabela = New ADODB.Recordset
        tabela.Open("select * from usuario  order by codigo", conecta)
        da = New OleDbDataAdapter
        ds = New DataSet
        da.Fill(ds, tabela, "usuario")
        Form4.grid.DataSource = ds.Tables("usuario")
        Form4.grid.Refresh()
    End Sub
    Public Sub carregagri1d()
        tabela = New ADODB.Recordset
        tabela.Open("select * from funcionario  order by codigo", conecta)
        da = New OleDbDataAdapter
        ds = New DataSet
        da.Fill(ds, tabela, "funcionario")
        Form7.grid.DataSource = ds.Tables("funcionario")
        Form7.grid.Refresh()
    End Sub
    Public Sub carregagrid5()
        tabela = New ADODB.Recordset
        tabela.Open("select * from empresa  order by codigo", conecta)
        da = New OleDbDataAdapter
        ds = New DataSet
        da.Fill(ds, tabela, "empresa")
        Form11.grids.DataSource = ds.Tables("empresa")
        Form11.grids.Refresh()
    End Sub
    Public Sub carregagrid6()
        tabela = New ADODB.Recordset
        tabela.Open("select * from contas  order by codigo", conecta)
        da = New OleDbDataAdapter
        ds = New DataSet
        da.Fill(ds, tabela, "contas")
        Form17.grids1.DataSource = ds.Tables("contas")
        Form17.grids1.Refresh()
    End Sub

End Module
