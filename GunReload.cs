using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunReload : MonoBehaviour
{
    public AudioSource reloadSound;
    public GameObject crossHair;
    public GameObject mechanics;
    public int loadedAmmo;
    public int AmmoCapacity; //Specifies capacity of ammo
    //stores the loaded ammo
    public int spareAmmo;
    //stores the current ammo count

    public int ReloadAvailable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loadedAmmo = AmmoData.LoadedAmmoCount;
        spareAmmo = AmmoData.CurrentAmmoCount;
        if(spareAmmo==0)
        {
            ReloadAvailable = 0;
        }
        else
        { 
            //Amount of ammo to be reloaded
            ReloadAvailable = AmmoCapacity - loadedAmmo;
        }
        if (Input.GetButtonDown("Reload"))
        {
            if (ReloadAvailable >= 1)
            {
                if (spareAmmo <= ReloadAvailable)
                {
                    AmmoData.LoadedAmmoCount += spareAmmo;
                    AmmoData.CurrentAmmoCount -= spareAmmo;
                    reloadSound.Play();
                    ReloadAction();
                }
                else
                {
                    AmmoData.LoadedAmmoCount += ReloadAvailable;
                    AmmoData.CurrentAmmoCount -= ReloadAvailable;
                    reloadSound.Play();
                    ReloadAction();
                }
            }

           
        }
        else
        {
            EnableScripts();
        }

    }
    void ReloadAction()
    {
        this.gameObject.GetComponent<GunFire>().enabled = false; //disables gun fire script on the gun
        crossHair.SetActive(false); //disables cross hair
        mechanics.SetActive(false);
        reloadSound.Play();
        this.gameObject.GetComponent<Animation>().Play("GunReload");

    }
    void EnableScripts()
    {
        StartCoroutine("WaitAtRelaodingTime");
        this.gameObject.GetComponent<GunFire>().enabled = true; //enables gun fire script on the gun
        crossHair.SetActive(true); //enables cross hair
        mechanics.SetActive(true);

    }
    IEnumerator WaitAtReloadingTime()
    {
        yield return new WaitForSeconds(1.2f);
        
        

    }
}
