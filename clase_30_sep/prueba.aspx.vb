Public Class prueba
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Verificar_Click(sender As Object, e As EventArgs) Handles Verificar.Click
        Dim dui = Request("dui")
        If dui <> "" Then
            Dim vericador = dui.Substring(9, 1)
            dui = dui.Substring(0, 8)
            Dim x As Integer = 9
            Dim i, resto As Integer
            Dim suma As Integer = 0
            For i = 0 To 7
                suma = suma + (Val(dui(i)) * x)
                x -= 1
            Next
            resto = suma Mod 10
            If (10 - resto) = Val(vericador) Then
                resultado.Text = "DUI es valido"
            Else
                resultado.Text = "DUI No valido. Verifique el numero de su DUI"
            End If
        Else
            resultado.Text = "Es obligatorio digitar un DUI"
        End If
    End Sub
End Class