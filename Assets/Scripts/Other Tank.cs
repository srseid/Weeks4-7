using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OtherTank : MonoBehaviour
{
    Slider missile;
    //refer to slider component
    float blowUp;
    
    // Start is called before the first frame update
    void Start()
    {
        missile = GetComponent<Slider>();
        //get slider component from inspector
    }

    // Update is called once per frame
    void Update()
    {
        blowUp += Time.deltaTime;
        //move missile over time
        missile.value = blowUp % missile.maxValue;
        //cover tank with fill after missile hit
    }
}
