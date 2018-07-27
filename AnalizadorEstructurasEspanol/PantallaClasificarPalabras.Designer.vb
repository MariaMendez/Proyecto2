<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaClasificarPalabras
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
        Me.cbxPalabras = New System.Windows.Forms.ComboBox()
        Me.txbPreclasificar = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblPalabras = New System.Windows.Forms.Label()
        Me.lblPreclasificar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxPalabras
        '
        Me.cbxPalabras.FormattingEnabled = True
        Me.cbxPalabras.Location = New System.Drawing.Point(128, 38)
        Me.cbxPalabras.Name = "cbxPalabras"
        Me.cbxPalabras.Size = New System.Drawing.Size(168, 21)
        Me.cbxPalabras.TabIndex = 0
        '
        'txbPreclasificar
        '
        Me.txbPreclasificar.Location = New System.Drawing.Point(508, 39)
        Me.txbPreclasificar.Name = "txbPreclasificar"
        Me.txbPreclasificar.Size = New System.Drawing.Size(143, 20)
        Me.txbPreclasificar.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Teal
        Me.btnGuardar.Location = New System.Drawing.Point(343, 165)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 44)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblPalabras
        '
        Me.lblPalabras.AutoSize = True
        Me.lblPalabras.Location = New System.Drawing.Point(57, 42)
        Me.lblPalabras.Name = "lblPalabras"
        Me.lblPalabras.Size = New System.Drawing.Size(51, 13)
        Me.lblPalabras.TabIndex = 3
        Me.lblPalabras.Text = "Palabras:"
        '
        'lblPreclasificar
        '
        Me.lblPreclasificar.AutoSize = True
        Me.lblPreclasificar.Location = New System.Drawing.Point(412, 43)
        Me.lblPreclasificar.Name = "lblPreclasificar"
        Me.lblPreclasificar.Size = New System.Drawing.Size(67, 13)
        Me.lblPreclasificar.TabIndex = 4
        Me.lblPreclasificar.Text = "Preclasificar:"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(343, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 98)
        Me.Label3.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txbPreclasificar)
        Me.Panel1.Controls.Add(Me.lblPreclasificar)
        Me.Panel1.Controls.Add(Me.cbxPalabras)
        Me.Panel1.Controls.Add(Me.lblPalabras)
        Me.Panel1.ForeColor = System.Drawing.Color.Teal
        Me.Panel1.Location = New System.Drawing.Point(29, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 98)
        Me.Panel1.TabIndex = 6
        '
        'PantallaClasificarPalabras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(760, 244)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "PantallaClasificarPalabras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación de palabras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxPalabras As ComboBox
    Friend WithEvents txbPreclasificar As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblPalabras As Label
    Friend WithEvents lblPreclasificar As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
End Class
