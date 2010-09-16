<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEddiesEquipment
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
        Me.btnDisplayRentalRates = New System.Windows.Forms.Button()
        Me.lblSelectItem = New System.Windows.Forms.Label()
        Me.lblSelectDuration = New System.Windows.Forms.Label()
        Me.txtSelectItem = New System.Windows.Forms.TextBox()
        Me.txtSelectDuration = New System.Windows.Forms.TextBox()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.lstRentalRates = New System.Windows.Forms.ListBox()
        Me.lstCustomerBill = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayRentalRates
        '
        Me.btnDisplayRentalRates.Location = New System.Drawing.Point(12, 12)
        Me.btnDisplayRentalRates.Name = "btnDisplayRentalRates"
        Me.btnDisplayRentalRates.Size = New System.Drawing.Size(178, 47)
        Me.btnDisplayRentalRates.TabIndex = 0
        Me.btnDisplayRentalRates.Text = "Display Rental Rates"
        Me.btnDisplayRentalRates.UseVisualStyleBackColor = True
        '
        'lblSelectItem
        '
        Me.lblSelectItem.AutoSize = True
        Me.lblSelectItem.Location = New System.Drawing.Point(12, 99)
        Me.lblSelectItem.Name = "lblSelectItem"
        Me.lblSelectItem.Size = New System.Drawing.Size(128, 13)
        Me.lblSelectItem.TabIndex = 1
        Me.lblSelectItem.Text = "Select an item (1, 2, or 3):"
        '
        'lblSelectDuration
        '
        Me.lblSelectDuration.AutoSize = True
        Me.lblSelectDuration.Location = New System.Drawing.Point(12, 128)
        Me.lblSelectDuration.Name = "lblSelectDuration"
        Me.lblSelectDuration.Size = New System.Drawing.Size(128, 13)
        Me.lblSelectDuration.TabIndex = 2
        Me.lblSelectDuration.Text = "Select a duration (H or F):"
        '
        'txtSelectItem
        '
        Me.txtSelectItem.Location = New System.Drawing.Point(160, 96)
        Me.txtSelectItem.Name = "txtSelectItem"
        Me.txtSelectItem.Size = New System.Drawing.Size(22, 20)
        Me.txtSelectItem.TabIndex = 3
        '
        'txtSelectDuration
        '
        Me.txtSelectDuration.Location = New System.Drawing.Point(160, 125)
        Me.txtSelectDuration.Name = "txtSelectDuration"
        Me.txtSelectDuration.Size = New System.Drawing.Size(22, 20)
        Me.txtSelectDuration.TabIndex = 4
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Location = New System.Drawing.Point(12, 196)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(178, 45)
        Me.btnDisplayBill.TabIndex = 5
        Me.btnDisplayBill.Text = "Display Customer Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'lstRentalRates
        '
        Me.lstRentalRates.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRentalRates.FormattingEnabled = True
        Me.lstRentalRates.ItemHeight = 14
        Me.lstRentalRates.Location = New System.Drawing.Point(196, 12)
        Me.lstRentalRates.Name = "lstRentalRates"
        Me.lstRentalRates.Size = New System.Drawing.Size(412, 74)
        Me.lstRentalRates.TabIndex = 6
        '
        'lstCustomerBill
        '
        Me.lstCustomerBill.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCustomerBill.FormattingEnabled = True
        Me.lstCustomerBill.ItemHeight = 14
        Me.lstCustomerBill.Location = New System.Drawing.Point(196, 111)
        Me.lstCustomerBill.Name = "lstCustomerBill"
        Me.lstCustomerBill.Size = New System.Drawing.Size(401, 130)
        Me.lstCustomerBill.TabIndex = 7
        '
        'frmEddiesEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 262)
        Me.Controls.Add(Me.lstCustomerBill)
        Me.Controls.Add(Me.lstRentalRates)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.txtSelectDuration)
        Me.Controls.Add(Me.txtSelectItem)
        Me.Controls.Add(Me.lblSelectDuration)
        Me.Controls.Add(Me.lblSelectItem)
        Me.Controls.Add(Me.btnDisplayRentalRates)
        Me.Name = "frmEddiesEquipment"
        Me.Text = "Welcome to Eddie's Equipment Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplayRentalRates As System.Windows.Forms.Button
    Friend WithEvents lblSelectItem As System.Windows.Forms.Label
    Friend WithEvents lblSelectDuration As System.Windows.Forms.Label
    Friend WithEvents txtSelectItem As System.Windows.Forms.TextBox
    Friend WithEvents txtSelectDuration As System.Windows.Forms.TextBox
    Friend WithEvents btnDisplayBill As System.Windows.Forms.Button
    Friend WithEvents lstRentalRates As System.Windows.Forms.ListBox
    Friend WithEvents lstCustomerBill As System.Windows.Forms.ListBox

End Class
