Imports System.Text.RegularExpressions
Public Class SelectLinks
    Public Main As Main
    Public Config As Configuracion
    Public oPaquete As Paquete

    Public ficheros As List(Of Fichero)
    Public ficherosBackup As List(Of Fichero)
    Public root As String
    Private tamanobytes As Long

    Public Property Checked As Boolean

#Region "Cargar variables y treeview"
    Private Sub SelectLinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centramos la pantalla
        ' http://stackoverflow.com/questions/7892090/how-to-set-winform-start-position-at-top-right
        Dim scr = Screen.FromPoint(Me.Location)
        Me.Location = New Point(CInt((scr.WorkingArea.Right - Me.Width) / 2), CInt((scr.WorkingArea.Bottom - Me.Height) / 2))

        DrawTreeView()


        'Dark Theme
        If Config.Tema Then

            Me.BackColor = Color.FromArgb(32, 33, 36)
            Me.ForeColor = Color.FromArgb(188, 192, 195)

            Me.TreeView1.BackColor = Color.FromArgb(52, 53, 56)
            Me.btnAgregar.BackColor = Color.FromArgb(52, 53, 56)
            Me.BtnContraer.BackColor = Color.FromArgb(52, 53, 56)
            Me.BtnDelete_all_nodes.BackColor = Color.FromArgb(52, 53, 56)
            Me.BtnDelete_node.BackColor = Color.FromArgb(52, 53, 56)
            Me.BtnExpandir.BackColor = Color.FromArgb(52, 53, 56)
            Me.BtnRestaurar.BackColor = Color.FromArgb(52, 53, 56)

            Me.TreeView1.ForeColor = Color.FromArgb(232, 234, 237)
            Me.btnAgregar.ForeColor = Color.FromArgb(232, 234, 237)
            Me.BtnContraer.ForeColor = Color.FromArgb(232, 234, 237)
            Me.BtnDelete_all_nodes.ForeColor = Color.FromArgb(232, 234, 237)
            Me.BtnDelete_node.ForeColor = Color.FromArgb(232, 234, 237)
            Me.BtnExpandir.ForeColor = Color.FromArgb(232, 234, 237)
            Me.BtnRestaurar.ForeColor = Color.FromArgb(232, 234, 237)

        End If

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
                        lastNode.StateImageIndex = 1
                    End If
                Else
                    lastNode = nodes(0)
                End If
            Next

            lastNode = Nothing
        Next
    End Sub
#End Region

#Region "Eliminar un nodo"
    Private Sub Delete_node_Click(sender As Object, e As EventArgs) Handles BtnDelete_node.Click
        DisableButtonsDelete()
        Try
            Dim node = TreeView1.SelectedNode.FullPath
            Dim nodes = New List(Of String) From {}

            Dim ext As Regex = New Regex("-\[\(\[(?<nombre>.*)\]\)\]{1}")
            Dim matt = ext.Match(node)
            Dim nombret = matt.Groups("nombre").Value
            If nombret.Equals("") Then
                GetChildNodes(TreeView1.SelectedNode)
            Else
                ficheros.RemoveAt(CInt(nombret))
                'Console.WriteLine(ficheros.Count)
            End If
            TreeView1.SelectedNode.Remove()
            DrawTreeViewDel()
            CalcTamanoBytes()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

#End Region

#Region "Agregar links a descarga"
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
            Log.WriteError("Error while adding the link: " & ex.ToString)
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Eliminar resto de links no necesarios"
    Private Sub Delete_all_nodes_Click(sender As Object, e As EventArgs) Handles BtnDelete_all_nodes.Click
        DisableButtonsDelete()
        Try
            Dim nodet = TreeView1.SelectedNode.FullPath

            Dim ext As Regex = New Regex("-\[\(\[(?<nombre>.*)\]\)\]{1}")
            Dim matt = ext.Match(nodet)
            Dim nombret = matt.Groups("nombre").Value

            If nombret.Equals("") Then

                GetChildNodesAllNodes(TreeView1.Nodes(0))
            Else
                Dim ficher = ficheros.ElementAt(CInt(nombret))
                ficheros.Clear()
                ficheros.Add(ficher)
                'Console.WriteLine(ficheros.Count)
            End If

            DrawTreeViewDel()

            CalcTamanoBytes()
            'Console.WriteLine(ficheros.Count)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

