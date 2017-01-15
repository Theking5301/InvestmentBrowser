namespace InvestmentBrowser
{
    partial class WebBrowserPanel
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
            this.BaseTable = new System.Windows.Forms.TableLayoutPanel();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.TopContainer = new System.Windows.Forms.SplitContainer();
            this.NavigationTable = new System.Windows.Forms.TableLayoutPanel();
            this.NavBar = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ForwardButton = new System.Windows.Forms.Button();
            this.NavigateButton = new System.Windows.Forms.Button();
            this.TopBottomContainer = new System.Windows.Forms.SplitContainer();
            this.HidePauseContainer = new System.Windows.Forms.SplitContainer();
            this.CollapseButton = new System.Windows.Forms.Button();
            this.PauseCheckbox = new System.Windows.Forms.CheckBox();
            this.TimerContainer = new System.Windows.Forms.SplitContainer();
            this.RefreshTimerBox = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.BaseTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopContainer)).BeginInit();
            this.TopContainer.Panel1.SuspendLayout();
            this.TopContainer.Panel2.SuspendLayout();
            this.TopContainer.SuspendLayout();
            this.NavigationTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopBottomContainer)).BeginInit();
            this.TopBottomContainer.Panel1.SuspendLayout();
            this.TopBottomContainer.Panel2.SuspendLayout();
            this.TopBottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePauseContainer)).BeginInit();
            this.HidePauseContainer.Panel1.SuspendLayout();
            this.HidePauseContainer.Panel2.SuspendLayout();
            this.HidePauseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerContainer)).BeginInit();
            this.TimerContainer.Panel1.SuspendLayout();
            this.TimerContainer.Panel2.SuspendLayout();
            this.TimerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseTable
            // 
            this.BaseTable.BackColor = System.Drawing.Color.LightBlue;
            this.BaseTable.ColumnCount = 1;
            this.BaseTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseTable.Controls.Add(this.WebBrowser, 0, 1);
            this.BaseTable.Controls.Add(this.TopContainer, 0, 0);
            this.BaseTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BaseTable.Location = new System.Drawing.Point(0, 0);
            this.BaseTable.Margin = new System.Windows.Forms.Padding(0);
            this.BaseTable.Name = "BaseTable";
            this.BaseTable.RowCount = 2;
            this.BaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.BaseTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseTable.Size = new System.Drawing.Size(314, 760);
            this.BaseTable.TabIndex = 0;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(0, 60);
            this.WebBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.ScriptErrorsSuppressed = true;
            this.WebBrowser.Size = new System.Drawing.Size(314, 700);
            this.WebBrowser.TabIndex = 0;
            this.WebBrowser.TabStop = false;
            this.WebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser_DocumentCompleted);
            // 
            // TopContainer
            // 
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContainer.Location = new System.Drawing.Point(10, 5);
            this.TopContainer.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TopContainer.Panel1
            // 
            this.TopContainer.Panel1.Controls.Add(this.NavigationTable);
            this.TopContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // TopContainer.Panel2
            // 
            this.TopContainer.Panel2.Controls.Add(this.TopBottomContainer);
            this.TopContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopContainer.Size = new System.Drawing.Size(294, 55);
            this.TopContainer.SplitterDistance = 25;
            this.TopContainer.TabIndex = 1;
            // 
            // NavigationTable
            // 
            this.NavigationTable.ColumnCount = 4;
            this.NavigationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.NavigationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.NavigationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.NavigationTable.Controls.Add(this.NavBar, 2, 0);
            this.NavigationTable.Controls.Add(this.BackButton, 3, 0);
            this.NavigationTable.Controls.Add(this.ForwardButton, 0, 0);
            this.NavigationTable.Controls.Add(this.NavigateButton, 1, 0);
            this.NavigationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigationTable.Location = new System.Drawing.Point(0, 0);
            this.NavigationTable.Name = "NavigationTable";
            this.NavigationTable.RowCount = 1;
            this.NavigationTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.NavigationTable.Size = new System.Drawing.Size(294, 25);
            this.NavigationTable.TabIndex = 0;
            // 
            // NavBar
            // 
            this.NavBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavBar.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavBar.Location = new System.Drawing.Point(33, 3);
            this.NavBar.Name = "NavBar";
            this.NavBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NavBar.Size = new System.Drawing.Size(188, 21);
            this.NavBar.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.BackgroundImage = global::InvestmentBrowser.Properties.Resources.blue_sliderLeft;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(0, 3);
            this.BackButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(30, 22);
            this.BackButton.TabIndex = 1;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.BackColor = System.Drawing.Color.Transparent;
            this.ForwardButton.BackgroundImage = global::InvestmentBrowser.Properties.Resources.blue_sliderRight;
            this.ForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ForwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForwardButton.FlatAppearance.BorderSize = 0;
            this.ForwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwardButton.ForeColor = System.Drawing.Color.Transparent;
            this.ForwardButton.Location = new System.Drawing.Point(264, 3);
            this.ForwardButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(30, 22);
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.UseVisualStyleBackColor = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // NavigateButton
            // 
            this.NavigateButton.BackgroundImage = global::InvestmentBrowser.Properties.Resources.green_checkmark;
            this.NavigateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NavigateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavigateButton.FlatAppearance.BorderSize = 0;
            this.NavigateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NavigateButton.Font = new System.Drawing.Font("Helvetica", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavigateButton.ForeColor = System.Drawing.Color.White;
            this.NavigateButton.Location = new System.Drawing.Point(224, 0);
            this.NavigateButton.Margin = new System.Windows.Forms.Padding(0);
            this.NavigateButton.Name = "NavigateButton";
            this.NavigateButton.Size = new System.Drawing.Size(40, 25);
            this.NavigateButton.TabIndex = 3;
            this.NavigateButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NavigateButton.UseVisualStyleBackColor = true;
            this.NavigateButton.Click += new System.EventHandler(this.NavigateButton_Click);
            // 
            // TopBottomContainer
            // 
            this.TopBottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopBottomContainer.Location = new System.Drawing.Point(0, 0);
            this.TopBottomContainer.Name = "TopBottomContainer";
            // 
            // TopBottomContainer.Panel1
            // 
            this.TopBottomContainer.Panel1.Controls.Add(this.HidePauseContainer);
            this.TopBottomContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TopBottomContainer.Panel1MinSize = 60;
            // 
            // TopBottomContainer.Panel2
            // 
            this.TopBottomContainer.Panel2.Controls.Add(this.TimerContainer);
            this.TopBottomContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TopBottomContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TopBottomContainer.Size = new System.Drawing.Size(294, 26);
            this.TopBottomContainer.SplitterDistance = 97;
            this.TopBottomContainer.TabIndex = 0;
            // 
            // HidePauseContainer
            // 
            this.HidePauseContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HidePauseContainer.Location = new System.Drawing.Point(0, 0);
            this.HidePauseContainer.Name = "HidePauseContainer";
            // 
            // HidePauseContainer.Panel1
            // 
            this.HidePauseContainer.Panel1.Controls.Add(this.CollapseButton);
            // 
            // HidePauseContainer.Panel2
            // 
            this.HidePauseContainer.Panel2.Controls.Add(this.PauseCheckbox);
            this.HidePauseContainer.Size = new System.Drawing.Size(97, 26);
            this.HidePauseContainer.SplitterDistance = 25;
            this.HidePauseContainer.TabIndex = 0;
            // 
            // CollapseButton
            // 
            this.CollapseButton.BackColor = System.Drawing.Color.Transparent;
            this.CollapseButton.BackgroundImage = global::InvestmentBrowser.Properties.Resources.red_cross;
            this.CollapseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CollapseButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CollapseButton.FlatAppearance.BorderSize = 0;
            this.CollapseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CollapseButton.Location = new System.Drawing.Point(0, 0);
            this.CollapseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CollapseButton.MaximumSize = new System.Drawing.Size(20, 0);
            this.CollapseButton.MinimumSize = new System.Drawing.Size(20, 0);
            this.CollapseButton.Name = "CollapseButton";
            this.CollapseButton.Size = new System.Drawing.Size(20, 26);
            this.CollapseButton.TabIndex = 0;
            this.CollapseButton.UseVisualStyleBackColor = false;
            this.CollapseButton.Click += new System.EventHandler(this.CollapseButton_Click);
            // 
            // PauseCheckbox
            // 
            this.PauseCheckbox.AutoSize = true;
            this.PauseCheckbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseCheckbox.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseCheckbox.Location = new System.Drawing.Point(0, 0);
            this.PauseCheckbox.MaximumSize = new System.Drawing.Size(70, 0);
            this.PauseCheckbox.MinimumSize = new System.Drawing.Size(70, 0);
            this.PauseCheckbox.Name = "PauseCheckbox";
            this.PauseCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PauseCheckbox.Size = new System.Drawing.Size(70, 26);
            this.PauseCheckbox.TabIndex = 2;
            this.PauseCheckbox.Text = "Pause";
            this.PauseCheckbox.UseVisualStyleBackColor = true;
            // 
            // TimerContainer
            // 
            this.TimerContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimerContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.TimerContainer.Location = new System.Drawing.Point(0, 0);
            this.TimerContainer.Name = "TimerContainer";
            // 
            // TimerContainer.Panel1
            // 
            this.TimerContainer.Panel1.Controls.Add(this.RefreshTimerBox);
            this.TimerContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // TimerContainer.Panel2
            // 
            this.TimerContainer.Panel2.Controls.Add(this.AcceptButton);
            this.TimerContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimerContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimerContainer.Size = new System.Drawing.Size(193, 26);
            this.TimerContainer.SplitterDistance = 106;
            this.TimerContainer.TabIndex = 0;
            // 
            // RefreshTimerBox
            // 
            this.RefreshTimerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RefreshTimerBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefreshTimerBox.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshTimerBox.Location = new System.Drawing.Point(66, 0);
            this.RefreshTimerBox.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.RefreshTimerBox.MaximumSize = new System.Drawing.Size(40, 20);
            this.RefreshTimerBox.MaxLength = 3;
            this.RefreshTimerBox.MinimumSize = new System.Drawing.Size(40, 20);
            this.RefreshTimerBox.Name = "RefreshTimerBox";
            this.RefreshTimerBox.Size = new System.Drawing.Size(40, 21);
            this.RefreshTimerBox.TabIndex = 0;
            // 
            // AcceptButton
            // 
            this.AcceptButton.BackColor = System.Drawing.Color.Transparent;
            this.AcceptButton.BackgroundImage = global::InvestmentBrowser.Properties.Resources.BlueButton1;
            this.AcceptButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AcceptButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.AcceptButton.FlatAppearance.BorderSize = 0;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.Font = new System.Drawing.Font("Helvetica", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptButton.ForeColor = System.Drawing.Color.White;
            this.AcceptButton.Location = new System.Drawing.Point(3, 0);
            this.AcceptButton.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.AcceptButton.MaximumSize = new System.Drawing.Size(80, 0);
            this.AcceptButton.MinimumSize = new System.Drawing.Size(80, 0);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(80, 26);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // WebBrowserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.BaseTable);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WebBrowserPanel";
            this.Size = new System.Drawing.Size(314, 760);
            this.BaseTable.ResumeLayout(false);
            this.TopContainer.Panel1.ResumeLayout(false);
            this.TopContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopContainer)).EndInit();
            this.TopContainer.ResumeLayout(false);
            this.NavigationTable.ResumeLayout(false);
            this.NavigationTable.PerformLayout();
            this.TopBottomContainer.Panel1.ResumeLayout(false);
            this.TopBottomContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopBottomContainer)).EndInit();
            this.TopBottomContainer.ResumeLayout(false);
            this.HidePauseContainer.Panel1.ResumeLayout(false);
            this.HidePauseContainer.Panel2.ResumeLayout(false);
            this.HidePauseContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HidePauseContainer)).EndInit();
            this.HidePauseContainer.ResumeLayout(false);
            this.TimerContainer.Panel1.ResumeLayout(false);
            this.TimerContainer.Panel1.PerformLayout();
            this.TimerContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimerContainer)).EndInit();
            this.TimerContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BaseTable;
        private System.Windows.Forms.SplitContainer TopContainer;
        private System.Windows.Forms.SplitContainer TopBottomContainer;
        private System.Windows.Forms.SplitContainer TimerContainer;
        private System.Windows.Forms.Button AcceptButton;
        public System.Windows.Forms.TextBox RefreshTimerBox;
        private System.Windows.Forms.TableLayoutPanel NavigationTable;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ForwardButton;
        private System.Windows.Forms.Button NavigateButton;
        private System.Windows.Forms.SplitContainer HidePauseContainer;
        private System.Windows.Forms.Button CollapseButton;
        private System.Windows.Forms.CheckBox PauseCheckbox;
        public System.Windows.Forms.WebBrowser WebBrowser;
        public System.Windows.Forms.TextBox NavBar;
    }
}
