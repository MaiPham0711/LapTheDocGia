﻿Public Class DocGiaDTO

    Private strHoten As String
    Private strDiaChi As String
    Private dateNgaySinh As DateTime
    Private strLoaiDocGia As String
    Private strEmail As String
    Private dateNgayLapThe As DateTime
    Private strNguoiLapThe As String

    Public Sub New()
    End Sub
    Public Sub New(strHoten As String, strDiaChi As String, dateNgaySinh As DateTime, strLoaiDocGia As String, strEmail As String, dateNgayLapThe As DateTime, strNguoiLapThe As String)
        Me.strHoten = strHoten
        Me.strDiaChi = strDiaChi
        Me.dateNgaySinh = dateNgaySinh
        Me.strLoaiDocGia = strLoaiDocGia
        Me.strEmail = strEmail
        Me.dateNgayLapThe = dateNgayLapThe
        Me.strNguoiLapThe = strNguoiLapThe
    End Sub

    Property HoTen() As String
        Get
            Return strHoten
        End Get
        Set(ByVal Value As String)
            strHoten = Value
        End Set
    End Property

    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property
    Property NgaySinh() As DateTime
        Get
            Return dateNgaySinh
        End Get
        Set(ByVal Value As DateTime)
            dateNgaySinh = Value
        End Set
    End Property

    Public Property LoaiDocGia() As String
        Get
            Return strLoaiDocGia
        End Get
        Set(value As String)
            strLoaiDocGia = value
        End Set
    End Property

    Public Property NgayLapThe() As Date
        Get
            Return dateNgayLapThe
        End Get
        Set(value As Date)
            dateNgayLapThe = value
        End Set
    End Property

    Public Property NguoiLapThe As String
        Get
            Return strNguoiLapThe
        End Get
        Set(value As String)
            strNguoiLapThe = value
        End Set
    End Property

    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            strEmail = value
        End Set
    End Property
End Class
