using System;
using System.Windows.Forms;
using System.IO;

namespace Psychology_Link_Provider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] URL = new string[6];
        int buttonsClicked = 0;
        int Def, MSCS;
        int currentPage = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //for confidentality concerns, all links redirect to the git repository to prevent any abuse of the links used for actual study
            URL[0] = "https://github.com/modernNeo/psycLinks"; 
            URL[1] = "https://github.com/modernNeo/psycLinks"; 
            URL[2] = "https://github.com/modernNeo/psycLinks";
            URL[3] = "https://github.com/modernNeo/psycLinks"; 
            URL[4] = "https://github.com/modernNeo/psycLinks";
            URL[5] = "https://github.com/modernNeo/psycLinks";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool passed = true;
            labelErrors.Text = "";
            int garbage;
            labelID.Text = txtBoxID.Text;
            if (!int.TryParse(txtBoxMSCS.Text, out MSCS) || MSCS < 1 || MSCS > 2)
            {
                passed = false;
                labelErrors.Text = "Incorrect Input for MSCS\n";

            }

            if (!int.TryParse(txtBoxDef.Text, out Def) || Def < 1 || Def > 2)
            {
                passed = false;
                labelErrors.Text += "Incorrect Input for Def";
            }
            if (txtBoxID.Text.Length != 17)
            {
                passed = false;
                labelErrors.Text += "Incorrect Input for Lab ID";
                System.Diagnostics.Debug.WriteLine(1);

            }
            else
            {
                for (int i = 0; i < 17; i++)
                {
                    if ((i < 4 && i > -1) || (i == 5 || i == 6) || (i == 8 || i == 9) || (i > 10))
                    {
                        if (!int.TryParse(txtBoxID.Text[i].ToString(), out garbage))
                        {
                            passed = false;
                            labelErrors.Text += "Incorrect Input for Lab ID";
                            System.Diagnostics.Debug.WriteLine("2" + i);

                        }
                    }
                    else
                    {
                        if (txtBoxID.Text[i].ToString() != ".")
                        {
                            passed = false;
                            labelErrors.Text += "Incorrect Input for Lab ID";
                            System.Diagnostics.Debug.WriteLine(3);

                        }
                    }
                }
            }
            if (passed == true)
            {
                if (MSCS == 1)
                {
                    buttonSecondLink.Text = "Second Link - MSCS";
                    buttonThirdLink.Text = "Third Link - What is SC?";
                }
                else
                {
                    buttonSecondLink.Text = "Second Link - What is SC?";
                    buttonThirdLink.Text = "Third Link - MSCS";
                }
                txtBoxID.Visible = false;
                txtBoxDef.Visible = false;
                txtBoxMSCS.Visible = false;
                btnSubmit.Visible = false;
                labelDefinition.Visible = false;
                labelMSCS.Visible = false;
                labelLabID.Visible = false;

                buttonFirstLink.Visible = true;
                buttonSecondLink.Visible = true;
                buttonThirdLink.Visible = true;
                buttonFourthLink.Visible = true;
                buttonFifthLink.Visible = true;
                labelID.Visible = true;
                doneButton.Visible = true;
                doneButton.Enabled = false;
                buttonDebriefing.Visible = true;
            }
        }

        private void buttonFirstLink_Click(object sender, EventArgs e)
        {
            buttonsClicked++;
            System.Diagnostics.Process.Start(URL[currentPage]);
            buttonFirstLink.Enabled = false;
            if (buttonsClicked == 6)
            {
                doneButton.Enabled = true;
            }
        }

        private void buttonSecondLink_Click(object sender, EventArgs e)
        {
            buttonsClicked++;
            if (MSCS == 1)
            {
                currentPage = 3;
            }
            else
            {
                if (Def == 1)
                {
                    currentPage = 1;
                }
                else
                {
                    currentPage = 2;
                }
            }
            System.Diagnostics.Process.Start(URL[currentPage]);
            buttonSecondLink.Enabled = false;
            if (buttonsClicked == 6)
            {
                doneButton.Enabled = true;
            }
        }

        private void buttonThirdLink_Click(object sender, EventArgs e)
        {
            buttonsClicked++;
            if (MSCS == 2)
            {
                currentPage = 3;
            }
            else
            {
                if (Def == 1)
                {
                    currentPage = 1;
                }
                else
                {
                    currentPage = 2;
                }
            }
            System.Diagnostics.Process.Start(URL[currentPage]);
            currentPage=4;
            buttonThirdLink.Enabled = false;
            if (buttonsClicked == 6)
            {
                doneButton.Enabled = true;
            }
        }

        private void buttonFourthLink_Click(object sender, EventArgs e)
        {
            buttonsClicked++;
            System.Diagnostics.Process.Start(URL[currentPage]);
            currentPage++;
            buttonFourthLink.Enabled = false;
            if (buttonsClicked == 6)
            {
                doneButton.Enabled = true;
            }
        }

        private void buttonFifthLink_Click(object sender, EventArgs e)
        {
            buttonsClicked++;
            System.Diagnostics.Process.Start(URL[currentPage]);
            currentPage++;
            buttonFifthLink.Enabled = false;
            if (buttonsClicked == 6)
            {
                doneButton.Enabled = true;
            }
        }

        private void buttonDebriefing_Click(object sender, EventArgs e)
        {
            buttonsClicked++;
            buttonDebriefing.Enabled = false;
            if (buttonsClicked == 6)
            {
                doneButton.Enabled = true;
            }

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            // Specify a name for your top-level folder. 
            string pwd = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string pathString = System.IO.Path.Combine(pwd, "MSCSFolder");


            String filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/MSCSFolder/";

            String fileName = "file.csv";

            string header = "Lab ID,Consent,Definition (1=N 2=Y), 1=MSCS 1st 2=MSCS 2nd, Direct questions, Demographics, Debriefing" + Environment.NewLine;



            if (!File.Exists(filePath + fileName))
            {
                System.IO.Directory.CreateDirectory(pathString);
                System.IO.File.WriteAllText(filePath + fileName, header);

                //create folder
                //add header to file
            }
            string appendText = labelID.Text + ",X," + Def + "," + MSCS + ",X,X,X" + Environment.NewLine;
            File.AppendAllText(filePath + fileName, appendText);
            labelErrors.Text = "Output saved to: " + filePath + fileName;
            txtBoxID.Text = "";
            txtBoxMSCS.Text = "";
            txtBoxDef.Text = "";
            txtBoxID.Visible = true;
            txtBoxDef.Visible = true;
            txtBoxMSCS.Visible = true;
            btnSubmit.Visible = true;
            labelDefinition.Visible = true;
            labelMSCS.Visible = true;
            labelLabID.Visible = true;

            buttonDebriefing.Visible = false;
            buttonFirstLink.Visible = false;
            buttonSecondLink.Visible = false;
            buttonThirdLink.Visible = false;
            buttonFourthLink.Visible = false;
            buttonFifthLink.Visible = false;
            labelID.Visible = false;
            doneButton.Visible = false;

        }

    }
}
