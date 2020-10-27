using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ImpHunter.GameObjects {
    class Player : SpriteGameObject {
        public Player() : base("spr_speler"){
            Mouse.SetPosition(260, 390);
            origin = Center;
        }
        public override void HandleInput(InputHelper inputHelper) {
            base.HandleInput(inputHelper);
            this.position = inputHelper.MousePosition;
        }
        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            if(position.X > GameEnvironment.Screen.X) {
                position.X = GameEnvironment.Screen.X;
            }
        }

    }
}
