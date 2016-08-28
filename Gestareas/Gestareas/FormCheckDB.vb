Public Class FormCheckDB

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.tbNameDB.Text = "GesTareas.db"
        Me.tbNameDB.ReadOnly = True
        Me.tbPathDB.ReadOnly = True
    End Sub

    Private Sub btBrowser_Click(sender As Object, e As EventArgs) Handles btBrowser.Click
        Dim folderBrowserDialog = New FolderBrowserDialog
        folderBrowserDialog.Description = "Seleccione ubicación para almacenar la base de datos"
        folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer
        folderBrowserDialog.ShowDialog()
        Me.tbPathDB.Text = folderBrowserDialog.SelectedPath
    End Sub

    Private Sub btFinish_Click(sender As Object, e As EventArgs) Handles btFinish.Click

        If Not Me.tbPathDB.Text = "" Then
            My.Settings.pathDB = Me.tbPathDB.Text
            My.Settings.nameDB = Me.tbNameDB.Text
            My.Settings.Save()
            Me.Close()
        Else
            MsgBox("Por favor, indique la ubicación donde desea almacenar la base de datos")
        End If
    End Sub
End Class