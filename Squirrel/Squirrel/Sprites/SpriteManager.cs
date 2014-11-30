using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Squirrel
{
    /// <summary>
    /// This is a game component that implements IUpdateable.
    /// </summary>
    public class SpriteManager : Microsoft.Xna.Framework.DrawableGameComponent
    {
        SpriteBatch spriteBatch;
        private List<Sprite> sprites = new List<Sprite>();
        
        public SpriteManager(Game game)
            : base(game)
        {
            // TODO: Construct any child components here
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            spriteBatch = new SpriteBatch(Game.GraphicsDevice);

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            foreach (Sprite s in Game1.Obstacles)
            {
                s.Update(gameTime);
            }


            base.Update(gameTime);
        }


        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend);
            {
                foreach (Sprite s in Game1.Obstacles)
                {
                    s.Draw(gameTime, spriteBatch);
                }
            }
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}


/*
 * Draw Order
 * Map
 * Power ups
 * Nuts
 * Player
 * Enemies
 * Obstacles
 * Hometree
 * Menu
 * 
 * Componets Order
 * Map
 * SpriteManager
 * Menu
*/ 
