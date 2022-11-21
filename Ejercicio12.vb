Module Ejercicio12

    Function Operaciones(numero1 As Integer, numero2 As Integer, operacion As Char)


        Select Case operacion
            Case "+"
                Console.WriteLine(numero1 + numero2)
            Case "-"
                Console.WriteLine(numero1 - numero2)
            Case "*"
                Console.WriteLine(numero1 * numero2)
            Case "/"
                Console.WriteLine(numero1 / numero2)
            Case Else
                Console.WriteLine("No puedes operar con este simbolo")
        End Select


    End Function

End Module
