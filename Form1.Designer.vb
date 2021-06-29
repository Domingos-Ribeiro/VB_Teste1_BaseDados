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
        Me.btnContaNomesLisa = New System.Windows.Forms.Button()
        Me.btnEliminaSelecLista = New System.Windows.Forms.Button()
        Me.txtEliminaDaLista = New System.Windows.Forms.TextBox()
        CType(Me.dgvTeste1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTeste1
        '
        Me.dgvTeste1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTeste1.Location = New System.Drawing.Point(42, 73)
        Me.dgvTeste1.Name = "dgvTeste1"
        Me.dgvTeste1.Size = New System.Drawing.Size(1002, 294)
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
        Me.Panel1.Location = New System.Drawing.Point(42, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 44)
        Me.Panel1.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnContar)
        Me.Panel2.Controls.Add(Me.txtContar)
        Me.Panel2.Location = New System.Drawing.Point(852, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(192, 44)
        Me.Panel2.TabIndex = 8
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.RemoverSelecionado)
        Me.Panel3.Controls.Add(Me.txtRemoverSelecionado)
        Me.Panel3.Location = New System.Drawing.Point(483, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(269, 45)
        Me.Panel3.TabIndex = 9
        '
        'btnNomesGridToList
        '
        Me.btnNomesGridToList.Location = New System.Drawing.Point(229, 460)
        Me.btnNomesGridToList.Name = "btnNomesGridToList"
        Me.btnNomesGridToList.Size = New System.Drawing.Size(160, 23)
        Me.btnNomesGridToList.TabIndex = 10
        Me.btnNomesGridToList.Text = "Nomes da Grid para a ListBox"
        Me.btnNomesGridToList.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Controls.Add(Me.RadioButton2)
        Me.Panel4.Controls.Add(Me.RadioButton1)
        Me.Panel4.Location = New System.Drawing.Point(42, 373)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1002, 34)
        Me.Panel4.TabIndex = 11
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(441, 9)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(141, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Todos da BG para a grid"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(730, 9)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(255, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Da BD para a Grid, apenas com quantidade zero"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(497, 413)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(547, 100)
        Me.Panel5.TabIndex = 12
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(42, 413)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(181, 368)
        Me.ListBox1.TabIndex = 13
        '
        'btnLimpaList
        '
        Me.btnLimpaList.Location = New System.Drawing.Point(229, 490)
        Me.btnLimpaList.Name = "btnLimpaList"
        Me.btnLimpaList.Size = New System.Drawing.Size(160, 23)
        Me.btnLimpaList.TabIndex = 14
        Me.btnLimpaList.Text = "Limpar a ListBox"
        Me.btnLimpaList.UseVisualStyleBackColor = True
        '
        'btnContaNomesLisa
        '
        Me.btnContaNomesLisa.Location = New System.Drawing.Point(229, 519)
        Me.btnContaNomesLisa.Name = "btnContaNomesLisa"
        Me.btnContaNomesLisa.Size = New System.Drawing.Size(160, 23)
        Me.btnContaNomesLisa.TabIndex = 15
        Me.btnContaNomesLisa.Text = "Contar o Nomes"
        Me.btnContaNomesLisa.UseVisualStyleBackColor = True
        '
        'btnEliminaSelecLista
        '
        Me.btnEliminaSelecLista.Location = New System.Drawing.Point(229, 627)
        Me.btnEliminaSelecLista.Name = "btnEliminaSelecLista"
        Me.btnEliminaSelecLista.Size = New System.Drawing.Size(160, 23)
        Me.btnEliminaSelecLista.TabIndex = 16
        Me.btnEliminaSelecLista.Text = "Elimina este da Lista"
        Me.btnEliminaSelecLista.UseVisualStyleBackColor = True
        '
        'txtEliminaDaLista
        '
        Me.txtEliminaDaLista.Location = New System.Drawing.Point(229, 601)
        Me.txtEliminaDaLista.Name = "txtEliminaDaLista"
        Me.txtEliminaDaLista.Size = New System.Drawing.Size(160, 20)
        Me.txtEliminaDaLista.TabIndex = 17
        Me.txtEliminaDaLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 833)
        Me.Controls.Add(Me.txtEliminaDaLista)
        Me.Controls.Add(Me.btnEliminaSelecLista)
        Me.Controls.Add(Me.btnContaNomesLisa)
        Me.Controls.Add(Me.btnLimpaList)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnNomesGridToList)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvTeste1)
        Me.Name = "Form1"
        Me.Text = "VB - Acesso a Base de Dados - Teste 1"
        CType(Me.dgvTeste1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnContaNomesLisa As Button
    Friend WithEvents btnEliminaSelecLista As Button
    Friend WithEvents txtEliminaDaLista As TextBox
End Class
