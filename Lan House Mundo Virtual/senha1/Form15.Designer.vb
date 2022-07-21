<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form15))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtvencimento = New System.Windows.Forms.MaskedTextBox()
        Me.txtpagamento = New System.Windows.Forms.ComboBox()
        Me.txtnota = New System.Windows.Forms.TextBox()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.txttipo = New System.Windows.Forms.ComboBox()
        Me.txtfornecedor = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbdata = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnconsultar = New System.Windows.Forms.Button()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.btnalterar = New System.Windows.Forms.Button()
        Me.btnfiltro = New System.Windows.Forms.Button()
        Me.btnrelatorio = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtvencimento)
        Me.GroupBox1.Controls.Add(Me.txtpagamento)
        Me.GroupBox1.Controls.Add(Me.txtnota)
        Me.GroupBox1.Controls.Add(Me.txtvalor)
        Me.GroupBox1.Controls.Add(Me.txttipo)
        Me.GroupBox1.Controls.Add(Me.txtfornecedor)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbdata)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnconsultar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 145)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Contas à Pagar"
        '
        'txtvencimento
        '
        Me.txtvencimento.Location = New System.Drawing.Point(290, 111)
        Me.txtvencimento.Mask = "00/00/0000"
        Me.txtvencimento.Name = "txtvencimento"
        Me.txtvencimento.Size = New System.Drawing.Size(100, 24)
        Me.txtvencimento.TabIndex = 83
        Me.txtvencimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtvencimento.ValidatingType = GetType(Date)
        '
        'txtpagamento
        '
        Me.txtpagamento.FormattingEnabled = True
        Me.txtpagamento.Items.AddRange(New Object() {"DINHEIRO", "CHEQUE", "CARTÃO DE DÉBITO", "DÉBITO AUTOMÁTICO"})
        Me.txtpagamento.Location = New System.Drawing.Point(575, 75)
        Me.txtpagamento.Name = "txtpagamento"
        Me.txtpagamento.Size = New System.Drawing.Size(184, 26)
        Me.txtpagamento.TabIndex = 82
        '
        'txtnota
        '
        Me.txtnota.Location = New System.Drawing.Point(290, 76)
        Me.txtnota.Name = "txtnota"
        Me.txtnota.Size = New System.Drawing.Size(100, 24)
        Me.txtnota.TabIndex = 81
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(77, 78)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(112, 24)
        Me.txtvalor.TabIndex = 80
        '
        'txttipo
        '
        Me.txttipo.FormattingEnabled = True
        Me.txttipo.Items.AddRange(New Object() {"ÁGUA", "ALUGUEL", "GÁS", "BEBEDOUROS", "LUZ", "TELEFONE", "INTERNET", "IPTU"})
        Me.txttipo.Location = New System.Drawing.Point(575, 45)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(184, 26)
        Me.txttipo.TabIndex = 79
        '
        'txtfornecedor
        '
        Me.txtfornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtfornecedor.Location = New System.Drawing.Point(112, 47)
        Me.txtfornecedor.Name = "txtfornecedor"
        Me.txtfornecedor.Size = New System.Drawing.Size(327, 24)
        Me.txtfornecedor.TabIndex = 78
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(381, 16)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(65, 24)
        Me.txtcodigo.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 18)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Forma de Pagamento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(195, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 18)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Nº da Nota:"
        '
        'lbdata
        '
        Me.lbdata.AutoSize = True
        Me.lbdata.Location = New System.Drawing.Point(600, 115)
        Me.lbdata.Name = "lbdata"
        Me.lbdata.Size = New System.Drawing.Size(0, 18)
        Me.lbdata.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 18)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Data de Lançamento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 18)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Data de Vencimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Fornecedor:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 18)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Tipo de Conta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(313, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código:"
        '
        'btnconsultar
        '
        Me.btnconsultar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconsultar.Image = CType(resources.GetObject("btnconsultar.Image"), System.Drawing.Image)
        Me.btnconsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconsultar.Location = New System.Drawing.Point(452, 16)
        Me.btnconsultar.Name = "btnconsultar"
        Me.btnconsultar.Size = New System.Drawing.Size(98, 23)
        Me.btnconsultar.TabIndex = 62
        Me.btnconsultar.Text = "Consultar"
        Me.btnconsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnconsultar.UseVisualStyleBackColor = True
        '
        'btnlimpar
        '
        Me.btnlimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpar.Image = CType(resources.GetObject("btnlimpar.Image"), System.Drawing.Image)
        Me.btnlimpar.Location = New System.Drawing.Point(184, 289)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(80, 23)
        Me.btnlimpar.TabIndex = 63
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'btnalterar
        '
        Me.btnalterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnalterar.Image = CType(resources.GetObject("btnalterar.Image"), System.Drawing.Image)
        Me.btnalterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnalterar.Location = New System.Drawing.Point(270, 289)
        Me.btnalterar.Name = "btnalterar"
        Me.btnalterar.Size = New System.Drawing.Size(90, 23)
        Me.btnalterar.TabIndex = 59
        Me.btnalterar.Text = " Alterar"
        Me.btnalterar.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnalterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnalterar.UseVisualStyleBackColor = True
        '
        'btnfiltro
        '
        Me.btnfiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfiltro.Image = CType(resources.GetObject("btnfiltro.Image"), System.Drawing.Image)
        Me.btnfiltro.Location = New System.Drawing.Point(453, 289)
        Me.btnfiltro.Name = "btnfiltro"
        Me.btnfiltro.Size = New System.Drawing.Size(73, 23)
        Me.btnfiltro.TabIndex = 65
        Me.btnfiltro.Text = "Filtro"
        Me.btnfiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnfiltro.UseVisualStyleBackColor = True
        '
        'btnrelatorio
        '
        Me.btnrelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrelatorio.Image = CType(resources.GetObject("btnrelatorio.Image"), System.Drawing.Image)
        Me.btnrelatorio.Location = New System.Drawing.Point(532, 289)
        Me.btnrelatorio.Name = "btnrelatorio"
        Me.btnrelatorio.Size = New System.Drawing.Size(99, 23)
        Me.btnrelatorio.TabIndex = 66
        Me.btnrelatorio.Text = "Relatório"
        Me.btnrelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrelatorio.UseVisualStyleBackColor = True
        '
        'btnexcluir
        '
        Me.btnexcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcluir.Image = CType(resources.GetObject("btnexcluir.Image"), System.Drawing.Image)
        Me.btnexcluir.Location = New System.Drawing.Point(366, 289)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(81, 23)
        Me.btnexcluir.TabIndex = 60
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvar.Image = CType(resources.GetObject("btnsalvar.Image"), System.Drawing.Image)
        Me.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalvar.Location = New System.Drawing.Point(96, 289)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(82, 23)
        Me.btnsalvar.TabIndex = 57
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(813, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'btnnovo
        '
        Me.btnnovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnovo.Image = CType(resources.GetObject("btnnovo.Image"), System.Drawing.Image)
        Me.btnnovo.Location = New System.Drawing.Point(12, 289)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(78, 23)
        Me.btnnovo.TabIndex = 56
        Me.btnnovo.Text = "Novo"
        Me.btnnovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnnovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'btnsair
        '
        Me.btnsair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsair.Image = CType(resources.GetObject("btnsair.Image"), System.Drawing.Image)
        Me.btnsair.Location = New System.Drawing.Point(763, 289)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(62, 23)
        Me.btnsair.TabIndex = 77
        Me.btnsair.Text = "Sair"
        Me.btnsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(836, 327)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnsair)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnlimpar)
        Me.Controls.Add(Me.btnalterar)
        Me.Controls.Add(Me.btnfiltro)
        Me.Controls.Add(Me.btnrelatorio)
        Me.Controls.Add(Me.btnexcluir)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnnovo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form15"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contas  à Pagar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents btnalterar As System.Windows.Forms.Button
    Friend WithEvents btnconsultar As System.Windows.Forms.Button
    Friend WithEvents btnfiltro As System.Windows.Forms.Button
    Friend WithEvents btnrelatorio As System.Windows.Forms.Button
    Friend WithEvents btnexcluir As System.Windows.Forms.Button
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnnovo As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbdata As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnsair As System.Windows.Forms.Button
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtvencimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtpagamento As System.Windows.Forms.ComboBox
    Friend WithEvents txtnota As System.Windows.Forms.TextBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents txttipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtfornecedor As System.Windows.Forms.TextBox
End Class
