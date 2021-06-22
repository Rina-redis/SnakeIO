﻿using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeIO
{
    public static class MathHelper
    {
        private static Random random;
        static MathHelper()
        {
            random = new Random();
        }
        //public static bool IsIntersectsCircleVsCircle(EatableObject circle1, EatableObject circle2)
        //{
        //    float deltaX = (circle2.GetCenter().X - circle1.GetCenter().X);
        //    float deltaY = (circle2.GetCenter().Y - circle1.GetCenter().Y);

        //    float distanceSquare = (deltaX * deltaX + deltaY * deltaY);
        //    return distanceSquare < circle2.shape.Radius * circle2.shape.Radius;
        //}
        public static float DistanceToPoint(Vector2f source, Vector2f destination)
        {
            float deltaX = destination.X - source.X;
            float deltaY = destination.Y - source.Y;
            float distanceToPoint = (float)Math.Sqrt(deltaX * deltaX +
                                                     deltaY * deltaY);

            return distanceToPoint;
        }
        public static float NextFloat(this Random rand, float a, float b)
        {
            float value = (float)rand.NextDouble();
            return value * (b - a) + a;
        }

    }
}
