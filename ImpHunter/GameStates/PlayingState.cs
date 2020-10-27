using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpHunter.GameStates {
    class PlayingState : GameObjectList {
        public PlayingState() {
            this.Add(new SpriteGameObject("spr_field"));
            

        }
        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            
        }
    }
}
