using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunPickUp_MachineGun : MonoBehaviour
{
    public GameObject GunMechanics;
   public float distanceFromGun = Distance_Target.distanceFromTarget; //stores distance from gun
   public GameObject TextDisplay; //Displays the type of gun picked
   public GameObject VirualGun; //disables the gun which was placed on table 
   public GameObject RealGun; // enables the gun which was in hand
    public GameObject AmmoDisplay;
    public GameObject CrossHair;
    public AudioSource GunPick;
    public GameObject pistol;
    //disables cross hair
    // Update is called once per frame
    void Update()
    {
        distanceFromGun = Distance_Target.distanceFromTarget;
       
    }
    private void OnMouseOver()
    {
        if (distanceFromGun <= 2)
        {
            TextDisplay.GetComponent<Text>().text = "Machine Gun";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (distanceFromGun <= 2)
            {
                GunPickUp();
                GunMechanics.SetActive(true);
            }
        }



    }
    private void OnMouseExit()
    {
        if (distanceFromGun <= 2)
        {
            TextDisplay.GetComponent<Text>().text = " ";
        }



    }
    void GunPickUp()
    {
        transform.position = new Vector3(0, -100000, 0);
        GunPick.Play();
        pistol.SetActive(false);
        VirualGun.SetActive(false);
        RealGun.SetActive(true);
        AmmoDisplay.SetActive(true);
        CrossHair.SetActive(true);
    }
}
