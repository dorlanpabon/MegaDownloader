Public Class SelectLinks
    Public Main As Main
    Public Config As Configuracion
    Public oPaquete As Paquete

    Private Sub SelectLinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TreeView1.Nodes.Clear()
        Dim root As String = oPaquete.Nombre
        TreeView1.Nodes.Add(root).Checked = True

    End Sub
End Class