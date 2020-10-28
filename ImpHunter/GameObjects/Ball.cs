using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpHunter.GameObjects {
    class Ball : SpriteGameObject {
        public Ball(Vector2 startPosition) :base("spr_ball") {
            position = startPosition;
            velocity.Y = -200;
            origin = Center;
        }
    }
}
