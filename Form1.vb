Public Class Form1
    Private Sub loaddata()
        OleDbDataAdapter1.Fill(DataSet1)
        OleDbDataAdapter2.Fill(DataSet11)
        OleDbDataAdapter3.Fill(DataSet12)
        OleDbDataAdapter4.Fill(DataSet13)
        OleDbDataAdapter5.Fill(DataSet14)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet14.DM_DiemHocPhan' table. You can move, or remove it, as needed.
        Me.DM_DiemHocPhanTableAdapter.Fill(Me.DataSet14.DM_DiemHocPhan)
        'TODO: This line of code loads data into the 'DataSet13.DM_HocPhan' table. You can move, or remove it, as needed.
        Me.DM_HocPhanTableAdapter.Fill(Me.DataSet13.DM_HocPhan)
        'TODO: This line of code loads data into the 'DataSet12.DM_SinhVien' table. You can move, or remove it, as needed.
        Me.DM_SinhVienTableAdapter.Fill(Me.DataSet12.DM_SinhVien)
        'TODO: This line of code loads data into the 'DataSet11.DM_Lop' table. You can move, or remove it, as needed.
        Me.DM_LopTableAdapter.Fill(Me.DataSet11.DM_Lop)
        'TODO: This line of code loads data into the 'DataSet1.DM_Khoa' table. You can move, or remove it, as needed.
        Me.DM_KhoaTableAdapter.Fill(Me.DataSet1.DM_Khoa)

        loaddata()
    End Sub
    Private Sub btDMKhoa_Click(sender As Object, e As EventArgs) Handles btDMKhoa.Click
        pnDMKhoa.Visible = True
        pnDMLop.Visible = False
        pnDMSV.Visible = False
        pnDMHocPhan.Visible = False
        pnDMDHP.Visible = False
    End Sub
    Private Sub btDMLop_Click(sender As Object, e As EventArgs) Handles btDMLop.Click
        pnDMKhoa.Visible = False
        pnDMLop.Visible = True
        pnDMSV.Visible = False
        pnDMHocPhan.Visible = False
        pnDMDHP.Visible = False
    End Sub
    Private Sub btDMSV_Click(sender As Object, e As EventArgs) Handles btDMSV.Click
        pnDMKhoa.Visible = False
        pnDMLop.Visible = False
        pnDMSV.Visible = True
        pnDMHocPhan.Visible = False
        pnDMDHP.Visible = False
    End Sub
    Private Sub btDMHP_Click(sender As Object, e As EventArgs) Handles btDMHP.Click
        pnDMKhoa.Visible = False
        pnDMLop.Visible = False
        pnDMSV.Visible = False
        pnDMHocPhan.Visible = True
        pnDMDHP.Visible = False
    End Sub
    Private Sub btDMDHP_Click(sender As Object, e As EventArgs) Handles btDMDHP.Click
        pnDMKhoa.Visible = False
        pnDMLop.Visible = False
        pnDMSV.Visible = False
        pnDMHocPhan.Visible = False
        pnDMDHP.Visible = True
    End Sub

    Private Sub btThemDMKhoa_Click(sender As Object, e As EventArgs) Handles btThemDMKhoa.Click
        If txtMaKhoaDMK.Text = "" Then
            MsgBox("Mã Khoa không được để trống")
        Else
            Try
                OleDbConnection1.Open()
                Dim sql As String = "INSERT INTO DM_Khoa
                  (MaKhoa, TenKhoa)
VALUES (N'" & txtMaKhoaDMK.Text & "',N'" & txtTenKhoaDMK.Text & "')"
                OleDbInsertCommand1.CommandText = sql
                OleDbInsertCommand1.ExecuteNonQuery()
                DataSet1.Clear()
                OleDbConnection1.Close()
                loaddata()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub
    Private Sub btThemDMLop_Click(sender As Object, e As EventArgs) Handles btThemDMLop.Click
        If txtMaLopDML.Text = "" Then
            MsgBox("Mã Lớp không được để trống")
        Else
            Try
                OleDbConnection1.Open()
                Dim sql As String = "INSERT INTO DM_Lop
                  (MaLop, TenLop, MaKhoa, KhoaHoc, HeDaoTao, NamNhapHoc)
