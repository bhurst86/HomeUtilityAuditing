Public Class MainForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbAppliance.SelectedIndex = 0
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAppliance.SelectedIndexChanged
        lblStatus.Text = ("Enter the amount of kiloWatts to run the appliance")

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim costPerKilowatt As Double
        Dim amountOfKilowatt As Double
        Dim runTime As Double

        Static Dim refrigeratorCost As Double
        Static Dim tvCost As Double
        Static Dim spaceHeaterCost As Double
        Static Dim fanCost As Double
        Static Dim dryerCost As Double
        Static Dim ovenCost As Double
        Static Dim laundryWasherCost As Double
        Static Dim clothWasherCost As Double

        Try
            costPerKilowatt = CDbl(txtKwattPerHour.Text)
            amountOfKilowatt = CDbl(txtAmountKwatts.Text)
            runTime = CDbl(txtRunTime.Text)
            If costPerKilowatt <= 3 Then
                If amountOfKilowatt < 1000 Then
                    If runTime <= 24 Then

                    Else
                        MessageBox.Show("Must be 24 hours or less")
                        txtRunTime.Focus()
                        txtRunTime.SelectionStart = 0
                        txtRunTime.SelectionLength = 2
                        Return
                    End If

                Else
                    MessageBox.Show("Number must be less than 1000 kW")
                    txtAmountKwatts.Focus()
                    txtAmountKwatts.SelectionStart = 0
                    txtAmountKwatts.SelectionLength = 4
                    Return
                End If

            Else
                MessageBox.Show("Number must be less than 3 dollars")
                txtKwattPerHour.Focus()
                txtKwattPerHour.SelectionStart = 0
                txtKwattPerHour.SelectionLength = 3
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("Error")
            lblTotal.Text = "$0.00"
            Return
        End Try

        If cmbAppliance.SelectedIndex = 0 Then
            ListBox1.Items.Add("Refrigerator")
            ListBox2.Items.Add(costPerKilowatt)
            ListBox3.Items.Add(amountOfKilowatt)
            ListBox4.Items.Add(runTime)
            refrigeratorCost = (amountOfKilowatt * costPerKilowatt) * runTime
            ListBox5.Items.Add(FormatCurrency(refrigeratorCost, 0, 0, 0))

        ElseIf cmbAppliance.SelectedIndex = 1 Then
            ListBox1.Items.Add("TV")
            ListBox2.Items.Add(costPerKilowatt)
            ListBox3.Items.Add(amountOfKilowatt)
            ListBox4.Items.Add(runTime)
            tvCost = (amountOfKilowatt * costPerKilowatt) * runTime
            ListBox5.Items.Add(FormatCurrency(tvCost, 0, 0, 0))

        ElseIf cmbAppliance.SelectedIndex = 2 Then
            ListBox1.Items.Add("Space Heater")
            ListBox2.Items.Add(costPerKilowatt)
            ListBox3.Items.Add(amountOfKilowatt)
            ListBox4.Items.Add(runTime)
            spaceHeaterCost = (amountOfKilowatt * costPerKilowatt) * runTime
            ListBox5.Items.Add(FormatCurrency(spaceHeaterCost, 0, 0, 0))

        ElseIf cmbAppliance.SelectedIndex = 3 Then
            ListBox1.Items.Add("Fan")
            ListBox2.Items.Add(costPerKilowatt)
            ListBox3.Items.Add(amountOfKilowatt)
            ListBox4.Items.Add(runTime)
            fanCost = (amountOfKilowatt * costPerKilowatt) * runTime
            ListBox5.Items.Add(FormatCurrency(fanCost, 0, 0, 0))

        ElseIf cmbAppliance.SelectedIndex = 4 Then
            ListBox1.Items.Add("Dryer")
            ListBox2.Items.Add(costPerKilowatt)
            ListBox3.Items.Add(amountOfKilowatt)
            ListBox4.Items.Add(runTime)
            dryerCost = (amountOfKilowatt * costPerKilowatt) * runTime
            ListBox5.Items.Add(FormatCurrency(dryerCost, 0, 0, 0))

        ElseIf cmbAppliance.SelectedIndex = 5 Then
            ListBox1.Items.Add("Oven")
            ListBox2.Items.Add(costPerKilowatt)
            ListBox3.Items.Add(amountOfKilowatt)
            ListBox4.Items.Add(runTime)
            ovenCost = CDec(amountOfKilowatt * costPerKilowatt) * CDec(runTime)
            ListBox5.Items.Add(FormatCurrency(ovenCost, 0, 0, 0))

        ElseIf cmbAppliance.SelectedIndex = 6 Then
            ListBox1.Items.Add("Laudry Washer")
            ListBox2.Items.Add(costPerKilowatt)
            ListBox3.Items.Add(amountOfKilowatt)
            ListBox4.Items.Add(runTime)

            ListBox5.Items.Add(FormatCurrency(laundryWasherCost, 0, 0, 0))

        ElseIf cmbAppliance.SelectedIndex = 7 Then
            ListBox1.Items.Add("Cloth Washer")
                            ListBox2.Items.Add(costPerKilowatt)
                            ListBox3.Items.Add(amountOfKilowatt)
                            ListBox4.Items.Add(runTime)

                            ListBox5.Items.Add(FormatCurrency(clothWasherCost, 0, 0, 0))

                        End If




            Dim totalCost As Decimal

        'Need to set a default of $0.12 for cost per hour

        cmbAppliance.SelectedIndex = 0

        totalCost = CDec(refrigeratorCost + tvCost + spaceHeaterCost + fanCost + dryerCost + ovenCost)

        lblTotal.Text = FormatCurrency(totalCost, 0, 0, 0)



    End Sub

    Private Sub txtAmountKwatts_TextChanged(sender As Object, e As EventArgs) Handles txtAmountKwatts.TextChanged
        lblStatus.Text = ("Enter in the amount of time the appliance is ran in a day")

    End Sub

    Private Sub txtRunTime_TextChanged(sender As Object, e As EventArgs) Handles txtRunTime.TextChanged
        lblStatus.Text = ("Click Add Item")
    End Sub

    Private Sub txtKwattPerHour_TextChanged(sender As Object, e As EventArgs) Handles txtKwattPerHour.TextChanged
        lblStatus.Text = ("Select an Appliance")


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If MessageBox.Show("Are you sure?", "Confirm",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        lblTotal.Text = ("$0.00")

    End Sub
End Class
