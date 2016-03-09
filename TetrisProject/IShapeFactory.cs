using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisProject
{
    /// <summary>
    /// Interface for handling new Shapes into the board
    /// </summary>
    public interface IShapeFactory
    {
        /// <summary>
        /// Provide a new Shape for the board
        /// </summary>
        void DeployNewShape();
    }
}
