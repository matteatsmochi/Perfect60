Public Class frmPerf60
    Dim Score As Integer
    Dim Arena0Win As Integer
    Dim Arena1Win As Integer
    Dim Arena2Win As Integer
    Dim Arena3Win As Integer
    Dim Arena4Win As Integer
    Dim Arena0Loss As Integer
    Dim Arena1Loss As Integer
    Dim Arena2Loss As Integer
    Dim Arena3Loss As Integer
    Dim Arena4Loss As Integer
    Private Sub frmPerf60_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
        Me.Width = 200
        ResetTxt()
        SendToOBS()
    End Sub
    Private Sub cmdNewRun_Click(sender As Object, e As EventArgs) Handles cmdNewRun.Click
        cmdNewRun.Enabled = False
        cmdWin.Enabled = True
        cmdLoss.Enabled = True
        cmdReset.Enabled = True
        ResetTxt()
        SendToOBS()
        NewDraft()
    End Sub
    Private Sub cmdWin_Click(sender As Object, e As EventArgs) Handles cmdWin.Click
        Arena0Win += 1
        txtArena0Wins.Text += 1
    End Sub
    Private Sub cmdLoss_Click(sender As Object, e As EventArgs) Handles cmdLoss.Click
        Arena0Loss += 1
        txtArena0Loss.Text += 1
    End Sub
    Private Sub cmdOBS_Click(sender As Object, e As EventArgs) Handles cmdOBS.Click
        frmOnScreen.Show()
    End Sub
    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        cmdNewRun.Enabled = True
        cmdWin.Enabled = False
        cmdLoss.Enabled = False
        cmdReset.Enabled = False
        ResetTxt()
        SendToOBS()
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
    End Sub
    Private Sub ResetTxt()
        txtArena0ClassName.Text = ""
        txtArena1ClassName.Text = ""
        txtArena2ClassName.Text = ""
        txtArena3ClassName.Text = ""
        txtArena4ClassName.Text = ""
        txtArena0Wins.Text = "0"
        txtArena1Wins.Text = ""
        txtArena2Wins.Text = ""
        txtArena3Wins.Text = ""
        txtArena4Wins.Text = ""
        Arena0Win = 0
        Arena1Win = 0
        Arena2Win = 0
        Arena3Win = 0
        Arena4Win = 0
        txtArena0Loss.Text = "0"
        txtArena1Loss.Text = ""
        txtArena2Loss.Text = ""
        txtArena3Loss.Text = ""
        txtArena4Loss.Text = ""
        Arena0Loss = 0
        Arena1Loss = 0
        Arena2Loss = 0
        Arena3Loss = 0
        Arena4Loss = 0
        frmOnScreen.picArena0.BackgroundImage = My.Resources.Empty
        frmOnScreen.picArena1.BackgroundImage = My.Resources.Empty
        frmOnScreen.picArena2.BackgroundImage = My.Resources.Empty
        frmOnScreen.picArena3.BackgroundImage = My.Resources.Empty
        frmOnScreen.picArena4.BackgroundImage = My.Resources.Empty
        txtScore.Text = "0"
        Score = 0
    End Sub
    Private Sub NewDraft()
        grpNewDraft.Left = 0
    End Sub
    Private Sub DropDown()
        txtArena4ClassName.Text = txtArena3ClassName.Text
        txtArena3ClassName.Text = txtArena2ClassName.Text
        txtArena2ClassName.Text = txtArena1ClassName.Text
        txtArena1ClassName.Text = txtArena0ClassName.Text
        txtArena0ClassName.Text = ""
        txtArena4Wins.Text = txtArena3Wins.Text
        txtArena3Wins.Text = txtArena2Wins.Text
        txtArena2Wins.Text = txtArena1Wins.Text
        txtArena1Wins.Text = txtArena0Wins.Text
        txtArena0Wins.Text = "0"
        Arena4Win = Arena3Win
        Arena3Win = Arena2Win
        Arena2Win = Arena1Win
        Arena1Win = Arena0Win
        Arena0Win = 0
        txtArena4Loss.Text = txtArena3Loss.Text
        txtArena3Loss.Text = txtArena2Loss.Text
        txtArena2Loss.Text = txtArena1Loss.Text
        txtArena1Loss.Text = txtArena0Loss.Text
        txtArena0Loss.Text = "0"
        Arena4Loss = Arena3Loss
        Arena3Loss = Arena2Loss
        Arena2Loss = Arena1Loss
        Arena1Loss = Arena0Loss
        Arena0Loss = 0
        frmOnScreen.picArena4.BackgroundImage = frmOnScreen.picArena3.BackgroundImage
        frmOnScreen.picArena3.BackgroundImage = frmOnScreen.picArena2.BackgroundImage
        frmOnScreen.picArena2.BackgroundImage = frmOnScreen.picArena1.BackgroundImage
        frmOnScreen.picArena1.BackgroundImage = frmOnScreen.picArena0.BackgroundImage
        frmOnScreen.picArena0.BackgroundImage = My.Resources.Empty
        SendToOBS()
    End Sub
    Private Sub CalcScore()
        Score = Arena0Win + Arena1Win + Arena2Win + Arena3Win + Arena4Win - Arena0Loss - Arena1Loss - Arena2Loss - Arena3Loss - Arena4Loss
        txtScore.Text = Score
    End Sub
    Private Sub SendToOBS()
        frmOnScreen.lblScore.Text = txtScore.Text
        frmOnScreen.lblArena0ClassName.Text = txtArena0ClassName.Text
        frmOnScreen.lblArena1ClassName.Text = txtArena1ClassName.Text
        frmOnScreen.lblArena2ClassName.Text = txtArena2ClassName.Text
        frmOnScreen.lblArena3ClassName.Text = txtArena3ClassName.Text
        frmOnScreen.lblArena4ClassName.Text = txtArena4ClassName.Text
        frmOnScreen.lblArena0Wins.Text = txtArena0Wins.Text
        frmOnScreen.lblArena1Wins.Text = txtArena1Wins.Text
        frmOnScreen.lblArena2Wins.Text = txtArena2Wins.Text
        frmOnScreen.lblArena3Wins.Text = txtArena3Wins.Text
        frmOnScreen.lblArena4Wins.Text = txtArena4Wins.Text
        frmOnScreen.lblArena0Loss.Text = txtArena0Loss.Text
        frmOnScreen.lblArena1Loss.Text = txtArena1Loss.Text
        frmOnScreen.lblArena2Loss.Text = txtArena2Loss.Text
        frmOnScreen.lblArena3Loss.Text = txtArena3Loss.Text
        frmOnScreen.lblArena4Loss.Text = txtArena4Loss.Text
    End Sub
    Private Sub txtArena0Wins_TextChanged(sender As Object, e As EventArgs) Handles txtArena0Wins.TextChanged
        If txtArena0Wins.Text = 12 Then
            If txtArena4ClassName.Text <> "" Then
                cmdWin.Enabled = False
                cmdLoss.Enabled = False
            Else
                DropDown()
                NewDraft()
            End If
        End If
        CalcScore()
        SendToOBS()
    End Sub
    Private Sub txtArena0Loss_TextChanged(sender As Object, e As EventArgs) Handles txtArena0Loss.TextChanged
        If txtArena0Loss.Text = 3 Then
            If txtArena4ClassName.Text <> "" Then
                cmdWin.Enabled = False
                cmdLoss.Enabled = False
            Else
                DropDown()
                NewDraft()
            End If
        End If
        CalcScore()
        SendToOBS()
    End Sub
    Private Sub cmdPickWarrior_Click(sender As Object, e As EventArgs) Handles cmdPickWarrior.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = False
        txtArena0ClassName.Text = "warrior"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_warrior
        SendToOBS()
    End Sub
    Private Sub cmdPickShaman_Click(sender As Object, e As EventArgs) Handles cmdPickShaman.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = False
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "shaman"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_shaman
        SendToOBS()
    End Sub
    Private Sub cmdPickRogue_Click(sender As Object, e As EventArgs) Handles cmdPickRogue.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = False
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "rogue"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_rogue
        SendToOBS()
    End Sub
    Private Sub cmdPickPaladin_Click(sender As Object, e As EventArgs) Handles cmdPickPaladin.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = False
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "paladin"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_paladin
        SendToOBS()
    End Sub
    Private Sub cmdPickHunter_Click(sender As Object, e As EventArgs) Handles cmdPickHunter.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = False
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "hunter"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_hunter
        SendToOBS()
    End Sub
    Private Sub cmdPickDruid_Click(sender As Object, e As EventArgs) Handles cmdPickDruid.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = False
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "druid"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_druid
        SendToOBS()
    End Sub
    Private Sub cmdPickWarlock_Click(sender As Object, e As EventArgs) Handles cmdPickWarlock.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = False
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "warlock"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_warlock
        SendToOBS()
    End Sub

    Private Sub cmdPickMage_Click(sender As Object, e As EventArgs) Handles cmdPickMage.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = False
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = True
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "mage"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_mage
        SendToOBS()
    End Sub
    Private Sub cmdPickPriest_Click(sender As Object, e As EventArgs) Handles cmdPickPriest.Click
        grpNewDraft.Left = 200
        cmdPickDruid.Enabled = True
        cmdPickHunter.Enabled = True
        cmdPickMage.Enabled = True
        cmdPickPaladin.Enabled = True
        cmdPickPriest.Enabled = False
        cmdPickRogue.Enabled = True
        cmdPickShaman.Enabled = True
        cmdPickWarlock.Enabled = True
        cmdPickWarrior.Enabled = True
        txtArena0ClassName.Text = "priest"
        frmOnScreen.picArena0.BackgroundImage = My.Resources.icon_class_priest
        SendToOBS()
    End Sub
End Class
