﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
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

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' Buttons declaration
    Private WithEvents btnDashboard As Button
    Private WithEvents btnMaintenance As Button
    Private WithEvents btnReports As Button
    Private WithEvents btnInventory As Button
    Private WithEvents btnPOS As Button

    ' Label declaration
    Friend WithEvents lblWelcome As Label

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        btnDashboard = New Button()
        btnMaintenance = New Button()
        btnReports = New Button()
        btnInventory = New Button()
        btnPOS = New Button()
        lblWelcome = New Label()
        lblTotalProduct = New Label()
        UserPanel = New Panel()
        PictureBox8 = New PictureBox()
        Label7 = New Label()
        lblDateTime = New Label()
        ButtonPanel = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        Panel5 = New Panel()
        MainPanel = New Panel()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label6 = New Label()
        PictureBox5 = New PictureBox()
        lblCriticalItems = New Label()
        PanelQuantityStock = New Panel()
        Label5 = New Label()
        PictureBox4 = New PictureBox()
        lblQuantityStock = New Label()
        PanelTotalSales = New Panel()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        lblTotalSales = New Label()
        PanelTotalProduct = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        PanelUser = New Panel()
        ContextMenuStripMaintenance = New ContextMenuStrip(components)
        UserToolStripMenuItem = New ToolStripMenuItem()
        SupplierToolStripMenuItem = New ToolStripMenuItem()
        CategoryToolStripMenuItem = New ToolStripMenuItem()
        ProductToolStripMenuItem = New ToolStripMenuItem()
        DiscountToolStripMenuItem = New ToolStripMenuItem()
        VatToolStripMenuItem = New ToolStripMenuItem()
        Timer1 = New Timer(components)
        btnSettings = New Button()
        ContextMenuStripReports = New ContextMenuStrip(components)
        SalesReportsToolStripMenuItem = New ToolStripMenuItem()
        FastMovingProductsToolStripMenuItem = New ToolStripMenuItem()
        ExpirationReportsToolStripMenuItem = New ToolStripMenuItem()
        VoidedTransactionToolStripMenuItem = New ToolStripMenuItem()
        StockInReportsToolStripMenuItem = New ToolStripMenuItem()
        ContextMenuStripSettings = New ContextMenuStrip(components)
        AuditTrailToolStripMenuItem = New ToolStripMenuItem()
        LogHistoryToolStripMenuItem = New ToolStripMenuItem()
        btnLogOut = New Button()
        PictureBox1 = New PictureBox()
        btnBackup = New Button()
        Timer2 = New Timer(components)
        btnChangePassword = New Button()
        UserPanel.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        ButtonPanel.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        MainPanel.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PanelQuantityStock.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalSales.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelTotalProduct.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        PanelUser.SuspendLayout()
        ContextMenuStripMaintenance.SuspendLayout()
        ContextMenuStripReports.SuspendLayout()
        ContextMenuStripSettings.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnDashboard
        ' 
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.Location = New Point(3, 190)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(110, 57)
        btnDashboard.TabIndex = 0
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnMaintenance
        ' 
        btnMaintenance.BackColor = Color.Transparent
        btnMaintenance.FlatStyle = FlatStyle.Flat
        btnMaintenance.Image = CType(resources.GetObject("btnMaintenance.Image"), Image)
        btnMaintenance.Location = New Point(3, 258)
        btnMaintenance.Name = "btnMaintenance"
        btnMaintenance.Size = New Size(110, 57)
        btnMaintenance.TabIndex = 1
        btnMaintenance.UseVisualStyleBackColor = False
        ' 
        ' btnReports
        ' 
        btnReports.BackColor = Color.Transparent
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Image = CType(resources.GetObject("btnReports.Image"), Image)
        btnReports.Location = New Point(3, 462)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(110, 57)
        btnReports.TabIndex = 2
        btnReports.UseVisualStyleBackColor = False
        ' 
        ' btnInventory
        ' 
        btnInventory.BackColor = Color.Transparent
        btnInventory.FlatStyle = FlatStyle.Flat
        btnInventory.Image = CType(resources.GetObject("btnInventory.Image"), Image)
        btnInventory.Location = New Point(3, 327)
        btnInventory.Name = "btnInventory"
        btnInventory.Size = New Size(110, 57)
        btnInventory.TabIndex = 3
        btnInventory.UseVisualStyleBackColor = False
        ' 
        ' btnPOS
        ' 
        btnPOS.BackColor = Color.Transparent
        btnPOS.FlatStyle = FlatStyle.Flat
        btnPOS.Image = CType(resources.GetObject("btnPOS.Image"), Image)
        btnPOS.Location = New Point(3, 393)
        btnPOS.Name = "btnPOS"
        btnPOS.Size = New Size(110, 57)
        btnPOS.TabIndex = 4
        btnPOS.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.BackColor = Color.White
        lblWelcome.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblWelcome.Location = New Point(112, 977)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(88, 32)
        lblWelcome.TabIndex = 5
        lblWelcome.Text = "Label1"
        ' 
        ' lblTotalProduct
        ' 
        lblTotalProduct.AutoSize = True
        lblTotalProduct.BackColor = Color.Transparent
        lblTotalProduct.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold)
        lblTotalProduct.ForeColor = SystemColors.ButtonHighlight
        lblTotalProduct.Location = New Point(129, 37)
        lblTotalProduct.Name = "lblTotalProduct"
        lblTotalProduct.Size = New Size(74, 28)
        lblTotalProduct.TabIndex = 6
        lblTotalProduct.Text = "Label1"
        ' 
        ' UserPanel
        ' 
        UserPanel.BackColor = Color.Gainsboro
        UserPanel.Controls.Add(PictureBox8)
        UserPanel.Controls.Add(Label7)
        UserPanel.Location = New Point(29, 13)
        UserPanel.Name = "UserPanel"
        UserPanel.Size = New Size(1752, 82)
        UserPanel.TabIndex = 9
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(37, 7)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(70, 70)
        PictureBox8.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox8.TabIndex = 35
        PictureBox8.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Black", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(121, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(566, 45)
        Label7.TabIndex = 34
        Label7.Text = "SHIENNA'S MINI GROCERY STORE "
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.BackColor = Color.White
        lblDateTime.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblDateTime.Location = New Point(543, 10)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(88, 32)
        lblDateTime.TabIndex = 6
        lblDateTime.Text = "Label1"
        ' 
        ' ButtonPanel
        ' 
        ButtonPanel.BackColor = Color.Gainsboro
        ButtonPanel.Controls.Add(PictureBox6)
        ButtonPanel.Controls.Add(Panel5)
        ButtonPanel.Controls.Add(lblWelcome)
        ButtonPanel.Controls.Add(UserPanel)
        ButtonPanel.Controls.Add(PanelUser)
        ButtonPanel.Location = New Point(119, 12)
        ButtonPanel.Name = "ButtonPanel"
        ButtonPanel.Size = New Size(1793, 1034)
        ButtonPanel.TabIndex = 10
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.White
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(487, 3)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(50, 50)
        PictureBox7.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox7.TabIndex = 16
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.White
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(52, 969)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(50, 50)
        PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox6.TabIndex = 15
        PictureBox6.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.LightGray
        Panel5.Controls.Add(MainPanel)
        Panel5.Controls.Add(Panel1)
        Panel5.Controls.Add(PanelQuantityStock)
        Panel5.Controls.Add(PanelTotalSales)
        Panel5.Controls.Add(PanelTotalProduct)
        Panel5.Location = New Point(29, 101)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1752, 859)
        Panel5.TabIndex = 14
        ' 
        ' MainPanel
        ' 
        MainPanel.Controls.Add(Panel2)
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(20, 856)
        MainPanel.TabIndex = 10
        MainPanel.Visible = False
        ' 
        ' Panel2
        ' 
        Panel2.Location = New Point(0, 865)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1752, 65)
        Panel2.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(lblCriticalItems)
        Panel1.Location = New Point(1061, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(324, 158)
        Panel1.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(127, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(173, 28)
        Label6.TabIndex = 13
        Label6.Text = "CRITICAL ITEMS"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(21, 23)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 100)
        PictureBox5.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' lblCriticalItems
        ' 
        lblCriticalItems.AutoSize = True
        lblCriticalItems.BackColor = Color.Transparent
        lblCriticalItems.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold)
        lblCriticalItems.ForeColor = SystemColors.ControlLightLight
        lblCriticalItems.Location = New Point(127, 37)
        lblCriticalItems.Name = "lblCriticalItems"
        lblCriticalItems.Size = New Size(74, 28)
        lblCriticalItems.TabIndex = 8
        lblCriticalItems.Text = "Label1"
        ' 
        ' PanelQuantityStock
        ' 
        PanelQuantityStock.BackColor = Color.White
        PanelQuantityStock.Controls.Add(Label5)
        PanelQuantityStock.Controls.Add(PictureBox4)
        PanelQuantityStock.Controls.Add(lblQuantityStock)
        PanelQuantityStock.Location = New Point(713, 22)
        PanelQuantityStock.Name = "PanelQuantityStock"
        PanelQuantityStock.Size = New Size(324, 158)
        PanelQuantityStock.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(127, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(183, 28)
        Label5.TabIndex = 12
        Label5.Text = "STOCK ON HAND"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(21, 23)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 100)
        PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox4.TabIndex = 9
        PictureBox4.TabStop = False
        ' 
        ' lblQuantityStock
        ' 
        lblQuantityStock.AutoSize = True
        lblQuantityStock.BackColor = Color.Transparent
        lblQuantityStock.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold)
        lblQuantityStock.ForeColor = SystemColors.ControlLightLight
        lblQuantityStock.Location = New Point(127, 37)
        lblQuantityStock.Name = "lblQuantityStock"
        lblQuantityStock.Size = New Size(74, 28)
        lblQuantityStock.TabIndex = 8
        lblQuantityStock.Text = "Label1"
        ' 
        ' PanelTotalSales
        ' 
        PanelTotalSales.BackColor = Color.White
        PanelTotalSales.Controls.Add(Label4)
        PanelTotalSales.Controls.Add(PictureBox2)
        PanelTotalSales.Controls.Add(lblTotalSales)
        PanelTotalSales.Location = New Point(363, 22)
        PanelTotalSales.Name = "PanelTotalSales"
        PanelTotalSales.Size = New Size(324, 158)
        PanelTotalSales.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(124, 65)
        Label4.Name = "Label4"
        Label4.Size = New Size(144, 28)
        Label4.TabIndex = 11
        Label4.Text = "TOTAL SALES"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(19, 23)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(100, 100)
        PictureBox2.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.AutoSize = True
        lblTotalSales.BackColor = Color.Transparent
        lblTotalSales.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold)
        lblTotalSales.ForeColor = SystemColors.ButtonHighlight
        lblTotalSales.Location = New Point(124, 37)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(74, 28)
        lblTotalSales.TabIndex = 6
        lblTotalSales.Text = "Label1"
        ' 
        ' PanelTotalProduct
        ' 
        PanelTotalProduct.BackColor = Color.White
        PanelTotalProduct.Controls.Add(Label3)
        PanelTotalProduct.Controls.Add(Label2)
        PanelTotalProduct.Controls.Add(PictureBox3)
        PanelTotalProduct.Controls.Add(lblTotalProduct)
        PanelTotalProduct.Location = New Point(16, 22)
        PanelTotalProduct.Name = "PanelTotalProduct"
        PanelTotalProduct.Size = New Size(324, 158)
        PanelTotalProduct.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(126, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 28)
        Label3.TabIndex = 10
        Label3.Text = "TOTAL PRODUCT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(126, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 28)
        Label2.TabIndex = 9
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(21, 23)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(100, 100)
        PictureBox3.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' PanelUser
        ' 
        PanelUser.BackColor = Color.Transparent
        PanelUser.Controls.Add(PictureBox7)
        PanelUser.Controls.Add(lblDateTime)
        PanelUser.Location = New Point(29, 967)
        PanelUser.Name = "PanelUser"
        PanelUser.Size = New Size(1749, 59)
        PanelUser.TabIndex = 15
        ' 
        ' ContextMenuStripMaintenance
        ' 
        ContextMenuStripMaintenance.ImageScalingSize = New Size(24, 24)
        ContextMenuStripMaintenance.Items.AddRange(New ToolStripItem() {UserToolStripMenuItem, SupplierToolStripMenuItem, CategoryToolStripMenuItem, ProductToolStripMenuItem, DiscountToolStripMenuItem, VatToolStripMenuItem})
        ContextMenuStripMaintenance.Name = "ContextMenuStrip1"
        ContextMenuStripMaintenance.Size = New Size(157, 196)
        ' 
        ' UserToolStripMenuItem
        ' 
        UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        UserToolStripMenuItem.Size = New Size(156, 32)
        UserToolStripMenuItem.Text = "User"
        ' 
        ' SupplierToolStripMenuItem
        ' 
        SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        SupplierToolStripMenuItem.Size = New Size(156, 32)
        SupplierToolStripMenuItem.Text = "Supplier"
        ' 
        ' CategoryToolStripMenuItem
        ' 
        CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        CategoryToolStripMenuItem.Size = New Size(156, 32)
        CategoryToolStripMenuItem.Text = "Category"
        ' 
        ' ProductToolStripMenuItem
        ' 
        ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        ProductToolStripMenuItem.Size = New Size(156, 32)
        ProductToolStripMenuItem.Text = "Product"
        ' 
        ' DiscountToolStripMenuItem
        ' 
        DiscountToolStripMenuItem.Name = "DiscountToolStripMenuItem"
        DiscountToolStripMenuItem.Size = New Size(156, 32)
        DiscountToolStripMenuItem.Text = "Discount"
        ' 
        ' VatToolStripMenuItem
        ' 
        VatToolStripMenuItem.Name = "VatToolStripMenuItem"
        VatToolStripMenuItem.Size = New Size(156, 32)
        VatToolStripMenuItem.Text = "Vat"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.Transparent
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), Image)
        btnSettings.Location = New Point(3, 530)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(110, 57)
        btnSettings.TabIndex = 5
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStripReports
        ' 
        ContextMenuStripReports.ImageScalingSize = New Size(24, 24)
        ContextMenuStripReports.Items.AddRange(New ToolStripItem() {SalesReportsToolStripMenuItem, FastMovingProductsToolStripMenuItem, ExpirationReportsToolStripMenuItem, VoidedTransactionToolStripMenuItem, StockInReportsToolStripMenuItem})
        ContextMenuStripReports.Name = "ContextMenuStrip1"
        ContextMenuStripReports.Size = New Size(257, 164)
        ' 
        ' SalesReportsToolStripMenuItem
        ' 
        SalesReportsToolStripMenuItem.Name = "SalesReportsToolStripMenuItem"
        SalesReportsToolStripMenuItem.Size = New Size(256, 32)
        SalesReportsToolStripMenuItem.Text = "Sales Reports"
        ' 
        ' FastMovingProductsToolStripMenuItem
        ' 
        FastMovingProductsToolStripMenuItem.Name = "FastMovingProductsToolStripMenuItem"
        FastMovingProductsToolStripMenuItem.Size = New Size(256, 32)
        FastMovingProductsToolStripMenuItem.Text = "Fast Moving Products"
        ' 
        ' ExpirationReportsToolStripMenuItem
        ' 
        ExpirationReportsToolStripMenuItem.Name = "ExpirationReportsToolStripMenuItem"
        ExpirationReportsToolStripMenuItem.Size = New Size(256, 32)
        ExpirationReportsToolStripMenuItem.Text = "Expiration Reports"
        ' 
        ' VoidedTransactionToolStripMenuItem
        ' 
        VoidedTransactionToolStripMenuItem.Name = "VoidedTransactionToolStripMenuItem"
        VoidedTransactionToolStripMenuItem.Size = New Size(256, 32)
        VoidedTransactionToolStripMenuItem.Text = "Voided Transaction"
        ' 
        ' StockInReportsToolStripMenuItem
        ' 
        StockInReportsToolStripMenuItem.Name = "StockInReportsToolStripMenuItem"
        StockInReportsToolStripMenuItem.Size = New Size(256, 32)
        StockInReportsToolStripMenuItem.Text = "Stock In Reports"
        ' 
        ' ContextMenuStripSettings
        ' 
        ContextMenuStripSettings.ImageScalingSize = New Size(24, 24)
        ContextMenuStripSettings.Items.AddRange(New ToolStripItem() {AuditTrailToolStripMenuItem, LogHistoryToolStripMenuItem})
        ContextMenuStripSettings.Name = "ContextMenuStripSettings"
        ContextMenuStripSettings.Size = New Size(177, 68)
        ' 
        ' AuditTrailToolStripMenuItem
        ' 
        AuditTrailToolStripMenuItem.Name = "AuditTrailToolStripMenuItem"
        AuditTrailToolStripMenuItem.Size = New Size(176, 32)
        AuditTrailToolStripMenuItem.Text = "Audit Trail"
        ' 
        ' LogHistoryToolStripMenuItem
        ' 
        LogHistoryToolStripMenuItem.Name = "LogHistoryToolStripMenuItem"
        LogHistoryToolStripMenuItem.Size = New Size(176, 32)
        LogHistoryToolStripMenuItem.Text = "Log History"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.Transparent
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Image = CType(resources.GetObject("btnLogOut.Image"), Image)
        btnLogOut.Location = New Point(3, 956)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(110, 48)
        btnLogOut.TabIndex = 12
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(6, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 85)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' btnBackup
        ' 
        btnBackup.BackColor = Color.Transparent
        btnBackup.FlatStyle = FlatStyle.Flat
        btnBackup.Image = CType(resources.GetObject("btnBackup.Image"), Image)
        btnBackup.Location = New Point(3, 597)
        btnBackup.Name = "btnBackup"
        btnBackup.Size = New Size(110, 57)
        btnBackup.TabIndex = 14
        btnBackup.UseVisualStyleBackColor = False
        btnBackup.Visible = False
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' btnChangePassword
        ' 
        btnChangePassword.BackColor = Color.Transparent
        btnChangePassword.FlatStyle = FlatStyle.Flat
        btnChangePassword.Image = CType(resources.GetObject("btnChangePassword.Image"), Image)
        btnChangePassword.Location = New Point(6, 660)
        btnChangePassword.Name = "btnChangePassword"
        btnChangePassword.Size = New Size(110, 57)
        btnChangePassword.TabIndex = 15
        btnChangePassword.UseVisualStyleBackColor = False
        btnChangePassword.Visible = False
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1924, 1050)
        Controls.Add(btnChangePassword)
        Controls.Add(btnBackup)
        Controls.Add(PictureBox1)
        Controls.Add(btnLogOut)
        Controls.Add(btnSettings)
        Controls.Add(btnMaintenance)
        Controls.Add(btnPOS)
        Controls.Add(btnDashboard)
        Controls.Add(btnInventory)
        Controls.Add(ButtonPanel)
        Controls.Add(btnReports)
        FormBorderStyle = FormBorderStyle.None
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main"
        UserPanel.ResumeLayout(False)
        UserPanel.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ButtonPanel.ResumeLayout(False)
        ButtonPanel.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        MainPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PanelQuantityStock.ResumeLayout(False)
        PanelQuantityStock.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalSales.ResumeLayout(False)
        PanelTotalSales.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelTotalProduct.ResumeLayout(False)
        PanelTotalProduct.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        PanelUser.ResumeLayout(False)
        PanelUser.PerformLayout()
        ContextMenuStripMaintenance.ResumeLayout(False)
        ContextMenuStripReports.ResumeLayout(False)
        ContextMenuStripSettings.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lblTotalProduct As Label
    Friend WithEvents UserPanel As Panel
    Friend WithEvents ButtonPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents PanelTotalProduct As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ContextMenuStripMaintenance As ContextMenuStrip
    Public WithEvents UserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DiscountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Timer1 As Timer
    Private WithEvents btnSettings As Button
    Friend WithEvents ContextMenuStripReports As ContextMenuStrip
    Friend WithEvents SalesReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripSettings As ContextMenuStrip
    Friend WithEvents AuditTrailToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogHistoryToolStripMenuItem As ToolStripMenuItem
    Private WithEvents btnLogOut As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PanelTotalSales As Panel
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents PanelQuantityStock As Panel
    Friend WithEvents FastMovingProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpirationReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Private WithEvents btnBackup As Button
    Friend WithEvents VoidedTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents lblQuantityStock As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblCriticalItems As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents btnChangePassword As Button
    Friend WithEvents StockInReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PanelUser As Panel

End Class
