using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Squirrel
{
    class Obstacle : SpriteBase
    {
        ObstacleCategory Category { get; set; } // Stores what type of obstacle this is.

        public Obstacle(ObstacleCategory type)
        {
            this.Category = type; // Set the category.
        }
    } // Obstacle
}
