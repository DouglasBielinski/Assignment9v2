Imports System
Imports System.Resources

Public Class Form1

    Dim fileList(0 To 5) As ResXResourceSet
    Dim i As Integer
    Dim resx_cur As ResXResourceSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
        'load in all the resx files from the directory
        For Each foundFile As String In My.Computer.FileSystem.GetFiles _
            (Application.StartupPath)
            If foundFile.EndsWith(".resx") Then
                resx_cur = New ResXResourceSet(foundFile)
                fileList(i) = resx_cur
                i = i + 1
                Console.WriteLine(foundFile)
            End If
        Next


        flagOne.Visible = False
        flagTwo.Visible = False
        flagThree.Visible = False
        flagFour.Visible = False
        flagFive.Visible = False
        'load up flags based on how many resx files we have



        If i >= 1 Then
            flagOne.Visible = True
            flagOne.Image = Image.FromFile(fileList(0).GetString("myImagePath"))
            If i >= 2 Then
                flagTwo.Visible = True
                flagTwo.Image = Image.FromFile(fileList(1).GetString("myImagePath"))
                If i >= 3 Then
                    flagThree.Visible = True
                    flagThree.Image = Image.FromFile(fileList(2).GetString("myImagePath"))
                    If i >= 4 Then
                        flagFour.Image = Image.FromFile(fileList(3).GetString("myImagePath"))
                        flagFour.Visible = True
                        If i >= 5 Then
                            flagFive.Image = Image.FromFile(fileList(4).GetString("myImagePath"))
                            flagFive.Visible = True
                        End If
                    End If
                End If
            End If
        End If
        Console.WriteLine(fileList.Length)



    End Sub

    Private Sub flagOne_Click(sender As Object, e As EventArgs) Handles flagOne.Click
        lGreeting.Text = fileList(0).GetString("myGreeting")
        bExit.Text = fileList(0).GetString("myExit")
        pMonument.Image = Image.FromFile(fileList(0).GetString("myMonu"))
    End Sub

    Private Sub flagTwo_Click(sender As Object, e As EventArgs) Handles flagTwo.Click
        lGreeting.Text = fileList(1).GetString("myGreeting")
        bExit.Text = fileList(1).GetString("myExit")
        pMonument.Image = Image.FromFile(fileList(1).GetString("myMonu"))
    End Sub

    Private Sub flagThree_Click(sender As Object, e As EventArgs) Handles flagThree.Click
        lGreeting.Text = fileList(2).GetString("myGreeting")
        bExit.Text = fileList(2).GetString("myExit")
        pMonument.Image = Image.FromFile(fileList(2).GetString("myMonu"))
    End Sub

    Private Sub flagFour_Click(sender As Object, e As EventArgs) Handles flagFour.Click
        lGreeting.Text = fileList(3).GetString("myGreeting")
        bExit.Text = fileList(3).GetString("myExit")
        pMonument.Image = Image.FromFile(fileList(3).GetString("myMonu"))
    End Sub

    Private Sub flagFive_Click(sender As Object, e As EventArgs) Handles flagFive.Click
        lGreeting.Text = fileList(4).GetString("myGreeting")
        bExit.Text = fileList(4).GetString("myExit")
        pMonument.Image = Image.FromFile(fileList(4).GetString("myMonu"))
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        End
    End Sub
End Class
