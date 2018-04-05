using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ImpHunter
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class ImpHunter : GameEnvironment
    {
        public ImpHunter()
        {
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            base.LoadContent();
            Screen = new Point(800, 600);
            ApplyResolutionSettings();

            // TODO: use this.Content to load your game content here

        }
        
    }
}
