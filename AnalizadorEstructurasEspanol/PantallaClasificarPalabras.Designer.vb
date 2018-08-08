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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblPreclasificar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxEstructuras = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbxPalabras = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnGuardar.ForeColor = System.Drawing.Color.Teal
        Me.btnGuardar.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.salida
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(640, 248)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(77, 38)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Salir"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'lblPreclasificar
        '
        Me.lblPreclasificar.AutoSize = True
        Me.lblPreclasificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreclasificar.Location = New System.Drawing.Point(12, 31)
        Me.lblPreclasificar.Name = "lblPreclasificar"
        Me.lblPreclasificar.Size = New System.Drawing.Size(58, 13)
        Me.lblPreclasificar.TabIndex = 4
        Me.lblPreclasificar.Text = "Estructura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(21, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Palabras sin clasificar:"
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.SystemColors.Control
        Me.btnAñadir.ForeColor = System.Drawing.Color.Teal
        Me.btnAñadir.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.anadir
        Me.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAñadir.Location = New System.Drawing.Point(260, 62)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(66, 31)
        Me.btnAñadir.TabIndex = 9
        Me.btnAñadir.Text = "    Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cbxEstructuras)
        Me.Panel1.Controls.Add(Me.btnAñadir)
        Me.Panel1.Controls.Add(Me.lblPreclasificar)
        Me.Panel1.Location = New System.Drawing.Point(265, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 100)
        Me.Panel1.TabIndex = 11
        '
        'cbxEstructuras
        '
        Me.cbxEstructuras.FormattingEnabled = True
        Me.cbxEstructuras.Location = New System.Drawing.Point(93, 31)
        Me.cbxEstructuras.Name = "cbxEstructuras"
        Me.cbxEstructuras.Size = New System.Drawing.Size(135, 21)
        Me.cbxEstructuras.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(262, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Preclasificación:"
        '
        'lbxPalabras
        '
        Me.lbxPalabras.BackColor = System.Drawing.SystemColors.Control
        Me.lbxPalabras.FormattingEnabled = True
        Me.lbxPalabras.Location = New System.Drawing.Point(24, 39)
        Me.lbxPalabras.Name = "lbxPalabras"
        Me.lbxPalabras.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbxPalabras.Size = New System.Drawing.Size(184, 160)
        Me.lbxPalabras.TabIndex = 0
        '
        'PantallaClasificarPalabras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(729, 298)
        Me.Controls.Add(Me.lbxPalabras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "PantallaClasificarPalabras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación de palabras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblPreclasificar As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxEstructuras As ComboBox
    Friend WithEvents lbxPalabras As ListBox
End Class
