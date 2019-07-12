<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.components = New System.ComponentModel.Container()
        Me.lbMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCar = New System.Windows.Forms.ListView()
        Me.chNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbMake
        '
        Me.lbMake.Location = New System.Drawing.Point(54, 13)
        Me.lbMake.Name = "lbMake"
        Me.lbMake.Size = New System.Drawing.Size(51, 23)
        Me.lbMake.TabIndex = 0
        Me.lbMake.Text = "&Make:"
        Me.lbMake.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbMake, "This is the label for Make")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Hyundai", "Honda", "Mercedes", "BMW", "Volkswagen", "Chevrolet", "Kia", "GMC"})
        Me.cmbMake.Location = New System.Drawing.Point(138, 13)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 24)
        Me.cmbMake.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbMake, "This is the combo box for make")
        '
        'lbModel
        '
        Me.lbModel.Location = New System.Drawing.Point(54, 54)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(51, 23)
        Me.lbModel.TabIndex = 2
        Me.lbModel.Text = "&Model:"
        Me.ToolTip1.SetToolTip(Me.lbModel, "This is the label for Model")
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(138, 55)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 22)
        Me.tbModel.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbModel, "This is the textbox for Model")
        '
        'lbYear
        '
        Me.lbYear.Location = New System.Drawing.Point(54, 94)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(100, 23)
        Me.lbYear.TabIndex = 4
        Me.lbYear.Text = "&Year:"
        Me.ToolTip1.SetToolTip(Me.lbYear, "This is the label for Year")
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(138, 85)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 24)
        Me.cmbYear.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cmbYear, "This is the combobox for Year")
        '
        'lbPrice
        '
        Me.lbPrice.Location = New System.Drawing.Point(54, 131)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(100, 23)
        Me.lbPrice.TabIndex = 6
        Me.lbPrice.Text = "&Price:"
        Me.ToolTip1.SetToolTip(Me.lbPrice, "This is the label for Price")
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(138, 131)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 22)
        Me.tbPrice.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tbPrice, "t")
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(12, 168)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(104, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.chkNew, "This is a check box")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCar
        '
        Me.lvwCar.CheckBoxes = True
        Me.lvwCar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNew, Me.chID, Me.chMake, Me.chModel, Me.chYear, Me.chPrice})
        Me.lvwCar.FullRowSelect = True
        Me.lvwCar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCar.Location = New System.Drawing.Point(12, 198)
        Me.lvwCar.MultiSelect = False
        Me.lvwCar.Name = "lvwCar"
        Me.lvwCar.Size = New System.Drawing.Size(392, 259)
        Me.lvwCar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.lvwCar, "This is the list view for cars")
        Me.lvwCar.UseCompatibleStateImageBehavior = False
        Me.lvwCar.View = System.Windows.Forms.View.Details
        '
        'chNew
        '
        Me.chNew.Text = "New"
        '
        'chID
        '
        Me.chID.Text = "ID"
        '
        'chMake
        '
        Me.chMake.Text = "Make"
        '
        'chModel
        '
        Me.chModel.Text = "Model"
        '
        'chYear
        '
        Me.chYear.Text = "Year"
        '
        'chPrice
        '
        Me.chPrice.Text = "Price"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 568)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 34)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "This is the Enter Button")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(184, 568)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "This is the Reset Button")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(329, 568)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 34)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "This is the button for Exit Button")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(12, 460)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(392, 81)
        Me.lbResult.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.lbResult, "This label will show the result")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(422, 614)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lvwCar)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.lbModel)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lbMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMake As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lbModel As Label
    Friend WithEvents tbModel As TextBox
    Friend WithEvents lbYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents lbPrice As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCar As ListView
    Friend WithEvents chNew As ColumnHeader
    Friend WithEvents chID As ColumnHeader
    Friend WithEvents chMake As ColumnHeader
    Friend WithEvents chModel As ColumnHeader
    Friend WithEvents chYear As ColumnHeader
    Friend WithEvents chPrice As ColumnHeader
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbResult As Label
End Class
