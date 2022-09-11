<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdMale = New System.Windows.Forms.RadioButton()
        Me.rdFemale = New System.Windows.Forms.RadioButton()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvClient = New System.Windows.Forms.DataGridView()
        Me.gbAdd = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnRoomList = New System.Windows.Forms.Button()
        Me.flpAdminControl = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.flpEmpList = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnLout = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUserLog = New System.Windows.Forms.Button()
        Me.btnTransLog = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAdd.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.flpAdminControl.SuspendLayout()
        Me.flpEmpList.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(17, 44)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(340, 20)
        Me.txtCustomerName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(25, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Gender:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rdMale
        '
        Me.rdMale.AutoSize = True
        Me.rdMale.Location = New System.Drawing.Point(28, 108)
        Me.rdMale.Name = "rdMale"
        Me.rdMale.Size = New System.Drawing.Size(48, 17)
        Me.rdMale.TabIndex = 5
        Me.rdMale.TabStop = True
        Me.rdMale.Text = "Male"
        Me.rdMale.UseVisualStyleBackColor = True
        '
        'rdFemale
        '
        Me.rdFemale.AutoSize = True
        Me.rdFemale.Location = New System.Drawing.Point(82, 108)
        Me.rdFemale.Name = "rdFemale"
        Me.rdFemale.Size = New System.Drawing.Size(59, 17)
        Me.rdFemale.TabIndex = 6
        Me.rdFemale.TabStop = True
        Me.rdFemale.Text = "Female"
        Me.rdFemale.UseVisualStyleBackColor = True
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(165, 108)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(72, 20)
        Me.txtAge.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(163, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Age:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthdate.Location = New System.Drawing.Point(278, 108)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(115, 20)
        Me.dtpBirthdate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(279, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Birthdate:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(430, 83)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(336, 20)
        Me.txtLocation.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(431, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 22)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Location:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvClient
        '
        Me.dgvClient.AllowUserToAddRows = False
        Me.dgvClient.AllowUserToDeleteRows = False
        Me.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClient.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvClient.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvClient.Location = New System.Drawing.Point(211, 292)
        Me.dgvClient.MultiSelect = False
        Me.dgvClient.Name = "dgvClient"
        Me.dgvClient.RowHeadersVisible = False
        Me.dgvClient.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvClient.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClient.Size = New System.Drawing.Size(875, 252)
        Me.dgvClient.TabIndex = 13
        '
        'gbAdd
        '
        Me.gbAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbAdd.Controls.Add(Me.Label2)
        Me.gbAdd.Controls.Add(Me.txtCustomerName)
        Me.gbAdd.Controls.Add(Me.Label3)
        Me.gbAdd.Controls.Add(Me.txtLocation)
        Me.gbAdd.Controls.Add(Me.rdMale)
        Me.gbAdd.Controls.Add(Me.Label6)
        Me.gbAdd.Controls.Add(Me.rdFemale)
        Me.gbAdd.Controls.Add(Me.Label5)
        Me.gbAdd.Controls.Add(Me.Label4)
        Me.gbAdd.Controls.Add(Me.dtpBirthdate)
        Me.gbAdd.Controls.Add(Me.txtAge)
        Me.gbAdd.Location = New System.Drawing.Point(270, 84)
        Me.gbAdd.Name = "gbAdd"
        Me.gbAdd.Size = New System.Drawing.Size(787, 151)
        Me.gbAdd.TabIndex = 17
        Me.gbAdd.TabStop = False
        '
        'btnAdd
        '
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 27)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Tag = ""
        Me.btnAdd.Text = "&Add New"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Location = New System.Drawing.Point(79, 3)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 27)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Tag = ""
        Me.btnSave.Text = "&Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDel.Location = New System.Drawing.Point(155, 3)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(70, 27)
        Me.btnDel.TabIndex = 20
        Me.btnDel.Tag = ""
        Me.btnDel.Text = "&Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(3, 3)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(493, 29)
        Me.txtSearch.TabIndex = 13
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSearch)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSearch)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(439, 38)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(618, 40)
        Me.FlowLayoutPanel1.TabIndex = 21
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(502, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(103, 29)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Tag = ""
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(231, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(70, 27)
        Me.Button4.TabIndex = 22
        Me.Button4.Tag = ""
        Me.Button4.Text = "Re&fresh"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnRoomList
        '
        Me.btnRoomList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomList.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnRoomList.ForeColor = System.Drawing.Color.White
        Me.btnRoomList.Location = New System.Drawing.Point(34, 151)
        Me.btnRoomList.Name = "btnRoomList"
        Me.btnRoomList.Size = New System.Drawing.Size(128, 34)
        Me.btnRoomList.TabIndex = 23
        Me.btnRoomList.Tag = ""
        Me.btnRoomList.Text = "Room &List"
        Me.btnRoomList.UseVisualStyleBackColor = True
        '
        'flpAdminControl
        '
        Me.flpAdminControl.Controls.Add(Me.btnAdd)
        Me.flpAdminControl.Controls.Add(Me.btnSave)
        Me.flpAdminControl.Controls.Add(Me.btnDel)
        Me.flpAdminControl.Controls.Add(Me.Button4)
        Me.flpAdminControl.Location = New System.Drawing.Point(748, 252)
        Me.flpAdminControl.Name = "flpAdminControl"
        Me.flpAdminControl.Size = New System.Drawing.Size(309, 34)
        Me.flpAdminControl.TabIndex = 24
        Me.flpAdminControl.Visible = False
        '
        'btnEmployee
        '
        Me.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmployee.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnEmployee.ForeColor = System.Drawing.Color.White
        Me.btnEmployee.Location = New System.Drawing.Point(3, 13)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(128, 34)
        Me.btnEmployee.TabIndex = 25
        Me.btnEmployee.Tag = ""
        Me.btnEmployee.Text = "Emplo&yee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'flpEmpList
        '
        Me.flpEmpList.Controls.Add(Me.btnEmployee)
        Me.flpEmpList.Controls.Add(Me.btnTransLog)
        Me.flpEmpList.Controls.Add(Me.btnUserLog)
        Me.flpEmpList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpEmpList.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.flpEmpList.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.flpEmpList.Location = New System.Drawing.Point(31, 193)
        Me.flpEmpList.Name = "flpEmpList"
        Me.flpEmpList.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.flpEmpList.Size = New System.Drawing.Size(138, 141)
        Me.flpEmpList.TabIndex = 26
        Me.flpEmpList.Visible = False
        '
        'btnLout
        '
        Me.btnLout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLout.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnLout.ForeColor = System.Drawing.Color.White
        Me.btnLout.Location = New System.Drawing.Point(31, 498)
        Me.btnLout.Name = "btnLout"
        Me.btnLout.Size = New System.Drawing.Size(128, 34)
        Me.btnLout.TabIndex = 27
        Me.btnLout.Tag = ""
        Me.btnLout.Text = "Log&out"
        Me.btnLout.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnRoomList)
        Me.Panel1.Controls.Add(Me.btnLout)
        Me.Panel1.Controls.Add(Me.flpEmpList)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 559)
        Me.Panel1.TabIndex = 28
        '
        'btnUserLog
        '
        Me.btnUserLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserLog.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnUserLog.ForeColor = System.Drawing.Color.White
        Me.btnUserLog.Location = New System.Drawing.Point(3, 93)
        Me.btnUserLog.Name = "btnUserLog"
        Me.btnUserLog.Size = New System.Drawing.Size(128, 34)
        Me.btnUserLog.TabIndex = 30
        Me.btnUserLog.Tag = ""
        Me.btnUserLog.Text = "User Log"
        Me.btnUserLog.UseVisualStyleBackColor = True
        '
        'btnTransLog
        '
        Me.btnTransLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransLog.Font = New System.Drawing.Font("Calibri", 11.25!)
        Me.btnTransLog.ForeColor = System.Drawing.Color.White
        Me.btnTransLog.Location = New System.Drawing.Point(3, 53)
        Me.btnTransLog.Name = "btnTransLog"
        Me.btnTransLog.Size = New System.Drawing.Size(128, 34)
        Me.btnTransLog.TabIndex = 29
        Me.btnTransLog.Tag = ""
        Me.btnTransLog.Text = "Transaction Log"
        Me.btnTransLog.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(53, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(90, 85)
        Me.Panel2.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(211, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(49, 46)
        Me.Panel3.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(266, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Client Information:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(1082, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 21)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "X"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1101, 556)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.flpAdminControl)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.gbAdd)
        Me.Controls.Add(Me.dgvClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.dgvClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAdd.ResumeLayout(False)
        Me.gbAdd.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.flpAdminControl.ResumeLayout(False)
        Me.flpEmpList.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdMale As System.Windows.Forms.RadioButton
    Friend WithEvents rdFemale As System.Windows.Forms.RadioButton
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpBirthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvClient As System.Windows.Forms.DataGridView
    Friend WithEvents gbAdd As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents btnRoomList As System.Windows.Forms.Button
    Friend WithEvents flpAdminControl As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents flpEmpList As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnLout As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnTransLog As System.Windows.Forms.Button
    Friend WithEvents btnUserLog As System.Windows.Forms.Button

End Class
