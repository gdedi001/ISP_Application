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
		Me.grpPackages = New System.Windows.Forms.GroupBox()
		Me.txtHours = New System.Windows.Forms.TextBox()
		Me.radPckC = New System.Windows.Forms.RadioButton()
		Me.radPckB = New System.Windows.Forms.RadioButton()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.radPckA = New System.Windows.Forms.RadioButton()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.chkNPrft = New System.Windows.Forms.CheckBox()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblTotal = New System.Windows.Forms.Label()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
		Me.grpPackages.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'grpPackages
		'
		Me.grpPackages.BackColor = System.Drawing.SystemColors.ActiveCaption
		Me.grpPackages.Controls.Add(Me.txtHours)
		Me.grpPackages.Controls.Add(Me.radPckC)
		Me.grpPackages.Controls.Add(Me.radPckB)
		Me.grpPackages.Controls.Add(Me.Label2)
		Me.grpPackages.Controls.Add(Me.radPckA)
		Me.grpPackages.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.grpPackages.Location = New System.Drawing.Point(21, 56)
		Me.grpPackages.Name = "grpPackages"
		Me.grpPackages.Size = New System.Drawing.Size(305, 137)
		Me.grpPackages.TabIndex = 0
		Me.grpPackages.TabStop = False
		Me.grpPackages.Text = "Packages"
		'
		'txtHours
		'
		Me.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtHours.Location = New System.Drawing.Point(168, 51)
		Me.txtHours.Name = "txtHours"
		Me.txtHours.Size = New System.Drawing.Size(80, 23)
		Me.txtHours.TabIndex = 4
		Me.txtHours.Text = "0"
		Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'radPckC
		'
		Me.radPckC.AutoSize = True
		Me.radPckC.Location = New System.Drawing.Point(18, 85)
		Me.radPckC.Name = "radPckC"
		Me.radPckC.Size = New System.Drawing.Size(94, 21)
		Me.radPckC.TabIndex = 2
		Me.radPckC.TabStop = True
		Me.radPckC.Text = "Package C"
		Me.radPckC.UseVisualStyleBackColor = True
		'
		'radPckB
		'
		Me.radPckB.AutoSize = True
		Me.radPckB.Location = New System.Drawing.Point(18, 58)
		Me.radPckB.Name = "radPckB"
		Me.radPckB.Size = New System.Drawing.Size(94, 21)
		Me.radPckB.TabIndex = 1
		Me.radPckB.TabStop = True
		Me.radPckB.Text = "Package B"
		Me.radPckB.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(132, 31)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(158, 17)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Amount of Access Used"
		'
		'radPckA
		'
		Me.radPckA.AutoSize = True
		Me.radPckA.Location = New System.Drawing.Point(18, 31)
		Me.radPckA.Name = "radPckA"
		Me.radPckA.Size = New System.Drawing.Size(94, 21)
		Me.radPckA.TabIndex = 0
		Me.radPckA.TabStop = True
		Me.radPckA.Text = "Package A"
		Me.radPckA.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(230, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(182, 22)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "ISP Pricing Packages"
		'
		'chkNPrft
		'
		Me.chkNPrft.AutoSize = True
		Me.chkNPrft.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.chkNPrft.Location = New System.Drawing.Point(39, 199)
		Me.chkNPrft.Name = "chkNPrft"
		Me.chkNPrft.Size = New System.Drawing.Size(170, 21)
		Me.chkNPrft.TabIndex = 2
		Me.chkNPrft.Text = "Nonprofit Organization"
		Me.chkNPrft.UseVisualStyleBackColor = True
		'
		'btnCalculate
		'
		Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCalculate.Location = New System.Drawing.Point(58, 85)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(100, 31)
		Me.btnCalculate.TabIndex = 3
		Me.btnCalculate.Text = "Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(55, 11)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(107, 17)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Monthly Charge"
		'
		'lblTotal
		'
		Me.lblTotal.BackColor = System.Drawing.SystemColors.ScrollBar
		Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotal.Location = New System.Drawing.Point(58, 38)
		Me.lblTotal.Name = "lblTotal"
		Me.lblTotal.Size = New System.Drawing.Size(100, 23)
		Me.lblTotal.TabIndex = 5
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.Info
		Me.Panel1.Controls.Add(Me.btnCalculate)
		Me.Panel1.Controls.Add(Me.lblTotal)
		Me.Panel1.Controls.Add(Me.Label3)
		Me.Panel1.Location = New System.Drawing.Point(364, 56)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(220, 137)
		Me.Panel1.TabIndex = 6
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 249)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(639, 22)
		Me.StatusStrip1.TabIndex = 7
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'lblStatus
		'
		Me.lblStatus.Name = "lblStatus"
		Me.lblStatus.Size = New System.Drawing.Size(0, 17)
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(639, 271)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.chkNPrft)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.grpPackages)
		Me.Name = "Form1"
		Me.Text = "ISP Packages"
		Me.grpPackages.ResumeLayout(False)
		Me.grpPackages.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents grpPackages As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radPckA As System.Windows.Forms.RadioButton
    Friend WithEvents radPckC As System.Windows.Forms.RadioButton
    Friend WithEvents radPckB As System.Windows.Forms.RadioButton
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkNPrft As System.Windows.Forms.CheckBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
