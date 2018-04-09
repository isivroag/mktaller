<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmauxinventario
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
        Me.lmedida = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tcant = New System.Windows.Forms.TextBox()
        Me.ttipo = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tobs = New System.Windows.Forms.TextBox()
        Me.tunidad = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.bguardar = New System.Windows.Forms.ToolStripButton()
        Me.bcancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lmedida
        '
        Me.lmedida.AutoSize = True
        Me.lmedida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lmedida.Location = New System.Drawing.Point(220, 72)
        Me.lmedida.Name = "lmedida"
        Me.lmedida.Size = New System.Drawing.Size(123, 15)
        Me.lmedida.TabIndex = 54
        Me.lmedida.Text = "UNIDAD DE MEDIDA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 15)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "CANTIDAD"
        '
        'tcant
        '
        Me.tcant.Location = New System.Drawing.Point(49, 90)
        Me.tcant.Name = "tcant"
        Me.tcant.Size = New System.Drawing.Size(138, 20)
        Me.tcant.TabIndex = 52
        '
        'ttipo
        '
        Me.ttipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ttipo.FormattingEnabled = True
        Me.ttipo.Items.AddRange(New Object() {"1 INVENTARIO INICIAL", "2 ENTRADA", "3 SALIDA"})
        Me.ttipo.Location = New System.Drawing.Point(49, 131)
        Me.ttipo.Name = "ttipo"
        Me.ttipo.Size = New System.Drawing.Size(198, 21)
        Me.ttipo.TabIndex = 56
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 113)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(133, 15)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "TIPO DE MOVIMIENTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "CANTIDAD"
        '
        'tobs
        '
        Me.tobs.Location = New System.Drawing.Point(49, 177)
        Me.tobs.Multiline = True
        Me.tobs.Name = "tobs"
        Me.tobs.Size = New System.Drawing.Size(379, 90)
        Me.tobs.TabIndex = 57
        '
        'tunidad
        '
        Me.tunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tunidad.FormattingEnabled = True
        Me.tunidad.Location = New System.Drawing.Point(238, 89)
        Me.tunidad.Name = "tunidad"
        Me.tunidad.Size = New System.Drawing.Size(183, 21)
        Me.tunidad.TabIndex = 59
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.bguardar, Me.bcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(444, 54)
        Me.ToolStrip1.TabIndex = 60
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'bguardar
        '
        Me.bguardar.Image = Global.SISTALLER.My.Resources.Resources.save
        Me.bguardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bguardar.Name = "bguardar"
        Me.bguardar.Size = New System.Drawing.Size(65, 51)
        Me.bguardar.Text = "GUARDAR"
        Me.bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'bcancelar
        '
        Me.bcancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.bcancelar.Image = Global.SISTALLER.My.Resources.Resources._error
        Me.bcancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.bcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bcancelar.Name = "bcancelar"
        Me.bcancelar.Size = New System.Drawing.Size(71, 51)
        Me.bcancelar.Text = "CANCELAR"
        Me.bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmauxinventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 278)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tunidad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tobs)
        Me.Controls.Add(Me.ttipo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lmedida)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tcant)
        Me.Name = "frmauxinventario"
        Me.Text = "AUTO SPORT: MOVIMIENTO DE INVENTARIO"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lmedida As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tcant As TextBox
    Friend WithEvents ttipo As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tobs As TextBox
    Friend WithEvents tunidad As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bguardar As ToolStripButton
    Friend WithEvents bcancelar As ToolStripButton
End Class
