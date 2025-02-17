using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSize : MonoBehaviour
{
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScaleUp(float scaleBarrel)
    {

        Vector3 sizeUp = new Vector3(scaleBarrel, scaleBarrel, scaleBarrel);
        transform.localScale += sizeUp;

    }

    public void ScaleDown(float scaleBarrel)
    {
        Vector3 sizeDown = new Vector3(-scaleBarrel,-scaleBarrel,-scaleBarrel);
        transform.localScale += sizeDown;
    }
}
