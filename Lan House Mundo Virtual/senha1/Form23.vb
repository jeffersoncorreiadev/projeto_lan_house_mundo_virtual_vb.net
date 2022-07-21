Public Class Form23

    Private Sub Form23_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdDataSet1.internet' table. You can move, or remove it, as needed.
        Me.internetTableAdapter.Fill(Me.bdDataSet1.internet)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class