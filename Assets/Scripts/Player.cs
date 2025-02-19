using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5;
    public GameObject start;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        //move left and right

        if (Input.GetKeyDown(KeyCode.Space))
        {



            //if pressing space, jump
        }


        if (Input.GetMouseButtonDown(1))
        {

            attack();
            //swing sword
        }
    }

    public void Respawn()
{
        Destroy(start);
        GameObject spawn = Instantiate(start, transform);

    }

    void attack()
    {

    }
}
