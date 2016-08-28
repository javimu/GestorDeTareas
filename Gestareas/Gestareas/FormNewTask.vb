Public Class FormNewTask
    'Variables
    'Si boUpdate es True, la pantalla se comporta para visualizar tareas y modificarlas (update)
    'Si boUpdate es false, la pantalla se comporta para el alta de tareas (insert)
    Dim bolUpdate As Boolean
    'PK del registro a actualizar
    Dim intPK As Integer


    'Constructor para pantalla de insercion de tarea
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "nueva Tarea"
        Me.AccessibleDescription = Me.Text
        Me.cbType.SelectedIndex = 0
        Me.cbPriority.SelectedIndex = 2
        Me.cbStatus.SelectedIndex = 0
        Dim dbSQLite As dbSqlite = New dbSqlite
        Me.cbProject.DataSource = dbSQLite.getProjects()
        Me.cbProject.DisplayMember = "project"
        Me.cbProject.SelectedItem = Nothing
        'Constructor para pantalla en modalidad insert
        Me.bolUpdate = False
        'Botones por defecto
        Me.AcceptButton = btSave
        Me.CancelButton = btCancel
    End Sub

    'Constructor para pantalla en modalidad update
    Public Sub New(ByVal intPK As Integer, ByVal strTitle As String,
                   ByVal strProject As String, ByVal strType As String,
                   ByVal strPriority As String, ByVal strStatus As String,
                   ByVal dateEndTask As String, ByVal strDetails As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Text = "Modificar Tarea"
        Me.AccessibleDescription = Me.Text
        Me.cbType.SelectedIndex = 0
        Me.cbPriority.SelectedIndex = 2
        Me.cbStatus.SelectedIndex = 0
        'Constructor para pantalla en modalidad update
        Me.bolUpdate = True
        Me.btSave.Text = "Modificar"
        'Pasando parámetros 
        Me.intPK = intPK
        Me.tbTitle.Text = strTitle
        Me.cbProject.Text = strProject
        Me.cbType.SelectedItem = strType
        Me.cbPriority.SelectedItem = strPriority
        Me.cbStatus.SelectedItem = strStatus
        Me.dpDateEndTask.Value = Convert.ToDateTime(dateEndTask)
        Me.tbTaskDetails.Text = strDetails

        'Botones por defecto
        Me.AcceptButton = btSave
        Me.CancelButton = btCancel
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click

        'Validando que se han rellenado campos obligatorios
        Dim strErrorMessage As String = Nothing
        If tbTitle.Text = "" Then
            strErrorMessage = strErrorMessage & Chr(13) & "Título de la tarea"
        End If

        If cbProject.Text = "" Then
            strErrorMessage = strErrorMessage & Chr(13) & "Título del proyecto"
        End If

        'Mensaje error por pantalla
        If Not IsNothing(strErrorMessage) Then
            MsgBox("Por favor, rellene: " & strErrorMessage)
            Exit Sub
        End If

        'Si la pantalla esta en modalidad insert
        If Not Me.bolUpdate Then
            'Insert nuevo registro
            Try
                Dim dbSQLite As dbSqlite = New dbSqlite
                dbSQLite.insertTask(tbTitle.Text, cbProject.Text,
                                    cbType.Text, cbPriority.SelectedItem,
                                    cbStatus.SelectedItem, dpDateEndTask.Value.Date,
                                    tbTaskDetails.Text)

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            'modalidad update
            Try
                Dim dbSQLite As dbSqlite = New dbSqlite
                dbSQLite.updateTask(Me.intPK, tbTitle.Text, cbProject.Text,
                                    cbType.Text, cbPriority.SelectedItem,
                                    cbStatus.SelectedItem, dpDateEndTask.Value.Date,
                                    tbTaskDetails.Text)

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
End Class