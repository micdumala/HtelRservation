<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoomList))
        Me.dgvRoomList = New System.Windows.Forms.DataGridView()
        Me.cbClientName = New System.Windows.Forms.ComboBox()
        Me.btnRoomList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbHour = New System.Windows.Forms.RadioButton()
        Me.rbDays = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.btnCheckIn = New System.Windows.Forms.Button()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.flpAdmin = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEditCo = New System.Windows.Forms.Button()
        Me.numDuration = New System.Windows.Forms.NumericUpDown()
        Me.cbRoomType = New System.Windows.Forms.ComboBox()
        Me.cbVacant = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.btnEditRoom = New System.Windows.Forms.Button()
        Me.btnDelRoom = New System.Windows.Forms.Button()
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpAdmin.SuspendLayout()
        CType(Me.numDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRoomList
        '
        Me.dgvRoomList.AllowUserToAddRows = False
        Me.dgvRoomList.AllowUserToDeleteRows = False
        Me.dgvRoomList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRoomList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvRoomList.Location = New System.Drawing.Point(13, 244)
        Me.dgvRoomList.Name = "dgvRoomList"
        Me.dgvRoomList.RowHeadersVisible = False
        Me.dgvRoomList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoomList.Size = New System.Drawing.Size(353, 450)
        Me.dgvRoomList.TabIndex = 0
        '
        'cbClientName
        '
        Me.cbClientName.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientName.FormattingEnabled = True
        Me.cbClientName.Location = New System.Drawing.Point(94, 123)
        Me.cbClientName.Name = "cbClientName"
        Me.cbClientName.Size = New System.Drawing.Size(180, 21)
        Me.cbClientName.TabIndex = 1
        '
        'btnRoomList
        '
        Me.btnRoomList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoomList.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomList.Location = New System.Drawing.Point(13, 84)
        Me.btnRoomList.Name = "btnRoomList"
        Me.btnRoomList.Size = New System.Drawing.Size(107, 26)
        Me.btnRoomList.TabIndex = 24
        Me.btnRoomList.Tag = ""
        Me.btnRoomList.Text = "&Client List"
        Me.btnRoomList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Client Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Type of Stay:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbHour
        '
        Me.rbHour.AutoSize = True
        Me.rbHour.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHour.Location = New System.Drawing.Point(94, 148)
        Me.rbHour.Name = "rbHour"
        Me.rbHour.Size = New System.Drawing.Size(53, 17)
        Me.rbHour.TabIndex = 29
        Me.rbHour.TabStop = True
        Me.rbHour.Text = "Hours"
        Me.rbHour.UseVisualStyleBackColor = True
        '
        'rbDays
        '
        Me.rbDays.AutoSize = True
        Me.rbDays.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDays.Location = New System.Drawing.Point(164, 148)
        Me.rbDays.Name = "rbDays"
        Me.rbDays.Size = New System.Drawing.Size(48, 17)
        Me.rbDays.TabIndex = 30
        Me.rbDays.TabStop = True
        Me.rbDays.Text = "Days"
        Me.rbDays.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Duration"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTransfer
        '
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.Location = New System.Drawing.Point(3, 3)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(73, 28)
        Me.btnTransfer.TabIndex = 34
        Me.btnTransfer.Text = "&Transfer"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'btnCheckIn
        '
        Me.btnCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckIn.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckIn.Location = New System.Drawing.Point(3, 37)
        Me.btnCheckIn.Name = "btnCheckIn"
        Me.btnCheckIn.Size = New System.Drawing.Size(73, 28)
        Me.btnCheckIn.TabIndex = 36
        Me.btnCheckIn.Text = "Check &In"
        Me.btnCheckIn.UseVisualStyleBackColor = True
        '
        'btnCheckOut
        '
        Me.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckOut.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.Location = New System.Drawing.Point(3, 71)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(73, 28)
        Me.btnCheckOut.TabIndex = 37
        Me.btnCheckOut.Text = "Check &Out"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'flpAdmin
        '
        Me.flpAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.flpAdmin.Controls.Add(Me.btnTransfer)
        Me.flpAdmin.Controls.Add(Me.btnCheckIn)
        Me.flpAdmin.Controls.Add(Me.btnCheckOut)
        Me.flpAdmin.Controls.Add(Me.btnEditCo)
        Me.flpAdmin.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpAdmin.Location = New System.Drawing.Point(290, 65)
        Me.flpAdmin.Name = "flpAdmin"
        Me.flpAdmin.Size = New System.Drawing.Size(81, 145)
        Me.flpAdmin.TabIndex = 38
        Me.flpAdmin.Visible = False
        '
        'btnEditCo
        '
        Me.btnEditCo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCo.Location = New System.Drawing.Point(3, 105)
        Me.btnEditCo.Name = "btnEditCo"
        Me.btnEditCo.Size = New System.Drawing.Size(73, 28)
        Me.btnEditCo.TabIndex = 38
        Me.btnEditCo.Text = "&Edit"
        Me.btnEditCo.UseVisualStyleBackColor = True
        '
        'numDuration
        '
        Me.numDuration.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDuration.Location = New System.Drawing.Point(93, 168)
        Me.numDuration.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.numDuration.Name = "numDuration"
        Me.numDuration.Size = New System.Drawing.Size(181, 21)
        Me.numDuration.TabIndex = 39
        Me.numDuration.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'cbRoomType
        '
        Me.cbRoomType.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRoomType.FormattingEnabled = True
        Me.cbRoomType.Items.AddRange(New Object() {"Single", "Twin", "Family"})
        Me.cbRoomType.Location = New System.Drawing.Point(100, 215)
        Me.cbRoomType.Name = "cbRoomType"
        Me.cbRoomType.Size = New System.Drawing.Size(150, 21)
        Me.cbRoomType.TabIndex = 42
        '
        'cbVacant
        '
        Me.cbVacant.AutoSize = True
        Me.cbVacant.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbVacant.Location = New System.Drawing.Point(265, 217)
        Me.cbVacant.Name = "cbVacant"
        Me.cbVacant.Size = New System.Drawing.Size(99, 17)
        Me.cbVacant.TabIndex = 43
        Me.cbVacant.Text = "Available Room"
        Me.cbVacant.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(21, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 21)
        Me.Button2.TabIndex = 44
        Me.Button2.Text = "Filter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(383, -6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(28, 767)
        Me.Panel2.TabIndex = 45
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(361, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "X"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(76, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 26)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Room List:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(13, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(57, 49)
        Me.Panel1.TabIndex = 48
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnAddRoom)
        Me.Panel4.Controls.Add(Me.btnEditRoom)
        Me.Panel4.Controls.Add(Me.btnDelRoom)
        Me.Panel4.Location = New System.Drawing.Point(70, 700)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(241, 40)
        Me.Panel4.TabIndex = 49
        '
        'btnAddRoom
        '
        Me.btnAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRoom.Location = New System.Drawing.Point(10, 7)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(70, 27)
        Me.btnAddRoom.TabIndex = 23
        Me.btnAddRoom.Tag = ""
        Me.btnAddRoom.Text = "Add Room"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'btnEditRoom
        '
        Me.btnEditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditRoom.Location = New System.Drawing.Point(86, 7)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(70, 27)
        Me.btnEditRoom.TabIndex = 24
        Me.btnEditRoom.Tag = ""
        Me.btnEditRoom.Text = "Edit Room"
        Me.btnEditRoom.UseVisualStyleBackColor = True
        '
        'btnDelRoom
        '
        Me.btnDelRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelRoom.Location = New System.Drawing.Point(162, 7)
        Me.btnDelRoom.Name = "btnDelRoom"
        Me.btnDelRoom.Size = New System.Drawing.Size(70, 27)
        Me.btnDelRoom.TabIndex = 25
        Me.btnDelRoom.Tag = ""
        Me.btnDelRoom.Text = "Del Room"
        Me.btnDelRoom.UseVisualStyleBackColor = True
        '
        'frmRoomList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(394, 746)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbVacant)
        Me.Controls.Add(Me.cbRoomType)
        Me.Controls.Add(Me.numDuration)
        Me.Controls.Add(Me.flpAdmin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbDays)
        Me.Controls.Add(Me.rbHour)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRoomList)
        Me.Controls.Add(Me.cbClientName)
        Me.Controls.Add(Me.dgvRoomList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRoomList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomList"
        CType(Me.dgvRoomList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpAdmin.ResumeLayout(False)
        CType(Me.numDuration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRoomList As System.Windows.Forms.DataGridView
    Friend WithEvents cbClientName As System.Windows.Forms.ComboBox
    Friend WithEvents btnRoomList As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbHour As System.Windows.Forms.RadioButton
    Friend WithEvents rbDays As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents btnCheckIn As System.Windows.Forms.Button
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
    Friend WithEvents flpAdmin As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents numDuration As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnEditCo As System.Windows.Forms.Button
    Friend WithEvents cbRoomType As System.Windows.Forms.ComboBox
    Friend WithEvents cbVacant As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents btnEditRoom As System.Windows.Forms.Button
    Friend WithEvents btnDelRoom As System.Windows.Forms.Button
End Class
