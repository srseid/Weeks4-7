using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2;
    public float size;
    public float Ang;

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
        transform.eulerAngles = Vector3.zero;
        

    }


    public void ScaleUp(float scaleBullet)
    {
        
        Vector3 sizeUp = new Vector3(scaleBullet, scaleBullet, scaleBullet);
        transform.localScale += sizeUp;
        
    }

    public void ScaleDown(float scaleBullet)
    {
        Vector3 sizeDown = new Vector3(-scaleBullet, -scaleBullet, -scaleBullet);
        transform.localScale += sizeDown;
    }

    public void RotateBullet(float angle)
    {
        Vector3 rotUp = new Vector3(angle, angle, -angle);
        transform.eulerAngles += rotUp;
    }
}
