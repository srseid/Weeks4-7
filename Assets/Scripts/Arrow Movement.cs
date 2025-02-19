using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    float speed =5;
    bool clickChest = false;
    public Rigidbody2D rb;
    public Transform doorStop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (clickChest == true)
        {
            Vector3 arrowPos = transform.position;
            arrowPos.x += speed * Time.deltaTime;

            transform.position = arrowPos;
        }

        if(transform.position == doorStop.position)
        {
            clickChest = false;
            //rb.SetActive(false);
        }
    }

    public void collect()
    {
        clickChest = true;
    }
}
