using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class tankmovement : MonoBehaviour
{
    public float tankSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * tankSpeed * Time.deltaTime, 0, 0);
    }

    public void increaseSpeed()
    {
        tankSpeed += 1;
    }



    public void decreaseSpeed()
    {
        tankSpeed -= 1;
    }
}
