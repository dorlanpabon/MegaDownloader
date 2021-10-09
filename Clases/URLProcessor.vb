Public Class URLProcessor

    Public Class FileURL

        Public Sub New(pURL As String, pPath As String, pName As String, pSize As Long)
            Me.URL = pURL
            Me.Path = pPath
            Me.Name = pName
            Me.Size = pSize
        End Sub

        Public URL As String
        Public Path As String
        Public Name As String
        Public Size As Long

    End Class

    Public Shared Function ProcessURLs(URLs As Generic.List(Of String), ByRef Config As Configuracion, ByVal root As List(Of String)) As Generic.List(Of FileURL)
        If root Is Nothing Then
            Throw New ArgumentNullException(NameOf(root))
        End If

        ' Contenedores de links
        Dim URLs2 As New Generic.List(Of String)
        For Each URL As String In URLs
            If LinkProtectors.IsLinkProtector(URL) Then
                URLs2.AddRange(LinkProtectors.ExtraerURLs(URL))
            Else
                URLs2.Add(URL)
            End If
        Next


        ' Convertimos los links de MegaFolder a links individuales
        Dim URLs3 As New Generic.List(Of FileURL)
        For Each URL As String In URLs2
            If URLExtractor.IsMegaFolder(URL) Then
                Dim FolderID As String = URLExtractor.ExtraerFileID(URL)
                Dim FolderKey As String = URLExtractor.ExtraerFileKey(URL)
                For Each FileURL In MegaFolderHelper.RetrieveLinksFromFolder(FolderID, FolderKey, root)
                    URLs3.Add(FileURL)
                Next
            ElseIf URLExtractor.IsELC(URL) Then
                Dim ELC_exc As Exception = Nothing
                For Each FileURL As String In ServerEncoderLinkHelper.ServerDecode(URL, Config, ELC_exc)
                    If URLExtractor.IsMegaFolder(FileURL) Then
                        Dim FolderID As String = URLExtractor.ExtraerFileID(FileURL)
                        Dim FolderKey As String = URLExtractor.ExtraerFileKey(FileURL)
                        For Each FileURL2 In MegaFolderHelper.RetrieveLinksFromFolder(FolderID, FolderKey, root)
                            URLs3.Add(New FileURL(Fichero.HIDDEN_LINK & FileURL2.URL, FileURL2.Path, "", 0))
                        Next
                    Else
                        URLs3.Add(New FileURL(Fichero.HIDDEN_LINK & FileURL, "", "", 0))
                    End If
                Next
                If ELC_exc IsNot Nothing Then
                    Throw ELC_exc
                End If
            Else
                URLs3.Add(New FileURL(URL, "", "", 0))
            End If
        Next
        Return URLs3
    End Function

End Class
