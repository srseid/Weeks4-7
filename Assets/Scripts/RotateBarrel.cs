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
    public void AngleUp(float rotBull)
    {

        Vector3 rotUp = new Vector3(rotBull, rotBull, rotBull);
        //transform.eulerAngle += rotUp;

    }

    public void AngleDown(float rotBull)
    {
        Vector3 rotDown = new Vector3(-rotBull,-rotBull,-rotBull);
        //transform.eulerAngle += rotDown;
    }
}
