Namespace RSS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class RSS_Main
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.RSSDetails = New BrightIdeasSoftware.TreeListView()
            Me.OlvName = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.OlvDescription = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
            Me.ListBox1 = New System.Windows.Forms.ListBox()
            Me.btnNewSource = New System.Windows.Forms.Button()
            CType(Me.RSSDetails, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'RSSDetails
            '
            Me.RSSDetails.AllColumns.Add(Me.OlvName)
            Me.RSSDetails.AllColumns.Add(Me.OlvDescription)
            Me.RSSDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.RSSDetails.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvName, Me.OlvDescription})
            Me.RSSDetails.Location = New System.Drawing.Point(154, 12)
            Me.RSSDetails.Name = "RSSDetails"
            Me.RSSDetails.OwnerDraw = True
            Me.RSSDetails.ShowGroups = False
            Me.RSSDetails.Size = New System.Drawing.Size(556, 293)
            Me.RSSDetails.TabIndex = 1
            Me.RSSDetails.UseCompatibleStateImageBehavior = False
            Me.RSSDetails.View = System.Windows.Forms.View.Details
            Me.RSSDetails.VirtualMode = True
            '
            'OlvName
            '
            Me.OlvName.Text = "Name"
            Me.OlvName.Width = 150
            '
            'OlvDescription
            '
            Me.OlvDescription.Text = "Description"
            Me.OlvDescription.Width = 400
            '
            'ListBox1
            '
            Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.ListBox1.FormattingEnabled = True
            Me.ListBox1.HorizontalScrollbar = True
            Me.ListBox1.Items.AddRange(New Object() {"RSS example 1", "RSS example 2"})
            Me.ListBox1.Location = New System.Drawing.Point(12, 12)
            Me.ListBox1.Name = "ListBox1"
            Me.ListBox1.Size = New System.Drawing.Size(136, 264)
            Me.ListBox1.TabIndex = 2
            '
            'btnNewSource
            '
            Me.btnNewSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnNewSource.Location = New System.Drawing.Point(12, 282)
            Me.btnNewSource.Name = "btnNewSource"
            Me.btnNewSource.Size = New System.Drawing.Size(136, 23)
            Me.btnNewSource.TabIndex = 3
            Me.btnNewSource.Text = "Add RSS source"
            Me.btnNewSource.UseVisualStyleBackColor = True
            '
            'RSS_Main
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(722, 317)
            Me.Controls.Add(Me.btnNewSource)
            Me.Controls.Add(Me.ListBox1)
            Me.Controls.Add(Me.RSSDetails)
            Me.Icon = Global.MegaDownloader.My.Resources.Resources.icono
            Me.Name = "RSS_Main"
            Me.Text = "RSS"
            CType(Me.RSSDetails, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents RSSDetails As BrightIdeasSoftware.TreeListView
        Friend WithEvents OlvName As BrightIdeasSoftware.OLVColumn
        Friend WithEvents OlvDescription As BrightIdeasSoftware.OLVColumn
        Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
        Friend WithEvents btnNewSource As System.Windows.Forms.Button
    End Class

End Namespace
