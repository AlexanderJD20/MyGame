using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpHunter.GameObjects {
    class GoalKeeper : SpriteGameObject {
        public GoalKeeper() : base("spr_keeper") {
            position.X = GameEnvironment.Screen.X / 2;
            position.Y = 95;
            velocity.X = 50;
            origin = Center;
        }
        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            
            if(position.X > 500) {
                velocity.X = -velocity.X;
            }
            if (position.X < 320) {
                velocity.X = -velocity.X;
            }
            
        }

    }
}
