using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVectors : MonoBehaviour
{
    public Transform CubeLG;
    float distance;

    void Start()
    {
        transform.position = Vector3.forward;
    }
    void Update()
    {
        Vector3 directionfacing = (transform.position - CubeLG.transform.position);
        CubeLG.transform.position = directionfacing;

        distance = Vector3.Distance(transform.position, CubeLG.transform.position);
    }

    void OnDrawGizmos()
    {
        if (distance < 3)
        {
            Gizmos.color = Color.red;
        }
        else
        {
            Gizmos.color = Color.white;
        }

        Gizmos.DrawLine(transform.position, CubeLG.transform.position);
    }
}
