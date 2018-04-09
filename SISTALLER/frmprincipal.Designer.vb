<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.mncliente = New System.Windows.Forms.ToolStripButton()
        Me.mnvehiculo = New System.Windows.Forms.ToolStripButton()
        Me.mnsalir = New System.Windows.Forms.ToolStripButton()
        Me.mnitem = New System.Windows.Forms.ToolStripButton()
        Me.mninventario = New System.Windows.Forms.ToolStripButton()
        Me.mnorden = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CATALOGOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MARCASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBMARCASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIPOSDEVEHICULOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TIPOSDEMOTORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLASESDEPRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBCLASESDEPRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LINEADEPRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UNIDADESDEMEDIDAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVENTARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOVIMIENTOSDEINVENTARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONSULTADEINVENTARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SERVICIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENTRADAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mncliente, Me.mnvehiculo, Me.mnsalir, Me.mnitem, Me.mninventario, Me.mnorden})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(1008, 54)
        Me.ToolStrip.Stretch = True
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'mncliente
        '
        Me.mncliente.Image = Global.SISTALLER.My.Resources.Resources.users
        Me.mncliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mncliente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mncliente.Name = "mncliente"
        Me.mncliente.Size = New System.Drawing.Size(56, 51)
        Me.mncliente.Text = "CLIENTE"
        Me.mncliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mncliente.ToolTipText = "CLIENTE"
        '
        'mnvehiculo
        '
        Me.mnvehiculo.AutoSize = False
        Me.mnvehiculo.Image = Global.SISTALLER.My.Resources.Resources.car_32
        Me.mnvehiculo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnvehiculo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnvehiculo.Name = "mnvehiculo"
        Me.mnvehiculo.Size = New System.Drawing.Size(67, 51)
        Me.mnvehiculo.Text = "VEHICULO"
        Me.mnvehiculo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnsalir
        '
        Me.mnsalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mnsalir.Image = Global.SISTALLER.My.Resources.Resources.salir
        Me.mnsalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnsalir.Name = "mnsalir"
        Me.mnsalir.Size = New System.Drawing.Size(41, 51)
        Me.mnsalir.Text = "SALIR"
        Me.mnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnitem
        '
        Me.mnitem.Image = Global.SISTALLER.My.Resources.Resources.pieza3_2
        Me.mnitem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnitem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnitem.Name = "mnitem"
        Me.mnitem.Size = New System.Drawing.Size(80, 51)
        Me.mnitem.Text = "PROD. & SERV."
        Me.mnitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mninventario
        '
        Me.mninventario.Image = Global.SISTALLER.My.Resources.Resources.PIEZAS552
        Me.mninventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mninventario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mninventario.Name = "mninventario"
        Me.mninventario.Size = New System.Drawing.Size(128, 51)
        Me.mninventario.Text = "MOV. DE INVENTARIO"
        Me.mninventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnorden
        '
        Me.mnorden.Image = Global.SISTALLER.My.Resources.Resources.SERV
        Me.mnorden.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.mnorden.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.mnorden.Name = "mnorden"
        Me.mnorden.Size = New System.Drawing.Size(102, 51)
        Me.mnorden.Text = "ORDEN SERVICIO"
        Me.mnorden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.mnorden.ToolTipText = "ORDEN SERVICIO"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 602)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1008, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CATALOGOSToolStripMenuItem, Me.INVENTARIOToolStripMenuItem, Me.SERVICIOToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CATALOGOSToolStripMenuItem
        '
        Me.CATALOGOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MARCASToolStripMenuItem, Me.SUBMARCASToolStripMenuItem, Me.TIPOSDEVEHICULOSToolStripMenuItem, Me.TIPOSDEMOTORToolStripMenuItem, Me.CLASESDEPRODUCTOSToolStripMenuItem, Me.SUBCLASESDEPRODUCTOSToolStripMenuItem, Me.LINEADEPRODUCTOSToolStripMenuItem, Me.UNIDADESDEMEDIDAToolStripMenuItem})
        Me.CATALOGOSToolStripMenuItem.Name = "CATALOGOSToolStripMenuItem"
        Me.CATALOGOSToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.CATALOGOSToolStripMenuItem.Text = "CATALOGOS"
        '
        'MARCASToolStripMenuItem
        '
        Me.MARCASToolStripMenuItem.Name = "MARCASToolStripMenuItem"
        Me.MARCASToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.MARCASToolStripMenuItem.Text = "MARCAS"
        '
        'SUBMARCASToolStripMenuItem
        '
        Me.SUBMARCASToolStripMenuItem.Name = "SUBMARCASToolStripMenuItem"
        Me.SUBMARCASToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.SUBMARCASToolStripMenuItem.Text = "SUBMARCAS"
        '
        'TIPOSDEVEHICULOSToolStripMenuItem
        '
        Me.TIPOSDEVEHICULOSToolStripMenuItem.Name = "TIPOSDEVEHICULOSToolStripMenuItem"
        Me.TIPOSDEVEHICULOSToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.TIPOSDEVEHICULOSToolStripMenuItem.Text = "TIPOS DE VEHICULOS"
        '
        'TIPOSDEMOTORToolStripMenuItem
        '
        Me.TIPOSDEMOTORToolStripMenuItem.Name = "TIPOSDEMOTORToolStripMenuItem"
        Me.TIPOSDEMOTORToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.TIPOSDEMOTORToolStripMenuItem.Text = "TIPOS DE MOTOR"
        '
        'CLASESDEPRODUCTOSToolStripMenuItem
        '
        Me.CLASESDEPRODUCTOSToolStripMenuItem.Name = "CLASESDEPRODUCTOSToolStripMenuItem"
        Me.CLASESDEPRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.CLASESDEPRODUCTOSToolStripMenuItem.Text = "CLASES DE PRODUCTOS"
        '
        'SUBCLASESDEPRODUCTOSToolStripMenuItem
        '
        Me.SUBCLASESDEPRODUCTOSToolStripMenuItem.Name = "SUBCLASESDEPRODUCTOSToolStripMenuItem"
        Me.SUBCLASESDEPRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.SUBCLASESDEPRODUCTOSToolStripMenuItem.Text = "SUBCLASES DE PRODUCTOS"
        '
        'LINEADEPRODUCTOSToolStripMenuItem
        '
        Me.LINEADEPRODUCTOSToolStripMenuItem.Name = "LINEADEPRODUCTOSToolStripMenuItem"
        Me.LINEADEPRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.LINEADEPRODUCTOSToolStripMenuItem.Text = "LINEA DE PRODUCTOS"
        '
        'UNIDADESDEMEDIDAToolStripMenuItem
        '
        Me.UNIDADESDEMEDIDAToolStripMenuItem.Name = "UNIDADESDEMEDIDAToolStripMenuItem"
        Me.UNIDADESDEMEDIDAToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.UNIDADESDEMEDIDAToolStripMenuItem.Text = "UNIDADES DE MEDIDA"
        '
        'INVENTARIOToolStripMenuItem
        '
        Me.INVENTARIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MOVIMIENTOSDEINVENTARIOToolStripMenuItem, Me.CONSULTADEINVENTARIOToolStripMenuItem})
        Me.INVENTARIOToolStripMenuItem.Name = "INVENTARIOToolStripMenuItem"
        Me.INVENTARIOToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.INVENTARIOToolStripMenuItem.Text = "INVENTARIO"
        '
        'MOVIMIENTOSDEINVENTARIOToolStripMenuItem
        '
        Me.MOVIMIENTOSDEINVENTARIOToolStripMenuItem.Name = "MOVIMIENTOSDEINVENTARIOToolStripMenuItem"
        Me.MOVIMIENTOSDEINVENTARIOToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.MOVIMIENTOSDEINVENTARIOToolStripMenuItem.Text = "MOVIMIENTOS DE INVENTARIO"
        '
        'CONSULTADEINVENTARIOToolStripMenuItem
        '
        Me.CONSULTADEINVENTARIOToolStripMenuItem.Name = "CONSULTADEINVENTARIOToolStripMenuItem"
        Me.CONSULTADEINVENTARIOToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.CONSULTADEINVENTARIOToolStripMenuItem.Text = "CONSULTA DE INVENTARIO"
        '
        'SERVICIOToolStripMenuItem
        '
        Me.SERVICIOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENTRADAToolStripMenuItem})
        Me.SERVICIOToolStripMenuItem.Name = "SERVICIOToolStripMenuItem"
        Me.SERVICIOToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.SERVICIOToolStripMenuItem.Text = "SERVICIO"
        '
        'ENTRADAToolStripMenuItem
        '
        Me.ENTRADAToolStripMenuItem.Name = "ENTRADAToolStripMenuItem"
        Me.ENTRADAToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ENTRADAToolStripMenuItem.Text = "ENTRADA"
        '
        'frmprincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SISTALLER.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1008, 624)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 663)
        Me.MinimumSize = New System.Drawing.Size(1024, 663)
        Me.Name = "frmprincipal"
        Me.Text = "AUTO SPORT- SISTEMA DE CONTROL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents mncliente As ToolStripButton
    Friend WithEvents mnvehiculo As ToolStripButton
    Friend WithEvents mnsalir As ToolStripButton
    Friend WithEvents mnitem As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CATALOGOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MARCASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUBMARCASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TIPOSDEVEHICULOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TIPOSDEMOTORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLASESDEPRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUBCLASESDEPRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LINEADEPRODUCTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UNIDADESDEMEDIDAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mninventario As ToolStripButton
    Friend WithEvents INVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOVIMIENTOSDEINVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CONSULTADEINVENTARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SERVICIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENTRADAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnorden As ToolStripButton
End Class
