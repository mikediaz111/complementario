<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ALUMNOS
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btmBuscar = New System.Windows.Forms.Button()
        Me.btmlimpiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radioF = New System.Windows.Forms.RadioButton()
        Me.radioM = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.txtape = New System.Windows.Forms.TextBox()
        Me.txtdir = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.btmeliminar = New System.Windows.Forms.Button()
        Me.btmactualizar = New System.Windows.Forms.Button()
        Me.btmregistrar = New System.Windows.Forms.Button()
        Me.lvAlumnos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(47, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDAlumno:"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(158, 56)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(87, 31)
        Me.txtid.TabIndex = 1
        '
        'btmBuscar
        '
        Me.btmBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btmBuscar.Location = New System.Drawing.Point(279, 56)
        Me.btmBuscar.Name = "btmBuscar"
        Me.btmBuscar.Size = New System.Drawing.Size(112, 34)
        Me.btmBuscar.TabIndex = 2
        Me.btmBuscar.Text = "BUSCAR"
        Me.btmBuscar.UseVisualStyleBackColor = True
        '
        'btmlimpiar
        '
        Me.btmlimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btmlimpiar.Location = New System.Drawing.Point(411, 56)
        Me.btmlimpiar.Name = "btmlimpiar"
        Me.btmlimpiar.Size = New System.Drawing.Size(112, 34)
        Me.btmlimpiar.TabIndex = 3
        Me.btmlimpiar.Text = "LIMPIAR"
        Me.btmlimpiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(47, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(47, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(47, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Direccion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(47, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Telefono:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(47, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Sexo:"
        '
        'radioF
        '
        Me.radioF.AutoSize = True
        Me.radioF.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioF.Location = New System.Drawing.Point(232, 333)
        Me.radioF.Name = "radioF"
        Me.radioF.Size = New System.Drawing.Size(47, 29)
        Me.radioF.TabIndex = 9
        Me.radioF.TabStop = True
        Me.radioF.Text = "F"
        Me.radioF.UseVisualStyleBackColor = True
        '
        'radioM
        '
        Me.radioM.AutoSize = True
        Me.radioM.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioM.Location = New System.Drawing.Point(158, 333)
        Me.radioM.Name = "radioM"
        Me.radioM.Size = New System.Drawing.Size(55, 29)
        Me.radioM.TabIndex = 10
        Me.radioM.TabStop = True
        Me.radioM.Text = "M"
        Me.radioM.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(47, 385)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Edad:"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(158, 112)
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(365, 31)
        Me.txtnom.TabIndex = 12
        '
        'txtape
        '
        Me.txtape.Location = New System.Drawing.Point(158, 172)
        Me.txtape.Name = "txtape"
        Me.txtape.Size = New System.Drawing.Size(365, 31)
        Me.txtape.TabIndex = 13
        '
        'txtdir
        '
        Me.txtdir.Location = New System.Drawing.Point(158, 234)
        Me.txtdir.Name = "txtdir"
        Me.txtdir.Size = New System.Drawing.Size(365, 31)
        Me.txtdir.TabIndex = 14
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(158, 286)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(187, 31)
        Me.txttelefono.TabIndex = 15
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(158, 384)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(187, 31)
        Me.txtedad.TabIndex = 16
        '
        'btmeliminar
        '
        Me.btmeliminar.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btmeliminar.Location = New System.Drawing.Point(375, 460)
        Me.btmeliminar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btmeliminar.Name = "btmeliminar"
        Me.btmeliminar.Size = New System.Drawing.Size(152, 47)
        Me.btmeliminar.TabIndex = 38
        Me.btmeliminar.Text = "ELIMINAR"
        Me.btmeliminar.UseVisualStyleBackColor = True
        '
        'btmactualizar
        '
        Me.btmactualizar.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btmactualizar.Location = New System.Drawing.Point(218, 460)
        Me.btmactualizar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btmactualizar.Name = "btmactualizar"
        Me.btmactualizar.Size = New System.Drawing.Size(149, 47)
        Me.btmactualizar.TabIndex = 37
        Me.btmactualizar.Text = "ACTUALIZAR"
        Me.btmactualizar.UseVisualStyleBackColor = True
        '
        'btmregistrar
        '
        Me.btmregistrar.Font = New System.Drawing.Font("Segoe UI", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.btmregistrar.Location = New System.Drawing.Point(58, 460)
        Me.btmregistrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btmregistrar.Name = "btmregistrar"
        Me.btmregistrar.Size = New System.Drawing.Size(152, 47)
        Me.btmregistrar.TabIndex = 36
        Me.btmregistrar.Text = "REGISTRAR"
        Me.btmregistrar.UseVisualStyleBackColor = True
        '
        'lvAlumnos
        '
        Me.lvAlumnos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader3, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvAlumnos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lvAlumnos.FullRowSelect = True
        Me.lvAlumnos.GridLines = True
        Me.lvAlumnos.HideSelection = False
        Me.lvAlumnos.Location = New System.Drawing.Point(555, 113)
        Me.lvAlumnos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lvAlumnos.Name = "lvAlumnos"
        Me.lvAlumnos.Size = New System.Drawing.Size(1180, 580)
        Me.lvAlumnos.TabIndex = 39
        Me.lvAlumnos.UseCompatibleStateImageBehavior = False
        Me.lvAlumnos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 50
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 175
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Apellido"
        Me.ColumnHeader4.Width = 175
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Direccion"
        Me.ColumnHeader3.Width = 250
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telefono"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Sexo"
        Me.ColumnHeader6.Width = 80
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Edad"
        Me.ColumnHeader7.Width = 80
        '
        'ALUMNOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1734, 873)
        Me.Controls.Add(Me.lvAlumnos)
        Me.Controls.Add(Me.btmeliminar)
        Me.Controls.Add(Me.btmactualizar)
        Me.Controls.Add(Me.btmregistrar)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtdir)
        Me.Controls.Add(Me.txtape)
        Me.Controls.Add(Me.txtnom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.radioM)
        Me.Controls.Add(Me.radioF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btmlimpiar)
        Me.Controls.Add(Me.btmBuscar)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ALUMNOS"
        Me.Text = "ALUMNOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents btmBuscar As Button
    Friend WithEvents btmlimpiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents radioF As RadioButton
    Friend WithEvents radioM As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents txtnom As TextBox
    Friend WithEvents txtape As TextBox
    Friend WithEvents txtdir As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents btmeliminar As Button
    Friend WithEvents btmactualizar As Button
    Friend WithEvents btmregistrar As Button
    Friend WithEvents lvAlumnos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
