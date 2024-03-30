using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBounds : MonoBehaviour

{
    public static TargetBounds Instance;

    void Awake()
    {
        Instance = this;    
    }


    [SerializeField] BoxCollider col;

    // Update is called once per frame
    public Vector3 GetRandomPos()
    {
        Vector3 center = col.center + transform.position;

        float minX = center.x - col.size.x / 2f;
        float maxX = center.x + col.size.x / 2f;

        float minY = center.y - col.size.y / 2f;
        float maxY = center.y + col.size.y / 2f;

        float minZ = center.z - col.size.z / 2f;
        float maxZ = center.z + col.size.z / 2f;

        float randX = Random.Range(minX, maxX);
        float randY = Random.Range(minY, maxY);
        float randZ = Random.Range(minZ, maxZ);

        Vector3 RandomPos = new Vector3(randX, randY, randZ);

        return RandomPos;
    }

}
