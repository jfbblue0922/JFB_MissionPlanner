namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigHWJRE30
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHWJRE30));
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imagebox = new System.Windows.Forms.PictureBox();
            this.CMB_GAIN = new System.Windows.Forms.ComboBox();
            this.BUT_gain = new MissionPlanner.Controls.MyButton();
            this.BUT_datazeroclear = new MissionPlanner.Controls.MyButton();
            this.BUT_datazero = new MissionPlanner.Controls.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // imagebox
            // 
            resources.ApplyResources(this.imagebox, "imagebox");
            this.imagebox.Name = "imagebox";
            this.imagebox.TabStop = false;
            // 
            // CMB_GAIN
            // 
            resources.ApplyResources(this.CMB_GAIN, "CMB_GAIN");
            this.CMB_GAIN.FormattingEnabled = true;
            this.CMB_GAIN.Name = "CMB_GAIN";
            this.CMB_GAIN.SelectedIndexChanged += new System.EventHandler(this.CMB_GAIN_SelectIndexChanged);
            // 
            // BUT_gain
            // 
            resources.ApplyResources(this.BUT_gain, "BUT_gain");
            this.BUT_gain.Name = "BUT_gain";
            this.BUT_gain.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_gain.UseVisualStyleBackColor = true;
            this.BUT_gain.Click += new System.EventHandler(this.BUT_gain_Click);
            // 
            // BUT_datazeroclear
            // 
            resources.ApplyResources(this.BUT_datazeroclear, "BUT_datazeroclear");
            this.BUT_datazeroclear.Name = "BUT_datazeroclear";
            this.BUT_datazeroclear.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_datazeroclear.UseVisualStyleBackColor = true;
            this.BUT_datazeroclear.Click += new System.EventHandler(this.BUT_datazeroclear_Click);
            // 
            // BUT_datazero
            // 
            resources.ApplyResources(this.BUT_datazero, "BUT_datazero");
            this.BUT_datazero.Name = "BUT_datazero";
            this.BUT_datazero.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_datazero.UseVisualStyleBackColor = true;
            this.BUT_datazero.Click += new System.EventHandler(this.BUT_datazero_Click);
            // 
            // ConfigHWJRE30
            // 
            this.Controls.Add(this.CMB_GAIN);
            this.Controls.Add(this.BUT_gain);
            this.Controls.Add(this.BUT_datazeroclear);
            this.Controls.Add(this.BUT_datazero);
            this.Controls.Add(this.imagebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox4);
            this.Name = "ConfigHWJRE30";
            resources.ApplyResources(this, "$this");
            ((System.ComponentModel.ISupportInitialize)(this.imagebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox imagebox;
        private System.Windows.Forms.ComboBox CMB_GAIN;
        private Controls.MyButton BUT_gain;
        private Controls.MyButton BUT_datazeroclear;
        private Controls.MyButton BUT_datazero;
    }
}
