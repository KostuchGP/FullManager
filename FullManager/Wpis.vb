Imports System.Windows.Forms
Public Class Wpis

    Public Sub Info(ByVal text As String) 'Metoda wpisująca information do consoli 
        Form1.txtConsole.Text &= Environment.NewLine & "Information: " & Microsoft.VisualBasic.Chr(34) & text & Microsoft.VisualBasic.Chr(34)
    End Sub

    Public Sub Warning(ByVal text As String) 'Metoda wpisująca warning do consoli
        Form1.txtConsole.Text &= Environment.NewLine & "Warning: " & Microsoft.VisualBasic.Chr(34) & text & Microsoft.VisualBasic.Chr(34)
    End Sub

    Public Sub LineText(ByVal text As String) 'Metoda wpisująca linie do consoli
        Form1.txtConsole.Text &= Environment.NewLine & text
    End Sub

    Public Sub ChangePN(ByVal doc As Boolean, ByVal name1 As String, ByVal name2 As String) 'Metoda wpisująca informacje do consoli o zmian nazm w CATII
        'True - Part Document
        'False - Product Document

        If doc = True Then
            Form1.txtConsole.Text &= Environment.NewLine & "[CATPart Part Number] " & Microsoft.VisualBasic.Chr(34) & name1 & Microsoft.VisualBasic.Chr(34) & " was changed to " & Microsoft.VisualBasic.Chr(34) & name2 & Microsoft.VisualBasic.Chr(34)
        Else
            Form1.txtConsole.Text &= Environment.NewLine & "[CATProduct Part Number] " & Microsoft.VisualBasic.Chr(34) & name1 & Microsoft.VisualBasic.Chr(34) & " was changed to " & Microsoft.VisualBasic.Chr(34) & name2 & Microsoft.VisualBasic.Chr(34)
        End If
    End Sub

    Public Sub SaveAsPN(ByVal doc As Boolean, ByVal name1 As String, ByVal name2 As String) 'Metoda wpisująca informacje do consoli o zmian nazm plików w CATII
        'True - Part Document
        'False - Product Document

        If doc = True Then
            Form1.txtConsole.Text &= Environment.NewLine & "[CATPart File Name] " & Microsoft.VisualBasic.Chr(34) & name1 & Microsoft.VisualBasic.Chr(34) & " was changed to " & Microsoft.VisualBasic.Chr(34) & name2 & Microsoft.VisualBasic.Chr(34)
        Else
            Form1.txtConsole.Text &= Environment.NewLine & "[CATProduct File Name] " & Microsoft.VisualBasic.Chr(34) & name1 & Microsoft.VisualBasic.Chr(34) & " was changed to " & Microsoft.VisualBasic.Chr(34) & name2 & Microsoft.VisualBasic.Chr(34)
        End If
    End Sub

End Class
