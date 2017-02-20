using System.Windows.Forms;

namespace TSZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tehenGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ujTehen = new System.Windows.Forms.Button();
            this.tehenDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tehenGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tehenDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tehenGridView
            // 
            this.tehenGridView.AllowUserToAddRows = false;
            this.tehenGridView.AllowUserToDeleteRows = false;
            this.tehenGridView.AllowUserToOrderColumns = true;
            this.tehenGridView.AllowUserToResizeRows = false;
            this.tehenGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tehenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tehenGridView.Location = new System.Drawing.Point(12, 124);
            this.tehenGridView.Name = "tehenGridView";
            this.tehenGridView.ReadOnly = true;
            this.tehenGridView.Size = new System.Drawing.Size(677, 315);
            this.tehenGridView.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.megnyitásToolStripMenuItem});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menü";
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // ujTehen
            // 
            this.ujTehen.BackColor = System.Drawing.Color.SpringGreen;
            this.ujTehen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ujTehen.Image = global::TSZ.Properties.Resources._01_cow_icon;
            this.ujTehen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ujTehen.Location = new System.Drawing.Point(12, 37);
            this.ujTehen.Name = "ujTehen";
            this.ujTehen.Size = new System.Drawing.Size(148, 64);
            this.ujTehen.TabIndex = 2;
            this.ujTehen.Text = "Új tehén";
            this.ujTehen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ujTehen.UseVisualStyleBackColor = false;
            this.ujTehen.Click += new System.EventHandler(this.ujTehen_Click);
            // 
            // tehenDataBindingSource
            // 
            this.tehenDataBindingSource.DataSource = typeof(TSZ.TehenData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 466);
            this.Controls.Add(this.ujTehen);
            this.Controls.Add(this.tehenGridView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(717, 505);
            this.MinimumSize = new System.Drawing.Size(717, 505);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tehenGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tehenDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tehenGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private new System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource tehenDataBindingSource;
        private System.Windows.Forms.Button ujTehen;

        public DataGridView TehenGridView
        {
            get
            {
                return tehenGridView;
            }

            set
            {
                tehenGridView = value;
            }
        }


    }
}

