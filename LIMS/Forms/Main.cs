//Created by Arjun Purohit
//E: arjun.purohit2020@my.ntu.ac.uk

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
    public partial class MainMenuForm : Form        //The "Main Menu" of the program and the first form instantiated by the program. Used to call all other forms. Doesn't close until program termination.
    {
        public static int plateNumber = 0;          //Plate number field used to hold the unique plate number of the next plate to be instantiated. Updated in constructor.

                                                    //Following three paths are set within the ConfigureationForm
        public static string dataFolderPath;        //Path to the common folder containing the data file storing the sample/plate list
        public static string outputFolderPath;      //Path to the common folder containing the excel document where sample data is output to
        public static string networkFolderPath;     //Path to the common folder containing the previous two folders

        public static Color bgColour = Color.FromArgb(255, 128, 128);       //Holds the ARGB value for the forms' background colour 
        public static Color butColour = Color.FromArgb(128, 128, 255);      


        List<Plate> platesList = new List<Plate>(); //List data store holding all plates in memory, loaded from plates.bin data file during initialisation

        public MainMenuForm()
        {
            InitializeComponent();
             
            if (ReadConfigFile())   //Reads configuration file to set up files paths if specified
            {
                Console.WriteLine("Config file read successfully");
            }
            else { Console.WriteLine("Config file cannot be read"); }

            if (ReadPlatesFile())   //If plate file exists, loads deserialized plates objects into memory (platesList)
            {
                plateNumber = platesList.Count();                           //Sets plateNumber variable to the number of plates in the platesList
                string outputCSV = outputFolderPath + "sample_list.csv";    //sets outputCSV to the sample_list.csv directory
                if (!File.Exists(outputCSV))                                //If the outputCSV file doesn't already exist, writes all samples in the platesList to a new outputCSV
                {
                    Console.WriteLine("Regenerating Sample List. Please wait...");
                    foreach (Plate p in platesList)
                    {
                        foreach (Sample s in p.SampleList)
                        {
                            s.WriteSampleToCSV();
                            Console.WriteLine("Written sample: " + s.internalSampleID + "to 'sample_list.csv'");
                        }
                    }
                }
                else { Console.WriteLine("Sample list found in: " + outputFolderPath); }
            }
        }

        bool ReadPlatesFile()
        {
            string file = dataFolderPath + "plates.bin";    //Sets the variable to the directory of the plates.bin data file
            if (File.Exists(file))      //If the file exists, clears the platesList and then parses the plates.bin data file to repopulate the platesList with the deserialized plates objects stored
            {
                platesList.Clear();     //Clears the platesList 

                using (Stream stream = File.Open(file, FileMode.Open))
                {
                    while (stream.Position != stream.Length)    //While loop to parse the file and add deserialised plate objects to the platesList
                    {
                        var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        platesList.Add((Plate)binaryFormatter.Deserialize(stream));
                    }
                }
                return true;
            }
            return false;       //Returns false if no data file
        }

        private void NewPlate_Button_Click(object sender, EventArgs e)
        {
            plateNumber++;                                              //Before creation of the NewPlateForm, increment the plate number for the contructor of the new plate in the NewPlateForm 
            Form NewPlate = new NewPlateForm();                         //Instantiate the new 
            NewPlate.Tag = this;                                        
            NewPlate.Show(this);
        }

        private void ViewPlates_Button_Click(object sender, EventArgs e)
        {
            Form ViewPlatesScreen = new ViewPlatesScreen();             //Instantiates a ViewPlatesScreen form
            ViewPlatesScreen.Tag = this;
            ViewPlatesScreen.Show(this);
        }

        private void Config_Button_Click(object sender, EventArgs e)    
        {
            Form ConfigurationScreen = new ConfigurationForm();         //Instatiates a ConfigurationScreen form
            ConfigurationScreen.Tag = this;
            ConfigurationScreen.Show(this);
        }

        public static bool ReadConfigFile()
        {
            string file = @"config.txt";                                //string holds the filename for the configuration file
            if (File.Exists(file))                                      //Checks if file exists
            {
                using (StreamReader sr = new StreamReader(file, Encoding.Default))      //If file exits, reads the file paths for the network, data and output files
                {
                    networkFolderPath = sr.ReadLine();
                    dataFolderPath = sr.ReadLine();
                    outputFolderPath = sr.ReadLine();
                }

                return true;
            }

            return false;   //If file doesn't exist, returns false
        }

        public void UpdateFormColour()
        {
            this.BackColor = bgColour;                                  //Sets colour to designated colour
        }

        private void MainMenuForm_Shown(object sender, EventArgs e)
        {
            UpdateFormColour();                                         //Updates the form colour everytime the form is show, in case the colour has been updated
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
