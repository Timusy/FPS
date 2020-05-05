using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    int healthDamage = 5; //gives damge of 5 units
   public float targetDistance; //stores the distance between player and the enemy
   public float damageDistance=15; //the maximum distance upto which damage can e inflicted
    public RaycastHit hit;
    public GameObject BulletHole;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (AmmoData.LoadedAmmoCount >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                RaycastHit shotdistance; // calculate the distance between enemy and player
                                         //first argument is the current location of player(gameObject),2nd argument is direction of light ray,3rd argument is variable used for raycast with "out" keyword,4th argument is the maxximum distance upto which light can travel
                if (Physics.Raycast(gameObject.transform.position, gameObject.transform.TransformDirection(Vector3.forward), out shotdistance, Mathf.Infinity))
                {
                    targetDistance = shotdistance.distance;
                    if (targetDistance < damageDistance)
                    {
                        //send this message to deduct point function of Enemy Class to deduct the health of enemy
                        shotdistance.transform.SendMessage("DeductPoints", healthDamage);
                    }
                    if(Physics.Raycast(gameObject.transform.position,gameObject.transform.TransformDirection(Vector3.forward),out hit,Mathf.Infinity))
                    {
                        Instantiate(BulletHole, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    }
                }
            }
        }
    }
}
