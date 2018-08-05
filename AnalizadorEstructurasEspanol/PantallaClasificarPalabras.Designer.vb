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
        Me.txbPreclasificar = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblPreclasificar = New System.Windows.Forms.Label()
        Me.lvbPalabras = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbPreclasificar
        '
        Me.txbPreclasificar.Location = New System.Drawing.Point(76, 28)
        Me.txbPreclasificar.Name = "txbPreclasificar"
        Me.txbPreclasificar.Size = New System.Drawing.Size(143, 20)
        Me.txbPreclasificar.TabIndex = 1
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
        'lvbPalabras
        '
        Me.lvbPalabras.BackColor = System.Drawing.SystemColors.Control
        Me.lvbPalabras.Location = New System.Drawing.Point(21, 39)
        Me.lvbPalabras.Name = "lvbPalabras"
        Me.lvbPalabras.Size = New System.Drawing.Size(193, 155)
        Me.lvbPalabras.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvbPalabras.TabIndex = 7
        Me.lvbPalabras.UseCompatibleStateImageBehavior = False
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.anadir
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(260, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 31)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "    Añadir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblPreclasificar)
        Me.Panel1.Controls.Add(Me.txbPreclasificar)
        Me.Panel1.Location = New System.Drawing.Point(265, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(333, 100)
        Me.Panel1.TabIndex = 11
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
        'PantallaClasificarPalabras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(729, 298)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvbPalabras)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "PantallaClasificarPalabras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clasificación de palabras"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbPreclasificar As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblPreclasificar As Label
    Friend WithEvents lvbPalabras As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
End Class
