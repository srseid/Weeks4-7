using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class KeyboardInputs : MonoBehaviour
{
    public float speed = 5;
    public GameObject SpeechBubble;
    public TextMeshProUGUI hi;

    public BoxCollider2D player;
    //public BoxCollider2D NPC;

    public Transform cupcake;
    public Transform chicken;

    public bool playerEncounter;

    // Start is called before the first frame update
    void Start()
    {
        SpeechBubble.SetActive(false);
        playerEncounter = false;
        player.enabled = true;
        
        cupcake.position = new Vector3(0,0, 0);
        chicken.position = new Vector3(5, -1,0);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.Translate(0, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);
        
       
        if (cupcake.position == chicken.position)
        {
            SpeechBubble.SetActive(true);
        }
        //if player is directly on top of NPC the box pops up, i'm having trouble figuring out how to have it pop up when the player is just near the NPC
    }

    
    void OnCollisionStay2D(Collision2D collision)
    {
        /*
        if (BoxCollider2D.player (collision))
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
