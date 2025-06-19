Public Class Form1
    'Dictionary for file management
    Private fileContents As New Dictionary(Of String, String)
    Private currentFile As String = ""

    'Arrays/ArrayLists for storage
    Private keywords As New ArrayList()
    Private variableNames As New ArrayList()
    Private variableValues As New ArrayList()
    Private operators As New ArrayList()
    Private output As New System.Text.StringBuilder()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeKeywords()
        InitializeOperators()
        LoadCode("codeSample_1")

        If Not fileContents.ContainsKey("codeSample_1") Then
            fileContents("codeSample_1") = GetEnglishSampleCode()
            main_code_editor.Text = fileContents("codeSample_1")
        End If
    End Sub

    Private Sub InitializeKeywords()
        keywords.Add("set")     'var assignment
        keywords.Add("print")   'output
        keywords.Add("if")      'conditional statement
        keywords.Add("then")    'if block
        keywords.Add("else")    'else block
        keywords.Add("end")     'end block
        keywords.Add("var")     'variable prefix
        keywords.Add("start")   'program start
        keywords.Add("comment") 'comment prefix type nyo "comment" instead na // 
        keywords.Add("true")    'Boolean true
        keywords.Add("false")   'Boolean false
        keywords.Add("count")   'for counting
        keywords.Add("times")   'loop iterations
        keywords.Add("do")      'actions
        keywords.Add("check")   'conditions
        keywords.Add("output")  'alternative print
    End Sub

    Private Sub InitializeOperators()
        operators.Add("=")
        operators.Add("+")
        operators.Add("-")
        operators.Add("*")
        operators.Add("/")
        operators.Add(">")
        operators.Add("<")
        operators.Add("==")
    End Sub

    'default code pag ni-run'
    Private Function GetEnglishSampleCode() As String
        Return "comment Welcome to BBC COMPILER!" & vbCrLf &
               "start programming" & vbCrLf &
               "" & vbCrLf &
               "set name = ""Pajeet""" & vbCrLf &
               "set lastname = "" Raju""" & vbCrLf &
               "set age = 15" & vbCrLf &
               "set money = 100" & vbCrLf &
               "" & vbCrLf &
               "print ""Hello World!""" & vbCrLf &
               "print ""My name is: "" + name + lastname" & vbCrLf &
               "print ""I am "" + age + "" years old""" & vbCrLf &
               "" & vbCrLf &
               "set total = money + 50" & vbCrLf &
               "print ""Total money: "" + total" & vbCrLf &
               "" & vbCrLf &
               "if age > 18 then" & vbCrLf &
               "    print ""Bulbulin ka na!""" & vbCrLf &
               "else" & vbCrLf &
               "    print ""Bata ka pa""" & vbCrLf &
               "end" & vbCrLf &
               "" & vbCrLf &
               "print ""HHHHHH!"""
    End Function

    'button logic'
    Private Sub file_button_Click(sender As Object, e As EventArgs) Handles file_button.Click
        MessageBox.Show("File menu - Manage your files here!", "File Menu")
    End Sub

    Private Sub edit_button_Click(sender As Object, e As EventArgs) Handles edit_button.Click
        MessageBox.Show("Edit menu - Edit your code here!", "Edit Menu")
    End Sub

    Private Sub terminal_button_Click(sender As Object, e As EventArgs) Handles terminal_button.Click
        Dim terminalOutput As New System.Text.StringBuilder()
        terminalOutput.AppendLine("=== TERMINAL ===")
        terminalOutput.AppendLine("Current Variables:")

        For i As Integer = 0 To variableNames.Count - 1
            terminalOutput.AppendLine($"var {variableNames(i)} = {variableValues(i)}")
        Next

        ShowOutputWindow(terminalOutput.ToString(), "Terminal")
    End Sub

    Private Sub settings_button_Click(sender As Object, e As EventArgs) Handles settings_button.Click
        Dim settingsInfo As String = "PROGRAMMING LANGUAGE SETTINGS" & vbCrLf & vbCrLf &
                                   "Keywords (Commands):" & vbCrLf

        For Each keyword As String In keywords
            settingsInfo += "- " + keyword + vbCrLf
        Next

        MessageBox.Show(settingsInfo, "Language Settings")
    End Sub

    Private Sub run_button_Click(sender As Object, e As EventArgs) Handles run_button.Click
        Try
            output.Clear()
            variableNames.Clear()
            variableValues.Clear()

            Dim sourceCode As String = main_code_editor.Text
            CompileAndRunCode(sourceCode)
            ShowOutputWindow(output.ToString(), "Program Output")

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Compilation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub debugg_button_Click(sender As Object, e As EventArgs) Handles debugg_button.Click
        Try
            Dim sourceCode As String = main_code_editor.Text
            Dim tokens = TokenizeCode(sourceCode)

            Dim debugInfo As New System.Text.StringBuilder()
            debugInfo.AppendLine("=== DEBUG INFO ===")
            debugInfo.AppendLine("Tokens found:")
            debugInfo.AppendLine()

            For Each token As Token In tokens
                debugInfo.AppendLine($"Type: {token.Type} | Value: '{token.Value}' | Line: {token.LineNumber}")
            Next

            debugInfo.AppendLine()
            debugInfo.AppendLine("Keywords in storage:")
            For Each keyword As String In keywords
                debugInfo.AppendLine("- " + keyword)
            Next

            ShowOutputWindow(debugInfo.ToString(), "Debug Info")

        Catch ex As Exception
            MessageBox.Show("Debug error: " & ex.Message, "Debug Error")
        End Try
    End Sub

    Public Class Token
        Public Property Type As String
        Public Property Value As String
        Public Property LineNumber As Integer

        Public Sub New(tokenType As String, tokenValue As String, lineNum As Integer)
            Type = tokenType
            Value = tokenValue
            LineNumber = lineNum
        End Sub
    End Class

    Private Function TokenizeCode(sourceCode As String) As ArrayList
        Dim tokens As New ArrayList()
        Dim lines() As String = sourceCode.Split({vbCrLf, vbLf}, StringSplitOptions.None)
        Dim lineNumber As Integer = 1

        For Each line As String In lines
            Dim trimmedLine As String = line.Trim()

            If String.IsNullOrEmpty(trimmedLine) OrElse trimmedLine.StartsWith("comment") Then
                lineNumber += 1
                Continue For
            End If

            Dim words As ArrayList = ParseLine(trimmedLine)

            For Each word As String In words
                If Not String.IsNullOrEmpty(word) Then
                    tokens.Add(ClassifyToken(word, lineNumber))
                End If
            Next

            tokens.Add(New Token("EOL", "", lineNumber))
            lineNumber += 1
        Next

        Return tokens
    End Function

    Private Function ParseLine(line As String) As ArrayList
        Dim words As New ArrayList()
        Dim currentWord As New System.Text.StringBuilder()
        Dim inString As Boolean = False
        Dim i As Integer = 0

        While i < line.Length
            Dim c As Char = line(i)

            If c = """"c Then
                If inString Then
                    currentWord.Append(c)
                    words.Add(currentWord.ToString())
                    currentWord.Clear()
                    inString = False
                Else
                    If currentWord.Length > 0 Then
                        words.Add(currentWord.ToString())
                        currentWord.Clear()
                    End If
                    currentWord.Append(c)
                    inString = True
                End If
            ElseIf inString Then
                currentWord.Append(c)
            ElseIf Char.IsWhiteSpace(c) Then
                If currentWord.Length > 0 Then
                    words.Add(currentWord.ToString())
                    currentWord.Clear()
                End If
            ElseIf IsOperatorChar(c) Then
                If currentWord.Length > 0 Then
                    words.Add(currentWord.ToString())
                    currentWord.Clear()
                End If

                If i + 1 < line.Length AndAlso line.Substring(i, 2) = "==" Then
                    words.Add("==")
                    i += 1
                Else
                    words.Add(c.ToString())
                End If
            Else
                currentWord.Append(c)
            End If

            i += 1
        End While

        If currentWord.Length > 0 Then
            words.Add(currentWord.ToString())
        End If

        Return words
    End Function

    Private Function IsOperatorChar(c As Char) As Boolean
        Dim operatorChars() As Char = {"+"c, "-"c, "*"c, "/"c, "="c, ">"c, "<"c}

        For Each opChar As Char In operatorChars
            If c = opChar Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function ClassifyToken(word As String, lineNum As Integer) As Token
        For Each keyword As String In keywords
            If word.ToLower() = keyword.ToLower() Then
                Return New Token("KEYWORD", keyword.ToLower(), lineNum)
            End If
        Next

        For Each op As String In operators
            If word = op Then
                Return New Token("OPERATOR", word, lineNum)
            End If
        Next

        If word.StartsWith("""") AndAlso word.EndsWith("""") Then
            Return New Token("STRING", word.Substring(1, word.Length - 2), lineNum)
        End If

        Dim numValue As Double
        If Double.TryParse(word, numValue) Then
            Return New Token("NUMBER", word, lineNum)
        End If

        Return New Token("IDENTIFIER", word, lineNum)
    End Function

    Private Sub CompileAndRunCode(sourceCode As String)
        Dim tokens As ArrayList = TokenizeCode(sourceCode)
        Dim i As Integer = 0

        While i < tokens.Count
            i = ProcessStatement(tokens, i)
        End While
    End Sub

    Private Function ProcessStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex

        While i < tokens.Count AndAlso CType(tokens(i), Token).Type = "EOL"
            i += 1
        End While

        If i >= tokens.Count Then Return i

        Dim currentToken As Token = CType(tokens(i), Token)

        If currentToken.Type = "KEYWORD" Then
            Select Case currentToken.Value.ToLower()
                Case "set"
                    Return ProcessSetStatement(tokens, i)
                Case "print"
                    Return ProcessPrintStatement(tokens, i)
                Case "if"
                    Return ProcessIfStatement(tokens, i)
                Case "start"
                    Return SkipToEndOfLine(tokens, i)
            End Select
        End If

        Return i + 1
    End Function

    Private Function ProcessSetStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex + 1

        If i >= tokens.Count OrElse CType(tokens(i), Token).Type <> "IDENTIFIER" Then
            Throw New Exception("Error: Variable name required!")
        End If

        Dim varName As String = CType(tokens(i), Token).Value
        i += 1

        If i >= tokens.Count OrElse CType(tokens(i), Token).Value <> "=" Then
            Throw New Exception("Error: Assignment operator '=' required!")
        End If

        i += 1

        Dim value As Object = EvaluateExpression(tokens, i)
        Dim varIndex As Integer = -1

        For j As Integer = 0 To variableNames.Count - 1
            If variableNames(j).ToString() = varName Then
                varIndex = j
                Exit For
            End If
        Next

        If varIndex >= 0 Then
            variableValues(varIndex) = value
        Else
            variableNames.Add(varName)
            variableValues.Add(value)
        End If

        Return SkipToEndOfLine(tokens, i)
    End Function

    Private Function ProcessPrintStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex + 1

        Dim result As Object = EvaluateExpression(tokens, i)
        output.AppendLine(result.ToString())

        Return SkipToEndOfLine(tokens, i)
    End Function

    Private Function ProcessIfStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex + 1

        Dim leftValue As Object = Nothing
        If i < tokens.Count Then
            Dim token As Token = CType(tokens(i), Token)
            If token.Type = "IDENTIFIER" Then
                leftValue = GetVariableValue(token.Value)
            ElseIf token.Type = "NUMBER" Then
                leftValue = Convert.ToDouble(token.Value)
            End If
            i += 1
        End If

        Dim comparisonOp As String = ""
        If i < tokens.Count AndAlso CType(tokens(i), Token).Type = "OPERATOR" Then
            comparisonOp = CType(tokens(i), Token).Value
            i += 1
        End If

        Dim rightValue As Object = Nothing
        If i < tokens.Count Then
            Dim token As Token = CType(tokens(i), Token)
            If token.Type = "IDENTIFIER" Then
                rightValue = GetVariableValue(token.Value)
            ElseIf token.Type = "NUMBER" Then
                rightValue = Convert.ToDouble(token.Value)
            End If
            i += 1
        End If

        While i < tokens.Count AndAlso CType(tokens(i), Token).Value.ToLower() <> "then"
            i += 1
        End While

        If i >= tokens.Count Then
            Throw New Exception("Error: 'then' keyword missing")
        End If

        i += 1

        Dim condition As Boolean = EvaluateCondition(leftValue, comparisonOp, rightValue)

        If condition Then
            While i < tokens.Count
                Dim token As Token = CType(tokens(i), Token)
                If token.Type = "KEYWORD" AndAlso (token.Value = "else" OrElse token.Value = "end") Then
                    Exit While
                End If
                i = ProcessStatement(tokens, i)
            End While

            If i < tokens.Count AndAlso CType(tokens(i), Token).Value = "else" Then
                i += 1
                While i < tokens.Count AndAlso CType(tokens(i), Token).Value <> "end"
                    i += 1
                End While
            End If
        Else
            While i < tokens.Count AndAlso CType(tokens(i), Token).Value <> "else" AndAlso CType(tokens(i), Token).Value <> "end"
                i += 1
            End While

            If i < tokens.Count AndAlso CType(tokens(i), Token).Value = "else" Then
                i += 1
                While i < tokens.Count AndAlso CType(tokens(i), Token).Value <> "end"
                    i = ProcessStatement(tokens, i)
                End While
            End If
        End If

        If i < tokens.Count AndAlso CType(tokens(i), Token).Value = "end" Then
            i += 1
        End If

        Return i
    End Function

    Private Function EvaluateExpression(tokens As ArrayList, ByRef index As Integer) As Object
        Dim result As Object = Nothing
        Dim currentOperator As String = ""

        While index < tokens.Count
            Dim token As Token = CType(tokens(index), Token)

            If token.Type = "EOL" OrElse token.Type = "KEYWORD" OrElse token.Value = "then" Then
                Exit While
            End If

            Select Case token.Type
                Case "STRING"
                    If result Is Nothing Then
                        result = token.Value
                    Else
                        If currentOperator = "+" Then
                            result = result.ToString() + token.Value
                        End If
                    End If

                Case "NUMBER"
                    If result Is Nothing Then
                        result = Convert.ToDouble(token.Value)
                    Else
                        Dim rightValue = Convert.ToDouble(token.Value)
                        result = PerformMathOperation(result, currentOperator, rightValue)
                    End If

                Case "IDENTIFIER"
                    Dim varValue As Object = GetVariableValue(token.Value)

                    If result Is Nothing Then
                        result = varValue
                    Else
                        If currentOperator = "+" Then
                            If TypeOf result Is String OrElse TypeOf varValue Is String Then
                                result = result.ToString() + varValue.ToString()
                            Else
                                result = Convert.ToDouble(result) + Convert.ToDouble(varValue)
                            End If
                        Else
                            result = PerformMathOperation(result, currentOperator, varValue)
                        End If
                    End If

                Case "OPERATOR"
                    currentOperator = token.Value
            End Select

            index += 1
        End While

        Return If(result, "")
    End Function

    Private Function GetVariableValue(varName As String) As Object
        For i As Integer = 0 To variableNames.Count - 1
            If variableNames(i).ToString() = varName Then
                Return variableValues(i)
            End If
        Next

        Throw New Exception($"Error: Variable '{varName}' not found!")
    End Function

    Private Function PerformMathOperation(left As Object, op As String, right As Object) As Object
        Dim leftNum As Double = Convert.ToDouble(left)
        Dim rightNum As Double = Convert.ToDouble(right)

        Select Case op
            Case "+"
                Return leftNum + rightNum
            Case "-"
                Return leftNum - rightNum
            Case "*"
                Return leftNum * rightNum
            Case "/"
                If rightNum = 0 Then
                    Throw New Exception("Error: Division by zero!")
                End If
                Return leftNum / rightNum
            Case Else
                Return leftNum
        End Select
    End Function

    Private Function EvaluateCondition(left As Object, op As String, right As Object) As Boolean
        Select Case op
            Case ">"
                Return Convert.ToDouble(left) > Convert.ToDouble(right)
            Case "<"
                Return Convert.ToDouble(left) < Convert.ToDouble(right)
            Case "=="
                Return left.ToString() = right.ToString()
            Case Else
                Return False
        End Select
    End Function

    Private Function SkipToEndOfLine(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex
        While i < tokens.Count AndAlso CType(tokens(i), Token).Type <> "EOL"
            i += 1
        End While
        Return i + 1
    End Function

    Private Sub ShowOutputWindow(content As String, title As String)
        Dim outputForm As New Form()
        outputForm.Text = title
        outputForm.Size = New Size(600, 500)
        outputForm.StartPosition = FormStartPosition.CenterParent

        Dim outputTextBox As New TextBox()
        outputTextBox.Multiline = True
        outputTextBox.ScrollBars = ScrollBars.Vertical
        outputTextBox.Dock = DockStyle.Fill
        outputTextBox.Text = content
        outputTextBox.ReadOnly = True
        outputTextBox.Font = New Font("Consolas", 11)
        outputTextBox.BackColor = Color.Black
        outputTextBox.ForeColor = Color.Lime

        outputForm.Controls.Add(outputTextBox)
        outputForm.Show()
    End Sub



    Private Sub codeSample_1_Click(sender As Object, e As EventArgs) Handles codeSample_1.Click
        SaveCurrentFile()
        LoadCode("codeSample_1")
    End Sub

    Private Sub codeSample_2_Click(sender As Object, e As EventArgs) Handles codeSample_2.Click
        SaveCurrentFile()
        LoadCode("codeSample_2")
    End Sub

    Private Sub codeSample_3_Click(sender As Object, e As EventArgs) Handles codeSample_3.Click
        SaveCurrentFile()
        LoadCode("codeSample_3")
    End Sub

    Private Sub codeSample_4_Click(sender As Object, e As EventArgs) Handles codeSample_4.Click
        SaveCurrentFile()
        LoadCode("codeSample_4")
    End Sub

    Private Sub codeSample_5_Click(sender As Object, e As EventArgs) Handles codeSample_5.Click
        SaveCurrentFile()
        LoadCode("codeSample_5")
    End Sub

    Private Sub main_code_editor_TextChanged(sender As Object, e As EventArgs) Handles main_code_editor.TextChanged
        UpdateLineNumbers()
    End Sub

    Private Sub SaveCurrentFile()
        If currentFile <> "" Then
            If fileContents.ContainsKey(currentFile) Then
                fileContents(currentFile) = main_code_editor.Text
            Else
                fileContents.Add(currentFile, main_code_editor.Text)
            End If
        End If
    End Sub


    Private Sub LoadCode(fileName As String)
        currentFile = fileName

        If fileContents.ContainsKey(fileName) Then
            main_code_editor.Text = fileContents(fileName)
        Else
            Select Case fileName
                Case "codeSample_1"
                    main_code_editor.Text = GetEnglishSampleCode()
                Case "codeSample_2"
                    main_code_editor.Text = "comment Simple Calculator" & vbCrLf &
                                          "set num1 = 10" & vbCrLf &
                                          "set num2 = 5" & vbCrLf &
                                          "print ""Addition: "" + (num1 + num2)"
                Case "codeSample_3"
                    main_code_editor.Text = "comment Sample" & vbCrLf &
                                          "set age = 21" & vbCrLf &
                                          "if age > 18 then" & vbCrLf &
                                          "    print ""Tanda ka na!""" & vbCrLf &
                                          "end"
                Case Else
                    main_code_editor.Text = "comment Sample" & vbCrLf &
                                          "set message = ""Hello World!""" & vbCrLf &
                                          "print message"
            End Select
            fileContents.Add(fileName, main_code_editor.Text)
        End If

        UpdateLineNumbers()
    End Sub

    Private Sub UpdateLineNumbers()
        line_number_box.SuspendLayout()
        line_number_box.Text = ""
        Dim totalLines As Integer = main_code_editor.Lines.Length

        For i As Integer = 1 To totalLines
            line_number_box.AppendText(i.ToString() & vbCrLf)
        Next

        line_number_box.ResumeLayout()
    End Sub

End Class