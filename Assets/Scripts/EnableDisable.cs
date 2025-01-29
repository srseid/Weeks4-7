using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public EnableDisable script;
    public GameObject go;

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            //sr.enabled = false;
            //sr.enabled =!sr.enabled; if it is false make true, if true make false

            //script.enabled = true;
            //activate script

            go.SetActive(false);
            //have gameObject active
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true;

            //script.enabled = true;
            
            go.SetActive(true);
        }
    }
}
