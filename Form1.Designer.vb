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
        luck = New Button()
        txtMyNumber = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' luck
        ' 
        luck.Location = New Point(273, 237)
        luck.Name = "luck"
        luck.Size = New Size(94, 29)
        luck.TabIndex = 0
        luck.Text = "Lucky Prize"
        luck.UseVisualStyleBackColor = True
        ' 
        ' txtMyNumber
        ' 
        txtMyNumber.Location = New Point(232, 123)
        txtMyNumber.Name = "txtMyNumber"
        txtMyNumber.Size = New Size(196, 27)
        txtMyNumber.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(94, 130)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 2
        Label1.Text = "My Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(254, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 20)
        Label2.TabIndex = 3
        Label2.Text = "Outcome Message"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMyNumber)
        Controls.Add(luck)
        Name = "Form1"
        Text = "Using If…Then Statement"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents luck As Button
    Friend WithEvents txtMyNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
