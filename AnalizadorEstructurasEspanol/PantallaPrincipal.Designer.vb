<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaPrincipal
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
        Me.btnAdministrar = New System.Windows.Forms.Button()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.pbxDiccionario = New System.Windows.Forms.PictureBox()
        Me.lblAnalizadorEstructuras = New System.Windows.Forms.Label()
        CType(Me.pbxDiccionario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdministrar
        '
        Me.btnAdministrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdministrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrar.ForeColor = System.Drawing.Color.Teal
        Me.btnAdministrar.Location = New System.Drawing.Point(63, 315)
        Me.btnAdministrar.Name = "btnAdministrar"
        Me.btnAdministrar.Size = New System.Drawing.Size(91, 40)
        Me.btnAdministrar.TabIndex = 0
        Me.btnAdministrar.Text = "Administrar"
        Me.btnAdministrar.UseVisualStyleBackColor = False
        '
        'btnExaminar
        '
        Me.btnExaminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.ForeColor = System.Drawing.Color.Teal
        Me.btnExaminar.Location = New System.Drawing.Point(546, 315)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(86, 40)
        Me.btnExaminar.TabIndex = 1
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = False
        '
        'pbxDiccionario
        '
        Me.pbxDiccionario.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.libro_abierto
        Me.pbxDiccionario.Location = New System.Drawing.Point(212, 124)
        Me.pbxDiccionario.Name = "pbxDiccionario"
        Me.pbxDiccionario.Size = New System.Drawing.Size(281, 256)
        Me.pbxDiccionario.TabIndex = 2
        Me.pbxDiccionario.TabStop = False
        '
        'lblAnalizadorEstructuras
        '
        Me.lblAnalizadorEstructuras.AutoSize = True
        Me.lblAnalizadorEstructuras.Font = New System.Drawing.Font("Ravie", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblAnalizadorEstructuras.ForeColor = System.Drawing.Color.Teal
        Me.lblAnalizadorEstructuras.Location = New System.Drawing.Point(-81, 21)
        Me.lblAnalizadorEstructuras.Name = "lblAnalizadorEstructuras"
        Me.lblAnalizadorEstructuras.Size = New System.Drawing.Size(735, 72)
        Me.lblAnalizadorEstructuras.TabIndex = 3
        Me.lblAnalizadorEstructuras.Text = "                Analizador de estructuras " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                                de es" &
    "pañol"
        '
        'PantallaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(725, 422)
        Me.Controls.Add(Me.lblAnalizadorEstructuras)
        Me.Controls.Add(Me.pbxDiccionario)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.btnAdministrar)
        Me.Name = "PantallaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaPrincipal"
        CType(Me.pbxDiccionario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdministrar As Button
    Friend WithEvents btnExaminar As Button
    Friend WithEvents pbxDiccionario As PictureBox
    Friend WithEvents lblAnalizadorEstructuras As Label
End Class
