<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.temail = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ttel = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tcel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tcol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tdir = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tedo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tcd = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tnombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.trfc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.bcancelar = New System.Windows.Forms.Button()
        Me.bguardar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 43)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CLIENTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.temail)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.ttel)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.tcel)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.tcol)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tdir)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.tedo)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.tcd)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.tcp)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tnombre)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.trfc)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tid)
        Me.Panel1.Location = New System.Drawing.Point(7, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 317)
        Me.Panel1.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(135, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "CORREO ELECTRONICO"
        '
        'temail
        '
        Me.temail.Location = New System.Drawing.Point(52, 275)
        Me.temail.Name = "temail"
        Me.temail.Size = New System.Drawing.Size(425, 20)
        Me.temail.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(253, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "TEL FIJO"
        '
        'ttel
        '
        Me.ttel.Location = New System.Drawing.Point(289, 234)
        Me.ttel.Name = "ttel"
        Me.ttel.Size = New System.Drawing.Size(188, 20)
        Me.ttel.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(16, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "*TEL MOVIL"
        '
        'tcel
        '
        Me.tcel.Location = New System.Drawing.Point(52, 234)
        Me.tcel.Name = "tcel"
        Me.tcel.Size = New System.Drawing.Size(188, 20)
        Me.tcel.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "COLONIA"
        '
        'tcol
        '
        Me.tcol.Location = New System.Drawing.Point(52, 152)
        Me.tcol.Name = "tcol"
        Me.tcol.Size = New System.Drawing.Size(248, 20)
        Me.tcol.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "DIRECCION"
        '
        'tdir
        '
        Me.tdir.Location = New System.Drawing.Point(52, 112)
        Me.tdir.Name = "tdir"
        Me.tdir.Size = New System.Drawing.Size(425, 20)
        Me.tdir.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(253, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 15)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "ESTADO"
        '
        'tedo
        '
        Me.tedo.Location = New System.Drawing.Point(289, 193)
        Me.tedo.Name = "tedo"
        Me.tedo.Size = New System.Drawing.Size(188, 20)
        Me.tedo.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "CIUDAD"
        '
        'tcd
        '
        Me.tcd.Location = New System.Drawing.Point(52, 193)
        Me.tcd.Name = "tcd"
        Me.tcd.Size = New System.Drawing.Size(188, 20)
        Me.tcd.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(348, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "CP"
        '
        'tcp
        '
        Me.tcp.Location = New System.Drawing.Point(377, 152)
        Me.tcp.Name = "tcp"
        Me.tcp.Size = New System.Drawing.Size(100, 20)
        Me.tcp.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "*NOMBRE"
        '
        'tnombre
        '
        Me.tnombre.Location = New System.Drawing.Point(52, 70)
        Me.tnombre.Name = "tnombre"
        Me.tnombre.Size = New System.Drawing.Size(425, 20)
        Me.tnombre.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "RFC"
        '
        'trfc
        '
        Me.trfc.Location = New System.Drawing.Point(377, 27)
        Me.trfc.Name = "trfc"
        Me.trfc.Size = New System.Drawing.Size(100, 20)
        Me.trfc.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CLAVE DE CLIENTE"
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(52, 25)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(100, 20)
        Me.tid.TabIndex = 4
        '
        'bcancelar
        '
        Me.bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bcancelar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcancelar.Image = Global.SISTALLER.My.Resources.Resources.stop_error
        Me.bcancelar.Location = New System.Drawing.Point(384, 12)
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(122, 46)
        Me.bcancelar.TabIndex = 7
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bcancelar.UseVisualStyleBackColor = False
        '
        'bguardar
        '
        Me.bguardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bguardar.Image = Global.SISTALLER.My.Resources.Resources.save
        Me.bguardar.Location = New System.Drawing.Point(6, 12)
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(106, 46)
        Me.bguardar.TabIndex = 6
        Me.bguardar.Text = "GUARDAR"
        Me.bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bguardar.UseVisualStyleBackColor = True
        '
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 389)
        Me.Controls.Add(Me.bcancelar)
        Me.Controls.Add(Me.bguardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmcliente"
        Me.Text = "AUTO SPORT: CLIENTES"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents tnombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents trfc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents bguardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tedo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tcd As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tcp As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents temail As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ttel As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tcel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tcol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tdir As TextBox
    Friend WithEvents bcancelar As Button
End Class
