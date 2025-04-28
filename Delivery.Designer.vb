<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delivery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    'Note: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim btnClear As Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delivery))
        lblTransactionNumber = New Label()
        lblSupplierID = New Label()
        cmbSupplierID = New ComboBox()
        lblProductID = New Label()
        cmbProductID = New ComboBox()
        lblQuantity = New Label()
        txtQuantity = New TextBox()
        lblSellingPrice = New Label()
        txtSellingPrice = New TextBox()
        lblCostPrice = New Label()
        txtCostPrice = New TextBox()
        lblExpirationDate = New Label()
        dtpExpirationDate = New DateTimePicker()
        lblDeliveryDate = New Label()
        dtpDeliveryDate = New DateTimePicker()
        btnConfirm = New Button()
        dgvPendingItems = New DataGridView()
        txtBarcode = New TextBox()
        lblBarcodeScan = New Label()
        btnSave = New Button()
        cmbUserFullName = New ComboBox()
        btnEdit = New Button()
        Label1 = New Label()
        btnCLose = New Button()
        prodtxt = New TextBox()
        txtReceivedBy = New TextBox()
        Button1 = New Button()
        btnClear = New Button()
        CType(dgvPendingItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = SystemColors.ControlDarkDark
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = SystemColors.ButtonHighlight
        btnClear.Location = New Point(1257, 704)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(149, 50)
        btnClear.TabIndex = 19
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' lblTransactionNumber
        ' 
        lblTransactionNumber.AutoSize = True
        lblTransactionNumber.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTransactionNumber.Location = New Point(12, 9)
        lblTransactionNumber.Name = "lblTransactionNumber"
        lblTransactionNumber.Size = New Size(255, 32)
        lblTransactionNumber.TabIndex = 0
        lblTransactionNumber.Text = "Transaction Number:"
        lblTransactionNumber.Visible = False
        ' 
        ' lblSupplierID
        ' 
        lblSupplierID.AutoSize = True
        lblSupplierID.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblSupplierID.Location = New Point(10, 177)
        lblSupplierID.Name = "lblSupplierID"
        lblSupplierID.Size = New Size(82, 21)
        lblSupplierID.TabIndex = 4
        lblSupplierID.Text = "Supplier :"
        ' 
        ' cmbSupplierID
        ' 
        cmbSupplierID.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSupplierID.FormattingEnabled = True
        cmbSupplierID.Location = New Point(156, 177)
        cmbSupplierID.Name = "cmbSupplierID"
        cmbSupplierID.Size = New Size(250, 33)
        cmbSupplierID.TabIndex = 5
        ' 
        ' lblProductID
        ' 
        lblProductID.AutoSize = True
        lblProductID.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblProductID.Location = New Point(11, 217)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(78, 21)
        lblProductID.TabIndex = 6
        lblProductID.Text = "Product :"
        ' 
        ' cmbProductID
        ' 
        cmbProductID.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProductID.FormattingEnabled = True
        cmbProductID.Location = New Point(156, 217)
        cmbProductID.Name = "cmbProductID"
        cmbProductID.Size = New Size(250, 33)
        cmbProductID.TabIndex = 7
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblQuantity.Location = New Point(422, 64)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(81, 21)
        lblQuantity.TabIndex = 8
        lblQuantity.Text = "Quantity:"
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(567, 64)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(250, 31)
        txtQuantity.TabIndex = 9
        ' 
        ' lblSellingPrice
        ' 
        lblSellingPrice.AutoSize = True
        lblSellingPrice.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblSellingPrice.Location = New Point(423, 104)
        lblSellingPrice.Name = "lblSellingPrice"
        lblSellingPrice.Size = New Size(109, 21)
        lblSellingPrice.TabIndex = 10
        lblSellingPrice.Text = "Selling Price:"
        ' 
        ' txtSellingPrice
        ' 
        txtSellingPrice.Location = New Point(567, 104)
        txtSellingPrice.Name = "txtSellingPrice"
        txtSellingPrice.Size = New Size(250, 31)
        txtSellingPrice.TabIndex = 11
        ' 
        ' lblCostPrice
        ' 
        lblCostPrice.AutoSize = True
        lblCostPrice.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblCostPrice.Location = New Point(423, 144)
        lblCostPrice.Name = "lblCostPrice"
        lblCostPrice.Size = New Size(89, 21)
        lblCostPrice.TabIndex = 12
        lblCostPrice.Text = "Cost Price:"
        ' 
        ' txtCostPrice
        ' 
        txtCostPrice.Location = New Point(567, 144)
        txtCostPrice.Name = "txtCostPrice"
        txtCostPrice.Size = New Size(250, 31)
        txtCostPrice.TabIndex = 13
        ' 
        ' lblExpirationDate
        ' 
        lblExpirationDate.AutoSize = True
        lblExpirationDate.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblExpirationDate.Location = New Point(423, 184)
        lblExpirationDate.Name = "lblExpirationDate"
        lblExpirationDate.Size = New Size(133, 21)
        lblExpirationDate.TabIndex = 14
        lblExpirationDate.Text = "Expiration Date:"
        ' 
        ' dtpExpirationDate
        ' 
        dtpExpirationDate.Format = DateTimePickerFormat.Short
        dtpExpirationDate.Location = New Point(567, 184)
        dtpExpirationDate.Name = "dtpExpirationDate"
        dtpExpirationDate.Size = New Size(250, 31)
        dtpExpirationDate.TabIndex = 15
        dtpExpirationDate.Value = New Date(2025, 4, 25, 0, 0, 0, 0)
        ' 
        ' lblDeliveryDate
        ' 
        lblDeliveryDate.AutoSize = True
        lblDeliveryDate.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblDeliveryDate.Location = New Point(423, 224)
        lblDeliveryDate.Name = "lblDeliveryDate"
        lblDeliveryDate.Size = New Size(119, 21)
        lblDeliveryDate.TabIndex = 16
        lblDeliveryDate.Text = "Delivery Date:"
        ' 
        ' dtpDeliveryDate
        ' 
        dtpDeliveryDate.Format = DateTimePickerFormat.Short
        dtpDeliveryDate.Location = New Point(567, 224)
        dtpDeliveryDate.Name = "dtpDeliveryDate"
        dtpDeliveryDate.Size = New Size(250, 31)
        dtpDeliveryDate.TabIndex = 17
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = SystemColors.ActiveCaptionText
        btnConfirm.FlatStyle = FlatStyle.Flat
        btnConfirm.ForeColor = SystemColors.ButtonHighlight
        btnConfirm.Location = New Point(833, 201)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(149, 50)
        btnConfirm.TabIndex = 18
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' dgvPendingItems
        ' 
        dgvPendingItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPendingItems.Location = New Point(12, 261)
        dgvPendingItems.Name = "dgvPendingItems"
        dgvPendingItems.RowHeadersWidth = 62
        dgvPendingItems.Size = New Size(1394, 437)
        dgvPendingItems.TabIndex = 20
        ' 
        ' txtBarcode
        ' 
        txtBarcode.Location = New Point(156, 64)
        txtBarcode.Name = "txtBarcode"
        txtBarcode.Size = New Size(250, 31)
        txtBarcode.TabIndex = 1
        ' 
        ' lblBarcodeScan
        ' 
        lblBarcodeScan.AutoSize = True
        lblBarcodeScan.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lblBarcodeScan.Location = New Point(12, 64)
        lblBarcodeScan.Name = "lblBarcodeScan"
        lblBarcodeScan.Size = New Size(80, 21)
        lblBarcodeScan.TabIndex = 21
        lblBarcodeScan.Text = "Barcode :"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = SystemColors.ActiveCaptionText
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = SystemColors.ButtonHighlight
        btnSave.Location = New Point(947, 704)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(149, 50)
        btnSave.TabIndex = 22
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = False
        btnSave.Visible = False
        ' 
        ' cmbUserFullName
        ' 
        cmbUserFullName.FormattingEnabled = True
        cmbUserFullName.Location = New Point(156, 138)
        cmbUserFullName.Name = "cmbUserFullName"
        cmbUserFullName.Size = New Size(250, 33)
        cmbUserFullName.TabIndex = 23
        cmbUserFullName.Visible = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ActiveCaptionText
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.ForeColor = SystemColors.ButtonHighlight
        btnEdit.Location = New Point(1102, 704)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(149, 50)
        btnEdit.TabIndex = 24
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label1.Location = New Point(12, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 21)
        Label1.TabIndex = 25
        Label1.Text = "Received By :"
        ' 
        ' btnCLose
        ' 
        btnCLose.BackColor = Color.Transparent
        btnCLose.FlatAppearance.BorderSize = 0
        btnCLose.FlatStyle = FlatStyle.Flat
        btnCLose.ForeColor = Color.Transparent
        btnCLose.Image = CType(resources.GetObject("btnCLose.Image"), Image)
        btnCLose.Location = New Point(1706, 8)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(66, 50)
        btnCLose.TabIndex = 70
        btnCLose.UseVisualStyleBackColor = False
        ' 
        ' prodtxt
        ' 
        prodtxt.Location = New Point(870, 64)
        prodtxt.Name = "prodtxt"
        prodtxt.Size = New Size(250, 31)
        prodtxt.TabIndex = 71
        ' 
        ' txtReceivedBy
        ' 
        txtReceivedBy.Location = New Point(156, 138)
        txtReceivedBy.Name = "txtReceivedBy"
        txtReceivedBy.Size = New Size(250, 31)
        txtReceivedBy.TabIndex = 72
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.Transparent
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(1286, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(66, 50)
        Button1.TabIndex = 94
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Delivery
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1447, 763)
        Controls.Add(Button1)
        Controls.Add(txtReceivedBy)
        Controls.Add(prodtxt)
        Controls.Add(btnCLose)
        Controls.Add(Label1)
        Controls.Add(btnEdit)
        Controls.Add(cmbUserFullName)
        Controls.Add(btnSave)
        Controls.Add(txtBarcode)
        Controls.Add(lblBarcodeScan)
        Controls.Add(dgvPendingItems)
        Controls.Add(btnClear)
        Controls.Add(btnConfirm)
        Controls.Add(dtpDeliveryDate)
        Controls.Add(lblDeliveryDate)
        Controls.Add(dtpExpirationDate)
        Controls.Add(lblExpirationDate)
        Controls.Add(txtCostPrice)
        Controls.Add(lblCostPrice)
        Controls.Add(txtSellingPrice)
        Controls.Add(lblSellingPrice)
        Controls.Add(txtQuantity)
        Controls.Add(lblQuantity)
        Controls.Add(cmbProductID)
        Controls.Add(lblProductID)
        Controls.Add(cmbSupplierID)
        Controls.Add(lblSupplierID)
        Controls.Add(lblTransactionNumber)
        FormBorderStyle = FormBorderStyle.None
        Name = "Delivery"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delivery"
        CType(dgvPendingItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    'Form Controls
    Private WithEvents lblTransactionNumber As Label
    Private WithEvents lblSupplierID As Label
    Private WithEvents cmbSupplierID As ComboBox
    Private WithEvents lblProductID As Label
    Private WithEvents cmbProductID As ComboBox
    Private WithEvents lblQuantity As Label
    Private WithEvents txtQuantity As TextBox
    Private WithEvents lblSellingPrice As Label
    Private WithEvents txtSellingPrice As TextBox
    Private WithEvents lblCostPrice As Label
    Private WithEvents txtCostPrice As TextBox
    Private WithEvents lblExpirationDate As Label
    Private WithEvents dtpExpirationDate As DateTimePicker
    Private WithEvents lblDeliveryDate As Label
    Private WithEvents dtpDeliveryDate As DateTimePicker
    Private WithEvents btnConfirm As Button
    Private WithEvents btnClear As Button
    Friend WithEvents dgvPendingItems As DataGridView
    Private WithEvents txtBarcode As TextBox
    Private WithEvents lblBarcodeScan As Label
    Private WithEvents btnSave As Button
    Friend WithEvents cmbUserFullName As ComboBox
    Private WithEvents btnEdit As Button
    Private WithEvents Label1 As Label
    Friend WithEvents btnCLose As Button
    Private WithEvents prodtxt As TextBox
    Private WithEvents txtReceivedBy As TextBox
    Friend WithEvents Button1 As Button

End Class
