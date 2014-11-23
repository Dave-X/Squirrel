using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Squirrel
{
    // Class for sprites & sprite sheets.
    abstract class Sprite
    {
        Texture2D textureImage; // The image for this sprite.

        Vector2 position; // Position to draw the sprite.

        Point frameSize; // Size of each frame on the sprite sheet.
        Point currentFrame; // The current frame the sprite is on.
        Point sheetSize; // The number of columns and rows in the sprite sheet.

        int timeSinceLastFrame; // Number of miliseconds since last frame was drawn.
        int milisecondsPerFrame; // Number of miliseconds to wait between frame changes.


        //abstract void Update(GameTime x, Rectangle z);
        //abstract void Draw(GameTime y, SpriteBatch e);
    }
}
