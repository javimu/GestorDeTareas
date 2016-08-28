Imports System.Data.SQLite

Public Class dbSqlite
    'Variables
    Dim ConnectionString As String = "Data Source=" & My.Settings.pathDB.Trim & "\" & My.Settings.nameDB.Trim & ";Version=3;"
    Dim connection As SQLiteConnection
    Dim command As SQLiteCommand


    Public Sub New()

        Try
            'Creando conexion a BD
            Me.connection = New SQLiteConnection(Me.ConnectionString)

        Catch ex As Exception
            Throw (New Exception("Error al conectar con la base de datos. - " & ex.Message))
        End Try

        Try
            'Apertura conexion base de datos
            Me.connection.Open()
            'Preparando propiedad command para ejecución de comandos
            Me.command = Me.connection.CreateCommand()
        Catch ex As Exception
            Throw (New Exception("Error apertura base de datos - " & ex.Message))
            'Cierre BD si se ha abierto
            If Not IsNothing(Me.connection) Then
                Me.connection.Close()
            End If
        End Try
    End Sub

    'Creación base de datos de tareas
    Public Sub createDB()

        Try
            
            'Configurando comando SQL
            Me.command.CommandText = "create table if not exists t_tasks_s (" & _
    "pk integer primary key autoincrement, " & _
    "title  varchar(300), " & _
    "project varchar (150), " & _
    "TYPE VARCHAR (15), " & _
    "PRIORITY VARCHAR (15), " & _
    "STATUS VARCHAR (15), " & _
    "DATEENDTASK DATE, " & _
            "DETAILS text " & _
            "dateCreated DATE, " & _
            "datemodified DATE " & _
    ")"
            command.ExecuteNonQuery()
        Catch ex As Exception
            Throw (New Exception("Error creando base de datos - " & ex.Message))
        Finally
            If Not IsNothing(Me.connection) Then
                Me.connection.Close()
            End If
        End Try
    End Sub
    'Insercion de un registro.
    Public Sub insertTask(ByVal strTitle As String, ByVal strProject As String,
        ByVal strType As String, ByVal strPriority As String,
        ByVal strStatus As String, ByVal dpDateEndTask As Date,
        ByVal strDetails As String)
        Try

            command.CommandText = "insert into t_tasks_s values (null, " & _
            "'" & strTitle & "', " & _
            "'" & strProject & "', " & _
            "'" & strType & "', " & _
            "'" & strPriority & "', " & _
            "'" & strStatus & "', " & _
    "'" & Format(dpDateEndTask, "yyyy-MM-dd") & "', " & _
            "'" & strDetails & "', " & _
            " '" & Date.Now.ToString("yyyy-MM-dd") & "'," & _
            " null)"

            Me.command.ExecuteNonQuery()

        Catch ex As Exception
            Throw (New Exception("Error insertando en base de datos - " & ex.Message))
        Finally
            Me.connection.Close()
        End Try

    End Sub

    'Consulta 
    Public Function searchByPriorityStatusType(ByVal strPriority As String, ByVal strStatus As String, ByVal strType As String, ByVal strProject As String) As DataTable

        Dim strSelect As String

        strSelect = "select pk, project, title, status, priority, type, dateEndTask, details from t_tasks_s " & _
            "where type = '" & strType & "' "

        If Not strPriority = "Todas" Then
            strSelect = strSelect & " and priority = '" & strPriority & "' "
        End If

        If Not strStatus = "Todos" Then
            strSelect = strSelect & " and status = '" & strStatus & "'"
        End If

        If Not strProject = "" Then
            strSelect = strSelect & " and project = '" & strProject & "' "
        End If

        'Añadiendo consulta al command.
        Me.command.CommandText = strSelect

        'Rellenando dataAdapter con consulta
        Dim dsSearch As DataTable
        Dim dataAdapter As SQLiteDataAdapter

        Try
            dsSearch = New DataTable
            dataAdapter = New SQLiteDataAdapter(Me.command)
            dataAdapter.Fill(dsSearch)

            Return dsSearch
        Catch ex As Exception
            Throw (New Exception("Error ejecutando búsqueda - " & ex.Message))
        Finally
            connection.Close()
        End Try

    End Function

    'Update de un registro.
    Public Sub updateTask(ByVal intPK As Integer, ByVal strTitle As String, ByVal strProject As String,
        ByVal strType As String, ByVal strPriority As String,
        ByVal strStatus As String, ByVal dpDateEndTask As Date,
        ByVal strDetails As String)
        Try


            command.CommandText = "update t_tasks_s " & _
            "set title = '" & strTitle & "', " & _
            "project = '" & strProject & "', " & _
            "type = '" & strType & "', " & _
            "priority = '" & strPriority & "', " & _
            "status = '" & strStatus & "', " & _
    "DATEENDTASK = '" & Format(dpDateEndTask, "yyyy-MM-dd") & "', " & _
            "details = '" & strDetails & "', " & _
            " datemodified = '" & Date.Now.ToString("yyyy-MM-dd") & "' " & _
            "where pk = " & intPK

            Me.command.ExecuteNonQuery()

        Catch ex As Exception
            Throw (New Exception("Error actualizando en base de datos - " & ex.Message))
        Finally
            Me.connection.Close()
        End Try

    End Sub

    'Delete de un registro de la BD
    Public Sub deleteTask(ByVal intPK As Integer)
        Try


            command.CommandText = "delete from t_tasks_s " & _            
            "where pk = " & intPK

            Me.command.ExecuteNonQuery()

        Catch ex As Exception
            Throw (New Exception("Error eliminando tarea - " & ex.Message))
        Finally
            Me.connection.Close()
        End Try

    End Sub

    'Obtención de los proyectos en BD
    Public Function getProjects() As DataTable

        Dim strSelect As String

        strSelect = "select project from t_tasks_s group by project" & _
            " order by project asc"

            
        'Añadiendo consulta al command.
        Me.command.CommandText = strSelect

        'Rellenando dataAdapter con consulta
        Dim dsSearch As DataTable
        Dim dataAdapter As SQLiteDataAdapter

        Try
            dsSearch = New DataTable
            dataAdapter = New SQLiteDataAdapter(Me.command)
            dataAdapter.Fill(dsSearch)

            Return dsSearch
        Catch ex As Exception
            Throw (New Exception("Error ejecutando búsqueda de proyectos - " & ex.Message))
        Finally
            connection.Close()
        End Try

    End Function

    'Búsqueda por todas las columnas de la tabla
    Public Function searchAll(ByVal strText As String) As DataTable

        Dim strSelect As String

        strSelect = "select pk, project, title, status, priority, type, dateEndTask, details from t_tasks_s " & _
            " where project like '%" & strText & "%'" & _
            " or title like '%" & strText & "%'" & _
            " or details like '%" & strText & "%' " & _
            " order by pk desc"


        'Añadiendo consulta al command.
        Me.command.CommandText = strSelect

        'Rellenando dataAdapter con consulta
        Dim dsSearch As DataTable
        Dim dataAdapter As SQLiteDataAdapter

        Try
            dsSearch = New DataTable
            dataAdapter = New SQLiteDataAdapter(Me.command)
            dataAdapter.Fill(dsSearch)

            Return dsSearch
        Catch ex As Exception
            Throw (New Exception("Error ejecutando búsqueda en todos los campos - " & ex.Message))
        Finally
            connection.Close()
        End Try

    End Function
End Class
