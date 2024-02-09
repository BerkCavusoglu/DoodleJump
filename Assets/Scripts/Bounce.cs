using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float BounceForce;
    private Vector2 chspeed;
    private Rigidbody2D physics;

    void OnCollisionEnter2D(Collision2D other)
    {

            if (other.relativeVelocity.y <= 0) {
            physics = other.collider.GetComponent<Rigidbody2D>();

            if (physics != null)
            {
                chspeed = physics.velocity;
                chspeed.y = BounceForce;
                physics.velocity = chspeed;
            }
        }
    }

}
