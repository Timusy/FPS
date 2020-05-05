using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoData : MonoBehaviour
{
     
    public static int CurrentAmmoCount;
    public int CurrentAmmoCountEquivalent;
    public GameObject AmmoCountDisplay;
    public static int LoadedAmmoCount=6;
    public int LoadedAmmoCountEquivalent;
    public GameObject LoadedCountDisplay;
    int pistolCapacity = LoadedAmmoCount;
//stores the capacity of pistol
// Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        LoadedAmmoCountEquivalent = LoadedAmmoCount;
       
        CurrentAmmoCountEquivalent = CurrentAmmoCount;
        AmmoCountDisplay.GetComponent<Text>().text = " " + CurrentAmmoCountEquivalent;
        LoadedCountDisplay.GetComponent<Text>().text = " " + LoadedAmmoCountEquivalent;

    }
}
