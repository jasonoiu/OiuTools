
namespace OiuTools.Controls
{
    partial class App
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
            this.components = new System.ComponentModel.Container();
            this.AppPanel = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AppPanel)).BeginInit();
            this.AppPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppPanel
            // 
            this.AppPanel.Controls.Add(this.flyoutPanelControl1);
            this.AppPanel.Location = new System.Drawing.Point(0, 0);
            this.AppPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppPanel.Name = "AppPanel";
            this.AppPanel.OptionsButtonPanel.ButtonPanelHeight = 37;
            this.AppPanel.OwnerControl = this;
            this.AppPanel.Size = new System.Drawing.Size(547, 352);
            this.AppPanel.TabIndex = 2;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.AppPanel;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(547, 352);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AppPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "App";
            this.Size = new System.Drawing.Size(547, 352);
            ((System.ComponentModel.ISupportInitialize)(this.AppPanel)).EndInit();
            this.AppPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.FlyoutPanel AppPanel;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}
