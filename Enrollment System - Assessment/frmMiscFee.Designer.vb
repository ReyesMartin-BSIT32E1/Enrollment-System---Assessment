<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMiscFee
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
        Me.btnAddFee = New System.Windows.Forms.Button()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numAmount = New System.Windows.Forms.NumericUpDown()
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddFee
        '
        Me.btnAddFee.Location = New System.Drawing.Point(60, 90)
        Me.btnAddFee.Name = "btnAddFee"
        Me.btnAddFee.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFee.TabIndex = 0
        Me.btnAddFee.Text = "Add Fee"
        Me.btnAddFee.UseVisualStyleBackColor = True
        '
        'txtFee
        '
        Me.txtFee.Location = New System.Drawing.Point(15, 25)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(120, 20)
        Me.txtFee.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fee"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Amount"
        '
        'numAmount
        '
        Me.numAmount.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.numAmount.Location = New System.Drawing.Point(15, 64)
        Me.numAmount.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(120, 20)
        Me.numAmount.TabIndex = 5
        '
        'frmMiscFee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(149, 124)
        Me.Controls.Add(Me.numAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFee)
        Me.Controls.Add(Me.btnAddFee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMiscFee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Miscellaneous Fee"
        CType(Me.numAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddFee As Button
    Friend WithEvents txtFee As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numAmount As NumericUpDown
End Class
