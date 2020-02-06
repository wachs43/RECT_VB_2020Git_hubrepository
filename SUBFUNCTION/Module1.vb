Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        'Dim myNumber As Integer
        'myNumber = 7
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)
        'Console.ReadLine()

        'MySub(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)

        'myNumber = MyFunc(myNumber)
        'Console.WriteLine("In Sub Main")
        'Console.WriteLine(myNumber)

        'doMath(7, 5, "Multiply")
        ShowPattern(5)
        Console.ReadLine()
    End Sub

    Sub MySub(myNumber As Integer)
        'Dim myNumber As Integer
        'myNumber = myNumber + 2
        myNumber += 2
        Console.WriteLine("In Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()
    End Sub

    Function MyFunc(myNumber As Integer) As Integer
        'Dim myNumber As Integer
        myNumber -= 3
        Console.WriteLine("In Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber
    End Function

    Sub doMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)
        Dim result As Double

        If operatorChoice = "Add" Then
            result = firstNumber + secondNumber
        ElseIf operatorChoice = "Subtract" Then
            result = firstNumber - secondNumber
        ElseIf operatorChoice = "Multiply" Then
            result = firstNumber * secondNumber
        ElseIf operatorChoice = "Divide" Then
            result = firstNumber / secondNumber
        End If

        Console.WriteLine(result)
    End Sub

    Sub ShowPattern(length As Integer)
        Dim character As String
        Dim pattern As String

        character = "*"
        pattern = ""
        For index = 1 To length
            pattern &= character
            Console.WriteLine(pattern)
        Next

    End Sub

End Module

