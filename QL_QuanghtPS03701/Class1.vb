Imports System.Data.SqlClient
Imports System.Data
Public Class Class1
    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=quanghtps03701.mssql.somee.com;packet size=4096;user id=shinoha_SQLLogin_1;pwd=lbwdgij41k;data source=quanghtps03701.mssql.somee.com;persist security info=False;initial catalog=quanghtps03701"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select DVD.MADVD as 'Mã DVD' , DVD.TENDVD as 'Tên DVD', DVD.NOIDUNG as 'Nội dung', DVD.DONGIA as 'Đơn giá', THELOAI.MA_TL as 'Mã thể loại', THELOAI.TEN_TL from DVD inner join THELOAI on DVD.MA_TL=THELOAI.MA_TL", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
