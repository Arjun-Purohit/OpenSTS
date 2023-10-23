using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIMS
{
    public partial class NewPlateForm : Form
    {
        public Plate p;     //Reference to the plate instantiated in the form
        public Dictionary<Well, Panel> WellToPanelDict = new Dictionary<Well, Panel>();     //Dictionary linking the well objects to their respective panel objects 
        public NewPlateForm()
        {
            InitializeComponent();

            this.BackColor = MainMenuForm.bgColour;             //Sets form colour to main menu colour
            p = new Plate(MainMenuForm.plateNumber);            //Instatiates a new plate with the current plate number
            UpdatePanelLabels(p);                               //Updates the text within the panels to read as the well numbers
            PlateID_Label.Text = "Plate ID: " + p.PlateName;    //Amends the PlateID label's text to the plateName of the plate
        }        

        private void UpdatePanelLabels(Plate p)
        {
            int i = 0;
            for (int columns = 0; columns < Plate.plateColumns; columns++)                                      //Traverse each well of the plate array
            {
                for (int rows = 0; rows < Plate.plateColumns; rows++)
                {
                    string s = "panel" + i;                                                                     
                    Panel panel = this.Controls.Find(s, true).FirstOrDefault() as Panel;                        //Retrieves the panel by it's name (panel#) where # = the numbered instance of the panel
                    Label label = panel.Controls.Find("label" + (i + 1), true).FirstOrDefault() as Label;       //Retrieves the label within the panel using the same method as above
                    label.Text = p.wellArray[columns, rows].wellName;                                           //Sets the label's text to the well name of the respective well in the plate's well array
                    WellToPanelDict.Add(p.wellArray[columns, rows], panel);                                     //Links the well within the plate to the panel object via a dictionary

                    i++;                                                                                        //Increments the panel number
                }
            }
        }

        private void WellBox_Click(object sender, EventArgs e)                                                  //Method to add a sample into the well by initialising the addSample form 
        {
            Panel panel = (Panel)sender;                                                                        //Method will only be called via a panel click, so it's safe to cast the object as the Panel type
            string sLabelNo = new String(panel.Name.Where(Char.IsDigit).ToArray());                             //Sets string as 
            int iLabelInt = int.Parse(sLabelNo) + 1;
            Label label = panel.Controls.Find("label" + iLabelInt, true).FirstOrDefault() as Label;

            Form addSample = new AddSampleBox(p, p.GetWellFromString(label.Text), this);
            addSample.Tag = this;
            addSample.Show(this);

            Console.WriteLine("Clicked on Well: " + label.Text);
        }


        private void ConfirmPlate_Button_Click(object sender, EventArgs e)
        {
            foreach (Sample s in p.SampleList)
            {
                s.WriteSampleToCSV();
            }

            using (Stream stream = File.Open(MainMenuForm.dataFolderPath + @"plates.bin", FileMode.Append))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, p);
            }

            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want discard this plate? All changes will be lost", "Cancel Plate", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainMenuForm.plateNumber--;
                p = null;
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //Do nothing
            }

            //this.Close();
        }
    }
}
