using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;


public class increasespeed : MonoBehaviour
{
    public tankmovement plus;
    
    //public Button increase;
    // Start is called before the first frame update
    void Start()
    {
        //Button inc = increase.GetComponent<Button>();
        //increase.onClick.AddListener(TaskOnClick);
        //gameObject.GetComponent<Button>().onClick.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        Debug.Log("I am Speed!!");
        //plus();
        
    }

    
}
