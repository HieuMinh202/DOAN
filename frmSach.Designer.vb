﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlisach
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtmasach = New System.Windows.Forms.TextBox()
        Me.txttensach = New System.Windows.Forms.TextBox()
        Me.txtsoluongton = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txttacgia = New System.Windows.Forms.TextBox()
        Me.cbnhaxuatban = New System.Windows.Forms.ComboBox()
        Me.cbtheloaisach = New System.Windows.Forms.ComboBox()
        Me.txtnamxuatban = New System.Windows.Forms.TextBox()
        Me.txtvitrikesach = New System.Windows.Forms.TextBox()
        Me.dgvSach = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnLuu = New System.Windows.Forms.Button()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quản Lý Sách"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mã sách"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 27)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên sách"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Số lượng tồn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 27)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Đơn giá"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 27)
        Me.Label6.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 27)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tác giả"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 27)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Nhà xuất bản"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 27)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Năm xuất bản"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 409)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 27)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Thể loại sách"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 459)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 27)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Vị trí kệ sách"
        '
        'txtmasach
        '
        Me.txtmasach.Location = New System.Drawing.Point(194, 98)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.Size = New System.Drawing.Size(134, 22)
        Me.txtmasach.TabIndex = 12
        '
        'txttensach
        '
        Me.txttensach.Location = New System.Drawing.Point(194, 146)
        Me.txttensach.Name = "txttensach"
        Me.txttensach.Size = New System.Drawing.Size(134, 22)
        Me.txttensach.TabIndex = 13
        '
        'txtsoluongton
        '
        Me.txtsoluongton.Location = New System.Drawing.Point(194, 185)
        Me.txtsoluongton.Name = "txtsoluongton"
        Me.txtsoluongton.Size = New System.Drawing.Size(134, 22)
        Me.txtsoluongton.TabIndex = 14
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(194, 234)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(134, 22)
        Me.txtdongia.TabIndex = 15
        '
        'txttacgia
        '
        Me.txttacgia.Location = New System.Drawing.Point(194, 278)
        Me.txttacgia.Name = "txttacgia"
        Me.txttacgia.Size = New System.Drawing.Size(134, 22)
        Me.txttacgia.TabIndex = 16
        '
        'cbnhaxuatban
        '
        Me.cbnhaxuatban.FormattingEnabled = True
        Me.cbnhaxuatban.Items.AddRange(New Object() {"Kim đồng", "Giáo dục", "Thanh niên", "Xây dựng", "Xuất bản trẻ"})
        Me.cbnhaxuatban.Location = New System.Drawing.Point(194, 325)
        Me.cbnhaxuatban.Name = "cbnhaxuatban"
        Me.cbnhaxuatban.Size = New System.Drawing.Size(134, 24)
        Me.cbnhaxuatban.TabIndex = 17
        '
        'cbtheloaisach
        '
        Me.cbtheloaisach.FormattingEnabled = True
        Me.cbtheloaisach.Items.AddRange(New Object() {"Tham khảo", "SGK", "Tiểu thuyết", "Hoạt hình", "Trinh thám"})
        Me.cbtheloaisach.Location = New System.Drawing.Point(192, 409)
        Me.cbtheloaisach.Name = "cbtheloaisach"
        Me.cbtheloaisach.Size = New System.Drawing.Size(136, 24)
        Me.cbtheloaisach.TabIndex = 18
        '
        'txtnamxuatban
        '
        Me.txtnamxuatban.Location = New System.Drawing.Point(194, 366)
        Me.txtnamxuatban.Name = "txtnamxuatban"
        Me.txtnamxuatban.Size = New System.Drawing.Size(134, 22)
        Me.txtnamxuatban.TabIndex = 19
        '
        'txtvitrikesach
        '
        Me.txtvitrikesach.Location = New System.Drawing.Point(194, 459)
        Me.txtvitrikesach.Name = "txtvitrikesach"
        Me.txtvitrikesach.Size = New System.Drawing.Size(134, 22)
        Me.txtvitrikesach.TabIndex = 20
        '
        'dgvSach
        '
        Me.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column9, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.dgvSach.Location = New System.Drawing.Point(416, 98)
        Me.dgvSach.Name = "dgvSach"
        Me.dgvSach.RowHeadersWidth = 51
        Me.dgvSach.RowTemplate.Height = 24
        Me.dgvSach.Size = New System.Drawing.Size(538, 289)
        Me.dgvSach.TabIndex = 0
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(460, 422)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(85, 34)
        Me.btnThem.TabIndex = 21
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsua.Location = New System.Drawing.Point(662, 422)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(85, 34)
        Me.btnsua.TabIndex = 22
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(838, 422)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(91, 34)
        Me.btnXoa.TabIndex = 23
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnLuu
        '
        Me.btnLuu.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLuu.Location = New System.Drawing.Point(460, 484)
        Me.btnLuu.Name = "btnLuu"
        Me.btnLuu.Size = New System.Drawing.Size(85, 37)
        Me.btnLuu.TabIndex = 24
        Me.btnLuu.Text = "Lưu"
        Me.btnLuu.UseVisualStyleBackColor = True
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.Location = New System.Drawing.Point(662, 484)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(85, 37)
        Me.btnHuy.TabIndex = 25
        Me.btnHuy.Text = "Hủy"
        Me.btnHuy.UseVisualStyleBackColor = True
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(838, 484)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(91, 37)
        Me.btnThoat.TabIndex = 26
        Me.btnThoat.Text = "Thoát"
        Me.btnThoat.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "masach"
        Me.Column1.HeaderText = "Mã sách"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "tensach"
        Me.Column2.HeaderText = "Tên sách"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "soluongton"
        Me.Column3.HeaderText = "Số lượng tồn"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "dongia"
        Me.Column4.HeaderText = "Đơn giá"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "tacgia"
        Me.Column9.HeaderText = "Tác giả"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 125
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "nhaxuatban"
        Me.Column5.HeaderText = "Nhà xuất bản"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "namxuatban"
        Me.Column6.HeaderText = "Năm xuất bản"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "theloaisach"
        Me.Column7.HeaderText = "Thể loại sách"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "vitrikesach"
        Me.Column8.HeaderText = "Vị trí kệ sách"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'frmquanlisach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 546)
        Me.Controls.Add(Me.btnThoat)
        Me.Controls.Add(Me.btnHuy)
        Me.Controls.Add(Me.btnLuu)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtvitrikesach)
        Me.Controls.Add(Me.txtnamxuatban)
        Me.Controls.Add(Me.cbtheloaisach)
        Me.Controls.Add(Me.cbnhaxuatban)
        Me.Controls.Add(Me.txttacgia)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtsoluongton)
        Me.Controls.Add(Me.txttensach)
        Me.Controls.Add(Me.txtmasach)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSach)
        Me.Name = "frmquanlisach"
        Me.Text = "frmSach"
        CType(Me.dgvSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtmasach As TextBox
    Friend WithEvents txttensach As TextBox
    Friend WithEvents txtsoluongton As TextBox
    Friend WithEvents txtdongia As TextBox
    Friend WithEvents txttacgia As TextBox
    Friend WithEvents cbnhaxuatban As ComboBox
    Friend WithEvents cbtheloaisach As ComboBox
    Friend WithEvents txtnamxuatban As TextBox
    Friend WithEvents txtvitrikesach As TextBox
    Friend WithEvents dgvSach As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnsua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnLuu As Button
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnThoat As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
