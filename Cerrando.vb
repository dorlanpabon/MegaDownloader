Public NotInheritable Class Cerrando

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Cerrando_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim Config = New Configuracion

        If Config.Tema Then

            Me.BackColor = Color.FromArgb(32, 33, 36)
            Me.ForeColor = Color.FromArgb(188, 192, 195)

        End If
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).


    End Sub

End Class
