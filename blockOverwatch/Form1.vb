Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        AddHandler Microsoft.Win32.SystemEvents.SessionEnding, AddressOf Handler_SessionEnding
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
        Me.Visible = False
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, _
        ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For Each prog As Process In Process.GetProcesses
            If prog.ProcessName = "Overwatch" Then
                prog.Kill()
            End If
        Next
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim confirm As Integer = MsgBox("종료하시겠습니까?", vbYesNo, "확인")
        If confirm = vbYes Then
            End
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub Handler_SessionEnding(ByVal sender As Object, ByVal e As Microsoft.Win32.SessionEndingEventArgs)
        End
    End Sub

End Class