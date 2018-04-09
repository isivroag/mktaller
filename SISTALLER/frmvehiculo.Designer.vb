<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmvehiculo
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ttipom = New System.Windows.Forms.ComboBox()
        Me.tsubmarca = New System.Windows.Forms.ComboBox()
        Me.tmarca = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tcliente = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ttipo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tmotor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tobs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.taño = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tserie = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tgasolina = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcolor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tplaca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bcancelar = New System.Windows.Forms.Button()
        Me.bguardar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.ttipom)
        Me.Panel1.Controls.Add(Me.tsubmarca)
        Me.Panel1.Controls.Add(Me.tmarca)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.tcliente)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ttipo)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.tmotor)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.tobs)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.taño)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tserie)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tgasolina)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tcolor)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.tplaca)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tid)
        Me.Panel1.Location = New System.Drawing.Point(5, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 399)
        Me.Panel1.TabIndex = 9
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(479, 199)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 11)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "NUEVO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(442, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 11)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "BUSCAR"
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.SISTALLER.My.Resources.Resources.agre1
        Me.PictureBox2.Location = New System.Drawing.Point(480, 213)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'ttipom
        '
        Me.ttipom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ttipom.FormattingEnabled = True
        Me.ttipom.Location = New System.Drawing.Point(390, 71)
        Me.ttipom.Name = "ttipom"
        Me.ttipom.Size = New System.Drawing.Size(121, 21)
        Me.ttipom.TabIndex = 37
        '
        'tsubmarca
        '
        Me.tsubmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsubmarca.FormattingEnabled = True
        Me.tsubmarca.Location = New System.Drawing.Point(219, 71)
        Me.tsubmarca.Name = "tsubmarca"
        Me.tsubmarca.Size = New System.Drawing.Size(128, 21)
        Me.tsubmarca.TabIndex = 36
        '
        'tmarca
        '
        Me.tmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tmarca.FormattingEnabled = True
        Me.tmarca.Location = New System.Drawing.Point(52, 71)
        Me.tmarca.Name = "tmarca"
        Me.tmarca.Size = New System.Drawing.Size(124, 21)
        Me.tmarca.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(378, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 15)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "*TIPO DE MOTOR"
        '
        'tcliente
        '
        Me.tcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tcliente.FormattingEnabled = True
        Me.tcliente.Location = New System.Drawing.Point(52, 220)
        Me.tcliente.Name = "tcliente"
        Me.tcliente.Size = New System.Drawing.Size(386, 21)
        Me.tcliente.TabIndex = 32
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.SISTALLER.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(444, 213)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'ttipo
        '
        Me.ttipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ttipo.FormattingEnabled = True
        Me.ttipo.Location = New System.Drawing.Point(219, 163)
        Me.ttipo.Name = "ttipo"
        Me.ttipo.Size = New System.Drawing.Size(128, 21)
        Me.ttipo.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "No. MOTOR"
        '
        'tmotor
        '
        Me.tmotor.Location = New System.Drawing.Point(52, 164)
        Me.tmotor.Name = "tmotor"
        Me.tmotor.Size = New System.Drawing.Size(124, 20)
        Me.tmotor.TabIndex = 28
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(195, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 15)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "*SUBMARCA"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "OBSERVACIONES"
        '
        'tobs
        '
        Me.tobs.Location = New System.Drawing.Point(52, 275)
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.Size = New System.Drawing.Size(459, 114)
        Me.tobs.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 203)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "*CLIENTE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "*AÑO"
        '
        'taño
        '
        Me.taño.Location = New System.Drawing.Point(52, 111)
        Me.taño.Name = "taño"
        Me.taño.Size = New System.Drawing.Size(124, 20)
        Me.taño.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(378, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "*No. SERIE"
        '
        'tserie
        '
        Me.tserie.Location = New System.Drawing.Point(389, 25)
        Me.tserie.MaxLength = 17
        Me.tserie.Name = "tserie"
        Me.tserie.Size = New System.Drawing.Size(121, 20)
        Me.tserie.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "*TIPO DE VEHICULO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(378, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "GASOLINA"
        '
        'tgasolina
        '
        Me.tgasolina.Location = New System.Drawing.Point(389, 111)
        Me.tgasolina.Name = "tgasolina"
        Me.tgasolina.Size = New System.Drawing.Size(121, 20)
        Me.tgasolina.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(195, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "*COLOR"
        '
        'tcolor
        '
        Me.tcolor.Location = New System.Drawing.Point(219, 111)
        Me.tcolor.Name = "tcolor"
        Me.tcolor.Size = New System.Drawing.Size(127, 20)
        Me.tcolor.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "*MARCA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(195, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "*PLACA"
        '
        'tplaca
        '
        Me.tplaca.Location = New System.Drawing.Point(219, 25)
        Me.tplaca.Name = "tplaca"
        Me.tplaca.Size = New System.Drawing.Size(127, 20)
        Me.tplaca.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ID VEHICULO"
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(52, 25)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(124, 20)
        Me.tid.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 43)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "VEHICULOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'bcancelar
        '
        Me.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bcancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancelar.Image = Global.SISTALLER.My.Resources.Resources.stop_error
        Me.bcancelar.Location = New System.Drawing.Point(410, 6)
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(122, 46)
        Me.bcancelar.TabIndex = 11
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bcancelar.UseVisualStyleBackColor = False
        '
        'bguardar
        '
        Me.bguardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bguardar.Image = Global.SISTALLER.My.Resources.Resources.save
        Me.bguardar.Location = New System.Drawing.Point(4, 6)
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(106, 46)
        Me.bguardar.TabIndex = 10
        Me.bguardar.Text = "GUARDAR"
        Me.bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bguardar.UseVisualStyleBackColor = True
        '
        'frmvehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 464)
        Me.Controls.Add(Me.bcancelar)
        Me.Controls.Add(Me.bguardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmvehiculo"
        Me.Text = "AUTO SPORT: VEHICULOS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bcancelar As Button
    Friend WithEvents bguardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents tobs As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents taño As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tserie As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tgasolina As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tcolor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tplaca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tmotor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ttipo As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tcliente As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tsubmarca As ComboBox
    Friend WithEvents tmarca As ComboBox
    Friend WithEvents ttipom As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
