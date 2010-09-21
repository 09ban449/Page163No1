Public Class frmEddiesEquipment

    Private Sub btnDisplayRentalRates_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayRentalRates.Click
        Dim fmtStr As String = "{0, -23} {1, -13} {2, -9}"
        'Listing the information in the First list box
        lstRentalRates.Items.Add(String.Format(fmtStr, "Price of Equipment", "Half-day", "Full-day"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "1. Rug cleaner", "$16.00", "$24.00"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "2. Lawn mower", "$12.00", "$18.00"))
        lstRentalRates.Items.Add(String.Format(fmtStr, "3. Paint sprayer", "$20.00", "$30.00"))
    End Sub

    Private Sub btnDisplayBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayBill.Click
        Dim strItem As String
        Dim strDuration As String
        Dim dblPrice As Double
        Dim dblDeposit As Double = 30.0
        Dim fmtStr As String = "{0, -15} {1, -7} {2, -17}"
        'Clearing the list box
        lstCustomerBill.Items.Clear()
        'Data verification
        If IsNumeric(txtSelectItem.Text) Then
            If CInt(txtSelectItem.Text) >= 1 And CInt(txtSelectItem.Text) <= 3 Then
                'good data path
                Select Case CInt(txtSelectItem.Text)
                    Case 1
                        strItem = "Rug cleaner"
                    Case 2
                        strItem = "Lawn mower"
                    Case 3
                        strItem = "Paint sprayer"
                End Select
            End If
        Else
            MessageBox.Show("Please Enter 1, 2, or 3!", "DUH!")

        End If
        'Data verification
        If txtSelectDuration.Text.ToUpper = "H" Or txtSelectDuration.Text.ToUpper = "F" Then
            'good data path
            If txtSelectDuration.Text.ToUpper = "H" Then
                strDuration = "Half-day"
                Select Case CInt(txtSelectItem.Text)
                    Case 1
                        dblPrice = 16.0
                    Case 2
                        dblPrice = 12.0
                    Case 3
                        dblPrice = 20.0
                End Select
            Else
                If txtSelectDuration.Text.ToUpper = "F" Then
                    strDuration = "Full-day"
                    Select Case CInt(txtSelectItem.Text)
                        Case 1
                            dblPrice = 24.0
                        Case 2
                            dblPrice = 18.0
                        Case 3
                            dblPrice = 30.0
                    End Select
                End If

            End If
        Else
            MessageBox.Show("Please Enter H or F", "DUH!")
        End If
        'listing all the info in the list box
        lstCustomerBill.Items.Add("Receipt from Eddie's Equipment Rental")
        lstCustomerBill.Items.Add("")
        lstCustomerBill.Items.Add(String.Format(fmtStr, strItem, FormatCurrency(dblPrice), "(" & strDuration & " " & "rental" & ")"))
        lstCustomerBill.Items.Add(String.Format(fmtStr, "Deposit", FormatCurrency(dblDeposit), ""))
        lstCustomerBill.Items.Add("")
        lstCustomerBill.Items.Add(String.Format(fmtStr, "Total", FormatCurrency(dblPrice + dblDeposit), ""))

    End Sub
End Class
