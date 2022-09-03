using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Expansion
{
    public static class Vector
    {
        public static Vector3 toV3(this Vector3Int v)
        {
            return new Vector3(v.x, v.y, v.z);
        }
        public static Vector3 toV3(this Vector2Int v, float z = 0)
        {
            return new Vector3(v.x, v.y, z);
        }
        public static Vector3Int toV3int(this Vector2Int v, int z = 0)
        {
            return new Vector3Int(v.x, v.y, z);
        }
        public static Vector2 toV2(this Vector2Int v)
        {
            return new Vector2(v.x, v.y);
        }

        public static Vector2 toV2(this Vector3 v)
        {
            return new Vector2(v.x, v.y);
        }

        public static Vector2Int toV2int(this Vector2 v)
        {
            return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
        }

        public static Vector2Int toV2int(this Vector3 v)
        {
            return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
        }

    }
}

