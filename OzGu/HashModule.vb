Imports System.Text
Imports System.Security.Cryptography
Module HashModule
    Public Function HashAlgoritma(Metin As String, Algoritma As HashAlgorithm) As String
        Dim DiziMetin() As Byte = Encoding.UTF8.GetBytes(Metin)
        Dim ByteSonuc() As Byte = Algoritma.ComputeHash(DiziMetin)
        Dim Sonuc As String = Nothing
        For Each Eleman As Byte In ByteSonuc
            Sonuc &= Eleman.ToString("x2")
        Next
        Return Sonuc
    End Function
End Module
