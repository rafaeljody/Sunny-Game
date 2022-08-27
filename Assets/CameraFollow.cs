using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    //[Range(1, 10)]
    //public float smoothFactor;
    //public Vector3 minValues, maxValues;

    private void FixedUpdate()
    {
        transform.position = target.position + offset;
        //Follow();
    }

    //void Follow()
    //{
    //    // define min and max x,y,z values
    //    Vector3 targetPosition = target.position + offset;

    //    // verify if the target pos out of bound or not
    //    // limit it to tge min and max values

    //    Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
    //    transform.position = smoothPosition;

    //}
}
