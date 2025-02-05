using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class KeyboardInputs : MonoBehaviour
{
    public float speed = 5;
    public GameObject SpeechBubble;

    public BoxCollider2D player;
    public BoxCollider2D NPC;

    // Start is called before the first frame update
    void Start()
    {
        SpeechBubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);

        
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        /*if (BoxCollider2D.isTouching(collision))
        {
            SpeechBubble.SetActive(true);
        }
        */
        if( collision.gameObject.tag == "Chicken")
        {
            SpeechBubble.SetActive(true);
        }
   
    }
}
