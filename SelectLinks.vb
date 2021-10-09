Public Class SelectLinks
    Public Main As Main
    Public Config As Configuracion
    Public oPaquete As Paquete

    Public ficheros As List(Of Fichero)
    Public ficherosBackup As List(Of Fichero)
    Public root As String
    Public Property Checked As Boolean

    Private Sub SelectLinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Clear()

        Dim paths = New List(Of String) From {}
        ficheros = oPaquete.ListaFicheros
        ficherosBackup = oPaquete.ListaFicheros.ToList
        root = oPaquete.Nombre
        For Each fic In ficheros
            Console.WriteLine(fic.RutaLocal)
            If fic.RutaRelativa Is "" Then
                paths.Add(root + "\" + fic.Nombre)
            Else
                paths.Add(root + "\" + fic.RutaRelativa + "\" + fic.Nombre)
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
        Dim node = TreeView1.SelectedNode.FullPath
        Dim nodes = New List(Of String) From {}

        GetChildNodes(TreeView1.SelectedNode, nodes)


        For i = ficherosBackup.Count - 1 To 0 Step -1
            Dim del = False
            For f = nodes.Count - 1 To 0 Step -1
                Console.WriteLine("Node |" + nodes(f))
                Console.WriteLine("pai" + CStr(i) + " ")
                Console.WriteLine("Fichero  |" + root + "\" + ficherosBackup(i).RutaRelativa + "\" + ficherosBackup(i).Nombre)
                If root + "\" + ficherosBackup(i).RutaRelativa + "\" + ficherosBackup(i).Nombre = nodes(f) And del = False Then
                    Console.WriteLine("if 1")
                    del = True
                    ficheros.RemoveAt(i)
                ElseIf root + "\" + ficherosBackup(i).RutaRelativa = nodes(f) And del = False Then
                    Console.WriteLine("if 2")
                    del = True
                    ficheros.RemoveAt(i)
                ElseIf root + "\" + ficherosBackup(i).Nombre = nodes(f) And del = False Then
                    Console.WriteLine("if 3")
                    del = True
                    ficheros.RemoveAt(i)
                End If
            Next

        Next
        Console.WriteLine(ficheros.Count)
        TreeView1.SelectedNode.Remove()
    End Sub
    Private Sub GetChildNodes(tnode As TreeNode, ByVal nodes As List(Of String))

        'Iterate through the child nodes of the node passed into this subroutine
        For Each node As TreeNode In tnode.Nodes
            'If the node passed into this subroutine contains child nodes,
            'call the subroutine for each one of them
            'If you only want to display one level deep, then comment out the
            'IF statement.
            nodes.Add(node.FullPath)

            If tnode.Nodes.Count > 0 Then GetChildNodes(node, nodes)

        Next

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        oPaquete.ListaFicheros = ficheros
        Main.AgregarPaquete(oPaquete, False)
        If Checked Then Main.StartDownload()
    End Sub
End Class