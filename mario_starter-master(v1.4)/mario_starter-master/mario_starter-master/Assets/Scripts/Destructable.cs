using UnityEngine;
using System.Collections;

public class Destructable : MonoBehaviour
{
    // if player touches block the block will be destroyed
    void OnControllerColliderHit(ControllerColliderHit other)
    {
        if (other.collider.gameObject.tag == "PlatformBlock")
        {
            Destroy(other.gameObject);    
            
        }
        
    }
   
	
	// Update is called once per frame
	void Update () 
    {
        
	}
}
