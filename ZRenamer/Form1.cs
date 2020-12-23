using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace ZRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbRegex.Text = episodeNrPattern;
        }
            

        // Called by Main to set args[0] as inputName
        public void SetInputName(string inputName)
        {
            inputFileName = inputName;
        }

        private void UpdateFoundFiles()
        {
            List<string> foundFiles = new List<string>();
            // Find all episodes in same dir with extensions
            try
            {
                // check so that the file is numerable
                string[] files = Directory.GetFiles(directory);
                foreach (string f in files)
                {
                    foundFiles.Add(f);
                }

                Console.WriteLine("Listing current directory:::::::::::::::::::::::::::");
                Console.WriteLine("Number of files: {0}.", foundFiles.Count);
            }
            catch (Exception err)
            {
                Console.WriteLine("The process (finding files) failed: {0}", err.ToString());
            }


            lvFound.Items.Clear();
            // Add all entries to the list
            foreach (string dir in foundFiles)
            {
                Console.WriteLine(dir);

                lvFound.Items.Add(Path.GetFileName(dir));
            }

            // Mark color items
            MarkColoredItems();

            Console.WriteLine("End of directory::::::::::::::::::::::::::::::::::::");
        }

        // With "if('.' + ext.key == ...)"
        public bool IsValidExtension(string extension)
        {
            bool isValid = false;

            // Always return true
            if(isIgnoreExtensionsd == true)
            { 
                return true;
            }

            foreach (var ext in enabledExt)
            {
                if (ext.Value == true)
                {
                    // Check if string matches
                    if ('.' + ext.Key == extension)
                    {
                        isValid = true;
                        break;
                    }
                }
            }

            return isValid;
        }

        public void MarkColoredItems()
        {
            for (int i = 0; i < lvFound.Items.Count; i++)
            {
                // OK color
                lvFound.Items[i].BackColor = Color.Green;

                bool isValid = IsValidExtension(Path.GetExtension(lvFound.Items[i].Text));
                if (!isValid)
                {
                    lvFound.Items[i].BackColor = Color.Red;
                    continue;
                }

                // If previewRegex fails, set yellow
                Match m = PreviewRegex(lvFound.Items[i].Text);
                if (!m.Success)
                {
                    lvFound.Items[i].BackColor = Color.Yellow;
                    continue;
                }
            }
        }

        public void ProcessInput()
        {
            string file = tbInput.Text;

            if (file == "")
                return;

            // Set working directory to the dir
            try
            {
                directory = Path.GetDirectoryName(file);
                inputFileName = Path.GetFileName(file);
                Directory.SetCurrentDirectory(directory);
            }
            catch (System.ArgumentException)
            {
                return;
            }
            
            // Update foundFiles
            UpdateFoundFiles();


            // Format the input string to include number wildcards "hejsan01.txt" --> "hejsan$episode$.txt"
            MatchEvaluator evaluator = new MatchEvaluator(ReplaceNum);
            string f_filename = Regex.Replace(inputFileName, episodeNrPattern, evaluator);
            
            // Set output filename without extension
            tbOutput.Text = Path.GetFileNameWithoutExtension(f_filename);

            UpdatePreviewRegex();
        }

        public Match PreviewRegex(string previewText)
        {
            Match match;
            try
            {
                match = Regex.Match(previewText, episodeNrPattern);
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("ERROR::::::Preview Failed");
                tbRegexTest.Text = "<Error>";
                tbRegexTest.BackColor = Color.Red;
                return Match.Empty;
            }

            return match;
        }

        // Changes color of the box under regex input.
        public void UpdatePreviewRegex()
        {
            Match match = PreviewRegex(tbInput.Text);
            if (!match.Success)
            {
                Console.WriteLine("Preview Match Not successfull");
                tbRegexTest.Text = "<Failed>";
                tbRegexTest.BackColor = Color.Red;
                tbRegexTest.ForeColor = Color.Black;
            }
            else
            {
                tbRegexTest.BackColor = Color.Green;
                tbRegexTest.ForeColor = Color.Black;

                // https://regex101.com/
                string nr = match.Groups["episode"].Value;
                tbRegexTest.Text = nr;
            }
        }

        public static string ReplaceNum(Match match)
        {
            string newString = "";

            // Skip the fullgroup
            for (int i = 1; i < match.Groups.Count; i++)
            {
                if(match.Groups[i].Name == "episode")
                {
                    newString += @"$episode$";
                }
                else
                {
                    newString += match.Groups[i].Value;
                }
            }

            return newString;
        }
        public static string RemoveNum(Match match)
        {
            return @"";
        }

        public static string nrToReplace = "";
        public static string ReplaceQ(Match match)
        {
            return nrToReplace;
        }

        string directory = "";
        string inputFileName = "";
        string episodeNrPattern = @"(- )(?<episode>\d+)";
        string patternNewName = @"(?'episode'\$episode\$)";
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            // Stupid forms can not select folders
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string path = "";
            if (result == DialogResult.OK) // Test result.
            {
                path = openFileDialog1.FileName;

                tbInput.Text = path;
                Console.WriteLine(path);
            }

            ProcessInput();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lvFound.Items.Count == 0)
            {
                return;
            }

            RenameFiles();
        }

        private void RenameFiles()
        {
            string oldOutputText = tbOutput.Text;
            string oldInputText = tbInput.Text;

            Console.WriteLine("Renaming Files....");

            pbProgress.Value = 0;

            // Rename all the files
            for (int i = 0; i < lvFound.Items.Count; i++)
            {
                // If item is filtered (red) go next
                if(!IsValidExtension(Path.GetExtension(lvFound.Items[i].Text)))
                {
                    continue;
                }
                

                // Get the specific number
                Match match = Regex.Match(lvFound.Items[i].ToString(), episodeNrPattern);

                string nr = match.Groups["episode"].Value;
                if (!match.Success)
                {
                    Console.WriteLine("{0}: Match Not successfull", lvFound.Items[i].Text);
                    continue;
                }

                nrToReplace = nr;
                MatchEvaluator evaluatorNewName = new MatchEvaluator(ReplaceQ);
                string newFileName = Regex.Replace(tbOutput.Text, patternNewName, evaluatorNewName);

                pbProgress.Value = (int)((float)i / (float)lvFound.Items.Count * 100);

                try
                {
                    // Add extension aswell
                    System.IO.File.Move(lvFound.Items[i].Text, newFileName + Path.GetExtension(lvFound.Items[i].Text));
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("File with name '{0}' already exists!, skipping....", newFileName + Path.GetExtension(lvFound.Items[i].Text));
                    continue;
                }

                

                Console.WriteLine(newFileName);
            }

            pbProgress.Value = 100;

            Console.WriteLine("Finished renaming files....");


            // Update
            ProcessInput();

            // Change text boxes
            tbOutput.Text = oldOutputText;

            MatchEvaluator ev = new MatchEvaluator(ReplaceQ);
            string newInputName = Regex.Replace(oldInputText, patternNewName, ev);
            tbInput.Text = newInputName;
        }

        bool isIgnoreExtensionsd = false;
        Dictionary<string, bool> enabledExt = new Dictionary<string, bool>()
        {
            {"mkv", true},
            {"mp4", true},
            {"ass", true},
        };

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ProcessInput();
            }
        }

        private void tbRegex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ProcessInput();
            }
        }

        private void tbRegex_TextChanged(object sender, EventArgs e)
        {
            episodeNrPattern = tbRegex.Text;
            PreviewRegex(tbInput.Text);
            UpdatePreviewRegex();

            MarkColoredItems();
        }

        private void cbEnableMP4_CheckedChanged(object sender, EventArgs e)
        {
            enabledExt["MP4"] = cbEnableMP4.Checked;
            MarkColoredItems();
        }

        private void cbEnableASS_CheckedChanged(object sender, EventArgs e)
        {
            enabledExt["ass"] = cbEnableASS.Checked;
            MarkColoredItems();
        }

        private void cbEnableMKV_CheckedChanged(object sender, EventArgs e)
        {
            enabledExt["mkv"] = cbEnableMKV.Checked;
            MarkColoredItems();
        }

        private void cbIgnoreExtension_CheckedChanged(object sender, EventArgs e)
        {
            isIgnoreExtensionsd = cbIgnoreExtension.Checked;
            MarkColoredItems();

            // Disable Extension screen
            gbExtensions.Enabled = !isIgnoreExtensionsd;
        }
    }
}
