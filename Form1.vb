Imports System.Runtime.InteropServices

Public Class frmIdle_Help

    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    Dim loop_stop As Boolean = False

    Dim loc As Point

    Dim colorAccent As System.Drawing.Color

    Dim pos1() As String = Nothing
    Dim pos2() As String = Nothing
    Dim interval_time_milliseconds As Double = Nothing




    Dim temp_pos1 As String = init_pos1
    Dim temp_pos2 As String = init_pos2
    Dim temp_interval As String = init_interval

    Dim set_interval_millisecond As Double = temp_interval * 3600

    Dim go_over_stop As Boolean = True


    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean

    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#95")>
    Public Shared Function GetImmersiveColorFromColorSetEx(ByVal dwImmersiveColorSet As UInteger, ByVal dwImmersiveColorType As UInteger, ByVal bIgnoreHighContrast As Boolean, ByVal dwHighContrastCacheMode As UInteger) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#96")>
    Public Shared Function GetImmersiveColorTypeFromName(ByVal pName As IntPtr) As UInteger
    End Function
    <DllImport("Uxtheme.dll", SetLastError:=True, CharSet:=CharSet.Auto, EntryPoint:="#98")>
    Public Shared Function GetImmersiveUserColorSetPreference(ByVal bForceCheckRegistry As Boolean, ByVal bSkipCheckOnFail As Boolean) As UInteger
    End Function

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlControl.MouseMove, lblTitle.MouseMove
        If e.Button = MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlControl.MouseDown, lblTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        If go_over_stop = True Then

            loop_stop = False

            If MessageBox.Show("Are you sure?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Exit Sub
            End If

            If txtPos1.Text.Contains(",") = False Or txtPos2.Text.Contains(",") = False Then
                Error_Msg()
                Exit Sub
            End If

            Try
                pos1 = Split(txtPos1.Text, ",")
                pos2 = Split(txtPos2.Text, ",")
                interval_time_milliseconds = CDbl(txtInterval.Text) * CDbl(60000)
                set_interval_millisecond = interval_time_milliseconds
            Catch ex As Exception
                Error_Msg()
                txtInterval.Text = Nothing
                txtPos1.Text = Nothing
                txtPos2.Text = Nothing
                Exit Sub
            End Try



            For Each ctrl As Control In Me.Controls
                ctrl.Enabled = False
            Next
            tmrMem.Enabled = True

            For Each lbl As Label In Me.Controls.OfType(Of Label)
                lbl.Enabled = True
            Next

            btnGo.Enabled = True
            btnStop.Enabled = True
            pnlControl.Enabled = True
            lblTitle.Enabled = True
            btnClose.Enabled = True
            btnDM.Enabled = True
            btnMore.Enabled = True
            chkTM.Enabled = True

            If Me.Size.Height <> 436 Then
                CodeToMore()
            End If

            go_over_stop = False

            drag_click = 0
            lblClicks.Text = stringClick & drag_click

            tmrInterval.Start()

        End If

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.F And go_over_stop = True Then
            Me.Cursor = New Cursor(Cursor.Current.Handle)

            xSelected = Cursor.Position.X
            ySelected = Cursor.Position.Y

            myDialog.lblInfo.Text = "Position: " & "(" & CStr(xSelected) & "," & CStr(ySelected) & ")" & vbNewLine & vbNewLine & "Press:" & vbNewLine & "Pos1 to enter into 'Pos1'" & vbNewLine & "Pos2 to enter in 'Pos2'" & vbNewLine & "Cancel to cancel!"

            Me.Hide()
            myDialog.ShowDialog()

            Select Case myDialog.DialogResult
                Case DialogResult.Yes
                    txtPos1.Text = CStr(xSelected) & "," & CStr(ySelected)
                Case DialogResult.No
                    txtPos2.Text = CStr(xSelected) & "," & CStr(ySelected)
            End Select
            btnGo.Select()
        End If

    End Sub
    Private Sub frmIdle_Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'the 2 lines of code below are for finding windows accent color
        Dim colorSystemAccent As UInteger = GetImmersiveColorFromColorSetEx(GetImmersiveUserColorSetPreference(False, False), GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveSystemAccent")), False, 0)
        colorAccent = System.Drawing.Color.FromArgb((&HFF000000 And colorSystemAccent) >> 24, &HFF And colorSystemAccent, (&HFF00 And colorSystemAccent) >> 8, (&HFF0000 And colorSystemAccent) >> 16)
        pnlControl.BackColor = colorAccent

        tmrMem.Start()
        Me.CheckForIllegalCrossThreadCalls = False
        Me.Size = New Size(255, 236)
        lblTitle.Text &= "Version " & version_make
        MyBase.KeyPreview = True
        rdbClick.Checked = True
        MessageBox.Show("Press 'F' to find position of desired location!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub rdbDrag_CheckedChanged(sender As Object, e As EventArgs) Handles rdbDrag.CheckedChanged
        If rdbDrag.Checked = True Then
            rdbClick.Checked = False
        End If
    End Sub

    Private Sub rdbClick_CheckedChanged(sender As Object, e As EventArgs) Handles rdbClick.CheckedChanged
        If rdbClick.Checked = True Then
            rdbDrag.Checked = False
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        If go_over_stop = False Then
            For Each ctrl As Control In Me.Controls
                ctrl.Enabled = True
            Next
            loop_stop = True
            tmrInterval.Stop()
            go_over_stop = True
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure you want to exit?", "Confirm!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    'Below is waste
    'Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwMain.DoWork
    '    If rdbClick.Checked = True Then
    '        While loop_stop = False
    '            Try
    '                Cursor.Position = New Point(pos1(0), pos1(1))
    '                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    '                Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    '                Threading.Thread.Sleep(180)
    '                Cursor.Position = New Point(pos2(0), pos2(1))
    '                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    '                Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    '            Catch ex As Exception
    '                Error_Msg()
    '            End Try

    '            lblnum.Text = set_interval_millisecond

    '            tmrInterval.Start()

    '            Do
    '                If bwMain.CancellationPending = True Then
    '                    e.Cancel = True
    '                    Exit Sub
    '                End If
    '            Loop Until tmrInterval.Enabled = False

    '            'For i As Integer = 1 To interval_time_milliseconds
    '            '    If bwMain.CancellationPending = True Then
    '            '        e.Cancel = True
    '            '        Exit Sub
    '            '    Else
    '            '        lblnum.Text = CStr(CInt(lblnum.Text) + 1)
    '            '        Refresh()
    '            '        Threading.Thread.Sleep(1)
    '            '        Refresh()
    '            '    End If
    '            'Next

    '            set_interval_millisecond = interval_time_milliseconds

    '        End While
    '        Exit Sub
    '    ElseIf rdbDrag.Checked = True Then
    '        While loop_stop = False
    '            Try
    '                Cursor.Position = New Point(pos1(0), pos1(1))
    '                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
    '                Threading.Thread.Sleep(180)
    '                Cursor.Position = New Point(pos2(0), pos2(1))
    '                Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    '            Catch ex As Exception
    '                Error_Msg()
    '            End Try
    '            For i As Integer = 1 To interval_time_milliseconds
    '                If bwMain.CancellationPending = True Then
    '                    e.Cancel = True
    '                    Exit Sub
    '                Else
    '                    Refresh()
    '                    Threading.Thread.Sleep(1)
    '                    Refresh()
    '                End If
    '            Next
    '        End While
    '    End If
    'End Sub

    Private Sub Error_Msg()
        Me.TopMost = False
        MessageBox.Show("Something is wrong with the position inputs!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Me.TopMost = True
    End Sub

    Private Sub CodeToMore()
        btnMore.Enabled = False
        bwAnimate.RunWorkerAsync()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        CodeToMore()
    End Sub

    Private Sub bwAnimate_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwAnimate.DoWork
        Dim give_take As Integer = 0
        If btnMore.Text.Contains("Show") Then
            give_take = +10
            btnMore.Text = "Hide More"
        Else
            give_take = -10
            btnMore.Text = "Show More"
        End If

        For i As Integer = 1 To 20
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + give_take)
            Threading.Thread.Sleep(5)
        Next
        e.Cancel = True
        btnMore.Enabled = True
        Exit Sub
    End Sub

    Private Sub chkTM_CheckedChanged(sender As Object, e As EventArgs) Handles chkTM.CheckedChanged
        If chkTM.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub txtPos1_MouseEnter(sender As Object, e As EventArgs) Handles txtPos1.MouseEnter
        txtPos1.Text = "1st area to click"
    End Sub

    Private Sub txtPos1_MouseLeave(sender As Object, e As EventArgs) Handles txtPos1.MouseLeave
        txtPos1.Text = temp_pos1
    End Sub

    Private Sub txtPos2_MouseEnter(sender As Object, e As EventArgs) Handles txtPos2.MouseEnter
        txtPos2.Text = "2nd area to click"
    End Sub

    Private Sub txtPos2_MouseLeave(sender As Object, e As EventArgs) Handles txtPos2.MouseLeave
        txtPos2.Text = temp_pos2
    End Sub

    Private Sub txtInterval_MouseEnter(sender As Object, e As EventArgs) Handles txtInterval.MouseEnter
        txtInterval.Text = "Enter the interval"
    End Sub

    Private Sub txtInterval_MouseLeave(sender As Object, e As EventArgs) Handles txtInterval.MouseLeave
        txtInterval.Text = temp_interval
    End Sub

    Private Sub tmrMem_Tick(sender As Object, e As EventArgs) Handles tmrMem.Tick
        Dim x As Process = Process.GetCurrentProcess()
        Dim mem_mb As Double = x.WorkingSet / 1048576

        lblMem.Text = "Memory Usage: " & mem_mb & " MB"

        If mem_mb > (max_mem * basecount) Then
            basecount += 1
            MessageBox.Show("Warning: Memory usage is over " & (max_mem * (basecount - 1)) & " MB!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnDM_Click(sender As Object, e As EventArgs) Handles btnDM.Click
        If btnDM.Text.Contains("Dark") Then
            For Each ctrl As Control In Me.Controls
                ctrl.BackColor = Color.Black
                ctrl.ForeColor = Color.White
            Next
            btnStop.ForeColor = Color.White
            btnClose.BackColor = Color.Black
            pnlControl.BackColor = colorAccent
            Me.BackColor = Color.Black
            btnDM.Text = "Light Mode"

            For Each ctrl As Control In myDialog.Controls
                ctrl.BackColor = Color.Black
                ctrl.ForeColor = Color.White
            Next
            myDialog.BackColor = Color.Black
            With myDialog
                .btnPos1.BackColor = Color.Black
                .btnPos2.BackColor = Color.Black
                .btnCancel.BackColor = Color.Black
            End With

        Else
            For Each ctrl As Control In Me.Controls
                ctrl.BackColor = Color.White
                ctrl.ForeColor = Color.Black
            Next
            btnStop.ForeColor = Color.Black
            btnClose.BackColor = Color.White
            pnlControl.BackColor = colorAccent
            Me.BackColor = Color.White
            btnDM.Text = "Dark Mode"

            For Each ctrl As Control In myDialog.Controls
                ctrl.BackColor = Color.White
                ctrl.ForeColor = Color.Black
            Next
            myDialog.BackColor = Color.White
            With myDialog
                .btnPos1.BackColor = Color.White
                .btnPos2.BackColor = Color.White
                .btnCancel.BackColor = Color.White
            End With

        End If

    End Sub

    Private Sub txtPos1_TextChanged(sender As Object, e As EventArgs) Handles txtPos1.TextChanged
        If txtPos1.Text.Contains("area to click") = False Then
            temp_pos1 = txtPos1.Text
        End If
    End Sub

    Private Sub txtPos2_TextChanged(sender As Object, e As EventArgs) Handles txtPos2.TextChanged
        If txtPos2.Text.Contains("area to click") = False Then
            temp_pos2 = txtPos2.Text
        End If
    End Sub

    Private Sub txtInterval_TextChanged(sender As Object, e As EventArgs) Handles txtInterval.TextChanged
        If txtInterval.Text.Contains("Enter") = False Then
            temp_interval = txtInterval.Text
        End If
    End Sub

    Private Sub frmIdle_Help_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.Select()
    End Sub

    Private Sub tmrInterval_Tick(sender As Object, e As EventArgs) Handles tmrInterval.Tick

        If set_interval_millisecond = 0 Then
            If rdbClick.Checked Then

                Try
                    Cursor.Position = New Point(pos1(0), pos1(1))
                    Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                    Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                    Threading.Thread.Sleep(180)
                    Cursor.Position = New Point(pos2(0), pos2(1))
                    Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                    Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                Catch ex As Exception
                    Error_Msg()
                End Try

            ElseIf rdbDrag.Checked = True Then

                Try
                    Cursor.Position = New Point(pos1(0), pos1(1))
                    Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                    Threading.Thread.Sleep(180)
                    Cursor.Position = New Point(pos2(0), pos2(1))
                    Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
                Catch ex As Exception
                    Error_Msg()
                End Try

            End If
            drag_click += 1
            lblClicks.Text = stringClick & drag_click

            set_interval_millisecond = interval_time_milliseconds
        Else
            set_interval_millisecond -= 1000
        End If
    End Sub
End Class
