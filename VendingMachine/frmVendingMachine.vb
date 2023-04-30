' Program:      Vending Machine
' Author:       Mark Bulmer
' Date:         April 9, 2022
' Purpose:      This application functions as a vending machine, accepting money from users,
'               asking for a selection, and then providing change. It is incomplete and has
'               been stripped of non-functioning code so that it may launch. Not all functions
'               have been implemented correctly. 

Option Strict On

Public Class frmVendingMachine

    Dim Amount As Integer

    Private Sub btnNickel_Click(sender As Object, e As EventArgs) Handles btnNickel.Click
        ' This button is intended to accept user input of $0.05 but is not set up
        ' to increment correctly.

        Dim Amount As Double

        Amount = Amount + 0.05 ' I know this is wrong but I am leaving it for posterity's sake.

        lblAmountInserted.Text = "Amount Inserted: $" & Amount.ToString()
        ' Update amount inserted text.
    End Sub

    Private Sub btnDime_Click(sender As Object, e As EventArgs) Handles btnDime.Click
        ' This button is intended to accept user input of $0.10 but is not set up
        ' to increment correctly.

        Dim Amount As Double

        Amount = Amount + 0.1

        lblAmountInserted.Text = "Amount Inserted: $" & Amount.ToString()
        ' Update amount inserted text.
    End Sub

    Private Sub btnQuarter_Click(sender As Object, e As EventArgs) Handles btnQuarter.Click
        ' This button is intended to accept user input of $0.10 but is not set up
        ' to increment correctly.

        Dim Amount As Double

        Amount = Amount + 0.25

        lblAmountInserted.Text = "Amount Inserted: $" & Amount.ToString()
        ' Update amount inserted text.
    End Sub

    Private Sub btnDollar_Click(sender As Object, e As EventArgs) Handles btnDollar.Click
        ' This button is intended to accept user input of $1.00 but is not set up
        ' to increment correctly.

        Dim Amount As Double

        Amount = Amount + 1.0

        lblAmountInserted.Text = "Amount Inserted: $" & Amount.ToString()
        ' Update amount inserted text.
    End Sub


    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application.

        Close()
    End Sub

    Private Sub btnCocaCola_Click(sender As Object, e As EventArgs) Handles btnCocaCola.Click
        ' This button is intended to accept user selection of a Coca-Cola
        ' if at least $1.25 has been inserted, but I failed to work out the code.
        ' Something to this effect:
        ' If AmountInserted >= 1.25 Then:
        lblEnjoy.Text = "Please enjoy your Coca-Cola!"
        lblEnjoy.Visible = True
        ' Calculate change and distribute appropriately.
        ' Else: "Please insert $1.25"
    End Sub

    Private Sub btnDietCoke_Click(sender As Object, e As EventArgs) Handles btnDietCoke.Click
        ' This button is intended to accept user selection of a Diet Coke
        ' if at least $1.25 has been inserted, but I failed to work out the code.
        ' Something to this effect:
        ' If AmountInserted >= 1.25 Then:
        lblEnjoy.Text = "Please enjoy your Diet Coke!"
        lblEnjoy.Visible = True
        ' Calculate change and distribute appropriately.
        ' Else: "Please insert $1.25"
    End Sub

    Private Sub btnMountainDew_Click(sender As Object, e As EventArgs) Handles btnMountainDew.Click
        ' This button is intended to accept user selection of a Mountain Dew
        ' if at least $1.25 has been inserted, but I failed to work out the code.
        ' Something to this effect:
        ' If AmountInserted >= 1.25 Then:
        lblEnjoy.Text = "Please enjoy your Mountain Dew!"
        lblEnjoy.Visible = True
        ' Calculate change and distribute appropriately.
        ' Else: "Please insert $1.25"
    End Sub

    Private Sub btnDrPepper_Click(sender As Object, e As EventArgs) Handles btnDrPepper.Click
        ' This button is intended to accept user selection of a Dr Pepper
        ' if at least $1.25 has been inserted, but I failed to work out the code.
        ' Something to this effect:
        ' If AmountInserted >= 1.25 Then:
        lblEnjoy.Text = "Please enjoy your Dr Pepper!"
        lblEnjoy.Visible = True
        ' Calculate change and distribute appropriately.
        ' Else: "Please insert $1.25"
    End Sub

    Private Sub btnRootBeer_Click(sender As Object, e As EventArgs) Handles btnRootBeer.Click
        ' This button is intended to accept user selection of a Root Beer
        ' if at least $1.25 has been inserted, but I failed to work out the code.
        ' Something to this effect:
        ' If AmountInserted >= 1.25 Then:
        lblEnjoy.Text = "Please enjoy your Root Beer!"
        lblEnjoy.Visible = True
        ' Calculate change and distribute appropriately.
        ' Else: "Please insert $1.25"
    End Sub

    Private Sub btnOrangeSoda_Click(sender As Object, e As EventArgs) Handles btnOrangeSoda.Click
        ' This button is intended to accept user selection of an Orange Soda
        ' if at least $1.25 has been inserted, but I failed to work out the code.
        ' Something to this effect:
        ' If AmountInserted >= 1.25 Then:
        lblEnjoy.Text = "Please enjoy your Orange Soda!"
        lblEnjoy.Visible = True
        ' Calculate change and distribute appropriately.
        ' Else: "Please insert $1.25"
    End Sub
End Class