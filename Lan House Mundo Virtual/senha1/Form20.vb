Public Class Form20

    Private Sub Form20_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdDataSet1.funcionario' table. You can move, or remove it, as needed.
        Me.funcionarioTableAdapter.Fill(Me.bdDataSet1.funcionario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class