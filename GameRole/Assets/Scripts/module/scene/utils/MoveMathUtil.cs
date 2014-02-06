using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module.scene.utils
{
    public class MoveMathUtil
    {
        public static int getDir(float sourceX, float sourceY, float tarX, float tarY)
        {
            int dir = 0;
            //dgr范围：-180到180
            float x1 = tarX - sourceX;
            float y1 = tarY - sourceY;
            double angle = Math.Atan2((double)y1, (double)x1);
            return getDir(angle);
        }

        public static int getDir(double angle)
        {
            angle = angle * 180 / Math.PI;
            int dir = 0;
            if (angle >= -15 && angle < 15)
            {
                dir = 2;
            }
            else if (angle >= 15 && angle < 75)
            {
                dir = 3;
            }
            else if (angle >= 75 && angle < 105)
            {
                dir = 4;
            }
            else if (angle >= 105 && angle < 170)
            {
                dir = 5;
            }
            else if (angle >= 170 || angle < -170)
            {
                dir = 6;
            }
            else if (angle >= -75 && angle < -15)
            {
                dir = 1;
            }
            else if (angle >= -105 && angle < -75)
            {
                dir = 0;
            }
            else if (angle >= -170 && angle < -105)
            {
                dir = 7;
            }
            return dir;
        }
    }
}
