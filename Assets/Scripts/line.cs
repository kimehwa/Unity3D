using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;


public class line : MonoBehaviour
{
    private LineRenderer lr;
    public float x = -3;
    public float y = 0.1f;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Sprites/Default"));
        lr.startWidth = 0.03f;                                    //设置画线开始宽度
        lr.endWidth = 0.03f;                                      //设置画线结束宽度
        lr.startColor = Color.white;                               //设置画线开始颜色
        lr.endColor = Color.white;                                 //设置画线结束颜色
        

        // Set some positions
        Vector3[] positions = new Vector3[300];                  //100个设置点
        

        for (int i = 0; i < 300; i++)
        {

            positions[i] = new Vector3(x, y, -1.5f);
            x += 0.01f;
            y = Mathf.Sin(x*10)/2;                                             //设置函数

            //Debug.Log(positions[i]);
        }

        lr.positionCount = positions.Length;
        lr.SetPositions(positions);

    }
}