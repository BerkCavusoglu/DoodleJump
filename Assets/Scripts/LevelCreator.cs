using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour
{
    public GameObject platformObject;
    public int platforms;
    public float minX, maxX;
    public float minY, maxY;

    void Start()
    {
        Vector3 clonePosition = new Vector3();
        for(int i = 0; i < platforms; i++)
        {
            clonePosition.x = Random.Range(minX, maxX);
            clonePosition.y = Random.Range(minY, maxY);
            Instantiate (platformObject, clonePosition, Quaternion.identity);
        }
    }

}
