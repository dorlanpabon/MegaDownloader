Imports System.Text.RegularExpressions
Public Class SelectLinks
    Public Main As Main
    Public Config As Configuracion
    Public oPaquete As Paquete

    Public ficheros As List(Of Fichero)
    Public ficherosBackup As List(Of Fichero)
    Public root As String
    Public Property Checked As Boolean

    Private Sub SelectLinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centramos la pantalla
        ' http://stackoverflow.com/questions/7892090/how-to-set-winform-start-position-at-top-right
        Dim scr = Screen.FromPoint(Me.Location)
        Me.Location = New Point(CInt((scr.WorkingArea.Right - Me.Width) / 2), CInt((scr.WorkingArea.Bottom - Me.Height) / 2))

        TreeView1.Nodes.Clear()

        Dim paths = New List(Of String) From {}
        ficheros = oPaquete.ListaFicheros
        ficherosBackup = oPaquete.ListaFicheros.ToList
        root = oPaquete.Nombre

        For Each fic In ficheros
            Console.WriteLine(fic.RutaLocal)
            If fic.RutaRelativa Is "" Then
                paths.Add(root + "\" + fic.Nombre + " -(" + CStr(Main.PintarTamano(fic.DescargaTamanoBytes)) + ")")
            Else
                paths.Add(root + "\" + fic.RutaRelativa + "\" + fic.Nombre + " -(" + CStr(Main.PintarTamano(fic.DescargaTamanoBytes)) + ")")
            End If
        Next
        'father.Nodes.Add(fic.RutaRelativa + "\" + fic.Nombre).Checked = True

        PopulateTreeView(TreeView1, paths, "\"c)

        TreeView1.ExpandAll()
    End Sub

    Private Shared Sub PopulateTreeView(ByVal treeView As TreeView, ByVal paths As List(Of String), ByVal pathSeparator As Char)
        Dim lastNode As TreeNode = Nothing
        Dim subPathAgg As String

        For Each path As String In paths
            subPathAgg = String.Empty

            For Each subPath As String In path.Split(pathSeparator)
                subPathAgg += subPath & pathSeparator
                Dim nodes As TreeNode() = treeView.Nodes.Find(subPathAgg, True)

                If nodes.Length = 0 Then

                    If lastNode Is Nothing Then
                        lastNode = treeView.Nodes.Add(subPathAgg, subPath)
                    Else
                        lastNode = lastNode.Nodes.Add(subPathAgg, subPath)
                    End If
                Else
                    lastNode = nodes(0)
                End If
            Next

            lastNode = Nothing
        Next
    End Sub

    Private Sub Delete_node_Click(sender As Object, e As EventArgs) Handles Delete_node.Click
        Try
            Dim node = TreeView1.SelectedNode.FullPath
            Dim nodes = New List(Of String) From {}

            Dim math = """(?<FileName>.*?)"""

            GetChildNodes(TreeView1.SelectedNode, nodes)


            For f = nodes.Count - 1 To 0 Step -1
                Dim ex As Regex = New Regex("(?<nombre>.*.\s.*-\(){1}")
                Dim mat = ex.Match(nodes(f))
                Dim nombre = mat.Groups("nombre").Value.Trim("("c, "-"c, " "c)

                If nombre Is "" Then
                    nombre = nodes(f)
                End If
                Console.WriteLine("antes")
                Console.WriteLine(nodes(f))
                Dim nomr = nombre.Replace(root + "\", "")
                Dim ruta = ""
                Dim nom = ""
                nom = nombre.Split("\"c).Last
                ruta = nomr.Replace("\" + nom, "")
                If nomr = nom Then
                    ruta = ""
                End If


                Dim i = ficheros.FindIndex(Function(p) p.RutaRelativa = ruta And p.Nombre = nom)
                Console.WriteLine("la i" + CStr(i))
                Console.WriteLine(nomr)
                Console.WriteLine(nom)
                If i > -1 Then
                    Console.WriteLine("Ingreso a if i")
                    ficheros.RemoveAt(i)
                Else
                    RemoveNodes(nomr)
                End If
            Next
            'For i = ficheros.Count - 1 To 0 Step -1
            '    Dim del = False
            '    For f = nodes.Count - 1 To 0 Step -1
            '        Dim ex As Regex = New Regex("(?<nombre>.*.\s.*-\(){1}")
            '        Dim mat = ex.Match(nodes(f))
            '        Dim nombre = mat.Groups("nombre").Value.Trim("("c, "-"c, " "c)
            '        Console.WriteLine("math" + nombre)
            '        Console.WriteLine("Node |" + nodes(f))
            '        Console.WriteLine("pai" + CStr(i) + " ")
            '        Console.WriteLine("Fichero  |" + root + "\" + ficheros(i).RutaRelativa + "\" + ficheros(i).Nombre)

            '        If nombre Is Nothing Then
            '            nombre = nodes(f)
            '        End If

            '        If root + "\" + ficheros(i).RutaRelativa + "\" + ficheros(i).Nombre = nombre And del = False Then
            '            Console.WriteLine("if 1")
            '            del = True
            '            ficheros.RemoveAt(i)
            '        ElseIf root + "\" + ficheros(i).RutaRelativa = nombre And del = False Then
            '            Console.WriteLine("if 2")
            '            del = True
            '            ficheros.RemoveAt(i)
            '        ElseIf root + "\" + ficheros(i).Nombre = nombre And del = False Then
            '            Console.WriteLine("if 3")
            '            del = True
            '            ficheros.RemoveAt(i)
            '        End If
            '    Next

            'Next
            Console.WriteLine(ficheros.Count)
            TreeView1.SelectedNode.Remove()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
    Private Sub GetChildNodes(tnode As TreeNode, ByVal nodes As List(Of String))

        'Iterate through the child nodes of the node passed into this subroutine
        For Each node As TreeNode In tnode.Nodes
            'If the node passed into this subroutine contains child nodes,
            'call the subroutine for each one of them
            'If you only want to display one level deep, then comment out the
            'IF statement.

            nodes.Add(node.FullPath)
            Console.WriteLine(node.FullPath)
            If tnode.Nodes.Count > 0 Then GetChildNodes(node, nodes)

        Next

    End Sub
    Private Sub RemoveNodes(nombre As String)

        Dim j = ficheros.FindIndex(Function(p) p.RutaRelativa = nombre)

        Console.WriteLine("la j" + CStr(j))
        Console.WriteLine(nombre)
        If j > -1 Then
            Console.WriteLine("Ingreso a if j")
            ficheros.RemoveAt(j)
            RemoveNodes(nombre)
        End If

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            oPaquete.ListaFicheros = ficheros
            For Each fic In oPaquete.ListaFicheros
                System.IO.Directory.CreateDirectory(fic.RutaLocal)
            Next
            Me.Close()
            Me.Dispose()
            If oPaquete.ListaFicheros.Count > 0 Then
                Main.AgregarPaquete(oPaquete, False)
                If Checked Then Main.StartDownload()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub Delete_all_nodes_Click(sender As Object, e As EventArgs) Handles Delete_all_nodes.Click

    End Sub
End Class