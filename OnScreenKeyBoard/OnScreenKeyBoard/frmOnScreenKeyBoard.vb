#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: https://www.facebook.com/g2gnet (For Thailand)
' / Facebook: https://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gnet.com/webboard
' /
' / Purpose: On Screen Keyboard usage TabTip.exe with VB.NET.
' / Microsoft Visual Basic .NET (2010)
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

Imports System.Runtime.InteropServices

Public Class frmOnScreenKeyBoard

    Const WM_SYSCOMMAND As Int32 = 274
    Const SC_CLOSE As UInt32 = 61536

    '// WinAPI32 From VB6. (API = Application Programming Interface)
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function PostMessage( _
        ByVal hWnd As IntPtr, _
        ByVal Msg As UInteger, _
        ByVal wParam As IntPtr, _
        ByVal lParam As IntPtr _
        ) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function FindWindow( _
        ByVal lpClassName As String, _
        ByVal lpWindowName As String _
        ) As IntPtr
    End Function

    '// Instance Name Process
    Private _P As Process

    Private Sub HideKeyboard()
        Dim KeyboardWnd As IntPtr = FindWindow("IPTip_Main_Window", Nothing)
        PostMessage(KeyboardWnd.ToInt32(), WM_SYSCOMMAND, SC_CLOSE, 0)
    End Sub

    Private Sub btnShowKeyboard_Click(sender As Object, e As EventArgs) Handles btnShowKeyboard.Click
        If _P Is Nothing OrElse _P.HasExited Then
            If _P IsNot Nothing AndAlso _P.HasExited Then _P.Close()
            '// Sometimes TabTip may be hidden.
            Call KillProcess()
            _P = Process.Start("C:\Program Files\Common Files\microsoft shared\ink\TabTip.exe")
            '/ Focus to the textbox
            TextBox1.Focus()
        End If
    End Sub

    Private Sub KillProcess()
        For Each p As Process In Process.GetProcesses
            If String.Compare(p.ProcessName, "TabTip", True) = 0 Then
                p.Kill()
                Exit For
            End If
        Next
    End Sub

    Private Sub btnHideKeyboard_Click(sender As System.Object, e As System.EventArgs) Handles btnHideKeyboard.Click
        Call HideKeyboard()
    End Sub

    Private Sub frmOnScreenKeyBoard_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Call HideKeyboard()
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
    End Sub

End Class
