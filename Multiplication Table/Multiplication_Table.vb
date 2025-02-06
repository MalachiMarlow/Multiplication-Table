Option Compare Text
Option Explicit On
Option Strict On

Module Multiplication_Table

    Sub Main()
        Dim userInput As Integer

        Console.WriteLine("Please enter a number.")
        Console.ReadLine()

        For i As Integer = 1 To userInput Step 1
            Console.WriteLine(i)
        Next
        Console.WriteLine(StrDup(80, "*"))



    End Sub

End Module
