<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form19
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form19))
        Me.usuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdDataSet = New WindowsApplication1.bdDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.usuarioTableAdapter = New WindowsApplication1.bdDataSetTableAdapters.usuarioTableAdapter()
        CType(Me.usuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'usuarioBindingSource
        '
        Me.usuarioBindingSource.DataMember = "usuario"
        Me.usuarioBindingSource.DataSource = Me.bdDataSet
        '
        'bdDataSet
        '
        Me.bdDataSet.DataSetName = "bdDataSet"
        Me.bdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.usuarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(811, 460)
        Me.ReportViewer1.TabIndex = 0
        '
        'usuarioTableAdapter
        '
        Me.usuarioTableAdapter.ClearBeforeFill = True
        '
        'Form19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(811, 460)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form19"
        Me.Text = "Relatório de Usuários"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.usuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents usuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bdDataSet As WindowsApplication1.bdDataSet
    Friend WithEvents usuarioTableAdapter As WindowsApplication1.bdDataSetTableAdapters.usuarioTableAdapter
End Class
