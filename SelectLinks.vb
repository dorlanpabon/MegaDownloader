Public Class SelectLinks
    Public Main As Main
    Public Config As Configuracion
    Public oPaquete As Paquete

    Private Sub SelectLinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Clear()
        Dim root As String = oPaquete.Nombre
        Dim ficheros = oPaquete.ListaFicheros

        Dim paths = New List(Of String) From {}

        For Each fic In ficheros
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
                        lastNode.Checked = True
                    Else
                        lastNode = lastNode.Nodes.Add(subPathAgg, subPath)
                        lastNode.Checked = True
                    End If
                Else
                    lastNode = nodes(0)
                End If
            Next

            lastNode = Nothing
        Next
    End Sub
End Class