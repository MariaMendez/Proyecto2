<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PantallaGuardarResultado
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
        Me.lblTítulo = New System.Windows.Forms.Label()
        Me.btnXML = New System.Windows.Forms.Button()
        Me.btnJason = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTítulo
        '
        Me.lblTítulo.AutoSize = True
        Me.lblTítulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítulo.ForeColor = System.Drawing.Color.Teal
        Me.lblTítulo.Location = New System.Drawing.Point(82, 36)
        Me.lblTítulo.Name = "lblTítulo"
        Me.lblTítulo.Size = New System.Drawing.Size(288, 15)
        Me.lblTítulo.TabIndex = 0
        Me.lblTítulo.Text = "¿En qué formato desea guardar el análisis?"
        '
        'btnXML
        '
        Me.btnXML.BackColor = System.Drawing.SystemColors.Control
        Me.btnXML.Location = New System.Drawing.Point(85, 84)
        Me.btnXML.Name = "btnXML"
        Me.btnXML.Size = New System.Drawing.Size(78, 32)
        Me.btnXML.TabIndex = 1
        Me.btnXML.Text = "XML"
        Me.btnXML.UseVisualStyleBackColor = False
        '
        'btnJason
        '
        Me.btnJason.BackColor = System.Drawing.SystemColors.Control
        Me.btnJason.Location = New System.Drawing.Point(293, 84)
        Me.btnJason.Name = "btnJason"
        Me.btnJason.Size = New System.Drawing.Size(77, 32)
        Me.btnJason.TabIndex = 2
        Me.btnJason.Text = "JASON"
        Me.btnJason.UseVisualStyleBackColor = False
        '
        'PantallaGuardarResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(466, 150)
        Me.Controls.Add(Me.btnJason)
        Me.Controls.Add(Me.btnXML)
        Me.Controls.Add(Me.lblTítulo)
        Me.Name = "PantallaGuardarResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PantallaGuardarResultado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTítulo As Label
    Friend WithEvents btnXML As Button
    Friend WithEvents btnJason As Button
End Class
