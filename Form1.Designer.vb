'Extra comment for the sake of making a project change

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudToRoll = New System.Windows.Forms.NumericUpDown()
        Me.rtbDiceRolls = New System.Windows.Forms.RichTextBox()
        Me.btnRoll = New System.Windows.Forms.Button()
        Me.lblNumRolls = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.nudToRoll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What number?"
        '
        'nudToRoll
        '
        Me.nudToRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudToRoll.Location = New System.Drawing.Point(85, 59)
        Me.nudToRoll.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudToRoll.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudToRoll.Name = "nudToRoll"
        Me.nudToRoll.Size = New System.Drawing.Size(62, 26)
        Me.nudToRoll.TabIndex = 1
        Me.nudToRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudToRoll.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rtbDiceRolls
        '
        Me.rtbDiceRolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDiceRolls.Location = New System.Drawing.Point(16, 58)
        Me.rtbDiceRolls.Name = "rtbDiceRolls"
        Me.rtbDiceRolls.Size = New System.Drawing.Size(60, 219)
        Me.rtbDiceRolls.TabIndex = 2
        Me.rtbDiceRolls.Text = ""
        '
        'btnRoll
        '
        Me.btnRoll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(85, 247)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(62, 30)
        Me.btnRoll.TabIndex = 3
        Me.btnRoll.Text = "Go"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'lblNumRolls
        '
        Me.lblNumRolls.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumRolls.Location = New System.Drawing.Point(12, 280)
        Me.lblNumRolls.Name = "lblNumRolls"
        Me.lblNumRolls.Size = New System.Drawing.Size(148, 23)
        Me.lblNumRolls.TabIndex = 4
        Me.lblNumRolls.Text = "Number of rolls:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Choose from 1 to 6"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(169, 312)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNumRolls)
        Me.Controls.Add(Me.btnRoll)
        Me.Controls.Add(Me.rtbDiceRolls)
        Me.Controls.Add(Me.nudToRoll)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudToRoll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nudToRoll As NumericUpDown
    Friend WithEvents rtbDiceRolls As RichTextBox
    Friend WithEvents btnRoll As Button
    Friend WithEvents lblNumRolls As Label
    Friend WithEvents Label3 As Label
End Class
