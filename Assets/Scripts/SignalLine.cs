using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalLine : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    private bool IsConnected;

    public void OnClick()
    {
        if(IsConnected)
        {
            go2.SendMessage("UnConnected");
            go1.SendMessage("UnConnected");
            IsConnected = false;
        }else
        {
            go2.SendMessage("Connected");
            go1.SendMessage("Connected");
            IsConnected = true;
        }
    }
}
