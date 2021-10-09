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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carpeta")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectLinks))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Delete_node = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Delete_all_nodes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TreeView1.Location = New System.Drawing.Point(66, 65)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Nodo0"
        TreeNode1.Text = "Carpeta"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeView1.Size = New System.Drawing.Size(664, 300)
        Me.TreeView1.TabIndex = 5
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(597, 402)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(133, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar links"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Delete_node
        '
        Me.Delete_node.Location = New System.Drawing.Point(439, 402)
        Me.Delete_node.Name = "Delete_node"
        Me.Delete_node.Size = New System.Drawing.Size(133, 23)
        Me.Delete_node.TabIndex = 6
        Me.Delete_node.Text = "Eliminar Nodo"
        Me.Delete_node.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Carpetas y Archivos"
        '
        'Delete_all_nodes
        '
        Me.Delete_all_nodes.Location = New System.Drawing.Point(279, 402)
        Me.Delete_all_nodes.Name = "Delete_all_nodes"
        Me.Delete_all_nodes.Size = New System.Drawing.Size(133, 23)
        Me.Delete_all_nodes.TabIndex = 8
        Me.Delete_all_nodes.Text = "Eliminar Demas Nodos"
        Me.Delete_all_nodes.UseVisualStyleBackColor = True
        '
        'SelectLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Delete_all_nodes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Delete_node)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.btnAgregar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SelectLinks"
        Me.Text = "Seleccionar Archivos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Delete_node As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Delete_all_nodes As Button
End Class
