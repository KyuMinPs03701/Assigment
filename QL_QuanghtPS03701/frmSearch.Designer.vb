<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.lblTimKiem = New System.Windows.Forms.Label()
        Me.cmbTimKiem = New System.Windows.Forms.ComboBox()
        Me.txtTimKiem = New System.Windows.Forms.TextBox()
        Me.dgvxem = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NhạcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThoátToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvxem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTimKiem
        '
        Me.lblTimKiem.AutoSize = True
        Me.lblTimKiem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTimKiem.Image = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.lblTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTimKiem.Location = New System.Drawing.Point(12, 37)
        Me.lblTimKiem.Name = "lblTimKiem"
        Me.lblTimKiem.Size = New System.Drawing.Size(60, 13)
        Me.lblTimKiem.TabIndex = 0
        Me.lblTimKiem.Text = "Danh Mục:"
        '
        'cmbTimKiem
        '
        Me.cmbTimKiem.FormattingEnabled = True
        Me.cmbTimKiem.Items.AddRange(New Object() {"Mã DVD", "Mã thể loại", "Tên DVD", "Nội dung", "Đơn giá"})
        Me.cmbTimKiem.Location = New System.Drawing.Point(78, 34)
        Me.cmbTimKiem.Name = "cmbTimKiem"
        Me.cmbTimKiem.Size = New System.Drawing.Size(121, 21)
        Me.cmbTimKiem.TabIndex = 1
        '
        'txtTimKiem
        '
        Me.txtTimKiem.Location = New System.Drawing.Point(205, 34)
        Me.txtTimKiem.Name = "txtTimKiem"
        Me.txtTimKiem.Size = New System.Drawing.Size(319, 20)
        Me.txtTimKiem.TabIndex = 2
        '
        'dgvxem
        '
        Me.dgvxem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxem.Location = New System.Drawing.Point(12, 61)
        Me.dgvxem.Name = "dgvxem"
        Me.dgvxem.Size = New System.Drawing.Size(512, 259)
        Me.dgvxem.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SảnPhẩmToolStripMenuItem, Me.NhạcToolStripMenuItem, Me.ThoátToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(540, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.star_10
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Sản phẩm"
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
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.funny_law_wallpaper_1366x768
        Me.ClientSize = New System.Drawing.Size(540, 332)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgvxem)
        Me.Controls.Add(Me.txtTimKiem)
        Me.Controls.Add(Me.cmbTimKiem)
        Me.Controls.Add(Me.lblTimKiem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearch"
        Me.Text = "Tìm kiếm"
        CType(Me.dgvxem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTimKiem As Label
    Friend WithEvents cmbTimKiem As ComboBox
    Friend WithEvents txtTimKiem As TextBox
    Friend WithEvents dgvxem As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NhạcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThoátToolStripMenuItem As ToolStripMenuItem
End Class
