using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button : MonoBehaviour
{
    public GameObject buttonObject;
    public GameObject bird;
    bool buttonPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        buttonObject = GameObject.Find("VirtualButton");
        bird = GameObject.Find("blueJay"); 
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        buttonObject.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        buttonPressed = true;
        Debug.Log("Button pressed");
        
        bird.GetComponent<Animation>().Play(); 
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        buttonPressed = false;
        Debug.Log("Button released");
        bird.GetComponent<Animation>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
