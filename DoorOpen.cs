using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
   public GameObject textDisplay;
    public float doorDistance=Distance_Target.distanceFromTarget;
    public GameObject door;
    public AudioSource doorSound;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       anim= door.GetComponent<Animator>();
        

    }

    // Update is called once per frame
    void Update()
    {
        doorDistance = Distance_Target.distanceFromTarget;
      
    }
    private void OnMouseOver()
    {
        if(doorDistance<=2)
        {
            textDisplay.GetComponent<Text>().text = "Press Button";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (doorDistance <= 2)
            {
                OpenDoor();
            }
        }
    }
    private void OnMouseExit()
    {
        textDisplay.GetComponent<Text>().text = " ";
    }
    void OpenDoor()
    {
        anim.enabled = true;
        
        StartCoroutine("OpenDoorAnimation");//starts the door animation and opens the door
        doorSound.Play();
        
      

    }
    IEnumerator OpenDoorAnimation()
    {
        yield return new WaitForSeconds(1.0f);
        anim.enabled = false;
        StartCoroutine("WaitDoorAnimation");
        // wait for 7  seconds before closing of door

    }
    IEnumerator WaitDoorAnimation()
    {
        yield return new WaitForSeconds(7.0f);
        anim.enabled = true;
        doorSound.Play();
        StartCoroutine("CloseDoorAnimation");

    }
    IEnumerator CloseDoorAnimation()
    {
        yield return new WaitForSeconds(1.0f);
        //closes the door after 7 sec
        anim.enabled = false;

    }
}
