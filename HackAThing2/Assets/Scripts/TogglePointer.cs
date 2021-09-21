using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus; 

public class TogglePointer : MonoBehaviour
{
    public GameObject pointer;
    bool on = false;
    // Start is called before the first frame update
    void Start()
    {
        pointer.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One)){
            on = !on;
            if (on){
                pointer.SetActive(true);
            
            }else{
                pointer.SetActive(false);
            }

        }
        
    }
}
