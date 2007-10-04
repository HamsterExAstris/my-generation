using System;
using System.Xml;
using System.IO;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;
using System.Text;

//using ADODB;
//using MSDASC;

using MyMeta;
using WeifenLuo.WinFormsUI.Docking;

namespace MyGeneration.Forms
{
	/// <summary>
	/// Summary description for DefaultProperties.
	/// </summary>
    public class ErrorDetail : DockContent, IMyGenDocument
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
        private System.ComponentModel.Container components = null;
        private ErrorDetailControl errorDetailControl;
        private IMyGenerationMDI mdi;

        public ErrorDetail(IMyGenerationMDI mdi)
		{
			InitializeComponent();

            this.mdi = mdi;
            this.errorDetailControl.Initialize();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorDetail));
            this.errorDetailControl = new MyGeneration.Forms.ErrorDetailControl();
            this.SuspendLayout();
            // 
            // errorDetailControl
            // 
            this.errorDetailControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.errorDetailControl.Location = new System.Drawing.Point(-2, 1);
            this.errorDetailControl.Name = "errorDetailControl";
            this.errorDetailControl.Size = new System.Drawing.Size(901, 606);
            this.errorDetailControl.TabIndex = 40;
            // 
            // ErrorDetail
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(590, 531);
            this.ClientSize = new System.Drawing.Size(896, 603);
            this.Controls.Add(this.errorDetailControl);
            this.DockAreas = WeifenLuo.WinFormsUI.Docking.DockAreas.Document;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TabText = "Error Details";
            this.Text = "Error Details";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ErrorDetail_Closing);
            this.Load += new System.EventHandler(this.ErrorDetail_Load);
            this.ResumeLayout(false);

		}
		#endregion

        private void ErrorDetail_Load(object sender, EventArgs e)
        {
            //this.errorDetailControl.Populate();
        }

        private void ErrorDetail_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*DialogResult r = DialogResult.None;

            // Something's Changed since the load...
            if (defaultSettingsControl.SettingsModified)
            {
                r = MessageBox.Show("Default settings have changed.\r\n Would you like to save before exiting?", "Default Settings Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }
            else if (defaultSettingsControl.ConnectionInfoModified)
            {
                r = MessageBox.Show("The loaded connection profile has changed.\r\n Would you like to save before exiting?", "Connection Profile Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            }

            if (r != DialogResult.None)
            {
                if (r == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (r == DialogResult.Yes)
                {
                    if (defaultSettingsControl.Save())
                    {
                        this.DialogResult = DialogResult.OK;
                        mdi.SendAlert(this, "UpdateDefaultSettings");
                    }
                }
                else
                {
                    defaultSettingsControl.Cancel();
                    this.DialogResult = DialogResult.Cancel;
                }
            }*/
        }

        #region IMyGenDocument Members

        public ToolStrip ToolStrip
        {
            get { return null; }
        }

        public string DocumentIndentity
        {
            get { return "::ErrorDetail::"; }
        }

        public void ProcessAlert(IMyGenContent sender, string command, params object[] args)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        public bool CanClose(bool allowPrevent)
        {
            return true;
        }

        public DockContent DockContent
        {
            get { return this; }
        }

        public string TextContent
        {
            get { return this.errorDetailControl.TextContent; }
        }

        #endregion
    }
}
