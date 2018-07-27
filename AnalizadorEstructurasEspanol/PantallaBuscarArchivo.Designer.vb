<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaBuscarArchivo
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
        Me.btnBuscarFolder = New System.Windows.Forms.Button()
        Me.lblAnalizadorEstructuras = New System.Windows.Forms.Label()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txbRuta = New System.Windows.Forms.TextBox()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarFolder
        '
        Me.btnBuscarFolder.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscarFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFolder.ForeColor = System.Drawing.Color.Teal
        Me.btnBuscarFolder.Location = New System.Drawing.Point(398, 223)
        Me.btnBuscarFolder.Name = "btnBuscarFolder"
        Me.btnBuscarFolder.Size = New System.Drawing.Size(97, 44)
        Me.btnBuscarFolder.TabIndex = 0
        Me.btnBuscarFolder.Text = "Buscar archivo"
        Me.btnBuscarFolder.UseVisualStyleBackColor = False
        '
        'lblAnalizadorEstructuras
        '
        Me.lblAnalizadorEstructuras.AutoSize = True
        Me.lblAnalizadorEstructuras.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnalizadorEstructuras.ForeColor = System.Drawing.Color.Teal
        Me.lblAnalizadorEstructuras.Location = New System.Drawing.Point(-117, 26)
        Me.lblAnalizadorEstructuras.Name = "lblAnalizadorEstructuras"
        Me.lblAnalizadorEstructuras.Size = New System.Drawing.Size(723, 72)
        Me.lblAnalizadorEstructuras.TabIndex = 3
        Me.lblAnalizadorEstructuras.Text = "                Analizador de estructuras" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "            de Español"
        Me.lblAnalizadorEstructuras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAnalizadorEstructuras.UseMnemonic = False
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.Teal
        Me.btnExaminar.Location = New System.Drawing.Point(523, 380)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(83, 34)
        Me.btnExaminar.TabIndex = 4
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Text File (.txt)|*.txt|Word File (.docx ,.doc)|*.docx;*.doc"
        Me.OpenFileDialog1.FilterIndex = 0
        '
        'txbRuta
        '
        Me.txbRuta.Location = New System.Drawing.Point(97, 388)
        Me.txbRuta.Name = "txbRuta"
        Me.txbRuta.ReadOnly = True
        Me.txbRuta.Size = New System.Drawing.Size(407, 20)
        Me.txbRuta.TabIndex = 5
        '
        'lblRuta
        '
        Me.lblRuta.AutoSize = True
        Me.lblRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRuta.Location = New System.Drawing.Point(50, 387)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(41, 15)
        Me.lblRuta.TabIndex = 6
        Me.lblRuta.Text = "Ruta:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.libro_abierto_300x207
        Me.PictureBox1.Location = New System.Drawing.Point(53, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 242)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PantallaBuscarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.txbRuta)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.lblAnalizadorEstructuras)
        Me.Controls.Add(Me.btnBuscarFolder)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "PantallaBuscarArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analizador estructuras español"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarFolder As Button
    Friend WithEvents lblAnalizadorEstructuras As Label
    Friend WithEvents btnExaminar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txbRuta As TextBox
    Friend WithEvents lblRuta As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
