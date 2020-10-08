using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FTUtility
{
    public static GameObject CloneObject(GameObject original)
    {
        GameObject go = MonoBehaviour.Instantiate(original);
        go.transform.position = original.transform.position;
        go.transform.localScale = original.transform.localScale;
        go.transform.rotation = original.transform.rotation;

        return go;
    }
    public static GameObject CloneObject(GameObject original,Vector2 clonePos)
    {
        GameObject go = MonoBehaviour.Instantiate(original);
        go.transform.position = clonePos;
        go.transform.localScale = original.transform.localScale;
        go.transform.rotation = original.transform.rotation;

        return go;
    }

    public static GameObject CloneObjectInChild(GameObject original,Transform pearent)
    {
        GameObject go = MonoBehaviour.Instantiate(original);
        go.transform.SetParent(pearent);
        go.transform.localPosition = original.transform.position;
        go.transform.localScale = original.transform.localScale;
        go.transform.localRotation = original.transform.rotation;

        return go;
    }

    public static GameObject CloneObjectInChild(GameObject original, Transform pearent,Vector2 clonePos)
    {
        GameObject go = MonoBehaviour.Instantiate(original);
        go.transform.SetParent(pearent);
        go.transform.position = clonePos;
        go.transform.localScale = original.transform.localScale;
        go.transform.rotation = original.transform.rotation;

        return go;
    }



}
