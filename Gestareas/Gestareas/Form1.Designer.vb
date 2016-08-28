<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btNewTask = New System.Windows.Forms.Button()
        Me.cbPriority = New System.Windows.Forms.ComboBox()
        Me.lbPriority = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.dgvTaskList = New System.Windows.Forms.DataGridView()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lbSearch = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.lbSearchProject = New System.Windows.Forms.Label()
        Me.cbSearchProject = New System.Windows.Forms.ComboBox()
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btNewTask
        '
        Me.btNewTask.AccessibleDescription = " Abrir formulario para el alta de una nueva tarea"
        Me.btNewTask.AccessibleName = "Nueva tarea"
        Me.btNewTask.Location = New System.Drawing.Point(120, 120)
        Me.btNewTask.Name = "btNewTask"
        Me.btNewTask.Size = New System.Drawing.Size(75, 23)
        Me.btNewTask.TabIndex = 10
        Me.btNewTask.Text = "&Nueva Tarea"
        Me.btNewTask.UseVisualStyleBackColor = True
        '
        'cbPriority
        '
        Me.cbPriority.AccessibleName = " Selector de prioridad"
        Me.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPriority.FormattingEnabled = True
        Me.cbPriority.Items.AddRange(New Object() {"Todas", "Muy Alta", "Alta", "media", "Baja", "Muy baja"})
        Me.cbPriority.Location = New System.Drawing.Point(120, 280)
        Me.cbPriority.Name = "cbPriority"
        Me.cbPriority.Size = New System.Drawing.Size(121, 21)
        Me.cbPriority.TabIndex = 16
        '
        'lbPriority
        '
        Me.lbPriority.AccessibleName = "Prioridad"
        Me.lbPriority.AutoSize = True
        Me.lbPriority.Location = New System.Drawing.Point(210, 120)
        Me.lbPriority.Name = "lbPriority"
        Me.lbPriority.Size = New System.Drawing.Size(48, 13)
        Me.lbPriority.TabIndex = 15
        Me.lbPriority.Text = "Prioridad"
        '
        'lbType
        '
        Me.lbType.AccessibleName = "Tipo"
        Me.lbType.AutoSize = True
        Me.lbType.Location = New System.Drawing.Point(260, 120)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(28, 13)
        Me.lbType.TabIndex = 20
        Me.lbType.Text = "Tipo"
        '
        'cbType
        '
        Me.cbType.AccessibleName = "tipo"
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Tarea", "Nota"})
        Me.cbType.Location = New System.Drawing.Point(300, 120)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(121, 21)
        Me.cbType.TabIndex = 21
        '
        'dgvTaskList
        '
        Me.dgvTaskList.AccessibleName = "Tareas"
        Me.dgvTaskList.AllowUserToAddRows = False
        Me.dgvTaskList.AllowUserToDeleteRows = False
        Me.dgvTaskList.AllowUserToOrderColumns = True
        Me.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTaskList.Location = New System.Drawing.Point(200, 120)
        Me.dgvTaskList.Name = "dgvTaskList"
        Me.dgvTaskList.ReadOnly = True
        Me.dgvTaskList.ShowEditingIcon = False
        Me.dgvTaskList.Size = New System.Drawing.Size(300, 400)
        Me.dgvTaskList.TabIndex = 50
        '
        'lbStatus
        '
        Me.lbStatus.AutoSize = True
        Me.lbStatus.Location = New System.Drawing.Point(120, 320)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(40, 13)
        Me.lbStatus.TabIndex = 25
        Me.lbStatus.Text = "Estado"
        '
        'cbStatus
        '
        Me.cbStatus.AccessibleDescription = ""
        Me.cbStatus.AccessibleName = "Estados"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"Todos", "Activa", "Finalizada", "Cancelada"})
        Me.cbStatus.Location = New System.Drawing.Point(120, 380)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 26
        '
        'lbSearch
        '
        Me.lbSearch.AutoSize = True
        Me.lbSearch.Location = New System.Drawing.Point(121, 140)
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Size = New System.Drawing.Size(43, 13)
        Me.lbSearch.TabIndex = 30
        Me.lbSearch.Text = "Buscar:"
        '
        'tbSearch
        '
        Me.tbSearch.AccessibleName = "Buscar"
        Me.tbSearch.Location = New System.Drawing.Point(140, 160)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(100, 20)
        Me.tbSearch.TabIndex = 32
        '
        'lbSearchProject
        '
        Me.lbSearchProject.AccessibleName = "Búsqueda por proyecto"
        Me.lbSearchProject.AutoSize = True
        Me.lbSearchProject.Location = New System.Drawing.Point(140, 260)
        Me.lbSearchProject.Name = "lbSearchProject"
        Me.lbSearchProject.Size = New System.Drawing.Size(117, 13)
        Me.lbSearchProject.TabIndex = 34
        Me.lbSearchProject.Text = "Búsqueda por proyecto"
        '
        'cbSearchProject
        '
        Me.cbSearchProject.AccessibleName = "Búsqueda por proyecto"
        Me.cbSearchProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchProject.Location = New System.Drawing.Point(140, 310)
        Me.cbSearchProject.Name = "cbSearchProject"
        Me.cbSearchProject.Size = New System.Drawing.Size(100, 21)
        Me.cbSearchProject.TabIndex = 36
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cbSearchProject)
        Me.Controls.Add(Me.lbSearchProject)
        Me.Controls.Add(Me.tbSearch)
        Me.Controls.Add(Me.lbSearch)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.dgvTaskList)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.lbPriority)
        Me.Controls.Add(Me.cbPriority)
        Me.Controls.Add(Me.btNewTask)
        Me.Name = "Form1"
        Me.Text = "GesTareas"
        CType(Me.dgvTaskList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btNewTask As System.Windows.Forms.Button
    Friend WithEvents cbPriority As System.Windows.Forms.ComboBox
    Friend WithEvents lbPriority As System.Windows.Forms.Label
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents dgvTaskList As System.Windows.Forms.DataGridView
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lbSearch As System.Windows.Forms.Label
    Friend WithEvents tbSearch As System.Windows.Forms.TextBox
    Friend WithEvents lbSearchProject As System.Windows.Forms.Label
    Friend WithEvents cbSearchProject As System.Windows.Forms.ComboBox

End Class
