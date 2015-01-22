namespace SalemOptimizer
{
    partial class MainForm
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
            this.btnFindSolution = new System.Windows.Forms.Button();
            this.lvInspirationals = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblInspirationals = new System.Windows.Forms.Label();
            this.grpDesiredProficiencies = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudPerenialPhilosophy = new System.Windows.Forms.NumericUpDown();
            this.nudNaturalPhilosophy = new System.Windows.Forms.NumericUpDown();
            this.nudThreadAndNeedle = new System.Windows.Forms.NumericUpDown();
            this.nudSugarAndSpice = new System.Windows.Forms.NumericUpDown();
            this.nudStocksAndCultivars = new System.Windows.Forms.NumericUpDown();
            this.nudSparksAndEmbers = new System.Windows.Forms.NumericUpDown();
            this.nudHerbsAndSprouts = new System.Windows.Forms.NumericUpDown();
            this.nudMinesAndMountains = new System.Windows.Forms.NumericUpDown();
            this.nudLawAndLore = new System.Windows.Forms.NumericUpDown();
            this.nudHuntingAndHideworking = new System.Windows.Forms.NumericUpDown();
            this.nudHammerAndNail = new System.Windows.Forms.NumericUpDown();
            this.nudFloraAndFauna = new System.Windows.Forms.NumericUpDown();
            this.nudCloakAndDagger = new System.Windows.Forms.NumericUpDown();
            this.lblArtsAndCrafts = new System.Windows.Forms.Label();
            this.lblCloakAndDagger = new System.Windows.Forms.Label();
            this.lblFloraAndFauna = new System.Windows.Forms.Label();
            this.lblHammerAndNail = new System.Windows.Forms.Label();
            this.lblHuntingAndHideworking = new System.Windows.Forms.Label();
            this.lblLawAndLore = new System.Windows.Forms.Label();
            this.lblMinesAndMountains = new System.Windows.Forms.Label();
            this.lblHerbsAndSprouts = new System.Windows.Forms.Label();
            this.lblSparksAndEmbers = new System.Windows.Forms.Label();
            this.lblStocksAndCultivars = new System.Windows.Forms.Label();
            this.lblSugarAndSpice = new System.Windows.Forms.Label();
            this.lblThreadAndNeedle = new System.Windows.Forms.Label();
            this.lblNaturalPhilosophy = new System.Windows.Forms.Label();
            this.lblPerenialPhilosophy = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.nudArtsAndCrafts = new System.Windows.Forms.NumericUpDown();
            this.lblFaithAndWisdom = new System.Windows.Forms.Label();
            this.nudFaithAndWisdom = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.grpSolution = new System.Windows.Forms.GroupBox();
            this.lvSolutions = new System.Windows.Forms.ListView();
            this.chOrganism = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpDesiredProficiencies.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerenialPhilosophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNaturalPhilosophy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadAndNeedle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSugarAndSpice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStocksAndCultivars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSparksAndEmbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHerbsAndSprouts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinesAndMountains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLawAndLore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHuntingAndHideworking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHammerAndNail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloraAndFauna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCloakAndDagger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArtsAndCrafts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaithAndWisdom)).BeginInit();
            this.grpSolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFindSolution
            // 
            this.btnFindSolution.Location = new System.Drawing.Point(6, 19);
            this.btnFindSolution.Name = "btnFindSolution";
            this.btnFindSolution.Size = new System.Drawing.Size(56, 23);
            this.btnFindSolution.TabIndex = 0;
            this.btnFindSolution.Text = "Find";
            this.btnFindSolution.UseVisualStyleBackColor = true;
            this.btnFindSolution.Click += new System.EventHandler(this.btnFindSolution_Click);
            // 
            // lvInspirationals
            // 
            this.lvInspirationals.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvInspirationals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInspirationals.CheckBoxes = true;
            this.lvInspirationals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chTotalCost});
            this.lvInspirationals.FullRowSelect = true;
            this.lvInspirationals.Location = new System.Drawing.Point(12, 25);
            this.lvInspirationals.Name = "lvInspirationals";
            this.lvInspirationals.ShowGroups = false;
            this.lvInspirationals.Size = new System.Drawing.Size(399, 208);
            this.lvInspirationals.TabIndex = 2;
            this.lvInspirationals.UseCompatibleStateImageBehavior = false;
            this.lvInspirationals.View = System.Windows.Forms.View.Details;
            this.lvInspirationals.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 113;
            // 
            // chTotalCost
            // 
            this.chTotalCost.Text = "Total cost";
            this.chTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chTotalCost.Width = 70;
            // 
            // lblInspirationals
            // 
            this.lblInspirationals.AutoSize = true;
            this.lblInspirationals.Location = new System.Drawing.Point(12, 9);
            this.lblInspirationals.Name = "lblInspirationals";
            this.lblInspirationals.Size = new System.Drawing.Size(116, 13);
            this.lblInspirationals.TabIndex = 3;
            this.lblInspirationals.Text = "Available inspirationals:";
            // 
            // grpDesiredProficiencies
            // 
            this.grpDesiredProficiencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDesiredProficiencies.Controls.Add(this.tableLayoutPanel1);
            this.grpDesiredProficiencies.Location = new System.Drawing.Point(417, 12);
            this.grpDesiredProficiencies.Name = "grpDesiredProficiencies";
            this.grpDesiredProficiencies.Size = new System.Drawing.Size(235, 438);
            this.grpDesiredProficiencies.TabIndex = 4;
            this.grpDesiredProficiencies.TabStop = false;
            this.grpDesiredProficiencies.Text = "Desired proficiencies";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.nudPerenialPhilosophy, 1, 14);
            this.tableLayoutPanel1.Controls.Add(this.nudNaturalPhilosophy, 1, 13);
            this.tableLayoutPanel1.Controls.Add(this.nudThreadAndNeedle, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.nudSugarAndSpice, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.nudStocksAndCultivars, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.nudSparksAndEmbers, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.nudHerbsAndSprouts, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.nudMinesAndMountains, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.nudLawAndLore, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.nudHuntingAndHideworking, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudHammerAndNail, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudFloraAndFauna, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudCloakAndDagger, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblArtsAndCrafts, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCloakAndDagger, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFloraAndFauna, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblHammerAndNail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblHuntingAndHideworking, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblLawAndLore, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMinesAndMountains, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblHerbsAndSprouts, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblSparksAndEmbers, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblStocksAndCultivars, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblSugarAndSpice, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lblThreadAndNeedle, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblNaturalPhilosophy, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.lblPerenialPhilosophy, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.btnResetAll, 1, 15);
            this.tableLayoutPanel1.Controls.Add(this.nudArtsAndCrafts, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFaithAndWisdom, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudFaithAndWisdom, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(229, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // nudPerenialPhilosophy
            // 
            this.nudPerenialPhilosophy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPerenialPhilosophy.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "PerenialPhilosophy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudPerenialPhilosophy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPerenialPhilosophy.Location = new System.Drawing.Point(143, 367);
            this.nudPerenialPhilosophy.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPerenialPhilosophy.Name = "nudPerenialPhilosophy";
            this.nudPerenialPhilosophy.Size = new System.Drawing.Size(83, 20);
            this.nudPerenialPhilosophy.TabIndex = 30;
            this.nudPerenialPhilosophy.ThousandsSeparator = true;
            this.nudPerenialPhilosophy.Value = global::SalemOptimizer.Properties.Settings.Default.PerenialPhilosophy;
            // 
            // nudNaturalPhilosophy
            // 
            this.nudNaturalPhilosophy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudNaturalPhilosophy.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "NaturalPhilosophy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudNaturalPhilosophy.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudNaturalPhilosophy.Location = new System.Drawing.Point(143, 341);
            this.nudNaturalPhilosophy.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudNaturalPhilosophy.Name = "nudNaturalPhilosophy";
            this.nudNaturalPhilosophy.Size = new System.Drawing.Size(83, 20);
            this.nudNaturalPhilosophy.TabIndex = 29;
            this.nudNaturalPhilosophy.ThousandsSeparator = true;
            this.nudNaturalPhilosophy.Value = global::SalemOptimizer.Properties.Settings.Default.NaturalPhilosophy;
            // 
            // nudThreadAndNeedle
            // 
            this.nudThreadAndNeedle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudThreadAndNeedle.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "ThreadAndNeedle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudThreadAndNeedle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudThreadAndNeedle.Location = new System.Drawing.Point(143, 315);
            this.nudThreadAndNeedle.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudThreadAndNeedle.Name = "nudThreadAndNeedle";
            this.nudThreadAndNeedle.Size = new System.Drawing.Size(83, 20);
            this.nudThreadAndNeedle.TabIndex = 28;
            this.nudThreadAndNeedle.ThousandsSeparator = true;
            this.nudThreadAndNeedle.Value = global::SalemOptimizer.Properties.Settings.Default.ThreadAndNeedle;
            // 
            // nudSugarAndSpice
            // 
            this.nudSugarAndSpice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSugarAndSpice.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "SugarAndSpice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudSugarAndSpice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSugarAndSpice.Location = new System.Drawing.Point(143, 289);
            this.nudSugarAndSpice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSugarAndSpice.Name = "nudSugarAndSpice";
            this.nudSugarAndSpice.Size = new System.Drawing.Size(83, 20);
            this.nudSugarAndSpice.TabIndex = 27;
            this.nudSugarAndSpice.ThousandsSeparator = true;
            this.nudSugarAndSpice.Value = global::SalemOptimizer.Properties.Settings.Default.SugarAndSpice;
            // 
            // nudStocksAndCultivars
            // 
            this.nudStocksAndCultivars.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStocksAndCultivars.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "StocksAndCultivars", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudStocksAndCultivars.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudStocksAndCultivars.Location = new System.Drawing.Point(143, 263);
            this.nudStocksAndCultivars.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudStocksAndCultivars.Name = "nudStocksAndCultivars";
            this.nudStocksAndCultivars.Size = new System.Drawing.Size(83, 20);
            this.nudStocksAndCultivars.TabIndex = 26;
            this.nudStocksAndCultivars.ThousandsSeparator = true;
            this.nudStocksAndCultivars.Value = global::SalemOptimizer.Properties.Settings.Default.StocksAndCultivars;
            // 
            // nudSparksAndEmbers
            // 
            this.nudSparksAndEmbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSparksAndEmbers.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "SparksAndEmbers", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudSparksAndEmbers.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSparksAndEmbers.Location = new System.Drawing.Point(143, 237);
            this.nudSparksAndEmbers.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudSparksAndEmbers.Name = "nudSparksAndEmbers";
            this.nudSparksAndEmbers.Size = new System.Drawing.Size(83, 20);
            this.nudSparksAndEmbers.TabIndex = 25;
            this.nudSparksAndEmbers.ThousandsSeparator = true;
            this.nudSparksAndEmbers.Value = global::SalemOptimizer.Properties.Settings.Default.SparksAndEmbers;
            // 
            // nudHerbsAndSprouts
            // 
            this.nudHerbsAndSprouts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHerbsAndSprouts.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "HerbsAndSprouts", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudHerbsAndSprouts.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHerbsAndSprouts.Location = new System.Drawing.Point(143, 211);
            this.nudHerbsAndSprouts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudHerbsAndSprouts.Name = "nudHerbsAndSprouts";
            this.nudHerbsAndSprouts.Size = new System.Drawing.Size(83, 20);
            this.nudHerbsAndSprouts.TabIndex = 24;
            this.nudHerbsAndSprouts.ThousandsSeparator = true;
            this.nudHerbsAndSprouts.Value = global::SalemOptimizer.Properties.Settings.Default.HerbsAndSprouts;
            // 
            // nudMinesAndMountains
            // 
            this.nudMinesAndMountains.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudMinesAndMountains.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "MinesAndMountains", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudMinesAndMountains.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinesAndMountains.Location = new System.Drawing.Point(143, 185);
            this.nudMinesAndMountains.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMinesAndMountains.Name = "nudMinesAndMountains";
            this.nudMinesAndMountains.Size = new System.Drawing.Size(83, 20);
            this.nudMinesAndMountains.TabIndex = 23;
            this.nudMinesAndMountains.ThousandsSeparator = true;
            this.nudMinesAndMountains.Value = global::SalemOptimizer.Properties.Settings.Default.MinesAndMountains;
            // 
            // nudLawAndLore
            // 
            this.nudLawAndLore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudLawAndLore.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "LawAndLore", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudLawAndLore.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLawAndLore.Location = new System.Drawing.Point(143, 159);
            this.nudLawAndLore.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudLawAndLore.Name = "nudLawAndLore";
            this.nudLawAndLore.Size = new System.Drawing.Size(83, 20);
            this.nudLawAndLore.TabIndex = 22;
            this.nudLawAndLore.ThousandsSeparator = true;
            this.nudLawAndLore.Value = global::SalemOptimizer.Properties.Settings.Default.LawAndLore;
            // 
            // nudHuntingAndHideworking
            // 
            this.nudHuntingAndHideworking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHuntingAndHideworking.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "HuntingAndHideworking", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudHuntingAndHideworking.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHuntingAndHideworking.Location = new System.Drawing.Point(143, 133);
            this.nudHuntingAndHideworking.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudHuntingAndHideworking.Name = "nudHuntingAndHideworking";
            this.nudHuntingAndHideworking.Size = new System.Drawing.Size(83, 20);
            this.nudHuntingAndHideworking.TabIndex = 21;
            this.nudHuntingAndHideworking.ThousandsSeparator = true;
            this.nudHuntingAndHideworking.Value = global::SalemOptimizer.Properties.Settings.Default.HuntingAndHideworking;
            // 
            // nudHammerAndNail
            // 
            this.nudHammerAndNail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudHammerAndNail.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "HammerAndNail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudHammerAndNail.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHammerAndNail.Location = new System.Drawing.Point(143, 107);
            this.nudHammerAndNail.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudHammerAndNail.Name = "nudHammerAndNail";
            this.nudHammerAndNail.Size = new System.Drawing.Size(83, 20);
            this.nudHammerAndNail.TabIndex = 20;
            this.nudHammerAndNail.ThousandsSeparator = true;
            this.nudHammerAndNail.Value = global::SalemOptimizer.Properties.Settings.Default.HammerAndNail;
            // 
            // nudFloraAndFauna
            // 
            this.nudFloraAndFauna.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFloraAndFauna.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "FloraAndFauna", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudFloraAndFauna.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFloraAndFauna.Location = new System.Drawing.Point(143, 81);
            this.nudFloraAndFauna.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudFloraAndFauna.Name = "nudFloraAndFauna";
            this.nudFloraAndFauna.Size = new System.Drawing.Size(83, 20);
            this.nudFloraAndFauna.TabIndex = 19;
            this.nudFloraAndFauna.ThousandsSeparator = true;
            this.nudFloraAndFauna.Value = global::SalemOptimizer.Properties.Settings.Default.FloraAndFauna;
            // 
            // nudCloakAndDagger
            // 
            this.nudCloakAndDagger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudCloakAndDagger.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "CloakAndDagger", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudCloakAndDagger.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCloakAndDagger.Location = new System.Drawing.Point(143, 29);
            this.nudCloakAndDagger.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCloakAndDagger.Name = "nudCloakAndDagger";
            this.nudCloakAndDagger.Size = new System.Drawing.Size(83, 20);
            this.nudCloakAndDagger.TabIndex = 17;
            this.nudCloakAndDagger.ThousandsSeparator = true;
            this.nudCloakAndDagger.Value = global::SalemOptimizer.Properties.Settings.Default.CloakAndDagger;
            // 
            // lblArtsAndCrafts
            // 
            this.lblArtsAndCrafts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblArtsAndCrafts.AutoSize = true;
            this.lblArtsAndCrafts.Location = new System.Drawing.Point(3, 6);
            this.lblArtsAndCrafts.Name = "lblArtsAndCrafts";
            this.lblArtsAndCrafts.Size = new System.Drawing.Size(76, 13);
            this.lblArtsAndCrafts.TabIndex = 0;
            this.lblArtsAndCrafts.Text = "Arts and Crafts";
            // 
            // lblCloakAndDagger
            // 
            this.lblCloakAndDagger.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCloakAndDagger.AutoSize = true;
            this.lblCloakAndDagger.Location = new System.Drawing.Point(3, 32);
            this.lblCloakAndDagger.Name = "lblCloakAndDagger";
            this.lblCloakAndDagger.Size = new System.Drawing.Size(91, 13);
            this.lblCloakAndDagger.TabIndex = 1;
            this.lblCloakAndDagger.Text = "Cloak and dagger";
            // 
            // lblFloraAndFauna
            // 
            this.lblFloraAndFauna.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFloraAndFauna.AutoSize = true;
            this.lblFloraAndFauna.Location = new System.Drawing.Point(3, 84);
            this.lblFloraAndFauna.Name = "lblFloraAndFauna";
            this.lblFloraAndFauna.Size = new System.Drawing.Size(84, 13);
            this.lblFloraAndFauna.TabIndex = 3;
            this.lblFloraAndFauna.Text = "Flora and Fauna";
            // 
            // lblHammerAndNail
            // 
            this.lblHammerAndNail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHammerAndNail.AutoSize = true;
            this.lblHammerAndNail.Location = new System.Drawing.Point(3, 110);
            this.lblHammerAndNail.Name = "lblHammerAndNail";
            this.lblHammerAndNail.Size = new System.Drawing.Size(88, 13);
            this.lblHammerAndNail.TabIndex = 4;
            this.lblHammerAndNail.Text = "Hammer and Nail";
            // 
            // lblHuntingAndHideworking
            // 
            this.lblHuntingAndHideworking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHuntingAndHideworking.AutoSize = true;
            this.lblHuntingAndHideworking.Location = new System.Drawing.Point(3, 136);
            this.lblHuntingAndHideworking.Name = "lblHuntingAndHideworking";
            this.lblHuntingAndHideworking.Size = new System.Drawing.Size(127, 13);
            this.lblHuntingAndHideworking.TabIndex = 5;
            this.lblHuntingAndHideworking.Text = "Hunting and Hideworking";
            // 
            // lblLawAndLore
            // 
            this.lblLawAndLore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLawAndLore.AutoSize = true;
            this.lblLawAndLore.Location = new System.Drawing.Point(3, 162);
            this.lblLawAndLore.Name = "lblLawAndLore";
            this.lblLawAndLore.Size = new System.Drawing.Size(72, 13);
            this.lblLawAndLore.TabIndex = 6;
            this.lblLawAndLore.Text = "Law and Lore";
            // 
            // lblMinesAndMountains
            // 
            this.lblMinesAndMountains.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMinesAndMountains.AutoSize = true;
            this.lblMinesAndMountains.Location = new System.Drawing.Point(3, 188);
            this.lblMinesAndMountains.Name = "lblMinesAndMountains";
            this.lblMinesAndMountains.Size = new System.Drawing.Size(108, 13);
            this.lblMinesAndMountains.TabIndex = 7;
            this.lblMinesAndMountains.Text = "Mines and Mountains";
            // 
            // lblHerbsAndSprouts
            // 
            this.lblHerbsAndSprouts.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHerbsAndSprouts.AutoSize = true;
            this.lblHerbsAndSprouts.Location = new System.Drawing.Point(3, 214);
            this.lblHerbsAndSprouts.Name = "lblHerbsAndSprouts";
            this.lblHerbsAndSprouts.Size = new System.Drawing.Size(95, 13);
            this.lblHerbsAndSprouts.TabIndex = 8;
            this.lblHerbsAndSprouts.Text = "Herbs and Sprouts";
            // 
            // lblSparksAndEmbers
            // 
            this.lblSparksAndEmbers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSparksAndEmbers.AutoSize = true;
            this.lblSparksAndEmbers.Location = new System.Drawing.Point(3, 240);
            this.lblSparksAndEmbers.Name = "lblSparksAndEmbers";
            this.lblSparksAndEmbers.Size = new System.Drawing.Size(99, 13);
            this.lblSparksAndEmbers.TabIndex = 9;
            this.lblSparksAndEmbers.Text = "Sparks and Embers";
            // 
            // lblStocksAndCultivars
            // 
            this.lblStocksAndCultivars.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStocksAndCultivars.AutoSize = true;
            this.lblStocksAndCultivars.Location = new System.Drawing.Point(3, 266);
            this.lblStocksAndCultivars.Name = "lblStocksAndCultivars";
            this.lblStocksAndCultivars.Size = new System.Drawing.Size(104, 13);
            this.lblStocksAndCultivars.TabIndex = 10;
            this.lblStocksAndCultivars.Text = "Stocks and Cultivars";
            // 
            // lblSugarAndSpice
            // 
            this.lblSugarAndSpice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSugarAndSpice.AutoSize = true;
            this.lblSugarAndSpice.Location = new System.Drawing.Point(3, 292);
            this.lblSugarAndSpice.Name = "lblSugarAndSpice";
            this.lblSugarAndSpice.Size = new System.Drawing.Size(86, 13);
            this.lblSugarAndSpice.TabIndex = 11;
            this.lblSugarAndSpice.Text = "Sugar and Spice";
            // 
            // lblThreadAndNeedle
            // 
            this.lblThreadAndNeedle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblThreadAndNeedle.AutoSize = true;
            this.lblThreadAndNeedle.Location = new System.Drawing.Point(3, 318);
            this.lblThreadAndNeedle.Name = "lblThreadAndNeedle";
            this.lblThreadAndNeedle.Size = new System.Drawing.Size(99, 13);
            this.lblThreadAndNeedle.TabIndex = 12;
            this.lblThreadAndNeedle.Text = "Thread and Needle";
            // 
            // lblNaturalPhilosophy
            // 
            this.lblNaturalPhilosophy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNaturalPhilosophy.AutoSize = true;
            this.lblNaturalPhilosophy.Location = new System.Drawing.Point(3, 344);
            this.lblNaturalPhilosophy.Name = "lblNaturalPhilosophy";
            this.lblNaturalPhilosophy.Size = new System.Drawing.Size(95, 13);
            this.lblNaturalPhilosophy.TabIndex = 13;
            this.lblNaturalPhilosophy.Text = "Natural Philosophy";
            // 
            // lblPerenialPhilosophy
            // 
            this.lblPerenialPhilosophy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPerenialPhilosophy.AutoSize = true;
            this.lblPerenialPhilosophy.Location = new System.Drawing.Point(3, 370);
            this.lblPerenialPhilosophy.Name = "lblPerenialPhilosophy";
            this.lblPerenialPhilosophy.Size = new System.Drawing.Size(99, 13);
            this.lblPerenialPhilosophy.TabIndex = 14;
            this.lblPerenialPhilosophy.Text = "Perenial Philosophy";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetAll.Location = new System.Drawing.Point(143, 393);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(83, 23);
            this.btnResetAll.TabIndex = 15;
            this.btnResetAll.Text = "Reset all";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // nudArtsAndCrafts
            // 
            this.nudArtsAndCrafts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudArtsAndCrafts.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "ArtsAndCrafts", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudArtsAndCrafts.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudArtsAndCrafts.Location = new System.Drawing.Point(143, 3);
            this.nudArtsAndCrafts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudArtsAndCrafts.Name = "nudArtsAndCrafts";
            this.nudArtsAndCrafts.Size = new System.Drawing.Size(83, 20);
            this.nudArtsAndCrafts.TabIndex = 16;
            this.nudArtsAndCrafts.ThousandsSeparator = true;
            this.nudArtsAndCrafts.Value = global::SalemOptimizer.Properties.Settings.Default.ArtsAndCrafts;
            // 
            // lblFaithAndWisdom
            // 
            this.lblFaithAndWisdom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFaithAndWisdom.AutoSize = true;
            this.lblFaithAndWisdom.Location = new System.Drawing.Point(3, 58);
            this.lblFaithAndWisdom.Name = "lblFaithAndWisdom";
            this.lblFaithAndWisdom.Size = new System.Drawing.Size(92, 13);
            this.lblFaithAndWisdom.TabIndex = 2;
            this.lblFaithAndWisdom.Text = "Faith and Wisdom";
            // 
            // nudFaithAndWisdom
            // 
            this.nudFaithAndWisdom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nudFaithAndWisdom.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SalemOptimizer.Properties.Settings.Default, "FaithAndWisdom", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nudFaithAndWisdom.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudFaithAndWisdom.Location = new System.Drawing.Point(143, 55);
            this.nudFaithAndWisdom.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudFaithAndWisdom.Name = "nudFaithAndWisdom";
            this.nudFaithAndWisdom.Size = new System.Drawing.Size(83, 20);
            this.nudFaithAndWisdom.TabIndex = 18;
            this.nudFaithAndWisdom.ThousandsSeparator = true;
            this.nudFaithAndWisdom.Value = global::SalemOptimizer.Properties.Settings.Default.FaithAndWisdom;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(68, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(59, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grpSolution
            // 
            this.grpSolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSolution.Controls.Add(this.lvSolutions);
            this.grpSolution.Controls.Add(this.btnFindSolution);
            this.grpSolution.Controls.Add(this.btnStop);
            this.grpSolution.Location = new System.Drawing.Point(12, 242);
            this.grpSolution.Name = "grpSolution";
            this.grpSolution.Size = new System.Drawing.Size(399, 208);
            this.grpSolution.TabIndex = 6;
            this.grpSolution.TabStop = false;
            this.grpSolution.Text = "Solution";
            // 
            // lvSolutions
            // 
            this.lvSolutions.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvSolutions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSolutions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chOrganism,
            this.chCost});
            this.lvSolutions.Location = new System.Drawing.Point(6, 48);
            this.lvSolutions.Name = "lvSolutions";
            this.lvSolutions.Size = new System.Drawing.Size(387, 154);
            this.lvSolutions.TabIndex = 6;
            this.lvSolutions.UseCompatibleStateImageBehavior = false;
            this.lvSolutions.View = System.Windows.Forms.View.Details;
            this.lvSolutions.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // chOrganism
            // 
            this.chOrganism.Text = "Organism";
            this.chOrganism.Width = 205;
            // 
            // chCost
            // 
            this.chCost.Text = "Cost";
            this.chCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 462);
            this.Controls.Add(this.grpSolution);
            this.Controls.Add(this.grpDesiredProficiencies);
            this.Controls.Add(this.lblInspirationals);
            this.Controls.Add(this.lvInspirationals);
            this.MinimumSize = new System.Drawing.Size(350, 501);
            this.Name = "MainForm";
            this.Text = "Salem Optimizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpDesiredProficiencies.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPerenialPhilosophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNaturalPhilosophy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadAndNeedle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSugarAndSpice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStocksAndCultivars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSparksAndEmbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHerbsAndSprouts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinesAndMountains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLawAndLore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHuntingAndHideworking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHammerAndNail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFloraAndFauna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCloakAndDagger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudArtsAndCrafts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaithAndWisdom)).EndInit();
            this.grpSolution.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindSolution;
        private System.Windows.Forms.ListView lvInspirationals;
        private System.Windows.Forms.Label lblInspirationals;
        private System.Windows.Forms.GroupBox grpDesiredProficiencies;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblArtsAndCrafts;
        private System.Windows.Forms.Label lblCloakAndDagger;
        private System.Windows.Forms.Label lblFaithAndWisdom;
        private System.Windows.Forms.Label lblFloraAndFauna;
        private System.Windows.Forms.Label lblHammerAndNail;
        private System.Windows.Forms.Label lblHuntingAndHideworking;
        private System.Windows.Forms.Label lblLawAndLore;
        private System.Windows.Forms.Label lblMinesAndMountains;
        private System.Windows.Forms.Label lblHerbsAndSprouts;
        private System.Windows.Forms.Label lblSparksAndEmbers;
        private System.Windows.Forms.Label lblStocksAndCultivars;
        private System.Windows.Forms.Label lblSugarAndSpice;
        private System.Windows.Forms.Label lblThreadAndNeedle;
        private System.Windows.Forms.Label lblNaturalPhilosophy;
        private System.Windows.Forms.Label lblPerenialPhilosophy;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chTotalCost;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.NumericUpDown nudArtsAndCrafts;
        private System.Windows.Forms.NumericUpDown nudCloakAndDagger;
        private System.Windows.Forms.NumericUpDown nudFaithAndWisdom;
        private System.Windows.Forms.NumericUpDown nudPerenialPhilosophy;
        private System.Windows.Forms.NumericUpDown nudNaturalPhilosophy;
        private System.Windows.Forms.NumericUpDown nudThreadAndNeedle;
        private System.Windows.Forms.NumericUpDown nudSugarAndSpice;
        private System.Windows.Forms.NumericUpDown nudStocksAndCultivars;
        private System.Windows.Forms.NumericUpDown nudSparksAndEmbers;
        private System.Windows.Forms.NumericUpDown nudHerbsAndSprouts;
        private System.Windows.Forms.NumericUpDown nudMinesAndMountains;
        private System.Windows.Forms.NumericUpDown nudLawAndLore;
        private System.Windows.Forms.NumericUpDown nudHuntingAndHideworking;
        private System.Windows.Forms.NumericUpDown nudHammerAndNail;
        private System.Windows.Forms.NumericUpDown nudFloraAndFauna;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grpSolution;
        private System.Windows.Forms.ListView lvSolutions;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chOrganism;
    }
}

