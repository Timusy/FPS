using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
    public AudioSource ammoPickup;
    public int AmmoToAdd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (AmmoData.LoadedAmmoCount == 0)
        {
            ammoPickup.Play();
            AmmoData.LoadedAmmoCount += AmmoToAdd;
            AmmoData.CurrentAmmoCount = 0;
            this.gameObject.SetActive(false);
        }

        else
        {
            ammoPickup.Play();
            AmmoData.CurrentAmmoCount += AmmoToAdd;
            this.gameObject.SetActive(false);
        }
    }
}
