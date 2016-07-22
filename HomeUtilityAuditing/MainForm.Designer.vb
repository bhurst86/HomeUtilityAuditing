<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.cmbAppliance = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKwattPerHour = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmountKwatts = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRunTime = New System.Windows.Forms.TextBox()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.ListBox5 = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Home Utility Auditing Program"
        '
        'cmbAppliance
        '
        Me.cmbAppliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAppliance.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmbAppliance.Items.AddRange(New Object() {"Refrigerator", "TV", "Space Heater", "Fan", "Dryer", "Oven", "Laundry Washer", "Cloth Washer"})
        Me.cmbAppliance.Location = New System.Drawing.Point(203, 95)
        Me.cmbAppliance.Name = "cmbAppliance"
        Me.cmbAppliance.Size = New System.Drawing.Size(121, 21)
        Me.cmbAppliance.TabIndex = 4
        Me.cmbAppliance.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select an appliance: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cost per Kilowatt per hour: "
        '
        'txtKwattPerHour
        '
        Me.txtKwattPerHour.Location = New System.Drawing.Point(203, 59)
        Me.txtKwattPerHour.MaxLength = 3
        Me.txtKwattPerHour.Name = "txtKwattPerHour"
        Me.txtKwattPerHour.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtKwattPerHour.Size = New System.Drawing.Size(121, 20)
        Me.txtKwattPerHour.TabIndex = 7
        Me.txtKwattPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Amount of kWatts to run appliance: "
        '
        'txtAmountKwatts
        '
        Me.txtAmountKwatts.Location = New System.Drawing.Point(203, 133)
        Me.txtAmountKwatts.MaxLength = 4
        Me.txtAmountKwatts.Name = "txtAmountKwatts"
        Me.txtAmountKwatts.Size = New System.Drawing.Size(121, 20)
        Me.txtAmountKwatts.TabIndex = 9
        Me.txtAmountKwatts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Appliance Run Time per Day: "
        '
        'txtRunTime
        '
        Me.txtRunTime.Location = New System.Drawing.Point(203, 168)
        Me.txtRunTime.MaxLength = 2
        Me.txtRunTime.Name = "txtRunTime"
        Me.txtRunTime.Size = New System.Drawing.Size(121, 20)
        Me.txtRunTime.TabIndex = 11
        Me.txtRunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(47, 235)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(75, 23)
        Me.btnAddItem.TabIndex = 13
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(346, 59)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(87, 134)
        Me.ListBox1.TabIndex = 14
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(346, 235)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(245, 23)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "$0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Cost to run devices:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 283)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(625, 22)
        Me.StatusStrip1.TabIndex = 17
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(398, 17)
        Me.lblStatus.Text = "Getting Started: Select Cost Per Kilowatt Per Hour Box  and Enter a number"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(431, 59)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(42, 134)
        Me.ListBox2.TabIndex = 18
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(471, 59)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(40, 134)
        Me.ListBox3.TabIndex = 19
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(508, 59)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(37, 134)
        Me.ListBox4.TabIndex = 20
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.Location = New System.Drawing.Point(541, 59)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(50, 134)
        Me.ListBox5.TabIndex = 21
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(141, 235)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(234, 235)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 305)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.ListBox5)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.txtRunTime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAmountKwatts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtKwattPerHour)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbAppliance)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.Text = "Home Utility Auditing Program"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbAppliance As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKwattPerHour As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmountKwatts As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRunTime As TextBox
    Friend WithEvents btnAddItem As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox5 As ListBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
