Module Ejercicio02

    Sub Main()
        Dim numero As Integer

        Console.WriteLine("Ingresa el número que deseas verificar")

        numero = Console.ReadLine()


        If numero > 0 Then
            Console.WriteLine("Este número es positivo")
        ElseIf numero < 0 Then
            Console.WriteLine("Este número es negativo")
        ElseIf numero = 0 Then
            Console.WriteLine("Este número es igual a cero")
        End If

        Console.ReadKey(True)

    End Sub
End Module
