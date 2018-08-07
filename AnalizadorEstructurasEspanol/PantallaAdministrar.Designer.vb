<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaAdministrar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaAdministrar))
        Me.cbxEstructuras = New System.Windows.Forms.ComboBox()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.lblEstructura = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEstructuras = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvEstructuras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxEstructuras
        '
        Me.cbxEstructuras.FormattingEnabled = True
        Me.cbxEstructuras.Location = New System.Drawing.Point(79, 16)
        Me.cbxEstructuras.Name = "cbxEstructuras"
        Me.cbxEstructuras.Size = New System.Drawing.Size(144, 21)
        Me.cbxEstructuras.TabIndex = 0
        Me.cbxEstructuras.Text = "SELECCIONAR"
        '
        'txtPalabra
        '
        Me.txtPalabra.Location = New System.Drawing.Point(79, 51)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(144, 20)
        Me.txtPalabra.TabIndex = 1
        '
        'lblEstructura
        '
        Me.lblEstructura.AutoSize = True
        Me.lblEstructura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstructura.ForeColor = System.Drawing.Color.Teal
        Me.lblEstructura.Location = New System.Drawing.Point(3, 16)
        Me.lblEstructura.Name = "lblEstructura"
        Me.lblEstructura.Size = New System.Drawing.Size(70, 16)
        Me.lblEstructura.TabIndex = 3
        Me.lblEstructura.Text = "Estructura:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Palabra:"
        '
        'dgvEstructuras
        '
        Me.dgvEstructuras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstructuras.Location = New System.Drawing.Point(1, 212)
        Me.dgvEstructuras.Name = "dgvEstructuras"
        Me.dgvEstructuras.Size = New System.Drawing.Size(726, 232)
        Me.dgvEstructuras.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblEstructura)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.cbxEstructuras)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.txtPalabra)
        Me.Panel1.Controls.Add(Me.btnAñadir)
        Me.Panel1.Location = New System.Drawing.Point(21, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(466, 126)
        Me.Panel1.TabIndex = 9
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.SystemColors.Control
        Me.btnBuscar.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.lupa_para_buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(325, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 25)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.Text = "   Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.SystemColors.Control
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(325, 38)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 25)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "    Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.SystemColors.Control
        Me.btnAñadir.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.anadir
        Me.btnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAñadir.Location = New System.Drawing.Point(325, 6)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(75, 26)
        Me.btnAñadir.TabIndex = 2
        Me.btnAñadir.Text = "   Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.pregunta
        Me.PictureBox1.Location = New System.Drawing.Point(549, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 126)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Image = Global.AnalizadorEstructurasEspanol.My.Resources.Resources.salida
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(641, 174)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(73, 32)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir:"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PantallaAdministrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(726, 372)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvEstructuras)
        Me.Name = "PantallaAdministrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrador Estructuras"
        CType(Me.dgvEstructuras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cbxEstructuras As ComboBox
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents lblEstructura As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEstructuras As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
