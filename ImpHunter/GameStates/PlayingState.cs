using ImpHunter.GameObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpHunter.GameStates {
    class PlayingState : GameObjectList {
        Player thePlayer;
        Ball theBall;
        GoalKeeper goalKeeper;
        Boolean ballFired;

        public PlayingState() {
            this.Add(new SpriteGameObject("spr_background"));

            thePlayer = new Player();
            this.Add(thePlayer);

            goalKeeper = new GoalKeeper();
            this.Add(goalKeeper);
        }
        
        public override void HandleInput(InputHelper inputHelper) {
            base.HandleInput(inputHelper);
            if (inputHelper.KeyPressed(Keys.Space) && !ballFired) {
                theBall = new Ball(thePlayer.Position);
                this.Add(theBall);
                ballFired = true;
            }
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            if (ballFired && theBall.Position.Y <50) {
                theBall.Visible = false;
                ballFired = false;
            }
        }
    }
}
