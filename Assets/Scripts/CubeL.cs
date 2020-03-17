using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class CubeL : MonoBehaviour
{
    public bool IsConnected;
    public GameObject R;


    int[] a = { 1, 2, 3, 4, 5, 6, };
    public void OnClick()
    {
        if(IsConnected)
        {
            print("1");
            R.SendMessage("Show", a);
        }
        else
        {
            print("请连接信号线！");
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
