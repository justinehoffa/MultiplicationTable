'Justine Hoffa
'RCET0265
'Fall2020
'https://github.com/justinehoffa/MultiplicationTable

Option Explicit On
Option Strict On
Option Compare Text

Module MultiplicationTable

    Sub Main()
        Dim numberInput, column, row As Integer
        Dim data(12, 12) As Integer
        Dim goodData As Boolean
        Dim quit As String
        Dim userInput As String

        Do
            Do
                Console.WriteLine("Please Enter a Number:")

                Try
                    userInput = Console.ReadLine()
                    numberInput = CInt(userInput)
                    If numberInput < 13 And numberInput > 0 Then
                        goodData = True
                    Else
                        goodData = False
                        Console.WriteLine("Only 1 to 12 will work boi")
                    End If
                Catch ex As Exception
                    If userInput = "q" Then
                        Exit Sub
                    End If
                    Console.WriteLine("Only 1 to 12 will work boi")
                    goodData = False
                End Try
            Loop Until goodData = True

            For column = 1 To numberInput
                For row = 1 To numberInput
                    data(row, column) = row * column
                    Console.Write(data(row, column) & vbTab) ' use padleft to get consistent column width - TJR
                Next
                Console.WriteLine()
            Next
            Console.WriteLine("Press Enter to start over or Q to quit.")
            quit = Console.ReadLine()
            If quit = "q" Then
                Exit Sub
            End If
        Loop
    End Sub

End Module
