using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgram.Physics
{
    class Vector
    {
        private float x;
        public float X => x;
        private float y;
        public float Y => y;
        private float z;
        public float Z => z;

        public Vector(float _x =0, float _y=0, float _z=0)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }
}
