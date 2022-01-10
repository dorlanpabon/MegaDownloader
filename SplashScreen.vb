﻿Public NotInheritable Class SplashScreen

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  
        lblMsg.Text = Language.GetText("Loading please wait")
        'lblThx.Text = Language.GetText("Thanks for using this app")
        lblThx.Text = InternalConfiguration.ObtenerNombreApp & InternalConfiguration.ObtenerValueFromInternalConfig("VERSION_MEGADOWNLOADER")

        Dim Config = New Configuracion

        If Config.Tema Then

            Me.BackColor = Color.FromArgb(32, 33, 36)
            Me.ForeColor = Color.FromArgb(188, 192, 195)

        End If

    End Sub

End Class
