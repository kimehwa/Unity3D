using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Generate : MonoBehaviour
{
    public GameObject SpectrumAnalyzer;

    public void SpectrumAnalyzer_copy()
    {
        GameObject go = Instantiate(SpectrumAnalyzer);
        go.transform.position = new Vector3(10, 0, -1);
    }
}
