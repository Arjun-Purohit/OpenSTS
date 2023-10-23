using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    //Class defining the "plate". Instantiated with an integer referring to the reference number of the plate. The naming format of each plate can be specified in the "PlateName" assignment within the constructor, however
    //must end in the plate number for indexing purposes.
    //Stores multiple objects of the "Well" class; the amount can be defined by altering the plateColoumns/plateRows variables. 
    //If changing the number of Wells on each plate, the "ViewPlatesScreen.cs"/"NewPlateScreen.cs" forms/code will need to be changed to include more panels to assign/view wells

    [Serializable]  //Class is set to serializable so it can be written to the output CSV/data file
    public class Plate
    {
        public static int plateColumns = 10;    //Defines the number of well columns on the plate, this should correlate with the real-world plate being emulated.
        public static int plateRows = 10;       //Defines the number of well rows on the plate, this should correlate with the real-world plate being emulated.

        public readonly string PlateName;       //Unique name identifier given to plate for CSV output/indexing. Assigned in constructor. Read-Only to prevent tampering, post-creation.

        public readonly Well[,] wellArray = new Well[plateRows, plateColumns];  //Data store to hold instantiated well objects, size set to size of plate (rows x columns)

        public List<Sample> SampleList = new List<Sample>();    //List of samples added to wells, is traversed to output samples to output CSV

        public Plate(int plateNumber)
        {
            this.PlateName = "MTIF-017-" + "P" + plateNumber;   //Assignment of plate object's name
            GenerateWells();                                    //Instantiates objects of the well class and adds them to the wellArray data store within this class
        }

        public Well GetWellFromString(string s)                 //Look up method to return a specific well object from the wellArray using it's alphanumeric name, by converting it to an array postiion (A1 = [0,0], B1 = [1,0], C10 = [2,9], etc...)
        {
            char r = s.ElementAt(0);                            //Takes the first character, the row letter (A, B, etc...) and stores it as a char
            int c;
            if (s.Length < 3)                                   //If the string is less than 3 (A4, R8, etc...) the second character of the string can be parsed as an integer, returning the column number of the well
            {
                c = int.Parse(s.ElementAt(1).ToString());
            }
            else { c = int.Parse(s.Substring(1, 2).ToString()); } //If the string is 3 or more chars (A10, R10, etc...) the second and third characters of the string can be parsed as an integer, returning the column number of the well

            return wellArray[(int)r - 65, (int)c - 1];          //Subtracting 65 from the value of the row character converts it from it's ascii code to an integer value, numericising the row (A = 0, B = 1, G = 6, etc...)
        }                                                       //Subtracting 1 from the column integer converts the well column to the zero-based array format. (Column 1 = 0, 2 = 1, etc...)
                                                                //By searching up this position [r,c] in the wellArray, the well is retrieved and returned

        private void GenerateWells()
        {
            for (int columns = 0; columns < plateColumns; columns++)    //Instantiates objects of the "Well" class, to the number specified on the dimensions of the plate
            {
                for (int rows = 0; rows < plateRows; rows++)
                {
                    char c = (Char)(rows + 65);                         //char c = the row number + 65 to convert the row integer to a corresponding ascii code
                    Well w = new Well(c, columns + 1, this);            //"Well" object instantiated using the row, column and the plate object calling this method

                    wellArray[rows, columns] = w;                       //"Well" object added to the well array using it's row/column position  
                }
            }
        }

        public override string ToString()
        {
            return PlateName;   //Helper method to return the name of this plate; overrides the ToString() method of the String type to return the PlateName rather than the object's type name
        }
    }
}
