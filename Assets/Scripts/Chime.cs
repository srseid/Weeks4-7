using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chime : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audioSource;
    public Transform oneAndSeven;
    public Transform twoAndEight;
    public Transform threeAndNine;
    public Transform fourAndTen;
    public Transform fiveAndEleven;
    public Transform sixAndTwelve;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
        
            //if (audioSource.isPlaying == false && transform.position == oneAndSeven.position)
                
            //{


            //    audioSource.PlayOneShot(clip);

            //}
        
        if(transform.Rotate(0,0,-30))
        
    }
}
