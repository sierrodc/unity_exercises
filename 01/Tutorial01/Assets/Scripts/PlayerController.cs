using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5f;
    public float TurnSpeed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontalAxis = Input.GetAxis("Horizontal");
        var verticalAxis = Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.forward * Time.deltaTime * this.Speed * verticalAxis);
        // this.transform.Rotate(Vector3.up, Time.deltaTime * this.TurnSpeed * horizontalAxis);
        var fulcrum = transform.TransformPoint(Vector3.forward * -3);
        this.transform.RotateAround(fulcrum, Vector3.up, Time.deltaTime * this.TurnSpeed * horizontalAxis);
    }
}
