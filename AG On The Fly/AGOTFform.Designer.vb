<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGOTFform
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
        Me.SetButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ExposureBox = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AggressivenessBox = New System.Windows.Forms.NumericUpDown()
        Me.MinMoveBox = New System.Windows.Forms.NumericUpDown()
        Me.MaxMoveBox = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BacklashYBox = New System.Windows.Forms.NumericUpDown()
        Me.BacklashXBox = New System.Windows.Forms.NumericUpDown()
        CType(Me.ExposureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AggressivenessBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinMoveBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxMoveBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BacklashYBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BacklashXBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SetButton
        '
        Me.SetButton.Location = New System.Drawing.Point(15, 227)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(75, 23)
        Me.SetButton.TabIndex = 0
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(166, 227)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ExposureBox
        '
        Me.ExposureBox.DecimalPlaces = 1
        Me.ExposureBox.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.ExposureBox.Location = New System.Drawing.Point(181, 17)
        Me.ExposureBox.Name = "ExposureBox"
        Me.ExposureBox.Size = New System.Drawing.Size(60, 20)
        Me.ExposureBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aggressiveness"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Minimum Move (sec)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Maximum Move (sec)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Exposure (sec)"
        '
        'AggressivenessBox
        '
        Me.AggressivenessBox.Location = New System.Drawing.Point(181, 49)
        Me.AggressivenessBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.AggressivenessBox.Name = "AggressivenessBox"
        Me.AggressivenessBox.Size = New System.Drawing.Size(60, 20)
        Me.AggressivenessBox.TabIndex = 8
        '
        'MinMoveBox
        '
        Me.MinMoveBox.DecimalPlaces = 2
        Me.MinMoveBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.MinMoveBox.Location = New System.Drawing.Point(181, 81)
        Me.MinMoveBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MinMoveBox.Name = "MinMoveBox"
        Me.MinMoveBox.Size = New System.Drawing.Size(60, 20)
        Me.MinMoveBox.TabIndex = 9
        '
        'MaxMoveBox
        '
        Me.MaxMoveBox.DecimalPlaces = 2
        Me.MaxMoveBox.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.MaxMoveBox.Location = New System.Drawing.Point(181, 113)
        Me.MaxMoveBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.MaxMoveBox.Name = "MaxMoveBox"
        Me.MaxMoveBox.Size = New System.Drawing.Size(60, 20)
        Me.MaxMoveBox.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Backlash Y  (sec)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Baxklash X  (sec)"
        '
        'BacklashYBox
        '
        Me.BacklashYBox.DecimalPlaces = 1
        Me.BacklashYBox.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.BacklashYBox.Location = New System.Drawing.Point(181, 177)
        Me.BacklashYBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.BacklashYBox.Name = "BacklashYBox"
        Me.BacklashYBox.Size = New System.Drawing.Size(60, 20)
        Me.BacklashYBox.TabIndex = 13
        '
        'BacklashXBox
        '
        Me.BacklashXBox.DecimalPlaces = 1
        Me.BacklashXBox.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.BacklashXBox.Location = New System.Drawing.Point(181, 145)
        Me.BacklashXBox.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.BacklashXBox.Name = "BacklashXBox"
        Me.BacklashXBox.Size = New System.Drawing.Size(60, 20)
        Me.BacklashXBox.TabIndex = 14
        '
        'AGOTFform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 273)
        Me.Controls.Add(Me.BacklashXBox)
        Me.Controls.Add(Me.BacklashYBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaxMoveBox)
        Me.Controls.Add(Me.MinMoveBox)
        Me.Controls.Add(Me.AggressivenessBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExposureBox)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.SetButton)
        Me.Name = "AGOTFform"
        Me.Text = "AutoGuide On-The-Fly"
        CType(Me.ExposureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AggressivenessBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinMoveBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxMoveBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BacklashYBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BacklashXBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SetButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents ExposureBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AggressivenessBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents MinMoveBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents MaxMoveBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BacklashYBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents BacklashXBox As System.Windows.Forms.NumericUpDown

End Class
