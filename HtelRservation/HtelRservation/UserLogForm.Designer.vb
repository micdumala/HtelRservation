<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLog
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
        Me.dgvUserLog = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbSelCol = New System.Windows.Forms.ComboBox()
        Me.dtpUpdate = New System.Windows.Forms.DateTimePicker()
        Me.cbSelValue = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        CType(Me.dgvUserLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUserLog
        '
        Me.dgvUserLog.AllowUserToAddRows = False
        Me.dgvUserLog.AllowUserToDeleteRows = False
        Me.dgvUserLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUserLog.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvUserLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserLog.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUserLog.Location = New System.Drawing.Point(13, 61)
        Me.dgvUserLog.Name = "dgvUserLog"
        Me.dgvUserLog.RowHeadersVisible = False
        Me.dgvUserLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserLog.Size = New System.Drawing.Size(540, 304)
        Me.dgvUserLog.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(13, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(97, 23)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'cbSelCol
        '
        Me.cbSelCol.FormattingEnabled = True
        Me.cbSelCol.Items.AddRange(New Object() {"All", "UserId", "ActionTaken", "Affected"})
        Me.cbSelCol.Location = New System.Drawing.Point(12, 34)
        Me.cbSelCol.Name = "cbSelCol"
        Me.cbSelCol.Size = New System.Drawing.Size(100, 21)
        Me.cbSelCol.TabIndex = 2
        '
        'dtpUpdate
        '
        Me.dtpUpdate.Location = New System.Drawing.Point(224, 35)
        Me.dtpUpdate.Name = "dtpUpdate"
        Me.dtpUpdate.Size = New System.Drawing.Size(218, 20)
        Me.dtpUpdate.TabIndex = 5
        '
        'cbSelValue
        '
        Me.cbSelValue.FormattingEnabled = True
        Me.cbSelValue.Location = New System.Drawing.Point(118, 34)
        Me.cbSelValue.Name = "cbSelValue"
        Me.cbSelValue.Size = New System.Drawing.Size(100, 21)
        Me.cbSelValue.TabIndex = 6
        '
        'btnFilter
        '
        Me.btnFilter.Location = New System.Drawing.Point(448, 32)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(97, 23)
        Me.btnFilter.TabIndex = 7
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'frmUserLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 377)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cbSelValue)
        Me.Controls.Add(Me.dtpUpdate)
        Me.Controls.Add(Me.cbSelCol)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvUserLog)
        Me.Name = "frmUserLog"
        Me.Text = "UserLogForm"
        CType(Me.dgvUserLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvUserLog As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cbSelCol As System.Windows.Forms.ComboBox
    Friend WithEvents dtpUpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbSelValue As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
End Class
