using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class youtube : MonoBehaviour,IVirtualButtonEventHandler
{
    public GameObject vbBtnObj;
    public Animator cubeAni;
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("virtual");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("cubenimation");
        Application.OpenURL("http://www.youtube.com");
        Debug.Log("Pressed");
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cubeAni.Play("none");
        Debug.Log("Released");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
