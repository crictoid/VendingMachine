<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendingMachine
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNickel = New System.Windows.Forms.Button()
        Me.btnDime = New System.Windows.Forms.Button()
        Me.btnQuarter = New System.Windows.Forms.Button()
        Me.btnDollar = New System.Windows.Forms.Button()
        Me.btnDietCoke = New System.Windows.Forms.Button()
        Me.btnMountainDew = New System.Windows.Forms.Button()
        Me.btnDrPepper = New System.Windows.Forms.Button()
        Me.btnRootBeer = New System.Windows.Forms.Button()
        Me.btnOrangeSoda = New System.Windows.Forms.Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAmountInserted = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInsufficientFunds = New System.Windows.Forms.Label()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCocaCola = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNickel
        '
        Me.btnNickel.Location = New System.Drawing.Point(13, 13)
        Me.btnNickel.Name = "btnNickel"
        Me.btnNickel.Size = New System.Drawing.Size(55, 23)
        Me.btnNickel.TabIndex = 0
        Me.btnNickel.Text = "$0.05"
        Me.btnNickel.UseVisualStyleBackColor = True
        '
        'btnDime
        '
        Me.btnDime.Location = New System.Drawing.Point(13, 42)
        Me.btnDime.Name = "btnDime"
        Me.btnDime.Size = New System.Drawing.Size(55, 23)
        Me.btnDime.TabIndex = 1
        Me.btnDime.Text = "$0.10"
        Me.btnDime.UseVisualStyleBackColor = True
        '
        'btnQuarter
        '
        Me.btnQuarter.Location = New System.Drawing.Point(12, 71)
        Me.btnQuarter.Name = "btnQuarter"
        Me.btnQuarter.Size = New System.Drawing.Size(55, 23)
        Me.btnQuarter.TabIndex = 2
        Me.btnQuarter.Text = "$0.25"
        Me.btnQuarter.UseVisualStyleBackColor = True
        '
        'btnDollar
        '
        Me.btnDollar.Location = New System.Drawing.Point(13, 100)
        Me.btnDollar.Name = "btnDollar"
        Me.btnDollar.Size = New System.Drawing.Size(55, 23)
        Me.btnDollar.TabIndex = 3
        Me.btnDollar.Text = "$1.00"
        Me.btnDollar.UseVisualStyleBackColor = True
        '
        'btnDietCoke
        '
        Me.btnDietCoke.BackgroundImage = Global.VendingMachine.My.Resources.Resources.diet
        Me.btnDietCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDietCoke.Location = New System.Drawing.Point(100, 132)
        Me.btnDietCoke.Name = "btnDietCoke"
        Me.btnDietCoke.Size = New System.Drawing.Size(75, 140)
        Me.btnDietCoke.TabIndex = 5
        Me.btnDietCoke.UseVisualStyleBackColor = True
        '
        'btnMountainDew
        '
        Me.btnMountainDew.BackgroundImage = Global.VendingMachine.My.Resources.Resources.mtdew
        Me.btnMountainDew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMountainDew.Location = New System.Drawing.Point(194, 132)
        Me.btnMountainDew.Name = "btnMountainDew"
        Me.btnMountainDew.Size = New System.Drawing.Size(75, 140)
        Me.btnMountainDew.TabIndex = 6
        Me.btnMountainDew.UseVisualStyleBackColor = True
        '
        'btnDrPepper
        '
        Me.btnDrPepper.BackgroundImage = Global.VendingMachine.My.Resources.Resources.dr_pepper_soda
        Me.btnDrPepper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDrPepper.Location = New System.Drawing.Point(100, 272)
        Me.btnDrPepper.Name = "btnDrPepper"
        Me.btnDrPepper.Size = New System.Drawing.Size(75, 140)
        Me.btnDrPepper.TabIndex = 7
        Me.btnDrPepper.UseVisualStyleBackColor = True
        '
        'btnRootBeer
        '
        Me.btnRootBeer.BackgroundImage = Global.VendingMachine.My.Resources.Resources.root
        Me.btnRootBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRootBeer.Location = New System.Drawing.Point(12, 272)
        Me.btnRootBeer.Name = "btnRootBeer"
        Me.btnRootBeer.Size = New System.Drawing.Size(75, 140)
        Me.btnRootBeer.TabIndex = 8
        Me.btnRootBeer.UseVisualStyleBackColor = True
        '
        'btnOrangeSoda
        '
        Me.btnOrangeSoda.BackgroundImage = Global.VendingMachine.My.Resources.Resources.sunkist_orange_soda
        Me.btnOrangeSoda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrangeSoda.Location = New System.Drawing.Point(195, 272)
        Me.btnOrangeSoda.Name = "btnOrangeSoda"
        Me.btnOrangeSoda.Size = New System.Drawing.Size(75, 140)
        Me.btnOrangeSoda.TabIndex = 9
        Me.btnOrangeSoda.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(77, 52)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(111, 15)
        Me.lblPrice.TabIndex = 10
        Me.lblPrice.Text = "All Drinks: $1.25"
        '
        'lblAmountInserted
        '
        Me.lblAmountInserted.AutoSize = True
        Me.lblAmountInserted.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountInserted.Location = New System.Drawing.Point(77, 81)
        Me.lblAmountInserted.Name = "lblAmountInserted"
        Me.lblAmountInserted.Size = New System.Drawing.Size(157, 15)
        Me.lblAmountInserted.TabIndex = 11
        Me.lblAmountInserted.Text = "Amount Inserted: $0.00"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(176, 426)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(99, 15)
        Me.lblChange.TabIndex = 12
        Me.lblChange.Text = "Change: $0.00"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(194, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInsufficientFunds
        '
        Me.lblInsufficientFunds.AutoSize = True
        Me.lblInsufficientFunds.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInsufficientFunds.Location = New System.Drawing.Point(10, 441)
        Me.lblInsufficientFunds.Name = "lblInsufficientFunds"
        Me.lblInsufficientFunds.Size = New System.Drawing.Size(167, 15)
        Me.lblInsufficientFunds.TabIndex = 14
        Me.lblInsufficientFunds.Text = "Please insert $X.XX more"
        Me.lblInsufficientFunds.Visible = False
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Font = New System.Drawing.Font("Lucida Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoy.Location = New System.Drawing.Point(9, 456)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(196, 15)
        Me.lblEnjoy.TabIndex = 15
        Me.lblEnjoy.Text = "Please enjoy your XXXXXXXX"
        Me.lblEnjoy.Visible = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Lucida Sans", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(76, 13)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(199, 23)
        Me.lblHeading.TabIndex = 16
        Me.lblHeading.Text = "Vending Machine"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.VendingMachine.My.Resources.Resources.vending
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(298, -44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(340, 605)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnCocaCola
        '
        Me.btnCocaCola.BackgroundImage = Global.VendingMachine.My.Resources.Resources.coca_cola_original_12oz
        Me.btnCocaCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCocaCola.Location = New System.Drawing.Point(12, 132)
        Me.btnCocaCola.Name = "btnCocaCola"
        Me.btnCocaCola.Size = New System.Drawing.Size(75, 140)
        Me.btnCocaCola.TabIndex = 4
        Me.btnCocaCola.UseVisualStyleBackColor = True
        '
        'frmVendingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(633, 515)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.lblInsufficientFunds)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.lblAmountInserted)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.btnOrangeSoda)
        Me.Controls.Add(Me.btnRootBeer)
        Me.Controls.Add(Me.btnDrPepper)
        Me.Controls.Add(Me.btnMountainDew)
        Me.Controls.Add(Me.btnDietCoke)
        Me.Controls.Add(Me.btnCocaCola)
        Me.Controls.Add(Me.btnDollar)
        Me.Controls.Add(Me.btnQuarter)
        Me.Controls.Add(Me.btnDime)
        Me.Controls.Add(Me.btnNickel)
        Me.Name = "frmVendingMachine"
        Me.Text = "Vending Machine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNickel As Button
    Friend WithEvents btnDime As Button
    Friend WithEvents btnQuarter As Button
    Friend WithEvents btnDollar As Button
    Friend WithEvents btnCocaCola As Button
    Friend WithEvents btnDietCoke As Button
    Friend WithEvents btnMountainDew As Button
    Friend WithEvents btnDrPepper As Button
    Friend WithEvents btnRootBeer As Button
    Friend WithEvents btnOrangeSoda As Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAmountInserted As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblInsufficientFunds As Label
    Friend WithEvents lblEnjoy As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
