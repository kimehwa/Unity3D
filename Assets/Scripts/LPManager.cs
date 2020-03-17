using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPManager : MonoBehaviour
{
    public GameObject Power;
    public GameObject lightOn;
    public GameObject lightStandby;
    public GameObject lightRemote;

    // Update is called once per frame
    void Update()
    {
        if(Power.GetComponent<PowerButton>().IsClick)
        {
            lightOn.SetActive(true);
        }else
        {
            lightOn.SetActive(false);
        }
    }
}
