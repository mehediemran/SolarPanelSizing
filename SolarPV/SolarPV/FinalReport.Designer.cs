namespace SolarPV
{
    partial class FinalReport
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
            System.Windows.Forms.Label designIDLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label irradLabel;
            System.Windows.Forms.Label totKwattLabel;
            System.Windows.Forms.Label panelModelLabel;
            System.Windows.Forms.Label noPanelLabel;
            System.Windows.Forms.Label pnelPowLabel;
            System.Windows.Forms.Label pnelVoltLabel;
            System.Windows.Forms.Label pnelCurrentLabel;
            System.Windows.Forms.Label battModelLabel;
            System.Windows.Forms.Label noofBattLabel;
            System.Windows.Forms.Label battVoltLabel;
            System.Windows.Forms.Label battAHLabel;
            System.Windows.Forms.Label battCurrentLabel;
            System.Windows.Forms.Label daysLabel;
            System.Windows.Forms.Label wattHourReqLabel;
            System.Windows.Forms.Label battbankAHLabel;
            System.Windows.Forms.Label housenumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalReport));
            this.systemBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.designIDTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.irradTextBox = new System.Windows.Forms.TextBox();
            this.totKwattTextBox = new System.Windows.Forms.TextBox();
            this.panelModelTextBox = new System.Windows.Forms.TextBox();
            this.noPanelTextBox = new System.Windows.Forms.TextBox();
            this.pnelPowTextBox = new System.Windows.Forms.TextBox();
            this.pnelVoltTextBox = new System.Windows.Forms.TextBox();
            this.pnelCurrentTextBox = new System.Windows.Forms.TextBox();
            this.battModelTextBox = new System.Windows.Forms.TextBox();
            this.noofBattTextBox = new System.Windows.Forms.TextBox();
            this.battVoltTextBox = new System.Windows.Forms.TextBox();
            this.battAHTextBox = new System.Windows.Forms.TextBox();
            this.battCurrentTextBox = new System.Windows.Forms.TextBox();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.wattHourReqTextBox = new System.Windows.Forms.TextBox();
            this.battbankAHTextBox = new System.Windows.Forms.TextBox();
            this.housenumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.systemBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.systemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solarpvbdDataSet = new SolarPV.solarpvbdDataSet();
            this.systemTableAdapter = new SolarPV.solarpvbdDataSetTableAdapters.SystemTableAdapter();
            this.tableAdapterManager = new SolarPV.solarpvbdDataSetTableAdapters.TableAdapterManager();
            designIDLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            irradLabel = new System.Windows.Forms.Label();
            totKwattLabel = new System.Windows.Forms.Label();
            panelModelLabel = new System.Windows.Forms.Label();
            noPanelLabel = new System.Windows.Forms.Label();
            pnelPowLabel = new System.Windows.Forms.Label();
            pnelVoltLabel = new System.Windows.Forms.Label();
            pnelCurrentLabel = new System.Windows.Forms.Label();
            battModelLabel = new System.Windows.Forms.Label();
            noofBattLabel = new System.Windows.Forms.Label();
            battVoltLabel = new System.Windows.Forms.Label();
            battAHLabel = new System.Windows.Forms.Label();
            battCurrentLabel = new System.Windows.Forms.Label();
            daysLabel = new System.Windows.Forms.Label();
            wattHourReqLabel = new System.Windows.Forms.Label();
            battbankAHLabel = new System.Windows.Forms.Label();
            housenumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingNavigator)).BeginInit();
            this.systemBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // designIDLabel
            // 
            designIDLabel.AutoSize = true;
            designIDLabel.Location = new System.Drawing.Point(99, 100);
            designIDLabel.Name = "designIDLabel";
            designIDLabel.Size = new System.Drawing.Size(57, 13);
            designIDLabel.TabIndex = 1;
            designIDLabel.Text = "Design ID:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(319, 100);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(47, 13);
            locationLabel.TabIndex = 3;
            locationLabel.Text = "location:";
            // 
            // irradLabel
            // 
            irradLabel.AutoSize = true;
            irradLabel.Location = new System.Drawing.Point(565, 100);
            irradLabel.Name = "irradLabel";
            irradLabel.Size = new System.Drawing.Size(30, 13);
            irradLabel.TabIndex = 5;
            irradLabel.Text = "irrad:";
            // 
            // totKwattLabel
            // 
            totKwattLabel.AutoSize = true;
            totKwattLabel.Location = new System.Drawing.Point(104, 143);
            totKwattLabel.Name = "totKwattLabel";
            totKwattLabel.Size = new System.Drawing.Size(52, 13);
            totKwattLabel.TabIndex = 7;
            totKwattLabel.Text = "tot Kwatt:";
            // 
            // panelModelLabel
            // 
            panelModelLabel.AutoSize = true;
            panelModelLabel.Location = new System.Drawing.Point(298, 143);
            panelModelLabel.Name = "panelModelLabel";
            panelModelLabel.Size = new System.Drawing.Size(68, 13);
            panelModelLabel.TabIndex = 9;
            panelModelLabel.Text = "panel Model:";
            // 
            // noPanelLabel
            // 
            noPanelLabel.AutoSize = true;
            noPanelLabel.Location = new System.Drawing.Point(543, 143);
            noPanelLabel.Name = "noPanelLabel";
            noPanelLabel.Size = new System.Drawing.Size(52, 13);
            noPanelLabel.TabIndex = 11;
            noPanelLabel.Text = "no Panel:";
            // 
            // pnelPowLabel
            // 
            pnelPowLabel.AutoSize = true;
            pnelPowLabel.Location = new System.Drawing.Point(102, 191);
            pnelPowLabel.Name = "pnelPowLabel";
            pnelPowLabel.Size = new System.Drawing.Size(54, 13);
            pnelPowLabel.TabIndex = 13;
            pnelPowLabel.Text = "pnel Pow:";
            // 
            // pnelVoltLabel
            // 
            pnelVoltLabel.AutoSize = true;
            pnelVoltLabel.Location = new System.Drawing.Point(315, 191);
            pnelVoltLabel.Name = "pnelVoltLabel";
            pnelVoltLabel.Size = new System.Drawing.Size(51, 13);
            pnelVoltLabel.TabIndex = 15;
            pnelVoltLabel.Text = "pnel Volt:";
            // 
            // pnelCurrentLabel
            // 
            pnelCurrentLabel.AutoSize = true;
            pnelCurrentLabel.Location = new System.Drawing.Point(528, 191);
            pnelCurrentLabel.Name = "pnelCurrentLabel";
            pnelCurrentLabel.Size = new System.Drawing.Size(67, 13);
            pnelCurrentLabel.TabIndex = 17;
            pnelCurrentLabel.Text = "pnel Current:";
            // 
            // battModelLabel
            // 
            battModelLabel.AutoSize = true;
            battModelLabel.Location = new System.Drawing.Point(96, 234);
            battModelLabel.Name = "battModelLabel";
            battModelLabel.Size = new System.Drawing.Size(60, 13);
            battModelLabel.TabIndex = 19;
            battModelLabel.Text = "batt Model:";
            // 
            // noofBattLabel
            // 
            noofBattLabel.AutoSize = true;
            noofBattLabel.Location = new System.Drawing.Point(313, 234);
            noofBattLabel.Name = "noofBattLabel";
            noofBattLabel.Size = new System.Drawing.Size(53, 13);
            noofBattLabel.TabIndex = 21;
            noofBattLabel.Text = "noof Batt:";
            // 
            // battVoltLabel
            // 
            battVoltLabel.AutoSize = true;
            battVoltLabel.Location = new System.Drawing.Point(546, 234);
            battVoltLabel.Name = "battVoltLabel";
            battVoltLabel.Size = new System.Drawing.Size(49, 13);
            battVoltLabel.TabIndex = 23;
            battVoltLabel.Text = "batt Volt:";
            // 
            // battAHLabel
            // 
            battAHLabel.AutoSize = true;
            battAHLabel.Location = new System.Drawing.Point(110, 274);
            battAHLabel.Name = "battAHLabel";
            battAHLabel.Size = new System.Drawing.Size(46, 13);
            battAHLabel.TabIndex = 25;
            battAHLabel.Text = "batt AH:";
            // 
            // battCurrentLabel
            // 
            battCurrentLabel.AutoSize = true;
            battCurrentLabel.Location = new System.Drawing.Point(301, 274);
            battCurrentLabel.Name = "battCurrentLabel";
            battCurrentLabel.Size = new System.Drawing.Size(65, 13);
            battCurrentLabel.TabIndex = 27;
            battCurrentLabel.Text = "batt Current:";
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Location = new System.Drawing.Point(563, 274);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new System.Drawing.Size(32, 13);
            daysLabel.TabIndex = 29;
            daysLabel.Text = "days:";
            // 
            // wattHourReqLabel
            // 
            wattHourReqLabel.AutoSize = true;
            wattHourReqLabel.Location = new System.Drawing.Point(77, 312);
            wattHourReqLabel.Name = "wattHourReqLabel";
            wattHourReqLabel.Size = new System.Drawing.Size(79, 13);
            wattHourReqLabel.TabIndex = 31;
            wattHourReqLabel.Text = "watt Hour Req:";
            // 
            // battbankAHLabel
            // 
            battbankAHLabel.AutoSize = true;
            battbankAHLabel.Location = new System.Drawing.Point(296, 312);
            battbankAHLabel.Name = "battbankAHLabel";
            battbankAHLabel.Size = new System.Drawing.Size(70, 13);
            battbankAHLabel.TabIndex = 33;
            battbankAHLabel.Text = "battbank AH:";
            // 
            // housenumberLabel
            // 
            housenumberLabel.AutoSize = true;
            housenumberLabel.Location = new System.Drawing.Point(521, 312);
            housenumberLabel.Name = "housenumberLabel";
            housenumberLabel.Size = new System.Drawing.Size(74, 13);
            housenumberLabel.TabIndex = 35;
            housenumberLabel.Text = "housenumber:";
            // 
            // systemBindingNavigator
            // 
            this.systemBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.systemBindingNavigator.BindingSource = this.systemBindingSource;
            this.systemBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.systemBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.systemBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.systemBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.systemBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.systemBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.systemBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.systemBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.systemBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.systemBindingNavigator.Name = "systemBindingNavigator";
            this.systemBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.systemBindingNavigator.Size = new System.Drawing.Size(815, 25);
            this.systemBindingNavigator.TabIndex = 0;
            this.systemBindingNavigator.Text = "bindingNavigator1";
            this.systemBindingNavigator.RefreshItems += new System.EventHandler(this.systemBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // designIDTextBox
            // 
            this.designIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "designID", true));
            this.designIDTextBox.Location = new System.Drawing.Point(175, 100);
            this.designIDTextBox.Name = "designIDTextBox";
            this.designIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.designIDTextBox.TabIndex = 2;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(396, 100);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 4;
            // 
            // irradTextBox
            // 
            this.irradTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "irrad", true));
            this.irradTextBox.Location = new System.Drawing.Point(604, 100);
            this.irradTextBox.Name = "irradTextBox";
            this.irradTextBox.Size = new System.Drawing.Size(100, 20);
            this.irradTextBox.TabIndex = 6;
            // 
            // totKwattTextBox
            // 
            this.totKwattTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "totKwatt", true));
            this.totKwattTextBox.Location = new System.Drawing.Point(175, 143);
            this.totKwattTextBox.Name = "totKwattTextBox";
            this.totKwattTextBox.Size = new System.Drawing.Size(100, 20);
            this.totKwattTextBox.TabIndex = 8;
            // 
            // panelModelTextBox
            // 
            this.panelModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "panelModel", true));
            this.panelModelTextBox.Location = new System.Drawing.Point(396, 143);
            this.panelModelTextBox.Name = "panelModelTextBox";
            this.panelModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.panelModelTextBox.TabIndex = 10;
            // 
            // noPanelTextBox
            // 
            this.noPanelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "noPanel", true));
            this.noPanelTextBox.Location = new System.Drawing.Point(604, 143);
            this.noPanelTextBox.Name = "noPanelTextBox";
            this.noPanelTextBox.Size = new System.Drawing.Size(100, 20);
            this.noPanelTextBox.TabIndex = 12;
            // 
            // pnelPowTextBox
            // 
            this.pnelPowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "pnelPow", true));
            this.pnelPowTextBox.Location = new System.Drawing.Point(175, 191);
            this.pnelPowTextBox.Name = "pnelPowTextBox";
            this.pnelPowTextBox.Size = new System.Drawing.Size(100, 20);
            this.pnelPowTextBox.TabIndex = 14;
            // 
            // pnelVoltTextBox
            // 
            this.pnelVoltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "pnelVolt", true));
            this.pnelVoltTextBox.Location = new System.Drawing.Point(396, 191);
            this.pnelVoltTextBox.Name = "pnelVoltTextBox";
            this.pnelVoltTextBox.Size = new System.Drawing.Size(100, 20);
            this.pnelVoltTextBox.TabIndex = 16;
            // 
            // pnelCurrentTextBox
            // 
            this.pnelCurrentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "pnelCurrent", true));
            this.pnelCurrentTextBox.Location = new System.Drawing.Point(604, 191);
            this.pnelCurrentTextBox.Name = "pnelCurrentTextBox";
            this.pnelCurrentTextBox.Size = new System.Drawing.Size(100, 20);
            this.pnelCurrentTextBox.TabIndex = 18;
            // 
            // battModelTextBox
            // 
            this.battModelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "battModel", true));
            this.battModelTextBox.Location = new System.Drawing.Point(175, 234);
            this.battModelTextBox.Name = "battModelTextBox";
            this.battModelTextBox.Size = new System.Drawing.Size(100, 20);
            this.battModelTextBox.TabIndex = 20;
            // 
            // noofBattTextBox
            // 
            this.noofBattTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "noofBatt", true));
            this.noofBattTextBox.Location = new System.Drawing.Point(396, 234);
            this.noofBattTextBox.Name = "noofBattTextBox";
            this.noofBattTextBox.Size = new System.Drawing.Size(100, 20);
            this.noofBattTextBox.TabIndex = 22;
            // 
            // battVoltTextBox
            // 
            this.battVoltTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "battVolt", true));
            this.battVoltTextBox.Location = new System.Drawing.Point(604, 234);
            this.battVoltTextBox.Name = "battVoltTextBox";
            this.battVoltTextBox.Size = new System.Drawing.Size(100, 20);
            this.battVoltTextBox.TabIndex = 24;
            // 
            // battAHTextBox
            // 
            this.battAHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "battAH", true));
            this.battAHTextBox.Location = new System.Drawing.Point(175, 274);
            this.battAHTextBox.Name = "battAHTextBox";
            this.battAHTextBox.Size = new System.Drawing.Size(100, 20);
            this.battAHTextBox.TabIndex = 26;
            // 
            // battCurrentTextBox
            // 
            this.battCurrentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "battCurrent", true));
            this.battCurrentTextBox.Location = new System.Drawing.Point(396, 274);
            this.battCurrentTextBox.Name = "battCurrentTextBox";
            this.battCurrentTextBox.Size = new System.Drawing.Size(100, 20);
            this.battCurrentTextBox.TabIndex = 28;
            // 
            // daysTextBox
            // 
            this.daysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "days", true));
            this.daysTextBox.Location = new System.Drawing.Point(604, 274);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.Size = new System.Drawing.Size(100, 20);
            this.daysTextBox.TabIndex = 30;
            // 
            // wattHourReqTextBox
            // 
            this.wattHourReqTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "wattHourReq", true));
            this.wattHourReqTextBox.Location = new System.Drawing.Point(175, 312);
            this.wattHourReqTextBox.Name = "wattHourReqTextBox";
            this.wattHourReqTextBox.Size = new System.Drawing.Size(100, 20);
            this.wattHourReqTextBox.TabIndex = 32;
            // 
            // battbankAHTextBox
            // 
            this.battbankAHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "battbankAH", true));
            this.battbankAHTextBox.Location = new System.Drawing.Point(396, 312);
            this.battbankAHTextBox.Name = "battbankAHTextBox";
            this.battbankAHTextBox.Size = new System.Drawing.Size(100, 20);
            this.battbankAHTextBox.TabIndex = 34;
            // 
            // housenumberTextBox
            // 
            this.housenumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemBindingSource, "housenumber", true));
            this.housenumberTextBox.Location = new System.Drawing.Point(604, 312);
            this.housenumberTextBox.Name = "housenumberTextBox";
            this.housenumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.housenumberTextBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "System Details";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // systemBindingNavigatorSaveItem
            // 
            this.systemBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.systemBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("systemBindingNavigatorSaveItem.Image")));
            this.systemBindingNavigatorSaveItem.Name = "systemBindingNavigatorSaveItem";
            this.systemBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.systemBindingNavigatorSaveItem.Text = "Save Data";
            this.systemBindingNavigatorSaveItem.Click += new System.EventHandler(this.systemBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // systemBindingSource
            // 
            this.systemBindingSource.DataMember = "System";
            this.systemBindingSource.DataSource = this.solarpvbdDataSet;
            // 
            // solarpvbdDataSet
            // 
            this.solarpvbdDataSet.DataSetName = "solarpvbdDataSet";
            this.solarpvbdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemTableAdapter
            // 
            this.systemTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BatteryTableAdapter = null;
            this.tableAdapterManager.LocationTableAdapter = null;
            this.tableAdapterManager.PanelTableAdapter = null;
            this.tableAdapterManager.SystemTableAdapter = this.systemTableAdapter;
            this.tableAdapterManager.UpdateOrder = SolarPV.solarpvbdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FinalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(designIDLabel);
            this.Controls.Add(this.designIDTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(irradLabel);
            this.Controls.Add(this.irradTextBox);
            this.Controls.Add(totKwattLabel);
            this.Controls.Add(this.totKwattTextBox);
            this.Controls.Add(panelModelLabel);
            this.Controls.Add(this.panelModelTextBox);
            this.Controls.Add(noPanelLabel);
            this.Controls.Add(this.noPanelTextBox);
            this.Controls.Add(pnelPowLabel);
            this.Controls.Add(this.pnelPowTextBox);
            this.Controls.Add(pnelVoltLabel);
            this.Controls.Add(this.pnelVoltTextBox);
            this.Controls.Add(pnelCurrentLabel);
            this.Controls.Add(this.pnelCurrentTextBox);
            this.Controls.Add(battModelLabel);
            this.Controls.Add(this.battModelTextBox);
            this.Controls.Add(noofBattLabel);
            this.Controls.Add(this.noofBattTextBox);
            this.Controls.Add(battVoltLabel);
            this.Controls.Add(this.battVoltTextBox);
            this.Controls.Add(battAHLabel);
            this.Controls.Add(this.battAHTextBox);
            this.Controls.Add(battCurrentLabel);
            this.Controls.Add(this.battCurrentTextBox);
            this.Controls.Add(daysLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(wattHourReqLabel);
            this.Controls.Add(this.wattHourReqTextBox);
            this.Controls.Add(battbankAHLabel);
            this.Controls.Add(this.battbankAHTextBox);
            this.Controls.Add(housenumberLabel);
            this.Controls.Add(this.housenumberTextBox);
            this.Controls.Add(this.systemBindingNavigator);
            this.Name = "FinalReport";
            this.Text = "FinalReport";
            this.Load += new System.EventHandler(this.FinalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingNavigator)).EndInit();
            this.systemBindingNavigator.ResumeLayout(false);
            this.systemBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solarpvbdDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private solarpvbdDataSet solarpvbdDataSet;
        private System.Windows.Forms.BindingSource systemBindingSource;
        private solarpvbdDataSetTableAdapters.SystemTableAdapter systemTableAdapter;
        private solarpvbdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator systemBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton systemBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox designIDTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox irradTextBox;
        private System.Windows.Forms.TextBox totKwattTextBox;
        private System.Windows.Forms.TextBox panelModelTextBox;
        private System.Windows.Forms.TextBox noPanelTextBox;
        private System.Windows.Forms.TextBox pnelPowTextBox;
        private System.Windows.Forms.TextBox pnelVoltTextBox;
        private System.Windows.Forms.TextBox pnelCurrentTextBox;
        private System.Windows.Forms.TextBox battModelTextBox;
        private System.Windows.Forms.TextBox noofBattTextBox;
        private System.Windows.Forms.TextBox battVoltTextBox;
        private System.Windows.Forms.TextBox battAHTextBox;
        private System.Windows.Forms.TextBox battCurrentTextBox;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.TextBox wattHourReqTextBox;
        private System.Windows.Forms.TextBox battbankAHTextBox;
        private System.Windows.Forms.TextBox housenumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}