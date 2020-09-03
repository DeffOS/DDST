using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DDST
{
    public partial class DDMB : Form
    {
        public DDMB()
        {
            InitializeComponent();
        }
        //private string   bin_folder = ""; BinBrowserDialog.SelectedPath
        //private string   exit_path  = ""; ExitBrowserDialog.SelectedPath
        private string[] smd_files;


        private void BINBut_Click( object sender, EventArgs e)  { BinBrowserDialog.ShowDialog();}
        private void PathBut_Click(object sender, EventArgs e)  {ExitBrowserDialog.ShowDialog();}
        private void OpenBut_Click(object sender, EventArgs e)  {   OpenFileDialog.ShowDialog();}

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            List<string> sisis;
            if (smd_files == null) 
            {
                sisis = new List<string>();
            }else{
                sisis = smd_files.ToList();
            }

            foreach (string file in OpenFileDialog.FileNames)
            {
                if (sisis.Contains(file)) { continue; }
                SMD_List.Items.Add(file);
                sisis.Add(file);
            }
            smd_files = sisis.ToArray();
        }

        private void ExitText_OnEnter(object sender, EventArgs e)
        {
            if (ExitBrowserDialog.SelectedPath != "")
            {
                ExitText.Text = ExitBrowserDialog.SelectedPath;
            }
        }

        private void Check_Sequences_Supression()
        {
            if (!StaticTick.Checked && SequncesTick.Checked)
            {
                SequenceGBox.Enabled = true;
            }
            else
            {
                SequenceGBox.Enabled = false;
            }
        }

        private string[] Generate_QCs()
        {
            List<string> QCs = new List<string>();

            foreach (string file in smd_files)
            {
                string file_file = file.Split('\\')[file.Split('\\').Length - 1];
                string file_name = file_file.Split('.')[0];
                string path = file.Substring(0, file.Length - file_file.Length);
                string qc_path = path + file_name + ".qc";


                List<int> lods_ints = new List<int>();
                string[] smdFiles = Directory.GetFiles($"{path}");
                foreach (string fl in smdFiles)
                {
                    if (fl.Contains($"{file_name}_lod_"))
                    {
                        lods_ints.Add(Int16.Parse(fl.Split('_')[fl.Split('_').Length - 1].Split('.')[0]));
                    }
                }

                List<string> anims = new List<string>();
                if (!StaticTick.Checked && SequncesTick.Checked)
                {
                    Log.Text = $"{path}anims";
                    if (Directory.Exists($"{path}anims\\")) {
                        string[] animFiles = Directory.GetFiles($"{path}anims\\");
                        foreach (string fl in animFiles)
                        {
                            if (fl.Contains($"{file_name}"))
                            {
                                anims.Add(fl.Split('_')[fl.Split('_').Length - 1]);
                            }
                        }
                    };

                }

                string qc_cfile = "";
                qc_cfile += "$modelname \t"     + $"\"{ModelPath.Text}{file_name}.mdl\"\n";
                qc_cfile += "$scale \t"         + $"{ScaleNum.Value}\n";
                
                if (StaticTick.Checked)
                {
                    qc_cfile += "$body main \t" + $"\"{file_file}\"\n";
                    qc_cfile += "$staticprop \n";
                }else{
                    qc_cfile += "$model main \t" + $"\"{file_file}\"\n";
                }
                if (LodTick.Checked)
                {
                    int[] a_lods_ints = lods_ints.ToArray();
                    foreach (int indx in a_lods_ints)
                    {
                        qc_cfile += $"$lod {indx} {{ \n replacemodel \"{file_file}\" \"{file_name}_lod_{indx}.smd\" \n }} \n";
                    }
                }
                if (AutoCenterTick.Checked)
                {
                    qc_cfile += "$autocenter \n";
                }
                qc_cfile += $"${OpacityBox.Text} \n";
                qc_cfile += "$surfaceprop \t"   + $"\"{SurfaceBox.Text}\"\n";
                qc_cfile += "$cdmaterials \t"   + $"\"{CDPath.Text}\"\n";

                if (!StaticTick.Checked && SequncesTick.Checked)
                {
                    string[] a_anims = anims.ToArray();
                    if (a_anims.Length > 0)
                    {
                        foreach (string anm in a_anims)
                        {
                            string anm_name = anm.Split('.')[0];
                            qc_cfile += $"$sequence \"{anm_name}\" {{ \n";
                            qc_cfile += $"\t \"anims\\{file_name}_{anm}\" \n";
                            if (SqLoopTick.Checked)
                            {
                                qc_cfile += "\t loop \n";
                            }
                            qc_cfile += $"\t fps {SqFPS.Value}\n";
                            qc_cfile += "}\n";
                        }
                    }
                    else
                    {
                        qc_cfile += $"$sequence No_Animations \"{file_file}\"\n";
                    }
                }else{
                    qc_cfile += $"$sequence Static_Prop \"{file_file}\"\n";
                }

                if (File.Exists($"{path}{file_name}{CollSufixBox.Text}.smd"))
                {
                    qc_cfile += "$collisionmodel \t" + $"\"{file_name}{CollSufixBox.Text}.smd\"\n" + "{\n";
                }
                else
                {
                    qc_cfile += "$collisionmodel \t" + $"\"{file_name}.smd\"\n" + "{\n";
                }

                if (ConvexTick.Checked)
                {
                    qc_cfile += "\t$concave \n";
                }
                qc_cfile += "}\n";
                qc_cfile += "//Dwh";


                File.WriteAllText(qc_path, qc_cfile);

                QCs.Add(qc_path);
                ProgressBar.Value++;
            }
            return QCs.ToArray();
        }

        private void Compile_All()
        {
            string[] qcs = Generate_QCs();
            Log.Clear();
            foreach (string file in qcs)
            {
                Log.AppendText($"============|{file}|============"+" \n\r");
                //Log.AppendText($"cmd.exe /c \"{BinBrowserDialog.SelectedPath}\\studiomdl.exe\" -game \"{BinBrowserDialog.SelectedPath.Substring(0, BinBrowserDialog.SelectedPath.Length - 3)}{ModBox.Text}\" -nop4 -verbose \"{file}\"\n\r");
                Process pProcess = new Process();
                //pProcess.StartInfo.FileName = "cmd.exe";
                //pProcess.StartInfo.Arguments = $"/c \"{BinBrowserDialog.SelectedPath}\\studiomdl.exe\" -game \"{BinBrowserDialog.SelectedPath.Substring(0, BinBrowserDialog.SelectedPath.Length-3)}{ModBox.Text}\" -nop4 -verbose \"{file}\"";
                pProcess.StartInfo.FileName = $"{BinBrowserDialog.SelectedPath}\\studiomdl.exe";
                pProcess.StartInfo.Arguments = $"-game \"{BinBrowserDialog.SelectedPath.Substring(0, BinBrowserDialog.SelectedPath.Length - 3)}{ModBox.Text}\" -nop4 -verbose \"{file}\"";
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.CreateNoWindow = true;
                pProcess.Start();
                string output = pProcess.StandardOutput.ReadToEnd();
                //pProcess.WaitForExit();
                Log.AppendText(output + "\n\r");
                ProgressBar.Value++;
            }
        }

        private void CompileBut_Click(object sender, EventArgs e)
        {
            if (smd_files == null || BinBrowserDialog.SelectedPath.Length == 0) { return; }
            ProgressBar.Value = 0;
            ProgressBar.Maximum = smd_files.Length*2;
            InfoTab.SelectedIndex = 1;
            Compile_All();
        }

        private void GQCsBut_Click(object sender, EventArgs e)
        {
            if (smd_files == null) { return; }
            ProgressBar.Value = 0;
            ProgressBar.Maximum = smd_files.Length;
            Generate_QCs();
        }





        private void ClearBut_Click(object sender, EventArgs e)
        {
            smd_files = new string[] { };
            SMD_List.Items.Clear();
        }

        private void SMD_List_Delete(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                List<string> new_arr = smd_files.Cast<string>().ToList();
                foreach (int ind in SMD_List.SelectedIndices)
                {
                    new_arr.RemoveAt(ind);
                    SMD_List.Items.RemoveAt(ind);
                }
                smd_files = new_arr.ToArray();
            }
        }






        private void Correct_Path(TextBox sas)
        {
            if (sas.Text[sas.TextLength - 1] != '\\')
            {
                sas.Text += "\\";
            }
        }

        private void InCorrect_Path(TextBox sas)
        {
            if (sas.Text[sas.TextLength - 1] == '\\')
            {
                sas.Text = sas.Text.Substring(0,sas.Text.Length-1);
            }
        }

        private void ModelPath_Leave(object sender, EventArgs e)
        {
            Correct_Path(ModelPath);
        }

        private void CDPath_Leave(object sender, EventArgs e)
        {
            Correct_Path(CDPath);
        }

        private void ExitText_Leave(object sender, EventArgs e)
        {
            InCorrect_Path(ExitText);
            ExitBrowserDialog.SelectedPath = ExitText.Text;
        }

        private void ExitText_MouseEnter(object sender, EventArgs e)
        {
            if (ExitBrowserDialog.SelectedPath != "")
            {
                ExitText.Text = ExitBrowserDialog.SelectedPath;
            }
        }

        private void StaticTick_CheckedChanged(object sender, EventArgs e)
        {
            Check_Sequences_Supression();
            SequncesTick.Enabled = !StaticTick.Checked;
        }

        private void SequncesTick_CheckedChanged(object sender, EventArgs e)
        {
            Check_Sequences_Supression();
        }
    }
}
