Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmSanpham
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=quanghtps03701.mssql.somee.com;packet size=4096;user id=shinoha_SQLLogin_1;pwd=1234@abc;data source=quanghtps03701.mssql.somee.com;persist security info=False;initial catalog=quanghtps03701"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub btnThem_Click(sender As Object, e As EventArgs) Handles btnThem.Click
        reset()
    End Sub
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MADVD as 'Mã DVD' , MA_TL as 'Mã thể loại',TENDVD as 'Tên DVD', NOIDUNG as 'Nội dung', DONGIA as 'Đơn giá' from DVD", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub frmSanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
    Private Sub reset()
        txtMaDVD.Text = ""
        txtMaTL.Text = ""
        txtTenDVD.Text = ""
        txtNoiDung.Text = ""
        txtDonGia.Text = ""
        txtMaDVD.Focus()
    End Sub
    Private Sub btnCapnhat_Click(sender As Object, e As EventArgs) Handles btnCapnhat.Click
        If txtMaDVD.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã DVD")
            txtMaDVD.Focus()
        ElseIf txtMaTL.Text = "" Then
            MessageBox.Show("Bạn chưa nhập mã thể loại DVD")
            txtMaTL.Focus()
        ElseIf txtTenDVD.Text = "" Then
            MessageBox.Show("Bạn chưa nhập tên DVD")
            txtTenDVD.Focus()
        ElseIf txtNoiDung.Text = "" Then
            MessageBox.Show("Bạn chưa nhập nội dung")
            txtNoiDung.Focus()
        ElseIf txtDonGia.Text = "" Then
            MessageBox.Show("Bạn chưa nhập đơn giá")
            txtDonGia.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into DVD values(@MADVD,@MATL,@TENDVD,@NOIDUNG,@DONGIA)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MADVD", txtMaDVD.Text)
            save.Parameters.AddWithValue("@MATL", txtMaTL.Text)
            save.Parameters.AddWithValue("@TENDVD", txtTenDVD.Text)
            save.Parameters.AddWithValue("@NOIDUNG", txtNoiDung.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Cập nhật thành công")
            LoadData()
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        If txtMaDVD.Text = "" Then
            MessageBox.Show("Nhập mã DVD cần xóa")
            txtMaDVD.Focus()
        Else
            Dim delquery As String = "delete from DVD where MaDVD=@MADVD"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        If btnSua.Text = "Sửa" Then
            txtMaDVD.ReadOnly = True
            btnSua.Text = "Update"
            txtTenDVD.Focus()
        ElseIf btnSua.Text = "Update" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update DVD set Ma_TL=@MATL, TENDVD=@TENDVD, DONGIA=@DONGIA, NOIDUNG=@NOIDUNG where MADVD=@MADVD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MADVD", txtMaDVD.Text)
            save.Parameters.AddWithValue("@MATL", txtMaTL.Text)
            save.Parameters.AddWithValue("@TENDVD", txtTenDVD.Text)
            save.Parameters.AddWithValue("@NOIDUNG", txtNoiDung.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMaDVD.ReadOnly = False
            btnSua.Text = "Sửa"
            LoadData()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMaDVD.Text = DataGridView1.Item(0, click).Value
        txtMaTL.Text = DataGridView1.Item(1, click).Value
        txtTenDVD.Text = DataGridView1.Item(2, click).Value
        txtNoiDung.Text = DataGridView1.Item(3, click).Value
        txtDonGia.Text = DataGridView1.Item(4, click).Value
    End Sub

    Private Sub TìmKiếmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TìmKiếmToolStripMenuItem.Click
        frmSearch.Show()
    End Sub

    Private Sub NhạcToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NhạcToolStripMenuItem.Click
        frmMedia.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThoátToolStripMenuItem.Click
        Close()
    End Sub
End Class