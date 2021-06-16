using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using File = System.IO.File;

namespace LnkGen_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGenerate.Location = new Point(223, 242);
            this.Size = new Size(643, 319);
        }

        private void chkArguments_Click(object sender, EventArgs e)
        {
            txtArgs.Visible = chkArguments.Checked == true;
        }
        private void chkDescription_Click(object sender, EventArgs e)
        {
            txtDescription.Visible = chkDescription.Checked == true;
        }

        private void BtnTargetBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog targetDialog = new OpenFileDialog();
            targetDialog.InitialDirectory = @"C:\Windows\System32";
            targetDialog.Title = "Select target executable";
            targetDialog.CheckFileExists = true;
            if (targetDialog.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = targetDialog.FileName;
            }

        }

        private void BtnIconBrowser_Click(object sender, EventArgs e)
        {
            picbox.Visible = true;
            OpenFileDialog iconDialog = new OpenFileDialog();
            if (!Program.expertMode)
            {
                iconDialog.Filter = "icon files (*.ico)|*.ico";
            }
            iconDialog.InitialDirectory = @"C:\";
            iconDialog.DefaultExt = "ico";
            iconDialog.Title = "Select lnk icon";
            iconDialog.CheckFileExists = true;
            if (iconDialog.ShowDialog() == DialogResult.OK)
            {
                txtIcon.Text = iconDialog.FileName;
                try
                {
                    picbox.SizeMode = PictureBoxSizeMode.AutoSize;
                    picbox.Image = Bitmap.FromHicon(new Icon(txtIcon.Text).Handle);
                }
                catch (Exception icoex)
                {
                    picbox.Image = null;
                    picbox.Visible = false;

                }

                //ico doesnt always get drawn correctly so if ico does not get drawn, just dont show the preview.
            }
        }


        private void optionalArgsOK()
        {
            if (chkArguments.Checked)
            {
                if (string.IsNullOrEmpty(txtArgs.Text))
                {
                    throw new Exception("arguments is checked but arguments are empty!");
                }
            }

            if (chkDescription.Checked)
            {
                if (string.IsNullOrEmpty(txtDescription.Text))
                {
                    throw new Exception("description is checked but the description is empty!");
                }
            }
        }
        private void preFlightChecks()
        {
            optionalArgsOK();
            if (!File.Exists(txtTarget.Text))
            {
                throw new Exception("target does not exist!");
            }

            if (!File.Exists(txtIcon.Text))
            {
                throw new Exception("icon does not exist!");
            }

            if (!txtIcon.Text.EndsWith(".ico"))
            {
                throw new Exception("icon needs to be a .ico file");
            }

            //checks if a target and an icon are chosen and checks if the optional values make sense.
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!Program.expertMode)
            {
                try
                {
                    preFlightChecks();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Title = "save your new lnk";
                saveDialog.OverwritePrompt = true;
                saveDialog.ShowDialog();
                if (saveDialog.FileName != "")
                {
                    string fn = saveDialog.FileName;
                    if (!fn.EndsWith(".lnk"))
                    {
                        fn = fn + ".lnk";
                    }

                    string target = "";
                    string arguments = "";
                    string iconpath = @"C:\Windows\System32\SHELL32.dll,0";
                    string description = "";
                    if (txtTarget.Text != "")
                    {
                        target = txtTarget.Text;
                    }

                    if (txtArgs.Text != "")
                    {
                        arguments = txtArgs.Text;
                    }

                    if (txtIcon.Text != "")
                    {
                        iconpath = txtIcon.Text;
                    }

                    if (txtDescription.Text != "")
                    {
                        description = txtDescription.Text;
                    }
                    Program.CreateLnk(fn, target, chkBamboozle.Checked, arguments, iconpath, description);
                    if (cboADFStreams.Items.Count > 0)
                    {
                        Program.AddADS(fn);
                    }
                    MessageBox.Show("Your lnk is generated successfully and saved at:" + fn, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void chkExpertMode_Click(object sender, EventArgs e)
        {

            if (chkExpertMode.Checked)
            {
                Program.expertMode = true;
                this.Size = new Size(643, 429);
                gpbxExpert.Visible = true;
                btnGenerate.Location = new Point(213, 333);
                btnCheckADFS.Location = new Point(213, 360);
                btnCheckADFS.Visible = true;
            }
            else
            {
                Program.expertMode = false;
                this.Size = new Size(643, 319);
                gpbxExpert.Visible = false;
                btnGenerate.Location = new Point(223, 242);
            }

        }

        private void btnADFS_Click(object sender, EventArgs e)
        {
            OpenFileDialog adfsDialog = new OpenFileDialog();
            adfsDialog.InitialDirectory = @"C:\";
            adfsDialog.Title = "Select alternate file steam";
            adfsDialog.CheckFileExists = true;
            if (adfsDialog.ShowDialog() == DialogResult.OK)
            {
                txtADFS.Text = adfsDialog.FileName;
            }
        }

        private void btnAddADFS_Click(object sender, EventArgs e)
        {
            string ADSSource, ADSName;

            if (!File.Exists(txtADFS.Text))
            {
                throw new Exception("ADFS not valid. file does not seem to exists.");
            }
            ADSSource = txtADFS.Text;
            if (txtADSName.Text != "")
            {
                ADSName = txtADSName.Text;
            }
            else
            {
                ADSName = ADSSource;
            }
            Program.alternateDataStreams.Add(ADSName, ADSSource);
            cboADFStreams.Items.Add(ADSName);
            cboADFStreams.Enabled = true;
            txtADSName.Text = String.Empty;
            txtADFS.Text = String.Empty;
        }

        private void btnCheckADFS_Click(object sender, EventArgs e)
        {
            OpenFileDialog adfsDialog = new OpenFileDialog();
            adfsDialog.DereferenceLinks = false;
            adfsDialog.InitialDirectory = @"C:\";
            adfsDialog.Title = "Select alternate file steam";
            adfsDialog.CheckFileExists = true;
            if (adfsDialog.ShowDialog() == DialogResult.OK)
            {
                Dictionary<string, string> adsdict = Program.ListADS(adfsDialog.FileName);
                string ADSOutputString = "";
                if (adsdict.Count > 0)
                {
                    foreach (var item in adsdict)
                    {
                        ADSOutputString += item.Key + "\n";
                    }

                    MessageBox.Show(adfsDialog.FileName + "contains the following Alternate data streams:\n" + ADSOutputString, "ADS Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(adfsDialog.FileName + " does not have any alternate data streams!", "ADS Check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}
