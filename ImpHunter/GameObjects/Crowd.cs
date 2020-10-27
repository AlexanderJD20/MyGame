using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpHunter.GameObjects {
    class Crowd : SpriteGameObject{
        public Crowd(Vector2 startPosition) : base("spr_speler") {
            position = startPosition;
            origin = Center;
        }
    }
}
