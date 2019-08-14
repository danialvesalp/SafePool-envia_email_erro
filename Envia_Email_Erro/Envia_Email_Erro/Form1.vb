Imports System.Net.Mail

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim servidorsmtp As New SmtpClient()
            Dim email As New MailMessage()
            servidorsmtp.Credentials = New _
                Net.NetworkCredential("piscinasegura306@gmail.com", "ps123456")

            servidorsmtp.Port = 587
            servidorsmtp.Host = "smtp.gmail.com"
            servidorsmtp.EnableSsl = True

            email = New MailMessage
            email.From = New MailAddress("piscinasegura306@gmail.com")
            email.To.Add("daniellelima@gea.inatel.br")
            email.Subject = "Piscina Segura- Erro!"
            email.Body = "Erro! Não foi possível iniciar a câmera de segurança!"
            servidorsmtp.Send(email)

        Catch ex As Exception
            MsgBox("ERRO!")
        End Try
        Close()

    End Sub
End Class
