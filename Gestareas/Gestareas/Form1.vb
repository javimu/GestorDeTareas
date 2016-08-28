Imports Gestareas.dbSqlite
Imports System.IO
Imports System.Windows.Forms.Application

Public Class Form1

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
                Me.cbPriority.SelectedIndex = 0
        Me.cbType.SelectedIndex = 0
        Me.cbStatus.SelectedIndex = 1
        

    End Sub

    'Cuando se inicia form1 se verifica la BD
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Verificando si existe la base de datos
        'MsgBox(My.Settings.pathDB)
        If Not File.Exists(My.Settings.pathDB.Trim & "\" & My.Settings.nameDB.Trim) Then
            Dim checkDB As FormCheckDB = New FormCheckDB
            checkDB.ShowDialog()

            'Creando la BD si no existe
            Try
                Dim dbSqlite = New dbSqlite()
                'Si no existe la base de datos se crea
                dbSQLite.createDB()
                
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Configurando combobox searProject con datos
        Dim dataBaseSQLite As dbSqlite = New dbSqlite
        Me.cbSearchProject.DataSource = dataBaseSQLite.getProjects()
        Me.cbSearchProject.DisplayMember = "project"
        Me.cbSearchProject.SelectedItem = Nothing
        'Mostrando datos de la bd en dataGrid
        Me.dgvTaskList.DataSource = dataBaseSQLite.searchByPriorityStatusType(Me.cbPriority.SelectedItem, Me.cbStatus.SelectedItem, Me.cbType.SelectedItem, Me.cbSearchProject.SelectedItem)
    End Sub
    'Sobreescribimos evento de respuesta ante teclas, para que al presionar enter no baje el selector del DGV una fila
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        'Si el DGV no tiene el foco abandonamos el método llamando a la funcion base
        If Not Me.dgvTaskList.Focused Then
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If

        'Si la tecla es distinta de enter, abanonamos el proceso
        'If keyData <> keyData.Enter Then
        '    Return MyBase.ProcessCmdKey(msg, keyData)
        'End If

        If keyData = keyData.Enter Then
            'La tecla es enter, ejecutamos acción
            Me.openDetailsTask()
        End If

        If keyData = keyData.Space Then
            Me.openDetailsTask()
        End If

        'Si se presiona tab, se pasa al siguiente control
        If keyData = keyData.Tab Then
            Me.btNewTask.Focus()
        End If

        'Si se presiona suprimir, se borra el registro                    
        If keyData = keyData.Delete Then
            Dim strTitle As String = Me.dgvTaskList.Rows(Me.dgvTaskList.CurrentCell.RowIndex).Cells(1).Value.ToString
            Dim message As String = "¿Está seguro de que desea eliminar el registro " & strTitle & "?"
            Dim response As MsgBoxResult
            response = MsgBox(message, 4, "Borrado de tarea")
            If response.Yes Then
                Dim dbSqlite As dbSqlite = New dbSqlite
                dbSqlite.deleteTask(Me.dgvTaskList.Rows(Me.dgvTaskList.CurrentCell.RowIndex).Cells(0).Value)
                Me.dgvTaskList.DataSource = dbSqlite.searchByPriorityStatusType(Me.cbPriority.SelectedItem, Me.cbStatus.SelectedItem, Me.cbType.SelectedItem, Me.cbSearchProject.SelectedItem)
            End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btNewTask_Click(sender As Object, e As EventArgs) Handles btNewTask.Click
        Dim mydb As dbSqlite = New dbSqlite()
        mydb.createDB()

        Dim formNewTask As FormNewTask = New FormNewTask()
        formNewTask.ShowDialog(Me)
        'Recargamos el DGV
        Dim dbSQLite As dbSqlite = New dbSqlite
        Me.dgvTaskList.DataSource = dbSQLite.searchByPriorityStatusType(Me.cbPriority.SelectedItem, Me.cbStatus.SelectedItem, Me.cbType.SelectedItem, Me.cbSearchProject.SelectedItem)
    End Sub

    Private Sub cbPriority_Leave(sender As Object, e As EventArgs) Handles cbPriority.Leave
        'Cuando se pierde el foco en el combobox se ejecuta la consulta
        Me.lostFocusinComboBox()
    End Sub

    Private Sub cbType_Leave(sender As Object, e As EventArgs) Handles cbType.Leave
        'Cuando se pierde el foco en el combobox se ejecuta la consulta
        Me.lostFocusinComboBox()
    End Sub

    Private Sub cbStatus_Leave(sender As Object, e As EventArgs) Handles cbStatus.Leave
        'Cuando se pierde el foco en el combobox se ejecuta la consulta
        Me.lostFocusinComboBox()
    End Sub

    'Método a ejecutar cuando se pierde el foco en cualquier comboBox
    Private Sub lostFocusinComboBox()
        Try
            Dim dbSqlite As dbSqlite = New dbSqlite
            Me.dgvTaskList.DataSource = dbSqlite.searchByPriorityStatusType(Me.cbPriority.SelectedItem, Me.cbStatus.SelectedItem, Me.cbType.SelectedItem, Me.cbSearchProject.Text)
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Sub dgvTaskList_DoubleClick(sender As Object, e As EventArgs) Handles dgvTaskList.DoubleClick
        Me.openDetailsTask()
    End Sub

    'Accion ante eventos en dataGrid
    Private Sub openDetailsTask()
        Dim intCell As Integer

        intCell = Me.dgvTaskList.CurrentCell.RowIndex
        Dim intPK As Integer = Me.dgvTaskList.Rows(intCell).Cells("pk").Value
        Dim strTitle As String = Me.dgvTaskList.Rows(intCell).Cells("title").Value
        Dim strProject As String = Me.dgvTaskList.Rows(intCell).Cells("project").Value
        Dim strType As String = Me.dgvTaskList.Rows(intCell).Cells("type").Value
        Dim strPriority As String = Me.dgvTaskList.Rows(intCell).Cells("priority").Value
        Dim strStatus As String = Me.dgvTaskList.Rows(intCell).Cells("status").Value
        Dim dateEndTask As String = Me.dgvTaskList.Rows(intCell).Cells("dateEndTask").Value
        Dim strDetails As String = Me.dgvTaskList.Rows(intCell).Cells("details").Value
        Dim formUpdate As FormNewTask = New FormNewTask(intPK, strTitle, strProject, strType, strPriority, strStatus, dateEndTask, strDetails)
        formUpdate.ShowDialog(Me)
        'Recargamos el DGV
        Dim dbSQLite As dbSqlite = New dbSqlite
        Me.dgvTaskList.DataSource = dbSQLite.searchByPriorityStatusType(Me.cbPriority.SelectedItem, Me.cbStatus.SelectedItem, Me.cbType.SelectedItem, Me.cbSearchProject.SelectedItem)
    End Sub

    Private Sub dgvTaskList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvTaskList.MouseDoubleClick
        Me.openDetailsTask()
    End Sub

    Private Sub dgvTaskList_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTaskList.CellMouseDoubleClick
        Me.openDetailsTask()
    End Sub

    
    Private Sub cbSearchProject_Leave(sender As Object, e As EventArgs) Handles cbSearchProject.Leave
        If Me.tbSearch.Text = "" Then
            Me.lostFocusinComboBox()
        End If
    End Sub
    'Cuando hay pérdida de foco en campo searchAll
    Private Sub tbSearch_Leave(sender As Object, e As EventArgs) Handles tbSearch.Leave
        'Solo se buscará si hay datos de búsqueda
        If Not Me.tbSearch.Text = "" Then
            Dim dbSQLite = New dbSqlite()
            Me.dgvTaskList.DataSource = dbSQLite.searchAll(Me.tbSearch.Text)
        End If
    End Sub
End Class
