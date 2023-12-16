using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   public float impactForceV = 2f;
   public float impactForceH = 2f;
   public float enemySpeed = 1f;
   public Rigidbody rb;
   public Renderer colorRenderer;
   private bool impact;
   public float delayDestroy = 2f;
   

   // Enemy Collision
    void OnCollisionEnter(Collision impactEnemy)
    {
        if(impactEnemy.gameObject.tag == "Cannon Ball")
        {
            colorRenderer.material.color = Color.black;
            impact = true;
        }
    }

    // Enemy Movement
    void FixedUpdate()
    {
        rb.AddForce(-Vector3.forward * enemySpeed);

        if (impact)
        {
            rb.AddForce(Vector3.up * impactForceV, ForceMode.Impulse);
            rb.AddForce(Vector3.forward * impactForceH, ForceMode.Impulse);

            Invoke("DestroyGameObject", delayDestroy);
        }
    }

    // Destroying Game Object
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }

    
}
