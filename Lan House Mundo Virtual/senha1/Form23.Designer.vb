﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form23
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form23))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.bdDataSet1 = New WindowsApplication1.bdDataSet1()
        Me.internetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.internetTableAdapter = New WindowsApplication1.bdDataSet1TableAdapters.internetTableAdapter()
        CType(Me.bdDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.internetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.internetBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(811, 460)
        Me.ReportViewer1.TabIndex = 0
        '
        'bdDataSet1
        '
        Me.bdDataSet1.DataSetName = "bdDataSet1"
        Me.bdDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'internetBindingSource
        '
        Me.internetBindingSource.DataMember = "internet"
        Me.internetBindingSource.DataSource = Me.bdDataSet1
        '
        'internetTableAdapter
        '
        Me.internetTableAdapter.ClearBeforeFill = True
        '
        'Form23
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 460)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form23"
        Me.Text = "Relatório de Caixa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.bdDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.internetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents internetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bdDataSet1 As WindowsApplication1.bdDataSet1
    Friend WithEvents internetTableAdapter As WindowsApplication1.bdDataSet1TableAdapters.internetTableAdapter
End Class