#End Region

#Region "Utilidades"
    Private Sub GetChildNodes(tnode As TreeNode)

        Dim nodefull = TreeView1.SelectedNode.FullPath

        Console.WriteLine("Get one ingreso")
        Dim ext As Regex = New Regex("\\(?<nombre>.*){1}")
        Dim matt = ext.Match(nodefull)
        Dim nomr = matt.Groups("nombre").Value
        'Iterate through the child nodes of the node passed into this subroutine

        ficheros.RemoveAll(Function(p) p.RutaRelativa.Contains(nomr))

    End Sub

    Private Sub GetChildNodesAllNodes(tnode As TreeNode)
        Dim nodefull = TreeView1.SelectedNode.FullPath
        Console.WriteLine("Get all ingreso")
        Dim ext As Regex = New Regex("\\(?<nombre>.*){1}")
        Dim matt = ext.Match(nodefull)
        Dim nomr = matt.Groups("nombre").Value
        'Iterate through the child nodes of the node passed into this subroutine
        ficheros = ficheros.FindAll(Function(p) p.RutaRelativa.Contains(nomr))

    End Sub

    Private Sub CalcTamanoBytes()
        tamanobytes = 0
        For Each fic In ficheros
            tamanobytes += fic.TamanoBytes
            'Console.WriteLine("Cal tamaño")
            'Console.WriteLine(fic.NombreFichero)
        Next

        If ficheros.Count > 0 Then
            btnAgregar.Enabled = True
        Else
            btnAgregar.Enabled = False
        End If
        'father.Nodes.Add(fic.RutaRelativa + "\" + fic.Nombre).Checked = True
        Tamano.Text = CStr(Main.PintarTamano(tamanobytes))

    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        BtnDelete_all_nodes.Enabled = False
        BtnDelete_node.Enabled = False
        ficheros = oPaquete.ListaFicheros.ToList()
        DrawTreeView()
        CalcTamanoBytes()
    End Sub

    Private Sub DrawTreeView()
        ficheros = oPaquete.ListaFicheros.ToList()
        DrawTreeViewAll()
    End Sub
    Private Sub DrawTreeViewDel()
        DrawTreeViewAll()
    End Sub
    Private Sub DrawTreeViewAll()

        TreeView1.Nodes.Clear()

        Dim paths = New List(Of String) From {}
        root = oPaquete.Nombre
        tamanobytes = 0

        For Each fic In ficheros
            'Console.WriteLine(fic.RutaLocal)
            Dim index = ficheros.IndexOf(fic)
            If fic.RutaRelativa Is "" Then
                paths.Add(root + "\" + fic.Nombre + " -(" + CStr(Main.PintarTamano(fic.DescargaTamanoBytes)) + ")-[([" + CStr(index) + "])]")
            Else
                paths.Add(root + "\" + fic.RutaRelativa + "\" + fic.Nombre + " -(" + CStr(Main.PintarTamano(fic.DescargaTamanoBytes)) + ")-[([" + CStr(index) + "])]")
            End If
            tamanobytes += fic.TamanoBytes
        Next
        'father.Nodes.Add(fic.RutaRelativa + "\" + fic.Nombre).Checked = True
        Tamano.Text = CStr(Main.PintarTamano(tamanobytes))
        PopulateTreeView(TreeView1, paths, "\"c)

        TreeView1.ImageList = imageTreeview

        TreeView1.ExpandAll()
    End Sub

    Private Sub BtnContraer_Click(sender As Object, e As EventArgs) Handles BtnContraer.Click
        TreeView1.CollapseAll()
        TreeView1.Nodes(0).Expand()
        DisableButtonsDelete()
    End Sub

    Private Sub BtnExpandir_Click(sender As Object, e As EventArgs) Handles BtnExpandir.Click
        TreeView1.ExpandAll()
        DisableButtonsDelete()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        EnableButtonsDelete()
    End Sub

    Private Sub DisableButtonsDelete()
        BtnDelete_all_nodes.Enabled = False
        BtnDelete_node.Enabled = False
    End Sub
    Private Sub EnableButtonsDelete()
        BtnDelete_all_nodes.Enabled = True
        BtnDelete_node.Enabled = True
    End Sub
#End Region
End Class