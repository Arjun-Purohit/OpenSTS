using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIMS
{
    public partial class AddSampleBox : Form
    {
        private bool debugMode = true;

        private readonly Plate plateID;                 //The plate that the sample is being added to
        private readonly Well wellID;                   //The well of the plate the sample is being added to
        private readonly NewPlateForm parentForm;       //Reference to the form that generated this form
        private SampleTypes sampleType;                 //The type of sample being added
        public AddSampleBox(Plate plateID, Well wellID, NewPlateForm parentForm)        //Constructor of this form
        {
            InitializeComponent();

            this.BackColor = MainMenuForm.bgColour;     //Sets the background colour of the form to that specified in the main menu form
            this.plateID = plateID;
            this.wellID = wellID;
            this.parentForm = parentForm;

            Title_Label.Text = "Adding sample to well: " + wellID.wellName + " on plate: " + plateID.PlateName;     //Sets the title of the form 
                                                                                                                    //NOTE: MOST LIKELY DON'T WANT USERS BEING ABLE TO EDIT THE BELOW FIELDS THEREFORE AUTO-FILLED
            InternalPlateID_TextBox.Text = plateID.PlateName;                                                       //Auto-fills the the plateID section of the sample generator with the plateID of the current plate
            InternalWellID_TextBox.Text = wellID.wellName;                                                          //Auto-fills the the wellID section of the sample generator with the well name of the current well
            InternalSampleID_TextBox.Text = InternalPlateID_TextBox.Text + "-" + InternalWellID_TextBox.Text;       //Auto-fills the sample name by using plate & well IDs
        }

        private void Title_Label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSampleBox_Load(object sender, EventArgs e)
        {

        }

        private void AddSample_Button_Click(object sender, EventArgs e)
        {
            if (!SupplierPlateID_TextBox.Text.Equals("") && !SupplierWellID_TextBox.Text.Equals("") && !SupplierSampleID_TextBox.Text.Equals("")    //if statement checks none of the fields are blank
                && !InternalPlateID_TextBox.Text.Equals("") && !InternalWellID_TextBox.Text.Equals("") && !InternalSampleID_TextBox.Text.Equals("") || debugMode)
            {
                Sample s = new Sample(SupplierSampleID_TextBox.Text, SupplierPlateID_TextBox.Text, SupplierWellID_TextBox.Text,         //Instantiates the sample objects using the values entered into the form
                                        InternalPlateID_TextBox.Text, InternalWellID_TextBox.Text, InternalSampleID_TextBox.Text,
                                        sampleType, Operator_TextBox.Text, DateTime.Now);



                
                plateID.wellArray[wellID.wellRow - 65, wellID.wellColumn - 1].sample = s;   //Adds the sample to parent plate's wellArray in the position corresponding to the Well this sample was added to

                bool deleteSample = false;      //bool used to mark if the sample being added is to replace another sample on the plate
                Sample sampleToDelete = null;   //Holds reference to a sample to be replaced if the current sample is replacing it
                
                foreach(Sample n in plateID.SampleList)
                {
                    if (n.internalWellID == s.internalWellID)
                    {
                        deleteSample = true;    //If the new sample is being added to a well that already holds a sample, deleteSample indicates the existing sample is to be deleted to make way for the new sample
                        sampleToDelete = n;     //Holds reference to the sample that is being replaced
                    }                    
                }

                if(deleteSample)
                {
                    plateID.SampleList.Remove(sampleToDelete);  //Deletes the previous sample from the SampleList if marked for deletion
                }

                plateID.SampleList.Add(s);  //Adds the new sample to the samplelist
                //s.WriteSampleToCSV();

                wellID.isFilled = true;     //Marks the well as filled

                parentForm.WellToPanelDict.TryGetValue(wellID, out Panel p);    //Looks up and outputs a refence to the panel object representing a well, using the WellID of the well
                if (isPosControl_Checkbox.Checked)                              //If the sample is delcared as a Positive Control, the panel is changed to be it's ascociated colour
                {
                    p.BackColor = Color.Yellow;
                }
                else if(isNegControl_Checkbox.Checked)                          //If the sample is delcared as a Negative Control, the panel is changed to be it's ascociated colour
                {
                    p.BackColor = Color.Aqua;                                   
                }
                else p.BackColor = Color.Lime;                                  //If the sample isn't delcared as a Control, the panel is changed to be it's ascociated colour

                this.Close();                                                   //Closes the AddSampleBox form
            }
            else Console.WriteLine("One or more fields are blank");
            
            //parentForm.wellTo

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   //Cancel button closes the form
        }

        private void isPosControl_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (isPosControl_Checkbox.Checked)  //Code to prevent a sample being erroniously marked as both a positive and negative control
            {                                   //If marked as positive, it is unmarked as negative and the negative box is disabled. The negative box is only re-enabled once the positive box is unchecked
                isNegControl_Checkbox.Checked = false;
                isNegControl_Checkbox.Enabled = false;
                sampleType = SampleTypes.controlPos;    //Sets the sample type to controlPos
            }
            else if (!isPosControl_Checkbox.Checked)    //If positve box is unchecked, re-enabeld the negative checkbox
            {                                           //Also resets the sample type to that of a regular sample
                isNegControl_Checkbox.Enabled = true;
                sampleType = 0;
            }
        }

        private void isNegControl_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (isNegControl_Checkbox.Checked)  //Code to prevent a sample being erroniously marked as both a positive and negative control
            {                                   //If marked as negative, it is unmarked as positive and the positive box is disabled. The positive box is only re-enabled once the negative box is unchecked
                isPosControl_Checkbox.Checked = false;
                isPosControl_Checkbox.Enabled = false;
                sampleType = SampleTypes.controlNeg;    //Sets the sample type to controlNeg
            }
            else if (!isNegControl_Checkbox.Checked)    //If negative box is unchecked, re-enabeld the positive checkbox
            {                                           //Also resets the sample type to that of a regular sample
                isPosControl_Checkbox.Enabled = true;
                sampleType = 0;
            }
        }
    }
}
