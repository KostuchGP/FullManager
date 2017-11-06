Imports INFITF
Imports MECMOD
Imports ProductStructureTypeLib

Public Class Form1
    Private prefix As String
    Private suffix As String
    Public search As String
    Public replace1 As String
    Public number As Integer
    Public numberGrow As Integer
    Private errorStatus As Boolean = False
    Dim sortColumn As Integer = -1
    Dim daneWpis As Wpis = New Wpis()
    Dim refreshShape As Refresh

    'Properties, dla pobierania wartości

    Public Property ErrorStatusValue As Boolean
        Get
            Return ErrorStatus
        End Get
        Set(ByVal value As Boolean)
            errorStatus = value
        End Set
    End Property

    Public Property PrefixValue As String
        Get
            Return prefix
        End Get
        Set(ByVal value As String)
            prefix = value
        End Set
    End Property

    Public Property SuffixValue As String
        Get
            Return suffix
        End Get
        Set(ByVal value As String)
            suffix = value
        End Set
    End Property

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.F1 Then
            TabMainForm.SelectedIndex = 0
        ElseIf e.KeyCode = Keys.F2 Then
            TabMainForm.SelectedIndex = 1
        ElseIf e.KeyCode = Keys.F3 Then
            TabMainForm.SelectedIndex = 2
        ElseIf e.KeyCode = Keys.F4 Then
            TabMainForm.SelectedIndex = 3
        ElseIf e.KeyCode = Keys.F10 Then
            btnHelp.Focus()
            SendKeys.Send("{enter}")
        ElseIf (e.Control AndAlso (e.KeyCode = Keys.R)) Then
            Me.btnRefresh.PerformClick()
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
    'Wszystkie elementy związane z UserForm /dodaje loga z information do Consoli
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TabMainForm.DrawMode = TabDrawMode.OwnerDrawFixed
        lvwMain.View = View.Details
        Main()
        If errorStatus = True Then
            Me.Close()
        End If

        refreshShape = New Refresh(btnRefresh)
        refreshShape.StartShape(1, FlatStyle.Flat, False, Color.Transparent, Color.Transparent, Color.WhiteSmoke)

    End Sub

    Private Sub TabMainForm_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TabMainForm.DrawItem

        'Firstly we'll define some parameters.
        Dim CurrentTab As TabPage = TabMainForm.TabPages(e.Index)
        Dim ItemRect As Rectangle = TabMainForm.GetTabRect(e.Index)
        Dim FillBrush As New SolidBrush(Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer)))
        Dim TextBrush As New SolidBrush(Color.Black)
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        'If we are currently painting the Selected TabItem we'll 
        'change the brush colors and inflate the rectangle.
        If CBool(e.State And DrawItemState.Selected) Then
            FillBrush.Color = Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(198, Byte), Integer))
            TextBrush.Color = Color.Black
            ItemRect.Inflate(2, 2)
        End If

        'Set up rotation for left and right aligned tabs
        If TabMainForm.Alignment = TabAlignment.Left Or TabMainForm.Alignment = TabAlignment.Right Then
            Dim RotateAngle As Single = 90
            If TabMainForm.Alignment = TabAlignment.Left Then RotateAngle = 270
            Dim cp As New PointF(ItemRect.Left + (ItemRect.Width \ 2), ItemRect.Top + (ItemRect.Height \ 2))
            e.Graphics.TranslateTransform(cp.X, cp.Y)
            e.Graphics.RotateTransform(RotateAngle)
            ItemRect = New Rectangle(-(ItemRect.Height \ 2), -(ItemRect.Width \ 2), ItemRect.Height, ItemRect.Width)
        End If

        'Next we'll paint the TabItem with our Fill Brush
        e.Graphics.FillRectangle(FillBrush, ItemRect)

        'Now draw the text.
        e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, RectangleF.op_Implicit(ItemRect), sf)

        'Reset any Graphics rotation
        e.Graphics.ResetTransform()

        'Finally, we should Dispose of our brushes.
        FillBrush.Dispose()
        TextBrush.Dispose()

    End Sub

    Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        Exit Sub 'wylaczona opcja ponizej
        If ExitAsk() = vbYes Then
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function ExitAsk() As MsgBoxResult
        Dim Smsg As String
        Smsg = "Are you really want to exit? Click Yes to terminate or No to Continue."
        ExitAsk = MsgBox(Smsg, vbYesNo + vbDefaultButton2 + vbQuestion, "Exit!")
    End Function
    'Buttony:
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    'Dodaje loga z information do Consoli
    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        lvwMain.MultiSelect = False
        lvwMain.CheckBoxes = False
        btnPNAsFN.Enabled = True
        btnManual.Enabled = True
        txtManual.Enabled = True
        If optAll.Checked = True Then
            txtConsole.Text &= Environment.NewLine & "Information: " & Microsoft.VisualBasic.Chr(34) & "The all elements mode was turned on" & Microsoft.VisualBasic.Chr(34)
        End If
    End Sub

    Private Sub optSelected_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optSelected.CheckedChanged
        lvwMain.MultiSelect = True
        lvwMain.CheckBoxes = True
        btnPNAsFN.Enabled = False
        btnManual.Enabled = False
        txtManual.Clear()
        txtManual.Enabled = False

        If optSelected.Checked = True Then
            MsgBox("W tym trybie nie można ręcznie zmieniać nazw", MsgBoxStyle.Information)
            daneWpis.Info("The selected elements mode was turned on")
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Dim dataDirectory As String = String.Format("{0}", Environment.CurrentDirectory)
        Dim FilePath As String = dataDirectory & "\Full_Manager_Guide.pdf"

        If My.Computer.FileSystem.FileExists(FilePath) Then
            Try
                Process.Start(FilePath)
            Catch ex3 As Exception
                MsgBox("Instal Acrobat Reader")
                daneWpis.LineText("Instal Acrobat Reader")
            End Try
        Else
            MsgBox("File not found.")
            daneWpis.LineText("File not found.")
        End If
    End Sub

    Private Sub btnManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManual.Click
        If txtManual.Text = "" Then
            daneWpis.Warning("No name entered")
        ElseIf lvwMain.SelectedItems.Count = 0 Then
            daneWpis.Warning("No item selected")
        Else 'wykonywanie kodu:
            For i = 0 To lvwMain.Items.Count - 1
                If (lvwMain.Items(i).SubItems(1).Text = txtManual.Text) = True Then
                    daneWpis.Warning("The name is already taken")
                    Exit For
                ElseIf i = lvwMain.Items.Count - 1 Then
                    'Nowa wartość w kolumnie
                    lvwMain.SelectedItems(0).SubItems(1).Text = txtManual.Text
                Else
                End If
            Next
        End If
        Me.lvwMain.Focus()
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Me.UseWaitCursor = True
        ZmianaPN()
        Me.UseWaitCursor = False
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Me.UseWaitCursor = True
        For i = 0 To lvwMain.Items.Count - 1
            lvwMain.Items(i).SubItems(1).Text = lvwMain.Items(i).Text
        Next
        Me.UseWaitCursor = False
    End Sub

    Private Sub btnSaveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAll.Click
        If InStr(1, rootPath, "") = 0 Then 'Jezeli glowny product jest nowy i nie ma podanej jeszcze sciezki
            Dim fbd As FolderBrowserDialog = New FolderBrowserDialog
            With fbd
                .Description = "Select Path for the Main Assembly: " & mainDoc.Name
                .RootFolder = Environment.SpecialFolder.Desktop
            End With
            If fbd.ShowDialog = DialogResult.OK Then
                rootPath = fbd.SelectedPath
                daneWpis.LineText("The path for Main Assembly " & mainDoc.Name & " has been selected: " & rootPath)
            Else
                daneWpis.LineText("The path has not been selected")
                Exit Sub
            End If
        End If

        Me.UseWaitCursor = True
        For i = 1 To CATIA.Documents.Count
            If CATIA.Documents.Item(i).Saved = False Then
                CATIA.Documents.Item(i).Save()
            End If
        Next
        Me.UseWaitCursor = False
    End Sub

    Private Sub btnSearchAndReplace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchAndReplace.Click
        Me.UseWaitCursor = True
        SearchAndReplace()
        Me.UseWaitCursor = False
    End Sub

    Private Sub btnSaveAsPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveAsPN.Click
        Me.UseWaitCursor = True
        SaveAsPN()
        Me.UseWaitCursor = False
    End Sub

    Private Sub btnAddPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPS.Click
        Me.UseWaitCursor = True
        AddPS()
        Me.UseWaitCursor = False
    End Sub

    Private Sub btnPNAsFN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPNAsFN.Click
        If optAll.Checked = True Then
            Me.UseWaitCursor = True
            CoreProgram.openDoc = CATIA.ActiveDocument
            'wykonanie dla aktywnego documentu
            openDoc.Product.PartNumber = Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATProduct"))
            'wykonanie dla wszystkich w środku
            ListingNames(CoreProgram.openDoc.Product)
            RefreshListView()
            Me.UseWaitCursor = False
        Else
            daneWpis.Warning("This option is available only in all elements mode")
            MsgBox("This option is available only in " & Microsoft.VisualBasic.Chr(34) & "all elements" & Microsoft.VisualBasic.Chr(34) & "mode")
        End If
    End Sub

    Private Sub btnInstanceName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstanceName.Click
        'Exit Sub ' wyłączone, bo zmienia rodzaj publikacji.
        Me.UseWaitCursor = True
        InstanceName()
        Me.UseWaitCursor = False
        MsgBox("Instance Names has been changed", MsgBoxStyle.Information)
        daneWpis.Info("Instance Names has been changed")
    End Sub

    Private Sub btnNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNumber.Click
        Me.UseWaitCursor = True
        AddNumber()
        Me.UseWaitCursor = False
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

        refreshShape.SetShape(My.Resources.Refresh2, 1, Color.WhiteSmoke)

        errorStatus = False
        sortColumn = -1
        CoreProgram.numberData = 0

        Me.Width = 700
        Me.Height = 550

        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        Form1_Load(e, e) 'Load everything in your form load event again

    End Sub

    Private Sub btnRefresh_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnRefresh.MouseDown
        refreshShape.SetShape(My.Resources.Refresh3, 2, Color.Gray)
    End Sub

    Private Sub btnRefresh_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.MouseEnter
        refreshShape.SetShape(My.Resources.Refresh1, 1, Color.WhiteSmoke)
    End Sub

    Private Sub btnRefresh_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.MouseHover
        refreshShape.SetShape(My.Resources.Refresh2, 1, Color.WhiteSmoke)
    End Sub

    Private Sub btnRefresh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.MouseLeave
        refreshShape.SetShape(My.Resources.Refresh1, 1, Color.WhiteSmoke)
    End Sub
    'Wszystko związane z ListView
    Private Sub lvwMain_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwMain.SelectedIndexChanged
        If optSelected.Checked = False Then
            If lvwMain.SelectedItems.Count = 1 Then
                txtManual.Text = lvwMain.SelectedItems(0).SubItems(1).Text
                txtSearch.Text = lvwMain.SelectedItems(0).SubItems(1).Text
            End If
        End If
    End Sub

    Private Sub lvwMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvwMain.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtManual.Focus()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub lvwMain_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwMain.ColumnClick
        ' Determine whether the column is the same as the last column clicked.
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            lvwMain.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If lvwMain.Sorting = SortOrder.Ascending Then
                lvwMain.Sorting = SortOrder.Descending
            Else
                lvwMain.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        lvwMain.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        lvwMain.ListViewItemSorter = New ListViewItemComparer(e.Column, lvwMain.Sorting)
    End Sub
    'Wszystkie TextBoxy
    Private Sub txtManual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtManual.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnManual.Focus()
            SendKeys.Send("{enter}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchAndReplace.Focus()
            SendKeys.Send("{enter}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtReplace_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtReplace.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchAndReplace.Focus()
            SendKeys.Send("{enter}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtPrefix_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPrefix.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddPS.Focus()
            SendKeys.Send("{enter}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtSufix_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSuffix.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddPS.Focus()
            SendKeys.Send("{enter}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        search = txtSearch.Text
    End Sub

    Private Sub txtReplace_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReplace.TextChanged
        replace1 = txtReplace.Text
    End Sub

    Private Sub txtSufifx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSuffix.TextChanged
        suffix = txtSuffix.Text
    End Sub

    Private Sub txtPrefix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrefix.TextChanged
        prefix = txtPrefix.Text
    End Sub

    Private Sub txtConsole_TextChanged(ByVal sender As System.Object, ByVal E As System.EventArgs) Handles txtConsole.TextChanged
        If lvwMain.Items.Count > 0 And Not TabMainForm.SelectedIndex = 3 Then
            'to jest tylko na start, aby od razu nie świeciło, pomimo pierwszego wpisu w konsoli
            picBell.Visible = True
        ElseIf TabMainForm.SelectedIndex = 3 Then
            'wyjątek jak widzimy odpaloną konsole
            txtConsole.SelectionStart = txtConsole.TextLength
            txtConsole.ScrollToCaret()
        End If
    End Sub

    Private Sub txtConsole_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtConsole.KeyDown
        If e.KeyCode = Keys.E Then
            Dim consolePath As String = "" 'zmienna dla sciezki jezeli nie istnieje rootPath
            Dim FILE_NAME As String
            Dim daneConsole As ExportConsole = New ExportConsole
            If InStr(1, rootPath, "") = 0 Then
                'Jezeli glowny product jest nowy i nie ma podanej jeszcze sciezki
                Dim fbd As FolderBrowserDialog = New FolderBrowserDialog
                With fbd
                    .Description = "Select Path for the Log File"
                    .RootFolder = Environment.SpecialFolder.MyComputer
                End With
                If fbd.ShowDialog = DialogResult.OK Then
                    consolePath = fbd.SelectedPath
                    FILE_NAME = consolePath & "\Log_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".txt"
                    daneConsole.startExport(FILE_NAME, consolePath)
                Else
                    MsgBox("The path has not been selected")
                    daneWpis.LineText("The path has not beed selected")
                    Exit Sub
                End If
            Else
                FILE_NAME = rootPath & "\Log_" & DateTime.Today.ToString("dd-MMM-yyyy") & ".txt"
                daneConsole.startExport(FILE_NAME, rootPath)
            End If
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub nudNumberGrow_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudNumberGrow.ValueChanged
        numberGrow = nudNumberGrow.Value
    End Sub

    Private Sub nudNumber_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudNumber.ValueChanged
        number = nudNumber.Value
    End Sub

    Private Sub TabMainForm_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TabMainForm.SelectedIndexChanged
        txtConsole.SelectionStart = txtConsole.TextLength
        txtConsole.ScrollToCaret()
        'po kliknięciu na tab z konsolą to znika nam komunikat
        If TabMainForm.SelectedIndex = 3 Then
            picBell.Visible = False
            txtConsole.Focus()
        End If
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTest.Click
        Dim myProduct As Product
        myProduct = mainDoc.Product
        For i = 1 To myProduct.Products.Count
            myProduct.Products.Item(i).Name = "Siema" & "." & i
        Next

    End Sub
End Class

Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder

    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub

    Public Sub New(ByVal column As Integer, ByVal order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
                        Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x,  _
                        ListViewItem).SubItems(col).Text, _
                        CType(y, ListViewItem).SubItems(col).Text)
        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If

        Return returnVal
    End Function
End Class

