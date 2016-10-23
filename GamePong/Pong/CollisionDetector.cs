using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            BoundingBox first = new BoundingBox(new Vector3(a.X, a.Y, 0), new Vector3(a.X + a.Width, a.Y + a.Height, 0));

            BoundingBox second = new BoundingBox(new Vector3(b.X, b.Y, 0), new Vector3(b.X + b.Width, b.Y + b.Height, 0));

            if (first.Intersects(second))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}