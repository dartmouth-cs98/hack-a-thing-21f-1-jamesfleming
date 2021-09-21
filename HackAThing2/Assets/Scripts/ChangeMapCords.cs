using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus;
using OculusSampleFramework;
using Mapbox.Unity.Map;
using Mapbox.Utils;

public class ChangeMapCords : MonoBehaviour
{
    public float Lat = 0.0f;
    public float Long = 0.0f;
    public float zoom = 13.0f;
    private DistanceGrabbable grabbable;
    public float panSpeed = 0.0001f;
    public AbstractMap map;
    private Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
        start = this.transform.localPosition;
        grabbable = GetComponent<DistanceGrabbable>();
        
        
    }

    // Update is called once per frame
    void Update()
    {   

        // While the user is grabbing ball
        if (grabbable.isGrabbed){
           

            // Calculate in which direction we have moved the ball
            float DX = (start.x - transform.position.x);
            float DZ = (start.z - this.transform.position.z);
            float DY = start.y - this.transform.position.y;
            

            // CHange our Lat Long based on the ball position
            if (DX > 0){
                Long += panSpeed;

            }else{
                Long -= panSpeed;
            }
            
            if (DZ>0){
                Lat += panSpeed;
            }else{
                Lat -= panSpeed;
            }
            // Update the map
             map.UpdateMap(new Vector2d(Lat, Long));



        }else{
            // Reset to center, kinda like a joystick
            this.transform.position = start;
        }      
    }
}
