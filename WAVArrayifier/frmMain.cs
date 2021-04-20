using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WAVArrayifier
{
    public partial class frmMain : Form
    {
        // List holding the types, set at compile time
        List<string> typeList = new List<string>();
        OpenFileDialog inputFileDialog;
        
        string[] tokens = new string[] { };

        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Define the typelist
            typeList.AddRange(new string[] {"float", "uint8_t", "char", "unsigned char", "string", "uint16_t", "uint32_t", "int", });
            cboInputType.Items.AddRange(typeList.ToArray());
            cboInputType.SelectedIndex = 0;
            cboOutputType.Items.AddRange(typeList.ToArray());
            cboOutputType.SelectedIndex = 0;
        }

        private void CmdLoadInput_Click(object sender, EventArgs e)
        {
            // Instantiate a new openfiledialog to set the input file path
            inputFileDialog = new OpenFileDialog();

            DialogResult result = inputFileDialog.ShowDialog();
            if ((result == DialogResult.Yes)||(result == DialogResult.OK))
            {
                // Further check to make sure file exits
                if (inputFileDialog.CheckFileExists == true)
                {
                    //Read the contents of the file into a stream
                    var fileStream = inputFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string input = reader.ReadToEnd();

                        txtInput.Clear();

                        cmdConvert.Enabled = true;

                        txtInput.Text = input;

                        input = input.TrimEnd(new char[] { ' ', '\r', '\n' });

                        // Tokenise the string into individual values
                        tokens = input.Replace("\r\n", " ").Split(' ');

                        txtSampleCount.Text = tokens.Length.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Unable to Locate File");
                    return;
                }
            }
        }

        private void CmdConvert_Click(object sender, EventArgs e)
        {
            List<string> newTokens = new List<string>();

            // First validate the array name for compilation
            if (txtOutputName.Text.Contains(" "))
            {
                MessageBox.Show("Array name cannot contain spaces");
                return;
            }

            if (cboInputType.SelectedIndex != cboOutputType.SelectedIndex)
            {
                // we need to do some conversion

                // Converting to an unsigned char with limits of 255
                if ((cboOutputType.SelectedIndex == 1) || (cboOutputType.SelectedIndex == 3))
                {
                    for (int cnt = 0; cnt < tokens.Length; cnt++)
                    {
                        double t = Convert.ToDouble(tokens[cnt]);
                        t = (t * 127) + 127;
                        newTokens.Add(Convert.ToByte(t).ToString());
                    }
                }
            }
            else
            {
                    foreach (string s in tokens)
                        newTokens.Add(s);
            }


                

            // Seconly convert and turn the tokens into array samples
            cmdConvert.Enabled = false;
            cmdReset.Enabled = true;

            gbTo.Enabled = true;

            List<char> outputChars = new List<char>();

            // Define it to program memory
            outputChars.AddRange("const ");

            // Set the type
            outputChars.AddRange(cboOutputType.SelectedItem.ToString() + " ");

            outputChars.AddRange(txtOutputName.Text + "[] = \r\n{\r\n");

            int lineCnt = 0;
            for (int cnt = 0; cnt < newTokens.Count - 1; cnt++)
            {
                string token = newTokens[cnt] + ", ";
                outputChars.AddRange(token);
                lineCnt += token.Length;

                if ((lineCnt > 80) && (cnt < (newTokens.Count - 1)))
                {
                    lineCnt = 0;
                    outputChars.AddRange("\r\n");
                }
            }

            outputChars.AddRange(newTokens[newTokens.Count-1]);

            if (lineCnt != 0)
            {
                outputChars.AddRange("\r\n");
            }

            outputChars.AddRange("};");

            txtOutput.Text = new string (outputChars.ToArray());
        }

        private void CmdReset_Click(object sender, EventArgs e)
        {
            List<string> typeList = new List<string>();
            inputFileDialog = new OpenFileDialog();

            string[] tokens = new string[] { };

            txtOutput.Text = "";
            txtInput.Text = "";
            txtSampleCount.Text = "";

            cmdConvert.Enabled = false;
            cmdReset.Enabled = false;

            txtOutputName.Text = "";

            cboInputType.SelectedIndex = 0;
            cboOutputType.SelectedIndex = 0;
        }
    }
}
