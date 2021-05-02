using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TEST : MonoBehaviour
{
    public GameObject currentUI;
    public GameObject targetUI;

    public IEnumerator Show(GameObject targetObj)
    {
        targetObj = currentUI;
        while (targetUI.GetComponent<RectTransform>().position.y < 0)
        {
            targetUI.GetComponent<RectTransform>().position += new Vector3(0, 0.3f, 0);
        }

        yield break;

    }

    public IEnumerator Hide()
    {
        while (currentUI.GetComponent<RectTransform>().position.y > -60)
        {
            currentUI.GetComponent<RectTransform>().position -= new Vector3(0, 0.5f, 0);
        }
        yield break;
        //return null;
    }

    public void SwichPage(GameObject targetUI)
    {
        StartCoroutine(Show(targetUI));
        StartCoroutine(Hide());
    }
}
