using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen1 : MonoBehaviour
{
    public float doorDistance = Distance_Target.distanceFromTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        doorDistance = Distance_Target.distanceFromTarget;
    }
    private void OnTriggerStay(Collider other)
    {
        if(doorDistance<=1)
        {
            //Write code for opening of door by changing the rotion around a pivot and tick on trigger option in Box Collider
        }
    }
}
