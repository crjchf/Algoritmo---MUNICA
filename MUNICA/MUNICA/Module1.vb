Module Module1

    Sub Main()
        'Declaración de Constantes
        Dim nu, rpp, mc, m As String
        Dim cod, c, ncd, tp As Integer
        Dim lim1, p1, p2, p3, p4, mpc As Integer

        'Ingresamos Datos
        Console.Write("Nombre del Universitario: ")
        nu = Console.ReadLine()
        Console.Write("Código: ")
        cod = Console.ReadLine()
        Console.Write("Ciclo: ")
        c = Console.ReadLine()
        Console.Write("Resolución Primeros Puestos: ")
        rpp = Console.ReadLine()
        Console.Write("Modalidad de Colegio: ")
        mc = Console.ReadLine()
        Console.Write("Números de Cursos Desaprobados: ")
        ncd = Console.ReadLine()

        lim1 = 3
        p1 = 160
        p2 = 180
        p3 = 40
        p4 = 50

        If ncd >= lim1 Then
            m = "No se puede inscribir en el Presente Ciclo"

        Else

            m = "Felicitaciones por Pasar de Ciclo"

            If (c = 1 Or c = 2) And mc = "estatal" Then
                If rpp = "si" Then
                    mpc = 0
                Else
                    mpc = p1
                End If
                tp = mpc + (ncd * p4)

            Else

                If (c = 1 Or c = 2) And mc = "privado" Then
                    If rpp = "si" Then
                        mpc = 0
                    Else
                        mpc = p2
                    End If
                    tp = mpc + (ncd * p4)
                Else
                    If rpp = "si" Then
                        mpc = 0
                    Else
                        mpc = p3
                    End If
                    tp = mpc + (ncd * p4)
                End If

            End If

        End If

        'Mostramos Datos
        Console.WriteLine()
        Console.WriteLine("MATRICULAS DE FACULTAD DE INGENIERIA DE SISTEMAS")
        Console.WriteLine()
        Console.WriteLine("Código: " & cod)
        Console.WriteLine("Nombre del Universitario: " & nu)
        Console.WriteLine("Ciclo: " & c)
        Console.WriteLine("Mensaje: " & m)
        Console.WriteLine("Total a Pagar: " & tp)

        'Mantener abierta la consola
        Console.ReadKey()

        'DERECHOS DE AUTOR: Cristian Jeancarlo Chacaltana Fajardo - FIS 2015
    End Sub

End Module
