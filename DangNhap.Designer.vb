<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DangNhap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DangNhap))
        Me.user = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ok = New System.Windows.Forms.Button()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.Silver
        Me.user.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(317, 154)
        Me.user.Multiline = True
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(242, 33)
        Me.user.TabIndex = 0
        Me.user.Text = "Nhập Email hoặc số điện thoại"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(509, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Đăng Nhập Hệ Thống Quản Lí Sinh Viên"
        '
        'ok
        '
        Me.ok.BackColor = System.Drawing.Color.Black
        Me.ok.FlatAppearance.BorderSize = 2
        Me.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ok.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ok.ForeColor = System.Drawing.Color.White
        Me.ok.Location = New System.Drawing.Point(228, 301)
        Me.ok.Name = "ok"
        Me.ok.Size = New System.Drawing.Size(101, 37)
        Me.ok.TabIndex = 2
        Me.ok.Text = "OK"
        Me.ok.UseVisualStyleBackColor = False
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.Silver
        Me.pass.Location = New System.Drawing.Point(317, 206)
        Me.pass.Multiline = True
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(242, 29)
        Me.pass.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tên Đăng Nhập"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(161, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mật Khẩu"
        '
        'cancel
        '
        Me.cancel.BackColor = System.Drawing.Color.Black
        Me.cancel.FlatAppearance.BorderSize = 2
        Me.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Location = New System.Drawing.Point(373, 301)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(106, 37)
        Me.cancel.TabIndex = 6
        Me.cancel.Text = "Cancel"
        Me.cancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quan_li_sinh_vien.My.Resources.Resources.HUBT
        Me.PictureBox1.Location = New System.Drawing.Point(496, 241)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(270, 210)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(121, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(551, 87)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'DangNhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.user)
        Me.Name = "DangNhap"
        Me.Text = "DangNhap"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ok As Button
    Friend WithEvents pass As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cancel As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
