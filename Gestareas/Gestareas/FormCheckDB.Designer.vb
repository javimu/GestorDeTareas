<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCheckDB
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
        Me.lbPathDB = New System.Windows.Forms.Label()
        Me.tbPathDB = New System.Windows.Forms.TextBox()
        Me.btBrowser = New System.Windows.Forms.Button()
        Me.lbNameDB = New System.Windows.Forms.Label()
        Me.tbNameDB = New System.Windows.Forms.TextBox()
        Me.btFinish = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbPathDB
        '
        Me.lbPathDB.AutoSize = True
        Me.lbPathDB.Location = New System.Drawing.Point(120, 120)
        Me.lbPathDB.Name = "lbPathDB"
        Me.lbPathDB.Size = New System.Drawing.Size(151, 13)
        Me.lbPathDB.TabIndex = 10
        Me.lbPathDB.Text = "Ubicación de la base de datos"
        '
        'tbPathDB
        '
        Me.tbPathDB.Location = New System.Drawing.Point(300, 120)
        Me.tbPathDB.Name = "tbPathDB"
        Me.tbPathDB.Size = New System.Drawing.Size(100, 20)
        Me.tbPathDB.TabIndex = 12
        '
        'btBrowser
        '
        Me.btBrowser.AccessibleName = "Examinar"
        Me.btBrowser.Location = New System.Drawing.Point(150, 119)
        Me.btBrowser.Name = "btBrowser"
        Me.btBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btBrowser.TabIndex = 14
        Me.btBrowser.UseVisualStyleBackColor = True
        '
        'lbNameDB
        '
        Me.lbNameDB.AutoSize = True
        Me.lbNameDB.Location = New System.Drawing.Point(120, 180)
        Me.lbNameDB.Name = "lbNameDB"
        Me.lbNameDB.Size = New System.Drawing.Size(39, 13)
        Me.lbNameDB.TabIndex = 16
        Me.lbNameDB.Text = "Label1"
        '
        'tbNameDB
        '
        Me.tbNameDB.AccessibleName = "Nombre de la base de datos"
        Me.tbNameDB.Location = New System.Drawing.Point(300, 180)
        Me.tbNameDB.Name = "tbNameDB"
        Me.tbNameDB.Size = New System.Drawing.Size(100, 20)
        Me.tbNameDB.TabIndex = 18
        '
        'btFinish
        '
        Me.btFinish.AccessibleName = "Continuar"
        Me.btFinish.Location = New System.Drawing.Point(300, 220)
        Me.btFinish.Name = "btFinish"
        Me.btFinish.Size = New System.Drawing.Size(75, 23)
        Me.btFinish.TabIndex = 20
        Me.btFinish.Text = "Button1"
        Me.btFinish.UseVisualStyleBackColor = True
        '
        'FormCheckDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btFinish)
        Me.Controls.Add(Me.tbNameDB)
        Me.Controls.Add(Me.lbNameDB)
        Me.Controls.Add(Me.btBrowser)
        Me.Controls.Add(Me.tbPathDB)
        Me.Controls.Add(Me.lbPathDB)
        Me.Name = "FormCheckDB"
        Me.Text = "FormCheckDB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPathDB As System.Windows.Forms.Label
    Friend WithEvents tbPathDB As System.Windows.Forms.TextBox
    Friend WithEvents btBrowser As System.Windows.Forms.Button
    Friend WithEvents lbNameDB As System.Windows.Forms.Label
    Friend WithEvents tbNameDB As System.Windows.Forms.TextBox
    Friend WithEvents btFinish As System.Windows.Forms.Button
End Class
