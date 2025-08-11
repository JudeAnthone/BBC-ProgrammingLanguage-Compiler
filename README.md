BIB BLACK COMPILER 
A custom programming language compiler built with VB.NET that features unique Filipino/colloquial keywords and a complete Windows Forms IDE. 
This project demonstrates compiler design principles including lexical analysis, parsing, and code execution. 

Features
Custom Programming Language: Unique Filipino/colloquial keyword system
Real-time Code Execution: Compile and run code instantly
Integrated Development Environment: Complete IDE with syntax highlighting area
Debug Mode: Token analysis and variable inspection
Multiple File Management: Switch between different code samples
Expression Evaluation: Support for arithmetic operations and string concatenation
Control Flow: Conditional statements and loop constructs
Variable System: Dynamic variable storage and retrieval

Language Overview
BBC uses unconventional keywords that map to standard programming constructs:
Keywords Reference:
<img width="770" height="714" alt="image" src="https://github.com/user-attachments/assets/4e14bb5d-e6e8-4654-b110-43f457b7498d" />


Supported Operators
Arithmetic: +, -, *, /
Comparison: >, <, ==
Assignment: =

Basic Variable Assignment: 
bbccumment Variable declarations
idikitmo name = "Juan"
idikitmo age = 25
idikitmo salary = 50000

Output Statements:
bbcambatukam "Hello World!"
ambatukam "My name is: " + name
ambatukam "I am " + age + " years old"
Conditional Statements
bbcnig age > 18 ken
    ambatukam "You are an adult!"
ga
    ambatukam "You are a minor"
kam

Loops: 
bbciyot i = 1 sa 5
    ambatukam "Count: " + i
labas


 Architecture: 
 
Core Components
Lexical Analyzer (Tokenizer)

TokenizeCode(): Processes source code line by line
ParseLine(): Breaks lines into individual tokens
ClassifyToken(): Categorizes tokens (keywords, operators, literals, identifiers)


Parser & Executor
ProcessStatement(): Handles different statement types
ProcessSetStatement(): Variable assignments
ProcessPrintStatement(): Output operations
ProcessIfStatement(): Conditional logic
ProcessForStatement(): Loop constructs

Expression Evaluator
EvaluateExpression(): Handles arithmetic and string operations
PerformMathOperation(): Mathematical computations
EvaluateCondition(): Boolean expression evaluation

Runtime Environment
Dynamic variable storage using ArrayLists
Memory management for variables and values
Error handling and reporting


Token Types
KEYWORD: Reserved language keywords
OPERATOR: Mathematical and comparison operators
STRING: String literals enclosed in quotes
NUMBER: Numeric literals
IDENTIFIER: Variable names
EOL: End of line markers


IDE Features: 
User Interface
Code Editor: Multi-line text editor with line numbering
Terminal: Output display and debug information
Toolbar: Quick access to run, debug, save, and settings
File Panel: Sample code management
Custom Styling: Rounded buttons with hover effects

Functionality
Real-time Execution: Immediate code compilation and execution
Error Reporting: Detailed error messages with line numbers
Variable Inspection: Debug mode shows all active variables
Token Analysis: Complete tokenization breakdown
Multi-file Support: Switch between different code samples








