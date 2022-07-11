Public Structure BulkGateSettings
    ''' <summary>
    ''' default address : https://portal.bulkgate.com/api/1.0/advanced/transactional
    ''' </summary>
    ''' <returns></returns>
    Public Property bulkgate_serviceURL As String

    ''' <summary>
    ''' BulkGate application token
    ''' </summary>
    ''' <returns></returns>
    Public Property application_token As String

    ''' <summary>
    ''' BulkGate application id
    ''' </summary>
    ''' <returns></returns>
    Public Property application_id As String
    ''' <summary>
    ''' BulkGate sender id
    ''' </summary>
    ''' <returns></returns>
    Public Property sender_id As String
    ''' <summary>
    ''' BulkGate sender id value
    ''' </summary>
    ''' <returns></returns>
    Public Property sender_id_value As String
End Structure
