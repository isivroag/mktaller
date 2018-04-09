Imports System.Windows.Forms

Public Class frmprincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub



    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub mncliente_Click(sender As Object, e As EventArgs) Handles mncliente.Click
        'frmconsultacliente.MdiParent = Me
        frmconsultacliente.Show()
        frmconsultacliente.flag = 1
    End Sub

    Private Sub mnvehiculo_Click(sender As Object, e As EventArgs) Handles mnvehiculo.Click
        ' frmconsultavehiculo.MdiParent = Me
        frmconsultavehiculo.Show()
        frmconsultavehiculo.flag = 1
    End Sub

    Private Sub mnsalir_Click(sender As Object, e As EventArgs) Handles mnsalir.Click
        End
    End Sub

    Private Sub mnitem_Click(sender As Object, e As EventArgs) Handles mnitem.Click
        ' frmconsultaitem.MdiParent = Me
        frmconsultaitem.Show()
        frmconsultaitem.flag = 1

    End Sub

    Private Sub MARCASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MARCASToolStripMenuItem.Click
        ' frmconsultamarca.MdiParent = Me
        frmconsultamarca.Show()
    End Sub

    Private Sub SUBMARCASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBMARCASToolStripMenuItem.Click
        'frmconsultasubmarca.MdiParent = Me
        frmconsultasubmarca.Show()
    End Sub

    Private Sub TIPOSDEVEHICULOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIPOSDEVEHICULOSToolStripMenuItem.Click
        'frmconsultatipoveh.MdiParent = Me
        frmconsultatipoveh.Show()

    End Sub

    Private Sub TIPOSDEMOTORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TIPOSDEMOTORToolStripMenuItem.Click
        'frmconsultamotor.MdiParent = Me
        frmconsultamotor.Show()

    End Sub

    Private Sub CLASESDEPRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLASESDEPRODUCTOSToolStripMenuItem.Click
        'frmconsultaclase.MdiParent = Me
        frmconsultaclase.Show()

    End Sub

    Private Sub SUBCLASESDEPRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SUBCLASESDEPRODUCTOSToolStripMenuItem.Click
        'frmconsultasubclase.MdiParent = Me
        frmconsultasubclase.Show()
    End Sub

    Private Sub LINEADEPRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LINEADEPRODUCTOSToolStripMenuItem.Click
        ' frmconsultalinea.MdiParent = Me
        frmconsultalinea.Show()
    End Sub

    Private Sub UNIDADESDEMEDIDAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UNIDADESDEMEDIDAToolStripMenuItem.Click
        'frmconsultaumed.MdiParent = Me
        frmconsultaumed.Show()
    End Sub

    Private Sub mninventario_Click(sender As Object, e As EventArgs) Handles mninventario.Click
        '  frminventario.MdiParent = Me
        frminventario.Show()

    End Sub

    Private Sub MOVIMIENTOSDEINVENTARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOVIMIENTOSDEINVENTARIOToolStripMenuItem.Click
        ' frminventario.MdiParent = Me
        frminventario.Show()
    End Sub

    Private Sub CONSULTADEINVENTARIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTADEINVENTARIOToolStripMenuItem.Click
        ' frmconsultainventario.MdiParent = Me
        frmconsultainventario.Show()
    End Sub

    Private Sub ENTRADAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ENTRADAToolStripMenuItem.Click

        frmordenser.Show()
    End Sub

    Private Sub SERVICIOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SERVICIOToolStripMenuItem.Click

    End Sub

    Private Sub mnorden_Click(sender As Object, e As EventArgs) Handles mnorden.Click
        '  frmconsultaorden.MdiParent = Me
        frmconsultaorden.Show()

    End Sub

    Private Sub frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
