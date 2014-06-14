﻿namespace EpisodeManager_WinForms
{
    partial class LocalEpisodesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.localEpisodesListview = new System.Windows.Forms.ListView();
            this.Episode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.epInfoPanel = new System.Windows.Forms.Panel();
            this.serverStatusOffPb = new System.Windows.Forms.PictureBox();
            this.serverStatusOnPb = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.iconPicture = new System.Windows.Forms.PictureBox();
            this.iconFrame = new System.Windows.Forms.PictureBox();
            this.viewFilesButton = new MetroFramework.Controls.MetroButton();
            this.forumTopicButton = new MetroFramework.Controls.MetroButton();
            this.ss4 = new System.Windows.Forms.PictureBox();
            this.ss3 = new System.Windows.Forms.PictureBox();
            this.ss2 = new System.Windows.Forms.PictureBox();
            this.ss1 = new System.Windows.Forms.PictureBox();
            this.authorName = new MetroFramework.Controls.MetroLabel();
            this.episodeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.epInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusOffPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusOnPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).BeginInit();
            this.SuspendLayout();
            // 
            // localEpisodesListview
            // 
            this.localEpisodesListview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.localEpisodesListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Episode});
            this.localEpisodesListview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localEpisodesListview.FullRowSelect = true;
            this.localEpisodesListview.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.localEpisodesListview.Location = new System.Drawing.Point(0, 0);
            this.localEpisodesListview.MultiSelect = false;
            this.localEpisodesListview.Name = "localEpisodesListview";
            this.localEpisodesListview.Size = new System.Drawing.Size(222, 466);
            this.localEpisodesListview.TabIndex = 4;
            this.localEpisodesListview.UseCompatibleStateImageBehavior = false;
            this.localEpisodesListview.View = System.Windows.Forms.View.Details;
            this.localEpisodesListview.SelectedIndexChanged += new System.EventHandler(this.localEpisodesListview_SelectedIndexChanged);
            // 
            // Episode
            // 
            this.Episode.Text = "Episode";
            this.Episode.Width = 220;
            // 
            // epInfoPanel
            // 
            this.epInfoPanel.BackColor = System.Drawing.Color.White;
            this.epInfoPanel.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.episodeInfoControlsbgo;
            this.epInfoPanel.Controls.Add(this.serverStatusOffPb);
            this.epInfoPanel.Controls.Add(this.serverStatusOnPb);
            this.epInfoPanel.Controls.Add(this.metroLabel1);
            this.epInfoPanel.Controls.Add(this.iconPicture);
            this.epInfoPanel.Controls.Add(this.iconFrame);
            this.epInfoPanel.Controls.Add(this.viewFilesButton);
            this.epInfoPanel.Controls.Add(this.forumTopicButton);
            this.epInfoPanel.Controls.Add(this.ss4);
            this.epInfoPanel.Controls.Add(this.ss3);
            this.epInfoPanel.Controls.Add(this.ss2);
            this.epInfoPanel.Controls.Add(this.ss1);
            this.epInfoPanel.Controls.Add(this.authorName);
            this.epInfoPanel.Controls.Add(this.episodeNameLabel);
            this.epInfoPanel.Controls.Add(this.descriptionLabel);
            this.epInfoPanel.Location = new System.Drawing.Point(200, 0);
            this.epInfoPanel.Name = "epInfoPanel";
            this.epInfoPanel.Size = new System.Drawing.Size(516, 466);
            this.epInfoPanel.TabIndex = 5;
            // 
            // serverStatusOffPb
            // 
            this.serverStatusOffPb.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusOffPb.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.cancel_32;
            this.serverStatusOffPb.Location = new System.Drawing.Point(365, 411);
            this.serverStatusOffPb.Name = "serverStatusOffPb";
            this.serverStatusOffPb.Size = new System.Drawing.Size(32, 32);
            this.serverStatusOffPb.TabIndex = 14;
            this.serverStatusOffPb.TabStop = false;
            this.serverStatusOffPb.Visible = false;
            // 
            // serverStatusOnPb
            // 
            this.serverStatusOnPb.BackColor = System.Drawing.Color.Transparent;
            this.serverStatusOnPb.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.ok_32;
            this.serverStatusOnPb.Location = new System.Drawing.Point(365, 411);
            this.serverStatusOnPb.Name = "serverStatusOnPb";
            this.serverStatusOnPb.Size = new System.Drawing.Size(32, 32);
            this.serverStatusOnPb.TabIndex = 13;
            this.serverStatusOnPb.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.CustomForeColor = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(273, 418);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Server Status: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // iconPicture
            // 
            this.iconPicture.Location = new System.Drawing.Point(212, 189);
            this.iconPicture.Name = "iconPicture";
            this.iconPicture.Size = new System.Drawing.Size(112, 100);
            this.iconPicture.TabIndex = 11;
            this.iconPicture.TabStop = false;
            // 
            // iconFrame
            // 
            this.iconFrame.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.Frame;
            this.iconFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconFrame.Location = new System.Drawing.Point(204, 181);
            this.iconFrame.Name = "iconFrame";
            this.iconFrame.Size = new System.Drawing.Size(128, 116);
            this.iconFrame.TabIndex = 10;
            this.iconFrame.TabStop = false;
            // 
            // viewFilesButton
            // 
            this.viewFilesButton.Highlight = false;
            this.viewFilesButton.Location = new System.Drawing.Point(155, 400);
            this.viewFilesButton.Name = "viewFilesButton";
            this.viewFilesButton.Size = new System.Drawing.Size(112, 52);
            this.viewFilesButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.viewFilesButton.StyleManager = null;
            this.viewFilesButton.TabIndex = 9;
            this.viewFilesButton.Text = "VIEW FILES";
            this.viewFilesButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.viewFilesButton.Click += new System.EventHandler(this.viewFilesButton_Click);
            // 
            // forumTopicButton
            // 
            this.forumTopicButton.Highlight = false;
            this.forumTopicButton.Location = new System.Drawing.Point(37, 400);
            this.forumTopicButton.Name = "forumTopicButton";
            this.forumTopicButton.Size = new System.Drawing.Size(112, 52);
            this.forumTopicButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.forumTopicButton.StyleManager = null;
            this.forumTopicButton.TabIndex = 7;
            this.forumTopicButton.Text = "VISIT FORUM TOPIC";
            this.forumTopicButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.forumTopicButton.Click += new System.EventHandler(this.forumTopicButton_Click);
            // 
            // ss4
            // 
            this.ss4.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ss4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss4.Location = new System.Drawing.Point(391, 304);
            this.ss4.Name = "ss4";
            this.ss4.Size = new System.Drawing.Size(112, 90);
            this.ss4.TabIndex = 6;
            this.ss4.TabStop = false;
            this.ss4.Click += new System.EventHandler(this.ss4_Click);
            // 
            // ss3
            // 
            this.ss3.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ss3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss3.Location = new System.Drawing.Point(273, 304);
            this.ss3.Name = "ss3";
            this.ss3.Size = new System.Drawing.Size(112, 90);
            this.ss3.TabIndex = 5;
            this.ss3.TabStop = false;
            this.ss3.Click += new System.EventHandler(this.ss3_Click);
            // 
            // ss2
            // 
            this.ss2.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ss2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss2.Location = new System.Drawing.Point(155, 304);
            this.ss2.Name = "ss2";
            this.ss2.Size = new System.Drawing.Size(112, 90);
            this.ss2.TabIndex = 4;
            this.ss2.TabStop = false;
            this.ss2.Click += new System.EventHandler(this.ss2_Click);
            // 
            // ss1
            // 
            this.ss1.BackgroundImage = global::EpisodeManager_WinForms.Properties.Resources.noimg;
            this.ss1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ss1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ss1.Location = new System.Drawing.Point(37, 304);
            this.ss1.Name = "ss1";
            this.ss1.Size = new System.Drawing.Size(112, 90);
            this.ss1.TabIndex = 3;
            this.ss1.TabStop = false;
            this.ss1.Click += new System.EventHandler(this.ss1_Click);
            // 
            // authorName
            // 
            this.authorName.CustomBackground = false;
            this.authorName.CustomForeColor = false;
            this.authorName.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.authorName.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.authorName.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.authorName.Location = new System.Drawing.Point(34, 44);
            this.authorName.Name = "authorName";
            this.authorName.Size = new System.Drawing.Size(466, 20);
            this.authorName.Style = MetroFramework.MetroColorStyle.Blue;
            this.authorName.StyleManager = null;
            this.authorName.TabIndex = 1;
            this.authorName.Text = "by: ";
            this.authorName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.authorName.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authorName.UseStyleColors = false;
            // 
            // episodeNameLabel
            // 
            this.episodeNameLabel.CustomBackground = false;
            this.episodeNameLabel.CustomForeColor = false;
            this.episodeNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.episodeNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.episodeNameLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.episodeNameLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.episodeNameLabel.Location = new System.Drawing.Point(34, 10);
            this.episodeNameLabel.Name = "episodeNameLabel";
            this.episodeNameLabel.Size = new System.Drawing.Size(469, 25);
            this.episodeNameLabel.Style = MetroFramework.MetroColorStyle.Purple;
            this.episodeNameLabel.StyleManager = null;
            this.episodeNameLabel.TabIndex = 0;
            this.episodeNameLabel.Text = "episodeName";
            this.episodeNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.episodeNameLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.episodeNameLabel.UseStyleColors = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.CustomBackground = false;
            this.descriptionLabel.CustomForeColor = false;
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.descriptionLabel.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.descriptionLabel.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.descriptionLabel.Location = new System.Drawing.Point(34, 73);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(466, 102);
            this.descriptionLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionLabel.StyleManager = null;
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "desc";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.descriptionLabel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionLabel.UseStyleColors = false;
            // 
            // LocalEpisodesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.localEpisodesListview);
            this.Controls.Add(this.epInfoPanel);
            this.Name = "LocalEpisodesControl";
            this.Size = new System.Drawing.Size(719, 466);
            this.Load += new System.EventHandler(this.LocalEpisodesControl_Load);
            this.epInfoPanel.ResumeLayout(false);
            this.epInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusOffPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverStatusOnPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ss1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Episode;
        public System.Windows.Forms.PictureBox iconPicture;
        public MetroFramework.Controls.MetroButton viewFilesButton;
        public MetroFramework.Controls.MetroButton forumTopicButton;
        public System.Windows.Forms.PictureBox ss4;
        public System.Windows.Forms.PictureBox ss3;
        public System.Windows.Forms.PictureBox ss2;
        public System.Windows.Forms.PictureBox ss1;
        public MetroFramework.Controls.MetroLabel descriptionLabel;
        public MetroFramework.Controls.MetroLabel authorName;
        public MetroFramework.Controls.MetroLabel episodeNameLabel;
        public System.Windows.Forms.Panel epInfoPanel;
        public System.Windows.Forms.PictureBox iconFrame;
        public System.Windows.Forms.ListView localEpisodesListview;
        private System.Windows.Forms.PictureBox serverStatusOnPb;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox serverStatusOffPb;
    }
}
