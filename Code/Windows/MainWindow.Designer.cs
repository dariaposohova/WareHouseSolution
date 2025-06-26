namespace WareHouseSpace
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.ProductTab = new System.Windows.Forms.TabPage();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.SubjectGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.InvoiceTab = new System.Windows.Forms.TabPage();
            this.HorizSplit = new System.Windows.Forms.SplitContainer();
            this.InvoiceGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.VertSplit = new System.Windows.Forms.SplitContainer();
            this.ProductSelectGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InvoiceUpdate = new System.Windows.Forms.Button();
            this.InvoiceType1 = new System.Windows.Forms.RadioButton();
            this.InvoiceType0 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OperationGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.TotalsTab = new System.Windows.Forms.TabPage();
            this.TotalGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.searchText = new System.Windows.Forms.ToolStripTextBox();
            this.searchBtn = new System.Windows.Forms.ToolStripButton();
            this.Tabs.SuspendLayout();
            this.ProductTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.InvoiceTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HorizSplit)).BeginInit();
            this.HorizSplit.Panel1.SuspendLayout();
            this.HorizSplit.Panel2.SuspendLayout();
            this.HorizSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).BeginInit();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VertSplit)).BeginInit();
            this.VertSplit.Panel1.SuspendLayout();
            this.VertSplit.Panel2.SuspendLayout();
            this.VertSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSelectGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationGrid)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.TotalsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.ProductTab);
            this.Tabs.Controls.Add(this.InvoiceTab);
            this.Tabs.Controls.Add(this.TotalsTab);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.HotTrack = true;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Multiline = true;
            this.Tabs.Name = "Tabs";
            this.Tabs.Padding = new System.Drawing.Point(0, 0);
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1251, 709);
            this.Tabs.TabIndex = 0;
            this.Tabs.SelectedIndexChanged += new System.EventHandler(this.TabSelecting);
            // 
            // ProductTab
            // 
            this.ProductTab.BackColor = System.Drawing.Color.Gainsboro;
            this.ProductTab.Controls.Add(this.MainSplit);
            this.ProductTab.Location = new System.Drawing.Point(4, 22);
            this.ProductTab.Name = "ProductTab";
            this.ProductTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductTab.Size = new System.Drawing.Size(1243, 683);
            this.ProductTab.TabIndex = 0;
            this.ProductTab.Text = "Номенклуатура/Контрагенти";
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.Location = new System.Drawing.Point(3, 3);
            this.MainSplit.Name = "MainSplit";
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.SubjectGrid);
            this.MainSplit.Panel1.Controls.Add(this.toolStrip1);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.ProductGrid);
            this.MainSplit.Panel2.Controls.Add(this.toolStrip2);
            this.MainSplit.Size = new System.Drawing.Size(1237, 677);
            this.MainSplit.SplitterDistance = 412;
            this.MainSplit.SplitterWidth = 1;
            this.MainSplit.TabIndex = 0;
            // 
            // SubjectGrid
            // 
            this.SubjectGrid.AllowUserToAddRows = false;
            this.SubjectGrid.AllowUserToDeleteRows = false;
            this.SubjectGrid.AllowUserToResizeRows = false;
            this.SubjectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubjectGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SubjectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectGrid.Location = new System.Drawing.Point(0, 25);
            this.SubjectGrid.MultiSelect = false;
            this.SubjectGrid.Name = "SubjectGrid";
            this.SubjectGrid.ReadOnly = true;
            this.SubjectGrid.RowHeadersVisible = false;
            this.SubjectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SubjectGrid.Size = new System.Drawing.Size(412, 652);
            this.SubjectGrid.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripButton13});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(412, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(79, 22);
            this.toolStripLabel1.Text = "Контрагенти:";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton11.Text = "Add";
            this.toolStripButton11.Click += new System.EventHandler(this.SubjectAddNew_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton12.Text = "Delete";
            this.toolStripButton12.Click += new System.EventHandler(this.SubjectDeleteOne_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton13.Text = "Update";
            this.toolStripButton13.Click += new System.EventHandler(this.SubjectUpdateOne_Click);
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.AllowUserToResizeRows = false;
            this.ProductGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductGrid.GridColor = System.Drawing.Color.WhiteSmoke;
            this.ProductGrid.Location = new System.Drawing.Point(0, 25);
            this.ProductGrid.Margin = new System.Windows.Forms.Padding(0);
            this.ProductGrid.MultiSelect = false;
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGrid.Size = new System.Drawing.Size(824, 652);
            this.ProductGrid.TabIndex = 6;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(824, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(97, 22);
            this.toolStripLabel2.Text = "Номенклуатура:";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton1.Text = "Add";
            this.toolStripButton1.Click += new System.EventHandler(this.ProductAddNew_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton2.Text = "Delete";
            this.toolStripButton2.Click += new System.EventHandler(this.ProductDelOne_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton3.Text = "Update";
            this.toolStripButton3.Click += new System.EventHandler(this.ProductUpdateOne_Click);
            // 
            // InvoiceTab
            // 
            this.InvoiceTab.BackColor = System.Drawing.Color.Gainsboro;
            this.InvoiceTab.Controls.Add(this.HorizSplit);
            this.InvoiceTab.Location = new System.Drawing.Point(4, 22);
            this.InvoiceTab.Name = "InvoiceTab";
            this.InvoiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.InvoiceTab.Size = new System.Drawing.Size(1243, 683);
            this.InvoiceTab.TabIndex = 2;
            this.InvoiceTab.Text = "Накладні";
            // 
            // HorizSplit
            // 
            this.HorizSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizSplit.Location = new System.Drawing.Point(3, 3);
            this.HorizSplit.Name = "HorizSplit";
            this.HorizSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // HorizSplit.Panel1
            // 
            this.HorizSplit.Panel1.BackColor = System.Drawing.Color.MistyRose;
            this.HorizSplit.Panel1.Controls.Add(this.InvoiceGrid);
            this.HorizSplit.Panel1.Controls.Add(this.toolStrip4);
            // 
            // HorizSplit.Panel2
            // 
            this.HorizSplit.Panel2.BackColor = System.Drawing.Color.LightYellow;
            this.HorizSplit.Panel2.Controls.Add(this.VertSplit);
            this.HorizSplit.Size = new System.Drawing.Size(1237, 677);
            this.HorizSplit.SplitterDistance = 138;
            this.HorizSplit.SplitterWidth = 1;
            this.HorizSplit.TabIndex = 0;
            // 
            // InvoiceGrid
            // 
            this.InvoiceGrid.AllowUserToAddRows = false;
            this.InvoiceGrid.AllowUserToDeleteRows = false;
            this.InvoiceGrid.AllowUserToResizeRows = false;
            this.InvoiceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InvoiceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InvoiceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceGrid.Location = new System.Drawing.Point(0, 25);
            this.InvoiceGrid.MultiSelect = false;
            this.InvoiceGrid.Name = "InvoiceGrid";
            this.InvoiceGrid.ReadOnly = true;
            this.InvoiceGrid.RowHeadersVisible = false;
            this.InvoiceGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InvoiceGrid.Size = new System.Drawing.Size(1237, 113);
            this.InvoiceGrid.TabIndex = 5;
            this.InvoiceGrid.SelectionChanged += new System.EventHandler(this.InvoiceSelection);
            // 
            // toolStrip4
            // 
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip4.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip4.Size = new System.Drawing.Size(1237, 25);
            this.toolStrip4.TabIndex = 4;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel3.Text = "Накладні:";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton5.Text = "Add";
            this.toolStripButton5.Click += new System.EventHandler(this.AddNewInvoice_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton6.Text = "Delete";
            this.toolStripButton6.Click += new System.EventHandler(this.DeleteOneInvoice_Click);
            // 
            // VertSplit
            // 
            this.VertSplit.BackColor = System.Drawing.Color.Gainsboro;
            this.VertSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VertSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.VertSplit.Location = new System.Drawing.Point(0, 0);
            this.VertSplit.Name = "VertSplit";
            // 
            // VertSplit.Panel1
            // 
            this.VertSplit.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.VertSplit.Panel1.Controls.Add(this.ProductSelectGrid);
            this.VertSplit.Panel1.Controls.Add(this.panel2);
            this.VertSplit.Panel1.Controls.Add(this.panel1);
            // 
            // VertSplit.Panel2
            // 
            this.VertSplit.Panel2.Controls.Add(this.OperationGrid);
            this.VertSplit.Panel2.Controls.Add(this.toolStrip5);
            this.VertSplit.Size = new System.Drawing.Size(1237, 538);
            this.VertSplit.SplitterDistance = 388;
            this.VertSplit.SplitterWidth = 1;
            this.VertSplit.TabIndex = 0;
            // 
            // ProductSelectGrid
            // 
            this.ProductSelectGrid.AllowUserToAddRows = false;
            this.ProductSelectGrid.AllowUserToDeleteRows = false;
            this.ProductSelectGrid.AllowUserToResizeRows = false;
            this.ProductSelectGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductSelectGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductSelectGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductSelectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductSelectGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductSelectGrid.Location = new System.Drawing.Point(0, 70);
            this.ProductSelectGrid.MultiSelect = false;
            this.ProductSelectGrid.Name = "ProductSelectGrid";
            this.ProductSelectGrid.ReadOnly = true;
            this.ProductSelectGrid.RowHeadersVisible = false;
            this.ProductSelectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductSelectGrid.Size = new System.Drawing.Size(388, 468);
            this.ProductSelectGrid.TabIndex = 6;
            this.ProductSelectGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductOperationSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InvoiceUpdate);
            this.panel2.Controls.Add(this.InvoiceType1);
            this.panel2.Controls.Add(this.InvoiceType0);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7);
            this.panel2.Size = new System.Drawing.Size(388, 35);
            this.panel2.TabIndex = 2;
            // 
            // InvoiceUpdate
            // 
            this.InvoiceUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.InvoiceUpdate.Location = new System.Drawing.Point(306, 7);
            this.InvoiceUpdate.Name = "InvoiceUpdate";
            this.InvoiceUpdate.Size = new System.Drawing.Size(75, 21);
            this.InvoiceUpdate.TabIndex = 3;
            this.InvoiceUpdate.Text = "Update";
            this.InvoiceUpdate.UseVisualStyleBackColor = true;
            this.InvoiceUpdate.Click += new System.EventHandler(this.InvoiceUpdate_Click);
            // 
            // InvoiceType1
            // 
            this.InvoiceType1.AutoSize = true;
            this.InvoiceType1.Dock = System.Windows.Forms.DockStyle.Left;
            this.InvoiceType1.Location = new System.Drawing.Point(203, 7);
            this.InvoiceType1.Name = "InvoiceType1";
            this.InvoiceType1.Size = new System.Drawing.Size(98, 21);
            this.InvoiceType1.TabIndex = 2;
            this.InvoiceType1.TabStop = true;
            this.InvoiceType1.Text = "Видача товару";
            this.InvoiceType1.UseVisualStyleBackColor = true;
            // 
            // InvoiceType0
            // 
            this.InvoiceType0.AutoSize = true;
            this.InvoiceType0.Dock = System.Windows.Forms.DockStyle.Left;
            this.InvoiceType0.Location = new System.Drawing.Point(101, 7);
            this.InvoiceType0.Name = "InvoiceType0";
            this.InvoiceType0.Size = new System.Drawing.Size(102, 21);
            this.InvoiceType0.TabIndex = 1;
            this.InvoiceType0.TabStop = true;
            this.InvoiceType0.Text = "Прийом товару";
            this.InvoiceType0.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип накладної";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubjectCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7);
            this.panel1.Size = new System.Drawing.Size(388, 35);
            this.panel1.TabIndex = 1;
            // 
            // SubjectCombo
            // 
            this.SubjectCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubjectCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjectCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SubjectCombo.FormattingEnabled = true;
            this.SubjectCombo.Location = new System.Drawing.Point(101, 7);
            this.SubjectCombo.Name = "SubjectCombo";
            this.SubjectCombo.Size = new System.Drawing.Size(280, 21);
            this.SubjectCombo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Контрагент";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OperationGrid
            // 
            this.OperationGrid.AllowUserToAddRows = false;
            this.OperationGrid.AllowUserToDeleteRows = false;
            this.OperationGrid.AllowUserToResizeRows = false;
            this.OperationGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OperationGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OperationGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OperationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationGrid.Location = new System.Drawing.Point(0, 25);
            this.OperationGrid.MultiSelect = false;
            this.OperationGrid.Name = "OperationGrid";
            this.OperationGrid.ReadOnly = true;
            this.OperationGrid.RowHeadersVisible = false;
            this.OperationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OperationGrid.Size = new System.Drawing.Size(848, 513);
            this.OperationGrid.TabIndex = 7;
            // 
            // toolStrip5
            // 
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4,
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStrip5.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip5.Location = new System.Drawing.Point(0, 0);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip5.Size = new System.Drawing.Size(848, 25);
            this.toolStrip5.TabIndex = 6;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(58, 22);
            this.toolStripLabel4.Text = "Операції:";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(33, 22);
            this.toolStripButton8.Text = "Add";
            this.toolStripButton8.Click += new System.EventHandler(this.AddOneOperation);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(44, 22);
            this.toolStripButton9.Text = "Delete";
            this.toolStripButton9.Click += new System.EventHandler(this.DeleteOneOperation);
            // 
            // TotalsTab
            // 
            this.TotalsTab.BackColor = System.Drawing.Color.Gainsboro;
            this.TotalsTab.Controls.Add(this.TotalGrid);
            this.TotalsTab.Controls.Add(this.toolStrip3);
            this.TotalsTab.Location = new System.Drawing.Point(4, 22);
            this.TotalsTab.Name = "TotalsTab";
            this.TotalsTab.Padding = new System.Windows.Forms.Padding(3);
            this.TotalsTab.Size = new System.Drawing.Size(1243, 683);
            this.TotalsTab.TabIndex = 3;
            this.TotalsTab.Text = "Інвентаризація";
            // 
            // TotalGrid
            // 
            this.TotalGrid.AllowUserToAddRows = false;
            this.TotalGrid.AllowUserToDeleteRows = false;
            this.TotalGrid.AllowUserToResizeRows = false;
            this.TotalGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TotalGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TotalGrid.Location = new System.Drawing.Point(3, 28);
            this.TotalGrid.MultiSelect = false;
            this.TotalGrid.Name = "TotalGrid";
            this.TotalGrid.ReadOnly = true;
            this.TotalGrid.RowHeadersVisible = false;
            this.TotalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TotalGrid.Size = new System.Drawing.Size(1237, 652);
            this.TotalGrid.TabIndex = 5;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchText,
            this.searchBtn});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip3.Size = new System.Drawing.Size(1237, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // searchText
            // 
            this.searchText.AutoSize = false;
            this.searchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchText.Margin = new System.Windows.Forms.Padding(0);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(100, 23);
            // 
            // searchBtn
            // 
            this.searchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(46, 22);
            this.searchBtn.Text = "Search";
            this.searchBtn.Click += new System.EventHandler(this.TotalsFiltration);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1251, 709);
            this.Controls.Add(this.Tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Tabs.ResumeLayout(false);
            this.ProductTab.ResumeLayout(false);
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel1.PerformLayout();
            this.MainSplit.Panel2.ResumeLayout(false);
            this.MainSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.InvoiceTab.ResumeLayout(false);
            this.HorizSplit.Panel1.ResumeLayout(false);
            this.HorizSplit.Panel1.PerformLayout();
            this.HorizSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HorizSplit)).EndInit();
            this.HorizSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.VertSplit.Panel1.ResumeLayout(false);
            this.VertSplit.Panel2.ResumeLayout(false);
            this.VertSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VertSplit)).EndInit();
            this.VertSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductSelectGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OperationGrid)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.TotalsTab.ResumeLayout(false);
            this.TotalsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalGrid)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage ProductTab;
        private System.Windows.Forms.TabPage InvoiceTab;
        private System.Windows.Forms.TabPage TotalsTab;
        private System.Windows.Forms.DataGridView TotalGrid;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripTextBox searchText;
        private System.Windows.Forms.ToolStripButton searchBtn;
        private System.Windows.Forms.SplitContainer HorizSplit;
        private System.Windows.Forms.SplitContainer VertSplit;
        private System.Windows.Forms.DataGridView InvoiceGrid;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridView OperationGrid;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton InvoiceType1;
        private System.Windows.Forms.RadioButton InvoiceType0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductSelectGrid;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView ProductGrid;
        private System.Windows.Forms.DataGridView SubjectGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ComboBox SubjectCombo;
        private System.Windows.Forms.Button InvoiceUpdate;
    }
}

