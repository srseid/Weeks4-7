using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

public class sword : MonoBehaviour
{
    //public SpriteRenderer appleSR;
    public GameObject door;
    public GameObject chest;
    public GameObject arrows;
    public GameObject apple;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
           
        }


    }

    public void collect()
    {
        Destroy(chest);
        GameObject opened = Instantiate(apple, transform);
        //appleSR.enabled = true;
        arrows.SetActive(true);
        //doorSR.enabled = false;
        Destroy(door);
    }
}
