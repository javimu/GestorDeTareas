<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewTask
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
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lbPriority = New System.Windows.Forms.Label()
        Me.lbDateEndTask = New System.Windows.Forms.Label()
        Me.lbTaskDetails = New System.Windows.Forms.Label()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.tbTaskDetails = New System.Windows.Forms.TextBox()
        Me.cbPriority = New System.Windows.Forms.ComboBox()
        Me.dpDateEndTask = New System.Windows.Forms.DateTimePicker()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.lbStatus = New System.Windows.Forms.Label()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.lbProjectName = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.cbProject = New System.Windows.Forms.ComboBox()
        Me.cbType = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = true
        Me.lbTitle.Location = New System.Drawing.Point(120, 120)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(91, 13)
        Me.lbTitle.TabIndex = 10
        Me.lbTitle.Text = "Título de la tarea:"
        '
        'lbPriority
        '
        Me.lbPriority.AutoSize = true
        Me.lbPriority.Location = New System.Drawing.Point(120, 180)
        Me.lbPriority.Name = "lbPriority"
        Me.lbPriority.Size = New System.Drawing.Size(54, 13)
        Me.lbPriority.TabIndex = 25
        Me.lbPriority.Text = " Prioridad:"
        '
        'lbDateEndTask
        '
        Me.lbDateEndTask.AutoSize = true
        Me.lbDateEndTask.Location = New System.Drawing.Point(120, 220)
        Me.lbDateEndTask.Name = "lbDateEndTask"
        Me.lbDateEndTask.Size = New System.Drawing.Size(81, 13)
        Me.lbDateEndTask.TabIndex = 35
        Me.lbDateEndTask.Text = " Fecha fin tarea"
        '
        'lbTaskDetails
        '
        Me.lbTaskDetails.AutoSize = true
        Me.lbTaskDetails.Location = New System.Drawing.Point(120, 240)
        Me.lbTaskDetails.Name = "lbTaskDetails"
        Me.lbTaskDetails.Size = New System.Drawing.Size(70, 13)
        Me.lbTaskDetails.TabIndex = 40
        Me.lbTaskDetails.Text = " Detalle tarea"
        '
        'tbTitle
        '
        Me.tbTitle.AccessibleName = " Título de la tarea"
        Me.tbTitle.Location = New System.Drawing.Point(220, 120)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(100, 20)
        Me.tbTitle.TabIndex = 11
        '
        'tbTaskDetails
        '
        Me.tbTaskDetails.AcceptsReturn = true
        Me.tbTaskDetails.AccessibleName = " Detalle de la tarea"
        Me.tbTaskDetails.Location = New System.Drawing.Point(220, 240)
        Me.tbTaskDetails.Multiline = true
        Me.tbTaskDetails.Name = "tbTaskDetails"
        Me.tbTaskDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTaskDetails.Size = New System.Drawing.Size(320, 145)
        Me.tbTaskDetails.TabIndex = 41
        '
        'cbPriority
        '
        Me.cbPriority.AccessibleName = " Selector de prioridad"
        Me.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPriority.FormattingEnabled = true
        Me.cbPriority.Items.AddRange(New Object() {"Muy Alta", "Alta", "media", "Baja", "Muy baja"})
        Me.cbPriority.Location = New System.Drawing.Point(220, 180)
        Me.cbPriority.Name = "cbPriority"
        Me.cbPriority.Size = New System.Drawing.Size(121, 21)
        Me.cbPriority.TabIndex = 26
        '
        'dpDateEndTask
        '
        Me.dpDateEndTask.AccessibleName = "Fecha de finalización de la tarea"
        Me.dpDateEndTask.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.dpDateEndTask.CustomFormat = "d/M/yyyy"
        Me.dpDateEndTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDateEndTask.Location = New System.Drawing.Point(220, 220)
        Me.dpDateEndTask.Name = "dpDateEndTask"
        Me.dpDateEndTask.Size = New System.Drawing.Size(200, 20)
        Me.dpDateEndTask.TabIndex = 36
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(140, 440)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 23)
        Me.btSave.TabIndex = 50
        Me.btSave.Text = " Guardar"
        Me.btSave.UseVisualStyleBackColor = true
        '
        'btCancel
        '
        Me.btCancel.Location = New System.Drawing.Point(220, 440)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(75, 23)
        Me.btCancel.TabIndex = 52
        Me.btCancel.Text = "Cancelar"
        Me.btCancel.UseVisualStyleBackColor = true
        '
        'lbStatus
        '
        Me.lbStatus.AccessibleName = "Estado tarea"
        Me.lbStatus.AutoSize = true
        Me.lbStatus.Location = New System.Drawing.Point(120, 200)
        Me.lbStatus.Name = "lbStatus"
        Me.lbStatus.Size = New System.Drawing.Size(40, 13)
        Me.lbStatus.TabIndex = 30
        Me.lbStatus.Text = "Estado"
        '
        'cbStatus
        '
        Me.cbStatus.AccessibleName = "Estado tarea"
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.FormattingEnabled = true
        Me.cbStatus.Items.AddRange(New Object() {"Activa", "Finalizada", "Cancelada"})
        Me.cbStatus.Location = New System.Drawing.Point(220, 200)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(121, 21)
        Me.cbStatus.TabIndex = 31
        Me.cbStatus.Tag = ""
        '
        'lbProjectName
        '
        Me.lbProjectName.AccessibleName = "Titulo del proyecto"
        Me.lbProjectName.AutoSize = true
        Me.lbProjectName.Location = New System.Drawing.Point(120, 140)
        Me.lbProjectName.Name = "lbProjectName"
        Me.lbProjectName.Size = New System.Drawing.Size(89, 13)
        Me.lbProjectName.TabIndex = 15
        Me.lbProjectName.Text = "Nombre Proyecto"
        '
        'lbType
        '
        Me.lbType.AccessibleName = "Tipo de entrada"
        Me.lbType.AutoSize = true
        Me.lbType.Location = New System.Drawing.Point(120, 160)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(28, 13)
        Me.lbType.TabIndex = 20
        Me.lbType.Text = "Tipo"
        '
        'cbProject
        '
        Me.cbProject.AccessibleName = "Nombre del proyecto"
        Me.cbProject.Location = New System.Drawing.Point(220, 140)
        Me.cbProject.Name = "cbProject"
        Me.cbProject.Size = New System.Drawing.Size(100, 21)
        Me.cbProject.TabIndex = 16
        '
        'cbType
        '
        Me.cbType.AccessibleName = "Tipo entrada"
        Me.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbType.Items.AddRange(New Object() {"Tarea", "Nota"})
        Me.cbType.Location = New System.Drawing.Point(220, 160)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(100, 21)
        Me.cbType.TabIndex = 21
        '
        'FormNewTask
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = "Alta de nueva tarea"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.cbProject)
        Me.Controls.Add(Me.lbType)
        Me.Controls.Add(Me.lbProjectName)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.lbStatus)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.dpDateEndTask)
        Me.Controls.Add(Me.cbPriority)
        Me.Controls.Add(Me.tbTaskDetails)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.lbTaskDetails)
        Me.Controls.Add(Me.lbDateEndTask)
        Me.Controls.Add(Me.lbPriority)
        Me.Controls.Add(Me.lbTitle)
        Me.Name = "FormNewTask"
        Me.Text = "Nueva Tarea"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents lbPriority As System.Windows.Forms.Label
    Friend WithEvents lbDateEndTask As System.Windows.Forms.Label
    Friend WithEvents lbTaskDetails As System.Windows.Forms.Label
    Friend WithEvents tbTitle As System.Windows.Forms.TextBox
    Friend WithEvents tbTaskDetails As System.Windows.Forms.TextBox
    Friend WithEvents cbPriority As System.Windows.Forms.ComboBox
    Friend WithEvents dpDateEndTask As System.Windows.Forms.DateTimePicker
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btCancel As System.Windows.Forms.Button
    Friend WithEvents lbStatus As System.Windows.Forms.Label
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents lbProjectName As System.Windows.Forms.Label
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents cbProject As System.Windows.Forms.ComboBox
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
End Class
