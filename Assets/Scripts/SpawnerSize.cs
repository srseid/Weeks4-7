using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSize : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScaleUp(float scaleBullet)
    {
        Vector3 sizeUp = new Vector3(scaleBullet, scaleBullet, scaleBullet);
        transform.localScale += sizeUp;
     //make sprite bullet bigger when pressed   
    }
    
    public void ScaleDown(float scaleBullet)
    {
        Vector3 sizeDown = new Vector3(-scaleBullet, -scaleBullet, -scaleBullet);
        transform.localScale += sizeDown;
       //make sprite bullet smaller when pressed
    }
    
   
}
