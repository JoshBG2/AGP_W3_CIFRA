using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public Transform ballSpawnPoint;
    public GameObject ballPrefab;
    public float ballSpeed = 17f;

    void Update()
    {
        // Setting Key Input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireCannon();
        }
    }

    void FireCannon()
    {
        // Instantiating Ball and RB
        GameObject ball = Instantiate(ballPrefab, ballSpawnPoint.position, ballSpawnPoint.rotation);
        Rigidbody ballRb = ball.GetComponent<Rigidbody>();

        // Setting Ball Trajectory
        Vector3 ballDirection = new Vector3 (0f, 4f, 10f).normalized;
        ballRb.AddForce(ballDirection * ballSpeed, ForceMode.Impulse);
    }
    

}
