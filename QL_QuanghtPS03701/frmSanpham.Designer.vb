<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSanpham
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSanpham))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMaDVD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaTL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTenDVD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.txtNoiDung = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnCapnhat = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TìmKiếmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhạcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Image = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(13, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã DVD:"
        '
        'txtMaDVD
        '
        Me.txtMaDVD.Location = New System.Drawing.Point(70, 37)
        Me.txtMaDVD.Name = "txtMaDVD"
        Me.txtMaDVD.Size = New System.Drawing.Size(149, 20)
        Me.txtMaDVD.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Image = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mã TL:"
        '
        'txtMaTL
        '
        Me.txtMaTL.Location = New System.Drawing.Point(70, 63)
        Me.txtMaTL.Name = "txtMaTL"
        Me.txtMaTL.Size = New System.Drawing.Size(149, 20)
        Me.txtMaTL.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Image = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.Location = New System.Drawing.Point(13, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tên DVD:"
        '
        'txtTenDVD
        '
        Me.txtTenDVD.Location = New System.Drawing.Point(70, 89)
        Me.txtTenDVD.Name = "txtTenDVD"
        Me.txtTenDVD.Size = New System.Drawing.Size(149, 20)
        Me.txtTenDVD.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Image = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label5.Location = New System.Drawing.Point(232, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Đơn giá:"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(291, 63)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(100, 20)
        Me.txtDonGia.TabIndex = 1
        '
        'txtNoiDung
        '
        Me.txtNoiDung.Location = New System.Drawing.Point(291, 89)
        Me.txtNoiDung.Name = "txtNoiDung"
        Me.txtNoiDung.Size = New System.Drawing.Size(239, 20)
        Me.txtNoiDung.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Image = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Location = New System.Drawing.Point(232, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nội dung:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 145)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(518, 280)
        Me.DataGridView1.TabIndex = 4
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(70, 116)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(75, 23)
        Me.btnThem.TabIndex = 5
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(161, 116)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 5
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(291, 116)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 5
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnCapnhat
        '
        Me.btnCapnhat.Location = New System.Drawing.Point(382, 116)
        Me.btnCapnhat.Name = "btnCapnhat"
        Me.btnCapnhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapnhat.TabIndex = 5
        Me.btnCapnhat.Text = "Cập nhật"
        Me.btnCapnhat.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources._2892546_Logo_FPT_Polytehnic_doc
        Me.PictureBox1.Location = New System.Drawing.Point(397, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TìmKiếmToolStripMenuItem, Me.NhạcToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(544, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TìmKiếmToolStripMenuItem
        '
        Me.TìmKiếmToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Clone_Trooper
        Me.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem"
        Me.TìmKiếmToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.TìmKiếmToolStripMenuItem.Text = "Tìm kiếm"
        '
        'NhạcToolStripMenuItem
        '
        Me.NhạcToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.google_chrome_icon___ico_file__by_speetix_d5pfs39
        Me.NhạcToolStripMenuItem.Name = "NhạcToolStripMenuItem"
        Me.NhạcToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.NhạcToolStripMenuItem.Text = "Nhạc"
        '
        'ThoátToolStripMenuItem
        '
        Me.ThoátToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.door
        Me.ThoátToolStripMenuItem.Name = "ThoátToolStripMenuItem"
        Me.ThoátToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ThoátToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ThoátToolStripMenuItem.Text = "Thoát"
        '
        'frmSanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(544, 433)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCapnhat)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNoiDung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTenDVD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaTL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMaDVD)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSanpham"
        Me.Text = "Sản phẩm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtMaDVD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMaTL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTenDVD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents txtNoiDung As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapnhat As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TìmKiếmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhạcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class
