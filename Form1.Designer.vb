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
        btnParameter = New Button()
        btnArea = New Button()
        lblLength = New Label()
        lblHeight = New Label()
        txtLength = New TextBox()
        txtHeight = New TextBox()
        txtArea = New TextBox()
        txtParameter = New TextBox()
        SuspendLayout()
        ' 
        ' btnParameter
        ' 
        btnParameter.Location = New Point(246, 212)
        btnParameter.Name = "btnParameter"
        btnParameter.Size = New Size(110, 29)
        btnParameter.TabIndex = 0
        btnParameter.Text = "Parameter is"
        btnParameter.UseVisualStyleBackColor = True
        ' 
        ' btnArea
        ' 
        btnArea.Location = New Point(246, 154)
        btnArea.Name = "btnArea"
        btnArea.Size = New Size(110, 29)
        btnArea.TabIndex = 1
        btnArea.Text = "Area is"
        btnArea.UseVisualStyleBackColor = True
        ' 
        ' lblLength
        ' 
        lblLength.AutoSize = True
        lblLength.Location = New Point(246, 38)
        lblLength.Name = "lblLength"
        lblLength.Size = New Size(92, 20)
        lblLength.TabIndex = 2
        lblLength.Text = "Enter Length"
        ' 
        ' lblHeight
        ' 
        lblHeight.AutoSize = True
        lblHeight.Location = New Point(246, 107)
        lblHeight.Name = "lblHeight"
        lblHeight.Size = New Size(92, 20)
        lblHeight.TabIndex = 3
        lblHeight.Text = "Enter Height"
        ' 
        ' txtLength
        ' 
        txtLength.Location = New Point(403, 38)
        txtLength.Name = "txtLength"
        txtLength.Size = New Size(125, 27)
        txtLength.TabIndex = 4
        ' 
        ' txtHeight
        ' 
        txtHeight.Location = New Point(403, 100)
        txtHeight.Name = "txtHeight"
        txtHeight.Size = New Size(125, 27)
        txtHeight.TabIndex = 5
        ' 
        ' txtArea
        ' 
        txtArea.Location = New Point(403, 156)
        txtArea.Name = "txtArea"
        txtArea.Size = New Size(125, 27)
        txtArea.TabIndex = 6
        ' 
        ' txtParameter
        ' 
        txtParameter.Location = New Point(403, 214)
        txtParameter.Name = "txtParameter"
        txtParameter.Size = New Size(125, 27)
        txtParameter.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtParameter)
        Controls.Add(txtArea)
        Controls.Add(txtHeight)
        Controls.Add(txtLength)
        Controls.Add(lblHeight)
        Controls.Add(lblLength)
        Controls.Add(btnArea)
        Controls.Add(btnParameter)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnParameter As Button
    Friend WithEvents btnArea As Button
    Friend WithEvents lblLength As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtArea As TextBox
    Friend WithEvents txtParameter As TextBox

End Class
