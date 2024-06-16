<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStudentAssessment
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudentAssessment))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvAssessment = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtStudentNo = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtFullname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dpSY = New Bunifu.Framework.UI.BunifuDropdown()
        Me.dpCourse = New Bunifu.Framework.UI.BunifuDropdown()
        Me.dpDepartment = New Bunifu.Framework.UI.BunifuDropdown()
        Me.dpSection = New Bunifu.Framework.UI.BunifuDropdown()
        Me.BunifuCustomLabel29 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb0 = New System.Windows.Forms.RadioButton()
        Me.lblTotal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblInstallmentFee = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMiscFee = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTuitionFee = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.rb100 = New System.Windows.Forms.RadioButton()
        Me.rb50 = New System.Windows.Forms.RadioButton()
        Me.rb40 = New System.Windows.Forms.RadioButton()
        Me.rb30 = New System.Windows.Forms.RadioButton()
        Me.rb20 = New System.Windows.Forms.RadioButton()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BunifuSeparator3 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.lblFullpayment = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblFinal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblPreFinal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblMidterm = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblPrelim = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblUponEnrollment = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel22 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel21 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel20 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnAddFee = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvFee = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAssessment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssessment
        '
        Me.dgvAssessment.AllowUserToAddRows = False
        Me.dgvAssessment.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvAssessment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAssessment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAssessment.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvAssessment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAssessment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAssessment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssessment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvAssessment.DoubleBuffered = True
        Me.dgvAssessment.EnableHeadersVisualStyles = False
        Me.dgvAssessment.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAssessment.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvAssessment.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAssessment.Location = New System.Drawing.Point(28, 352)
        Me.dgvAssessment.Name = "dgvAssessment"
        Me.dgvAssessment.ReadOnly = True
        Me.dgvAssessment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAssessment.RowHeadersVisible = False
        Me.dgvAssessment.Size = New System.Drawing.Size(885, 160)
        Me.dgvAssessment.TabIndex = 12
        '
        'Column2
        '
        Me.Column2.HeaderText = "SectionID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Section Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Subject Code"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Subject Title"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Units"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1235, 67)
        Me.Panel2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Student Assessment"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1235, 23)
        Me.Panel1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(1213, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtStudentNo
        '
        Me.txtStudentNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStudentNo.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStudentNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStudentNo.HintForeColor = System.Drawing.Color.Empty
        Me.txtStudentNo.HintText = ""
        Me.txtStudentNo.isPassword = False
        Me.txtStudentNo.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtStudentNo.LineIdleColor = System.Drawing.Color.Black
        Me.txtStudentNo.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtStudentNo.LineThickness = 2
        Me.txtStudentNo.Location = New System.Drawing.Point(134, 22)
        Me.txtStudentNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStudentNo.Name = "txtStudentNo"
        Me.txtStudentNo.Size = New System.Drawing.Size(226, 33)
        Me.txtStudentNo.TabIndex = 15
        Me.txtStudentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtFullname
        '
        Me.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFullname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFullname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFullname.HintForeColor = System.Drawing.Color.Empty
        Me.txtFullname.HintText = ""
        Me.txtFullname.isPassword = False
        Me.txtFullname.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtFullname.LineIdleColor = System.Drawing.Color.Black
        Me.txtFullname.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtFullname.LineThickness = 2
        Me.txtFullname.Location = New System.Drawing.Point(134, 63)
        Me.txtFullname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFullname.Name = "txtFullname"
        Me.txtFullname.Size = New System.Drawing.Size(226, 33)
        Me.txtFullname.TabIndex = 16
        Me.txtFullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.dpSY)
        Me.GroupBox1.Controls.Add(Me.dpCourse)
        Me.GroupBox1.Controls.Add(Me.dpDepartment)
        Me.GroupBox1.Controls.Add(Me.dpSection)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel29)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox1.Controls.Add(Me.txtStudentNo)
        Me.GroupBox1.Controls.Add(Me.txtFullname)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(28, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 220)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'dpSY
        '
        Me.dpSY.BackColor = System.Drawing.Color.Transparent
        Me.dpSY.BorderRadius = 3
        Me.dpSY.ForeColor = System.Drawing.Color.Black
        Me.dpSY.Items = New String(-1) {}
        Me.dpSY.Location = New System.Drawing.Point(647, 23)
        Me.dpSY.Margin = New System.Windows.Forms.Padding(5)
        Me.dpSY.Name = "dpSY"
        Me.dpSY.NomalColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpSY.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpSY.selectedIndex = -1
        Me.dpSY.Size = New System.Drawing.Size(204, 38)
        Me.dpSY.TabIndex = 33
        '
        'dpCourse
        '
        Me.dpCourse.BackColor = System.Drawing.Color.Transparent
        Me.dpCourse.BorderRadius = 3
        Me.dpCourse.ForeColor = System.Drawing.Color.Black
        Me.dpCourse.Items = New String(-1) {}
        Me.dpCourse.Location = New System.Drawing.Point(133, 170)
        Me.dpCourse.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.dpCourse.Name = "dpCourse"
        Me.dpCourse.NomalColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpCourse.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpCourse.selectedIndex = -1
        Me.dpCourse.Size = New System.Drawing.Size(227, 38)
        Me.dpCourse.TabIndex = 31
        '
        'dpDepartment
        '
        Me.dpDepartment.BackColor = System.Drawing.Color.Transparent
        Me.dpDepartment.BorderRadius = 3
        Me.dpDepartment.ForeColor = System.Drawing.Color.Black
        Me.dpDepartment.Items = New String(-1) {}
        Me.dpDepartment.Location = New System.Drawing.Point(133, 121)
        Me.dpDepartment.Margin = New System.Windows.Forms.Padding(5)
        Me.dpDepartment.Name = "dpDepartment"
        Me.dpDepartment.NomalColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpDepartment.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpDepartment.selectedIndex = -1
        Me.dpDepartment.Size = New System.Drawing.Size(227, 38)
        Me.dpDepartment.TabIndex = 30
        '
        'dpSection
        '
        Me.dpSection.BackColor = System.Drawing.Color.Transparent
        Me.dpSection.BorderRadius = 3
        Me.dpSection.ForeColor = System.Drawing.Color.Black
        Me.dpSection.Items = New String(-1) {}
        Me.dpSection.Location = New System.Drawing.Point(647, 70)
        Me.dpSection.Margin = New System.Windows.Forms.Padding(4)
        Me.dpSection.Name = "dpSection"
        Me.dpSection.NomalColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpSection.onHoverColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dpSection.selectedIndex = -1
        Me.dpSection.Size = New System.Drawing.Size(204, 38)
        Me.dpSection.TabIndex = 29
        '
        'BunifuCustomLabel29
        '
        Me.BunifuCustomLabel29.AutoSize = True
        Me.BunifuCustomLabel29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel29.Location = New System.Drawing.Point(543, 84)
        Me.BunifuCustomLabel29.Name = "BunifuCustomLabel29"
        Me.BunifuCustomLabel29.Size = New System.Drawing.Size(63, 16)
        Me.BunifuCustomLabel29.TabIndex = 28
        Me.BunifuCustomLabel29.Text = "Section:"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(543, 39)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(96, 16)
        Me.BunifuCustomLabel5.TabIndex = 25
        Me.BunifuCustomLabel5.Text = "School Year:"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(6, 181)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(60, 16)
        Me.BunifuCustomLabel4.TabIndex = 24
        Me.BunifuCustomLabel4.Text = "Course:"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(6, 135)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(91, 16)
        Me.BunifuCustomLabel3.TabIndex = 23
        Me.BunifuCustomLabel3.Text = "Department:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(6, 80)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(108, 16)
        Me.BunifuCustomLabel2.TabIndex = 22
        Me.BunifuCustomLabel2.Text = "Student Name:"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(6, 39)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(121, 16)
        Me.BunifuCustomLabel1.TabIndex = 18
        Me.BunifuCustomLabel1.Text = "Student Number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb0)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.lblInstallmentFee)
        Me.GroupBox2.Controls.Add(Me.lblMiscFee)
        Me.GroupBox2.Controls.Add(Me.lblTuitionFee)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel11)
        Me.GroupBox2.Controls.Add(Me.BunifuSeparator2)
        Me.GroupBox2.Controls.Add(Me.rb100)
        Me.GroupBox2.Controls.Add(Me.rb50)
        Me.GroupBox2.Controls.Add(Me.rb40)
        Me.GroupBox2.Controls.Add(Me.rb30)
        Me.GroupBox2.Controls.Add(Me.rb20)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel10)
        Me.GroupBox2.Controls.Add(Me.BunifuSeparator1)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel9)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox2.Location = New System.Drawing.Point(930, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 312)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'rb0
        '
        Me.rb0.AutoSize = True
        Me.rb0.Checked = True
        Me.rb0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb0.Location = New System.Drawing.Point(69, 178)
        Me.rb0.Name = "rb0"
        Me.rb0.Size = New System.Drawing.Size(43, 19)
        Me.rb0.TabIndex = 43
        Me.rb0.TabStop = True
        Me.rb0.Text = "0%"
        Me.rb0.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(166, 269)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(15, 16)
        Me.lblTotal.TabIndex = 42
        Me.lblTotal.Text = "0"
        '
        'lblInstallmentFee
        '
        Me.lblInstallmentFee.AutoSize = True
        Me.lblInstallmentFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstallmentFee.Location = New System.Drawing.Point(144, 96)
        Me.lblInstallmentFee.Name = "lblInstallmentFee"
        Me.lblInstallmentFee.Size = New System.Drawing.Size(39, 16)
        Me.lblInstallmentFee.TabIndex = 41
        Me.lblInstallmentFee.Text = "1200"
        '
        'lblMiscFee
        '
        Me.lblMiscFee.AutoSize = True
        Me.lblMiscFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMiscFee.Location = New System.Drawing.Point(144, 63)
        Me.lblMiscFee.Name = "lblMiscFee"
        Me.lblMiscFee.Size = New System.Drawing.Size(15, 16)
        Me.lblMiscFee.TabIndex = 40
        Me.lblMiscFee.Text = "0"
        '
        'lblTuitionFee
        '
        Me.lblTuitionFee.AutoSize = True
        Me.lblTuitionFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTuitionFee.Location = New System.Drawing.Point(144, 30)
        Me.lblTuitionFee.Name = "lblTuitionFee"
        Me.lblTuitionFee.Size = New System.Drawing.Size(15, 16)
        Me.lblTuitionFee.TabIndex = 39
        Me.lblTuitionFee.Text = "0"
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(21, 269)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(135, 16)
        Me.BunifuCustomLabel11.TabIndex = 38
        Me.BunifuCustomLabel11.Text = "Total Assessment:"
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 2
        Me.BunifuSeparator2.Location = New System.Drawing.Point(24, 249)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(231, 17)
        Me.BunifuSeparator2.TabIndex = 37
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'rb100
        '
        Me.rb100.AutoSize = True
        Me.rb100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb100.Location = New System.Drawing.Point(147, 224)
        Me.rb100.Name = "rb100"
        Me.rb100.Size = New System.Drawing.Size(57, 19)
        Me.rb100.TabIndex = 36
        Me.rb100.TabStop = True
        Me.rb100.Text = "100%"
        Me.rb100.UseVisualStyleBackColor = True
        '
        'rb50
        '
        Me.rb50.AutoSize = True
        Me.rb50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb50.Location = New System.Drawing.Point(147, 201)
        Me.rb50.Name = "rb50"
        Me.rb50.Size = New System.Drawing.Size(50, 19)
        Me.rb50.TabIndex = 35
        Me.rb50.TabStop = True
        Me.rb50.Text = "50%"
        Me.rb50.UseVisualStyleBackColor = True
        '
        'rb40
        '
        Me.rb40.AutoSize = True
        Me.rb40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb40.Location = New System.Drawing.Point(147, 178)
        Me.rb40.Name = "rb40"
        Me.rb40.Size = New System.Drawing.Size(50, 19)
        Me.rb40.TabIndex = 34
        Me.rb40.TabStop = True
        Me.rb40.Text = "40%"
        Me.rb40.UseVisualStyleBackColor = True
        '
        'rb30
        '
        Me.rb30.AutoSize = True
        Me.rb30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb30.Location = New System.Drawing.Point(69, 224)
        Me.rb30.Name = "rb30"
        Me.rb30.Size = New System.Drawing.Size(50, 19)
        Me.rb30.TabIndex = 33
        Me.rb30.TabStop = True
        Me.rb30.Text = "30%"
        Me.rb30.UseVisualStyleBackColor = True
        '
        'rb20
        '
        Me.rb20.AutoSize = True
        Me.rb20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb20.Location = New System.Drawing.Point(69, 201)
        Me.rb20.Name = "rb20"
        Me.rb20.Size = New System.Drawing.Size(50, 19)
        Me.rb20.TabIndex = 32
        Me.rb20.TabStop = True
        Me.rb20.Text = "20%"
        Me.rb20.UseVisualStyleBackColor = True
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(32, 145)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(103, 16)
        Me.BunifuCustomLabel10.TabIndex = 31
        Me.BunifuCustomLabel10.Text = "Add Discount:"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(22, 125)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(231, 17)
        Me.BunifuSeparator1.TabIndex = 30
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(21, 96)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(116, 16)
        Me.BunifuCustomLabel9.TabIndex = 29
        Me.BunifuCustomLabel9.Text = "Installment Fee:"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(21, 64)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(74, 16)
        Me.BunifuCustomLabel8.TabIndex = 28
        Me.BunifuCustomLabel8.Text = "Misc Fee:"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(19, 30)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(89, 16)
        Me.BunifuCustomLabel7.TabIndex = 27
        Me.BunifuCustomLabel7.Text = "Tuition Fee:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BunifuSeparator3)
        Me.GroupBox3.Controls.Add(Me.lblFullpayment)
        Me.GroupBox3.Controls.Add(Me.lblFinal)
        Me.GroupBox3.Controls.Add(Me.lblPreFinal)
        Me.GroupBox3.Controls.Add(Me.lblMidterm)
        Me.GroupBox3.Controls.Add(Me.lblPrelim)
        Me.GroupBox3.Controls.Add(Me.lblUponEnrollment)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel22)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel21)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel20)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel19)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel18)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel17)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel16)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(930, 448)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 218)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Scheme"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator3.LineThickness = 2
        Me.BunifuSeparator3.Location = New System.Drawing.Point(22, 50)
        Me.BunifuSeparator3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Size = New System.Drawing.Size(233, 13)
        Me.BunifuSeparator3.TabIndex = 43
        Me.BunifuSeparator3.Transparency = 255
        Me.BunifuSeparator3.Vertical = False
        '
        'lblFullpayment
        '
        Me.lblFullpayment.AutoSize = True
        Me.lblFullpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullpayment.Location = New System.Drawing.Point(178, 30)
        Me.lblFullpayment.Name = "lblFullpayment"
        Me.lblFullpayment.Size = New System.Drawing.Size(15, 16)
        Me.lblFullpayment.TabIndex = 55
        Me.lblFullpayment.Text = "0"
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.Location = New System.Drawing.Point(178, 190)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(15, 16)
        Me.lblFinal.TabIndex = 54
        Me.lblFinal.Text = "0"
        '
        'lblPreFinal
        '
        Me.lblPreFinal.AutoSize = True
        Me.lblPreFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreFinal.Location = New System.Drawing.Point(178, 165)
        Me.lblPreFinal.Name = "lblPreFinal"
        Me.lblPreFinal.Size = New System.Drawing.Size(15, 16)
        Me.lblPreFinal.TabIndex = 53
        Me.lblPreFinal.Text = "0"
        '
        'lblMidterm
        '
        Me.lblMidterm.AutoSize = True
        Me.lblMidterm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidterm.Location = New System.Drawing.Point(178, 139)
        Me.lblMidterm.Name = "lblMidterm"
        Me.lblMidterm.Size = New System.Drawing.Size(15, 16)
        Me.lblMidterm.TabIndex = 52
        Me.lblMidterm.Text = "0"
        '
        'lblPrelim
        '
        Me.lblPrelim.AutoSize = True
        Me.lblPrelim.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrelim.Location = New System.Drawing.Point(178, 113)
        Me.lblPrelim.Name = "lblPrelim"
        Me.lblPrelim.Size = New System.Drawing.Size(15, 16)
        Me.lblPrelim.TabIndex = 51
        Me.lblPrelim.Text = "0"
        '
        'lblUponEnrollment
        '
        Me.lblUponEnrollment.AutoSize = True
        Me.lblUponEnrollment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUponEnrollment.Location = New System.Drawing.Point(178, 87)
        Me.lblUponEnrollment.Name = "lblUponEnrollment"
        Me.lblUponEnrollment.Size = New System.Drawing.Size(39, 16)
        Me.lblUponEnrollment.TabIndex = 50
        Me.lblUponEnrollment.Text = "5000"
        '
        'BunifuCustomLabel22
        '
        Me.BunifuCustomLabel22.AutoSize = True
        Me.BunifuCustomLabel22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel22.Location = New System.Drawing.Point(21, 190)
        Me.BunifuCustomLabel22.Name = "BunifuCustomLabel22"
        Me.BunifuCustomLabel22.Size = New System.Drawing.Size(45, 16)
        Me.BunifuCustomLabel22.TabIndex = 49
        Me.BunifuCustomLabel22.Text = "Final:"
        '
        'BunifuCustomLabel21
        '
        Me.BunifuCustomLabel21.AutoSize = True
        Me.BunifuCustomLabel21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel21.Location = New System.Drawing.Point(21, 165)
        Me.BunifuCustomLabel21.Name = "BunifuCustomLabel21"
        Me.BunifuCustomLabel21.Size = New System.Drawing.Size(74, 16)
        Me.BunifuCustomLabel21.TabIndex = 48
        Me.BunifuCustomLabel21.Text = "Pre-Final:"
        '
        'BunifuCustomLabel20
        '
        Me.BunifuCustomLabel20.AutoSize = True
        Me.BunifuCustomLabel20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel20.Location = New System.Drawing.Point(21, 139)
        Me.BunifuCustomLabel20.Name = "BunifuCustomLabel20"
        Me.BunifuCustomLabel20.Size = New System.Drawing.Size(66, 16)
        Me.BunifuCustomLabel20.TabIndex = 47
        Me.BunifuCustomLabel20.Text = "Midterm:"
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.AutoSize = True
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(21, 113)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(55, 16)
        Me.BunifuCustomLabel19.TabIndex = 46
        Me.BunifuCustomLabel19.Text = "Prelim:"
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.AutoSize = True
        Me.BunifuCustomLabel18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(21, 87)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(125, 16)
        Me.BunifuCustomLabel18.TabIndex = 45
        Me.BunifuCustomLabel18.Text = "Upon Enrollment:"
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(19, 62)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(81, 16)
        Me.BunifuCustomLabel17.TabIndex = 44
        Me.BunifuCustomLabel17.Text = "Installment"
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(19, 30)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(100, 16)
        Me.BunifuCustomLabel16.TabIndex = 43
        Me.BunifuCustomLabel16.Text = "Full Payment:"
        '
        'btnPrint
        '
        Me.btnPrint.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.BorderRadius = 0
        Me.btnPrint.ButtonText = "Print Assessment"
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrint.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrint.Iconimage = Nothing
        Me.btnPrint.Iconimage_right = Nothing
        Me.btnPrint.Iconimage_right_Selected = Nothing
        Me.btnPrint.Iconimage_Selected = Nothing
        Me.btnPrint.IconMarginLeft = 0
        Me.btnPrint.IconMarginRight = 0
        Me.btnPrint.IconRightVisible = True
        Me.btnPrint.IconRightZoom = 0R
        Me.btnPrint.IconVisible = True
        Me.btnPrint.IconZoom = 90.0R
        Me.btnPrint.IsTab = False
        Me.btnPrint.Location = New System.Drawing.Point(1077, 682)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrint.selected = False
        Me.btnPrint.Size = New System.Drawing.Size(108, 38)
        Me.btnPrint.TabIndex = 30
        Me.btnPrint.Text = "Print Assessment"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPrint.Textcolor = System.Drawing.Color.White
        Me.btnPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'btnAddFee
        '
        Me.btnAddFee.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddFee.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddFee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddFee.BorderRadius = 0
        Me.btnAddFee.ButtonText = "Add Fee"
        Me.btnAddFee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddFee.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddFee.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddFee.Iconimage = Nothing
        Me.btnAddFee.Iconimage_right = Nothing
        Me.btnAddFee.Iconimage_right_Selected = Nothing
        Me.btnAddFee.Iconimage_Selected = Nothing
        Me.btnAddFee.IconMarginLeft = 0
        Me.btnAddFee.IconMarginRight = 0
        Me.btnAddFee.IconRightVisible = True
        Me.btnAddFee.IconRightZoom = 0R
        Me.btnAddFee.IconVisible = True
        Me.btnAddFee.IconZoom = 90.0R
        Me.btnAddFee.IsTab = False
        Me.btnAddFee.Location = New System.Drawing.Point(965, 682)
        Me.btnAddFee.Name = "btnAddFee"
        Me.btnAddFee.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAddFee.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAddFee.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddFee.selected = False
        Me.btnAddFee.Size = New System.Drawing.Size(106, 38)
        Me.btnAddFee.TabIndex = 31
        Me.btnAddFee.Text = "Add Fee"
        Me.btnAddFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAddFee.Textcolor = System.Drawing.Color.White
        Me.btnAddFee.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvFee
        '
        Me.dgvFee.AllowUserToAddRows = False
        Me.dgvFee.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvFee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFee.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvFee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.Column6})
        Me.dgvFee.DoubleBuffered = True
        Me.dgvFee.EnableHeadersVisualStyles = False
        Me.dgvFee.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvFee.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.dgvFee.HeaderForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvFee.Location = New System.Drawing.Point(28, 535)
        Me.dgvFee.Name = "dgvFee"
        Me.dgvFee.ReadOnly = True
        Me.dgvFee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvFee.RowHeadersVisible = False
        Me.dgvFee.Size = New System.Drawing.Size(885, 160)
        Me.dgvFee.TabIndex = 32
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Miscellaneous Fee"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Amount"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'frmStudentAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 728)
        Me.Controls.Add(Me.dgvFee)
        Me.Controls.Add(Me.btnAddFee)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvAssessment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStudentAssessment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStudentAssessment"
        CType(Me.dgvAssessment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAssessment As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents txtStudentNo As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtFullname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents rb100 As RadioButton
    Friend WithEvents rb50 As RadioButton
    Friend WithEvents rb40 As RadioButton
    Friend WithEvents rb30 As RadioButton
    Friend WithEvents rb20 As RadioButton
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblTotal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblInstallmentFee As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMiscFee As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTuitionFee As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblFinal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblPreFinal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblMidterm As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblPrelim As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblUponEnrollment As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel22 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel21 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel20 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuSeparator3 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents lblFullpayment As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCustomLabel29 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dpSection As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents dpCourse As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents dpDepartment As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents dpSY As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents rb0 As RadioButton
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnAddFee As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvFee As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
