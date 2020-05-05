using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunFire : MonoBehaviour
{
    public GameObject MachineGun;
    public AudioSource MachinegunFire;
    public GameObject MuzzleFlash;
    public int AmmoCount; 
    public int firing;
    public GameObject CrossHair;
    /*public GameObject TopCrossHair;
    public GameObject BottomCrossHair;
    public GameObject RightCrossHair;
    public GameObject LeftCrossHair;*/


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AmmoCount = AmmoData.LoadedAmmoCount;
        if(Input.GetButton("Fire1"))
        {
            if(AmmoCount>=1)
            {
                if (firing == 0)
                {
                    Fire();
                }
            }
        }
        
    }
    void Fire()
    {
        firing = 1;

        Animator anim = CrossHair.GetComponent<Animator>();
        anim.enabled = true;

       /* Animator anim = TopCrossHair.GetComponent<Animator>();
        anim.enabled = true;
        Animator anim1 = BottomCrossHair.GetComponent<Animator>();
        anim1.enabled = true;
        Animator anim2 = RightCrossHair.GetComponent<Animator>();
        anim2.enabled = true;
        Animator anim3 = LeftCrossHair.GetComponent<Animator>();
        anim3.enabled = true;*/
        AmmoData.LoadedAmmoCount -= 1;
        MachinegunFire.Play();
        MuzzleFlash.SetActive(true);
        MachineGun.GetComponent<Animator>().enabled = true;
        StartCoroutine("MachineGunDelay");
        


    }
    IEnumerator MachineGunDelay()
    {
        yield return new WaitForSeconds(0.1f);
        MuzzleFlash.SetActive(false);
        MachineGun.GetComponent<Animator>().enabled = false;

        Animator anim = CrossHair.GetComponent<Animator>();
        anim.enabled = false;
        /*Animator anim = TopCrossHair.GetComponent<Animator>();
        anim.enabled = false;
        Animator anim1 = BottomCrossHair.GetComponent<Animator>();
        anim1.enabled = false;
        Animator anim2 = RightCrossHair.GetComponent<Animator>();
        anim2.enabled = false;
        Animator anim3 = LeftCrossHair.GetComponent<Animator>();
        anim3.enabled = false;*/
        firing = 0;

    }
}
