Public Class DangNhap
    Private Sub ok_Click(sender As Object, e As EventArgs) Handles ok.Click
        If user.Text = "" Or pass.Text = "" Then
            MsgBox("Bạn chưa nhập tên đăng nhập hoặc mật khẩu")
        Else
            If user.Text = "Nguyen Thai" And pass.Text = "2621210441" Then
                MsgBox("Đăng nhập thành công!")
                Dim lienket As Form1 = New Form1
                lienket.Show()
            Else
                MessageBox.Show("Đăng nhập thất bại")
            End If
        End If
    End Sub

    Private Sub user_GotFocus(sender As Object, e As EventArgs) Handles user.GotFocus
        If user.Text = "Nhập Email hoặc số điện thoại" Then user.Text = ""
    End Sub
    Private Sub user_LostFocus(sender As Object, e As EventArgs) Handles user.LostFocus
        If user.Text = "" Then user.Text = "Nhập Email hoặc số điện thoại"
    End Sub

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Dim hoi As Integer
        hoi = MsgBox("Bạn có chắc chắn muốn thoát không?", vbYesNo, "Nguyễn Văn Thái")
        If hoi = vbYes Then
            Close()
        Else
            Enabled = True
        End If
    End Sub

    Private Sub DangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class