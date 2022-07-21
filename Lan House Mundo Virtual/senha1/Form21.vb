Public Class Form21

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdDataSet1.empresa' table. You can move, or remove it, as needed.
        Me.empresaTableAdapter.Fill(Me.bdDataSet1.empresa)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class