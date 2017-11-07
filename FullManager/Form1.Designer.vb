<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtManual = New System.Windows.Forms.TextBox()
        Me.optAll = New System.Windows.Forms.RadioButton()
        Me.optSelected = New System.Windows.Forms.RadioButton()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblReplace = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.txtReplace = New System.Windows.Forms.TextBox()
        Me.btnSearchAndReplace = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPNAsFN = New System.Windows.Forms.Button()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.btnAddPS = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaveAsPN = New System.Windows.Forms.Button()
        Me.btnSaveAll = New System.Windows.Forms.Button()
        Me.btnInstanceName = New System.Windows.Forms.Button()
        Me.btnManual = New System.Windows.Forms.Button()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvwMain = New System.Windows.Forms.ListView()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.nudNumberGrow = New System.Windows.Forms.NumericUpDown()
        Me.nudNumber = New System.Windows.Forms.NumericUpDown()
        Me.chkDeleteCopyOf = New System.Windows.Forms.CheckBox()
        Me.TabMainForm = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnCharToDel = New System.Windows.Forms.Button()
        Me.lblCharToDel = New System.Windows.Forms.Label()
        Me.nudNumberCharToDel = New System.Windows.Forms.NumericUpDown()
        Me.lblStartNumberSmall = New System.Windows.Forms.Label()
        Me.lblMultiplyJumpSmall = New System.Windows.Forms.Label()
        Me.lblMultiplyJump = New System.Windows.Forms.Label()
        Me.lblStartNumber = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txtConsole = New System.Windows.Forms.TextBox()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.picBell = New System.Windows.Forms.PictureBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        CType(Me.nudNumberGrow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMainForm.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.nudNumberCharToDel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.picBell, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblName.BackColor = System.Drawing.Color.White
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 336)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 26)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtManual
        '
        Me.txtManual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtManual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManual.Location = New System.Drawing.Point(108, 336)
        Me.txtManual.Name = "txtManual"
        Me.txtManual.Size = New System.Drawing.Size(762, 26)
        Me.txtManual.TabIndex = 2
        '
        'optAll
        '
        Me.optAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optAll.AutoSize = True
        Me.optAll.Checked = True
        Me.optAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAll.Location = New System.Drawing.Point(242, 371)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(121, 22)
        Me.optAll.TabIndex = 20
        Me.optAll.TabStop = True
        Me.optAll.Text = "All elements"
        Me.optAll.UseVisualStyleBackColor = True
        '
        'optSelected
        '
        Me.optSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.optSelected.AutoSize = True
        Me.optSelected.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optSelected.Location = New System.Drawing.Point(369, 371)
        Me.optSelected.Name = "optSelected"
        Me.optSelected.Size = New System.Drawing.Size(166, 22)
        Me.optSelected.TabIndex = 20
        Me.optSelected.Text = "Selected elements"
        Me.optSelected.UseVisualStyleBackColor = True
        '
        'lblSearch
        '
        Me.lblSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSearch.BackColor = System.Drawing.Color.White
        Me.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSearch.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(2, 3)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(90, 26)
        Me.lblSearch.TabIndex = 1
        Me.lblSearch.Text = "Search:"
        '
        'lblReplace
        '
        Me.lblReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblReplace.BackColor = System.Drawing.Color.White
        Me.lblReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblReplace.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReplace.Location = New System.Drawing.Point(2, 36)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(90, 26)
        Me.lblReplace.TabIndex = 0
        Me.lblReplace.Text = "Replace:"
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(98, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(748, 26)
        Me.txtSearch.TabIndex = 5
        '
        'txtReplace
        '
        Me.txtReplace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtReplace.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReplace.Location = New System.Drawing.Point(98, 36)
        Me.txtReplace.Name = "txtReplace"
        Me.txtReplace.Size = New System.Drawing.Size(748, 26)
        Me.txtReplace.TabIndex = 6
        '
        'btnSearchAndReplace
        '
        Me.btnSearchAndReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchAndReplace.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSearchAndReplace.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSearchAndReplace.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchAndReplace.Location = New System.Drawing.Point(697, 68)
        Me.btnSearchAndReplace.Name = "btnSearchAndReplace"
        Me.btnSearchAndReplace.Size = New System.Drawing.Size(145, 29)
        Me.btnSearchAndReplace.TabIndex = 7
        Me.btnSearchAndReplace.Text = "Search and Replace"
        Me.btnSearchAndReplace.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReset.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(12, 368)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(224, 29)
        Me.btnReset.TabIndex = 16
        Me.btnReset.Text = "Change to Orginal Part Number"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnPNAsFN
        '
        Me.btnPNAsFN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPNAsFN.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPNAsFN.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPNAsFN.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPNAsFN.Location = New System.Drawing.Point(151, 581)
        Me.btnPNAsFN.Name = "btnPNAsFN"
        Me.btnPNAsFN.Size = New System.Drawing.Size(185, 29)
        Me.btnPNAsFN.TabIndex = 13
        Me.btnPNAsFN.Text = "Part Number As File Name"
        Me.btnPNAsFN.UseVisualStyleBackColor = False
        '
        'lblPrefix
        '
        Me.lblPrefix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblPrefix.BackColor = System.Drawing.Color.White
        Me.lblPrefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrefix.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrefix.Location = New System.Drawing.Point(2, 3)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(90, 26)
        Me.lblPrefix.TabIndex = 0
        Me.lblPrefix.Text = "Prefix:"
        '
        'lblSuffix
        '
        Me.lblSuffix.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSuffix.BackColor = System.Drawing.Color.White
        Me.lblSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSuffix.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuffix.Location = New System.Drawing.Point(2, 36)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(90, 26)
        Me.lblSuffix.TabIndex = 0
        Me.lblSuffix.Text = "Suffix:"
        '
        'txtPrefix
        '
        Me.txtPrefix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPrefix.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(98, 3)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(548, 26)
        Me.txtPrefix.TabIndex = 5
        '
        'txtSuffix
        '
        Me.txtSuffix.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSuffix.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSuffix.Location = New System.Drawing.Point(98, 36)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(548, 26)
        Me.txtSuffix.TabIndex = 6
        '
        'btnAddPS
        '
        Me.btnAddPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddPS.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnAddPS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddPS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPS.Location = New System.Drawing.Point(497, 68)
        Me.btnAddPS.Name = "btnAddPS"
        Me.btnAddPS.Size = New System.Drawing.Size(145, 29)
        Me.btnAddPS.TabIndex = 7
        Me.btnAddPS.Text = "Add Prefix/Suffix"
        Me.btnAddPS.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.BackColor = System.Drawing.Color.LightGreen
        Me.btnApply.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(648, 581)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(222, 29)
        Me.btnApply.TabIndex = 9
        Me.btnApply.Text = "Make changes to the structure"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(792, 616)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(78, 29)
        Me.btnClose.TabIndex = 16
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSaveAsPN
        '
        Me.btnSaveAsPN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAsPN.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSaveAsPN.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAsPN.Location = New System.Drawing.Point(547, 616)
        Me.btnSaveAsPN.Name = "btnSaveAsPN"
        Me.btnSaveAsPN.Size = New System.Drawing.Size(239, 29)
        Me.btnSaveAsPN.TabIndex = 10
        Me.btnSaveAsPN.Text = "Save, File Name As Part Number]"
        Me.btnSaveAsPN.UseVisualStyleBackColor = False
        '
        'btnSaveAll
        '
        Me.btnSaveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAll.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSaveAll.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAll.Location = New System.Drawing.Point(547, 581)
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(97, 29)
        Me.btnSaveAll.TabIndex = 14
        Me.btnSaveAll.Text = "Save All"
        Me.btnSaveAll.UseVisualStyleBackColor = False
        '
        'btnInstanceName
        '
        Me.btnInstanceName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnInstanceName.BackColor = System.Drawing.Color.Yellow
        Me.btnInstanceName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnInstanceName.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstanceName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnInstanceName.Location = New System.Drawing.Point(151, 547)
        Me.btnInstanceName.Name = "btnInstanceName"
        Me.btnInstanceName.Size = New System.Drawing.Size(235, 29)
        Me.btnInstanceName.TabIndex = 11
        Me.btnInstanceName.Text = "Instance Name As Part Number"
        Me.btnInstanceName.UseVisualStyleBackColor = False
        '
        'btnManual
        '
        Me.btnManual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManual.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnManual.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnManual.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManual.Location = New System.Drawing.Point(792, 368)
        Me.btnManual.Name = "btnManual"
        Me.btnManual.Size = New System.Drawing.Size(78, 29)
        Me.btnManual.TabIndex = 3
        Me.btnManual.Text = "Change"
        Me.btnManual.UseVisualStyleBackColor = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Original Part Number"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "New Part Number"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "File Name"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Location"
        Me.ColumnHeader4.Width = 200
        '
        'lvwMain
        '
        Me.lvwMain.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lvwMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwMain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwMain.FullRowSelect = True
        Me.lvwMain.HideSelection = False
        Me.lvwMain.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lvwMain.Location = New System.Drawing.Point(12, 12)
        Me.lvwMain.MultiSelect = False
        Me.lvwMain.Name = "lvwMain"
        Me.lvwMain.Size = New System.Drawing.Size(858, 318)
        Me.lvwMain.TabIndex = 1
        Me.lvwMain.UseCompatibleStateImageBehavior = False
        Me.lvwMain.View = System.Windows.Forms.View.Details
        '
        'btnNumber
        '
        Me.btnNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNumber.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNumber.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNumber.Location = New System.Drawing.Point(508, 68)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(134, 29)
        Me.btnNumber.TabIndex = 8
        Me.btnNumber.Text = "Add Numbers"
        Me.btnNumber.UseVisualStyleBackColor = True
        '
        'nudNumberGrow
        '
        Me.nudNumberGrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nudNumberGrow.Location = New System.Drawing.Point(178, 36)
        Me.nudNumberGrow.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudNumberGrow.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberGrow.Name = "nudNumberGrow"
        Me.nudNumberGrow.Size = New System.Drawing.Size(112, 26)
        Me.nudNumberGrow.TabIndex = 6
        Me.nudNumberGrow.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudNumber
        '
        Me.nudNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nudNumber.InterceptArrowKeys = False
        Me.nudNumber.Location = New System.Drawing.Point(178, 3)
        Me.nudNumber.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumber.Name = "nudNumber"
        Me.nudNumber.Size = New System.Drawing.Size(112, 26)
        Me.nudNumber.TabIndex = 5
        Me.nudNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkDeleteCopyOf
        '
        Me.chkDeleteCopyOf.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkDeleteCopyOf.AutoSize = True
        Me.chkDeleteCopyOf.Location = New System.Drawing.Point(375, 72)
        Me.chkDeleteCopyOf.Name = "chkDeleteCopyOf"
        Me.chkDeleteCopyOf.Size = New System.Drawing.Size(127, 22)
        Me.chkDeleteCopyOf.TabIndex = 7
        Me.chkDeleteCopyOf.Text = "Delete Copy of"
        Me.chkDeleteCopyOf.UseVisualStyleBackColor = True
        '
        'TabMainForm
        '
        Me.TabMainForm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabMainForm.Controls.Add(Me.TabPage1)
        Me.TabMainForm.Controls.Add(Me.TabPage2)
        Me.TabMainForm.Controls.Add(Me.TabPage3)
        Me.TabMainForm.Controls.Add(Me.TabPage4)
        Me.TabMainForm.ItemSize = New System.Drawing.Size(80, 23)
        Me.TabMainForm.Location = New System.Drawing.Point(12, 403)
        Me.TabMainForm.Name = "TabMainForm"
        Me.TabMainForm.SelectedIndex = 0
        Me.TabMainForm.Size = New System.Drawing.Size(858, 139)
        Me.TabMainForm.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.lblSearch)
        Me.TabPage1.Controls.Add(Me.lblReplace)
        Me.TabPage1.Controls.Add(Me.txtSearch)
        Me.TabPage1.Controls.Add(Me.txtReplace)
        Me.TabPage1.Controls.Add(Me.btnSearchAndReplace)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(850, 108)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Search And Replace"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage2.Controls.Add(Me.txtPrefix)
        Me.TabPage2.Controls.Add(Me.lblPrefix)
        Me.TabPage2.Controls.Add(Me.lblSuffix)
        Me.TabPage2.Controls.Add(Me.txtSuffix)
        Me.TabPage2.Controls.Add(Me.btnAddPS)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(650, 108)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add Prefix / Suffix"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage3.Controls.Add(Me.btnCharToDel)
        Me.TabPage3.Controls.Add(Me.lblCharToDel)
        Me.TabPage3.Controls.Add(Me.nudNumberCharToDel)
        Me.TabPage3.Controls.Add(Me.lblStartNumberSmall)
        Me.TabPage3.Controls.Add(Me.lblMultiplyJumpSmall)
        Me.TabPage3.Controls.Add(Me.chkDeleteCopyOf)
        Me.TabPage3.Controls.Add(Me.lblMultiplyJump)
        Me.TabPage3.Controls.Add(Me.btnNumber)
        Me.TabPage3.Controls.Add(Me.lblStartNumber)
        Me.TabPage3.Controls.Add(Me.nudNumber)
        Me.TabPage3.Controls.Add(Me.nudNumberGrow)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(650, 108)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Name Counting"
        '
        'btnCharToDel
        '
        Me.btnCharToDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCharToDel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCharToDel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharToDel.Location = New System.Drawing.Point(508, 28)
        Me.btnCharToDel.Name = "btnCharToDel"
        Me.btnCharToDel.Size = New System.Drawing.Size(134, 29)
        Me.btnCharToDel.TabIndex = 24
        Me.btnCharToDel.Text = "Delete Chars"
        Me.btnCharToDel.UseVisualStyleBackColor = True
        '
        'lblCharToDel
        '
        Me.lblCharToDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCharToDel.BackColor = System.Drawing.Color.White
        Me.lblCharToDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCharToDel.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCharToDel.Location = New System.Drawing.Point(2, 68)
        Me.lblCharToDel.Name = "lblCharToDel"
        Me.lblCharToDel.Size = New System.Drawing.Size(170, 26)
        Me.lblCharToDel.TabIndex = 22
        Me.lblCharToDel.Text = "Chars to delete:"
        '
        'nudNumberCharToDel
        '
        Me.nudNumberCharToDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.nudNumberCharToDel.Location = New System.Drawing.Point(178, 68)
        Me.nudNumberCharToDel.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudNumberCharToDel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumberCharToDel.Name = "nudNumberCharToDel"
        Me.nudNumberCharToDel.Size = New System.Drawing.Size(112, 26)
        Me.nudNumberCharToDel.TabIndex = 23
        Me.nudNumberCharToDel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStartNumberSmall
        '
        Me.lblStartNumberSmall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStartNumberSmall.AutoSize = True
        Me.lblStartNumberSmall.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartNumberSmall.Location = New System.Drawing.Point(296, 7)
        Me.lblStartNumberSmall.Name = "lblStartNumberSmall"
        Me.lblStartNumberSmall.Size = New System.Drawing.Size(157, 17)
        Me.lblStartNumberSmall.TabIndex = 21
        Me.lblStartNumberSmall.Text = "Max value is 100000000"
        '
        'lblMultiplyJumpSmall
        '
        Me.lblMultiplyJumpSmall.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMultiplyJumpSmall.AutoSize = True
        Me.lblMultiplyJumpSmall.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplyJumpSmall.Location = New System.Drawing.Point(296, 40)
        Me.lblMultiplyJumpSmall.Name = "lblMultiplyJumpSmall"
        Me.lblMultiplyJumpSmall.Size = New System.Drawing.Size(117, 17)
        Me.lblMultiplyJumpSmall.TabIndex = 20
        Me.lblMultiplyJumpSmall.Text = "Max value is 1000"
        '
        'lblMultiplyJump
        '
        Me.lblMultiplyJump.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMultiplyJump.BackColor = System.Drawing.Color.White
        Me.lblMultiplyJump.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMultiplyJump.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiplyJump.Location = New System.Drawing.Point(2, 36)
        Me.lblMultiplyJump.Name = "lblMultiplyJump"
        Me.lblMultiplyJump.Size = New System.Drawing.Size(170, 26)
        Me.lblMultiplyJump.TabIndex = 1
        Me.lblMultiplyJump.Text = "Multiply jump:"
        '
        'lblStartNumber
        '
        Me.lblStartNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStartNumber.BackColor = System.Drawing.Color.White
        Me.lblStartNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStartNumber.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartNumber.Location = New System.Drawing.Point(2, 3)
        Me.lblStartNumber.Name = "lblStartNumber"
        Me.lblStartNumber.Size = New System.Drawing.Size(170, 26)
        Me.lblStartNumber.TabIndex = 0
        Me.lblStartNumber.Text = "The start number:"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.TabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage4.Controls.Add(Me.txtConsole)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(650, 108)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Console"
        '
        'txtConsole
        '
        Me.txtConsole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConsole.BackColor = System.Drawing.Color.Black
        Me.txtConsole.Font = New System.Drawing.Font("Tahoma", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsole.ForeColor = System.Drawing.Color.Gainsboro
        Me.txtConsole.Location = New System.Drawing.Point(2, 3)
        Me.txtConsole.Multiline = True
        Me.txtConsole.Name = "txtConsole"
        Me.txtConsole.ReadOnly = True
        Me.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtConsole.Size = New System.Drawing.Size(644, 101)
        Me.txtConsole.TabIndex = 5
        '
        'lblAuthor
        '
        Me.lblAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(9, 628)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(269, 17)
        Me.lblAuthor.TabIndex = 22
        Me.lblAuthor.Text = "Full Manager © 2017 Grzegorz Pawęzowski"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackgroundImage = Global.FullManager.My.Resources.Resources.Refresh1
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.ForeColor = System.Drawing.Color.Transparent
        Me.btnRefresh.Location = New System.Drawing.Point(75, 549)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(60, 60)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'picBell
        '
        Me.picBell.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picBell.BackColor = System.Drawing.Color.Transparent
        Me.picBell.BackgroundImage = Global.FullManager.My.Resources.Resources.Bell_32x32
        Me.picBell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picBell.Location = New System.Drawing.Point(458, 395)
        Me.picBell.Name = "picBell"
        Me.picBell.Size = New System.Drawing.Size(32, 32)
        Me.picBell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picBell.TabIndex = 23
        Me.picBell.TabStop = False
        Me.picBell.Visible = False
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnHelp.BackgroundImage = Global.FullManager.My.Resources.Resources.adobe_reader_logo2
        Me.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHelp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(12, 548)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(60, 60)
        Me.btnHelp.TabIndex = 12
        Me.btnHelp.Text = "HELP"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 655)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.picBell)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.TabMainForm)
        Me.Controls.Add(Me.optSelected)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.txtManual)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lvwMain)
        Me.Controls.Add(Me.btnPNAsFN)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnInstanceName)
        Me.Controls.Add(Me.btnSaveAll)
        Me.Controls.Add(Me.btnSaveAsPN)
        Me.Controls.Add(Me.btnManual)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnApply)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(700, 550)
        Me.Name = "Form1"
        Me.Text = "Full Manager 1.7"
        CType(Me.nudNumberGrow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMainForm.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.nudNumberCharToDel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.picBell, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChangeButton As System.Windows.Forms.Button
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtManual As System.Windows.Forms.TextBox
    Friend WithEvents optAll As System.Windows.Forms.RadioButton
    Friend WithEvents optSelected As System.Windows.Forms.RadioButton
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblReplace As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents txtReplace As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchAndReplace As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnPNAsFN As System.Windows.Forms.Button
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents btnAddPS As System.Windows.Forms.Button
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSaveAsPN As System.Windows.Forms.Button
    Friend WithEvents btnSaveAll As System.Windows.Forms.Button
    Friend WithEvents btnInstanceName As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnManual As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvwMain As System.Windows.Forms.ListView
    Friend WithEvents btnNumber As System.Windows.Forms.Button
    Friend WithEvents nudNumberGrow As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkDeleteCopyOf As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabMainForm As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lblMultiplyJump As System.Windows.Forms.Label
    Friend WithEvents lblStartNumber As System.Windows.Forms.Label
    Friend WithEvents lblMultiplyJumpSmall As System.Windows.Forms.Label
    Friend WithEvents lblStartNumberSmall As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtConsole As System.Windows.Forms.TextBox
    Friend WithEvents lblAuthor As System.Windows.Forms.Label
    Friend WithEvents picBell As System.Windows.Forms.PictureBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblCharToDel As System.Windows.Forms.Label
    Friend WithEvents nudNumberCharToDel As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCharToDel As System.Windows.Forms.Button

End Class
