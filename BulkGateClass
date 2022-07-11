Public Class BulkGateClass
    Private BulkGateSettings As BulkGateSettings

    Public Sub New(Bs As BulkGateSettings)
        BulkGateSettings = Bs
    End Sub

    Public Function Send(number As String, text As String, ByRef ok As Boolean, Optional country As String = "") As Object
        Dim resultJSON As String = "0"
        Dim values As NameValueCollection = New NameValueCollection() From {
            {"application_id", BulkGateSettings.application_id},
            {"application_token", BulkGateSettings.application_token},
            {"sender_id", BulkGateSettings.sender_id},
            {"sender_id_value", BulkGateSettings.sender_id_value},
            {"number", number},
            {"text", text},
            {"unicode", "true"}
        }

        If country.Length > 1 Then
            values.Add("country", country)
        End If

        Try

            Using client As New WebClient()
                ServicePointManager.Expect100Continue = True
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
                Dim result = client.UploadValues(BulkGateSettings.bulkgate_serviceURL, values)
                resultJSON = Encoding.UTF8.GetString(result)
            End Using

        Catch ex As Exception
            ok = False
            resultJSON = $"err = {ex}"
        End Try

        If resultJSON.Length > 0 Then
            ok = True
        End If

        Return resultJSON
    End Function
End Class
