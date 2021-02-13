'Tori Gomez
'RCET0265
'Spring 2021
'Convert and Validate
'https://github.com/ToriGomez/ConvertAndValidate.git


Option Explicit On
Option Strict On
Module ConvertAndValidate

    Sub Main()
        Dim userInput As String
        Dim convert As Integer


        Console.WriteLine("Enter in any Number...")
        userInput = Console.ReadLine()

        Console.WriteLine($"Integer value before converted, {convert}")

        Console.WriteLine(ValidateAndConvert(userInput, convert))

        Console.WriteLine(vbNewLine & "ValidateAndConvert function:")
        Console.WriteLine($"Converted validated integer, {convert}")
        Console.ReadLine()
    End Sub
    Function ValidateAndConvert(ByVal validate As String, ByRef convert As Integer) As String
        Try
            convert = CInt(validate)
            Return ""
        Catch ex As Exception
            Select Case validate
                Case ""
                    Return "is empty"
                Case Else
                    Return "must contain a number"
            End Select
        End Try
    End Function
End Module
