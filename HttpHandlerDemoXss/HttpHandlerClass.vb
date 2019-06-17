Public Class HttpHandlerClass
    Implements IHttpHandler

    Public ReadOnly Property IsReusable As Boolean Implements IHttpHandler.IsReusable
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Sub ProcessRequest(context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.WriteFile(System.IO.Path.GetFileName(context.Server.UrlEncode(context.Request.Path)))
    End Sub
End Class
