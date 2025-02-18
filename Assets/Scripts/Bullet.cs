using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2;
    //make speed variable
    public float size;
    //make size variable
    public float Ang = 1f;
    //Rigidbody2D rb;
    //make angle variable



    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<RigidBody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
       
        transform.position = pos;
        //move bullet to the right

       

    }

    void FixedUpdate()
    {
        //rb.MoveRotation(rb.rotation + Input.getAxisRaw("Horizontal"));

    }
    public void ScaleUp(float scaleBullet)
    {
        
        Vector3 sizeUp = new Vector3(scaleBullet, scaleBullet, scaleBullet);
        transform.localScale += sizeUp;
        //increase size by pressing button

        if (transform.localScale == new Vector3(9, 9, 9))
        {

        }
    }

    public void ScaleDown(float scaleBullet)
    {
        Vector3 sizeDown = new Vector3(-scaleBullet, -scaleBullet, -scaleBullet);
        transform.localScale += sizeDown;
        //decrease size by pressing button
        
    }

    public void RotateBullet(float angle)
    {
        //Vector3 rotUp = new Vector3(angle, angle, angle);
        //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 25f);

        //transform.Rotate(0,0,angle * Time.deltaTime);

        //transform.position += transform.up * speed * Time.deltaTime;
       
        //transform.localEulerAngles = new Vector3(0,0,(+25));
        Ang=angle;
        pos.y += speed * Time.deltaTime * angle;
    }

    public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo = Space.Self)
    {
}
