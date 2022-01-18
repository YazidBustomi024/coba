Public Class form1
    Dim isi As Integer = 0

    Private Sub clbComponent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbComponent.SelectedIndexChanged
        If clbComponent.GetItemChecked(0) = True Then
            cmbRam.Enabled = True
        Else
            cmbRam.Enabled = False
        End If

        If clbComponent.GetItemChecked(1) = True Then
            cmbMouse.Enabled = True
        Else
            cmbMouse.Enabled = False
        End If

        If clbComponent.GetItemChecked(2) = True Then
            cmbMonitor.Enabled = True
        Else
            cmbMonitor.Enabled = False
        End If

        If clbComponent.GetItemChecked(3) = True Then
            cmbKeyboard.Enabled = True
        Else
            cmbKeyboard.Enabled = False
        End If
        'If clbComponent.GetItemChecked(1) = True Then
        '    cmbMouse.Enabled = True
        '    cmbMouse.SelectedIndex = -1
        '    If ProgressBar1.Value - 2 >= 0 Then
        '        ProgressBar1.Value -= 2
        '    Else : ProgressBar1.Value = ProgressBar1.Minimum
        '    End If
        'Else
        '    cmbMouse.Enabled = False
        '    If ProgressBar1.Value - 2 >= 0 Then
        '        ProgressBar1.Value -= 2
        '    Else : ProgressBar1.Value = ProgressBar1.Minimum
        '    End If
        'End If

        'If clbComponent.GetItemChecked(2) = True Then
        '    cmbMonitor.Enabled = True
        'Else : cmbMonitor.Enabled = False
        'End If

        'If clbComponent.GetItemChecked(3) = True Then
        '    cmbKeyboard.Enabled = True
        'Else : cmbKeyboard.Enabled = False
        'End If
        isi += cmbRam.SelectedItem
        isi += cmbMouse.SelectedItem
        isi += cmbMonitor.SelectedItem
        isi += cmbKeyboard.SelectedItem

        ProgressBar1.Value = isi


    End Sub
End Class
