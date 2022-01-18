<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.clbComponent = New System.Windows.Forms.CheckedListBox()
        Me.cmbRam = New System.Windows.Forms.ComboBox()
        Me.cmbMonitor = New System.Windows.Forms.ComboBox()
        Me.cmbMouse = New System.Windows.Forms.ComboBox()
        Me.cmbKeyboard = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'clbComponent
        '
        Me.clbComponent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbComponent.FormattingEnabled = True
        Me.clbComponent.Items.AddRange(New Object() {"RAM", "Mouse", "Monitor", "Keyboard", "CPU Case", "Moutherboard", "Graphic Card", "Power Supply"})
        Me.clbComponent.Location = New System.Drawing.Point(53, 99)
        Me.clbComponent.Margin = New System.Windows.Forms.Padding(3, 3, 6, 3)
        Me.clbComponent.Name = "clbComponent"
        Me.clbComponent.Size = New System.Drawing.Size(137, 172)
        Me.clbComponent.TabIndex = 0
        '
        'cmbRam
        '
        Me.cmbRam.FormattingEnabled = True
        Me.cmbRam.Items.AddRange(New Object() {"10", "20", "30", "40", "50"})
        Me.cmbRam.Location = New System.Drawing.Point(253, 140)
        Me.cmbRam.Name = "cmbRam"
        Me.cmbRam.Size = New System.Drawing.Size(121, 21)
        Me.cmbRam.TabIndex = 1
        '
        'cmbMonitor
        '
        Me.cmbMonitor.FormattingEnabled = True
        Me.cmbMonitor.Items.AddRange(New Object() {"10", "20", "30", "40", "50"})
        Me.cmbMonitor.Location = New System.Drawing.Point(253, 225)
        Me.cmbMonitor.Name = "cmbMonitor"
        Me.cmbMonitor.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonitor.TabIndex = 2
        '
        'cmbMouse
        '
        Me.cmbMouse.FormattingEnabled = True
        Me.cmbMouse.Items.AddRange(New Object() {"10", "20", "30", "40", "50"})
        Me.cmbMouse.Location = New System.Drawing.Point(451, 140)
        Me.cmbMouse.Name = "cmbMouse"
        Me.cmbMouse.Size = New System.Drawing.Size(121, 21)
        Me.cmbMouse.TabIndex = 3
        '
        'cmbKeyboard
        '
        Me.cmbKeyboard.FormattingEnabled = True
        Me.cmbKeyboard.Items.AddRange(New Object() {"10", "20", "30", "40", "50"})
        Me.cmbKeyboard.Location = New System.Drawing.Point(451, 225)
        Me.cmbKeyboard.Name = "cmbKeyboard"
        Me.cmbKeyboard.Size = New System.Drawing.Size(121, 21)
        Me.cmbKeyboard.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "RAM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(273, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monitor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(469, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mouse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(469, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Keyboard"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Orange
        Me.ProgressBar1.Location = New System.Drawing.Point(39, 317)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(573, 24)
        Me.ProgressBar1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(395, 33)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Check the list to update the field"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 427)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbKeyboard)
        Me.Controls.Add(Me.cmbMouse)
        Me.Controls.Add(Me.cmbMonitor)
        Me.Controls.Add(Me.cmbRam)
        Me.Controls.Add(Me.clbComponent)
        Me.Name = "form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tugas Ke - 8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clbComponent As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmbRam As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonitor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMouse As System.Windows.Forms.ComboBox
    Friend WithEvents cmbKeyboard As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
