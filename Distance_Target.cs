using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance_Target : MonoBehaviour
{
    public static float distanceFromTarget;
    //equivalence of distance from target
    public float targetDistance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(gameObject.transform.position,gameObject.transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
        {
            targetDistance= hit.distance;
            distanceFromTarget = targetDistance;

        }

        
    }
}
