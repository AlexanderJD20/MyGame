using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace ImpHunter.GameObjects {
    class Player : SpriteGameObject {
        public Player() : base("spr_player"){
            origin = Center;
            Reset();
        }
        public override void HandleInput(InputHelper inputHelper) {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Right)) {
                position.X += 20; 
            }
            if (inputHelper.KeyPressed(Keys.Left)) {
                position.X -= 20;
            }
            if (inputHelper.KeyPressed(Keys.Up)) {
                position.Y -= 20;
            }
            if (inputHelper.KeyPressed(Keys.Down)) {
                position.Y += 20;
            }
        }
        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            if(position.X > 650) {
                position.X = 640;
            }
            if (position.X < 150) {
                position.X = 160;
            }
            if (position.Y < 300) {
                position.Y = 300;
            }
            if(position.Y > 800) {
                position.Y = 800;
            }
        }
        public override void Reset() {
            base.Reset();
            position.X = GameEnvironment.Screen.X / 2;
            position.Y = GameEnvironment.Screen.Y / 2;
        }

    }
}
