Namespace RSS
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class RSS_Source
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
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.gbGeneral = New System.Windows.Forms.GroupBox()
            Me.chkAutomaticDownload = New System.Windows.Forms.CheckBox()
            Me.chkActive = New System.Windows.Forms.CheckBox()
            Me.txtFolder = New System.Windows.Forms.TextBox()
            Me.lblFolder = New System.Windows.Forms.Label()
            Me.txtAlias = New System.Windows.Forms.TextBox()
            Me.lblAlias = New System.Windows.Forms.Label()
            Me.lblUrl = New System.Windows.Forms.Label()
            Me.txtURL = New System.Windows.Forms.TextBox()
            Me.gbAdvanced = New System.Windows.Forms.GroupBox()
            Me.txtAuthPassw = New System.Windows.Forms.TextBox()
            Me.txtAuthName = New System.Windows.Forms.TextBox()
            Me.lblAuthPassw = New System.Windows.Forms.Label()
            Me.lblAuthName = New System.Windows.Forms.Label()
            Me.lblAuthType = New System.Windows.Forms.Label()
            Me.comboAuth = New System.Windows.Forms.ComboBox()
            Me.chkAuth = New System.Windows.Forms.CheckBox()
            Me.comboPeriod = New System.Windows.Forms.ComboBox()
            Me.txtPeriod = New System.Windows.Forms.TextBox()
            Me.lblUpdatePeriod = New System.Windows.Forms.Label()
            Me.chkCreateDirectory = New System.Windows.Forms.CheckBox()
            Me.gbFilters = New System.Windows.Forms.GroupBox()
            Me.gridFilters = New System.Windows.Forms.DataGridView()
            Me.columnField = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.columnType = New System.Windows.Forms.DataGridViewComboBoxColumn()
            Me.columnValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.llHelpAutomaticDownload = New System.Windows.Forms.LinkLabel()
            Me.btnSave = New System.Windows.Forms.Button()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.gbGeneral.SuspendLayout()
            Me.gbAdvanced.SuspendLayout()
            Me.gbFilters.SuspendLayout()
            CType(Me.gridFilters, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gbGeneral
            '
            Me.gbGeneral.Controls.Add(Me.llHelpAutomaticDownload)
            Me.gbGeneral.Controls.Add(Me.chkAutomaticDownload)
            Me.gbGeneral.Controls.Add(Me.chkActive)
            Me.gbGeneral.Controls.Add(Me.txtFolder)
            Me.gbGeneral.Controls.Add(Me.lblFolder)
            Me.gbGeneral.Controls.Add(Me.txtAlias)
            Me.gbGeneral.Controls.Add(Me.lblAlias)
            Me.gbGeneral.Controls.Add(Me.lblUrl)
            Me.gbGeneral.Controls.Add(Me.txtURL)
            Me.gbGeneral.Location = New System.Drawing.Point(12, 12)
            Me.gbGeneral.Name = "gbGeneral"
            Me.gbGeneral.Size = New System.Drawing.Size(347, 182)
            Me.gbGeneral.TabIndex = 0
            Me.gbGeneral.TabStop = False
            Me.gbGeneral.Text = "General"
            '
            'chkAutomaticDownload
            '
            Me.chkAutomaticDownload.AutoSize = True
            Me.chkAutomaticDownload.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkAutomaticDownload.Location = New System.Drawing.Point(27, 152)
            Me.chkAutomaticDownload.Name = "chkAutomaticDownload"
            Me.chkAutomaticDownload.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkAutomaticDownload.Size = New System.Drawing.Size(127, 17)
            Me.chkAutomaticDownload.TabIndex = 7
            Me.chkAutomaticDownload.Text = "Descarga automática"
            Me.chkAutomaticDownload.UseVisualStyleBackColor = True
            '
            'chkActive
            '
            Me.chkActive.AutoSize = True
            Me.chkActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkActive.Location = New System.Drawing.Point(98, 102)
            Me.chkActive.Name = "chkActive"
            Me.chkActive.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkActive.Size = New System.Drawing.Size(56, 17)
            Me.chkActive.TabIndex = 6
            Me.chkActive.Text = "Activo"
            Me.chkActive.UseVisualStyleBackColor = True
            '
            'txtFolder
            '
            Me.txtFolder.Location = New System.Drawing.Point(140, 76)
            Me.txtFolder.Name = "txtFolder"
            Me.txtFolder.Size = New System.Drawing.Size(192, 20)
            Me.txtFolder.TabIndex = 5
            '
            'lblFolder
            '
            Me.lblFolder.AutoSize = True
            Me.lblFolder.Location = New System.Drawing.Point(28, 79)
            Me.lblFolder.Name = "lblFolder"
            Me.lblFolder.Size = New System.Drawing.Size(106, 13)
            Me.lblFolder.TabIndex = 4
            Me.lblFolder.Text = "Carpeta de descarga"
            '
            'txtAlias
            '
            Me.txtAlias.Location = New System.Drawing.Point(140, 50)
            Me.txtAlias.Name = "txtAlias"
            Me.txtAlias.Size = New System.Drawing.Size(192, 20)
            Me.txtAlias.TabIndex = 3
            '
            'lblAlias
            '
            Me.lblAlias.AutoSize = True
            Me.lblAlias.Location = New System.Drawing.Point(105, 53)
            Me.lblAlias.Name = "lblAlias"
            Me.lblAlias.Size = New System.Drawing.Size(29, 13)
            Me.lblAlias.TabIndex = 2
            Me.lblAlias.Text = "Alias"
            '
            'lblUrl
            '
            Me.lblUrl.AutoSize = True
            Me.lblUrl.Location = New System.Drawing.Point(105, 26)
            Me.lblUrl.Name = "lblUrl"
            Me.lblUrl.Size = New System.Drawing.Size(29, 13)
            Me.lblUrl.TabIndex = 1
            Me.lblUrl.Text = "URL"
            '
            'txtURL
            '
            Me.txtURL.Location = New System.Drawing.Point(140, 23)
            Me.txtURL.Name = "txtURL"
            Me.txtURL.Size = New System.Drawing.Size(192, 20)
            Me.txtURL.TabIndex = 0
            '
            'gbAdvanced
            '
            Me.gbAdvanced.Controls.Add(Me.txtAuthPassw)
            Me.gbAdvanced.Controls.Add(Me.txtAuthName)
            Me.gbAdvanced.Controls.Add(Me.lblAuthPassw)
            Me.gbAdvanced.Controls.Add(Me.lblAuthName)
            Me.gbAdvanced.Controls.Add(Me.lblAuthType)
            Me.gbAdvanced.Controls.Add(Me.comboAuth)
            Me.gbAdvanced.Controls.Add(Me.chkAuth)
            Me.gbAdvanced.Controls.Add(Me.comboPeriod)
            Me.gbAdvanced.Controls.Add(Me.txtPeriod)
            Me.gbAdvanced.Controls.Add(Me.lblUpdatePeriod)
            Me.gbAdvanced.Controls.Add(Me.chkCreateDirectory)
            Me.gbAdvanced.Location = New System.Drawing.Point(365, 13)
            Me.gbAdvanced.Name = "gbAdvanced"
            Me.gbAdvanced.Size = New System.Drawing.Size(271, 181)
            Me.gbAdvanced.TabIndex = 1
            Me.gbAdvanced.TabStop = False
            Me.gbAdvanced.Text = "Avanzado"
            '
            'txtAuthPassw
            '
            Me.txtAuthPassw.Location = New System.Drawing.Point(135, 152)
            Me.txtAuthPassw.Name = "txtAuthPassw"
            Me.txtAuthPassw.Size = New System.Drawing.Size(126, 20)
            Me.txtAuthPassw.TabIndex = 15
            Me.txtAuthPassw.UseSystemPasswordChar = True
            '
            'txtAuthName
            '
            Me.txtAuthName.Location = New System.Drawing.Point(135, 126)
            Me.txtAuthName.Name = "txtAuthName"
            Me.txtAuthName.Size = New System.Drawing.Size(126, 20)
            Me.txtAuthName.TabIndex = 14
            '
            'lblAuthPassw
            '
            Me.lblAuthPassw.AutoSize = True
            Me.lblAuthPassw.Location = New System.Drawing.Point(68, 155)
            Me.lblAuthPassw.Name = "lblAuthPassw"
            Me.lblAuthPassw.Size = New System.Drawing.Size(61, 13)
            Me.lblAuthPassw.TabIndex = 13
            Me.lblAuthPassw.Text = "Contraseña"
            '
            'lblAuthName
            '
            Me.lblAuthName.AutoSize = True
            Me.lblAuthName.Location = New System.Drawing.Point(85, 129)
            Me.lblAuthName.Name = "lblAuthName"
            Me.lblAuthName.Size = New System.Drawing.Size(44, 13)
            Me.lblAuthName.TabIndex = 12
            Me.lblAuthName.Text = "Nombre"
            '
            'lblAuthType
            '
            Me.lblAuthType.AutoSize = True
            Me.lblAuthType.Location = New System.Drawing.Point(34, 102)
            Me.lblAuthType.Name = "lblAuthType"
            Me.lblAuthType.Size = New System.Drawing.Size(95, 13)
            Me.lblAuthType.TabIndex = 11
            Me.lblAuthType.Text = "Tipo autenticación"
            '
            'comboAuth
            '
            Me.comboAuth.FormattingEnabled = True
            Me.comboAuth.Location = New System.Drawing.Point(135, 99)
            Me.comboAuth.Name = "comboAuth"
            Me.comboAuth.Size = New System.Drawing.Size(126, 21)
            Me.comboAuth.TabIndex = 11
            '
            'chkAuth
            '
            Me.chkAuth.AutoSize = True
            Me.chkAuth.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkAuth.Location = New System.Drawing.Point(13, 77)
            Me.chkAuth.Name = "chkAuth"
            Me.chkAuth.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkAuth.Size = New System.Drawing.Size(136, 17)
            Me.chkAuth.TabIndex = 10
            Me.chkAuth.Text = "Requiere autenticación"
            Me.chkAuth.UseVisualStyleBackColor = True
            '
            'comboPeriod
            '
            Me.comboPeriod.FormattingEnabled = True
            Me.comboPeriod.Items.AddRange(New Object() {"Minutos", "Horas"})
            Me.comboPeriod.Location = New System.Drawing.Point(169, 48)
            Me.comboPeriod.Name = "comboPeriod"
            Me.comboPeriod.Size = New System.Drawing.Size(92, 21)
            Me.comboPeriod.TabIndex = 9
            '
            'txtPeriod
            '
            Me.txtPeriod.Location = New System.Drawing.Point(135, 48)
            Me.txtPeriod.Name = "txtPeriod"
            Me.txtPeriod.Size = New System.Drawing.Size(28, 20)
            Me.txtPeriod.TabIndex = 8
            Me.txtPeriod.Text = "3"
            '
            'lblUpdatePeriod
            '
            Me.lblUpdatePeriod.AutoSize = True
            Me.lblUpdatePeriod.Location = New System.Drawing.Point(21, 51)
            Me.lblUpdatePeriod.Name = "lblUpdatePeriod"
            Me.lblUpdatePeriod.Size = New System.Drawing.Size(108, 13)
            Me.lblUpdatePeriod.TabIndex = 7
            Me.lblUpdatePeriod.Text = "Periodo actualización"
            '
            'chkCreateDirectory
            '
            Me.chkCreateDirectory.AutoSize = True
            Me.chkCreateDirectory.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.chkCreateDirectory.Location = New System.Drawing.Point(52, 23)
            Me.chkCreateDirectory.Name = "chkCreateDirectory"
            Me.chkCreateDirectory.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.chkCreateDirectory.Size = New System.Drawing.Size(97, 17)
            Me.chkCreateDirectory.TabIndex = 7
            Me.chkCreateDirectory.Text = "Crear directorio"
            Me.chkCreateDirectory.UseVisualStyleBackColor = True
            '
            'gbFilters
            '
            Me.gbFilters.Controls.Add(Me.gridFilters)
            Me.gbFilters.Location = New System.Drawing.Point(12, 200)
            Me.gbFilters.Name = "gbFilters"
            Me.gbFilters.Size = New System.Drawing.Size(624, 178)
            Me.gbFilters.TabIndex = 2
            Me.gbFilters.TabStop = False
            Me.gbFilters.Text = "Filtros de descarga automática"
            '
            'gridFilters
            '
            Me.gridFilters.AllowUserToResizeColumns = False
            Me.gridFilters.AllowUserToResizeRows = False
            Me.gridFilters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.gridFilters.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnField, Me.columnType, Me.columnValue})
            Me.gridFilters.Location = New System.Drawing.Point(11, 19)
            Me.gridFilters.Name = "gridFilters"
            Me.gridFilters.Size = New System.Drawing.Size(603, 148)
            Me.gridFilters.TabIndex = 0
            '
            'columnField
            '
            DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
            Me.columnField.DefaultCellStyle = DataGridViewCellStyle7
            Me.columnField.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.columnField.HeaderText = "Campo"
            Me.columnField.Items.AddRange(New Object() {"Titulo", "Descripcion", "Link"})
            Me.columnField.Name = "columnField"
            Me.columnField.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.columnField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.columnField.Width = 170
            '
            'columnType
            '
            Me.columnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.columnType.HeaderText = "Tipo"
            Me.columnType.Items.AddRange(New Object() {"Contiene", "Igual a", "Regex"})
            Me.columnType.Name = "columnType"
            '
            'columnValue
            '
            Me.columnValue.HeaderText = "Valor"
            Me.columnValue.Name = "columnValue"
            Me.columnValue.Width = 285
            '
            'llHelpAutomaticDownload
            '
            Me.llHelpAutomaticDownload.AutoSize = True
            Me.llHelpAutomaticDownload.Location = New System.Drawing.Point(160, 153)
            Me.llHelpAutomaticDownload.Name = "llHelpAutomaticDownload"
            Me.llHelpAutomaticDownload.Size = New System.Drawing.Size(19, 13)
            Me.llHelpAutomaticDownload.TabIndex = 8
            Me.llHelpAutomaticDownload.TabStop = True
            Me.llHelpAutomaticDownload.Text = "[?]"
            '
            'btnSave
            '
            Me.btnSave.Location = New System.Drawing.Point(12, 384)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(93, 27)
            Me.btnSave.TabIndex = 3
            Me.btnSave.Text = "Guardar"
            Me.btnSave.UseVisualStyleBackColor = True
            '
            'btnCancel
            '
            Me.btnCancel.Location = New System.Drawing.Point(543, 384)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(93, 27)
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.Text = "Cancelar"
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'RSS_Source
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(648, 422)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.gbFilters)
            Me.Controls.Add(Me.gbAdvanced)
            Me.Controls.Add(Me.gbGeneral)
            Me.Icon = Global.MegaDownloader.My.Resources.Resources.icono
            Me.Name = "RSS_Source"
            Me.Text = "RSS_Source"
            Me.gbGeneral.ResumeLayout(False)
            Me.gbGeneral.PerformLayout()
            Me.gbAdvanced.ResumeLayout(False)
            Me.gbAdvanced.PerformLayout()
            Me.gbFilters.ResumeLayout(False)
            CType(Me.gridFilters, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents gbGeneral As System.Windows.Forms.GroupBox
        Friend WithEvents lblAlias As System.Windows.Forms.Label
        Friend WithEvents lblUrl As System.Windows.Forms.Label
        Friend WithEvents txtURL As System.Windows.Forms.TextBox
        Friend WithEvents txtAlias As System.Windows.Forms.TextBox
        Friend WithEvents txtFolder As System.Windows.Forms.TextBox
        Friend WithEvents lblFolder As System.Windows.Forms.Label
        Friend WithEvents chkActive As System.Windows.Forms.CheckBox
        Friend WithEvents gbAdvanced As System.Windows.Forms.GroupBox
        Friend WithEvents chkCreateDirectory As System.Windows.Forms.CheckBox
        Friend WithEvents lblUpdatePeriod As System.Windows.Forms.Label
        Friend WithEvents txtPeriod As System.Windows.Forms.TextBox
        Friend WithEvents comboPeriod As System.Windows.Forms.ComboBox
        Friend WithEvents chkAuth As System.Windows.Forms.CheckBox
        Friend WithEvents txtAuthPassw As System.Windows.Forms.TextBox
        Friend WithEvents txtAuthName As System.Windows.Forms.TextBox
        Friend WithEvents lblAuthPassw As System.Windows.Forms.Label
        Friend WithEvents lblAuthName As System.Windows.Forms.Label
        Friend WithEvents lblAuthType As System.Windows.Forms.Label
        Friend WithEvents comboAuth As System.Windows.Forms.ComboBox
        Friend WithEvents chkAutomaticDownload As System.Windows.Forms.CheckBox
        Friend WithEvents gbFilters As System.Windows.Forms.GroupBox
        Friend WithEvents gridFilters As System.Windows.Forms.DataGridView
        Friend WithEvents columnField As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents columnType As System.Windows.Forms.DataGridViewComboBoxColumn
        Friend WithEvents columnValue As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents llHelpAutomaticDownload As System.Windows.Forms.LinkLabel
        Friend WithEvents btnSave As System.Windows.Forms.Button
        Friend WithEvents btnCancel As System.Windows.Forms.Button
    End Class

End Namespace
