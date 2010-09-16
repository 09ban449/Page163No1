Public Class frmEddiesEquipment

    Private Sub btnDisplayRentalRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRentalRates.Click
        Dim fmtStr As String = "{0, -23} {1, -13} {2, -9}"
        lstRentalRates.Items.Add(String.Format(fmtStr, "Price of Equipment", "Half-day", "Full-day"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "1. Rug cleaner", "$16.00", "$24.00"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "2. Lawn mower", "$12.00", "$18.00"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "3. Paint sprayer", "$20.00", "$30.00"))
    End Sub

    Private Sub btnDisplayBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBill.Click
        If IsNumeric(txtSelectItem) Then
            If CInt(txtSelectItem.Text) >= 1 And CInt(txtSelectItem.Text) <= 3 Then

            End If

        End If
    End Sub
End Class
