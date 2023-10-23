using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS
{
    [Serializable]
    public class Well   //The well class acts as an interface between the plate and sample classes. The well stores the sample's location within the plate.
    {
        public bool isFilled = false;       //Whether or not the well is filled with the sample
        public Sample sample;               //Reference to the sample object stored in this well, NULL if empty
        public readonly Plate plate;        //The plate this well belongs to
        public readonly char wellRow;       //Row value of this well (A, B, C, etc)
        public readonly int wellColumn;     //Column value of this well (1, 2, 3, etc)
        public readonly string wellName;    //Row + Column (A3, B10, etc)

        public Well(char row, int column, Plate plate)  //Constructor for the class
        {                                               
            this.plate = plate;
            this.wellRow = row;
            this.wellColumn = column;
            this.wellName = "" + row + column;
        }

        
    }
}
