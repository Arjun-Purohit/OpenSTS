using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIMS
{
    public partial class ViewPlatesScreen : Form
    {
        List<Plate> platesList = new List<Plate>();
        Dictionary<Panel, Well> PanelToWellDictionary = new Dictionary<Panel, Well>();
        //Plate currentPlate;

        public ViewPlatesScreen()
        {
            InitializeComponent();

            this.BackColor = MainMenuForm.bgColour;

            if (ReadPlatesFile())
            {
                Console.WriteLine("Plates file successfully read");
            }
            else Console.WriteLine("Plates file read unsuccessful, please check file exists");

            UpdateListbox();            

        }

        private void UpdatePanelLabels(Plate p)
        {
            int i = 0;
            for (int columns = 0; columns < Plate.plateColumns; columns++)
            {
                for (int rows = 0; rows < Plate.plateColumns; rows++)
                {
                    string s = "panel" + i;
                    Panel panel = this.Controls.Find(s, true).FirstOrDefault() as Panel;
                    Label label = panel.Controls.Find("label" + (i + 1), true).FirstOrDefault() as Label;
                    label.Text = p.wellArray[columns, rows].wellName;
                    i++;
                }
            }
        }

        void UpdateListbox()
        {            
            foreach(Plate p in platesList)
            {
                Plates_Listbox.Items.Add(p);
                //Plates_Listbox.Items[i] = p.PlateName;                
            }
        }

        bool ReadPlatesFile()
        {
            string file = MainMenuForm.dataFolderPath + "plates.bin";
            if(File.Exists(file))
            {
                platesList.Clear();

                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    while (stream.Position != stream.Length)
                    {
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        platesList.Add((Plate)binaryFormatter.Deserialize(stream));
                    }
                }
                return true;
            }
            return false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlateAttributes((Plate)Plates_Listbox.SelectedItem);
            UpdatePanelLabels((Plate)Plates_Listbox.SelectedItem);
        }

        private void LoadPlateAttributes(Plate plate)
        {
            PanelToWellDictionary.Clear();
            foreach (Well w in plate.wellArray)
            {
                int row = char.ToUpper(w.wellRow) - 64;
                Panel panel = this.Controls.Find("panel" + (((row * 10) - 10) + (w.wellColumn - 1)) , true).FirstOrDefault() as Panel;

                panel.BackColor = Color.Silver;

                if (w.isFilled)
                {                    
                    if (w.sample.isControl)
                    {
                        if (w.sample.sampleType == SampleTypes.controlNeg)
                        {
                            panel.BackColor = Color.Aqua;
                        }
                        if (w.sample.sampleType == SampleTypes.controlPos)
                        {
                            panel.BackColor = Color.Yellow;
                        }
                    }
                    else panel.BackColor = Color.Lime;

                    PanelToWellDictionary.Add(panel, w);
                }
            }
        }

        private void panel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            PanelToWellDictionary.TryGetValue((Panel)sender, out Well w);
            string toolTipText;
            if (w != null)
            {
                toolTipText = w.sample.internalSampleID + Environment.NewLine + 
                    "Supplier ID: " + w.sample.providerSampleID + Environment.NewLine +
                    "Processed by: " + w.sample.sOperator + Environment.NewLine +
                    "Processed at: " + w.sample.dateTimeSampled;
            }
            else { toolTipText = "Empty well"; }
            toolTip.SetToolTip((Control)sender, toolTipText);
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
