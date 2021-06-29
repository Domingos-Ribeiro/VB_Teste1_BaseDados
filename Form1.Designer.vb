<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvTeste1 = New System.Windows.Forms.DataGridView()
        Me.btnBuscarProdutos = New System.Windows.Forms.Button()
        Me.btnLimparGrid = New System.Windows.Forms.Button()
        Me.RemoverSelecionado = New System.Windows.Forms.Button()
        Me.txtRemoverSelecionado = New System.Windows.Forms.TextBox()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.txtContar = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNomesGridToList = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnLimpaList = New System.Windows.Forms.Button()
        Me.btnContaNomesList = New System.Windows.Forms.Button()
        Me.btnEliminaProdutoLista = New System.Windows.Forms.Button()
        Me.txtEliminaProdutoLista = New System.Windows.Forms.TextBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.txtContaNomesList = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnAtualizaLinha = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtContaProdutos = New System.Windows.Forms.TextBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dgvTeste1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTeste1
        '
        Me.dgvTeste1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTeste1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTeste1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeste1.GridColor = System.Drawing.Color.CornflowerBlue
        Me.dgvTeste1.Location = New System.Drawing.Point(21, 71)
        Me.dgvTeste1.Name = "dgvTeste1"
        Me.dgvTeste1.Size = New System.Drawing.Size(1002, 284)
        Me.dgvTeste1.TabIndex = 0
        '
        'btnBuscarProdutos
        '
        Me.btnBuscarProdutos.Location = New System.Drawing.Point(12, 11)
        Me.btnBuscarProdutos.Name = "btnBuscarProdutos"
        Me.btnBuscarProdutos.Size = New System.Drawing.Size(237, 23)
        Me.btnBuscarProdutos.TabIndex = 1
        Me.btnBuscarProdutos.Text = "Copia da BD os Produtos para a DataGridView"
        Me.btnBuscarProdutos.UseVisualStyleBackColor = True
        '
        'btnLimparGrid
        '
        Me.btnLimparGrid.Location = New System.Drawing.Point(255, 11)
        Me.btnLimparGrid.Name = "btnLimparGrid"
        Me.btnLimparGrid.Size = New System.Drawing.Size(78, 23)
        Me.btnLimparGrid.TabIndex = 2
        Me.btnLimparGrid.Text = "Limpa a Grid"
        Me.btnLimparGrid.UseVisualStyleBackColor = True
        '
        'RemoverSelecionado
        '
        Me.RemoverSelecionado.Location = New System.Drawing.Point(14, 11)
        Me.RemoverSelecionado.Name = "RemoverSelecionado"
        Me.RemoverSelecionado.Size = New System.Drawing.Size(80, 23)
        Me.RemoverSelecionado.TabIndex = 3
        Me.RemoverSelecionado.Text = "Remover ---->"
        Me.RemoverSelecionado.UseVisualStyleBackColor = True
        '
        'txtRemoverSelecionado
        '
        Me.txtRemoverSelecionado.Location = New System.Drawing.Point(100, 13)
        Me.txtRemoverSelecionado.Name = "txtRemoverSelecionado"
        Me.txtRemoverSelecionado.Size = New System.Drawing.Size(155, 20)
        Me.txtRemoverSelecionado.TabIndex = 4
        '
        'btnContar
        '
        Me.btnContar.Location = New System.Drawing.Point(14, 12)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(113, 23)
        Me.btnContar.TabIndex = 5
        Me.btnContar.Text = "Contar Produtos"
        Me.btnContar.UseVisualStyleBackColor = True
        '
        'txtContar
        '
        Me.txtContar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContar.Location = New System.Drawing.Point(133, 13)
        Me.txtContar.Name = "txtContar"
        Me.txtContar.Size = New System.Drawing.Size(42, 23)
        Me.txtContar.TabIndex = 6
        Me.txtContar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.btnBuscarProdutos)
        Me.Panel1.Controls.Add(Me.btnLimparGrid)
        Me.Panel1.Location = New System.Drawing.Point(21, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 44)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnContar)
        Me.Panel2.Controls.Add(Me.txtContar)
        Me.Panel2.Location = New System.Drawing.Point(831, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 44)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.RemoverSelecionado)
        Me.Panel3.Controls.Add(Me.txtRemoverSelecionado)
        Me.Panel3.Location = New System.Drawing.Point(462, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 45)
        Me.Panel3.TabIndex = 9
        '
        'btnNomesGridToList
        '
        Me.btnNomesGridToList.Location = New System.Drawing.Point(267, 14)
        Me.btnNomesGridToList.Name = "btnNomesGridToList"
        Me.btnNomesGridToList.Size = New System.Drawing.Size(160, 40)
        Me.btnNomesGridToList.TabIndex = 10
        Me.btnNomesGridToList.Text = "Nomes da Grid para a ListBox"
        Me.btnNomesGridToList.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.RadioButton3)
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Controls.Add(Me.RadioButton1)
        Me.Panel4.Location = New System.Drawing.Point(21, 371)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1002, 34)
        Me.Panel4.TabIndex = 11
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(108, 9)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(141, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos da BD para a grid"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(383, 9)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(255, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Da BD para a Grid, apenas com quantidade zero"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel5.Controls.Add(Me.txtContaNomesList)
        Me.Panel5.Controls.Add(Me.ListBox1)
        Me.Panel5.Controls.Add(Me.txtEliminaProdutoLista)
        Me.Panel5.Controls.Add(Me.btnEliminaProdutoLista)
        Me.Panel5.Controls.Add(Me.btnNomesGridToList)
        Me.Panel5.Controls.Add(Me.btnContaNomesList)
        Me.Panel5.Controls.Add(Me.btnLimpaList)
        Me.Panel5.Location = New System.Drawing.Point(21, 419)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(444, 368)
        Me.Panel5.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 14)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(237, 342)
        Me.ListBox1.TabIndex = 13
        '
        'btnLimpaList
        '
        Me.btnLimpaList.Location = New System.Drawing.Point(267, 219)
        Me.btnLimpaList.Name = "btnLimpaList"
        Me.btnLimpaList.Size = New System.Drawing.Size(160, 40)
        Me.btnLimpaList.TabIndex = 14
        Me.btnLimpaList.Text = "Limpar a ListBox"
        Me.btnLimpaList.UseVisualStyleBackColor = True
        '
        'btnContaNomesList
        '
        Me.btnContaNomesList.Location = New System.Drawing.Point(267, 95)
        Me.btnContaNomesList.Name = "btnContaNomesList"
        Me.btnContaNomesList.Size = New System.Drawing.Size(160, 40)
        Me.btnContaNomesList.TabIndex = 15
        Me.btnContaNomesList.Text = "Contar o Nomes"
        Me.btnContaNomesList.UseVisualStyleBackColor = True
        '
        'btnEliminaProdutoLista
        '
        Me.btnEliminaProdutoLista.Location = New System.Drawing.Point(267, 333)
        Me.btnEliminaProdutoLista.Name = "btnEliminaProdutoLista"
        Me.btnEliminaProdutoLista.Size = New System.Drawing.Size(160, 23)
        Me.btnEliminaProdutoLista.TabIndex = 16
        Me.btnEliminaProdutoLista.Text = "Elimina este da Lista"
        Me.btnEliminaProdutoLista.UseVisualStyleBackColor = True
        '
        'txtEliminaProdutoLista
        '
        Me.txtEliminaProdutoLista.Location = New System.Drawing.Point(267, 307)
        Me.txtEliminaProdutoLista.Name = "txtEliminaProdutoLista"
        Me.txtEliminaProdutoLista.Size = New System.Drawing.Size(160, 20)
        Me.txtEliminaProdutoLista.TabIndex = 17
        Me.txtEliminaProdutoLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(796, 9)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(141, 17)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Só o nome dos Produtos"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'txtContaNomesList
        '
        Me.txtContaNomesList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContaNomesList.Location = New System.Drawing.Point(267, 141)
        Me.txtContaNomesList.Multiline = True
        Me.txtContaNomesList.Name = "txtContaNomesList"
        Me.txtContaNomesList.ReadOnly = True
        Me.txtContaNomesList.Size = New System.Drawing.Size(160, 40)
        Me.txtContaNomesList.TabIndex = 18
        Me.txtContaNomesList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel6.Controls.Add(Me.btnAtualizaLinha)
        Me.Panel6.Location = New System.Drawing.Point(481, 419)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(542, 68)
        Me.Panel6.TabIndex = 13
        '
        'btnAtualizaLinha
        '
        Me.btnAtualizaLinha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizaLinha.Location = New System.Drawing.Point(20, 14)
        Me.btnAtualizaLinha.Name = "btnAtualizaLinha"
        Me.btnAtualizaLinha.Size = New System.Drawing.Size(505, 40)
        Me.btnAtualizaLinha.TabIndex = 0
        Me.btnAtualizaLinha.Text = "Atualiza a linha Selecionada da Grid na Base de Dados"
        Me.btnAtualizaLinha.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel7.Controls.Add(Me.txtContaProdutos)
        Me.Panel7.Controls.Add(Me.Button1)
        Me.Panel7.Location = New System.Drawing.Point(481, 504)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(542, 61)
        Me.Panel7.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(451, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Conta os Produtos Diferentes que estão na Base de Dados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtContaProdutos
        '
        Me.txtContaProdutos.Location = New System.Drawing.Point(487, 11)
        Me.txtContaProdutos.Multiline = True
        Me.txtContaProdutos.Name = "txtContaProdutos"
        Me.txtContaProdutos.Size = New System.Drawing.Size(38, 38)
        Me.txtContaProdutos.TabIndex = 1
        Me.txtContaProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel8.Controls.Add(Me.Label4)
        Me.Panel8.Controls.Add(Me.Label3)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.Label1)
        Me.Panel8.Controls.Add(Me.TextBox4)
        Me.Panel8.Controls.Add(Me.TextBox3)
        Me.Panel8.Controls.Add(Me.TextBox2)
        Me.Panel8.Controls.Add(Me.TextBox1)
        Me.Panel8.Location = New System.Drawing.Point(481, 582)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(542, 205)
        Me.Panel8.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(20, 99)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 27)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 99)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(124, 27)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(310, 99)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 27)
        Me.TextBox3.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(455, 99)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(69, 27)
        Me.TextBox4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nome do Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(187, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fornecedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(334, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(421, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Preço"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1043, 804)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvTeste1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VB - Acesso a Base de Dados - Teste 1"
        CType(Me.dgvTeste1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTeste1 As DataGridView
    Friend WithEvents btnBuscarProdutos As Button
    Friend WithEvents btnLimparGrid As Button
    Friend WithEvents RemoverSelecionado As Button
    Friend WithEvents txtRemoverSelecionado As TextBox
    Friend WithEvents btnContar As Button
    Friend WithEvents txtContar As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnNomesGridToList As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnLimpaList As Button
    Friend WithEvents btnContaNomesList As Button
    Friend WithEvents btnEliminaProdutoLista As Button
    Friend WithEvents txtEliminaProdutoLista As TextBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents txtContaNomesList As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnAtualizaLinha As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtContaProdutos As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
