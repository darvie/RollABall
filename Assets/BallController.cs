using System;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed;
    
    public void Start()
    {
        Debug.Log("Calling the Start method");

    }
    public void MoveBall(Vector2 input)
    {
         Vector3 inputXZPlane = new(input.x, 0, input.y);
         sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

}
