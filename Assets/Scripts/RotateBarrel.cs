using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBarrel : MonoBehaviour
{
    public float angle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   

    public void AngleDown(float rotBull)
    {
    transform.localEulerAngles = new Vector3(0,0,25);
}
}
