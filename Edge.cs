using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube
{
    public class Edge
    {
        private double init;
        private double end;
        public Edge(double center, double length )
        {
            init = center - length / 2;
            end = center + length / 2;
        }
        public bool Collide(Edge edge)
        {
            if ((init >= edge.init && init <= edge.end) ||
                (end >= edge.init && end <= edge.end)   ||
                (edge.init >= init && edge.init <= end) ||
                (edge.end >= init && edge.end <= end))
                return true;

            return false;
        }
    }
}
