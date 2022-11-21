Module Ejercicio11
    Sub Main()

        Dim edad As Integer

        Console.WriteLine("Ingrese su edad: ")

        edad = Console.ReadLine()

        If edad >= 18 Then
            Console.WriteLine("Eres mayor de edad :)")
        ElseIf edad < 18 Then
            Console.WriteLine("Aún no eres mayor de edad :(")
        End If

        Console.ReadKey(True)

    End Sub
End Module
