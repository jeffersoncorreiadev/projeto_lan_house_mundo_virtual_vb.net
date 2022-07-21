Public Class Form19

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'bdDataSet.usuario' table. You can move, or remove it, as needed.
        Me.usuarioTableAdapter.Fill(Me.bdDataSet.usuario)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class