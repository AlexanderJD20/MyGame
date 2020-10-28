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
        Boolean gameOver;
        GameObjectList crowd;
        TextGameObject score;
        TextGameObject nameScore;
        TextGameObject numberOfLives;
        TextGameObject nameLives;
        int lives = 3;
        int goals = 0;

        public PlayingState() {
            this.Add(new SpriteGameObject("spr_background"));

            thePlayer = new Player();
            this.Add(thePlayer);

            goalKeeper = new GoalKeeper();
            this.Add(goalKeeper);

            crowd = new GameObjectList();
            this.Add(crowd);

            nameScore = new TextGameObject("GameFont");
            nameScore.Text = "GOALS:";
            nameScore.Position = new Vector2(120, 0);
            this.Add(nameScore);

            score = new TextGameObject("GameFont");
            score.Text = "0";
            score.Position = new Vector2(300, 0);
            this.Add(score);

            nameLives = new TextGameObject("GameFont");
            nameLives.Text = "LIVES:";
            nameLives.Position = new Vector2(500, 0);
            this.Add(nameLives);

            numberOfLives = new TextGameObject("GameFont");
            numberOfLives.Text = "lives";
            numberOfLives.Position = new Vector2(630, 0);
            this.Add(numberOfLives);
        }

        public override void HandleInput(InputHelper inputHelper) {
            base.HandleInput(inputHelper);
            //press space to shoot
            if (inputHelper.KeyPressed(Keys.Space) && !ballFired) {
                theBall = new Ball(thePlayer.Position);
                this.Add(theBall);
                ballFired = true;
            }
        }

        public override void Update(GameTime gameTime) {
            base.Update(gameTime);
            score.Text = goals.ToString();
            //detect if ball got in goal
            if (ballFired && theBall.Position.Y <50 && theBall.Position.X > 320 && theBall.Position.X < 500) {
                if(goals >= 19) {
                    crowd.Add(new Crowd(new Vector2(75, 25 + (50 * (goals-19)))));
                }
                if(goals < 19) {
                    crowd.Add(new Crowd(new Vector2(25, 25 + (50 * goals))));
                }
                theBall.Visible = false;
                ballFired = false;
                goals++;
            }
            //look if ball missed
            if (ballFired && theBall.Position.Y < 0) {
                theBall.Visible = false;
                ballFired = false;
                lives--;
            }
            numberOfLives.Text = lives.ToString();
            //collision detection
            if (theBall != null) {
                if (theBall.CollidesWith(goalKeeper)) {
                    theBall.Visible = false;
                    ballFired = false;
                    lives--;
                }
            }
            if(lives <= 0) {
                gameOver = true;
            }
            if (gameOver) {
                GameEnvironment.GameStateManager.SwitchTo("GameOverState");
                lives = 3;
                goals = 0;
                thePlayer.Reset();
                gameOver = false;
                crowd.Children.Clear();
            }
        }
    }
}
