Module Module1

    Sub Main()
        Dim random As New Random()
        Dim numeroAleatorio As Integer = random.Next(1, 1001)
        Dim numeroUsuario As Integer = 0
        Dim intentos As Integer = 0

        Console.WriteLine("¡Bienvenido al juego de adivinar el número!")
        Console.WriteLine("He generado un número aleatorio entre 1 y 1000.")
        Console.WriteLine("Intenta adivinarlo...")

        Do
            Try
                Console.WriteLine()
                Console.Write("Introduce tu número: ")
                numeroUsuario = Convert.ToInt32(Console.ReadLine())
                intentos += 1

                If numeroUsuario < numeroAleatorio Then
                    Console.WriteLine("El número es muy bajo, intenta nuevamente.")
                ElseIf numeroUsuario > numeroAleatorio Then
                    Console.WriteLine("El número es muy alto, intenta nuevamente.")
                Else
                    Console.WriteLine("¡Felicidades! Has adivinado el número en " & intentos & " intentos.")
                End If

            Catch ex As Exception
                Console.WriteLine("Por favor, ingresa un número válido.")
            End Try
        Loop While numeroUsuario <> numeroAleatorio

        Console.WriteLine("Gracias por jugar.")
        Console.ReadKey()
    End Sub


End Module
