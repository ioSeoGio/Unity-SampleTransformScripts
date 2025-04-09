using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3Extensions
{
    public static float SqrDistance(this Vector3 start, Vector3 end)
    {
        return (end - start).sqrMagnitude;
    }

    public static bool IsOutOfRange(this Vector3 start, Vector3 end, float range)
    {
        return start.SqrDistance(end) >= range * range;
    }
}
