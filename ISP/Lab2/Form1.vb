Public Class Form1
    'Declare constant base package prices 
    Private Const PCK_A As Double = 9.95
	Private Const PCK_B As Double = 14.95
	Private Const PCK_C As Double = 19.95
    'Declare amount of hours that are included with base price
    Private Const PCK_A_hrs As Integer = 10
	Private Const PCK_B_hrs As Integer = 20
    'Declare additional price per hour for package A and B
    Private Const PCK_A_extra As Double = 2.0
	Private Const PCK_B_extra As Double = 1.0
    'Declare nonprofit percentage as a double (20%)
    Private Const nonPrft As Double = 0.2
	'Delcare the maximum amount of hours to be used in a month
	Private Const maxHrs As Integer = 744

	Private Sub radPckA_CheckedChanged(sender As Object, e As EventArgs) Handles radPckA.CheckedChanged, radPckB.CheckedChanged, radPckC.CheckedChanged
		If radPckA.Checked Then
			lblStatus.Text = "10 hours of access for $9.95/month. Extra hours are $2.00/hour."

		ElseIf radPckB.Checked Then
			lblStatus.Text = "20 hours of access for $14.95/month. Extra hours are $1.00/hour."

		Else
			lblStatus.Text = "Unlimited access for $19.95/month."
		End If

	End Sub

	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		'Create local variables that will hold the clients selected Package, the corresponding hours included with package 
		' and the price for extra hours
		Dim pckgPrice As Double
		Dim pckgHrs As Integer
		Dim pckgExtrHrs As Double
		'num will be used with Integer.TryParse to obtain the string value of the amount of access used by client
		Dim num As Integer
		Integer.TryParse(txtHours.Text, num)
		'Create variable that will hold the remaining number of hours if the current package has exceeded the hours available
		Dim hrsRem As Integer
		'total will be assigned to the final total 
		Dim total As Double = 0.00

		'Determine which package the client has selected and assign proper values
		If radPckA.Checked Then
			pckgPrice = PCK_A
			pckgHrs = PCK_A_hrs
			pckgExtrHrs = PCK_A_extra

			'If the amount of access hours used exceeds package hours then obtain difference between hours used and package hours
			If num > pckgHrs And num < maxHrs Then
				hrsRem = num - pckgHrs
				total = pckgPrice + (hrsRem * pckgExtrHrs)

			ElseIf num <= pckgHrs Then
				total = pckgPrice

			Else
				lblStatus.Text = "You have exceeded the maximum amount of hours. Please enter a lower number."
			End If

		ElseIf radPckB.Checked Then
			pckgPrice = PCK_B
			pckgHrs = PCK_B_hrs
			pckgExtrHrs = PCK_B_extra

			If num > pckgHrs And num < maxHrs Then
				hrsRem = num - pckgHrs
				total = pckgPrice + (hrsRem * pckgExtrHrs)

			ElseIf num <= pckgHrs Then
				total = pckgPrice

			Else
				lblStatus.Text = "You have exceeded the maximum amount of hours. Please enter a lower number."
			End If


		Else
			'Package C gives the client unlimited access so no package hours or extra hours are needed.
			pckgPrice = PCK_C
			total = pckgPrice

			If num > maxHrs Then
				lblStatus.Text = "You have exceeded the maximum amount of hours. Please enter a lower number."
				total = 0
			End If
		End If

		'Determine if the client chooses non-profit option
		If chkNPrft.Checked Then
			total = total - (total * nonPrft)
		End If

		lblTotal.Text = total.ToString("c")

	End Sub

End Class