VALUES (N'" & txtMaLopDML.Text & "',N'" & txtTenLopDML.Text & "',N'" & txtMaKhoaDML.Text & "',N'" & txtKhoaHocDML.Text & "',N'" & txtHeDTDML.Text & "',N'" & txtNamNhapHocDML.Text & "')"
                OleDbInsertCommand2.CommandText = sql
                OleDbInsertCommand2.ExecuteNonQuery()
                DataSet11.Clear()
                OleDbConnection1.Close()
                loaddata()
            Catch ex As Exception
                MessageBox.Show("Mã Lớp đã tồn tại! Xin hãy nhập Mã Lớp Khác!")
            End Try
        End If
    End Sub
    Private Sub btThemDMSV_Click(sender As Object, e As EventArgs) Handles btThemDMSV.Click
        Dim gt As String = ""
        If rbNam.Checked = True Then
            gt = "Nam"
        Else
            rbNu.Checked = True
            gt = "Nữ"
        End If
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO DM_SinhVien
                  (MaSinhVien, HoTen, MaKhoa, GioiTinh, NgaySinh, DiaChi)
VALUES (N'" & txtMaSVDMSV.Text & "',N'" & txtHoTenDMSV.Text & "',N'" & txtMaKhoaDMSV.Text & "',N'" & gt & "',N'" & txtNgaySinhDMSV.Text & "',N'" & txtDiaChiDMSV.Text & "')"
            OleDbInsertCommand3.CommandText = sql
            OleDbInsertCommand3.ExecuteNonQuery()
            DataSet12.Clear()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btThemDMHP_Click(sender As Object, e As EventArgs) Handles btThemDMHP.Click
        If txtMaHPDMHP.Text = "" Then
            MsgBox("Mã Học Phần không được để trống")
        Else
            Try
                OleDbConnection1.Open()
                Dim sql As String = "INSERT INTO DM_HocPhan
                  (MaHocPhan, TenHocPhan, SoTinChi, MaKhoa, HocKy)
VALUES (N'" & txtMaHPDMHP.Text & "',N'" & txtTenHPDMHP.Text & "',N'" & txtSoTCDMHP.Text & "',N'" & txtMaKhoaDMHP.Text & "',N'" & txtHocKyDMHP.Text & "')"
                OleDbInsertCommand4.CommandText = sql
                OleDbInsertCommand4.ExecuteNonQuery()
                DataSet13.Clear()
                OleDbConnection1.Close()
                loaddata()
            Catch ex As Exception
                MessageBox.Show("Mã Học Phần đã tồn tại! Xin hãy nhập Mã Học Phần Khác!")
            End Try
        End If
    End Sub

    Private Sub btThemDMDHP_Click(sender As Object, e As EventArgs) Handles btThemDMDHP.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "INSERT INTO DM_DiemHocPhan
                  (MaSinhVien, MaHocPhan, DiemHocPhan)
VALUES (N'" & txtMaSVDMDHP.Text & "',N'" & txtMaHPDMDHP.Text & "',N'" & txtDiemHPDMDHP.Text & "')"
            OleDbInsertCommand5.CommandText = sql
            OleDbInsertCommand5.ExecuteNonQuery()
            DataSet14.Clear()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MessageBox.Show("Mã Sinh Viên đã tồn tại! Xin hãy nhập Mã Sinh Viên Khác!")
        End Try
    End Sub

    Private Sub btSuaDMKhoa_Click(sender As Object, e As EventArgs) Handles btSuaDMKhoa.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE DM_Khoa
SET          MaKhoa = N'" & txtMaKhoaDMK.Text & "', TenKhoa = N'" & txtTenKhoaDMK.Text & "'
WHERE  MaKhoa = N'" & txtMaKhoaDMK.Text & "'"
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            DataSet1.Clear()
            loaddata()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btSuaDMLop_Click(sender As Object, e As EventArgs) Handles btSuaDMLop.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [DM_Lop]
