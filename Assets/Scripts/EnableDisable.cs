using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    public EnableDisable script;
    public GameObject go;
    public AudioSource audioSource;
    public AudioClip clip;
   
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            //sr.enabled = false;
            //sr.enabled =!sr.enabled; if it is false make true, if true make false

            //script.enabled = true;
            //activate script

            go.SetActive(false);
            //have gameObject active
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true;

            //script.enabled = true;
            
            go.SetActive(true);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (audioSource.isPlaying == false)
            {
                //    audioSource.Play();

                audioSource.PlayOneShot(clip);
                //just this code plays the sound every frame
                //playing sound in clip (inspector)
            }
        }
    }
}
