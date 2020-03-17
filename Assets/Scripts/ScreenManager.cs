using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    public Sprite Axis;
    public Image image;



    void Powered ()
    {
        image.sprite = Axis;
    }

}