SET          [MaLop] = N'" & txtMaLopDML.Text & "', [TenLop] = N'" & txtTenLopDML.Text & "', [MaKhoa] = N'" & txtMaKhoaDML.Text & "', [KhoaHoc] = N'" & txtKhoaHocDML.Text & "', [HeDaoTao] = N'" & txtHeDTDML.Text & "', [NamNhapHoc] = N'" & txtNamNhapHocDML.Text & "'
WHERE  [MaLop] =N'" & txtMaLopDML.Text & "'"
            OleDbUpdateCommand2.CommandText = sql
            OleDbUpdateCommand2.ExecuteNonQuery()
            DataSet11.Clear()
            loaddata()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btSuaDMSV_Click(sender As Object, e As EventArgs) Handles btSuaDMSV.Click
        Dim gt As String = ""
        If rbNam.Checked = True Then
            gt = "Nam"
        Else
            rbNu.Checked = True
            gt = "Nữ"
        End If
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE DM_SinhVien
SET          MaSinhVien = N'" & txtMaSVDMSV.Text & "', HoTen = N'" & txtHoTenDMSV.Text & "',MaKhoa=N'" & txtMaKhoaDMSV.Text & "',GioiTinh=N'" & gt & "',NgaySinh=N'" & txtNgaySinhDMSV.Text & "',DiaChi=N'" & txtDiaChiDMSV.Text & "'
WHERE  MaSinhVien = N'" & txtMaSVDMSV.Text & "'"
            OleDbInsertCommand3.CommandText = sql
            OleDbInsertCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet12.Clear()
            OleDbConnection1.Close()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btSuaDMHP_Click(sender As Object, e As EventArgs) Handles btSuaDMHP.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [DM_HocPhan]
SET          [MaHocPhan] =N'" & txtMaHPDMHP.Text & "', [TenHocPhan] = N'" & txtTenHPDMHP.Text & "', [SoTinChi] = N'" & txtSoTCDMHP.Text & "', [MaKhoa] = N'" & txtMaKhoaDMHP.Text & "', [HocKy] = N'" & txtHocKyDMHP.Text & "'
WHERE  [MaHocPhan] = N'" & txtMaHPDMHP.Text & "' "
            OleDbInsertCommand4.CommandText = sql
            OleDbInsertCommand4.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet13.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btSuaDMDHP_Click(sender As Object, e As EventArgs) Handles btSuaDMDHP.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "UPDATE [DM_DiemHocPhan]
SET          [MaSinhVien] =N'" & txtMaSVDMDHP.Text & "', [MaHocPhan] = N'" & txtMaHPDMDHP.Text & "', [DiemHocPhan] = N'" & txtDiemHPDMDHP.Text & "'
WHERE  [MaSinhVien] = N'" & txtMaSVDMDHP.Text & "'"
            OleDbInsertCommand5.CommandText = sql
            OleDbInsertCommand5.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet14.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btXoaDMKhoa_Click(sender As Object, e As EventArgs) Handles btXoaDMKhoa.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM DM_Khoa
WHERE  MaKhoa = N'" & txtMaKhoaDMK.Text & "' "
            OleDbInsertCommand1.CommandText = sql
            OleDbInsertCommand1.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet1.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoaDMLop_Click(sender As Object, e As EventArgs) Handles btXoaDMLop.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [DM_Lop]
WHERE  [MaLop] =N'" & txtMaLopDML.Text & "'"
            OleDbInsertCommand2.CommandText = sql
            OleDbInsertCommand2.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet11.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoaDMSV_Click(sender As Object, e As EventArgs) Handles btXoaDMSV.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = " DELETE FROM DM_SinhVien
WHERE  MaSinhVien = N'" & txtMaSVDMSV.Text & "'"
            OleDbInsertCommand3.CommandText = sql
            OleDbInsertCommand3.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet12.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btXoaDMHP_Click(sender As Object, e As EventArgs) Handles btXoaDMHP.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [DM_HocPhan]
WHERE  [MaHocPhan] = N'" & txtMaHPDMHP.Text & "'"
            OleDbInsertCommand4.CommandText = sql
            OleDbInsertCommand4.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet13.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub btXoaDMDHP_Click(sender As Object, e As EventArgs) Handles btXoaDMDHP.Click
        Try
            OleDbConnection1.Open()
            Dim sql As String = "DELETE FROM [DM_DiemHocPhan]
WHERE  [MaSinhVien] = N'" & txtMaSVDMDHP.Text & "'"
            OleDbInsertCommand5.CommandText = sql
            OleDbInsertCommand5.ExecuteNonQuery()
            OleDbConnection1.Close()
            DataSet14.Clear()
            loaddata()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btTimKiemDMKhoa_Click(sender As Object, e As EventArgs) Handles btTimKiemDMKhoa.Click
        OleDbConnection1.Open()
        Dim sql As String = "SELECT MaKhoa, TenKhoa
