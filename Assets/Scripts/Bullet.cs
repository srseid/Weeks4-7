using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2;
    //public float angle = 1;
    //public float size = 1;

    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        //pos.y += speed * Time.deltaTime;
        transform.position = pos;
/*
        Vector3.one rot = transform.rotation;
        rot.z += angle;
        transform.rotation = rot;

        Vector2 scale = transform.LocalScale;
        scale.x += size * 2;
        transform.LocalScale = scale;
*/
    }
    /*
    public void Increase(float size)
    {
        spriteRenderer.transform.localScale = new Vector3(2f, 2f, 2f);
    }

    public void Decrease(float size)
    {
        spriteRenderer.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
    }
    */
}
