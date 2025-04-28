<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Product))
        txtBarcode = New TextBox()
        txtProductName = New TextBox()
        btnAdd = New Button()
        dgvProduct = New DataGridView()
        picProductImage = New PictureBox()
        btnBrowseImage = New Button()
        chkExpirationOption = New CheckBox()
        btnReset = New Button()
        btnDelete = New Button()
        btnEdit = New Button()
        lblFirstName = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PanelProduct = New Panel()
        Button3 = New Button()
        cboCategory = New ComboBox()
        Label1 = New Label()
        PanelCategory = New Panel()
        Button2 = New Button()
        btnCLose = New Button()
        txtSearch = New TextBox()
        CType(dgvProduct, ComponentModel.ISupportInitialize).BeginInit()
        CType(picProductImage, ComponentModel.ISupportInitialize).BeginInit()
        PanelProduct.SuspendLayout()
        PanelCategory.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtBarcode
        ' 
        txtBarcode.Font = New Font("Segoe UI", 10F)
        txtBarcode.Location = New Point(461, 81)
        txtBarcode.Name = "txtBarcode"
        txtBarcode.Size = New Size(610, 34)
        txtBarcode.TabIndex = 1
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Segoe UI", 10F)
        txtProductName.Location = New Point(461, 121)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(610, 34)
        txtProductName.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = SystemColors.ActiveCaptionText
        btnAdd.FlatStyle = FlatStyle.Flat
        btnAdd.ForeColor = SystemColors.ButtonHighlight
        btnAdd.Location = New Point(461, 238)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(149, 50)
        btnAdd.TabIndex = 9
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' dgvProduct
        ' 
        dgvProduct.AllowUserToAddRows = False
        dgvProduct.AllowUserToDeleteRows = False
        dgvProduct.AllowUserToResizeColumns = False
        dgvProduct.AllowUserToResizeRows = False
        dgvProduct.ColumnHeadersHeight = 34
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvProduct.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvProduct.Location = New Point(12, 85)
        dgvProduct.MultiSelect = False
        dgvProduct.Name = "dgvProduct"
        dgvProduct.ReadOnly = True
        dgvProduct.RowHeadersWidth = 62
        dgvProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        dgvProduct.Size = New Size(1730, 865)
        dgvProduct.TabIndex = 12
        ' 
        ' picProductImage
        ' 
        picProductImage.BackColor = SystemColors.ControlLight
        picProductImage.Location = New Point(23, 81)
        picProductImage.Name = "picProductImage"
        picProductImage.Size = New Size(221, 192)
        picProductImage.SizeMode = PictureBoxSizeMode.Zoom
        picProductImage.TabIndex = 11
        picProductImage.TabStop = False
        ' 
        ' btnBrowseImage
        ' 
        btnBrowseImage.BackColor = SystemColors.ActiveCaptionText
        btnBrowseImage.FlatStyle = FlatStyle.Flat
        btnBrowseImage.ForeColor = SystemColors.ButtonHighlight
        btnBrowseImage.Location = New Point(56, 279)
        btnBrowseImage.Name = "btnBrowseImage"
        btnBrowseImage.Size = New Size(158, 50)
        btnBrowseImage.TabIndex = 8
        btnBrowseImage.Text = "BROWSE IMAGE"
        btnBrowseImage.UseVisualStyleBackColor = False
        ' 
        ' chkExpirationOption
        ' 
        chkExpirationOption.AutoSize = True
        chkExpirationOption.Location = New Point(462, 203)
        chkExpirationOption.Name = "chkExpirationOption"
        chkExpirationOption.Size = New Size(158, 29)
        chkExpirationOption.TabIndex = 7
        chkExpirationOption.Text = "With Expiration"
        chkExpirationOption.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ControlDarkDark
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.ForeColor = SystemColors.ButtonHighlight
        btnReset.Location = New Point(926, 238)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(149, 50)
        btnReset.TabIndex = 12
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = SystemColors.ActiveCaptionText
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(771, 238)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(149, 50)
        btnDelete.TabIndex = 11
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ActiveCaptionText
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.ForeColor = SystemColors.ButtonHighlight
        btnEdit.Location = New Point(616, 238)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(149, 50)
        btnEdit.TabIndex = 10
        btnEdit.Text = "EDIT"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' lblFirstName
        ' 
        lblFirstName.BackColor = Color.Transparent
        lblFirstName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        lblFirstName.ForeColor = SystemColors.ActiveCaptionText
        lblFirstName.Location = New Point(260, 75)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(154, 36)
        lblFirstName.TabIndex = 27
        lblFirstName.Text = "Barcode :"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(260, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(191, 36)
        Label2.TabIndex = 28
        Label2.Text = "Product Name :"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(260, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 36)
        Label3.TabIndex = 29
        Label3.Text = "Category Name :"
        ' 
        ' PanelProduct
        ' 
        PanelProduct.Controls.Add(Button3)
        PanelProduct.Controls.Add(txtBarcode)
        PanelProduct.Controls.Add(picProductImage)
        PanelProduct.Controls.Add(btnBrowseImage)
        PanelProduct.Controls.Add(btnReset)
        PanelProduct.Controls.Add(cboCategory)
        PanelProduct.Controls.Add(txtProductName)
        PanelProduct.Controls.Add(btnDelete)
        PanelProduct.Controls.Add(btnEdit)
        PanelProduct.Controls.Add(btnAdd)
        PanelProduct.Controls.Add(Label3)
        PanelProduct.Controls.Add(Label2)
        PanelProduct.Controls.Add(lblFirstName)
        PanelProduct.Controls.Add(chkExpirationOption)
        PanelProduct.Location = New Point(297, 145)
        PanelProduct.Name = "PanelProduct"
        PanelProduct.Size = New Size(1089, 421)
        PanelProduct.TabIndex = 33
        PanelProduct.Visible = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.Transparent
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(1020, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(66, 50)
        Button3.TabIndex = 96
        Button3.UseVisualStyleBackColor = False
        ' 
        ' cboCategory
        ' 
        cboCategory.Font = New Font("Segoe UI", 10F)
        cboCategory.FormattingEnabled = True
        cboCategory.Items.AddRange(New Object() {"Dairy", "Meat & Poultry", "Beverages", "Canned Goods", "Snacks", "Bakery", "Frozen Foods", "Condiments & Sauces" & vbTab, "Grains & Pasta", "Baby Food & Products", "Household Items" & vbTab})
        cboCategory.Location = New Point(461, 161)
        cboCategory.Name = "cboCategory"
        cboCategory.Size = New Size(610, 36)
        cboCategory.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(26, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 32)
        Label1.TabIndex = 33
        Label1.Text = "PRODUCT LIST"
        ' 
        ' PanelCategory
        ' 
        PanelCategory.Controls.Add(Label1)
        PanelCategory.Location = New Point(12, 12)
        PanelCategory.Name = "PanelCategory"
        PanelCategory.Size = New Size(238, 67)
        PanelCategory.TabIndex = 38
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(1620, 29)
        Button2.Name = "Button2"
        Button2.Size = New Size(66, 50)
        Button2.TabIndex = 94
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnCLose
        ' 
        btnCLose.BackColor = Color.Transparent
        btnCLose.FlatAppearance.BorderSize = 0
        btnCLose.FlatStyle = FlatStyle.Flat
        btnCLose.ForeColor = Color.Transparent
        btnCLose.Image = CType(resources.GetObject("btnCLose.Image"), Image)
        btnCLose.Location = New Point(1676, 29)
        btnCLose.Name = "btnCLose"
        btnCLose.Size = New Size(66, 50)
        btnCLose.TabIndex = 93
        btnCLose.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F)
        txtSearch.Location = New Point(1376, 40)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = " 🔍 Search Product"
        txtSearch.Size = New Size(238, 39)
        txtSearch.TabIndex = 0
        ' 
        ' Product
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1754, 962)
        Controls.Add(Button2)
        Controls.Add(btnCLose)
        Controls.Add(txtSearch)
        Controls.Add(PanelProduct)
        Controls.Add(dgvProduct)
        Controls.Add(PanelCategory)
        FormBorderStyle = FormBorderStyle.None
        Name = "Product"
        Text = "Product Management"
        CType(dgvProduct, ComponentModel.ISupportInitialize).EndInit()
        CType(picProductImage, ComponentModel.ISupportInitialize).EndInit()
        PanelProduct.ResumeLayout(False)
        PanelProduct.PerformLayout()
        PanelCategory.ResumeLayout(False)
        PanelCategory.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private WithEvents txtBarcode As System.Windows.Forms.TextBox
    Private WithEvents txtProductName As System.Windows.Forms.TextBox
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Private WithEvents picProductImage As System.Windows.Forms.PictureBox
    Private WithEvents btnBrowseImage As System.Windows.Forms.Button
    Private WithEvents btnReset As Button
    Private WithEvents btnDelete As Button
    Private WithEvents btnEdit As Button
    Friend WithEvents chkExpirationOption As CheckBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelProduct As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCategory As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCLose As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button3 As Button
    Private WithEvents cboCategory As ComboBox
    Friend WithEvents id As DataGridViewTextBoxColumn
End Class
