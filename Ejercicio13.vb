Module Ejercicio13
	Sub Main()

		Dim mayor1 As Integer
		Dim menor1 As Integer
		Dim n As Integer
		Dim x As Integer

		n = 5
		Dim vector(n) As Integer
		For x = 1 To n
			Console.WriteLine("Ingresa un numero")
			vector(x) = Integer.Parse(Console.ReadLine())
		Next x
		mayor1 = 0
		menor1 = 0
		For x = 1 To n
			Console.WriteLine(vector(x))
			If x = 1 Then
				menor1 = vector(x)
				mayor1 = vector(x)
			Else
				If vector(x) > mayor1 Then
					mayor1 = vector(x)
				Else
					If vector(x) < menor1 Then
						menor1 = vector(x)
					End If
				End If
			End If
		Next x
		Console.WriteLine("El numero mayor es: {0}", mayor1)
		Console.WriteLine("EL numero menor es: {0}", menor1)
	End Sub
End Module
