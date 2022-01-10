<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SelectLinks
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Carpeta")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectLinks))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.BtnDelete_node = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDelete_all_nodes = New System.Windows.Forms.Button()
        Me.imageTreeview = New System.Windows.Forms.ImageList(Me.components)
        Me.Tamano = New System.Windows.Forms.Label()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnContraer = New System.Windows.Forms.Button()
        Me.BtnExpandir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(597, 402)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(133, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar links"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'BtnDelete_node
        '
        Me.BtnDelete_node.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete_node.Enabled = False
        Me.BtnDelete_node.Location = New System.Drawing.Point(439, 402)
        Me.BtnDelete_node.Name = "BtnDelete_node"
        Me.BtnDelete_node.Size = New System.Drawing.Size(133, 23)
        Me.BtnDelete_node.TabIndex = 6
        Me.BtnDelete_node.Text = "Eliminar Item"
        Me.BtnDelete_node.UseVisualStyleBackColor = True
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
        'BtnDelete_all_nodes
        '
        Me.BtnDelete_all_nodes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete_all_nodes.Enabled = False
        Me.BtnDelete_all_nodes.Location = New System.Drawing.Point(279, 402)
        Me.BtnDelete_all_nodes.Name = "BtnDelete_all_nodes"
        Me.BtnDelete_all_nodes.Size = New System.Drawing.Size(133, 23)
        Me.BtnDelete_all_nodes.TabIndex = 8
        Me.BtnDelete_all_nodes.Text = "Eliminar Demas Items"
        Me.BtnDelete_all_nodes.UseVisualStyleBackColor = True
        '
        'imageTreeview
        '
        Me.imageTreeview.ImageStream = CType(resources.GetObject("imageTreeview.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageTreeview.TransparentColor = System.Drawing.Color.Transparent
        Me.imageTreeview.Images.SetKeyName(0, "folder.png")
        Me.imageTreeview.Images.SetKeyName(1, "addlink.png")
        Me.imageTreeview.Images.SetKeyName(2, "plantilla.png")
        '
        'Tamano
        '
        Me.Tamano.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Tamano.AutoSize = True
        Me.Tamano.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tamano.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Tamano.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tamano.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.Tamano.Location = New System.Drawing.Point(62, 402)
        Me.Tamano.Name = "Tamano"
        Me.Tamano.Size = New System.Drawing.Size(67, 20)
        Me.Tamano.TabIndex = 9
        Me.Tamano.Text = "Tamaño"
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Location = New System.Drawing.Point(597, 23)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(133, 23)
        Me.BtnRestaurar.TabIndex = 10
        Me.BtnRestaurar.Text = "Restaurar"
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        '
        'BtnContraer
        '
        Me.BtnContraer.Location = New System.Drawing.Point(244, 23)
        Me.BtnContraer.Name = "BtnContraer"
        Me.BtnContraer.Size = New System.Drawing.Size(60, 23)
        Me.BtnContraer.TabIndex = 11
        Me.BtnContraer.Text = "Contraer"
        Me.BtnContraer.UseVisualStyleBackColor = True
        '
        'BtnExpandir
        '
        Me.BtnExpandir.Location = New System.Drawing.Point(310, 23)
        Me.BtnExpandir.Name = "BtnExpandir"
        Me.BtnExpandir.Size = New System.Drawing.Size(60, 23)
        Me.BtnExpandir.TabIndex = 12
        Me.BtnExpandir.Text = "Expandir"
        Me.BtnExpandir.UseVisualStyleBackColor = True
        '
        'SelectLinks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnExpandir)
        Me.Controls.Add(Me.BtnContraer)
        Me.Controls.Add(Me.BtnRestaurar)
        Me.Controls.Add(Me.Tamano)
        Me.Controls.Add(Me.BtnDelete_all_nodes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnDelete_node)
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
    Friend WithEvents BtnDelete_node As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDelete_all_nodes As Button
    Friend WithEvents imageTreeview As ImageList
    Friend WithEvents Tamano As Label
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnContraer As Button
    Friend WithEvents BtnExpandir As Button
End Class
