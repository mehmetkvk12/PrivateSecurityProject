Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Module AyarlarModule
    Public Function SqlBaglantiCumlesi() As String
        Dim SqlBaglantiCumlesiOlusturucu As New SqlConnectionStringBuilder
        SqlBaglantiCumlesiOlusturucu.DataSource = "."
        SqlBaglantiCumlesiOlusturucu.InitialCatalog = "OzGuVT"
        SqlBaglantiCumlesiOlusturucu.IntegratedSecurity = False
        SqlBaglantiCumlesiOlusturucu.PersistSecurityInfo = False
        SqlBaglantiCumlesiOlusturucu.UserID = "sa"
        SqlBaglantiCumlesiOlusturucu.Password = "mmyo"
        Return SqlBaglantiCumlesiOlusturucu.ConnectionString
    End Function
    Public Function SifreKontrol(Sifre As String) As Boolean
        Dim regex As Regex = New Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{5,15}$")
        Dim isValid As Boolean = regex.IsMatch(Sifre)
        Return isValid
    End Function
End Module
