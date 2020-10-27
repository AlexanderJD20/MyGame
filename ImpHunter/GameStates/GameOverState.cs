using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace ImpHunter.GameStates {
    class GameOverState :  GameObjectList {
        public GameOverState() {
            this.Add(new SpriteGameObject("spr_game_over"));
            
        }
        public override void HandleInput(InputHelper inputHelper) {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space)) {
                
                GameEnvironment.GameStateManager.SwitchTo("PlayingState");
            }
        }
    }
}
