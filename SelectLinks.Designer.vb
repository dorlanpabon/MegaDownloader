<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLinks
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carpeta")
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Delete_node = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(93, 47)
        Me.TreeView1.Name = "TreeView1"
        TreeNode2.Name = "Nodo0"
        TreeNode2.Text = "Carpeta"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.TreeView1.Size = New System.Drawing.Size(593, 300)
        Me.TreeView1.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(574, 381)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(133, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar links"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Delete_node
        '
        Me.Delete_node.Location = New System.Drawing.Point(399, 381)
        Me.Delete_node.Name = "Delete_node"
        Me.Delete_node.Size = New System.Drawing.Size(133, 23)
        Me.Delete_node.TabIndex = 6
        Me.Delete_node.Text = "Eliminar Nodo"
        Me.Delete_node.UseVisualStyleBackColor = True
        '
        'SelectLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Delete_node)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "SelectLinks"
        Me.Text = "SelectLinks"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Delete_node As Button
End Class
