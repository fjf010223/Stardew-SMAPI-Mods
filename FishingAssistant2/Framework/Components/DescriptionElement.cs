using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewValley.Menus;

namespace FishingAssistant2.Framework.Components
{
    /// This code is copied from CJBok/SDV-Mods repository
    /// available under the MIT License. See that repository for the latest version.
    /// https://github.com/CJBok/SDV-Mods
    
    /// <summary>An options element which contains descriptive text.</summary>
    internal class DescriptionElement : BaseOptionsElement
    {
        /*********
         ** Public methods
         *********/
        /// <summary>Construct an instance.</summary>
        /// <param name="label">The checkbox label.</param>
        public DescriptionElement(string label)
            : base(label, -1, -1, 0, 0, 0) { }

        /// <summary>Draw the component to the screen.</summary>
        /// <param name="spriteBatch">The sprite batch being drawn.</param>
        /// <param name="slotX">The X position at which to draw, relative to the bounds.</param>
        /// <param name="slotY">The Y position at which to draw, relative to the bounds.</param>
        /// <param name="context">The menu drawing the component.</param>
        public override void draw(SpriteBatch spriteBatch, int slotX, int slotY, IClickableMenu? context = null)
        {
            spriteBatch.DrawString(Game1.smallFont, this.label, new Vector2(slotX + this.bounds.X, slotY + this.bounds.Y), Color.Black);
        }
    }
}