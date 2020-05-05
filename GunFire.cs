using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public static int totalammo;
    public GameObject gunFlash;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         totalammo = AmmoData.LoadedAmmoCount + AmmoData.CurrentAmmoCount;
            if (AmmoData.LoadedAmmoCount > 0 )
        {
            if (Input.GetButtonDown("Fire1"))
            {
                //if fire button is pressed then gunshot audio gets activated
                AudioSource gunShot = gameObject.GetComponent<AudioSource>();
                gunShot.Play();
                gunFlash.SetActive(true);
                MuzzleFlashOff();
                
                //if fire button is pressed then gunshot animation(recoil of gun) gets activated
                Animation gunAnim = gameObject.GetComponent<Animation>();
                gunAnim.Play("GunShot");
                //reduces the ammo count by1 after firing
                AmmoData.LoadedAmmoCount -= 1;
                totalammo -= 1;

            }
        }
        
    }
    void MuzzleFlashOff()
    {
        StartCoroutine("FlashTime");
       // 
    }
    IEnumerator FlashTime()
    {
        yield return new WaitForSeconds(0.1f);
        gunFlash.SetActive(false);
    }
}
