using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHairAnimation : MonoBehaviour
{
    public GameObject CrossHair;
  /* public GameObject TopCrossHair;
   public GameObject BottomCrossHair;
   public GameObject RightCrossHair;
   public GameObject LeftCrossHair;*/
    // Start is called before the first frame update
    void Start()
    {

        Animator anim = CrossHair.GetComponent<Animator>();
        anim.enabled = false;

        /*Animator anim = TopCrossHair.GetComponent<Animator>();
        anim.enabled = false;

        /*Animator anim = TopCrossHair.GetComponent<Animator>();
        anim.enabled = false;
        Animator anim1 = BottomCrossHair.GetComponent<Animator>();
        anim1.enabled = false;
        Animator anim2 = RightCrossHair.GetComponent<Animator>();
        anim2.enabled = false;
        Animator anim3 = LeftCrossHair.GetComponent<Animator>();
        anim3.enabled = false;*/

    }

    // Update is called once per frame
    void Update()
    {
        if ( AmmoData.LoadedAmmoCount>=0)
        {
            //Activates the animation of crosshair when gun is fired
            if (Input.GetButtonDown("Fire1"))
            {
                Animator anim = CrossHair.GetComponent<Animator>();
                anim.enabled = true;

                /*Animator anim = TopCrossHair.GetComponent<Animator>();
                anim.enabled = true;
                Animator anim1 = BottomCrossHair.GetComponent<Animator>();
                anim1.enabled = true;
                Animator anim2 = RightCrossHair.GetComponent<Animator>();
                anim2.enabled = true;
                Animator anim3 = LeftCrossHair.GetComponent<Animator>();
                anim3.enabled = true;*/
                StartCoroutine("WaitingAnim");

            }
        }
    }
    IEnumerator WaitingAnim()
    {
        yield return new WaitForSeconds(0.1f);
        Animator anim = CrossHair.GetComponent<Animator>();
        anim.enabled = false;

        /*Animator anim = TopCrossHair.GetComponent<Animator>();
        anim.enabled = false;
        Animator anim1 = BottomCrossHair.GetComponent<Animator>();
        anim1.enabled = false;
        Animator anim2 = RightCrossHair.GetComponent<Animator>();
        anim2.enabled = false ;
        Animator anim3 = LeftCrossHair.GetComponent<Animator>();
        anim3.enabled = false;*/


    }
}
