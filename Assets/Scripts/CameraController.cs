using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    // 视角操作参数
    public RotationAxes m_axes = RotationAxes.MouseXAndY;
    public float m_sensitivityX = 1;
    public float m_sensitivityY = 1;

    // 水平方向的 镜头转向
    public float m_minimumX = -360f;
    public float m_maximumX = 360f;
    // 垂直方向的 镜头转向 (这里给个限度 最大仰角为45°)
    public float m_minimumY = -45f;
    public float m_maximumY = 45f;

    float m_rotationY = 0f;

    private bool canChangeVisual;

    public float MoveSpeedy = 5;
    public float MoveSpeedx = 5;

    public enum RotationAxes
    {

        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }

    // Use this for initialization
    void Start()
    {
        // 防止 刚体影响 镜头旋转
        if (GetComponent<Rigidbody>())
        {
            GetComponent<Rigidbody>().freezeRotation = true;
        }
    }

    void Update()
    {
        ButtonClick();

        VisualChange();

        CameraMove();
       
    }


    void ButtonClick()
    {
        RaycastHit hit = new RaycastHit();
        for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase.Equals(TouchPhase.Began))
            {
                // Construct a ray from the current touch coordinates
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
                
                if (Physics.Raycast(ray, out hit))
                {
                   
                    hit.transform.gameObject.SendMessage("OnClick");

                }
            }
        }
    } // 实现3D按钮触发

    void VisualChange()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canChangeVisual = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            canChangeVisual = false;
        }

        if (canChangeVisual)
        {
           if(Input.GetMouseButton(0))
            {
                if (m_axes == RotationAxes.MouseXAndY)
                {
                    float m_rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * m_sensitivityX;
                    m_rotationY += Input.GetAxis("Mouse Y") * m_sensitivityY;
                    m_rotationY = Mathf.Clamp(m_rotationY, m_minimumY, m_maximumY);

                    transform.localEulerAngles = new Vector3(-m_rotationY, m_rotationX, 0);
                }
                else if (m_axes == RotationAxes.MouseX)
                {
                    transform.Rotate(0, Input.GetAxis("Mouse X") * m_sensitivityX, 0);
                }
                else
                {
                    m_rotationY += Input.GetAxis("Mouse Y") * m_sensitivityY;
                    m_rotationY = Mathf.Clamp(m_rotationY, m_minimumY, m_maximumY);

                    transform.localEulerAngles = new Vector3(-m_rotationY, transform.localEulerAngles.y, 0);
                }
            }
        }

    } //按下空格键 鼠标左键按住拖动视角旋转

    void CameraMove()
    {
      
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * MoveSpeedy * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * MoveSpeedy * Time.deltaTime);
        }


        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * MoveSpeedx * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * MoveSpeedx * Time.deltaTime);
        }
    } //WSAD控制相机视角 移动

}
