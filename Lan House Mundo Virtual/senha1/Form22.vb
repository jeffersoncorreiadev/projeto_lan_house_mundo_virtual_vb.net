Public Class Form22

    Private Sub Form22_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdDataSet1.contas' table. You can move, or remove it, as needed.
        Me.contasTableAdapter.Fill(Me.bdDataSet1.contas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class