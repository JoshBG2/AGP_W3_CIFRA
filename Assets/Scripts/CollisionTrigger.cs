using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour
{
    // Destroying Ball on Enemy Collision
    void OnCollisionEnter(Collision ballCollided)
    {
        if (ballCollided.gameObject.tag == "Enemies" || ballCollided.gameObject.tag == "Back Wall")
        {
            Destroy(gameObject);
        }
        
    }
}
