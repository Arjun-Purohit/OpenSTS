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
using System.Xml;

namespace LIMS
{
    public partial class ConfigurationForm : Form
    {
        

        public ConfigurationForm()
        {
            InitializeComponent();

            this.BackColor = MainMenuForm.bgColour;     //Sets form colour to that specified in the MainMenuForm

            networkFolderPath_TextBox.Text = MainMenuForm.networkFolderPath;    //Auto-fills the network folder path with that specified in the MainMenuForm
            dataFolderPath_TextBox.Text = MainMenuForm.dataFolderPath;          //Auto-fills the data folder path with that specified in the MainMenuForm
            outputFolderPath_TextBox.Text = MainMenuForm.outputFolderPath;      //Auto-fills the output folder path with that specified in the MainMenuForm
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void browse_button_Click(object sender, EventArgs e)    //Opens the folder browser, to specify the network location that the program will store it's data
        {                                                               //Output and data folders are auto-filled, this should not be changed as other instances of LIMS will need to access this shared directory
            folderBrowser.Description = "Select the folder the program will store data in. This most likely should be a shared network location.";    //The text within the folder browser 
            if (folderBrowser.ShowDialog() == DialogResult.OK)    //ShowDialog() method of FolderBrowserDialog retruns true if valid path is chosen, this is used to prevent invalid paths
            {
                networkFolderPath_TextBox.Text = folderBrowser.SelectedPath;                    //Sets the networkFolderPath variable of this form to the valid, designated path
                dataFolderPath_TextBox.Text = folderBrowser.SelectedPath + @"\data\";           //Auto-fills the data folder path by appending \data\ to the end of the specified path
                outputFolderPath_TextBox.Text = folderBrowser.SelectedPath + @"\output\";       //Auto-fills the output folder path by appending \output\ to the end of the specified path
            }
        }

        private void WriteConfigFile()      //This method writes a configuration file in the same directory as this program, storing the paths of the network, data and output folders
        {
            string configPath = @"config.txt";      //Names the file "config.txt" and sets it's location to the program's directory
            File.WriteAllText(configPath, networkFolderPath_TextBox.Text + "\n" + dataFolderPath_TextBox.Text + "\n" + outputFolderPath_TextBox.Text);      //Writes each path on a new line in the config.txt file
        }        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {

        }

        private void dataFolderPath_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Configure_Button_Click(object sender, EventArgs e)     //Sets the user-specified settings when clicking the configure button
        {
            WriteConfigFile();      //Calls the method to write the user defined options 

            string output;
            if (MainMenuForm.ReadConfigFile())  //Calls this method to read and set the settings in the main menu form
            {
                if (!System.IO.Directory.Exists(MainMenuForm.outputFolderPath))
                {
                    System.IO.Directory.CreateDirectory(MainMenuForm.outputFolderPath);     //Creates the output folder as defined by the ouputFolderPath value
                }

                if (!System.IO.Directory.Exists(MainMenuForm.dataFolderPath))
                {
                    System.IO.Directory.CreateDirectory(MainMenuForm.dataFolderPath);       //Creates the data folder as defined by the dataFolderPath value
                }

                output = "Configuration successful \n LIMS folder location changed to: " + MainMenuForm.networkFolderPath;
                this.Close();       //Closes the form after applying settings
            }
            else { output = "Configuration failed \n LIMS folder location: " + MainMenuForm.networkFolderPath; }


            Output_Textbox.Text = output;
        }

        private void Output_Textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void networkFolderPath_TextBox_TextChanged(object sender, EventArgs e)          //Updates the data and output folder paths whenever the network path is edited
        {
            dataFolderPath_TextBox.Text = networkFolderPath_TextBox.Text + @"\data\";           //Updates the data folder path everytime the network folder path textbox is changed
            outputFolderPath_TextBox.Text = networkFolderPath_TextBox.Text + @"\output\";       //Updates the output folder path everytime the network folder path textbox is changed
        }

        private void BackgroundColour_Button_Click(object sender, EventArgs e)                  //Opens the Colour selection dialogue box and updates the bgColour field of the MainMenuForm 
        {                                                                                       //This is used to set the ground colour of all forms within their constructor
            if (colorBrowser.ShowDialog() == DialogResult.OK)                                   //As this form and MainMenuForm have both already been instantiated, we set the background colour manually
            {
                MainMenuForm.bgColour = colorBrowser.Color;
                this.BackColor = MainMenuForm.bgColour;
                this.Owner.BackColor = MainMenuForm.bgColour;
            }
        }

        private void ButtonColour_Button_Click(object sender, EventArgs e)
        {
            if (colorBrowser.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
