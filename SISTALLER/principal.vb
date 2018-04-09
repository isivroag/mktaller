Imports System.IO
Imports System.Math

Module principal
    Public Function sacarclave(texto As String) As String
        Dim i As Integer
        Dim p As Integer
        If texto <> "" Then
            For i = 1 To Len(texto)
                If Mid(texto, i, 1) = " " Then
                    p = i
                    i = Len(texto)
                End If
            Next
            sacarclave = Left(texto, p - 1)
        Else
            sacarclave = ""
        End If

    End Function

    Public Function contenido(texto As String) As String
        contenido = Mid(texto, Len(sacarclave(texto)) + 2, Len(texto) - Len(sacarclave(texto)) + 1)

    End Function

    Public Function EnLetras(tyCantidad As Decimal) As String
        Dim lyCantidad As Decimal, lyCentavos As Decimal, lnDigito As Byte, lnPrimerDigito As Byte, lnSegundoDigito As Byte, lnTercerDigito As Byte, lcBloque As String, lnNumeroBloques As Byte, lnBloqueCero As Decimal
        tyCantidad = Round(tyCantidad, 2)
        lyCantidad = Int(tyCantidad)
        lyCentavos = (tyCantidad - lyCantidad) * 100
        Dim laUnidades As String()
        laUnidades = {"UN", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE", "VEINTE", "VEINTIUN", "VEINTIDOS", "VEINTITRES", "VEINTICUATRO", "VEINTICINCO", "VEINTISEIS", "VEINTISIETE", "VEINTIOCHO", "VEINTINUEVE"}
        Dim laDecenas As String()
        laDecenas = {"DIEZ", "VEINTE", "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA"}
        Dim laCentenas As String()
        laCentenas = {"CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS"}
        lnNumeroBloques = 1
        Do
            lnPrimerDigito = 0
            lnSegundoDigito = 0
            lnTercerDigito = 0
            lcBloque = ""
            lnBloqueCero = 0
            For i = 1 To 3
                lnDigito = lyCantidad Mod 10
                If lnDigito <> 0 Then
                    Select Case i
                        Case 1
                            lcBloque = " " & laUnidades(lnDigito - 1)
                            lnPrimerDigito = lnDigito
                        Case 2
                            If lnDigito <= 2 Then
                                lcBloque = " " & laUnidades((lnDigito * 10) + lnPrimerDigito - 1)
                            Else
                                lcBloque = " " & laDecenas(lnDigito - 1) & IIf(lnPrimerDigito <> 0, " Y", Nothing) & lcBloque
                            End If
                            lnSegundoDigito = lnDigito
                        Case 3
                            lcBloque = " " & IIf(lnDigito = 1 And lnPrimerDigito = 0 And lnSegundoDigito = 0, "CIEN", laCentenas(lnDigito - 1)) & lcBloque
                            lnTercerDigito = lnDigito
                    End Select
                Else
                    lnBloqueCero = lnBloqueCero + 1
                End If
                lyCantidad = Int(lyCantidad / 10)
                If lyCantidad = 0 Then
                    Exit For
                End If
            Next i
            Select Case lnNumeroBloques
                Case 1
                    EnLetras = lcBloque
                Case 2
                    EnLetras = lcBloque & IIf(lnBloqueCero = 3, Nothing, " MIL") & EnLetras
                Case 3
                    EnLetras = lcBloque & IIf(lnPrimerDigito = 1 And lnSegundoDigito = 0 And lnTercerDigito = 0, " MILLON", " MILLONES") & EnLetras
            End Select
            lnNumeroBloques = lnNumeroBloques + 1
        Loop Until lyCantidad = 0
        EnLetras = "(" & EnLetras & IIf(tyCantidad > 1, " PESOS ", " PESO ") & Format(lyCentavos, "00") & "/100 M.N. )"
    End Function


    Public Function formatomoneda(ByVal Tabla As DataGridView, ByVal num As Integer, ByVal pesos As Boolean) As Integer
        If pesos = True Then
            Tabla.Columns(num).DefaultCellStyle.Format = "c2"
        Else
            'Tabla.Columns(num).DefaultCellStyle.Format = "D2"
        End If
        Tabla.Columns(num).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Return 0
    End Function


    Public Function solonumeros(ByVal sender As Object, ByVal e As KeyPressEventArgs) As Integer
        Dim cadena As String
        Dim i As Integer
        Dim at As Integer

        cadena = "0123456789." + Chr(8)
        If Strings.InStr(cadena, e.KeyChar.ToString) = 0 Then
            e.KeyChar = ""
        End If

        Do While i < Strings.Len(sender.Text)
            If Mid(sender.Text, i + 1, 1) = "." Then
                at = 1
            End If
            i = i + 1
        Loop

        If at = 1 And e.KeyChar = Chr(46) Then
            e.KeyChar = ""
        End If
        Return 0
    End Function

    Public Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo)
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
End Module