FROM     DM_Khoa
Where MaKhoa=N'" & txtMaKhoaDMK.Text & "'"

        OleDbSelectCommand1.CommandText = sql
        OleDbSelectCommand1.ExecuteNonQuery()
        DataSet1.Clear()
        loaddata()
        OleDbConnection1.Close()
        loaddata()
    End Sub

    Private Sub btTimKiemDMLop_Click(sender As Object, e As EventArgs) Handles btTimKiemDMLop.Click
        OleDbConnection1.Open()
        Dim sql As String = "SELECT MaLop, TenLop, MaKhoa, KhoaHoc, HeDaoTao, NamNhapHoc
FROM     DM_Lop
Where MaLop=N'" & txtMaLopDML.Text & "'"

        OleDbSelectCommand2.CommandText = sql
        OleDbSelectCommand2.ExecuteNonQuery()
        DataSet11.Clear()
        loaddata()
        OleDbConnection1.Close()
        loaddata()
    End Sub
    Private Sub btTimKiemDMSV_Click(sender As Object, e As EventArgs) Handles btTimKiemDMSV.Click
        Dim gt As String = ""
        If rbNam.Checked = True Then
            gt = "Nam"
        Else
            rbNu.Checked = True
            gt = "Nữ"
        End If
        OleDbConnection1.Open()
        Dim sql As String = "SELECT MaSinhVien, HoTen, MaKhoa, GioiTinh, NgaySinh, DiaChi
FROM     DM_SinhVien
where MaSinhVien=N'" & txtMaSVDMSV.Text & "'"
        OleDbSelectCommand3.CommandText = sql
        OleDbSelectCommand3.ExecuteNonQuery()
        DataSet12.Clear()
        loaddata()
        OleDbConnection1.Close()
        loaddata()
    End Sub

    Private Sub btTimKiemDMHP_Click(sender As Object, e As EventArgs) Handles btTimKiemDMHP.Click
        OleDbConnection1.Open()
        Dim sql As String = "SELECT MaHocPhan, TenHocPhan, SoTinChi, MaKhoa, HocKy
FROM     DM_HocPhan
Where MaHocPhan=N'" & txtMaHPDMHP.Text & "'"

        OleDbSelectCommand4.CommandText = sql
        OleDbSelectCommand4.ExecuteNonQuery()
        DataSet13.Clear()
        loaddata()
        OleDbConnection1.Close()
        loaddata()
    End Sub
    Private Sub btTimKiemDMDHP_Click(sender As Object, e As EventArgs) Handles btTimKiemDMDHP.Click

        OleDbConnection1.Open()
        Dim sql As String = "SELECT MaSinhVien, MaHocPhan, DiemHocPhan
FROM     DM_DiemHocPhan
where MaSinhVien=N'" & txtMaSVDMDHP.Text & "'"

        OleDbSelectCommand5.CommandText = sql
        OleDbSelectCommand5.ExecuteNonQuery()
        DataSet14.Clear()
        loaddata()
        OleDbConnection1.Close()
        loaddata()
    End Sub


    Private Sub btThoatDMKhoa_Click(sender As Object, e As EventArgs) Handles btThoatDMKhoa.Click
        Dim hoi As Integer
        hoi = MsgBox("BAN CO CHAC CHAN MUON THOAT KHONG?", vbYesNo, " Nhom 3 TH26.14 ^-^ ")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub
    Private Sub btThoatDMLop_Click(sender As Object, e As EventArgs) Handles btThoatDMLop.Click
        Dim hoi As Integer
        hoi = MsgBox("BAN CO CHAC CHAN MUON THOAT KHONG?", vbYesNo, " Nhom 3 TH26.14 ^-^ ")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub
    Private Sub btThoatDMSV_Click(sender As Object, e As EventArgs) Handles btThoatDMSV.Click
        Dim hoi As Integer
        hoi = MsgBox("BAN CO CHAC CHAN MUON THOAT KHONG?", vbYesNo, " Nhom 3 TH26.14 ^-^ ")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub

    Private Sub btThoatDMHP_Click(sender As Object, e As EventArgs) Handles btThoatDMHP.Click
        Dim hoi As Integer
        hoi = MsgBox("BAN CO CHAC CHAN MUON THOAT KHONG?", vbYesNo, " Nhom 3 TH26.14 ^-^ ")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub
    Private Sub btThoatDMDHP_Click(sender As Object, e As EventArgs) Handles btThoatDMDHP.Click
        Dim hoi As Integer
        hoi = MsgBox("BAN CO CHAC CHAN MUON THOAT KHONG?", vbYesNo, " Nhom 3 TH26.14 ^-^ ")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub

End Class
