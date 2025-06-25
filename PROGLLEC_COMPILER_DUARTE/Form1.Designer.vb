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
        run_button = New Button()
        debugg_button = New Button()
        search_button = New Button()
        Search_bar = New TextBox()
        settings_button = New Button()
        terminal_button = New Button()
        edit_button = New Button()
        brgr_button = New Button()
        help_btn = New Button()
        edit_btn = New Button()
        hambrgr_btn = New Button()
        file_button = New Button()
        side_panel = New Panel()
        sideCode_panel = New FlowLayoutPanel()
        codeSample_1 = New Button()
        codeSample_2 = New Button()
        codeSample_3 = New Button()
        elipsis_button = New Button()
        fileExplorer_txt = New TextBox()
        code_panel = New Panel()
        main_panel = New Panel()
        line_number_box = New RichTextBox()
        main_code_editor = New RichTextBox()
        terminal_btn = New Button()
        header_panel.SuspendLayout()
        side_panel.SuspendLayout()
        sideCode_panel.SuspendLayout()
        main_panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' terminal_btn
        ' 
        terminal_btn.FlatStyle = FlatStyle.Popup
        terminal_btn.Font = New Font("Bauhaus 93", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        terminal_btn.ForeColor = Color.White
        terminal_btn.Location = New Point(150, 11)
        terminal_btn.Name = "terminal_btn"
        terminal_btn.Size = New Size(0, 0)
        terminal_btn.TabIndex = 6
        terminal_btn.Text = "Terminal"
        terminal_btn.UseVisualStyleBackColor = True
        ' 
        ' header_panel
        ' 
        header_panel.BackColor = Color.FromArgb(CByte(95), CByte(103), CByte(108))
        header_panel.BorderStyle = BorderStyle.Fixed3D
        header_panel.Controls.Add(run_button)
        header_panel.Controls.Add(debugg_button)
        header_panel.Controls.Add(search_button)
        header_panel.Controls.Add(Search_bar)
        header_panel.Controls.Add(settings_button)
        header_panel.Controls.Add(terminal_button)
        header_panel.Controls.Add(edit_button)
        header_panel.Controls.Add(brgr_button)
        header_panel.Controls.Add(help_btn)
        header_panel.Controls.Add(terminal_btn)
        header_panel.Controls.Add(edit_btn)
        header_panel.Controls.Add(hambrgr_btn)
        header_panel.Controls.Add(file_button)
        header_panel.Dock = DockStyle.Top
        header_panel.Location = New Point(0, 0)
        header_panel.Name = "header_panel"
        header_panel.Size = New Size(949, 45)
        header_panel.TabIndex = 2
        ' 
        ' run_button
        ' 
        run_button.FlatStyle = FlatStyle.Popup
        run_button.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        run_button.ForeColor = Color.White
        run_button.Location = New Point(867, 2)
        run_button.Margin = New Padding(2)
        run_button.Name = "run_button"
        run_button.Size = New Size(35, 35)
        run_button.TabIndex = 14
        run_button.Text = "▶"
        run_button.UseVisualStyleBackColor = True
        ' 
        ' debugg_button
        ' 
        debugg_button.FlatStyle = FlatStyle.Popup
        debugg_button.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        debugg_button.ForeColor = Color.White
        debugg_button.Location = New Point(906, 2)
        debugg_button.Margin = New Padding(2)
        debugg_button.Name = "debugg_button"
        debugg_button.Size = New Size(35, 35)
        debugg_button.TabIndex = 13
        debugg_button.Text = "🐞"
        debugg_button.UseVisualStyleBackColor = True
        ' 
        ' search_button
        ' 
        search_button.AutoSize = True
        search_button.BackColor = Color.FromArgb(CByte(95), CByte(103), CByte(108))
        search_button.FlatStyle = FlatStyle.Flat
        search_button.ForeColor = Color.White
        search_button.Location = New Point(246, 5)
        search_button.Name = "search_button"
        search_button.Size = New Size(39, 31)
        search_button.TabIndex = 3
        search_button.Text = "🔎"
        search_button.UseVisualStyleBackColor = False
        ' 
        ' Search_bar
        ' 
        Search_bar.BackColor = Color.FromArgb(CByte(95), CByte(103), CByte(108))
        Search_bar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Search_bar.Location = New Point(286, 6)
        Search_bar.Name = "Search_bar"
        Search_bar.Size = New Size(506, 29)
        Search_bar.TabIndex = 12
        ' 
        ' settings_button
        ' 
        settings_button.FlatStyle = FlatStyle.Popup
        settings_button.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        settings_button.ForeColor = Color.White
        settings_button.Location = New Point(159, 2)
        settings_button.Margin = New Padding(2)
        settings_button.Name = "settings_button"
        settings_button.Size = New Size(35, 35)
        settings_button.TabIndex = 11
        settings_button.Text = "⚙️"
        settings_button.UseVisualStyleBackColor = True
        ' 
        ' terminal_button
        ' 
        terminal_button.FlatStyle = FlatStyle.Popup
        terminal_button.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        terminal_button.ForeColor = Color.White
        terminal_button.Location = New Point(120, 2)
        terminal_button.Margin = New Padding(2)
        terminal_button.Name = "terminal_button"
        terminal_button.Size = New Size(35, 35)
        terminal_button.TabIndex = 10
        terminal_button.Text = "🖥️"
        terminal_button.UseVisualStyleBackColor = True
        ' 
        ' edit_button
        ' 
        edit_button.FlatStyle = FlatStyle.Popup
        edit_button.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        edit_button.ForeColor = Color.White
        edit_button.Location = New Point(81, 2)
        edit_button.Margin = New Padding(2)
        edit_button.Name = "edit_button"
        edit_button.Size = New Size(35, 35)
        edit_button.TabIndex = 9
        edit_button.Text = "📝"
        edit_button.UseVisualStyleBackColor = True
        ' 
        ' brgr_button
        ' 
        brgr_button.FlatStyle = FlatStyle.Popup
        brgr_button.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        brgr_button.ForeColor = Color.White
        brgr_button.Location = New Point(3, 2)
        brgr_button.Margin = New Padding(2)
        brgr_button.Name = "brgr_button"
        brgr_button.Size = New Size(35, 35)
        brgr_button.TabIndex = 8
        brgr_button.Text = "☰"
        brgr_button.UseVisualStyleBackColor = True
        ' 
        ' help_btn
        ' 
        help_btn.FlatStyle = FlatStyle.Popup
        help_btn.Font = New Font("Bauhaus 93", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        help_btn.ForeColor = Color.White
        help_btn.Location = New Point(227, 3)
        help_btn.Name = "help_btn"
        help_btn.Size = New Size(0, 0)
        help_btn.TabIndex = 7
        help_btn.Text = "Help"
        help_btn.UseVisualStyleBackColor = True
        ' 
        ' edit_btn
        ' 
        edit_btn.FlatStyle = FlatStyle.Popup
        edit_btn.Font = New Font("Bauhaus 93", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        edit_btn.ForeColor = Color.White
        edit_btn.Location = New Point(102, 3)
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
        hambrgr_btn.Location = New Point(3, 3)
        hambrgr_btn.Name = "hambrgr_btn"
        hambrgr_btn.Size = New Size(0, 0)
        hambrgr_btn.TabIndex = 4
        hambrgr_btn.Text = "☰" & vbCrLf
        hambrgr_btn.UseVisualStyleBackColor = True
        ' 
        ' file_button
        ' 
        file_button.FlatStyle = FlatStyle.Popup
        file_button.Font = New Font("Bauhaus 93", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        file_button.ForeColor = Color.White
        file_button.Location = New Point(42, 2)
        file_button.Margin = New Padding(2)
        file_button.Name = "file_button"
        file_button.Size = New Size(35, 35)
        file_button.TabIndex = 3
        file_button.Text = "💾"
        file_button.UseVisualStyleBackColor = True
        ' 
        ' side_panel
        ' 
        side_panel.BackColor = Color.FromArgb(CByte(95), CByte(103), CByte(108))
        side_panel.BorderStyle = BorderStyle.FixedSingle
        side_panel.Controls.Add(sideCode_panel)
        side_panel.Controls.Add(elipsis_button)
        side_panel.Controls.Add(fileExplorer_txt)
        side_panel.Location = New Point(0, 43)
        side_panel.Name = "side_panel"
        side_panel.Size = New Size(196, 582)
        side_panel.TabIndex = 3
        ' 
        ' sideCode_panel
        ' 
        sideCode_panel.BorderStyle = BorderStyle.Fixed3D
        sideCode_panel.Controls.Add(codeSample_1)
        sideCode_panel.Controls.Add(codeSample_2)
        sideCode_panel.Controls.Add(codeSample_3)
        sideCode_panel.Location = New Point(6, 41)
        sideCode_panel.Name = "sideCode_panel"
        sideCode_panel.Size = New Size(181, 533)
        sideCode_panel.TabIndex = 2
        ' 
        ' codeSample_1
        ' 
        codeSample_1.BackColor = Color.FromArgb(CByte(81), CByte(91), CByte(101))
        codeSample_1.FlatStyle = FlatStyle.Popup
        codeSample_1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        codeSample_1.ForeColor = Color.FromArgb(CByte(226), CByte(82), CByte(114))
        codeSample_1.Location = New Point(3, 3)
        codeSample_1.Name = "codeSample_1"
        codeSample_1.Size = New Size(170, 26)
        codeSample_1.TabIndex = 0
        codeSample_1.Text = "calculator.cpp"
        codeSample_1.TextAlign = ContentAlignment.MiddleLeft
        codeSample_1.UseVisualStyleBackColor = False
        ' 
        ' codeSample_2
        ' 
        codeSample_2.BackColor = Color.FromArgb(CByte(81), CByte(91), CByte(101))
        codeSample_2.FlatStyle = FlatStyle.Popup
        codeSample_2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        codeSample_2.ForeColor = Color.FromArgb(CByte(226), CByte(82), CByte(114))
        codeSample_2.Location = New Point(3, 35)
        codeSample_2.Name = "codeSample_2"
        codeSample_2.Size = New Size(170, 26)
        codeSample_2.TabIndex = 1
        codeSample_2.Text = "banking.cpp"
        codeSample_2.TextAlign = ContentAlignment.MiddleLeft
        codeSample_2.UseVisualStyleBackColor = False
        ' 
        ' codeSample_3
        ' 
        codeSample_3.BackColor = Color.FromArgb(CByte(81), CByte(91), CByte(101))
        codeSample_3.FlatStyle = FlatStyle.Popup
        codeSample_3.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        codeSample_3.ForeColor = Color.FromArgb(CByte(226), CByte(82), CByte(114))
        codeSample_3.Location = New Point(3, 67)
        codeSample_3.Name = "codeSample_3"
        codeSample_3.Size = New Size(170, 26)
        codeSample_3.TabIndex = 2
        codeSample_3.Text = "RPS.cpp"
        codeSample_3.TextAlign = ContentAlignment.MiddleLeft
        codeSample_3.UseVisualStyleBackColor = False
        ' 
        ' elipsis_button
        ' 
        elipsis_button.FlatStyle = FlatStyle.Popup
        elipsis_button.Font = New Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        elipsis_button.ForeColor = Color.White
        elipsis_button.Location = New Point(148, 10)
        elipsis_button.Name = "elipsis_button"
        elipsis_button.Size = New Size(39, 24)
        elipsis_button.TabIndex = 1
        elipsis_button.Text = "····"
        elipsis_button.UseVisualStyleBackColor = True
        ' 
        ' fileExplorer_txt
        ' 
        fileExplorer_txt.BorderStyle = BorderStyle.FixedSingle
        fileExplorer_txt.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fileExplorer_txt.Location = New Point(6, 10)
        fileExplorer_txt.Name = "fileExplorer_txt"
        fileExplorer_txt.Size = New Size(111, 25)
        fileExplorer_txt.TabIndex = 0
        fileExplorer_txt.Text = "FILE EXPLORER"
        fileExplorer_txt.TextAlign = HorizontalAlignment.Center
        ' 
        ' code_panel
        ' 
        code_panel.BackColor = Color.FromArgb(CByte(95), CByte(103), CByte(108))
        code_panel.Location = New Point(197, 43)
        code_panel.Name = "code_panel"
        code_panel.Size = New Size(752, 50)
        code_panel.TabIndex = 4
        ' 
        ' main_panel
        ' 
        main_panel.BackColor = Color.FromArgb(CByte(81), CByte(91), CByte(101))
        main_panel.Controls.Add(line_number_box)
        main_panel.Controls.Add(main_code_editor)
        main_panel.Location = New Point(197, 85)
        main_panel.Name = "main_panel"
        main_panel.Size = New Size(752, 546)
        main_panel.TabIndex = 5
        ' 
        ' line_number_box
        ' 
        line_number_box.BackColor = Color.FromArgb(CByte(81), CByte(91), CByte(101))
        line_number_box.Location = New Point(4, 5)
        line_number_box.Name = "line_number_box"
        line_number_box.Size = New Size(28, 528)
        line_number_box.TabIndex = 1
        line_number_box.Text = ""
        ' 
        ' main_code_editor
        ' 
        main_code_editor.BackColor = Color.FromArgb(CByte(81), CByte(91), CByte(101))
        main_code_editor.Font = New Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        main_code_editor.Location = New Point(60, 6)
        main_code_editor.Name = "main_code_editor"
        main_code_editor.Size = New Size(709, 527)
        main_code_editor.TabIndex = 0
        main_code_editor.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(949, 624)
        Controls.Add(main_panel)
        Controls.Add(code_panel)
        Controls.Add(side_panel)
        Controls.Add(header_panel)
        ForeColor = Color.DarkRed
        FormBorderStyle = FormBorderStyle.Fixed3D
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        ImeMode = ImeMode.On
        IsMdiContainer = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "COMPILER NI JUDE ANTHONE R. DUARTE"
        header_panel.ResumeLayout(False)
        header_panel.PerformLayout()
        side_panel.ResumeLayout(False)
        side_panel.PerformLayout()
        sideCode_panel.ResumeLayout(False)
        main_panel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents header_panel As Panel
    Friend WithEvents file_button As Button
    Friend WithEvents hambrgr_btn As Button
    Friend WithEvents edit_btn As Button
    Friend WithEvents help_btn As Button
    Friend WithEvents brgr_button As Button
    Friend WithEvents settings_button As Button
    Friend WithEvents terminal_button As Button
    Friend WithEvents edit_button As Button
    Friend WithEvents Search_bar As TextBox
    Friend WithEvents search_button As Button
    Friend WithEvents run_button As Button
    Friend WithEvents debugg_button As Button
    Friend WithEvents side_panel As Panel
    Friend WithEvents code_panel As Panel
    Friend WithEvents main_panel As Panel
    Friend WithEvents fileExplorer_txt As TextBox
    Friend WithEvents elipsis_button As Button
    Friend WithEvents sideCode_panel As FlowLayoutPanel
    Friend WithEvents codeSample_1 As Button
    Friend WithEvents codeSample_2 As Button
    Friend WithEvents codeSample_3 As Button
    Friend WithEvents main_code_editor As RichTextBox
    Friend WithEvents line_number_box As RichTextBox

End Class
