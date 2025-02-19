using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelSize : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }
    
        public void ScaleUp(float scaleBarrel)
        {

            Vector3 sizeUp = new Vector3(scaleBarrel, scaleBarrel, scaleBarrel);
            transform.localScale += sizeUp;
        //scale up the tank barrel when bullet does
        //put on parent so the barrel's anchor always stays the same

        

        }

        public void ScaleDown(float scaleBarrel)
        {
        
            Vector3 sizeDown = new Vector3(-scaleBarrel,-scaleBarrel,-scaleBarrel);
            transform.localScale += sizeDown;
            //scale down tank barrel when bullet does
        }
    

    
}
