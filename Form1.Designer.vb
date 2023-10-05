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
        Button1 = New Button()
        lblName = New Label()
        lblExtract = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Location = New Point(187, 136)
        Button1.Name = "Button1"
        Button1.Size = New Size(350, 34)
        Button1.TabIndex = 0
        Button1.Text = "Mid Function"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(211, 226)
        lblName.Name = "lblName"
        lblName.Size = New Size(146, 25)
        lblName.TabIndex = 1
        lblName.Text = "Insert your name"
        ' 
        ' lblExtract
        ' 
        lblExtract.AutoSize = True
        lblExtract.Location = New Point(216, 269)
        lblExtract.Name = "lblExtract"
        lblExtract.Size = New Size(148, 25)
        lblExtract.TabIndex = 2
        lblExtract.Text = "Extract the name "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(lblExtract)
        Controls.Add(lblName)
        Controls.Add(Button1)
        ForeColor = Color.Maroon
        Name = "Form1"
        Text = "String Manipulation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblExtract As Label
End Class
