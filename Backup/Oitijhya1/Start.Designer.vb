﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.gridView = New System.Windows.Forms.DataGridView
        Me.GridRCMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InsertBelowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetFilterCriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.cmdRollback = New System.Windows.Forms.Button
        Me.optFilter = New System.Windows.Forms.RadioButton
        Me.optFull = New System.Windows.Forms.RadioButton
        Me.cmdSave = New System.Windows.Forms.Button
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridRCMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridView
        '
        Me.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridView.ContextMenuStrip = Me.GridRCMenu
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridView.Location = New System.Drawing.Point(12, 12)
        Me.gridView.Name = "gridView"
        Me.gridView.Size = New System.Drawing.Size(786, 388)
        Me.gridView.TabIndex = 0
        '
        'GridRCMenu
        '
        Me.GridRCMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.InsertBelowToolStripMenuItem, Me.SetFilterCriteriaToolStripMenuItem, Me.ModifyToolStripMenuItem})
        Me.GridRCMenu.Name = "GridRCMenu"
        Me.GridRCMenu.Size = New System.Drawing.Size(167, 92)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'InsertBelowToolStripMenuItem
        '
        Me.InsertBelowToolStripMenuItem.Name = "InsertBelowToolStripMenuItem"
        Me.InsertBelowToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.InsertBelowToolStripMenuItem.Text = "Insert Below"
        '
        'SetFilterCriteriaToolStripMenuItem
        '
        Me.SetFilterCriteriaToolStripMenuItem.Name = "SetFilterCriteriaToolStripMenuItem"
        Me.SetFilterCriteriaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.SetFilterCriteriaToolStripMenuItem.Text = "Filter Similar Data"
        '
        'ModifyToolStripMenuItem
        '
        Me.ModifyToolStripMenuItem.Name = "ModifyToolStripMenuItem"
        Me.ModifyToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ModifyToolStripMenuItem.Text = "Modify"
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(428, 411)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(125, 29)
        Me.cmdLoad.TabIndex = 1
        Me.cmdLoad.Text = "Load New"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'cmdRollback
        '
        Me.cmdRollback.Location = New System.Drawing.Point(680, 411)
        Me.cmdRollback.Name = "cmdRollback"
        Me.cmdRollback.Size = New System.Drawing.Size(118, 29)
        Me.cmdRollback.TabIndex = 2
        Me.cmdRollback.Text = "Rollback"
        Me.cmdRollback.UseVisualStyleBackColor = True
        '
        'optFilter
        '
        Me.optFilter.AutoSize = True
        Me.optFilter.Location = New System.Drawing.Point(12, 406)
        Me.optFilter.Name = "optFilter"
        Me.optFilter.Size = New System.Drawing.Size(97, 17)
        Me.optFilter.TabIndex = 3
        Me.optFilter.Text = "Filtered Results"
        Me.optFilter.UseVisualStyleBackColor = True
        '
        'optFull
        '
        Me.optFull.AutoSize = True
        Me.optFull.Checked = True
        Me.optFull.Location = New System.Drawing.Point(12, 423)
        Me.optFull.Name = "optFull"
        Me.optFull.Size = New System.Drawing.Size(71, 17)
        Me.optFull.TabIndex = 4
        Me.optFull.TabStop = True
        Me.optFull.Text = "Full Table"
        Me.optFull.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(559, 411)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(115, 29)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Save Changes"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 447)
        Me.Controls.Add(Me.optFull)
        Me.Controls.Add(Me.cmdRollback)
        Me.Controls.Add(Me.optFilter)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.gridView)
        Me.Controls.Add(Me.cmdLoad)
        Me.Name = "Start"
        Me.Text = "Start"
        CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridRCMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gridView As System.Windows.Forms.DataGridView
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdRollback As System.Windows.Forms.Button
    Friend WithEvents GridRCMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertBelowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetFilterCriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optFilter As System.Windows.Forms.RadioButton
    Friend WithEvents optFull As System.Windows.Forms.RadioButton
    Friend WithEvents cmdSave As System.Windows.Forms.Button
End Class
