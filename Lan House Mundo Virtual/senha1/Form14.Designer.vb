<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.txtdata = New System.Windows.Forms.MaskedTextBox()
        Me.txtsexo = New System.Windows.Forms.ComboBox()
        Me.txtcpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtrg = New System.Windows.Forms.MaskedTextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnsair = New System.Windows.Forms.Button()
        Me.txtvalor = New System.Windows.Forms.TextBox()
        Me.btnlimpar = New System.Windows.Forms.Button()
        Me.txtpagamento = New System.Windows.Forms.TextBox()
        Me.txthoras = New System.Windows.Forms.ComboBox()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.lbtroco = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtmaquina = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbdata = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdata
        '
        Me.txtdata.Location = New System.Drawing.Point(400, 84)
        Me.txtdata.Mask = "00/00/0000"
        Me.txtdata.Name = "txtdata"
        Me.txtdata.Size = New System.Drawing.Size(110, 26)
        Me.txtdata.TabIndex = 31
        Me.txtdata.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.txtdata.ValidatingType = GetType(Date)
        '
        'txtsexo
        '
        Me.txtsexo.FormattingEnabled = True
        Me.txtsexo.Items.AddRange(New Object() {"MASCULINO", "FEMININO"})
        Me.txtsexo.Location = New System.Drawing.Point(70, 84)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(132, 28)
        Me.txtsexo.TabIndex = 30
        '
        'txtcpf
        '
        Me.txtcpf.Location = New System.Drawing.Point(586, 48)
        Me.txtcpf.Mask = "000000000-00"
        Me.txtcpf.Name = "txtcpf"
        Me.txtcpf.Size = New System.Drawing.Size(121, 26)
        Me.txtcpf.TabIndex = 29
        Me.txtcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtrg
        '
        Me.txtrg.Location = New System.Drawing.Point(400, 50)
        Me.txtrg.Mask = "00000000-0"
        Me.txtrg.Name = "txtrg"
        Me.txtrg.Size = New System.Drawing.Size(126, 26)
        Me.txtrg.TabIndex = 28
        Me.txtrg.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        '
        'txtnome
        '
        Me.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnome.Location = New System.Drawing.Point(70, 51)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(291, 26)
        Me.txtnome.TabIndex = 27
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(400, 17)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(63, 26)
        Me.txtcodigo.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "RG:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(539, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "CPF:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(241, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Data de Nascimento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Sexo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnsair)
        Me.GroupBox2.Controls.Add(Me.txtvalor)
        Me.GroupBox2.Controls.Add(Me.btnlimpar)
        Me.GroupBox2.Controls.Add(Me.txtpagamento)
        Me.GroupBox2.Controls.Add(Me.txthoras)
        Me.GroupBox2.Controls.Add(Me.btnsalvar)
        Me.GroupBox2.Controls.Add(Me.lbtroco)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtmaquina)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 108)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acesso de Internet"
        '
        'btnsair
        '
        Me.btnsair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsair.Image = CType(resources.GetObject("btnsair.Image"), System.Drawing.Image)
        Me.btnsair.Location = New System.Drawing.Point(307, 72)
        Me.btnsair.Name = "btnsair"
        Me.btnsair.Size = New System.Drawing.Size(62, 23)
        Me.btnsair.TabIndex = 49
        Me.btnsair.Text = "Sair"
        Me.btnsair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsair.UseVisualStyleBackColor = True
        '
        'txtvalor
        '
        Me.txtvalor.Location = New System.Drawing.Point(615, 30)
        Me.txtvalor.Name = "txtvalor"
        Me.txtvalor.Size = New System.Drawing.Size(114, 24)
        Me.txtvalor.TabIndex = 12
        '
        'btnlimpar
        '
        Me.btnlimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpar.Image = CType(resources.GetObject("btnlimpar.Image"), System.Drawing.Image)
        Me.btnlimpar.Location = New System.Drawing.Point(24, 72)
        Me.btnlimpar.Name = "btnlimpar"
        Me.btnlimpar.Size = New System.Drawing.Size(80, 23)
        Me.btnlimpar.TabIndex = 53
        Me.btnlimpar.Text = "Limpar"
        Me.btnlimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlimpar.UseVisualStyleBackColor = True
        '
        'txtpagamento
        '
        Me.txtpagamento.Location = New System.Drawing.Point(445, 30)
        Me.txtpagamento.Name = "txtpagamento"
        Me.txtpagamento.Size = New System.Drawing.Size(93, 24)
        Me.txtpagamento.TabIndex = 11
        '
        'txthoras
        '
        Me.txthoras.FormattingEnabled = True
        Me.txthoras.Items.AddRange(New Object() {"00:00:10", "00:15", "00:30", "01:00", "01:30", "02:00", "02:30", "03:00"})
        Me.txthoras.Location = New System.Drawing.Point(226, 27)
        Me.txthoras.Name = "txthoras"
        Me.txthoras.Size = New System.Drawing.Size(98, 26)
        Me.txthoras.TabIndex = 10
        '
        'btnsalvar
        '
        Me.btnsalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalvar.Image = CType(resources.GetObject("btnsalvar.Image"), System.Drawing.Image)
        Me.btnsalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsalvar.Location = New System.Drawing.Point(120, 72)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(181, 23)
        Me.btnsalvar.TabIndex = 47
        Me.btnsalvar.Text = "Efetuar pagamento"
        Me.btnsalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'lbtroco
        '
        Me.lbtroco.AutoSize = True
        Me.lbtroco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtroco.Location = New System.Drawing.Point(544, 72)
        Me.lbtroco.Name = "lbtroco"
        Me.lbtroco.Size = New System.Drawing.Size(0, 20)
        Me.lbtroco.TabIndex = 9
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(557, 33)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 18)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Valor:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(341, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 18)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Pagamento:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(467, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 24)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Troco:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(155, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(65, 18)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Tempo:"
        '
        'txtmaquina
        '
        Me.txtmaquina.FormattingEnabled = True
        Me.txtmaquina.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.txtmaquina.Location = New System.Drawing.Point(84, 27)
        Me.txtmaquina.Name = "txtmaquina"
        Me.txtmaquina.Size = New System.Drawing.Size(55, 26)
        Me.txtmaquina.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 30)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 18)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Maquina:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(539, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Data:"
        '
        'lbdata
        '
        Me.lbdata.AutoSize = True
        Me.lbdata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdata.Location = New System.Drawing.Point(585, 88)
        Me.lbdata.Name = "lbdata"
        Me.lbdata.Size = New System.Drawing.Size(0, 16)
        Me.lbdata.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbdata)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdata)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtsexo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcpf)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.txtrg)
        Me.GroupBox1.Controls.Add(Me.txtnome)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 125)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações dos Usuários"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(751, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(773, 377)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locação de Internet"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtdata As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtsexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtcpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtrg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtnome As System.Windows.Forms.TextBox
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtvalor As System.Windows.Forms.TextBox
    Friend WithEvents txtpagamento As System.Windows.Forms.TextBox
    Friend WithEvents txthoras As System.Windows.Forms.ComboBox
    Friend WithEvents lbtroco As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtmaquina As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbdata As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnsalvar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnlimpar As System.Windows.Forms.Button
    Friend WithEvents btnsair As System.Windows.Forms.Button
End Class
