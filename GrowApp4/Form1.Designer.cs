namespace GrowOP
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label notesLabel;
            System.Windows.Forms.Label initialDateLabel;
            System.Windows.Forms.Label flowerDateLabel;
            System.Windows.Forms.Label harvestDateLabel;
            System.Windows.Forms.Label wetWeightLabel;
            System.Windows.Forms.Label dryWeightLabel;
            System.Windows.Forms.Label finishedLabel;
            System.Windows.Forms.Label uIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.calendar1 = new System.Windows.Forms.MonthCalendar();
            this.txtEvents = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.growAppDataSet = new GrowOP.GrowAppDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.calendarFlowerDateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.notesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.initialDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowerDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.harvestDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.wetWeightTextBox = new System.Windows.Forms.TextBox();
            this.dryWeightTextBox = new System.Windows.Forms.TextBox();
            this.finishedCheckBox = new System.Windows.Forms.CheckBox();
            this.calendarFlowerDateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarFlowerDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarHarvestDateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarHarvestDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDLabel1 = new System.Windows.Forms.Label();
            this.calendarFlowerDateTable = new GrowOP.GrowAppDataSetTableAdapters.calendarFlowerDateTable();
            this.tableAdapterManager = new GrowOP.GrowAppDataSetTableAdapters.TableAdapterManager();
            this.calendarHarvestDateTableAdapter = new GrowOP.GrowAppDataSetTableAdapters.calendarHarvestDateTableAdapter();
            this.plantsTableAdapter = new GrowOP.GrowAppDataSetTableAdapters.PlantsTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            initialDateLabel = new System.Windows.Forms.Label();
            flowerDateLabel = new System.Windows.Forms.Label();
            harvestDateLabel = new System.Windows.Forms.Label();
            wetWeightLabel = new System.Windows.Forms.Label();
            dryWeightLabel = new System.Windows.Forms.Label();
            finishedLabel = new System.Windows.Forms.Label();
            uIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).BeginInit();
            this.plantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.growAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarFlowerDateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarFlowerDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarHarvestDateDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarHarvestDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(135, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 23;
            nameLabel.Text = "Name:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(146, 182);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(38, 13);
            notesLabel.TabIndex = 24;
            notesLabel.Text = "Notes:";
            // 
            // initialDateLabel
            // 
            initialDateLabel.AutoSize = true;
            initialDateLabel.Location = new System.Drawing.Point(78, 42);
            initialDateLabel.Name = "initialDateLabel";
            initialDateLabel.Size = new System.Drawing.Size(60, 13);
            initialDateLabel.TabIndex = 25;
            initialDateLabel.Text = "Initial Date:";
            // 
            // flowerDateLabel
            // 
            flowerDateLabel.AutoSize = true;
            flowerDateLabel.Location = new System.Drawing.Point(71, 68);
            flowerDateLabel.Name = "flowerDateLabel";
            flowerDateLabel.Size = new System.Drawing.Size(67, 13);
            flowerDateLabel.TabIndex = 26;
            flowerDateLabel.Text = "Flower Date:";
            // 
            // harvestDateLabel
            // 
            harvestDateLabel.AutoSize = true;
            harvestDateLabel.Location = new System.Drawing.Point(65, 94);
            harvestDateLabel.Name = "harvestDateLabel";
            harvestDateLabel.Size = new System.Drawing.Size(73, 13);
            harvestDateLabel.TabIndex = 27;
            harvestDateLabel.Text = "Harvest Date:";
            // 
            // wetWeightLabel
            // 
            wetWeightLabel.AutoSize = true;
            wetWeightLabel.Location = new System.Drawing.Point(45, 134);
            wetWeightLabel.Name = "wetWeightLabel";
            wetWeightLabel.Size = new System.Drawing.Size(67, 13);
            wetWeightLabel.TabIndex = 28;
            wetWeightLabel.Text = "Wet Weight:";
            // 
            // dryWeightLabel
            // 
            dryWeightLabel.AutoSize = true;
            dryWeightLabel.Location = new System.Drawing.Point(191, 134);
            dryWeightLabel.Name = "dryWeightLabel";
            dryWeightLabel.Size = new System.Drawing.Size(63, 13);
            dryWeightLabel.TabIndex = 29;
            dryWeightLabel.Text = "Dry Weight:";
            // 
            // finishedLabel
            // 
            finishedLabel.AutoSize = true;
            finishedLabel.Location = new System.Drawing.Point(135, 158);
            finishedLabel.Name = "finishedLabel";
            finishedLabel.Size = new System.Drawing.Size(49, 13);
            finishedLabel.TabIndex = 30;
            finishedLabel.Text = "Finished:";
            // 
            // uIDLabel
            // 
            uIDLabel.AutoSize = true;
            uIDLabel.Location = new System.Drawing.Point(12, 9);
            uIDLabel.Name = "uIDLabel";
            uIDLabel.Size = new System.Drawing.Size(30, 13);
            uIDLabel.TabIndex = 32;
            uIDLabel.Text = "u ID:";
            // 
            // calendar1
            // 
            this.calendar1.Location = new System.Drawing.Point(356, 9);
            this.calendar1.Name = "calendar1";
            this.calendar1.TabIndex = 19;
            this.calendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar1_DateChanged);
            // 
            // txtEvents
            // 
            this.txtEvents.Location = new System.Drawing.Point(361, 213);
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.Size = new System.Drawing.Size(222, 370);
            this.txtEvents.TabIndex = 20;
            this.txtEvents.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Calendar Events:";
            // 
            // plantsBindingNavigator
            // 
            this.plantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.plantsBindingNavigator.BindingSource = this.plantsBindingSource;
            this.plantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.plantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.plantsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.calendarFlowerDateBindingNavigatorSaveItem});
            this.plantsBindingNavigator.Location = new System.Drawing.Point(0, 586);
            this.plantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.plantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.plantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.plantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.plantsBindingNavigator.Name = "plantsBindingNavigator";
            this.plantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.plantsBindingNavigator.Size = new System.Drawing.Size(591, 25);
            this.plantsBindingNavigator.TabIndex = 22;
            this.plantsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // plantsBindingSource
            // 
            this.plantsBindingSource.DataMember = "Plants";
            this.plantsBindingSource.DataSource = this.growAppDataSet;
            // 
            // growAppDataSet
            // 
            this.growAppDataSet.DataSetName = "GrowAppDataSet";
            this.growAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // calendarFlowerDateBindingNavigatorSaveItem
            // 
            this.calendarFlowerDateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.calendarFlowerDateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("calendarFlowerDateBindingNavigatorSaveItem.Image")));
            this.calendarFlowerDateBindingNavigatorSaveItem.Name = "calendarFlowerDateBindingNavigatorSaveItem";
            this.calendarFlowerDateBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.calendarFlowerDateBindingNavigatorSaveItem.Text = "Save Data";
            this.calendarFlowerDateBindingNavigatorSaveItem.Click += new System.EventHandler(this.calendarFlowerDateBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(179, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 20);
            this.nameTextBox.TabIndex = 24;
            // 
            // notesRichTextBox
            // 
            this.notesRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Notes", true));
            this.notesRichTextBox.Location = new System.Drawing.Point(0, 197);
            this.notesRichTextBox.Name = "notesRichTextBox";
            this.notesRichTextBox.Size = new System.Drawing.Size(344, 386);
            this.notesRichTextBox.TabIndex = 25;
            this.notesRichTextBox.Text = "";
            // 
            // initialDateDateTimePicker
            // 
            this.initialDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plantsBindingSource, "InitialDate", true));
            this.initialDateDateTimePicker.Location = new System.Drawing.Point(144, 38);
            this.initialDateDateTimePicker.Name = "initialDateDateTimePicker";
            this.initialDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.initialDateDateTimePicker.TabIndex = 26;
            this.initialDateDateTimePicker.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // flowerDateDateTimePicker
            // 
            this.flowerDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plantsBindingSource, "FlowerDate", true));
            this.flowerDateDateTimePicker.Location = new System.Drawing.Point(144, 64);
            this.flowerDateDateTimePicker.Name = "flowerDateDateTimePicker";
            this.flowerDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.flowerDateDateTimePicker.TabIndex = 27;
            this.flowerDateDateTimePicker.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // harvestDateDateTimePicker
            // 
            this.harvestDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.plantsBindingSource, "HarvestDate", true));
            this.harvestDateDateTimePicker.Location = new System.Drawing.Point(144, 90);
            this.harvestDateDateTimePicker.Name = "harvestDateDateTimePicker";
            this.harvestDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.harvestDateDateTimePicker.TabIndex = 28;
            this.harvestDateDateTimePicker.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // wetWeightTextBox
            // 
            this.wetWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "WetWeight", true));
            this.wetWeightTextBox.Location = new System.Drawing.Point(118, 131);
            this.wetWeightTextBox.Name = "wetWeightTextBox";
            this.wetWeightTextBox.Size = new System.Drawing.Size(32, 20);
            this.wetWeightTextBox.TabIndex = 29;
            // 
            // dryWeightTextBox
            // 
            this.dryWeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "DryWeight", true));
            this.dryWeightTextBox.Location = new System.Drawing.Point(260, 131);
            this.dryWeightTextBox.Name = "dryWeightTextBox";
            this.dryWeightTextBox.Size = new System.Drawing.Size(35, 20);
            this.dryWeightTextBox.TabIndex = 30;
            // 
            // finishedCheckBox
            // 
            this.finishedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.plantsBindingSource, "Finished", true));
            this.finishedCheckBox.Location = new System.Drawing.Point(190, 153);
            this.finishedCheckBox.Name = "finishedCheckBox";
            this.finishedCheckBox.Size = new System.Drawing.Size(25, 24);
            this.finishedCheckBox.TabIndex = 31;
            this.finishedCheckBox.UseVisualStyleBackColor = true;
            // 
            // calendarFlowerDateDataGridView
            // 
            this.calendarFlowerDateDataGridView.AutoGenerateColumns = false;
            this.calendarFlowerDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarFlowerDateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.calendarFlowerDateDataGridView.DataSource = this.calendarFlowerDateBindingSource;
            this.calendarFlowerDateDataGridView.Location = new System.Drawing.Point(611, 153);
            this.calendarFlowerDateDataGridView.Name = "calendarFlowerDateDataGridView";
            this.calendarFlowerDateDataGridView.Size = new System.Drawing.Size(452, 161);
            this.calendarFlowerDateDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "uID";
            this.dataGridViewTextBoxColumn1.HeaderText = "uID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FlowerDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "FlowerDate";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Finished";
            this.dataGridViewTextBoxColumn4.HeaderText = "Finished";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // calendarFlowerDateBindingSource
            // 
            this.calendarFlowerDateBindingSource.DataMember = "calendarFlowerDate";
            this.calendarFlowerDateBindingSource.DataSource = this.growAppDataSet;
            // 
            // calendarHarvestDateDataGridView
            // 
            this.calendarHarvestDateDataGridView.AutoGenerateColumns = false;
            this.calendarHarvestDateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calendarHarvestDateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.calendarHarvestDateDataGridView.DataSource = this.calendarHarvestDateBindingSource;
            this.calendarHarvestDateDataGridView.Location = new System.Drawing.Point(611, 328);
            this.calendarHarvestDateDataGridView.Name = "calendarHarvestDateDataGridView";
            this.calendarHarvestDateDataGridView.Size = new System.Drawing.Size(452, 195);
            this.calendarHarvestDateDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "uID";
            this.dataGridViewTextBoxColumn5.HeaderText = "uID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Name";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HarvestDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "HarvestDate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Finished";
            this.dataGridViewTextBoxColumn8.HeaderText = "Finished";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // calendarHarvestDateBindingSource
            // 
            this.calendarHarvestDateBindingSource.DataMember = "calendarHarvestDate";
            this.calendarHarvestDateBindingSource.DataSource = this.growAppDataSet;
            // 
            // plantsDataGridView
            // 
            this.plantsDataGridView.AutoGenerateColumns = false;
            this.plantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.plantsDataGridView.DataSource = this.plantsBindingSource;
            this.plantsDataGridView.Location = new System.Drawing.Point(611, 12);
            this.plantsDataGridView.Name = "plantsDataGridView";
            this.plantsDataGridView.Size = new System.Drawing.Size(452, 135);
            this.plantsDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "uID";
            this.dataGridViewTextBoxColumn9.HeaderText = "uID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn11.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "InitialDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "InitialDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "FlowerDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "FlowerDate";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "HarvestDate";
            this.dataGridViewTextBoxColumn14.HeaderText = "HarvestDate";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "WetWeight";
            this.dataGridViewTextBoxColumn15.HeaderText = "WetWeight";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "DryWeight";
            this.dataGridViewTextBoxColumn16.HeaderText = "DryWeight";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Finished";
            this.dataGridViewTextBoxColumn17.HeaderText = "Finished";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // uIDLabel1
            // 
            this.uIDLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "uID", true));
            this.uIDLabel1.Location = new System.Drawing.Point(48, 9);
            this.uIDLabel1.Name = "uIDLabel1";
            this.uIDLabel1.Size = new System.Drawing.Size(62, 23);
            this.uIDLabel1.TabIndex = 33;
            // 
            // calendarFlowerDateTable
            // 
            this.calendarFlowerDateTable.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.calendarFlowerDateTable = this.calendarFlowerDateTable;
            this.tableAdapterManager.calendarHarvestDateTableAdapter = this.calendarHarvestDateTableAdapter;
            this.tableAdapterManager.PlantsTableAdapter = this.plantsTableAdapter;
            this.tableAdapterManager.UpdateOrder = GrowOP.GrowAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // calendarHarvestDateTableAdapter
            // 
            this.calendarHarvestDateTableAdapter.ClearBeforeFill = true;
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 611);
            this.Controls.Add(uIDLabel);
            this.Controls.Add(this.uIDLabel1);
            this.Controls.Add(this.plantsDataGridView);
            this.Controls.Add(this.calendarHarvestDateDataGridView);
            this.Controls.Add(this.calendarFlowerDateDataGridView);
            this.Controls.Add(finishedLabel);
            this.Controls.Add(this.finishedCheckBox);
            this.Controls.Add(dryWeightLabel);
            this.Controls.Add(this.dryWeightTextBox);
            this.Controls.Add(wetWeightLabel);
            this.Controls.Add(this.wetWeightTextBox);
            this.Controls.Add(harvestDateLabel);
            this.Controls.Add(this.harvestDateDateTimePicker);
            this.Controls.Add(flowerDateLabel);
            this.Controls.Add(this.flowerDateDateTimePicker);
            this.Controls.Add(initialDateLabel);
            this.Controls.Add(this.initialDateDateTimePicker);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesRichTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.plantsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEvents);
            this.Controls.Add(this.calendar1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GrowOP Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingNavigator)).EndInit();
            this.plantsBindingNavigator.ResumeLayout(false);
            this.plantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.growAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarFlowerDateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarFlowerDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarHarvestDateDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarHarvestDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendar1;
        private System.Windows.Forms.RichTextBox txtEvents;
        private System.Windows.Forms.Label label1;
        private GrowAppDataSet growAppDataSet;
        private System.Windows.Forms.BindingSource calendarFlowerDateBindingSource;
        private GrowAppDataSetTableAdapters.calendarFlowerDateTable calendarFlowerDateTable;
        private GrowAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator plantsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton calendarFlowerDateBindingNavigatorSaveItem;
        private GrowAppDataSetTableAdapters.calendarHarvestDateTableAdapter calendarHarvestDateTableAdapter;
        private System.Windows.Forms.BindingSource calendarHarvestDateBindingSource;
        private GrowAppDataSetTableAdapters.PlantsTableAdapter plantsTableAdapter;
        private System.Windows.Forms.BindingSource plantsBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RichTextBox notesRichTextBox;
        private System.Windows.Forms.DateTimePicker initialDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker flowerDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker harvestDateDateTimePicker;
        private System.Windows.Forms.TextBox wetWeightTextBox;
        private System.Windows.Forms.TextBox dryWeightTextBox;
        private System.Windows.Forms.CheckBox finishedCheckBox;
        private System.Windows.Forms.DataGridView calendarFlowerDateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView calendarHarvestDateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView plantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Label uIDLabel1;
    
        
    }
}

