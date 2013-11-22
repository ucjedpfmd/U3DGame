using UnityEngine;
using System.Collections;

public class NGUIUtility
{
    public static Transform rootParent;
    public static void SetParent(Transform child,Transform parent=null)
    {
        if (parent == null)
        {
            parent = rootParent;
        }
        Vector3 scale = child.localScale;
        Vector3 position = child.localPosition;
        child.parent = parent;
        child.localScale = scale;
        child.localPosition = position;
    }
}
