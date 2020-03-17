using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideKey : NumButton
{

    public LineRenderer line;
    private Animator an;
    private bool ClickOn = true;

    private void Awake()
    {
        an = GetComponent<Animator>();
    }

    public new void OnClick()
    {
        an.SetBool("IsClick", true);
        if (Panel.GetComponent<PanelManager>().Power && ClickOn)
        {
            line.enabled = true;
            Panel.SendMessage("SideKey1On");
            ClickOn = false;
        }else if(Panel.GetComponent<PanelManager>().Power)
        {
            line.enabled = false;
            ClickOn = true;
        }
       
    }

    public new void ClickOver()
    {
        an.SetBool("IsClick", false);
    }


}
