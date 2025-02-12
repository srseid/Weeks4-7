using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 5;
    public bool hasBeenFired = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasBeenFired == true)
        {
            Movement();
        }
        else
        {
            PointAtMouse();
        }
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }

    void Movement()
    {
        transform.position += transform.up * speed * Time.deltaTime;
        
        //Vector3.up knows the world's up

        //transform.Translate(transform.up * speed * Time.deltaTime); 
        //does smth similar, just depends what u want
    }
    
}
