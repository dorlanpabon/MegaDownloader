Namespace RSS
    Public Class RSS_Source


        Private Sub RSS_Source_Load(sender As Object, e As System.EventArgs) Handles Me.Load


            comboPeriod.SelectedIndex = 0
            chkAuth_CheckedChanged(Nothing, Nothing)
            chkAutomaticDownload_CheckedChanged(Nothing, Nothing)
        End Sub

        Private Sub chkAuth_CheckedChanged(sender As Object, e As EventArgs) Handles chkAuth.CheckedChanged
            comboAuth.Enabled = chkAuth.Checked
            txtAuthName.Enabled = chkAuth.Checked
            txtAuthPassw.Enabled = chkAuth.Checked
        End Sub

        Private Sub chkAutomaticDownload_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutomaticDownload.CheckedChanged
            gridFilters.Enabled = chkAutomaticDownload.Checked
            gridFilters.ClearSelection()

            If chkAutomaticDownload.Checked Then
                gridFilters.Columns.Item(0).DefaultCellStyle.BackColor = Color.White
                gridFilters.Columns.Item(1).DefaultCellStyle.BackColor = Color.White
                gridFilters.Columns.Item(2).DefaultCellStyle.BackColor = Color.White
            Else
                gridFilters.Columns.Item(0).DefaultCellStyle.BackColor = Color.LightGray
                gridFilters.Columns.Item(1).DefaultCellStyle.BackColor = Color.LightGray
                gridFilters.Columns.Item(2).DefaultCellStyle.BackColor = Color.LightGray
            End If

        End Sub
    End Class
End Namespace
