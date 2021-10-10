
namespace OiuTools.Controls
{
    partial class BlegMM
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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pagerControl1 = new OiuTools.Controls.PagerControl();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(4, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1183, 1028);
            this.mainPanel.TabIndex = 0;
            // 
            // pagerControl1
            // 
            this.pagerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pagerControl1.Location = new System.Drawing.Point(4, 1036);
            this.pagerControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageCount = 0;
            this.pagerControl1.PageIndex = 0;
            this.pagerControl1.PageSize = 10;
            this.pagerControl1.RecordCount = ((long)(0));
            this.pagerControl1.Size = new System.Drawing.Size(604, 53);
            this.pagerControl1.TabIndex = 1;
            // 
            // BlegMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagerControl1);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "BlegMM";
            this.Size = new System.Drawing.Size(1191, 1089);
            this.Load += new System.EventHandler(this.BlegMM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private PagerControl pagerControl1;
    }
}
