﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public class Circle : IGeometry
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Umfang()
        {
            return 2 * (float)Math.PI * Radius;
        }

        public float Flaeche()
        {
            return (float)Math.PI * (float)Math.Pow(2, Radius);
        }
    }
}
