
using UnityEngine;

// Use Transform.position to bounce a sphere.
// The sphere and a quad are colored using materials.

public class bouncy : MonoBehaviour
{
    Vector3 velocity = new Vector3(0.0f, 1.0f, 0.0f);
    float floorHeight = 0.0f;
    float sleepThreshold = 0.05f;
    float gravity = -9.8f;
    public Color sphereColor = Color.black;
   

    void Start()
    {
        transform.position = new Vector3(0.0f, 1.5f, 0.0f);

    }

    void FixedUpdate()
    {
        if (velocity.magnitude > sleepThreshold || transform.position.y > floorHeight)
        {
            velocity += new Vector3(0.0f, gravity * Time.fixedDeltaTime, 0.0f);
        }

        transform.position += velocity * Time.fixedDeltaTime;
        if (transform.position.y <= floorHeight)
        {
            transform.position = new Vector3(0.0f, floorHeight, 0.0f);
            velocity.y = -velocity.y;
                        
            if (sphereColor != Color.blue)
            {
                sphereColor = Color.blue;
            }
            else
            {
                sphereColor = Color.red;
            }

        }
    }
}