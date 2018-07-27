<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResultadoDelAnalisis
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
        Me.txbVerbos = New System.Windows.Forms.TextBox()
        Me.lblVerbos = New System.Windows.Forms.Label()
        Me.grxResultadoAnalisis = New System.Windows.Forms.GroupBox()
        Me.txbPreposiciones = New System.Windows.Forms.TextBox()
        Me.txbVocales = New System.Windows.Forms.TextBox()
        Me.txbArticulos = New System.Windows.Forms.TextBox()
        Me.lblPreposiciones = New System.Windows.Forms.Label()
        Me.lblVocales = New System.Windows.Forms.Label()
        Me.lblArticulos = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.grxResultadoAnalisis.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbVerbos
        '
        Me.txbVerbos.BackColor = System.Drawing.SystemColors.Control
        Me.txbVerbos.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txbVerbos.Location = New System.Drawing.Point(102, 34)
        Me.txbVerbos.Name = "txbVerbos"
        Me.txbVerbos.ReadOnly = True
        Me.txbVerbos.Size = New System.Drawing.Size(53, 21)
        Me.txbVerbos.TabIndex = 4
        Me.txbVerbos.Text = "0"
        '
        'lblVerbos
        '
        Me.lblVerbos.AutoSize = True
        Me.lblVerbos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerbos.Location = New System.Drawing.Point(6, 34)
        Me.lblVerbos.Name = "lblVerbos"
        Me.lblVerbos.Size = New System.Drawing.Size(48, 15)
        Me.lblVerbos.TabIndex = 1
        Me.lblVerbos.Text = "Verbos:"
        Me.lblVerbos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grxResultadoAnalisis
        '
        Me.grxResultadoAnalisis.Controls.Add(Me.txbPreposiciones)
        Me.grxResultadoAnalisis.Controls.Add(Me.txbVocales)
        Me.grxResultadoAnalisis.Controls.Add(Me.txbArticulos)
        Me.grxResultadoAnalisis.Controls.Add(Me.lblPreposiciones)
        Me.grxResultadoAnalisis.Controls.Add(Me.lblVocales)
        Me.grxResultadoAnalisis.Controls.Add(Me.lblArticulos)
        Me.grxResultadoAnalisis.Controls.Add(Me.lblVerbos)
        Me.grxResultadoAnalisis.Controls.Add(Me.txbVerbos)
        Me.grxResultadoAnalisis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grxResultadoAnalisis.Location = New System.Drawing.Point(67, 41)
        Me.grxResultadoAnalisis.Name = "grxResultadoAnalisis"
        Me.grxResultadoAnalisis.Size = New System.Drawing.Size(251, 218)
        Me.grxResultadoAnalisis.TabIndex = 2
        Me.grxResultadoAnalisis.TabStop = False
        Me.grxResultadoAnalisis.Text = "Resultado del análisis:"
        '
        'txbPreposiciones
        '
        Me.txbPreposiciones.BackColor = System.Drawing.SystemColors.Control
        Me.txbPreposiciones.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbPreposiciones.Location = New System.Drawing.Point(102, 125)
        Me.txbPreposiciones.Name = "txbPreposiciones"
        Me.txbPreposiciones.ReadOnly = True
        Me.txbPreposiciones.Size = New System.Drawing.Size(53, 21)
        Me.txbPreposiciones.TabIndex = 7
        Me.txbPreposiciones.Text = "0"
        '
        'txbVocales
        '
        Me.txbVocales.BackColor = System.Drawing.SystemColors.Control
        Me.txbVocales.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txbVocales.Location = New System.Drawing.Point(102, 96)
        Me.txbVocales.Name = "txbVocales"
        Me.txbVocales.ReadOnly = True
        Me.txbVocales.Size = New System.Drawing.Size(53, 21)
        Me.txbVocales.TabIndex = 6
        Me.txbVocales.Text = "0"
        '
        'txbArticulos
        '
        Me.txbArticulos.BackColor = System.Drawing.SystemColors.Control
        Me.txbArticulos.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txbArticulos.Location = New System.Drawing.Point(102, 65)
        Me.txbArticulos.Name = "txbArticulos"
        Me.txbArticulos.ReadOnly = True
        Me.txbArticulos.Size = New System.Drawing.Size(53, 21)
        Me.txbArticulos.TabIndex = 5
        Me.txbArticulos.Text = "0"
        '
        'lblPreposiciones
        '
        Me.lblPreposiciones.AutoSize = True
        Me.lblPreposiciones.Location = New System.Drawing.Point(6, 128)
        Me.lblPreposiciones.Name = "lblPreposiciones"
        Me.lblPreposiciones.Size = New System.Drawing.Size(88, 15)
        Me.lblPreposiciones.TabIndex = 4
        Me.lblPreposiciones.Text = "Preposiciones:"
        Me.lblPreposiciones.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVocales
        '
        Me.lblVocales.AutoSize = True
        Me.lblVocales.Location = New System.Drawing.Point(6, 96)
        Me.lblVocales.Name = "lblVocales"
        Me.lblVocales.Size = New System.Drawing.Size(53, 15)
        Me.lblVocales.TabIndex = 3
        Me.lblVocales.Text = "Vocales:"
        Me.lblVocales.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblArticulos
        '
        Me.lblArticulos.AutoSize = True
        Me.lblArticulos.Location = New System.Drawing.Point(6, 65)
        Me.lblArticulos.Name = "lblArticulos"
        Me.lblArticulos.Size = New System.Drawing.Size(56, 15)
        Me.lblArticulos.TabIndex = 2
        Me.lblArticulos.Text = "Artículos:"
        Me.lblArticulos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Teal
        Me.btnAceptar.Location = New System.Drawing.Point(142, 279)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(80, 39)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'ResultadoDelAnalisis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(379, 369)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grxResultadoAnalisis)
        Me.Name = "ResultadoDelAnalisis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ResultadoDelAnalisis"
        Me.grxResultadoAnalisis.ResumeLayout(False)
        Me.grxResultadoAnalisis.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txbVerbos As TextBox
    Friend WithEvents lblVerbos As Label
    Friend WithEvents grxResultadoAnalisis As GroupBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblPreposiciones As Label
    Friend WithEvents lblVocales As Label
    Friend WithEvents lblArticulos As Label
    Friend WithEvents txbPreposiciones As TextBox
    Friend WithEvents txbVocales As TextBox
    Friend WithEvents txbArticulos As TextBox
End Class
