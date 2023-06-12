Imports System.Data.SqlClient
Public Class frmquanlisach
    Public kt As Boolean
    Public Sub SetControl(b As Boolean)
        btnThem.Enabled = b
        btnsua.Enabled = b
        btnXoa.Enabled = b
        btnLuu.Enabled = Not b
        btnHuy.Enabled = Not b
    End Sub
    Public Sub SetLock(b As Boolean)
        txtmasach.Enabled = Not b
        txttensach.Enabled = Not b

        txtsoluongton.Enabled = Not b
        txtdongia.Enabled = Not b
        txttacgia.Enabled = Not b

        cbnhaxuatban.Enabled = Not b
        txtnamxuatban.Enabled = Not b
        cbtheloaisach.Enabled = Not b
        txtvitrikesach.Enabled = Not b
    End Sub


    Private Sub frmSach_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MoKetNoi()
        MsgBox(conn.State.ToString())
        sql = "select * from quanlisach"
        LoadDataGridView(dgvSach, sql)
        SetControl(True)
        SetLock(True)
    End Sub

    Private Sub dgvSach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSach.CellContentClick

        If dgvSach.RowCount <= 0 Then Exit Sub
        If e.RowIndex >= 0 Then
            Dim dong As Integer
            dong = dgvSach.CurrentCell.RowIndex
            txtmasach.Text = dgvSach.Rows(dong).Cells(0).Value
            txttensach.Text = dgvSach.Rows(dong).Cells(1).Value
            txtsoluongton.Text = dgvSach.Rows(dong).Cells(2).Value
            txtdongia.Text = dgvSach.Rows(dong).Cells(3).Value
            txttacgia.Text = dgvSach.Rows(dong).Cells(4).Value
            cbnhaxuatban.Text = dgvSach.Rows(dong).Cells(5).Value
            txtnamxuatban.Text = dgvSach.Rows(dong).Cells(6).Value
            cbtheloaisach.Text = dgvSach.Rows(dong).Cells(7).Value
            txtvitrikesach.Text = dgvSach.Rows(dong).Cells(8).Value
            '`                                                                                                                                                                          Dim masach As String = dgvSach.Rows(dong).Cells(5).Value.ToString()
            'sql = "select * From quanlisach where masach='" & masach & "'"
            'Dim dasach As DataTable
            'dasach = LoadDuLieu(sql)
            'txtmasach.Text = dasach.Rows(0).Item("masach").ToString()
        End If

    End Sub



    Private Sub btnThoat_Click(sender As Object, e As EventArgs) Handles btnThoat.Click
        Dim traloi As DialogResult
        traloi = MessageBox.Show("Có chắc đóng không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (traloi = DialogResult.OK) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click

        kt = True
        SetControl(False)
        SetLock(False)
        txtmasach.Text = ""
        txttensach.Text = ""
        txtsoluongton.Text = ""
        txtdongia.Text = ""
        txtnamxuatban.Text = ""
        cbtheloaisach.Text = ""
        cbnhaxuatban.Text = ""
        txtvitrikesach.Text = ""

    End Sub

    ' Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click'
    '    On Error GoTo SaveErr
    '        dgvSach.DataSource.save()
    '        MessageBox.Show("Thành công!")
    'SaveErr: Exit Sub
    '    End Sub
    'Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
    '    If txtmasach.Text = "" Then
    '        MsgBox("Bạn chưa chọn bản ghi cần xóa")
    '        Exit Sub
    '    End If
    '    'MoKetNoi()
    '    Dim traloi As DialogResult
    'End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtmasach.Text = "" Then
            MsgBox("Bạn chưa chọn bản ghi cần xóa")
            Exit Sub
        End If
        'MoKetNoi()
        Dim traloi As DialogResult
        traloi = MessageBox.Show("Có chắc xóa không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If (traloi = DialogResult.Cancel) Then Exit Sub
        Try
            command = New SqlClient.SqlCommand()
            command.Connection = conn
            command.CommandType = CommandType.Text
            Dim r As Integer = dgvSach.CurrentCell.RowIndex
            Dim ma As String = dgvSach.Rows(r).Cells(0).Value.ToString()
            sql = "delete from quanlisach where masach='" + ma + "'"
            command.CommandText = sql
            command.ExecuteNonQuery()
            LoadDataGridView(dgvSach, "Select * From quanlisach")
            MessageBox.Show("Đã xóa thành công")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        'DongKetNoi()
    End Sub



    Private Sub btnLuu_Click(sender As Object, e As EventArgs) Handles btnLuu.Click
        ' conn.Open()
        'MoKetNoi()

        If txtmasach.Text = "" Then
            MsgBox("Cần nhập thông tin")
            txtmasach.Focus()
            Exit Sub
        End If
        If txttensach.Text = "" Then
            MsgBox("Cần nhập thông tin")
            txttensach.Focus()
            Exit Sub
        End If
        If txtdongia.Text = "" Then
            MsgBox("Cần nhập thông tin")
            txtdongia.Focus()
            Exit Sub
        End If
        If txttacgia.Text = "" Then
            MsgBox("Cần nhập thông tin")
            txttacgia.Focus()
            Exit Sub
        End If
        If cbnhaxuatban.Text = "" Then
            MsgBox("Cần nhập thông tin")
            cbnhaxuatban.Focus()
            Exit Sub
        End If
        If txtnamxuatban.Text = "" Then
            MsgBox("Cần nhập thông tin")
            txtnamxuatban.Focus()
            Exit Sub
        End If
        If cbtheloaisach.Text = "" Then
            MsgBox("Chưa nhập thông tin")
            cbtheloaisach.Focus()
            Exit Sub
        End If
        If txtvitrikesach.Text = "" Then
            MsgBox("Chưa nhập thông tin")
            txtvitrikesach.Focus()
            Exit Sub
        End If

        If kt Then
            sql = "select count(*) from quanlisach where masach='" & txtmasach.Text & "'"
            command = New SqlClient.SqlCommand(sql, conn)
            Dim count As Integer
            count = command.ExecuteScalar()
            If count > 0 Then
                MsgBox("mã sách đã tồn tại")
                Exit Sub
            End If
            sql = "insert into quanlisach values (@masach,@tensach,@soluongton,@dongia,@tacgia,@nhaxuatban,@namxuatban,@theloaisach,@vitrikesach)"
        Else
            sql = "update quanlisach set tensach=@tensach,soluongton=@soluongton,dongia=@dongia,tacgia=@tacgia,nhaxuatban=@nhaxuatban,namxuatban=@namxuatban,theloaisach=@theloaisach,vitrikesach=@vitrikesach where masach=@masach  "
        End If
        Try
            command = New SqlClient.SqlCommand(sql, conn)
            command.Parameters.AddWithValue("@masach", txtmasach.Text)
            command.Parameters.AddWithValue("@tensach", txttensach.Text)
            command.Parameters.AddWithValue("@soluongton", txtsoluongton.Text)
            command.Parameters.AddWithValue("@dongia", txtdongia.Text)
            command.Parameters.AddWithValue("@tacgia", txttacgia.Text)
            command.Parameters.AddWithValue("@nhaxuatban", cbnhaxuatban.Text)
            command.Parameters.AddWithValue("@namxuatban", txtnamxuatban.Text)
            command.Parameters.AddWithValue("@theloaisach", cbtheloaisach.Text)
            command.Parameters.AddWithValue("@vitrikesach", txtvitrikesach.Text)
            command.ExecuteNonQuery()

            LoadDataGridView(dgvSach, "select * from quanlisach ")
            MessageBox.Show("Đã cập nhật thành công")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SetControl(True)
        SetLock(True)
    End Sub

    Private Sub btnHuy_Click(sender As Object, e As EventArgs) Handles btnHuy.Click
        txtmasach.ResetText()
        txttensach.ResetText()
        txtsoluongton.ResetText()
        txtdongia.ResetText()
        cbnhaxuatban.ResetText()
        txtnamxuatban.ResetText()
        cbtheloaisach.ResetText()
        txtvitrikesach.ResetText()
        SetControl(True)
        SetLock(True)


    End Sub


    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        If txtmasach.Text = "" Then
            MsgBox("Bạn chưa chọn bản ghi cần sửa")
            Exit Sub
        End If
        kt = False
        SetLock(False)
        SetControl(False)
        txtmasach.Focus()
        txtmasach.Enabled = False
    End Sub

End Class