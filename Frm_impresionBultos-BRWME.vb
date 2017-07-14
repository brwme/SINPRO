﻿Public Class Frm_impresionBultos_BRWME

    Dim NroFact As Integer = 0
    Dim Bultos As Integer = 0
    Dim destino As String = ""
    Dim nombre As String = ""

    Private Sub Frm_impresionBultos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = My.Settings.NombreEmpresa & ": " & Me.Text

        Datos.consultaLogo(PictureBox1)
        Datos.consultaLogo(PictureBox2)

        Dim Total As Double = Bultos / 2

        Dim Alto As Integer = Math.Round(Total, 2, MidpointRounding.ToEven)
        Dim Bajo As Integer = Math.Truncate(Total)

        If Total - Bajo = 0 Then

            lbl_sugerencia.Text = "SUGERENCIA: Usar " & Alto.ToString & " hojas completas"
            lbl_sugerencia.Visible = True

        ElseIf Total - Bajo = 0.5 Then

            lbl_sugerencia.Visible = True
            lbl_sugerencia.Text = "SUGERENCIA: Colocar como primera página una hoja de 2 etiquetas"

        End If

    End Sub

    Public Sub recibe(ByVal nrof As Integer, ByVal btos As Integer, ByVal dest As String, ByVal nom As String)

        NroFact = nrof
        Bultos = btos
        destino = dest
        nombre = nom

    End Sub

    Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click, PictureBox1.Click

        Dim r_GB As New R_GuiaBultos
        r_GB.valores_Guia(NroFact, Bultos, destino, nombre, 1)
        r_GB.Show()
        Me.Close()

    End Sub

    Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click, PictureBox2.Click

        Dim r_GB As New R_GuiaBultos
        r_GB.valores_Guia(NroFact, Bultos, destino, nombre, 2)
        r_GB.Show()
        Me.Close()

    End Sub

    Private Sub Panel1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseHover, PictureBox1.MouseHover

        Panel1.BackColor = Color.WhiteSmoke
        Panel2.BackColor = Color.White

        PictureBox1.Visible = True
        PictureBox2.Visible = True

    End Sub

    Private Sub Panel2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseHover, PictureBox2.MouseHover

        Panel2.BackColor = Color.WhiteSmoke
        PictureBox1.Visible = False
        Panel1.BackColor = Color.White

        PictureBox1.Visible = False
        PictureBox2.Visible = True

    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave

        Panel1.BackColor = Color.White
        PictureBox1.Visible = True
        PictureBox2.Visible = True

    End Sub

    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.MouseLeave

        Panel2.BackColor = Color.White
        PictureBox1.Visible = True
        PictureBox2.Visible = True

    End Sub

End Class