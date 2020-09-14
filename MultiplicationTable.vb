'Justine Hoffa
'RCET0265
'Fall2020
'

Option Explicit On
Option Strict On
Option Compare Text

Module MultiplicationTable

    Sub Main()
        Dim numberInput, column, row As Integer
        Dim data(12, 12) As Integer

        Do
            Console.WriteLine("Please Enter a Number:")

            numberInput = CInt(Console.ReadLine())

            For column = 1 To numberInput
                For row = 1 To numberInput
                    data(row, column) = row * column
                    Console.Write(data(row, column) & vbTab)
                Next
                Console.WriteLine()
            Next

            Console.ReadLine()
        Loop




    End Sub

End Module
