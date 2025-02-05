using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InteractMe : MonoBehaviour
{
    public GameObject SpeechBubble;
    public TextMeshProUGUI hi;
    // Start is called before the first frame update
    void Start()
    {
        SpeechBubble.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SpeechBubble.SetActive(true);
        }
    }
}
