using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent : MonoBehaviour
{
    public float maxSpeed;
    public float maxAccel;
    public float orientation;
    public float rotation;
    public Vector3 velocity;
    protected Steering steering;
    // Start is called before the first frame update
    void Start()
    {
        velocity = Vector3.zero;
        steering = new Steering();
        
    }
    public void SetSteering(Steering steering) {
        this.steering = steering;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 displacement = velocity * Time.deltaTime;
        orientation += rotation * Time.deltaTime;
        if(orientation < 0.0f) {
            orientation += 360.0f;

        }else if(orientation > 360.0f) {
            orientation -= 360.0f;
        }
        transform.Translate(displacement,Space.World);
        transform.rotation = new Quaternion();
        transform.Rotate(Vector2.up, orientation);
    }   
    private void LateUpdate() {
        velocity += steering.linear * Time.deltaTime;
        rotation += steering.angular * Time.deltaTime;
        if(velocity.magnitude > maxSpeed) {
            velocity.Normalize();
            velocity = velocity * maxSpeed;
        }
        if(steering.angular == 0.0f) {
            rotation = 0.0f;
        }
        if(steering.linear.sqrMagnitude == 0.0f) {
            velocity = Vector2.zero;
        }
        steering = new Steering();
    }
}
