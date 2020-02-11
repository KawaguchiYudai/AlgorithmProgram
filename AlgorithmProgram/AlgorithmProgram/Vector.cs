﻿using System;
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

        public float Angle(Vector a,Vector b)
        {
            var ab = a.x * b.x + a.y * b.y + a.z * b.z;
            var abSize = Size(a) * Size(b);
            var cos = ab / abSize;
            return cos;
        }

        public float Size(Vector a)
        {
            var x = a.x * a.x;
            var y = a.y * a.y;
            var z = a.z * a.z;
            var size = Math.Sqrt(x + y + z);
            return (float)size;
        }
    }
}
