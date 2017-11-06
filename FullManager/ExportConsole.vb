Public Class ExportConsole
    Inherits System.IO.StreamWriter
    'miejsce na deklaracje zmiennych, właściwości, metod, zdarzeń
    'Konstruktory mogą być przeciążane. Domyślny konstruktor nie pobiera żadnych parametrów
    'Jeżeli nie ma żadnego konctruktora, to sam się utworzy, jeżeli jest jakikolwiek to nie
    'Aby konstruktor powstał trzeba użyć słowa kluczowego New, bez tego jest to zwykła Metoda
    'back up 
    Private objWriter As System.IO.StreamWriter 'Empty path name is not legal.
    Private dataWpis As Wpis


    Public Sub New()
        MyBase.New("1")
    End Sub

    Public Sub startExport(ByVal fileName As String, ByVal path As String)
        If System.IO.File.Exists(fileName) = True Then
            'jesli plik istnieje
            MakeFile(fileName, path)
        Else
            'jesli trzeba stworzyc plik
            System.IO.File.Create(path & "\Log_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".txt").Dispose()
            MakeFile(fileName, path)
        End If
    End Sub

    Private Sub FillConsole(ByRef path As String) ' Wypełnienie consoli po wyexportowaniu plików
        MessageBox.Show("Log file [" & "Log_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".txt" & "] was created and text was written in location: " & path)
        dataWpis.Info("-------------------------------------END-------------------------------------")
        dataWpis.Info("Text written to log file [" & "Log_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".txt" & "] in location: ")
        dataWpis.Info(path)
    End Sub

    Private Sub MakeFile(ByVal filename As String, ByVal path As String) 'Dla każdego przypadku
        FillFile(objWriter, filename)
        FillConsole(path)
    End Sub

    Private Sub FillFile(ByVal objWriter As System.IO.StreamWriter, ByVal filename As String) 'Wypełnianie zawartością pliku
        objWriter = My.Computer.FileSystem.OpenTextFileWriter(filename, True)
        objWriter.Write("Log File from date: " & DateTime.Now + Environment.NewLine + Environment.NewLine)
        objWriter.Write(Form1.txtConsole.Text)
        objWriter.Close()
    End Sub
End Class
