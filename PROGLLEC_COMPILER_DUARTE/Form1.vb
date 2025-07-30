'Test comment 7/30/2025 - unbroken version 2
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

        rounded_utils(btn_exit, btn_maximize, btn_minimize, btn_more)
        rounded_btn(btn_save, btn_editfile, btn_debug, btn_settings, btn_dropdown, btn_run)





    End Sub

    'keywords initialization
    'paki-palitan yung mga keywords natin ng medyo unique
    Private Sub InitializeKeywords()
        keywords.Add("idikitmo")     'var assignment 'set
        keywords.Add("ambatukam")   'output ''print
        keywords.Add("nig")      'conditional statement 'if
        keywords.Add("ken")    'if block 'then
        keywords.Add("ger")  'else-if block 'elseif
        keywords.Add("ga")    'else block 'else
        keywords.Add("kam")     'end block 'end
        keywords.Add("iyot")     'for loop 'loop
        keywords.Add("sa")      'for loop range 'to
        keywords.Add("labas")    'for loop end 'next
        keywords.Add("ilagaymo")     'variable prefix 'var
        keywords.Add("gora")   'program start 'start
        keywords.Add("cumment") 'comment prefix type nyo "comment" instead na //  'comment
        keywords.Add("typeshit")    'Boolean true 'true
        keywords.Add("nah")   'Boolean false 'false
        keywords.Add("huzz")   'for counting 'count
        keywords.Add("bruh")   'loop iterations 'times
        keywords.Add("lockin")      'actions 'do
        keywords.Add("pajeet")   'conditions 'check
        keywords.Add("jamal")  'alternative print 'alt print
    End Sub

    'operators initialization
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
        Return "cumment Welcome to BBC COMPILER!" & vbCrLf &
               "gora programming" & vbCrLf &
               "" & vbCrLf &
               "idikitmo name = ""Pajeet""" & vbCrLf &
               "idikitmo lastname = "" Raju""" & vbCrLf &
               "idikitmo age = 15" & vbCrLf &
               "idikitmo money = 100" & vbCrLf &
               "" & vbCrLf &
               "ambatukam ""Hello World!""" & vbCrLf &
               "ambatukam ""My name is: "" + name + lastname" & vbCrLf &
               "ambatukam ""I am "" + age + "" years old""" & vbCrLf &
               "" & vbCrLf &
               "idikitmo total = money + 50" & vbCrLf &
               "ambatukam ""Total money: "" + total" & vbCrLf &
               "" & vbCrLf &
               "nig age > 18 ken" & vbCrLf &
               "    ambatukam ""Bulbulin ka na!""" & vbCrLf &
               "ga" & vbCrLf &
               "    ambatukam ""Bata ka pa""" & vbCrLf &
               "kam" & vbCrLf &
               "" & vbCrLf &
               "ambatukam ""HHHHHH!"""
    End Function







    'Terminal button - available variables and their values

    'settings button - shows programming language


    'run button - compiles and runs the code
    Private Sub run_button_Click(sender As Object, e As EventArgs)
        Try
            output.Clear()
            variableNames.Clear()
            variableValues.Clear()
            rch_terminal.Clear()


            Dim sourceCode = main_code_editor.Text
            CompileAndRunCode(sourceCode)
            rch_terminal.Text = "=== OUTPUT ===" & vbCrLf & output.ToString


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Compilation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'debug button - kung anong kulang and mali sa syntax ng code
    Private Sub debugg_button_Click(sender As Object, e As EventArgs)
        Try
            Dim sourceCode = main_code_editor.Text
            Dim tokens = TokenizeCode(sourceCode)

            Dim debugInfo As New Text.StringBuilder
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

            rch_terminal.Text = "=== DEBUG INFO ===" & vbCrLf & debugInfo.ToString


        Catch ex As Exception
            MessageBox.Show("Debug error: " & ex.Message, "Debug Error")
        End Try
    End Sub

    'token
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


    'called when we run the code
    ' each line sa compiler is trimmed and disregarded yung spaces
    'if my line na walang laman, didisregard sya or if may nakalagay na "comment" (ito yung keyword natin for comment sa code)
    'yung line na may laman na code, mapupunta sa ParseLine wherein ParseLine is inchaarge sa pag analyze ng content ng specific line of code
    'after magawa ni ParseLine yung analyzation, proceed sa ClassifyToken. 
    'ClassifyToken basically each word ay chineckeck na galing sa ParseLine, chinecheck neto if may nagmatch ba sa keyword natin, if wala DISREGARD. 
    'if may nag match, gagawin nya yung keyword na yon. 
    Private Function TokenizeCode(sourceCode As String) As ArrayList
        Dim tokens As New ArrayList()

        Dim lines() As String = sourceCode.Split({vbCrLf, vbLf}, StringSplitOptions.None) 'each code line is split into 1, so ito yung reading per lines ni sir

        Dim lineNumber As Integer = 1


        For Each line As String In lines
            Dim trimmedLine As String = line.Trim()

            ' Change "comment" to "cumment" 
            If String.IsNullOrEmpty(trimmedLine) OrElse trimmedLine.StartsWith("cumment") Then
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


    'Each lines are passed here, each lines/words sa line of code are grouped, then nirereturn nya as ArrayList. 
    ' yung mga nireturn nya, mapupunta sa ClassifyToken. 
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


    'if may nagmatch na keyword sa ginawa natin (print, set or + -) na galing sa ParseLine, gagawin nya yon. 
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

    'dito na cocompile and tokenize yung code per line na galing sa ParseLine
    Private Sub CompileAndRunCode(sourceCode As String)
        Dim tokens As ArrayList = TokenizeCode(sourceCode)
        Dim i As Integer = 0

        While i < tokens.Count
            i = ProcessStatement(tokens, i)
        End While
    End Sub


    'Skipping empty lines
    ' chinecheck if yung keyword na detected is token ba o hindi
    Private Function ProcessStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex

        While i < tokens.Count AndAlso CType(tokens(i), Token).Type = "EOL"
            i += 1
        End While

        If i >= tokens.Count Then Return i

        Dim currentToken As Token = CType(tokens(i), Token)

        If currentToken.Type = "KEYWORD" Then
            Select Case currentToken.Value.ToLower()
                Case "idikitmo"
                    Return ProcessSetStatement(tokens, i)
                Case "ambatukam"
                    Return ProcessPrintStatement(tokens, i)
                Case "nig"
                    Return ProcessIfStatement(tokens, i)
                Case "ger"
                    Return i + 1
                Case "ga"
                    Return i + 1
                Case "iyot"
                    Return ProcessForStatement(tokens, i)
                Case "labas"
                    Return i + 1 ' handled in ProcessForStatement
                Case "gora"
                    Return SkipToEndOfLine(tokens, i)
            End Select
        End If

        Return i + 1
    End Function

    'Syntax checker
    Private Function ProcessSetStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex + 1

        If i >= tokens.Count OrElse CType(tokens(i), Token).Type <> "IDENTIFIER" Then
            Throw New Exception("Error: Variable name required!")
        End If

        Dim varName As String = CType(tokens(i), Token).Value
        i += 1

        ' Check for assignment operator - only '=' is allowed for variable assignment
        If i >= tokens.Count OrElse CType(tokens(i), Token).Type <> "OPERATOR" Then
            Throw New Exception("Error: Assignment operator '=' required!")
        End If

        Dim operatorToken As String = CType(tokens(i), Token).Value

        ' Check if the operator is anything other than '='
        If operatorToken <> "=" Then
            Throw New Exception("Sike! Bobo mo nigga")
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


    'Print 
    Private Function ProcessPrintStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex + 1

        Dim result As Object = EvaluateExpression(tokens, i)
        output.AppendLine(result.ToString())

        Return SkipToEndOfLine(tokens, i)
    End Function


    'Conditional statement checker
    Private Function ProcessIfStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex + 1

        ' Evaluate condition
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

        ' Look for "ken" instead of "then"
        While i < tokens.Count AndAlso CType(tokens(i), Token).Value.ToLower() <> "ken"
            i += 1
        End While

        If i >= tokens.Count Then
            Throw New Exception("Error: 'ken' keyword missing")
        End If

        i += 1

        Dim condition As Boolean = EvaluateCondition(leftValue, comparisonOp, rightValue)

        If condition Then
            ' Execute statements until ger/ga/kam (elseif/else/end)
            While i < tokens.Count
                Dim token As Token = CType(tokens(i), Token)
                If token.Type = "KEYWORD" AndAlso (token.Value = "ger" OrElse token.Value = "ga" OrElse token.Value = "kam") Then
                    Exit While
                End If
                i = ProcessStatement(tokens, i)
            End While

            ' Skip the rest of the if-elseif-else chain
            While i < tokens.Count
                Dim token As Token = CType(tokens(i), Token)
                If token.Type = "KEYWORD" AndAlso token.Value = "kam" Then
                    i += 1
                    Exit While
                End If
                i += 1
            End While
        Else
            ' Check for ger/ga (elseif/else)
            While i < tokens.Count
                Dim token As Token = CType(tokens(i), Token)
                If token.Type = "KEYWORD" AndAlso token.Value = "ger" Then
                    Return ProcessIfStatement(tokens, i)
                ElseIf token.Type = "KEYWORD" AndAlso token.Value = "ga" Then
                    i += 1
                    While i < tokens.Count AndAlso CType(tokens(i), Token).Value <> "kam"
                        i = ProcessStatement(tokens, i)
                    End While
                    If i < tokens.Count AndAlso CType(tokens(i), Token).Value = "kam" Then
                        i += 1
                    End If
                    Exit While
                ElseIf token.Type = "KEYWORD" AndAlso token.Value = "kam" Then
                    i += 1
                    Exit While
                End If
                i += 1
            End While
        End If

        Return i
    End Function


    'Expression checker
    'handle nya yung numbers, identifiers, strings, variables and operators na ginawa natin
    Private Function EvaluateExpression(tokens As ArrayList, ByRef index As Integer) As Object
        Dim result As Object = Nothing
        Dim currentOperator As String = ""

        While index < tokens.Count
            Dim token As Token = CType(tokens(index), Token)

            ' Change "then" to "ken" and add other custom keywords
            If token.Type = "EOL" OrElse token.Type = "KEYWORD" OrElse token.Value = "ken" OrElse token.Value = "sa" Then
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




    '-------------------------------------------------------------------'HELPER FUNCTIONS ---------------------------------------------------------------------------------'
    'Getting variable value
    Private Function GetVariableValue(varName As String) As Object
        For i As Integer = 0 To variableNames.Count - 1
            If variableNames(i).ToString() = varName Then
                Return variableValues(i)
            End If
        Next

        Throw New Exception($"Error: Variable '{varName}' not found!")
    End Function

    'arithmetic shit
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

    'Conditional statement shit
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


    'output window (DAPAT SA GAWA NATIN NA TERMINAL NA TO)
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


    'Code sample is yung mga files na nasa gilid (may functionality na mag-load ng code sa editor, need lang i-sure na gagana ng maayos)
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
                    main_code_editor.Text = "cumment Simple Calculator" & vbCrLf &
                                      "idikitmo num1 = 10" & vbCrLf &
                                      "idikitmo num2 = 5" & vbCrLf &
                                      "idikitmo answer = num1 + num2" & vbCrLf &
                                      "ambatukam ""Addition: "" + answer"
                Case "codeSample_3"
                    main_code_editor.Text = "cumment Sample with Loop" & vbCrLf &
                                      "idikitmo age = 21" & vbCrLf &
                                      "nig age > 18 ken" & vbCrLf &
                                      "    ambatukam ""Tanda ka na!""" & vbCrLf &
                                      "kam" & vbCrLf &
                                      "" & vbCrLf &
                                      "iyot i = 1 sa 3" & vbCrLf &
                                      "    ambatukam ""Count: "" + i" & vbCrLf &
                                      "labas"
                Case Else
                    main_code_editor.Text = "cumment Sample" & vbCrLf &
                                      "idikitmo message = ""Hello World!""" & vbCrLf &
                                      "ambatukam message"
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



    'Process for-loop statement
    Private Function ProcessForStatement(tokens As ArrayList, startIndex As Integer) As Integer
        Dim i As Integer = startIndex + 1

        ' Get loop variable
        If i >= tokens.Count OrElse CType(tokens(i), Token).Type <> "IDENTIFIER" Then
            Throw New Exception("Error: Loop variable required!")
        End If
        Dim loopVar As String = CType(tokens(i), Token).Value
        i += 1

        ' Expect '='
        If i >= tokens.Count OrElse CType(tokens(i), Token).Value <> "=" Then
            Throw New Exception("Error: '=' required in for loop!")
        End If
        i += 1

        ' Get start value
        Dim startValue As Object = EvaluateExpression(tokens, i)
        If Not IsNumeric(startValue) Then
            Throw New Exception("Error: For loop start value must be numeric!")
        End If

        ' Expect 'sa' instead of 'to'
        While i < tokens.Count AndAlso CType(tokens(i), Token).Value.ToLower() <> "sa"
            i += 1
        End While
        If i >= tokens.Count Then
            Throw New Exception("Error: 'sa' required in for loop!")
        End If
        i += 1

        ' Get end value
        Dim endValue As Object = EvaluateExpression(tokens, i)
        If Not IsNumeric(endValue) Then
            Throw New Exception("Error: For loop end value must be numeric!")
        End If

        ' Find the body of the loop (from after this line to matching 'labas')
        Dim bodyStart As Integer = SkipToEndOfLine(tokens, i)
        Dim bodyEnd As Integer = bodyStart
        Dim nestLevel As Integer = 1
        While bodyEnd < tokens.Count
            Dim t As Token = CType(tokens(bodyEnd), Token)
            If t.Type = "KEYWORD" Then
                If t.Value.ToLower() = "iyot" Then
                    nestLevel += 1
                ElseIf t.Value.ToLower() = "labas" Then
                    nestLevel -= 1
                    If nestLevel = 0 Then Exit While
                End If
            End If
            bodyEnd += 1
        End While
        If bodyEnd >= tokens.Count Then
            Throw New Exception("Error: 'labas' not found for for loop!")
        End If

        ' Save old value if variable exists
        Dim oldVarIndex As Integer = -1
        Dim oldVarValue As Object = Nothing
        For j As Integer = 0 To variableNames.Count - 1
            If variableNames(j).ToString() = loopVar Then
                oldVarIndex = j
                oldVarValue = variableValues(j)
                Exit For
            End If
        Next

        ' Loop execution
        For loopCounter As Integer = CInt(startValue) To CInt(endValue)
            If oldVarIndex >= 0 Then
                variableValues(oldVarIndex) = loopCounter
            Else
                If loopCounter = CInt(startValue) Then
                    variableNames.Add(loopVar)
                    variableValues.Add(loopCounter)
                    oldVarIndex = variableNames.Count - 1
                Else
                    variableValues(oldVarIndex) = loopCounter
                End If
            End If

            Dim k As Integer = bodyStart
            While k < bodyEnd
                k = ProcessStatement(tokens, k)
            End While
        Next

        ' Restore old value if existed, or remove if new
        If oldVarIndex >= 0 Then
            variableValues(oldVarIndex) = oldVarValue
        Else
            For j As Integer = 0 To variableNames.Count - 1
                If variableNames(j).ToString() = loopVar Then
                    variableNames.RemoveAt(j)
                    variableValues.RemoveAt(j)
                    Exit For
                End If
            Next
        End If

        Return bodyEnd + 1
    End Function

    Private Sub rounded_utils(ParamArray btnArr1() As Button)

        For Each btn As Button In btnArr1
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.DarkOrange
            btn.ForeColor = Color.Black
            btn.FlatAppearance.MouseOverBackColor = Color.Peru
            btn.FlatAppearance.MouseDownBackColor = Color.Orange

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
            Dim iconBtn As FontAwesome.Sharp.IconButton = CType(btn, FontAwesome.Sharp.IconButton)
            iconBtn.IconColor = Color.Black

            AddHandler btn.MouseEnter, Sub(s, e)
                                           btn.ForeColor = Color.White
                                           iconBtn.IconColor = Color.White
                                       End Sub
            AddHandler btn.MouseLeave, Sub(s, e)
                                           btn.ForeColor = Color.Black
                                           iconBtn.IconColor = Color.Black
                                       End Sub
            AddHandler btn.MouseDown, Sub(s, e)
                                          btn.ForeColor = Color.Black
                                          iconBtn.IconColor = Color.Black
                                      End Sub
            AddHandler btn.MouseUp, Sub(s, e)
                                        btn.ForeColor = Color.Black
                                        iconBtn.IconColor = Color.Black
                                    End Sub

        Next
    End Sub

    Private Sub rounded_btn(ParamArray btnArr() As Button)
        For Each btn As Button In btnArr
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.DarkOrange
            btn.ForeColor = Color.Black
            btn.FlatAppearance.MouseOverBackColor = Color.Peru
            btn.FlatAppearance.MouseDownBackColor = Color.Orange

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)

            AddHandler btn.MouseEnter, Sub(s, e) btn.ForeColor = Color.White
            AddHandler btn.MouseLeave, Sub(s, e) btn.ForeColor = Color.Black
            AddHandler btn.MouseDown, Sub(s, e) btn.ForeColor = Color.Black
            AddHandler btn.MouseUp, Sub(s, e) btn.ForeColor = Color.Black

            Dim radius As New Drawing2D.GraphicsPath
            radius.StartFigure()

            ' Top-left
            radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
            radius.AddLine(10, 0, btn.Width - 20, 0)

            ' Top-right
            radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
            radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

            ' Bottom-right
            radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

            ' Bottom-left
            radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
            radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

            radius.CloseFigure()
            btn.Region = New Region(radius)
        Next
    End Sub




    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        MessageBox.Show("File menu - Manage your files here!", "File Menu")
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles btn_editfile.Click
        MessageBox.Show("Edit menu - Edit your code here!", "Edit Menu")
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles btn_settings.Click
        Dim settingsInfo = "PROGRAMMING LANGUAGE SETTINGS" & vbCrLf & vbCrLf &
                        "Keywords (Commands) with Equivalents:" & vbCrLf & vbCrLf

        ' Array of equivalent standard keywords matching the order in InitializeKeywords
        Dim equivalentKeywords() As String = {
          "set", "print", "if", "then", "elseif", "else", "end",
          "loop", "to", "next", "var", "start", "comment", "true",
          "false", "count", "times", "do", "check", "alt print"
      }

        ' Loop through keywords and show both unique and equivalent
        For i As Integer = 0 To keywords.Count - 1
            If i < equivalentKeywords.Length Then
                settingsInfo += $"- {keywords(i)} → {equivalentKeywords(i)}" & vbCrLf
            Else
                settingsInfo += $"- {keywords(i)}" & vbCrLf
            End If
        Next

        MessageBox.Show(settingsInfo, "Language Settings")
    End Sub


    'run button - compiles and runs the code
    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles btn_run.Click
        Try
            output.Clear()
            variableNames.Clear()
            variableValues.Clear()
            rch_terminal.Clear()

            Dim sourceCode = main_code_editor.Text
            CompileAndRunCode(sourceCode)
            rch_terminal.Text = "=== OUTPUT ===" & vbCrLf & output.ToString


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Compilation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    'debug button - kung anong kulang and mali sa syntax ng code
    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles btn_debug.Click
        Try
            Dim sourceCode = main_code_editor.Text
            Dim tokens = TokenizeCode(sourceCode)

            Dim debugInfo As New Text.StringBuilder
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

            rch_terminal.Text = "=== DEBUG INFO ===" & vbCrLf & debugInfo.ToString


        Catch ex As Exception
            MessageBox.Show("Debug error: " & ex.Message, "Debug Error")
        End Try
    End Sub

    Private Sub btn_more_Click(sender As Object, e As EventArgs) Handles btn_more.Click

    End Sub
End Class