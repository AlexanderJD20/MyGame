using ImpHunter.GameObjects;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpHunter.GameStates {
    class PlayingState : GameObjectList {
        Player thePlayer;

        public PlayingState() {
            this.Add(new SpriteGameObject("spr_background"));

            thePlayer = new Player();
            this.Add(thePlayer);

        }
        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            
        }
    }
}
