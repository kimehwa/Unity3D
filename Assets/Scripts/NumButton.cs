using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NumButton : MonoBehaviour
{
  
    public new GameObject light;
    private Animator an;
    public GameObject Panel;
    public GameObject Text;


    private void Awake()
    {
        an = GetComponent<Animator>();
    }

    private void Lighting()
    {
        light.SetActive(true);
        Text.SetActive(true);
    }

    private void TurnOff()
    {
        light.SetActive(false);
        Text.GetComponent<TextMesh>().text = "";
        Text.SetActive(false);
    }

    public virtual void OnClick()
    {
        an.SetBool("IsClick", true);
        //TODO:交互
        if(Panel.GetComponent<PanelManager>().Power)
        {
            switch (gameObject.tag)
            {
                case "1":
                    Text.GetComponent<TextMesh>().text += "1";
                    break;
                case "2":
                    Text.GetComponent<TextMesh>().text += "2";
                    break;
                case "3":
                    Text.GetComponent<TextMesh>().text += "3";
                    break;
                case "4":
                    Text.GetComponent<TextMesh>().text += "4";
                    break;
                case "5":
                    Text.GetComponent<TextMesh>().text += "5";
                    break;
                case "6":
                    Text.GetComponent<TextMesh>().text += "6";
                    break;
                case "7":
                    Text.GetComponent<TextMesh>().text += "7";
                    break;
                case "8":
                    Text.GetComponent<TextMesh>().text += "8";
                    break;
                case "9":
                    Text.GetComponent<TextMesh>().text += "9";
                    break;
                case "0":
                    Text.GetComponent<TextMesh>().text += "0";
                    break;
                case "Del":
                    string t = Text.GetComponent<TextMesh>().text;
                    Text.GetComponent<TextMesh>().text = t.Substring(0, t.Length - 1);


                    break;
            }
        }
    }

    public virtual void ClickOver()
    {
        an.SetBool("IsClick", false);
    }



}
