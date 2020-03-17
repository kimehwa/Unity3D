using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelManager : MonoBehaviour
{
    public GameObject Text;
    public Sprite[] sprits;


    public GameObject ScreenImage;
    public bool Power = false;



    private void PowerOn()
    {
        Power = true;
        Text.SetActive(true);
        //开机动画
        StartCoroutine("OpenAct");

    }

    private void PowerOff()
    {
        Power = false;
        ScreenImage.GetComponent<Image>().sprite = sprits[2];
        Text.GetComponent<TextMesh>().text = "";
        Text.SetActive(false);
        StartCoroutine("CloseAct");
    }
    IEnumerator OpenAct()
    {

        ScreenImage.GetComponent<Image>().sprite = sprits[1];
        yield return new WaitForSeconds(2);
        ScreenImage.GetComponent<Image>().sprite = sprits[0];
    }

    IEnumerator CloseAct()
    {
        yield return new WaitForSeconds(1);
        ScreenImage.GetComponent<Image>().sprite = sprits[0];
    }

    void SideKey1On()
    {
        ScreenImage.GetComponent<Image>().sprite = sprits[3];
    }

}
