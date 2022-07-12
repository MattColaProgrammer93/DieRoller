using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// It represents a single six sided die that rolls 1-6
    /// </summary>
    public class Die
    {
        /// <summary>
        /// The current face up value of the die 
        /// </summary>
        public byte FaceValue { get; set; }
        
        /// <summary>
        /// True if the die currently held
        /// </summary>
        public bool IsHeld { get; set; }
        
        /// <summary>
        /// Rolls the die and set the <see cref="FaceValue"/> 
        /// to the new number. Returns the new number
        /// </summary>
        /// <returns>Returns the new random number</returns>>
        public byte Roll()
        {
            // Generate random number
            // Set to face up value
            // Return new number
            throw new NotImplementedException();
        }

    }
}
