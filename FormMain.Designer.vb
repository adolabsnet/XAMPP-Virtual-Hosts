﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxVirtualHosts = New System.Windows.Forms.ComboBox()
        Me.TextBoxVirtualHostEntryRaw = New System.Windows.Forms.TextBox()
        Me.GroupBoxViewVirtualHosts = New System.Windows.Forms.GroupBox()
        Me.ButtonAddVirtualHost = New System.Windows.Forms.Button()
        Me.LabelSelect = New System.Windows.Forms.Label()
        Me.LabelPreview = New System.Windows.Forms.Label()
        Me.ButtonRemoveVirtualHost = New System.Windows.Forms.Button()
        Me.GroupBoxViewVirtualHosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxVirtualHosts
        '
        Me.ComboBoxVirtualHosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxVirtualHosts.FormattingEnabled = True
        Me.ComboBoxVirtualHosts.Location = New System.Drawing.Point(20, 56)
        Me.ComboBoxVirtualHosts.Margin = New System.Windows.Forms.Padding(0, 0, 20, 20)
        Me.ComboBoxVirtualHosts.Name = "ComboBoxVirtualHosts"
        Me.ComboBoxVirtualHosts.Size = New System.Drawing.Size(320, 26)
        Me.ComboBoxVirtualHosts.TabIndex = 0
        '
        'TextBoxVirtualHostEntryRaw
        '
        Me.TextBoxVirtualHostEntryRaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxVirtualHostEntryRaw.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVirtualHostEntryRaw.Location = New System.Drawing.Point(360, 56)
        Me.TextBoxVirtualHostEntryRaw.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxVirtualHostEntryRaw.Multiline = True
        Me.TextBoxVirtualHostEntryRaw.Name = "TextBoxVirtualHostEntryRaw"
        Me.TextBoxVirtualHostEntryRaw.ReadOnly = True
        Me.TextBoxVirtualHostEntryRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxVirtualHostEntryRaw.Size = New System.Drawing.Size(450, 270)
        Me.TextBoxVirtualHostEntryRaw.TabIndex = 1
        Me.TextBoxVirtualHostEntryRaw.WordWrap = False
        '
        'GroupBoxViewVirtualHosts
        '
        Me.GroupBoxViewVirtualHosts.AutoSize = True
        Me.GroupBoxViewVirtualHosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ButtonRemoveVirtualHost)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.LabelPreview)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.LabelSelect)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ButtonAddVirtualHost)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.ComboBoxVirtualHosts)
        Me.GroupBoxViewVirtualHosts.Controls.Add(Me.TextBoxVirtualHostEntryRaw)
        Me.GroupBoxViewVirtualHosts.Location = New System.Drawing.Point(20, 20)
        Me.GroupBoxViewVirtualHosts.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.GroupBoxViewVirtualHosts.Name = "GroupBoxViewVirtualHosts"
        Me.GroupBoxViewVirtualHosts.Padding = New System.Windows.Forms.Padding(20)
        Me.GroupBoxViewVirtualHosts.Size = New System.Drawing.Size(830, 364)
        Me.GroupBoxViewVirtualHosts.TabIndex = 2
        Me.GroupBoxViewVirtualHosts.TabStop = False
        Me.GroupBoxViewVirtualHosts.Text = "View Virtual Hosts"
        '
        'ButtonAddVirtualHost
        '
        Me.ButtonAddVirtualHost.AutoSize = True
        Me.ButtonAddVirtualHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonAddVirtualHost.Location = New System.Drawing.Point(20, 102)
        Me.ButtonAddVirtualHost.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ButtonAddVirtualHost.Name = "ButtonAddVirtualHost"
        Me.ButtonAddVirtualHost.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonAddVirtualHost.Size = New System.Drawing.Size(120, 32)
        Me.ButtonAddVirtualHost.TabIndex = 4
        Me.ButtonAddVirtualHost.Text = "Add Virtual Host"
        Me.ButtonAddVirtualHost.UseVisualStyleBackColor = True
        '
        'LabelSelect
        '
        Me.LabelSelect.AutoSize = True
        Me.LabelSelect.Location = New System.Drawing.Point(17, 38)
        Me.LabelSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSelect.Name = "LabelSelect"
        Me.LabelSelect.Size = New System.Drawing.Size(43, 18)
        Me.LabelSelect.TabIndex = 5
        Me.LabelSelect.Text = "Select"
        '
        'LabelPreview
        '
        Me.LabelPreview.AutoSize = True
        Me.LabelPreview.Location = New System.Drawing.Point(357, 38)
        Me.LabelPreview.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelPreview.Name = "LabelPreview"
        Me.LabelPreview.Size = New System.Drawing.Size(55, 18)
        Me.LabelPreview.TabIndex = 6
        Me.LabelPreview.Text = "Preview"
        '
        'ButtonRemoveVirtualHost
        '
        Me.ButtonRemoveVirtualHost.AutoSize = True
        Me.ButtonRemoveVirtualHost.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonRemoveVirtualHost.Location = New System.Drawing.Point(142, 102)
        Me.ButtonRemoveVirtualHost.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonRemoveVirtualHost.Name = "ButtonRemoveVirtualHost"
        Me.ButtonRemoveVirtualHost.Padding = New System.Windows.Forms.Padding(2)
        Me.ButtonRemoveVirtualHost.Size = New System.Drawing.Size(145, 32)
        Me.ButtonRemoveVirtualHost.TabIndex = 7
        Me.ButtonRemoveVirtualHost.Text = "Remove Virtual Host"
        Me.ButtonRemoveVirtualHost.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1026, 574)
        Me.Controls.Add(Me.GroupBoxViewVirtualHosts)
        Me.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(20)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XAMPP Virtual Hosts"
        Me.GroupBoxViewVirtualHosts.ResumeLayout(False)
        Me.GroupBoxViewVirtualHosts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxVirtualHosts As ComboBox
    Friend WithEvents TextBoxVirtualHostEntryRaw As TextBox
    Friend WithEvents GroupBoxViewVirtualHosts As GroupBox
    Friend WithEvents ButtonAddVirtualHost As Button
    Friend WithEvents LabelPreview As Label
    Friend WithEvents LabelSelect As Label
    Friend WithEvents ButtonRemoveVirtualHost As Button
End Class
