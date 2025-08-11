# *BIG BLACK COMPILER*
A custom programming language compiler built with **VB.NET** that features unique Filipino/colloquial keywords and a complete Windows Forms IDE. This project demonstrates compiler design principles including **lexical analysis, parsing, and code execution**. <br>
The project is written and coded within the 5-6 hour deadline, so don't expect that this will work properly as intented as a real  Integrated Development Environment (IDE)

---

# *Features*
- **Custom Programming Language**: Unique Filipino/colloquial keyword system.
- **Real-time Code Execution**: Compile and run code instantly.
- **Integrated Development Environment**: Complete IDE with syntax highlighting area.
- **Debug Mode**: Token analysis and variable inspection.
- **Multiple File Management**: Switch between different code samples.
- **Expression Evaluation**: Support for arithmetic operations and string concatenation.
- **Control Flow**: Conditional statements and loop constructs.
- **Variable System**: Dynamic variable storage and retrieval.

---
### *Tech Stack:*
### Core Framework
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![VB.NET](https://img.shields.io/badge/VB.NET-512BD4?style=for-the-badge&logo=visualbasic&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

### External Libraries
![Newtonsoft JSON](https://img.shields.io/badge/Newtonsoft%20JSON-000000?style=for-the-badge&logo=JSON&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-68217A?style=for-the-badge&logo=dotnet&logoColor=white)
![Dapper](https://img.shields.io/badge/Dapper-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

---
# 🏗 *Architecture*
### **Core Components**
#### **Lexical Analyzer (Tokenizer)**

- `TokenizeCode()`: Processes source code line by line  
- `ParseLine()`: Breaks lines into individual tokens  
- `ClassifyToken()`: Categorizes tokens (keywords, operators, literals, identifiers)  

#### **Parser & Executor**
- `ProcessStatement()`: Handles different statement types  
- `ProcessSetStatement()`: Variable assignments  
- `ProcessPrintStatement()`: Output operations  
- `ProcessIfStatement()`: Conditional logic  
- `ProcessForStatement()`: Loop constructs  

#### **Expression Evaluator**
- `EvaluateExpression()`: Handles arithmetic and string operations  
- `PerformMathOperation()`: Mathematical computations  
- `EvaluateCondition()`: Boolean expression evaluation  

#### **Runtime Environment**
- Dynamic variable storage using `ArrayLists`  
- Memory management for variables and values  
- Error handling and reporting  

---

# 🏷 *Token Types*
- **KEYWORD**: Reserved language keywords  
- **OPERATOR**: Mathematical and comparison operators  
- **STRING**: String literals enclosed in quotes  
- **NUMBER**: Numeric literals  
- **IDENTIFIER**: Variable names  
- **EOL**: End of line markers  

---

# *Language Overview*
BBC uses unconventional keywords that map to standard programming constructs.

### **Keywords Reference**
![Keywords Reference](https://github.com/user-attachments/assets/4e14bb5d-e6e8-4654-b110-43f457b7498d)

---

## *Supported Operators*
- **Arithmetic**: `+`, `-`, `*`, `/`
- **Comparison**: `>`, `<`, `==`
- **Assignment**: `=`

---

## *Basic Syntax Examples*
### **Variable Assignment**
```bbc
bbccumment Variable declarations
idikitmo name = "Juan"
idikitmo age = 25
idikitmo salary = 50000
```

### **Output Statements:**
```bbc
bbcambatukam "Hello World!"
ambatukam "My name is: " + name
ambatukam "I am " + age + " years old"
```

### **Conditional Statements:**
```bbc
bbcnig age > 18 ken
    ambatukam "You are an adult!"
ga
    ambatukam "You are a minor"
kam
```
### **Loops Statements:**
```bbc
bbciyot i = 1 sa 5
    ambatukam "Count: " + i
labas
```
    
--- 
# 📜 System Walkthrough & User Flow
I have provided the **Google Drive** link below containing all images and screenshots of every part of the compiler.  
This ensures that all sections — **Functionality**, **Buttons**, and **Interface** — can be seen in one folder to avoid confusion.  <br> 

<img width="1479" height="1060" alt="Screenshot 2025-08-12 031147" src="https://github.com/user-attachments/assets/f6debcfb-08fb-414e-86ac-f9a3cca55ad5" /> 
<img width="1478" height="1056" alt="Screenshot 2025-08-12 031221" src="https://github.com/user-attachments/assets/ebc1d0bf-f75f-4c80-ba6c-fa5744c6931b" /> 
<img width="1476" height="1069" alt="Screenshot 2025-08-12 031243" src="https://github.com/user-attachments/assets/3f684b44-3347-46c6-8acc-ce56eeb2eea8" /> 
<img width="1480" height="1064" alt="Screenshot 2025-08-12 031336" src="https://github.com/user-attachments/assets/f3a6986c-2d65-4c8a-bbc2-b36ab58b6bcd" />
<img width="1479" height="1059" alt="Screenshot 2025-08-12 031343" src="https://github.com/user-attachments/assets/82a2aca0-7c18-4335-9bf1-46a582af2883" />

--- 

# *Project Contributors*
- I, Jude Anthone R. Duarte (Backend Developer)
- Ralph Russle Marabilla (Frontend Developer) (https://github.com/akuunoro)
