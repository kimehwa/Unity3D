using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : NumButton
{
    private Animator an;



    private void Awake()
    {
        an = GetComponent<Animator>();
    }


    public new void OnClick()
    {
        an.SetBool("IsClick", true);
        //TODO: 
    }

    new void ClickOver()
    {
        an.SetBool("IsClick", false);
    }
}
