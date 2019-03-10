using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButton : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbObj;
    public Animator cube;
    // Start is called before the first frame update
    void Start()
    {
        vbObj = GameObject.Find("VirtualButton");
        vbObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cube.GetComponent<Animator>();
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.Play("cubeanimation");
        Application.OpenURL("http://www.facebook.com");
        Debug.Log("Pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.Play("none");
        Debug.Log("Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
