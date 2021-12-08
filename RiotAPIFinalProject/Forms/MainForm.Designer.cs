
namespace RiotAPIFinalProject
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
            this.components = new System.ComponentModel.Container();
            this.summonerSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchSummonerNameLabel = new System.Windows.Forms.Label();
            this.summonerInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.summonerLevelTextBox = new System.Windows.Forms.TextBox();
            this.riotAPIViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.summonerLevelLabel = new System.Windows.Forms.Label();
            this.summonerNameTextBox = new System.Windows.Forms.TextBox();
            this.summonerNameLabel = new System.Windows.Forms.Label();
            this.puuIDTextBox = new System.Windows.Forms.TextBox();
            this.puuIDLabel = new System.Windows.Forms.Label();
            this.accountIDTextBox = new System.Windows.Forms.TextBox();
            this.accountIDLabel = new System.Windows.Forms.Label();
            this.summonerSearchButton = new System.Windows.Forms.Button();
            this.championsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.championsLabel = new System.Windows.Forms.Label();
            this.championMasteriesListBox = new System.Windows.Forms.ListBox();
            this.masteryStatsGroupBox = new System.Windows.Forms.GroupBox();
            this.tokensEarnedTextBox = new System.Windows.Forms.TextBox();
            this.tokensEarnedLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chestGrantedLabel = new System.Windows.Forms.Label();
            this.pointsToLevelTextBox = new System.Windows.Forms.TextBox();
            this.pointsToLevelLabel = new System.Windows.Forms.Label();
            this.championPointsTextBox = new System.Windows.Forms.TextBox();
            this.championPointsLabel = new System.Windows.Forms.Label();
            this.championLevelTextBox = new System.Windows.Forms.TextBox();
            this.championLevelLabel = new System.Windows.Forms.Label();
            this.matchInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.currentMatchInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.matchesListBox = new System.Windows.Forms.ListBox();
            this.lastTenMatchesLabel = new System.Windows.Forms.Label();
            this.riotAPIKeyLabel = new System.Windows.Forms.Label();
            this.riotAPIKeyTextBox = new System.Windows.Forms.TextBox();
            this.championMasteryGroupBox = new System.Windows.Forms.GroupBox();
            this.matchesGroupBox = new System.Windows.Forms.GroupBox();
            this.summonerInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riotAPIViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.championsBindingSource)).BeginInit();
            this.accountInfoGroupBox.SuspendLayout();
            this.masteryStatsGroupBox.SuspendLayout();
            this.matchInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentMatchInfoBindingSource)).BeginInit();
            this.championMasteryGroupBox.SuspendLayout();
            this.matchesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // summonerSearchTextBox
            // 
            this.summonerSearchTextBox.Enabled = false;
            this.summonerSearchTextBox.Location = new System.Drawing.Point(175, 25);
            this.summonerSearchTextBox.Name = "summonerSearchTextBox";
            this.summonerSearchTextBox.Size = new System.Drawing.Size(134, 20);
            this.summonerSearchTextBox.TabIndex = 3;
            this.summonerSearchTextBox.TextChanged += new System.EventHandler(this.summonerSearchTextBox_TextChanged);
            // 
            // searchSummonerNameLabel
            // 
            this.searchSummonerNameLabel.AutoSize = true;
            this.searchSummonerNameLabel.Location = new System.Drawing.Point(172, 9);
            this.searchSummonerNameLabel.Name = "searchSummonerNameLabel";
            this.searchSummonerNameLabel.Size = new System.Drawing.Size(139, 13);
            this.searchSummonerNameLabel.TabIndex = 2;
            this.searchSummonerNameLabel.Text = "&Search by Summoner Name";
            // 
            // summonerInfoGroupBox
            // 
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.summonerLevelLabel);
            this.summonerInfoGroupBox.Controls.Add(this.summonerNameTextBox);
            this.summonerInfoGroupBox.Controls.Add(this.summonerNameLabel);
            this.summonerInfoGroupBox.Location = new System.Drawing.Point(317, 9);
            this.summonerInfoGroupBox.Name = "summonerInfoGroupBox";
            this.summonerInfoGroupBox.Size = new System.Drawing.Size(229, 73);
            this.summonerInfoGroupBox.TabIndex = 5;
            this.summonerInfoGroupBox.TabStop = false;
            this.summonerInfoGroupBox.Text = "Summoner Information";
            // 
            // summonerLevelTextBox
            // 
            this.summonerLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.riotAPIViewModelBindingSource, "Summoner.SummonerLevel", true));
            this.summonerLevelTextBox.Location = new System.Drawing.Point(132, 42);
            this.summonerLevelTextBox.Name = "summonerLevelTextBox";
            this.summonerLevelTextBox.ReadOnly = true;
            this.summonerLevelTextBox.Size = new System.Drawing.Size(82, 20);
            this.summonerLevelTextBox.TabIndex = 3;
            // 
            // riotAPIViewModelBindingSource
            // 
            this.riotAPIViewModelBindingSource.DataSource = typeof(RiotAPIFinalProject.ViewModels.RiotAPIViewModel);
            // 
            // summonerLevelLabel
            // 
            this.summonerLevelLabel.AutoSize = true;
            this.summonerLevelLabel.Location = new System.Drawing.Point(129, 26);
            this.summonerLevelLabel.Name = "summonerLevelLabel";
            this.summonerLevelLabel.Size = new System.Drawing.Size(86, 13);
            this.summonerLevelLabel.TabIndex = 2;
            this.summonerLevelLabel.Text = "Summoner Level";
            // 
            // summonerNameTextBox
            // 
            this.summonerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.riotAPIViewModelBindingSource, "Summoner.Name", true));
            this.summonerNameTextBox.Location = new System.Drawing.Point(6, 42);
            this.summonerNameTextBox.Name = "summonerNameTextBox";
            this.summonerNameTextBox.ReadOnly = true;
            this.summonerNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.summonerNameTextBox.TabIndex = 1;
            // 
            // summonerNameLabel
            // 
            this.summonerNameLabel.AutoSize = true;
            this.summonerNameLabel.Location = new System.Drawing.Point(6, 26);
            this.summonerNameLabel.Name = "summonerNameLabel";
            this.summonerNameLabel.Size = new System.Drawing.Size(88, 13);
            this.summonerNameLabel.TabIndex = 0;
            this.summonerNameLabel.Text = "Summoner Name";
            // 
            // puuIDTextBox
            // 
            this.puuIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.riotAPIViewModelBindingSource, "Summoner.Puuid", true));
            this.puuIDTextBox.Location = new System.Drawing.Point(6, 74);
            this.puuIDTextBox.Name = "puuIDTextBox";
            this.puuIDTextBox.ReadOnly = true;
            this.puuIDTextBox.Size = new System.Drawing.Size(510, 20);
            this.puuIDTextBox.TabIndex = 3;
            // 
            // puuIDLabel
            // 
            this.puuIDLabel.AutoSize = true;
            this.puuIDLabel.Location = new System.Drawing.Point(6, 58);
            this.puuIDLabel.Name = "puuIDLabel";
            this.puuIDLabel.Size = new System.Drawing.Size(37, 13);
            this.puuIDLabel.TabIndex = 2;
            this.puuIDLabel.Text = "PuuID";
            // 
            // accountIDTextBox
            // 
            this.accountIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.riotAPIViewModelBindingSource, "Summoner.AccountId", true));
            this.accountIDTextBox.Location = new System.Drawing.Point(6, 35);
            this.accountIDTextBox.Name = "accountIDTextBox";
            this.accountIDTextBox.ReadOnly = true;
            this.accountIDTextBox.Size = new System.Drawing.Size(510, 20);
            this.accountIDTextBox.TabIndex = 1;
            // 
            // accountIDLabel
            // 
            this.accountIDLabel.AutoSize = true;
            this.accountIDLabel.Location = new System.Drawing.Point(6, 19);
            this.accountIDLabel.Name = "accountIDLabel";
            this.accountIDLabel.Size = new System.Drawing.Size(61, 13);
            this.accountIDLabel.TabIndex = 0;
            this.accountIDLabel.Text = "Account ID";
            // 
            // summonerSearchButton
            // 
            this.summonerSearchButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.summonerSearchButton.Enabled = false;
            this.summonerSearchButton.Location = new System.Drawing.Point(12, 52);
            this.summonerSearchButton.Name = "summonerSearchButton";
            this.summonerSearchButton.Size = new System.Drawing.Size(299, 23);
            this.summonerSearchButton.TabIndex = 4;
            this.summonerSearchButton.Text = "Search";
            this.summonerSearchButton.UseVisualStyleBackColor = true;
            this.summonerSearchButton.Click += new System.EventHandler(this.summonerSearchButton_Click);
            // 
            // championsBindingSource
            // 
            this.championsBindingSource.DataMember = "Champions";
            this.championsBindingSource.DataSource = this.riotAPIViewModelBindingSource;
            // 
            // accountInfoGroupBox
            // 
            this.accountInfoGroupBox.Controls.Add(this.accountIDLabel);
            this.accountInfoGroupBox.Controls.Add(this.puuIDTextBox);
            this.accountInfoGroupBox.Controls.Add(this.accountIDTextBox);
            this.accountInfoGroupBox.Controls.Add(this.puuIDLabel);
            this.accountInfoGroupBox.Location = new System.Drawing.Point(12, 90);
            this.accountInfoGroupBox.Name = "accountInfoGroupBox";
            this.accountInfoGroupBox.Size = new System.Drawing.Size(534, 103);
            this.accountInfoGroupBox.TabIndex = 6;
            this.accountInfoGroupBox.TabStop = false;
            this.accountInfoGroupBox.Text = "Account Information";
            // 
            // championsLabel
            // 
            this.championsLabel.AutoSize = true;
            this.championsLabel.Location = new System.Drawing.Point(8, 16);
            this.championsLabel.Name = "championsLabel";
            this.championsLabel.Size = new System.Drawing.Size(59, 13);
            this.championsLabel.TabIndex = 0;
            this.championsLabel.Text = "&Champions";
            // 
            // championMasteriesListBox
            // 
            this.championMasteriesListBox.DataSource = this.championsBindingSource;
            this.championMasteriesListBox.DisplayMember = "ChampName";
            this.championMasteriesListBox.FormattingEnabled = true;
            this.championMasteriesListBox.Location = new System.Drawing.Point(11, 33);
            this.championMasteriesListBox.Name = "championMasteriesListBox";
            this.championMasteriesListBox.Size = new System.Drawing.Size(100, 121);
            this.championMasteriesListBox.TabIndex = 1;
            this.championMasteriesListBox.ValueMember = "_AdditionalProperties";
            // 
            // masteryStatsGroupBox
            // 
            this.masteryStatsGroupBox.Controls.Add(this.tokensEarnedTextBox);
            this.masteryStatsGroupBox.Controls.Add(this.tokensEarnedLabel);
            this.masteryStatsGroupBox.Controls.Add(this.textBox1);
            this.masteryStatsGroupBox.Controls.Add(this.chestGrantedLabel);
            this.masteryStatsGroupBox.Controls.Add(this.pointsToLevelTextBox);
            this.masteryStatsGroupBox.Controls.Add(this.pointsToLevelLabel);
            this.masteryStatsGroupBox.Controls.Add(this.championPointsTextBox);
            this.masteryStatsGroupBox.Controls.Add(this.championPointsLabel);
            this.masteryStatsGroupBox.Controls.Add(this.championLevelTextBox);
            this.masteryStatsGroupBox.Controls.Add(this.championLevelLabel);
            this.masteryStatsGroupBox.Location = new System.Drawing.Point(117, 19);
            this.masteryStatsGroupBox.Name = "masteryStatsGroupBox";
            this.masteryStatsGroupBox.Size = new System.Drawing.Size(405, 138);
            this.masteryStatsGroupBox.TabIndex = 2;
            this.masteryStatsGroupBox.TabStop = false;
            this.masteryStatsGroupBox.Text = "Mastery Stats";
            // 
            // tokensEarnedTextBox
            // 
            this.tokensEarnedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.championsBindingSource, "TokensEarned", true));
            this.tokensEarnedTextBox.Location = new System.Drawing.Point(148, 88);
            this.tokensEarnedTextBox.Name = "tokensEarnedTextBox";
            this.tokensEarnedTextBox.ReadOnly = true;
            this.tokensEarnedTextBox.Size = new System.Drawing.Size(100, 20);
            this.tokensEarnedTextBox.TabIndex = 9;
            // 
            // tokensEarnedLabel
            // 
            this.tokensEarnedLabel.AutoSize = true;
            this.tokensEarnedLabel.Location = new System.Drawing.Point(145, 72);
            this.tokensEarnedLabel.Name = "tokensEarnedLabel";
            this.tokensEarnedLabel.Size = new System.Drawing.Size(80, 13);
            this.tokensEarnedLabel.TabIndex = 8;
            this.tokensEarnedLabel.Text = "Tokens Earned";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.championsBindingSource, "ChestGranted", true));
            this.textBox1.Location = new System.Drawing.Point(9, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // chestGrantedLabel
            // 
            this.chestGrantedLabel.AutoSize = true;
            this.chestGrantedLabel.Location = new System.Drawing.Point(6, 72);
            this.chestGrantedLabel.Name = "chestGrantedLabel";
            this.chestGrantedLabel.Size = new System.Drawing.Size(133, 13);
            this.chestGrantedLabel.TabIndex = 6;
            this.chestGrantedLabel.Text = "Chest Granted this Season";
            // 
            // pointsToLevelTextBox
            // 
            this.pointsToLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.championsBindingSource, "PointsToNextLevel", true));
            this.pointsToLevelTextBox.Location = new System.Drawing.Point(283, 33);
            this.pointsToLevelTextBox.Name = "pointsToLevelTextBox";
            this.pointsToLevelTextBox.ReadOnly = true;
            this.pointsToLevelTextBox.Size = new System.Drawing.Size(100, 20);
            this.pointsToLevelTextBox.TabIndex = 5;
            // 
            // pointsToLevelLabel
            // 
            this.pointsToLevelLabel.AutoSize = true;
            this.pointsToLevelLabel.Location = new System.Drawing.Point(280, 16);
            this.pointsToLevelLabel.Name = "pointsToLevelLabel";
            this.pointsToLevelLabel.Size = new System.Drawing.Size(102, 13);
            this.pointsToLevelLabel.TabIndex = 4;
            this.pointsToLevelLabel.Text = "Points to Next Level";
            // 
            // championPointsTextBox
            // 
            this.championPointsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.championsBindingSource, "ChampPoints", true));
            this.championPointsTextBox.Location = new System.Drawing.Point(148, 33);
            this.championPointsTextBox.Name = "championPointsTextBox";
            this.championPointsTextBox.ReadOnly = true;
            this.championPointsTextBox.Size = new System.Drawing.Size(77, 20);
            this.championPointsTextBox.TabIndex = 3;
            // 
            // championPointsLabel
            // 
            this.championPointsLabel.AutoSize = true;
            this.championPointsLabel.Location = new System.Drawing.Point(145, 16);
            this.championPointsLabel.Name = "championPointsLabel";
            this.championPointsLabel.Size = new System.Drawing.Size(83, 13);
            this.championPointsLabel.TabIndex = 2;
            this.championPointsLabel.Text = "ChampionPoints";
            // 
            // championLevelTextBox
            // 
            this.championLevelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.championsBindingSource, "ChampLevel", true));
            this.championLevelTextBox.Location = new System.Drawing.Point(9, 33);
            this.championLevelTextBox.Name = "championLevelTextBox";
            this.championLevelTextBox.ReadOnly = true;
            this.championLevelTextBox.Size = new System.Drawing.Size(80, 20);
            this.championLevelTextBox.TabIndex = 1;
            // 
            // championLevelLabel
            // 
            this.championLevelLabel.AutoSize = true;
            this.championLevelLabel.Location = new System.Drawing.Point(6, 16);
            this.championLevelLabel.Name = "championLevelLabel";
            this.championLevelLabel.Size = new System.Drawing.Size(83, 13);
            this.championLevelLabel.TabIndex = 0;
            this.championLevelLabel.Text = "Champion Level";
            // 
            // matchInfoGroupBox
            // 
            this.matchInfoGroupBox.Controls.Add(this.listBox1);
            this.matchInfoGroupBox.Controls.Add(this.textBox3);
            this.matchInfoGroupBox.Controls.Add(this.textBox2);
            this.matchInfoGroupBox.Location = new System.Drawing.Point(127, 19);
            this.matchInfoGroupBox.Name = "matchInfoGroupBox";
            this.matchInfoGroupBox.Size = new System.Drawing.Size(422, 325);
            this.matchInfoGroupBox.TabIndex = 2;
            this.matchInfoGroupBox.TabStop = false;
            this.matchInfoGroupBox.Text = "Match Info";
            // 
            // listBox1
            // 
            this.listBox1.DisplayMember = "_AdditionalProperties";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(274, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(142, 199);
            this.listBox1.TabIndex = 2;
            this.listBox1.ValueMember = "_AdditionalProperties";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentMatchInfoBindingSource, "GameMode", true));
            this.textBox3.Location = new System.Drawing.Point(7, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // currentMatchInfoBindingSource
            // 
            this.currentMatchInfoBindingSource.DataMember = "CurrentMatchInfo";
            this.currentMatchInfoBindingSource.DataSource = this.riotAPIViewModelBindingSource;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.currentMatchInfoBindingSource, "GameName", true));
            this.textBox2.Location = new System.Drawing.Point(7, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // matchesListBox
            // 
            this.matchesListBox.DataSource = this.currentMatchInfoBindingSource;
            this.matchesListBox.DisplayMember = "MatchID";
            this.matchesListBox.FormattingEnabled = true;
            this.matchesListBox.Location = new System.Drawing.Point(9, 31);
            this.matchesListBox.Name = "matchesListBox";
            this.matchesListBox.Size = new System.Drawing.Size(111, 303);
            this.matchesListBox.TabIndex = 1;
            this.matchesListBox.ValueMember = "GameMode";
            // 
            // lastTenMatchesLabel
            // 
            this.lastTenMatchesLabel.AutoSize = true;
            this.lastTenMatchesLabel.Location = new System.Drawing.Point(6, 15);
            this.lastTenMatchesLabel.Name = "lastTenMatchesLabel";
            this.lastTenMatchesLabel.Size = new System.Drawing.Size(86, 13);
            this.lastTenMatchesLabel.TabIndex = 0;
            this.lastTenMatchesLabel.Text = "Last 20 &Matches";
            // 
            // riotAPIKeyLabel
            // 
            this.riotAPIKeyLabel.AutoSize = true;
            this.riotAPIKeyLabel.Location = new System.Drawing.Point(9, 9);
            this.riotAPIKeyLabel.Name = "riotAPIKeyLabel";
            this.riotAPIKeyLabel.Size = new System.Drawing.Size(45, 13);
            this.riotAPIKeyLabel.TabIndex = 0;
            this.riotAPIKeyLabel.Text = "&API Key";
            // 
            // riotAPIKeyTextBox
            // 
            this.riotAPIKeyTextBox.Location = new System.Drawing.Point(12, 25);
            this.riotAPIKeyTextBox.Name = "riotAPIKeyTextBox";
            this.riotAPIKeyTextBox.Size = new System.Drawing.Size(147, 20);
            this.riotAPIKeyTextBox.TabIndex = 1;
            this.riotAPIKeyTextBox.TextChanged += new System.EventHandler(this.riotAPIKeyTextBox_TextChanged);
            // 
            // championMasteryGroupBox
            // 
            this.championMasteryGroupBox.Controls.Add(this.championsLabel);
            this.championMasteryGroupBox.Controls.Add(this.championMasteriesListBox);
            this.championMasteryGroupBox.Controls.Add(this.masteryStatsGroupBox);
            this.championMasteryGroupBox.Location = new System.Drawing.Point(12, 200);
            this.championMasteryGroupBox.Name = "championMasteryGroupBox";
            this.championMasteryGroupBox.Size = new System.Drawing.Size(534, 163);
            this.championMasteryGroupBox.TabIndex = 7;
            this.championMasteryGroupBox.TabStop = false;
            this.championMasteryGroupBox.Text = "Champion Masteries";
            // 
            // matchesGroupBox
            // 
            this.matchesGroupBox.Controls.Add(this.lastTenMatchesLabel);
            this.matchesGroupBox.Controls.Add(this.matchesListBox);
            this.matchesGroupBox.Controls.Add(this.matchInfoGroupBox);
            this.matchesGroupBox.Location = new System.Drawing.Point(553, 13);
            this.matchesGroupBox.Name = "matchesGroupBox";
            this.matchesGroupBox.Size = new System.Drawing.Size(555, 350);
            this.matchesGroupBox.TabIndex = 8;
            this.matchesGroupBox.TabStop = false;
            this.matchesGroupBox.Text = "Matches";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 368);
            this.Controls.Add(this.matchesGroupBox);
            this.Controls.Add(this.championMasteryGroupBox);
            this.Controls.Add(this.riotAPIKeyTextBox);
            this.Controls.Add(this.riotAPIKeyLabel);
            this.Controls.Add(this.accountInfoGroupBox);
            this.Controls.Add(this.summonerSearchButton);
            this.Controls.Add(this.summonerInfoGroupBox);
            this.Controls.Add(this.searchSummonerNameLabel);
            this.Controls.Add(this.summonerSearchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoL Summoner Search";
            this.summonerInfoGroupBox.ResumeLayout(false);
            this.summonerInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.riotAPIViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.championsBindingSource)).EndInit();
            this.accountInfoGroupBox.ResumeLayout(false);
            this.accountInfoGroupBox.PerformLayout();
            this.masteryStatsGroupBox.ResumeLayout(false);
            this.masteryStatsGroupBox.PerformLayout();
            this.matchInfoGroupBox.ResumeLayout(false);
            this.matchInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentMatchInfoBindingSource)).EndInit();
            this.championMasteryGroupBox.ResumeLayout(false);
            this.championMasteryGroupBox.PerformLayout();
            this.matchesGroupBox.ResumeLayout(false);
            this.matchesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox summonerSearchTextBox;
        private System.Windows.Forms.Label searchSummonerNameLabel;
        private System.Windows.Forms.GroupBox summonerInfoGroupBox;
        private System.Windows.Forms.TextBox puuIDTextBox;
        private System.Windows.Forms.Label puuIDLabel;
        private System.Windows.Forms.TextBox accountIDTextBox;
        private System.Windows.Forms.Label accountIDLabel;
        private System.Windows.Forms.TextBox summonerLevelTextBox;
        private System.Windows.Forms.Label summonerLevelLabel;
        private System.Windows.Forms.TextBox summonerNameTextBox;
        private System.Windows.Forms.Label summonerNameLabel;
        private System.Windows.Forms.Button summonerSearchButton;
        private System.Windows.Forms.BindingSource riotAPIViewModelBindingSource;
        private System.Windows.Forms.GroupBox accountInfoGroupBox;
        private System.Windows.Forms.BindingSource championsBindingSource;
        private System.Windows.Forms.Label championsLabel;
        private System.Windows.Forms.ListBox championMasteriesListBox;
        private System.Windows.Forms.GroupBox masteryStatsGroupBox;
        private System.Windows.Forms.TextBox championPointsTextBox;
        private System.Windows.Forms.Label championPointsLabel;
        private System.Windows.Forms.TextBox championLevelTextBox;
        private System.Windows.Forms.Label championLevelLabel;
        private System.Windows.Forms.TextBox pointsToLevelTextBox;
        private System.Windows.Forms.Label pointsToLevelLabel;
        private System.Windows.Forms.TextBox tokensEarnedTextBox;
        private System.Windows.Forms.Label tokensEarnedLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label chestGrantedLabel;
        private System.Windows.Forms.Label lastTenMatchesLabel;
        private System.Windows.Forms.GroupBox matchInfoGroupBox;
        private System.Windows.Forms.ListBox matchesListBox;
        private System.Windows.Forms.Label riotAPIKeyLabel;
        private System.Windows.Forms.TextBox riotAPIKeyTextBox;
        private System.Windows.Forms.BindingSource currentMatchInfoBindingSource;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox championMasteryGroupBox;
        private System.Windows.Forms.GroupBox matchesGroupBox;
    }
}

