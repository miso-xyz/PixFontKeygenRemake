Imports System.Media
Public Class Form1
    Dim xpos As Integer
    Dim MoveForm As Boolean
    Dim MoveForm_MousePosition As Point

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Label1.Text = Mid(Label1.Text, 2, Len(Label1.Text)) & Mid(Label1.Text, 1, 1)
        If Label1.Right < 0 Then
            Label1.Left = ClientSize.Width
        Else
            Label1.Left -= 1
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Public Sub MoveForm_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown, Panel1.MouseDown, PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            MoveForm_MousePosition = e.Location
        End If
    End Sub

    Public Sub MoveForm_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, Panel1.MouseMove, PictureBox1.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Public Sub MoveForm_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseUp, Panel1.MouseUp, PictureBox1.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        PictureBox1.Image = My.Resources._3002
    End Sub
    Private Sub PictureBox1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        PictureBox1.Image = My.Resources._3001
    End Sub
End Class
