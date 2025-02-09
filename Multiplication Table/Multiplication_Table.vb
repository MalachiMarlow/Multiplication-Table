'Malachi Marlow
'Spring 2025
'RCET2265
'Multiplication Table
'https://github.com/MalachiMarlow/Multiplication-Table.git

Option Compare Text
Option Explicit On
Option Strict On

Module Multiplication_Table

    Sub Main()
        Dim userInput As Integer
        Dim result As String

        Console.WriteLine("Please enter a number.")
        userInput = CInt(Console.ReadLine)
        Console.WriteLine($"Enjoy your {userInput} x {userInput} multiplication table.")

        For i As Integer = 1 To userInput

            For M As Integer = 1 To userInput
                result = CStr(i * M)

                result = result.PadLeft(5)
                Console.Write(result)
            Next
            Console.WriteLine()
        Next



    End Sub

End Module
