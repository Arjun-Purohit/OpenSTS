using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    //Class defining the sample. Instantiated with provider details, lab details, sample type, processing operator & date/time sampled. Stored within a well object and de facto stored in the plate object the well belongs to 
    //Additional fields can be added here by declaring them as public read-only, however they must also be added as parameters to the constructor and assigned within the constructor to prevent modification after instantiation
    //Any new new fields will be need to be added to the AddSampleBox form

    [Serializable]  //Class is set to serializable so it can be written to the output CSV/data file 
    public class Sample     
    {
        public readonly string providerSampleID;    //The sample ID assigned by the sample provider (external naming convention)
        public readonly string providerPlateID;     //The plate ID assigned by the sample provider (external naming convention)
        public readonly string providerWellID;      //The well ID assigned by the sample provider (external naming convention)

        public readonly string internalSampleID;    //The sample ID assigned by the lab (this program's naming convention)
        public readonly string internalPlateID;     //The plate ID assigned by the lab (this program's naming convention)
        public readonly string internalWellID;      //The well ID assigned by the lab (this program's naming convention)

        public readonly SampleTypes sampleType;     //Sample type enum used to determine whether sample is positive, negative control or positive control -> Edit the enum to change the types of samples to be added
        public readonly bool isControl;             //Bool used to identify whether or not sample is a control (negative & positive)
        public readonly string sOperator;           //The name of the operator who processed the sample
        public readonly DateTime dateTimeSampled;   //The date/time the sample was processed

        public Sample(string providerSampleID, string providerPlateID, string providerWellID,       //Constructor used to instantiate Sample class, used by AddSampleBox form
                        string internalPlateID, string internalWellID, string internalSampleID,
                        SampleTypes sampleType, string Operator, DateTime dateTimeSampled)
        {
            this.providerSampleID = providerSampleID;   //Assigns contructor parameter to field of instantiated Sample object
            this.providerPlateID = providerPlateID;
            this.providerWellID = providerWellID;
            this.internalPlateID = internalPlateID;
            this.internalWellID = internalWellID;
            this.internalSampleID = internalSampleID;
            this.sampleType = sampleType;
            this.sOperator = Operator;
            this.dateTimeSampled = dateTimeSampled;

            if (sampleType != 0)
            {
                isControl = true;   //If sample type is not positive (i.e is positive/negative control), set isControl to true
            }
        }

        public bool WriteSampleToCSV() //Method to write the instantiated sample object to sample_list.csv file defined in Main.cs, file name can be edited in the first line
        {
            string sampleListFile = MainMenuForm.outputFolderPath + "sample_list.csv";  //String buffer holding the output file address

            string sType;
            if (sampleType == 0)        //If statements recording the Sample Type field of the output CSV
            {
                sType = "Positive Sample";
            }
            else if (sampleType == SampleTypes.controlNeg)
            {
                sType = "Negative Control";
            }
            else if (sampleType == SampleTypes.controlPos)
            {
                sType = "Positive Control";
            }
            else { sType = "Type not recorded"; }

            string sampleString = providerSampleID + "," + providerPlateID + "," + providerWellID + "," +                                                               //String holding all details to be recorded by data
                    internalPlateID + "," + internalWellID + "," + internalSampleID + "," + sType + "," + sOperator + "," + dateTimeSampled + Environment.NewLine;      //Fields seperated by "," to parse into separate columns

            if (!File.Exists(sampleListFile))   //If the file specified in the string buffer doesn't exist create the file with the below columns. Comma delineator standard syntax for next column
            {
                string csvHeader = "Supplier Sample ID" + "," + "Provider Plate ID" + "," + "Provider Well ID" + "," +
                    "Internal Plate ID" + "," + "Internal Well ID" + "," + "Internal Sample ID" + "," + "Sample Type" + "," + "Operator" + "," + "Date/Time Processed" + "," + Environment.NewLine;

                File.WriteAllText(sampleListFile, csvHeader);   //Writes the columns specified above to the .csv output
            }

            File.AppendAllText(sampleListFile, sampleString);   //otherwise append the data stored in "sampleString" to the file

            return false;
        }

        public override string ToString()
        {
            String s = providerPlateID + " " + providerWellID + " " + providerSampleID;     //Helper method to return the name of this sample; overrides the ToString() method of the String type to return the full sanmple name, rather than the object's type name
            return s;
        }
    }
}
