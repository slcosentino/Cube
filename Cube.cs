using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    public class Cube
    {
        private Edge width;
        private Edge height;
        private Edge depth;
        public Cube(Point dimension, double length)
        {
            width = new Edge(dimension.X, length);
            height = new Edge(dimension.Y, length);
            depth = new Edge(dimension.Z, length);
        }
        public bool IsCollide(Cube cube) {
            return cube.width.Collide(width) ||
                cube.height.Collide(height)    ||
                cube.depth.Collide(depth);
        
        }
        public bool CollideVolume(Cube cube)
        {
            throw new NotImplementedException();
        }
    }
}
