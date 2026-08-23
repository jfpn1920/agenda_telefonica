Imports System
Module agenda_telefonica
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim nombres(9) As String
        Dim apellidos(9) As String
        Dim telefonos(9) As String
        Dim correos(9) As String
        Dim direcciones(9) As String
        Dim categorias(9) As String
        Dim fechasRegistro(9) As String
        Dim estados(9) As String
        Dim observaciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '-----------------------------------------//
        '--|menu_principal_de_agenda_telefonica|--//
        '-----------------------------------------//
        Do
            Console.WriteLine("menu principal de agenda telefonica")
            Console.WriteLine("1) Registrar contacto")
            Console.WriteLine("2) Editar contacto")
            Console.WriteLine("3) Listar contactos")
            Console.WriteLine("4) Buscar contacto")
            Console.WriteLine("5) Eliminar contacto")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '------------------------//
                '--|registrar_contacto|--//
                '------------------------//
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas contactos.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.WriteLine("registro de contacto")
                        Console.Write("Nombre: ")
                        nombres(cantidad) = Console.ReadLine()
                        Console.Write("Apellido: ")
                        apellidos(cantidad) = Console.ReadLine()
                        Console.Write("Telefono: ")
                        telefonos(cantidad) = Console.ReadLine()
                        Console.Write("Correo: ")
                        correos(cantidad) = Console.ReadLine()
                        Console.Write("Direccion: ")
                        direcciones(cantidad) = Console.ReadLine()
                        Console.Write("Categoria: ")
                        categorias(cantidad) = Console.ReadLine()
                        Console.Write("Fecha de registro: ")
                        fechasRegistro(cantidad) = Console.ReadLine()
                        Console.Write("Estado: ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Observaciones: ")
                        observaciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Contacto registrado correctamente.")
                    End If
                '---------------------//
                '--|editar_contacto|--//
                '---------------------//
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen contactos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Categoria: " & categorias(i) & " | Fecha registro: " & fechasRegistro(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del contacto a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo nombre: ")
                            nombres(posicion) = Console.ReadLine()
                            Console.Write("Nuevo apellido: ")
                            apellidos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo telefono: ")
                            telefonos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo correo: ")
                            correos(posicion) = Console.ReadLine()
                            Console.Write("Nueva direccion: ")
                            direcciones(posicion) = Console.ReadLine()
                            Console.Write("Nueva categoria: ")
                            categorias(posicion) = Console.ReadLine()
                            Console.Write("Nueva fecha de registro: ")
                            fechasRegistro(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado: ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nuevas observaciones: ")
                            observaciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Contacto actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '----------------------//
                '--|listar_contactos|--//
                '----------------------//
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen contactos registrados.")
                    Else
                        Console.WriteLine("lista de contactos")
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Categoria: " & categorias(i) & " | Fecha registro: " & fechasRegistro(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                    End If
                '---------------------//
                '--|buscar_contacto|--//
                '---------------------//
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen contactos registrados.")
                    Else
                        Console.Write("Ingrese el ID del contacto a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("contacto encontrado")
                            Console.WriteLine("ID: " & ids(posicion) & " | Nombre: " & nombres(posicion) & " | Apellido: " & apellidos(posicion) & " | Telefono: " & telefonos(posicion) & " | Correo: " & correos(posicion) & " | Direccion: " & direcciones(posicion) & " | Categoria: " & categorias(posicion) & " | Fecha registro: " & fechasRegistro(posicion) & " | Estado: " & estados(posicion) & " | Observaciones: " & observaciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-----------------------//
                '--|eliminar_contacto|--//
                '-----------------------//
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen contactos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Nombre: " & nombres(i) & " | Apellido: " & apellidos(i) & " | Telefono: " & telefonos(i) & " | Correo: " & correos(i) & " | Direccion: " & direcciones(i) & " | Categoria: " & categorias(i) & " | Fecha registro: " & fechasRegistro(i) & " | Estado: " & estados(i) & " | Observaciones: " & observaciones(i))
                        Next
                        Console.Write("Ingrese el ID del contacto a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                nombres(i) = nombres(i + 1)
                                apellidos(i) = apellidos(i + 1)
                                telefonos(i) = telefonos(i + 1)
                                correos(i) = correos(i + 1)
                                direcciones(i) = direcciones(i + 1)
                                categorias(i) = categorias(i + 1)
                                fechasRegistro(i) = fechasRegistro(i + 1)
                                estados(i) = estados(i + 1)
                                observaciones(i) = observaciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Contacto eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------//
                '--|mostrar_resumen|--//
                '---------------------//
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen contactos registrados.")
                    Else
                        Dim activos As Integer = 0
                        Dim inactivos As Integer = 0
                        Dim familia As Integer = 0
                        Dim amigos As Integer = 0
                        Dim trabajo As Integer = 0
                        Dim estudio As Integer = 0
                        Dim clientes As Integer = 0
                        Dim otros As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            If estados(i).ToLower() = "activo" Then
                                activos += 1
                            ElseIf estados(i).ToLower() = "inactivo" Then
                                inactivos += 1
                            End If
                            If categorias(i).ToLower() = "familia" Then
                                familia += 1
                            ElseIf categorias(i).ToLower() = "amigos" Then
                                amigos += 1
                            ElseIf categorias(i).ToLower() = "trabajo" Then
                                trabajo += 1
                            ElseIf categorias(i).ToLower() = "estudio" Then
                                estudio += 1
                            ElseIf categorias(i).ToLower() = "cliente" Then
                                clientes += 1
                            Else
                                otros += 1
                            End If
                        Next
                        Console.WriteLine("resumen de agenda telefonica")
                        Console.WriteLine("Contactos: " & cantidad & " | Activos: " & activos & " | Inactivos: " & inactivos & " | Familia: " & familia & " | Amigos: " & amigos & " | Trabajo: " & trabajo & " | Estudio: " & estudio & " | Clientes: " & clientes & " | Otros: " & otros)
                    End If
                '------------------------------//
                '--|salir_del_menu_principal|--//
                '------------------------------//
                Case 7
                    Console.WriteLine("Gracias por utilizar Agenda Telefonica.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module