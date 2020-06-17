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
            tbRegex.Text = patternEpisodeNr;
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
                    Match match = Regex.Match(f, patternEpisodeNr);

                    if (!match.Success)
                    {
                        // skip
                    }
                    else
                    {
                        foundFiles.Add(f);
                    }
                }
                Console.WriteLine("The number of files starting with is {0}.", foundFiles.Count);
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

            // Mark Filtered Items
            MarkFilteredItems();
        }

        public void MarkFilteredItems()
        {
            for(int i = 0; i < lvFound.Items.Count; i++)
            {
                lvFound.Items[i].BackColor = Color.Green;

                foreach (var filter in map)
                {
                    if (filter.Value == false)
                        continue;

                    if ('.' + filter.Key == Path.GetExtension(lvFound.Items[i].Text))
                    {
                        lvFound.Items[i].BackColor = Color.Red;
                    }
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




            // Format the input string to include number wildcards "hejsan01.txt" --> "hejsan??.txt"
            MatchEvaluator evaluator = new MatchEvaluator(ReplaceNum);
            string f_filename = Regex.Replace(inputFileName, patternDigit, evaluator);
            Console.WriteLine("Formated name: " + f_filename);

            // Set output filename without extension
            tbOutput.Text = Path.GetFileNameWithoutExtension(f_filename);


            PreviewRegex(inputFileName);
        }

        public void PreviewRegex(string previewText)
        {
            // Get the specific number
            Match match = Regex.Match(previewText, patternEpisodeNr);

            string nr = match.Groups["episode"].Value;
            if (!match.Success)
            {
                Console.WriteLine("Preview Match Not successfull");
                tbRegexTest.Text = "<Failed>";
                return;
            }

            tbRegexTest.Text = nr;
        }

        public static string ReplaceNum(Match match)
        {
            return @"?";
        }
        public static string RemoveNum(Match match)
        {
            return @"";
        }

        public static string nrToReplace = "";
        public static string ReplaceQ(Match match)
        {
            Console.WriteLine(match.Value);
            return nrToReplace;
        }

        string directory = "";
        string inputFileName = "";
        string patternDigit = @"\d";
        string patternEpisodeNr = @"(- )(?'episode'\d+)";
        string patternNewName = @"\?+";
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            string file = "";
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;

                tbInput.Text = file;
                Console.WriteLine(file); // <-- Shows file size in debugging mode.
            }

            ProcessInput();
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (lvFound.Items.Count == 0)
            {
                return;
            }



            // Rename all the files
            for (int i = 0; i < lvFound.Items.Count; i++)
            {
                // Get the specific number
                Match match = Regex.Match(lvFound.Items[i].ToString(), patternEpisodeNr);

                string nr = match.Groups["episode"].Value;
                if (!match.Success)
                {
                    Console.WriteLine("Match Not successfull");
                    return;
                }

                nrToReplace = nr;
                MatchEvaluator evaluatorNewName = new MatchEvaluator(ReplaceQ);
                string newFileName = Regex.Replace(tbOutput.Text, patternNewName, evaluatorNewName);

                // Rember that the extension is not in the string
                File.Move(lvFound.Items[i].Text, newFileName + Path.GetExtension(lvFound.Items[i].Text));

                Console.WriteLine(newFileName);
            }

        }


        Dictionary<string, bool> map = new Dictionary<string, bool>()
        {
            {"mkv", false},
            {"txt", false},
        };
            
        private void cbFilterMKV_CheckedChanged(object sender, EventArgs e)
        {
            map["mkv"] = cbFilterMKV.Checked;
            MarkFilteredItems();
        }

        private void cbFilterTXT_CheckedChanged(object sender, EventArgs e)
        {
            map["txt"] = cbFilterTXT.Checked;
            MarkFilteredItems();
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ProcessInput();
            }
        }

        private void tbRegex_TextChanged(object sender, EventArgs e)
        {
            PreviewRegex(inputFileName);
        }
    }
}
