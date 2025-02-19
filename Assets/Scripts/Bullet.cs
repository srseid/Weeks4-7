using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2;
    //make speed variable default
    public float size;
    //make size variable default in inspector

  
    
    // Update is called once per frame
    void Update()
    {
        Vector3 Bulletposition = transform.position;
        Bulletposition.x += speed * Time.deltaTime;
       //move bullet on x axis
        transform.position = Bulletposition;
        //move bullet to the right

    }

   
    public void Fast(float fastBullet)
    {
        speed = fastBullet;
        //make bullet go faster

    }

    
}
