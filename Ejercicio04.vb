Module Ejercicio04
    Sub Main()

        Dim plan_elegido, alcohol, lentes, enfermedad, edad_cuarenta As Decimal
        Dim subtotal1, subtotal2, subtotal3, total As Decimal

        Console.WriteLine("¿Que póliza desea adquirir?: " & vbCrLf _
                          & "1: Cobertura Amplia" & vbCrLf _
                          & "2: Daños a Terceros")
        plan_elegido = Console.ReadLine()

        If plan_elegido = 1 Then
            plan_elegido = 500.0
        ElseIf plan_elegido = 2 Then
            plan_elegido = 200.0
        End If

        Console.WriteLine("¿Usted ingiere bebidas alcoholicas?" & vbCrLf _
                          & "1: Si" & vbCrLf _
                          & "2: No")
        alcohol = Console.ReadLine()

        If alcohol = 1 Then
            subtotal1 = (plan_elegido * 0.1) + plan_elegido
        ElseIf alcohol = 2 Then
            subtotal1 = plan_elegido
        End If

        Console.WriteLine("¿Usted usa lentes?" & vbCrLf _
                          & "1: Si" & vbCrLf _
                          & "2: No")
        lentes = Console.ReadLine()

        If lentes = 1 Then
            subtotal2 = (subtotal1 * 0.05) + subtotal1
        ElseIf lentes = 2 Then
            subtotal2 = subtotal1
        End If

        Console.WriteLine("¿Usted padece alguna enfermedad?" & vbCrLf _
                          & "1: Si" & vbCrLf _
                          & "2: No")
        enfermedad = Console.ReadLine()

        If enfermedad = 1 Then
            subtotal3 = (subtotal2 * 0.1) + subtotal2
        ElseIf enfermedad = 2 Then
            subtotal3 = subtotal2
        End If

        Console.WriteLine("¿Usted tiene más de 40 años?" & vbCrLf _
                          & "1: Si" & vbCrLf _
                          & "2: No")
        edad_cuarenta = Console.ReadLine()

        If edad_cuarenta = 1 Then
            total = (subtotal3 * 0.1) + subtotal3
        ElseIf edad_cuarenta = 2 Then
            total = subtotal3
        End If

        Console.WriteLine("Usted pagará por su poliza de seguro la cantidad de: $" & total)

        Console.ReadKey(True)
    End Sub
End Module
