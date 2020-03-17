using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerButton : MonoBehaviour
{
    public bool IsClick = false;
    private Animator an;
    public new GameObject light;
    public GameObject[] Buttons;
    public GameObject Panel;
    public GameObject Screen;

    private void Awake()
    {
        an = GetComponent<Animator>();
        
    }

  

    public virtual void OnClick()
    {
        
        if (IsClick)
        {
            
            IsClick = false;
            an.SetBool("IsClick", false);
            foreach(GameObject button  in Buttons)
            {
                button.SendMessage("TurnOff");
            }
            Panel.SendMessage("PowerOff");
            Screen.SendMessage("PowerOff");
        }
        else
        {
            IsClick = true;
            an.SetBool("IsClick", true);
            foreach(GameObject button in Buttons)
            {
                button.SendMessage("Lighting");
            }
            Panel.SendMessage("PowerOn");
            Screen.SendMessage("PowerOn");
        }
    }
    public virtual void Lighting()
    {
        
        if (IsClick)
        {
            light.SetActive(true);
        }
        else
        {
            light.SetActive(false);
        }

    }
 
}