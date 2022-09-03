using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Expansion
{
    public enum Direction8
    {
        UP, LeftUp, LEFT, LeftDown, DOWN, RightDown, RIGHT, RightUp
    }
    public enum Direction4
    {
        UP, LEFT, DOWN, RIGHT
    }

    public static class Direction
    {
        /// <summary>
        /// �p�x�̂���̐�Βl 45�x���Ƃ�1
        /// </summary>
        public static int Angle(Direction4 dir1, Direction8 dir2)
        {
            var d1 = (int)dir1 * 2;

            return Angle((Direction8)d1, dir2);
        }
        /// <summary>
        /// �p�x�̂���̐�Βl 45�x���Ƃ�1
        /// </summary>
        public static int Angle(Direction4 dir1, Direction4 dir2)
        {
            var d1 = (int)dir1 * 2;
            var d2 = (int)dir2*2;
            return Angle((Direction8)d1, (Direction8)d2);
        }
        /// <summary>
        /// �p�x�̂���̐�Βl 45�x���Ƃ�1
        /// </summary>
        public static int Angle(Direction8 dir1, Direction8 dir2)
        {
            var d1 = (int)dir1;
            var d2 = (int)dir2;
            int res = Mathf.Min(Mathf.Abs(d1 - d2), Mathf.Abs(d1 - d2 + 8), Mathf.Abs(d1 - d2 - 8));

            return res;
        }

    }

}

