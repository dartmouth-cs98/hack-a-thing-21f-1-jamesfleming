using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    public GameObject images;
    // Start is called before the first frame update
    void Start()
    {
        images.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other){
        if (other.tag == "Marker"){
            Debug.Log("Hit");
                images.SetActive(true);
        }

    }
}
