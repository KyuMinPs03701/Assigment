Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmSearch
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=quanghtps03701.mssql.somee.com;packet size=4096;user id=shinoha_SQLLogin_1;pwd=1234@abc;data source=quanghtps03701.mssql.somee.com;persist security info=False;initial catalog=quanghtps03701"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    'Load Dữ Liệu Tìm Kiếm
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataTimKiem()
    End Sub
    Private Sub LoadDataTimKiem()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MADVD as 'Mã DVD' , MA_TL as 'Mã thể loại',TENDVD as 'Tên DVD', NOIDUNG as 'Nội dung', DONGIA as 'Đơn giá' from DVD", conn)
        db.Clear()
        refesh.Fill(db)
        dgvxem.DataSource = db.DefaultView
        conn.Close()
    End Sub
    'Định Nghĩa hàm Tìm Kiếm
    Private Sub txtTimKiem_TextChanged(sender As Object, e As EventArgs) Handles txtTimKiem.TextChanged
        SearchSanPham(txtTimKiem.Text)
    End Sub
    Private Sub SearchSanPham(value As String)
        Dim sqlQuery As String = String.Format("select MADVD as 'Mã DVD' , MA_TL as 'Mã thể loại',TENDVD as 'Tên DVD', NOIDUNG as 'Nội dung', DONGIA as 'Đơn giá' from DVD")
        If cmbTimKiem.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MADVD like '{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where MA_TL LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where TENDVD LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where NOIDUNG LIKE N'{0}%'", value)
        ElseIf cmbTimKiem.SelectedIndex = 4 Then
            sqlQuery += String.Format(" where DONGIA LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = DataBaseAccess.GetDataTable(sqlQuery)
        dgvxem.DataSource = data
        With dgvxem
            .Columns(0).HeaderText = "Mã DVD"
            .Columns(1).HeaderText = "Mã thể loại"
            .Columns(2).HeaderText = "Tên DVD"
            .Columns(3).HeaderText = "Nội dung"
            .Columns(4).HeaderText = "Đơn giá"
            .Columns(4).Width = 250
        End With
    End Sub
End Class