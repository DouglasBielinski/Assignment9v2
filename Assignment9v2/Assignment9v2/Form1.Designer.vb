<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.flagOne = New System.Windows.Forms.PictureBox()
        Me.flagTwo = New System.Windows.Forms.PictureBox()
        Me.flagThree = New System.Windows.Forms.PictureBox()
        Me.flagFour = New System.Windows.Forms.PictureBox()
        Me.flagFive = New System.Windows.Forms.PictureBox()
        Me.pMonument = New System.Windows.Forms.PictureBox()
        Me.lGreeting = New System.Windows.Forms.Label()
        Me.bExit = New System.Windows.Forms.Button()
        CType(Me.flagOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flagTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flagThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flagFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flagFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pMonument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'flagOne
        '
        Me.flagOne.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.flagOne.Location = New System.Drawing.Point(50, 12)
        Me.flagOne.Name = "flagOne"
        Me.flagOne.Size = New System.Drawing.Size(100, 60)
        Me.flagOne.TabIndex = 6
        Me.flagOne.TabStop = False
        '
        'flagTwo
        '
        Me.flagTwo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.flagTwo.Location = New System.Drawing.Point(50, 107)
        Me.flagTwo.Name = "flagTwo"
        Me.flagTwo.Size = New System.Drawing.Size(100, 60)
        Me.flagTwo.TabIndex = 7
        Me.flagTwo.TabStop = False
        '
        'flagThree
        '
        Me.flagThree.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.flagThree.Location = New System.Drawing.Point(50, 201)
        Me.flagThree.Name = "flagThree"
        Me.flagThree.Size = New System.Drawing.Size(100, 60)
        Me.flagThree.TabIndex = 8
        Me.flagThree.TabStop = False
        '
        'flagFour
        '
        Me.flagFour.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.flagFour.Location = New System.Drawing.Point(50, 290)
        Me.flagFour.Name = "flagFour"
        Me.flagFour.Size = New System.Drawing.Size(100, 60)
        Me.flagFour.TabIndex = 9
        Me.flagFour.TabStop = False
        '
        'flagFive
        '
        Me.flagFive.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.flagFive.Location = New System.Drawing.Point(50, 381)
        Me.flagFive.Name = "flagFive"
        Me.flagFive.Size = New System.Drawing.Size(100, 60)
        Me.flagFive.TabIndex = 10
        Me.flagFive.TabStop = False
        '
        'pMonument
        '
        Me.pMonument.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pMonument.Image = Global.Assignment9v2.My.Resources.Resources.default_image
        Me.pMonument.Location = New System.Drawing.Point(246, 82)
        Me.pMonument.Name = "pMonument"
        Me.pMonument.Size = New System.Drawing.Size(300, 300)
        Me.pMonument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pMonument.TabIndex = 11
        Me.pMonument.TabStop = False
        '
        'lGreeting
        '
        Me.lGreeting.AutoSize = True
        Me.lGreeting.Location = New System.Drawing.Point(279, 43)
        Me.lGreeting.Name = "lGreeting"
        Me.lGreeting.Size = New System.Drawing.Size(84, 13)
        Me.lGreeting.TabIndex = 12
        Me.lGreeting.Text = "Default Greeting"
        '
        'bExit
        '
        Me.bExit.Location = New System.Drawing.Point(412, 413)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(75, 23)
        Me.bExit.TabIndex = 13
        Me.bExit.Text = "Default Exit"
        Me.bExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 453)
        Me.Controls.Add(Me.bExit)
        Me.Controls.Add(Me.lGreeting)
        Me.Controls.Add(Me.pMonument)
        Me.Controls.Add(Me.flagFive)
        Me.Controls.Add(Me.flagFour)
        Me.Controls.Add(Me.flagThree)
        Me.Controls.Add(Me.flagTwo)
        Me.Controls.Add(Me.flagOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.flagOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flagTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flagThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flagFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flagFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pMonument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents flagOne As System.Windows.Forms.PictureBox
    Friend WithEvents flagTwo As System.Windows.Forms.PictureBox
    Friend WithEvents flagThree As System.Windows.Forms.PictureBox
    Friend WithEvents flagFour As System.Windows.Forms.PictureBox
    Friend WithEvents flagFive As System.Windows.Forms.PictureBox
    Friend WithEvents pMonument As System.Windows.Forms.PictureBox
    Friend WithEvents lGreeting As System.Windows.Forms.Label
    Friend WithEvents bExit As System.Windows.Forms.Button

End Class
