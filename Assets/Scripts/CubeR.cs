using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeR : MonoBehaviour
{
    public TextMesh text;
    private float timer = 0;
    private int i = 0;
    public bool IsConnected;

    

    public void Show(int[] a)
    {
        
        if (IsConnected)
        {
            foreach(int i in a)
            {
                text.text += i.ToString();
            }
        }
        
    }

    void Connected()
    {
        IsConnected = true;
    }

    void UnConnected()
    {
        IsConnected = false;
    }
}
