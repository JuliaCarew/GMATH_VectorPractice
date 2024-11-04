using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVectors : MonoBehaviour
{
    public Transform CubeLG;
    public float rangeChangeColor = 3.0f;

    void Start()
    {
        transform.position = Vector3.forward;
    }

    void OnDrawGizmos()
    {
        Vector3 directionfacing = (transform.position - CubeLG.transform.position).normalized;
        CubeLG.transform.forward = directionfacing;
        directionfacing.Normalize();

        Gizmos.DrawLine(directionfacing, transform.position);
        Vector3 scaled = directionfacing * 2;

        float distance = directionfacing.magnitude;
   
        if (distance < rangeChangeColor)
        {
            Gizmos.color = Color.red;
        }
        else
        {
            Gizmos.color = Color.white;
        }
    }
}
