Imports INFITF
Imports MECMOD
Imports ProductStructureTypeLib

Module CoreProgram
    Public CATIA As Object
    Public openDoc As INFITF.Document
    Public mainDoc As INFITF.Document
    Public numberData As Integer = 0
    Public nrwystapien As Integer
    Public mainData(numberData, 1) As String
    Public prefixStatus As Boolean
    Public suffixStatus As Boolean
    Public prefixsuffixStatus As Boolean
    Public searchStatus As Boolean
    Public numberStatus As Boolean
    Public charToDeleteStatus As Boolean
    Public lnn As Long
    Public sPN() As String
    Public lCount() As Long
    Public stempPartNumber As String
    Public sPartNumberCache() As String
    Public lPartNumberCacheSize As Long
    Public bExistInCache As Boolean
    Public bExist As Boolean
    Public objProductDoc As INFITF.Document
    Public objRootProduct As ProductStructureTypeLib.Product
    Public numberArray As String()
    Public charToDeleteArray As String()
    Public rootPath As String
    Private lnnadd As Integer
    Dim daneWpis2 As Wpis = New Wpis()

    'Starting Subroutine
    Public Sub Main()
        Dim iErr As Integer

        On Error Resume Next
        CATIA = GetObject(, "CATIA.Application")
        iErr = Err.Number
        If (iErr <> 0) Then
            MsgBox("There is no open CATIA Application")
            Form1.ErrorStatusValue = True
            Exit Sub
        End If

        openDoc = CATIA.ActiveDocument
        mainDoc = openDoc
        rootPath = mainDoc.Path

        If Err.Number <> 0 Then
            MsgBox("There is no open any component in CATIA")
            Form1.ErrorStatusValue = True
            Exit Sub
        End If
        On Error GoTo 0
        If TypeName(openDoc) <> "ProductDocument" Then
            MsgBox("In CATIA Active window must be the Assembly (.CATProduct)")
            Form1.ErrorStatusValue = True
            Exit Sub
        End If

        Form1.txtConsole.Text = "Program is running for Assembly: " & Microsoft.VisualBasic.Chr(34) & mainDoc.Name & Microsoft.VisualBasic.Chr(34)

        Loading()
        BackupData()
    End Sub
    'Subroutine for loading all documents from CATIA to ListView
    Public Sub Loading()
        For Each CoreProgram.openDoc In CATIA.Documents
            If InStr(1, openDoc.Path, Form1.varGlobalLibraryPath) = 0 Then
                Select Case TypeName(openDoc)
                    Case "PartDocument"
                        Form1.lvwMain.Items.Add(openDoc.Product.PartNumber).SubItems.Add(openDoc.Product.PartNumber)
                        Form1.lvwMain.Items(numberData).SubItems.Add(openDoc.Name)
                        Form1.lvwMain.Items(numberData).SubItems.Add(openDoc.Path)
                        numberData = numberData + 1
                    Case "ProductDocument"
                        Form1.lvwMain.Items.Add(openDoc.Product.PartNumber).SubItems.Add(openDoc.Product.PartNumber)
                        Form1.lvwMain.Items(numberData).SubItems.Add(openDoc.Name)
                        Form1.lvwMain.Items(numberData).SubItems.Add(openDoc.Path)
                        numberData = numberData + 1
                End Select
            Else
                Select Case TypeName(openDoc)
                    Case "PartDocument"
                        'Nothing for elements from NuW Folder
                    Case "ProductDocument"
                        'Nothing for elements from NuW Folder
                End Select
            End If
        Next
    End Sub
    'Create a backup table for verification of segregated items
    Sub BackupData()
        ReDim mainData(numberData - 1, 1)
        For i = 0 To numberData - 1
            mainData(i, 0) = i
            mainData(i, 1) = Form1.lvwMain.Items(i).Text
        Next
        lnnadd = Form1.lvwMain.Items.Count - 1
    End Sub
    'Subroutine for changing Part Numbers with entry to the console
    Sub ZmianaPN()
        Dim l As Integer = 0
        Dim itm As ListViewItem
        Dim m As Integer
        For Each CoreProgram.openDoc In CATIA.Documents
            If InStr(1, openDoc.Path, Form1.varGlobalLibraryPath) = 0 Then
                Select Case TypeName(openDoc)
                    Case "PartDocument"
                        With Form1.lvwMain
                            itm = .FindItemWithText(mainData(l, 1), False, 0, True)
                            If Not itm Is Nothing Then
                                m = itm.Index
                            End If
                        End With
                        If Form1.optAll.Checked = True Then 'For all Part Documents one by one
                            daneWpis2.ChangePN(True, openDoc.Product.PartNumber, Form1.lvwMain.Items(m).SubItems(1).Text)
                            openDoc.Product.PartNumber = Form1.lvwMain.Items(m).SubItems(1).Text
                            Form1.lvwMain.Items(m).SubItems(2).Text = openDoc.Name
                        ElseIf Form1.lvwMain.Items(m).Checked = True Then 'Only for selected Part Documents
                            daneWpis2.ChangePN(True, openDoc.Product.PartNumber, Form1.lvwMain.Items(m).SubItems(1).Text)
                            openDoc.Product.PartNumber = Form1.lvwMain.Items(m).SubItems(1).Text
                            Form1.lvwMain.Items(m).SubItems(2).Text = openDoc.Name
                        End If
                        l = l + 1
                    Case "ProductDocument"
                        With Form1.lvwMain
                            itm = .FindItemWithText(mainData(l, 1), False, 0, True)
                            If Not itm Is Nothing Then
                                m = itm.Index
                            End If
                        End With
                        If Form1.optAll.Checked = True Then 'For all Product Documents one by one
                            daneWpis2.ChangePN(False, openDoc.Product.PartNumber, Form1.lvwMain.Items(m).SubItems(1).Text)
                            openDoc.Product.PartNumber = Form1.lvwMain.Items(m).SubItems(1).Text
                            Form1.lvwMain.Items(m).SubItems(2).Text = openDoc.Name
                        ElseIf Form1.lvwMain.Items(m).Checked = True Then 'Only for selected Part Documents
                            daneWpis2.ChangePN(False, openDoc.Product.PartNumber, Form1.lvwMain.Items(m).SubItems(1).Text)
                            openDoc.Product.PartNumber = Form1.lvwMain.Items(m).SubItems(1).Text
                            Form1.lvwMain.Items(m).SubItems(2).Text = openDoc.Name
                        End If
                        l = l + 1
                End Select
            End If
        Next
    End Sub
    'Subroutine to save Part and Product Documents with the same name as As Part Number with entry to the console || To change!
    Sub SaveAsPN()
        Dim itm As ListViewItem
        Dim m As Integer
        Dim l As Integer = 0

        If InStr(1, rootPath, "") = 0 Then 'If main Product is new and he doesn't have a path
            Dim fbd As FolderBrowserDialog = New FolderBrowserDialog
            With fbd
                .Description = "Select Path for the Main Assembly: " & mainDoc.Name
                .RootFolder = Environment.SpecialFolder.MyComputer
            End With
            If fbd.ShowDialog = DialogResult.OK Then
                rootPath = fbd.SelectedPath
                daneWpis2.LineText("The path for Main Assembly " & mainDoc.Name & " has been selected: " & rootPath)
            Else
                MsgBox("The path has not been selected")
                daneWpis2.LineText("The path has not been selected")
                Exit Sub
            End If
        End If

        CATIA.DisplayFileAlerts = False
        For Each CoreProgram.openDoc In CATIA.Documents
            If InStr(1, openDoc.Path, Form1.varGlobalLibraryPath) = 0 Then
                Select Case TypeName(openDoc)
                    Case "PartDocument"
                        With Form1.lvwMain
                            itm = .FindItemWithText(mainData(l, 1), False, 0, True)
                            If Not itm Is Nothing Then
                                m = itm.Index
                            End If
                        End With
                        If Form1.optAll.Checked = True Then 'For all Part Documents one by one
                            If InStr(1, openDoc.Path, ":") = 0 Then 'If document doesn't have specify a path to file
                                daneWpis2.SaveAsPN(True, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATPart")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(rootPath & "\" & openDoc.Product.PartNumber & ".CATPart")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            Else 'If document have a path to file
                                daneWpis2.SaveAsPN(True, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATPart")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(openDoc.Path & "\" & openDoc.Product.PartNumber & ".CATPart")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            End If
                        ElseIf Form1.lvwMain.Items(m).Checked = True Then 'Only for selected Part Documents
                            If InStr(1, openDoc.Path, ":") = 0 Then 'If document doesn't have specify a path to file
                                daneWpis2.SaveAsPN(True, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATPart")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(rootPath & "\" & openDoc.Product.PartNumber & ".CATPart")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            Else 'If document have a path to file
                                daneWpis2.SaveAsPN(True, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATPart")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(openDoc.Path & "\" & openDoc.Product.PartNumber & ".CATPart")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            End If
                        End If
                        l = l + 1
                    Case "ProductDocument"
                        With Form1.lvwMain
                            itm = .FindItemWithText(mainData(l, 1), False, 0, True)
                            If Not itm Is Nothing Then
                                m = itm.Index
                            End If
                        End With
                        If Form1.optAll.Checked = True Then 'For all Part Documents one by one
                            If InStr(1, openDoc.Path, ":") = 0 Then 'If document doesn't have specify a path to file
                                daneWpis2.SaveAsPN(False, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATProduct")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(rootPath & "\" & openDoc.Product.PartNumber & ".CATProduct")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            Else 'If document have a path to file
                                daneWpis2.SaveAsPN(False, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATProduct")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(openDoc.Path & "\" & openDoc.Product.PartNumber & ".CATProduct")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            End If
                        ElseIf Form1.lvwMain.Items(m).Checked = True Then 'Only for selected Part Documents
                            If InStr(1, openDoc.Path, ":") = 0 Then 'If document doesn't have specify a path to file
                                daneWpis2.SaveAsPN(False, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATProduct")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(rootPath & "\" & openDoc.Product.PartNumber & ".CATProduct")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            Else 'If document have a path to file
                                daneWpis2.SaveAsPN(False, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATProduct")), Form1.lvwMain.Items(m).SubItems(1).Text)
                                openDoc.SaveAs(openDoc.Path & "\" & openDoc.Product.PartNumber & ".CATProduct")
                                Form1.lvwMain.Items(m).SubItems(2).Text() = openDoc.Name
                                Form1.lvwMain.Items(m).SubItems(3).Text() = openDoc.Path
                            End If
                        End If
                        l = l + 1
                End Select
            Else 'Operatons for elements from NuW folder
                Select Case TypeName(openDoc)
                    Case "PartDocument"
                        'openDoc.Save()
                    Case "ProductDocument"
                        'openDoc.Save()
                End Select
            End If
        Next
        CATIA.DisplayFileAlerts = True
        mainDoc.Activate()
    End Sub
    'Subroutine for adding prefix and suffix with entry to the console
    Sub AddPS()
        Dim prefixArray As String()
        Dim sufixArray As String()
        Dim prefixsufixArray As String()

        'For Prefix
        prefixStatus = False
        ReDim prefixArray(lnnadd)

        If Not Form1.PrefixValue = "" And Form1.SuffixValue = "" Then
            If Form1.optAll.Checked = True Then 'For all Documents
                For i = 0 To Form1.lvwMain.Items.Count - 1
                    Form1.lvwMain.Items(i).SubItems(1).Text = Form1.PrefixValue & Form1.lvwMain.Items(i).SubItems(1).Text
                Next
            Else 'Only for selected Documents
                For i = 0 To lnnadd
                    If Form1.lvwMain.Items(i).Checked = True Then
                        prefixArray(i) = Form1.PrefixValue & Form1.lvwMain.Items(i).SubItems(1).Text
                        Call checkadd(prefixArray(i), 0)
                        If prefixStatus = True Then
                            daneWpis2.Warning("You can not add a given prefix to the selected names")
                            Exit Sub
                        End If
                    End If
                Next
                For i = 0 To lnnadd
                    If Form1.lvwMain.Items(i).Checked = True Then
                        Form1.lvwMain.Items(i).SubItems(1).Text = Form1.PrefixValue & Form1.lvwMain.Items(i).SubItems(1).Text
                    End If
                Next
            End If
        End If

        'For Suffix
        suffixStatus = False
        ReDim sufixArray(lnnadd)

        If Not Form1.SuffixValue = "" And Form1.PrefixValue = "" Then
            If Form1.optAll.Checked = True Then 'For all Documents
                For i = 0 To lnnadd
                    Form1.lvwMain.Items(i).SubItems(1).Text = Form1.lvwMain.Items(i).SubItems(1).Text & Form1.SuffixValue
                Next
            Else 'Only for selected Documents
                For i = 0 To lnnadd
                    If Form1.lvwMain.Items(i).Checked = True Then
                        sufixArray(i) = Form1.lvwMain.Items(i).SubItems(1).Text & Form1.SuffixValue
                        Call checkadd(sufixArray(i), 1)
                        If suffixStatus = True Then
                            daneWpis2.Warning("You can not add a given suffix to the selected names")
                            Exit Sub
                        End If
                    End If
                Next
                For i = 0 To lnnadd
                    If Form1.lvwMain.Items(i).Checked = True Then
                        Form1.lvwMain.Items(i).SubItems(1).Text = Form1.lvwMain.Items(i).SubItems(1).Text & Form1.SuffixValue
                    End If
                Next

            End If
        End If

        'For Prefix and Suffix
        prefixsuffixStatus = False
        ReDim prefixsufixArray(lnnadd)

        If Not Form1.PrefixValue = "" And Not Form1.SuffixValue = "" Then
            If Form1.optAll.Checked = True Then 'For all Documents
                For i = 0 To lnnadd
                    Form1.lvwMain.Items(i).SubItems(1).Text = Form1.PrefixValue & Form1.lvwMain.Items(i).SubItems(1).Text & Form1.SuffixValue
                Next
            Else 'Only for selected Documents
                For i = 0 To lnnadd
                    If Form1.lvwMain.Items(i).Checked = True Then
                        prefixsufixArray(i) = Form1.PrefixValue & Form1.lvwMain.Items(i).SubItems(1).Text & Form1.SuffixValue
                        Call checkadd(prefixsufixArray(i), 2)
                        If prefixsuffixStatus = True Then
                            daneWpis2.Warning("You can not add a given prefix and suffix to the selected names")
                        End If
                    End If
                Next
                For i = 0 To lnnadd
                    If Form1.lvwMain.Items(i).Checked = True Then
                        Form1.lvwMain.Items(i).SubItems(1).Text = Form1.PrefixValue & Form1.lvwMain.Items(i).SubItems(1).Text & Form1.SuffixValue
                    End If
                Next

            End If
        End If

    End Sub
    'Subroutine for changing entry phrase with entry to the console
    Sub SearchAndReplace()
        Dim searchAllArray As String()
        Dim searchSelectedArray As String()
        searchStatus = False
        ReDim searchAllArray(lnnadd)
        ReDim searchSelectedArray(lnnadd)

        If Not Form1.search = "" Then ' Checking replace on all
            For i = 0 To lnnadd
                If (Form1.lvwMain.Items(i).SubItems(1).Text = Form1.replace1) = True Then
                    daneWpis2.Warning("The name is already taken")
                    Exit Sub
                End If
            Next 'Checking if that what we make there is on the list
            For i = 0 To lnnadd
                If InStr(Form1.lvwMain.Items(i).SubItems(1).Text, Form1.search) > 0 Then
                    If Form1.optAll.Checked = True Then 'Action Search and Replace on all elements
                        searchAllArray(i) = Replace(Form1.lvwMain.Items(i).SubItems(1).Text, Form1.search, Form1.replace1)
                        Call checksearchandreplace(searchAllArray(i), 0, searchAllArray)
                        If searchStatus = True Then
                            daneWpis2.Warning("You can not swap")
                            Exit Sub
                        End If
                    ElseIf Form1.lvwMain.Items(i).Checked = True Then 'Action Search and Replace on selected elements 
                        searchSelectedArray(i) = Replace(Form1.lvwMain.Items(i).SubItems(1).Text, Form1.search, Form1.replace1)
                        Call checksearchandreplace(searchSelectedArray(i), 0, searchSelectedArray)
                        If searchStatus = True Then
                            daneWpis2.Warning("You can not swap")
                            Exit Sub
                        End If
                    End If
                End If
            Next
            If Form1.optAll.Checked = True Then 'Cheking all searchAllArray for all elements
                For i = 0 To searchAllArray.Count - 1 ' nie wiem ile tu bedzie
                    If Not searchAllArray(i) Is Nothing Then
                        nrwystapien = 0
                        Call checksearchandreplace(searchAllArray(i), 1, searchAllArray)
                        If nrwystapien > 1 Then
                            daneWpis2.Warning("You can not swap")
                            Exit Sub
                        End If
                    End If
                Next
                For i = 0 To lnnadd
                    Form1.lvwMain.Items(i).SubItems(1).Text = Replace(Form1.lvwMain.Items(i).SubItems(1).Text, Form1.search, Form1.replace1)
                Next
            Else 'Sprawdzanie calego searchSelectedArray dla Selected Elements
                For i = 0 To searchSelectedArray.Count - 1 ' nie wiem ile tu bedzie
                    If Not searchAllArray(i) Is Nothing Then
                        nrwystapien = 0
                        Call checksearchandreplace(searchSelectedArray(i), 1, searchSelectedArray)
                        If nrwystapien > 1 Then
                            daneWpis2.Warning("You can not swap")
                            Exit Sub
                        End If
                    End If
                Next
                For i = 0 To lnnadd
                    If InStr(Form1.lvwMain.Items(i).SubItems(1).Text, Form1.search) > 0 Then
                        If Form1.lvwMain.Items(i).Checked = True Then
                            Form1.lvwMain.Items(i).SubItems(1).Text = Replace(Form1.lvwMain.Items(i).SubItems(1).Text, Form1.search, Form1.replace1)
                        End If
                    End If
                Next
            End If
        End If
    End Sub
    'Subroutine for changing Instance Name || Right know it's not working
    Sub InstanceName()
        lnn = 1
        ReDim sPN(lnn)
        ReDim lCount(lnn)
        sPN(0) = ""
        sPN(1) = ""
        lCount(0) = 0
        lCount(1) = 0
        bExist = False
        stempPartNumber = ""
        lPartNumberCacheSize = 1

        ReDim sPartNumberCache(lPartNumberCacheSize)
        sPartNumberCache(0) = ""
        sPartNumberCache(1) = ""
        bExistInCache = False
        'Weryfikacja czy jest zaladowany CATProduct
        On Error Resume Next
        openDoc = CATIA.ActiveDocument
        If Err.Number <> 0 Then
            daneWpis2.Warning("In CATIA Active window must be the Assembly (.CATProduct)")
            Exit Sub
        End If
        On Error GoTo 0
        If TypeName(openDoc) <> "ProductDocument" Then
            daneWpis2.Warning("In CATIA Active window must be the Assembly (.CATProduct)")
            Exit Sub
        End If
        Dim myProduct As Product
        myProduct = openDoc.Product
        If myProduct.Products.Count > 0 Then
            Call fSetProductName(myProduct, openDoc)
            lPartNumberCacheSize = 1
            ReDim sPartNumberCache(lPartNumberCacheSize)
            sPartNumberCache(0) = ""
            sPartNumberCache(1) = ""
            bExistInCache = False
        Else
            daneWpis2.Warning("The product is empty")
        End If
    End Sub
    'Subroutine for changing phrase "Copy (...) of"
    Sub DeleteCopyOf()
        Dim numerPosition As Integer
        Dim numberLength As Integer

        ReDim numberArray(lnnadd)
        For i = 0 To lnnadd
            numberArray(i) = Form1.lvwMain.Items(i).SubItems(1).Text
        Next

        If Form1.optAll.Checked = True Then 'For all elements in ListView
            For i = 0 To lnnadd
                numberLength = numberArray(i).Length
                numerPosition = Form1.lvwMain.Items(i).SubItems(1).Text.LastIndexOf(") of ")
                If Not numerPosition = -1 Then
                    numberArray(i) = Right(numberArray(i), numberLength - numerPosition - 5)
                End If
            Next
        Else 'Actions on selected elements
            For i = 0 To lnnadd
                If Form1.lvwMain.Items(i).Checked = True Then
                    numberLength = numberArray(i).Length
                    numerPosition = Form1.lvwMain.Items(i).SubItems(1).Text.LastIndexOf(") of ")
                    If Not numerPosition = -1 Then
                        numberArray(i) = Right(numberArray(i), numberLength - numerPosition - 5)
                    End If
                End If
            Next
        End If

    End Sub
    'Subroutine do dodawania liczb do nazw 1## /dodaje loga z warningiem do Consoli
    Sub AddNumber()
        Dim numberNew As Long = numberNew = Form1.number
        Dim lnnadd As Integer = Form1.lvwMain.Items.Count - 1
        Dim sprawdzana As String

        numberStatus = False
        If Form1.chkDeleteCopyOf.Checked = False Then
            ReDim numberArray(lnnadd)
            For i = 0 To lnnadd
                numberArray(i) = Form1.lvwMain.Items(i).SubItems(1).Text
            Next
        ElseIf Form1.chkDeleteCopyOf.Checked = True Then
            DeleteCopyOf()
        End If

        'Troche inna filozofia sprawdzania niz przy prefiksie czy sufixie poniewaz jezeli nie znajdzie problemu to nadpisuje przeszukiwany teren
        If Form1.optAll.Checked = True Then 'Actions on all elements
            For i = 0 To lnnadd
                Form1.lvwMain.Items(i).SubItems(1).Text = numberArray(i) & numberNew
                numberNew = numberNew + Form1.numberGrow
            Next
        Else 'Actions on selected elements
            For i = 0 To lnnadd
                If Form1.lvwMain.Items(i).Checked = True Then
                    sprawdzana = numberArray(i).ToString & numberNew
                    'wywolanie funkcji, która sprawdzi selected item z cala list boxem, jezeli wynik w ktoryms z kroków okaze sie konfliktowy to wstawi zmienna
                    Call checkadd(sprawdzana, 3)
                    If numberStatus = True Then
                        daneWpis2.Warning("You can not add the given number to the selected names")
                        Exit Sub
                    Else
                        numberArray(i) = sprawdzana
                    End If
                    numberNew = numberNew + Form1.numberGrow
                End If
            Next
            For i = 0 To lnnadd
                If Form1.lvwMain.Items(i).Checked = True Then
                    Form1.lvwMain.Items(i).SubItems(1).Text = numberArray(i)
                End If
            Next
        End If
    End Sub
    'Subroutine do usuwania znaków z początku nazw /dodaje loga z warningiem do Consoli
    Sub CharToDelete()
        Dim numberNewChar As Integer = Form1.numberCharToDel
        Dim sprawdzana As String
        charToDeleteStatus = False
        ReDim charToDeleteArray(lnnadd)

        For i = 0 To lnnadd
            charToDeleteArray(i) = Form1.lvwMain.Items(i).SubItems(1).Text
        Next

        If Form1.optAll.Checked = False Then 'Actions on selected elements
            For i = 0 To lnnadd
                If Form1.lvwMain.Items(i).Checked = True Then
                    'tutaj musze dac funkcje
                    sprawdzana = (charToDeleteArray(i).ToString).Remove(0, numberNewChar)
                    'wywolanie funkcji, która sprawdzi selected item z cala list boxem, jezeli wynik w ktoryms z kroków okaze sie konfliktowy to wstawi zmienna
                    Call checkadd(sprawdzana, 4)
                    If charToDeleteStatus = True Then
                        daneWpis2.Warning("You can not delete letters from the selected names")
                        Exit Sub
                    Else
                        charToDeleteArray(i) = sprawdzana
                    End If
                End If
            Next

            For i = 0 To lnnadd
                If Form1.lvwMain.Items(i).Checked = True Then
                    Form1.lvwMain.Items(i).SubItems(1).Text = charToDeleteArray(i)
                End If
            Next
        End If
    End Sub
    'Subroutine do zamiany Part Number na ten sam co ma file name
    Sub ListingNames(ByVal current_prod As ProductStructureTypeLib.Product)
        If current_prod.Products.Count > 0 Then
            For i = 1 To current_prod.Products.Count
                Call ListingNames(current_prod.Products.Item(i))
                If InStr(current_prod.Products.Item(i).ReferenceProduct.Parent.Name, ".CATProduct") > 0 Then
                    current_prod.Products.Item(i).PartNumber = Left(current_prod.Products.Item(i).ReferenceProduct.Parent.Name, Len(current_prod.Products.Item(i).ReferenceProduct.Parent.Name) - 11)
                End If
            Next
        Else
            If InStr(current_prod.ReferenceProduct.Parent.Name, ".CATPart") > 0 Then
                current_prod.PartNumber = Left(current_prod.ReferenceProduct.Parent.Name, Len(current_prod.ReferenceProduct.Parent.Name) - 8)
            End If
        End If
    End Sub
    'Subroutine do odświeżenia listy np po subie ListingNames
    Sub RefreshListView()
        Dim l As Integer = 0
        Dim itm As ListViewItem
        Dim m As Integer
        For Each CoreProgram.openDoc In CATIA.Documents
            If InStr(1, openDoc.Path, Form1.varGlobalLibraryPath) = 0 Then
                Select Case TypeName(openDoc)
                    Case "PartDocument"
                        With Form1.lvwMain
                            itm = .FindItemWithText(mainData(l, 1), False, 0, True)
                            If Not itm Is Nothing Then
                                m = itm.Index
                            End If
                        End With
                        daneWpis2.ChangePN(True, Form1.lvwMain.Items(m).SubItems(1).Text, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATPart")))
                        Form1.lvwMain.Items(m).SubItems(1).Text = openDoc.Product.PartNumber
                        l = l + 1
                    Case "ProductDocument"
                        With Form1.lvwMain
                            itm = .FindItemWithText(mainData(l, 1), False, 0, True)
                            If Not itm Is Nothing Then
                                m = itm.Index
                            End If
                        End With
                        daneWpis2.ChangePN(False, Form1.lvwMain.Items(m).SubItems(1).Text, Microsoft.VisualBasic.Left(openDoc.Name, openDoc.Name.LastIndexOf(".CATProduct")))
                        Form1.lvwMain.Items(m).SubItems(1).Text = openDoc.Product.PartNumber
                        l = l + 1
                End Select
            End If
        Next
        daneWpis2.Info("Changing Part Number As File Name end successful")
    End Sub
    'Dodatkowa funkcja sprawdzajaca przez ostatecznym dodaniem prefixu i sufixu
    Function checkadd(ByVal myadd As String, ByVal wyznacznik As Long)
        On Error Resume Next
        If wyznacznik = 0 Then
            For i = 0 To lnnadd
                If (Form1.lvwMain.Items(i).SubItems(1).Text = myadd) = True Then
                    prefixStatus = True
                    Exit For
                End If
            Next
        ElseIf wyznacznik = 1 Then
            For i = 0 To lnnadd
                If (Form1.lvwMain.Items(i).SubItems(1).Text = myadd) = True Then
                    suffixStatus = True
                    Exit For
                End If
            Next
        ElseIf wyznacznik = 2 Then
            For i = 0 To lnnadd
                If (Form1.lvwMain.Items(i).SubItems(1).Text = myadd) = True Then
                    prefixsuffixStatus = True
                    Exit For
                End If
            Next
        ElseIf wyznacznik = 3 Then
            For i = 0 To lnnadd
                If (numberArray(i) = myadd) = True Then
                    numberStatus = True
                    Exit For
                End If
            Next
        ElseIf wyznacznik = 4 Then
            For i = 0 To lnnadd
                If (charToDeleteArray(i) = myadd) = True Then
                    charToDeleteStatus = True
                    Exit For
                End If
            Next
        End If
    End Function
    'Dodatkowa funkcja sprawdzajaca przez ostatecznym replace
    Function checksearchandreplace(ByVal myreplace As String, ByVal wyznacznik As Long, ByVal myArray As String())
        On Error Resume Next
        If wyznacznik = 0 Then
            For i = 0 To lnnadd
                If Form1.lvwMain.Items(i).SubItems(1).Text = myreplace Then
                    searchStatus = True
                    Exit For
                End If
            Next
        ElseIf wyznacznik = 1 Then
            For i = 0 To myArray.Count - 1
                If myArray(i) = myreplace Then
                    nrwystapien = nrwystapien + 1
                End If
            Next
        End If
    End Function
    'Dodatkowa funkcja potrzeba do Instance Name
    Function fSetProductName(ByVal myProduct As Product, ByVal myDocument As Document)
        On Error Resume Next
        Dim otempProduct As AnyObject
        For i = 1 To myProduct.Products.Count
            stempPartNumber = myProduct.Products.Item(i).PartNumber
            For j = 1 To lnn
                If stempPartNumber = sPN(j) Then
                    lCount(j) = lCount(j) + 1
                    myProduct.Products.Item(i).Name = stempPartNumber & "." & CStr(lCount(j))
                    bExist = True
                    Exit For
                End If
            Next
            If bExist = False Then
                lnn = lnn + 1
                ReDim Preserve sPN(lnn)
                ReDim Preserve lCount(lnn)
                sPN(lnn) = stempPartNumber
                lCount(lnn) = 1
                myProduct.Products.Item(i).Name = stempPartNumber & "." & CStr(lCount(lnn))
            End If
            bExist = False
        Next
        lnn = 1
        ReDim sPN(lnn)
        ReDim lCount(lnn)
        sPN(0) = ""
        sPN(1) = ""
        lCount(0) = 0
        lCount(1) = 0
        stempPartNumber = ""
        For i = 1 To myProduct.Products.Count
            If myProduct.Products.Item(i).Products.Count > 0 Then
                stempPartNumber = myProduct.Products.Item(i).PartNumber
                For j = 1 To lPartNumberCacheSize
                    If sPartNumberCache(j) = stempPartNumber Then
                        bExistInCache = True
                        Exit For
                    End If
                Next
                If bExistInCache = False Then
                    lPartNumberCacheSize = lPartNumberCacheSize + 1
                    ReDim Preserve sPartNumberCache(lPartNumberCacheSize)
                    sPartNumberCache(lPartNumberCacheSize - 1) = stempPartNumber
                    On Error Resume Next
                    otempProduct = myDocument.GetItem(stempPartNumber)
                    Call fSetProductName(otempProduct, myDocument)
                    On Error GoTo 0
                End If
                stempPartNumber = ""
                bExistInCache = False
            End If
        Next
    End Function
End Module