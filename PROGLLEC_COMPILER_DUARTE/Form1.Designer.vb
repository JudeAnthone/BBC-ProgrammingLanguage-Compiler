<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim terminal_btn As Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        header_panel = New Panel()
        btn_debug = New FontAwesome.Sharp.IconButton()
        btn_run = New FontAwesome.Sharp.IconButton()
        btn_search = New FontAwesome.Sharp.IconButton()
        btn_settings = New FontAwesome.Sharp.IconButton()
        btn_editfile = New FontAwesome.Sharp.IconButton()
        btn_save = New FontAwesome.Sharp.IconButton()
        btn_dropdown = New FontAwesome.Sharp.IconButton()
        Search_bar = New TextBox()
        help_btn = New Button()
        edit_btn = New Button()
        hambrgr_btn = New Button()
        pnl_titletop = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        btn_minimize = New FontAwesome.Sharp.IconButton()
        btn_maximize = New FontAwesome.Sharp.IconButton()
        btn_exit = New FontAwesome.Sharp.IconButton()
        side_panel = New Panel()
        btn_more = New FontAwesome.Sharp.IconButton()
        sideCode_panel = New FlowLayoutPanel()
        codeSample_1 = New Button()
        codeSample_3 = New Button()
        codeSample_2 = New Button()
        fileExplorer_txt = New TextBox()
        code_panel = New Panel()
        main_panel = New Panel()
        line_number_box = New RichTextBox()
        main_code_editor = New RichTextBox()
        rch_terminal = New RichTextBox()
        pnl_terminal = New Panel()
        lbl_terminal = New Label()
        Panel2 = New Panel()
        terminal_btn = New Button()
        header_panel.SuspendLayout()
        pnl_titletop.SuspendLayout()
        side_panel.SuspendLayout()
        sideCode_panel.SuspendLayout()
        main_panel.SuspendLayout()
        pnl_terminal.SuspendLayout()
        SuspendLayout()
        ' 
        ' terminal_btn
        ' 
        terminal_btn.FlatStyle = FlatStyle.Popup
        terminal_btn.Font = New Font("Bauhaus 93", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        terminal_btn.ForeColor = Color.White
        terminal_btn.Location = New Point(171, 15)
        terminal_btn.Margin = New Padding(3, 4, 3, 4)
        terminal_btn.Name = "terminal_btn"
        terminal_btn.Size = New Size(0, 0)
        terminal_btn.TabIndex = 6
        terminal_btn.Text = "Terminal"
        terminal_btn.UseVisualStyleBackColor = True
        ' 
        ' header_panel
        ' 
        header_panel.BackColor = Color.Black
        header_panel.BorderStyle = BorderStyle.Fixed3D
        header_panel.Controls.Add(btn_debug)
        header_panel.Controls.Add(btn_run)
        header_panel.Controls.Add(btn_search)
        header_panel.Controls.Add(btn_settings)
        header_panel.Controls.Add(btn_editfile)
        header_panel.Controls.Add(btn_save)
        header_panel.Controls.Add(btn_dropdown)
        header_panel.Controls.Add(Search_bar)
        header_panel.Controls.Add(help_btn)
        header_panel.Controls.Add(terminal_btn)
        header_panel.Controls.Add(edit_btn)
        header_panel.Controls.Add(hambrgr_btn)
        header_panel.Location = New Point(0, 49)
        header_panel.Margin = New Padding(0)
        header_panel.Name = "header_panel"
        header_panel.Size = New Size(1181, 66)
        header_panel.TabIndex = 2
        ' 
        ' btn_debug
        ' 
        btn_debug.BackColor = Color.DarkOrange
        btn_debug.FlatAppearance.BorderSize = 0
        btn_debug.FlatStyle = FlatStyle.Flat
        btn_debug.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_debug.ForeColor = Color.Black
        btn_debug.IconChar = FontAwesome.Sharp.IconChar.None
        btn_debug.IconColor = Color.Black
        btn_debug.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_debug.IconSize = 30
        btn_debug.Location = New Point(1129, 2)
        btn_debug.Margin = New Padding(0)
        btn_debug.Name = "btn_debug"
        btn_debug.Size = New Size(47, 49)
        btn_debug.TabIndex = 20
        btn_debug.Text = "🐞"
        btn_debug.UseVisualStyleBackColor = False
        ' 
        ' btn_run
        ' 
        btn_run.BackColor = Color.DarkOrange
        btn_run.FlatAppearance.BorderSize = 0
        btn_run.FlatStyle = FlatStyle.Flat
        btn_run.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_run.ForeColor = Color.Black
        btn_run.IconChar = FontAwesome.Sharp.IconChar.None
        btn_run.IconColor = Color.Black
        btn_run.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_run.IconSize = 30
        btn_run.Location = New Point(1080, 2)
        btn_run.Margin = New Padding(0)
        btn_run.Name = "btn_run"
        btn_run.Size = New Size(47, 49)
        btn_run.TabIndex = 19
        btn_run.Text = "▶"
        btn_run.UseVisualStyleBackColor = False
        ' 
        ' btn_search
        ' 
        btn_search.BackColor = Color.DarkOrange
        btn_search.FlatAppearance.BorderSize = 0
        btn_search.FlatStyle = FlatStyle.Flat
        btn_search.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_search.ForeColor = Color.Black
        btn_search.IconChar = FontAwesome.Sharp.IconChar.None
        btn_search.IconColor = Color.Black
        btn_search.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_search.IconSize = 30
        btn_search.Location = New Point(399, 8)
        btn_search.Margin = New Padding(0)
        btn_search.Name = "btn_search"
        btn_search.Size = New Size(47, 32)
        btn_search.TabIndex = 18
        btn_search.Text = "🔎"
        btn_search.UseVisualStyleBackColor = False
        ' 
        ' btn_settings
        ' 
        btn_settings.BackColor = Color.DarkOrange
        btn_settings.FlatAppearance.BorderSize = 0
        btn_settings.FlatStyle = FlatStyle.Flat
        btn_settings.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_settings.ForeColor = Color.Black
        btn_settings.IconChar = FontAwesome.Sharp.IconChar.None
        btn_settings.IconColor = Color.Black
        btn_settings.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_settings.IconSize = 30
        btn_settings.Location = New Point(153, 2)
        btn_settings.Margin = New Padding(0)
        btn_settings.Name = "btn_settings"
        btn_settings.Size = New Size(47, 49)
        btn_settings.TabIndex = 17
        btn_settings.Text = "⚙️"
        btn_settings.UseVisualStyleBackColor = False
        ' 
        ' btn_editfile
        ' 
        btn_editfile.BackColor = Color.DarkOrange
        btn_editfile.FlatAppearance.BorderSize = 0
        btn_editfile.FlatStyle = FlatStyle.Flat
        btn_editfile.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_editfile.ForeColor = Color.Black
        btn_editfile.IconChar = FontAwesome.Sharp.IconChar.None
        btn_editfile.IconColor = Color.Black
        btn_editfile.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_editfile.IconSize = 30
        btn_editfile.Location = New Point(105, 2)
        btn_editfile.Margin = New Padding(0)
        btn_editfile.Name = "btn_editfile"
        btn_editfile.Size = New Size(47, 49)
        btn_editfile.TabIndex = 16
        btn_editfile.Text = "📝"
        btn_editfile.UseVisualStyleBackColor = False
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.DarkOrange
        btn_save.FlatAppearance.BorderSize = 0
        btn_save.FlatStyle = FlatStyle.Flat
        btn_save.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_save.ForeColor = Color.Black
        btn_save.IconChar = FontAwesome.Sharp.IconChar.None
        btn_save.IconColor = Color.Black
        btn_save.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_save.IconSize = 30
        btn_save.Location = New Point(57, 2)
        btn_save.Margin = New Padding(0)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(47, 49)
        btn_save.TabIndex = 15
        btn_save.Text = "💾"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_dropdown
        ' 
        btn_dropdown.BackColor = Color.DarkOrange
        btn_dropdown.FlatAppearance.BorderSize = 0
        btn_dropdown.FlatStyle = FlatStyle.Flat
        btn_dropdown.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_dropdown.ForeColor = Color.Black
        btn_dropdown.IconChar = FontAwesome.Sharp.IconChar.None
        btn_dropdown.IconColor = Color.Black
        btn_dropdown.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_dropdown.IconSize = 30
        btn_dropdown.Location = New Point(9, 2)
        btn_dropdown.Margin = New Padding(0)
        btn_dropdown.Name = "btn_dropdown"
        btn_dropdown.Size = New Size(47, 49)
        btn_dropdown.TabIndex = 3
        btn_dropdown.Text = "☰"
        btn_dropdown.UseVisualStyleBackColor = False
        ' 
        ' Search_bar
        ' 
        Search_bar.BackColor = Color.Black
        Search_bar.BorderStyle = BorderStyle.FixedSingle
        Search_bar.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Search_bar.ForeColor = Color.DarkOrange
        Search_bar.Location = New Point(447, 8)
        Search_bar.Margin = New Padding(3, 4, 3, 4)
        Search_bar.Name = "Search_bar"
        Search_bar.Size = New Size(578, 34)
        Search_bar.TabIndex = 12
        ' 
        ' help_btn
        ' 
        help_btn.FlatStyle = FlatStyle.Popup
        help_btn.Font = New Font("Bauhaus 93", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        help_btn.ForeColor = Color.White
        help_btn.Location = New Point(259, 4)
        help_btn.Margin = New Padding(3, 4, 3, 4)
        help_btn.Name = "help_btn"
        help_btn.Size = New Size(0, 0)
        help_btn.TabIndex = 7
        help_btn.Text = "Help"
        help_btn.UseVisualStyleBackColor = True
        ' 
        ' edit_btn
        ' 
        edit_btn.FlatStyle = FlatStyle.Popup
        edit_btn.Font = New Font("Bauhaus 93", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        edit_btn.ForeColor = Color.White
        edit_btn.Location = New Point(117, 4)
        edit_btn.Margin = New Padding(3, 4, 3, 4)
        edit_btn.Name = "edit_btn"
        edit_btn.Size = New Size(0, 0)
        edit_btn.TabIndex = 5
        edit_btn.Text = "📝"
        edit_btn.UseVisualStyleBackColor = True
        ' 
        ' hambrgr_btn
        ' 
        hambrgr_btn.FlatStyle = FlatStyle.Popup
        hambrgr_btn.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hambrgr_btn.ForeColor = Color.White
        hambrgr_btn.Location = New Point(3, 4)
        hambrgr_btn.Margin = New Padding(3, 4, 3, 4)
        hambrgr_btn.Name = "hambrgr_btn"
        hambrgr_btn.Size = New Size(0, 0)
        hambrgr_btn.TabIndex = 4
        hambrgr_btn.Text = "☰" & vbCrLf
        hambrgr_btn.UseVisualStyleBackColor = True
        ' 
        ' pnl_titletop
        ' 
        pnl_titletop.BackColor = Color.DarkOrange
        pnl_titletop.Controls.Add(Panel1)
        pnl_titletop.Controls.Add(Label1)
        pnl_titletop.Controls.Add(btn_minimize)
        pnl_titletop.Controls.Add(btn_maximize)
        pnl_titletop.Controls.Add(btn_exit)
        pnl_titletop.Dock = DockStyle.Top
        pnl_titletop.ForeColor = Color.DarkOrange
        pnl_titletop.Location = New Point(0, 0)
        pnl_titletop.Margin = New Padding(3, 4, 3, 4)
        pnl_titletop.Name = "pnl_titletop"
        pnl_titletop.Size = New Size(1183, 40)
        pnl_titletop.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(95), CByte(103), CByte(108))
        Panel1.Location = New Point(2, 45)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(948, 10)
        Panel1.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Left
        Label1.Font = New Font("Segoe UI Black", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(0, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 41)
        Label1.TabIndex = 1
        Label1.Text = " BBC CUMPILER"
        ' 
        ' btn_minimize
        ' 
        btn_minimize.BackColor = Color.DarkOrange
        btn_minimize.FlatAppearance.BorderSize = 0
        btn_minimize.FlatStyle = FlatStyle.Flat
        btn_minimize.Font = New Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_minimize.ForeColor = Color.Black
        btn_minimize.IconChar = FontAwesome.Sharp.IconChar.None
        btn_minimize.IconColor = Color.Black
        btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_minimize.IconSize = 30
        btn_minimize.Location = New Point(975, -9)
        btn_minimize.Margin = New Padding(0)
        btn_minimize.Name = "btn_minimize"
        btn_minimize.Size = New Size(64, 49)
        btn_minimize.TabIndex = 2
        btn_minimize.Text = "−"
        btn_minimize.TextAlign = ContentAlignment.TopCenter
        btn_minimize.UseVisualStyleBackColor = False
        ' 
        ' btn_maximize
        ' 
        btn_maximize.BackColor = Color.DarkOrange
        btn_maximize.Dock = DockStyle.Right
        btn_maximize.FlatStyle = FlatStyle.Flat
        btn_maximize.ForeColor = Color.DarkOrange
        btn_maximize.IconChar = FontAwesome.Sharp.IconChar.SquareFull
        btn_maximize.IconColor = Color.Black
        btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_maximize.IconSize = 30
        btn_maximize.Location = New Point(1039, 0)
        btn_maximize.Margin = New Padding(0)
        btn_maximize.Name = "btn_maximize"
        btn_maximize.Size = New Size(72, 40)
        btn_maximize.TabIndex = 1
        btn_maximize.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.BackColor = Color.DarkOrange
        btn_exit.Dock = DockStyle.Right
        btn_exit.FlatStyle = FlatStyle.Flat
        btn_exit.ForeColor = Color.DarkOrange
        btn_exit.IconChar = FontAwesome.Sharp.IconChar.X
        btn_exit.IconColor = Color.Black
        btn_exit.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_exit.IconSize = 30
        btn_exit.Location = New Point(1111, 0)
        btn_exit.Margin = New Padding(0)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(72, 40)
        btn_exit.TabIndex = 0
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' side_panel
        ' 
        side_panel.BackColor = Color.Black
        side_panel.Controls.Add(btn_more)
        side_panel.Controls.Add(sideCode_panel)
        side_panel.Controls.Add(fileExplorer_txt)
        side_panel.Location = New Point(0, 115)
        side_panel.Margin = New Padding(0)
        side_panel.Name = "side_panel"
        side_panel.Size = New Size(227, 522)
        side_panel.TabIndex = 3
        ' 
        ' btn_more
        ' 
        btn_more.BackColor = Color.DarkOrange
        btn_more.FlatAppearance.BorderSize = 0
        btn_more.FlatStyle = FlatStyle.Flat
        btn_more.Font = New Font("Arial Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_more.ForeColor = Color.Black
        btn_more.IconChar = FontAwesome.Sharp.IconChar.None
        btn_more.IconColor = Color.Black
        btn_more.IconFont = FontAwesome.Sharp.IconFont.Solid
        btn_more.IconSize = 30
        btn_more.Location = New Point(167, 2)
        btn_more.Margin = New Padding(0)
        btn_more.Name = "btn_more"
        btn_more.Size = New Size(47, 32)
        btn_more.TabIndex = 21
        btn_more.Text = "····"
        btn_more.UseVisualStyleBackColor = False
        ' 
        ' sideCode_panel
        ' 
        sideCode_panel.Controls.Add(codeSample_1)
        sideCode_panel.Controls.Add(codeSample_3)
        sideCode_panel.Controls.Add(codeSample_2)
        sideCode_panel.Location = New Point(12, 40)
        sideCode_panel.Margin = New Padding(3, 4, 3, 4)
        sideCode_panel.Name = "sideCode_panel"
        sideCode_panel.Size = New Size(206, 532)
        sideCode_panel.TabIndex = 2
        ' 
        ' codeSample_1
        ' 
        codeSample_1.BackColor = Color.SandyBrown
        codeSample_1.FlatStyle = FlatStyle.Popup
        codeSample_1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        codeSample_1.ForeColor = Color.Black
        codeSample_1.Location = New Point(3, 4)
        codeSample_1.Margin = New Padding(3, 4, 3, 4)
        codeSample_1.Name = "codeSample_1"
        codeSample_1.Size = New Size(194, 35)
        codeSample_1.TabIndex = 0
        codeSample_1.Text = "calculator.cpp"
        codeSample_1.TextAlign = ContentAlignment.MiddleLeft
        codeSample_1.UseVisualStyleBackColor = False
        ' 
        ' codeSample_3
        ' 
        codeSample_3.BackColor = Color.SandyBrown
        codeSample_3.FlatStyle = FlatStyle.Popup
        codeSample_3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        codeSample_3.ForeColor = Color.Black
        codeSample_3.Location = New Point(3, 47)
        codeSample_3.Margin = New Padding(3, 4, 3, 4)
        codeSample_3.Name = "codeSample_3"
        codeSample_3.Size = New Size(194, 35)
        codeSample_3.TabIndex = 2
        codeSample_3.Text = "RPS.cpp"
        codeSample_3.TextAlign = ContentAlignment.MiddleLeft
        codeSample_3.UseVisualStyleBackColor = False
        ' 
        ' codeSample_2
        ' 
        codeSample_2.BackColor = Color.SandyBrown
        codeSample_2.FlatStyle = FlatStyle.Popup
        codeSample_2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        codeSample_2.ForeColor = Color.Black
        codeSample_2.Location = New Point(3, 90)
        codeSample_2.Margin = New Padding(3, 4, 3, 4)
        codeSample_2.Name = "codeSample_2"
        codeSample_2.Size = New Size(194, 35)
        codeSample_2.TabIndex = 1
        codeSample_2.Text = "banking.cpp"
        codeSample_2.TextAlign = ContentAlignment.MiddleLeft
        codeSample_2.UseVisualStyleBackColor = False
        ' 
        ' fileExplorer_txt
        ' 
        fileExplorer_txt.BackColor = Color.DarkOrange
        fileExplorer_txt.BorderStyle = BorderStyle.FixedSingle
        fileExplorer_txt.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fileExplorer_txt.Location = New Point(6, 3)
        fileExplorer_txt.Margin = New Padding(3, 4, 3, 4)
        fileExplorer_txt.Name = "fileExplorer_txt"
        fileExplorer_txt.Size = New Size(127, 29)
        fileExplorer_txt.TabIndex = 0
        fileExplorer_txt.Text = "FILE EXPLORER"
        fileExplorer_txt.TextAlign = HorizontalAlignment.Center
        ' 
        ' code_panel
        ' 
        code_panel.BackColor = Color.DarkOrange
        code_panel.Location = New Point(0, 104)
        code_panel.Margin = New Padding(0)
        code_panel.Name = "code_panel"
        code_panel.Size = New Size(1180, 11)
        code_panel.TabIndex = 4
        ' 
        ' main_panel
        ' 
        main_panel.BackColor = Color.DarkOrange
        main_panel.Controls.Add(line_number_box)
        main_panel.Controls.Add(main_code_editor)
        main_panel.Location = New Point(225, 115)
        main_panel.Margin = New Padding(0)
        main_panel.Name = "main_panel"
        main_panel.Size = New Size(953, 522)
        main_panel.TabIndex = 5
        ' 
        ' line_number_box
        ' 
        line_number_box.BackColor = Color.Black
        line_number_box.BorderStyle = BorderStyle.None
        line_number_box.ForeColor = Color.DarkOrange
        line_number_box.Location = New Point(5, 7)
        line_number_box.Margin = New Padding(3, 4, 3, 4)
        line_number_box.Name = "line_number_box"
        line_number_box.Size = New Size(31, 509)
        line_number_box.TabIndex = 1
        line_number_box.Text = ""
        ' 
        ' main_code_editor
        ' 
        main_code_editor.BackColor = Color.Black
        main_code_editor.BorderStyle = BorderStyle.None
        main_code_editor.Font = New Font("Century Schoolbook", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        main_code_editor.ForeColor = Color.DarkOrange
        main_code_editor.Location = New Point(69, 8)
        main_code_editor.Margin = New Padding(3, 4, 3, 4)
        main_code_editor.Name = "main_code_editor"
        main_code_editor.Size = New Size(884, 508)
        main_code_editor.TabIndex = 0
        main_code_editor.Text = ""
        ' 
        ' rch_terminal
        ' 
        rch_terminal.BackColor = Color.Black
        rch_terminal.BorderStyle = BorderStyle.None
        rch_terminal.Dock = DockStyle.Bottom
        rch_terminal.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rch_terminal.ForeColor = Color.DarkOrange
        rch_terminal.Location = New Point(0, 676)
        rch_terminal.Name = "rch_terminal"
        rch_terminal.Size = New Size(1183, 173)
        rch_terminal.TabIndex = 7
        rch_terminal.Text = ""
        ' 
        ' pnl_terminal
        ' 
        pnl_terminal.BackColor = Color.DarkOrange
        pnl_terminal.Controls.Add(lbl_terminal)
        pnl_terminal.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pnl_terminal.ForeColor = Color.Black
        pnl_terminal.Location = New Point(0, 638)
        pnl_terminal.Margin = New Padding(0)
        pnl_terminal.Name = "pnl_terminal"
        pnl_terminal.Size = New Size(1180, 40)
        pnl_terminal.TabIndex = 5
        ' 
        ' lbl_terminal
        ' 
        lbl_terminal.AutoSize = True
        lbl_terminal.Font = New Font("Segoe UI Black", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_terminal.Location = New Point(490, -1)
        lbl_terminal.Name = "lbl_terminal"
        lbl_terminal.Size = New Size(246, 41)
        lbl_terminal.TabIndex = 0
        lbl_terminal.Text = "BBC TERMINAL"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Orange
        Panel2.Location = New Point(2, 39)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1181, 10)
        Panel2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(1183, 849)
        Controls.Add(Panel2)
        Controls.Add(pnl_titletop)
        Controls.Add(pnl_terminal)
        Controls.Add(rch_terminal)
        Controls.Add(main_panel)
        Controls.Add(code_panel)
        Controls.Add(side_panel)
        Controls.Add(header_panel)
        ForeColor = Color.DarkRed
        FormBorderStyle = FormBorderStyle.None
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        ImeMode = ImeMode.On
        IsMdiContainer = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "COMPILER NI JUDE ANTHONE R. DUARTE"
        header_panel.ResumeLayout(False)
        header_panel.PerformLayout()
        pnl_titletop.ResumeLayout(False)
        pnl_titletop.PerformLayout()
        side_panel.ResumeLayout(False)
        side_panel.PerformLayout()
        sideCode_panel.ResumeLayout(False)
        main_panel.ResumeLayout(False)
        pnl_terminal.ResumeLayout(False)
        pnl_terminal.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents header_panel As Panel
    Friend WithEvents hambrgr_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents help_btn As Button
    Friend WithEvents Search_bar As TextBox
    Friend WithEvents debugg_button As Button
    Friend WithEvents side_panel As Panel
    Friend WithEvents code_panel As Panel
    Friend WithEvents main_panel As Panel
    Friend WithEvents fileExplorer_txt As TextBox
    Friend WithEvents sideCode_panel As FlowLayoutPanel
    Friend WithEvents codeSample_1 As Button
    Friend WithEvents codeSample_2 As Button
    Friend WithEvents codeSample_3 As Button
    Friend WithEvents main_code_editor As RichTextBox
    Friend WithEvents line_number_box As RichTextBox
    Friend WithEvents rch_terminal As RichTextBox
    Friend WithEvents pnl_terminal As Panel
    Friend WithEvents lbl_terminal As Label
    Friend WithEvents pnl_titletop As Panel
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_dropdown As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_save As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_editfile As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_settings As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_run As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_debug As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_more As FontAwesome.Sharp.IconButton

End Class
