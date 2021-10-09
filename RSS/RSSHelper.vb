Namespace RSS

    'Public Class RSSHelper

    '    ' Ejemplo:
    '    ' http://showrss.info/rss.php?user_id=256104&hd=2&proper=null

    '    ' Más info:
    '    ' http://help.utorrent.com/customer/portal/articles/163700-how-do-i-import-torrents-from-rss-feeds-
    '    ' https://en.wikipedia.org/wiki/Broadcatching
    '    Public Class RSSChannel
    '        Public Title As String
    '        Public Description As String
    '        Public Link As String
    '        Public TTL As String
    '    End Class

    '    Public Class RSSItem
    '        Public Title As String
    '        Public Description As String
    '        Public Link As String
    '        Public GUID As String
    '        Public pubDate As String
    '    End Class

    '    Public Shared Function GetRSS(Url As String) As Object

    '        ' Meter nuevos RSS:
    '        ' http://help.utorrent.com/customer/portal/articles/163700-how-do-i-import-torrents-from-rss-feeds-
    '        ' URL
    '        ' Alias (opcional)
    '        ' Carpeta de descarga (opcional, el directorio por defecto sino)
    '        ' Activo (bit)

    '        ' Crear directorio con nombre title (bit)
    '        ' Velocidad actualización: cada x minutos, horas o días (mínimo 15 minutos, por defecto cada 3 horas)
    '        ' Usuario password (opcional, autenticación HTTP)

    '        ' Automatic download (bit) 
    '        ' Si es automatic -> Filtros -> campo (title/description) y Contains o Regex (opcional)



    '        ' En disco se irá guardando el último RSS y los elementos DESCARGADOS, indicando fecha de descarga nada más

    '        ' Ver RSSs
    '        ' -> Ver 
    '        ' Ventana nueva, tipo cola de descompresión
    '        ' Te dirá si está descargado y cuando se descargó
    '        ' Botón de descargar un item concreto (se añadirá el elemento igual que se añade automáticamente, sin preguntar nada)

    '       Proceso
    '       Al iniciar se irán descargando los RSS en segundo plano
    '       Los que tengan el automatic download, se añadirán a la cola de descargas y empezará a descargar -> Paquete "title [RSS]"
    '    End Function

    'End Class

End Namespace