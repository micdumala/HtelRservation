Imports System.Data.OleDb
Imports System.Data

Public Class frmAddRoom
    Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbHtelReservation.mdb;Persist Security Info=False"
    Dim conn As New OleDbConnection(connString)
    Public intRoomId, intFunc As Integer

    Private Sub reload()
        Me.Close()
        frmRoomList.reload()
        frmRoomList.Enabled = True
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        reload()
    End Sub

    Private Sub frAddRoom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmRoomList.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        checkRoomNum()
    End Sub
    Private Sub insertRoomNum()
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Using cmdUpd As New OleDbCommand("Insert into tblRoomList(RoomNumber, RoomType, ClientName, RoomStatus, Checkout) values (@rnNum, @rnType, '',0,'1/1/2001')", conn)
                cmdUpd.Parameters.AddWithValue("@rnNum", txtRoomNum.Text)
                cmdUpd.Parameters.AddWithValue("@rnType", txtRoomType.Text)
                cmdUpd.ExecuteNonQuery()
            End Using

        End Using
        reload()
    End Sub
    Private Sub checkRoomNum()
        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Using cmdCntRoom As New OleDbCommand("Select count(RoomNumber) from tblRoomList where RoomNumber=@rnNum", conn)
                    cmdCntRoom.Parameters.AddWithValue("@rnNum", txtRoomNum.Text)
                    Dim cntResult = cmdCntRoom.ExecuteScalar
                    If cntResult > 0 Then
                        MsgBox("Room Number is already Used!", vbInformation, "Room Number not Avaliable")
                    Else

                        If intFunc = 1 Then
                            frmHome.insertUserLog("Add", "Room List")
                            insertRoomNum()
                        ElseIf intFunc = 2 Then
                            frmHome.insertUserLog("Edit", "Room List")
                            updRoomList()
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdRoomTest()

    End Sub

    Private Sub updRoomList()
        Try
            Using conn As New OleDbConnection(connString)
                conn.Open()
                Using cmdUpdRoom As New OleDbCommand("Update tblRoomList set RoomNumber=@rnNum, RoomType=@rnType, ClientName='', RoomStatus=0, Checkout='1/1/2001' where RoomId=@rnId", conn)
                    cmdUpdRoom.Parameters.AddWithValue("@rnNum", txtRoomNum.Text)
                    cmdUpdRoom.Parameters.AddWithValue("@rnType", txtRoomType.Text)
                    cmdUpdRoom.Parameters.AddWithValue("@rnId", intRoomId)
                    cmdUpdRoom.ExecuteNonQuery()
                End Using
                conn.Close()
            End Using
            reload()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class