using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaner : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        float randomX = Random.Range(-12f, 12f);
        float randomY = 12f;

        if (other.tag == "Platform")
        {
            other.transform.position = new Vector3(randomX,other.transform.position.y + randomY, other.transform.position.z);
        }
    }
}
