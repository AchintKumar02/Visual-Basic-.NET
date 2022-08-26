<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnGO = New System.Windows.Forms.Button()
        Me.VariableBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnGO
        '
        Me.BtnGO.Location = New System.Drawing.Point(195, 50)
        Me.BtnGO.Name = "BtnGO"
        Me.BtnGO.Size = New System.Drawing.Size(137, 90)
        Me.BtnGO.TabIndex = 0
        Me.BtnGO.Text = "Go"
        Me.BtnGO.UseVisualStyleBackColor = True
        '
        'VariableBtn
        '
        Me.VariableBtn.Location = New System.Drawing.Point(442, 50)
        Me.VariableBtn.Name = "VariableBtn"
        Me.VariableBtn.Size = New System.Drawing.Size(116, 90)
        Me.VariableBtn.TabIndex = 1
        Me.VariableBtn.Text = "Variable"
        Me.VariableBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VariableBtn)
        Me.Controls.Add(Me.BtnGO)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnGO As Button
    Friend WithEvents VariableBtn As Button
End Class
