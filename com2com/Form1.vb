Imports System.IO.Ports

Public Class Form1

    Dim fs As New FaconSvr.FaconServer

    Dim CSG As String = "Channel0.Station0.Group0"

    Private Sub LigarY0_MotorBtn_Click(sender As Object, e As EventArgs) Handles LigarY0_MotorBtn.Click
        fs.SetItem(CSG, "Y0", 1)
    End Sub

    Private Sub DesligarY0_MotorBtn_Click(sender As Object, e As EventArgs) Handles DesligarY0_MotorBtn.Click
        fs.SetItem(CSG, "Y0", 0)
    End Sub

    Private Sub LigarY1_EV_InBtn_Click(sender As Object, e As EventArgs) Handles LigarY1_EV_InBtn.Click
        fs.SetItem(CSG, "Y1", 1)
    End Sub

    Private Sub DesligarY1_EV_In_Click(sender As Object, e As EventArgs) Handles DesligarY1_EV_In.Click
        fs.SetItem(CSG, "Y1", 0)
    End Sub

    Private Sub LigarY2_EV_OutBtn_Click(sender As Object, e As EventArgs) Handles LigarY2_EV_OutBtn.Click
        fs.SetItem(CSG, "Y2", 1)
    End Sub

    Private Sub DesligarY2_EV_OutBtn_Click(sender As Object, e As EventArgs) Handles DesligarY2_EV_OutBtn.Click
        fs.SetItem(CSG, "Y2", 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        X0_AlarmEmptyChk.Checked = fs.GetItem(CSG, "X0")
        X1_EmptyChk.Checked = fs.GetItem(CSG, "X1")
        X2_FullChk.Checked = fs.GetItem(CSG, "X2")
        X3_AlarmMaxChk.Checked = fs.GetItem(CSG, "X3")
        Y0_MotorChk.Checked = fs.GetItem(CSG, "Y0")
        Y1_EV_InChk.Checked = fs.GetItem(CSG, "Y1")
        Y2_EV_OutChk.Checked = fs.GetItem(CSG, "Y2")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True

        fs.OpenProject("C:\Users\aspire-pc\source\repos\Facon\facon.fcs")
        fs.Connect()

    End Sub
End Class
