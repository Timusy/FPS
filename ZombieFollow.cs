using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow : MonoBehaviour
{
    public GameObject player;
    public float distance;
    public float allowedRange = 10;
    public GameObject Enemy;
    public float moveSpeed;
    public int AttackTrigger;//by default attack trigger is set ti zero soit will start walking towards palyer once the palyer is the allowed range
    public RaycastHit shot;
    public bool canMove;
    public int isAttacking;
    public GameObject ScreenSplash;
    public AudioSource hurt1;
    public AudioSource hurt2;
    public AudioSource hurt3;
    public int HurtSound;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnBecameVisible()
    {
        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot, Mathf.Infinity))
        {
            distance = shot.distance;
            if (distance <= allowedRange )
            {
                moveSpeed = 0.02f;
                //starts walking if the player is in trigger range of enemy
                if (AttackTrigger == 0)
                {
                    Enemy.GetComponent<Animation>().Play("Walking");
                    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, moveSpeed);
                }
            }
            else
            {
                moveSpeed = 0;
                Enemy.GetComponent<Animation>().Play("Idle");


            }
        }

        //attacks the palyer if attack trigger is 1
        if (AttackTrigger == 1)
        {
            if(isAttacking==0)
            {
                StartCoroutine("EnemyDamage");
            }
            moveSpeed = 0;
            Enemy.GetComponent<Animation>().Play("Attacking");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        AttackTrigger = 1;
    }
    private void OnTriggerExit(Collider other)
    {
        AttackTrigger = 0;

    }
    IEnumerator EnemyDamage()
    {
        isAttacking = 1;
        HurtSound = Random.Range(1, 4);
        yield return new WaitForSeconds(0.9f);
        ScreenSplash.SetActive(true);
        PlayerHealth.Playerhealth -= 2;
        if (HurtSound == 1)
        {
            hurt1.Play();
        }
         if (HurtSound == 2)
        {
            hurt2.Play();
        }
        if(HurtSound == 2)
        {
            hurt3.Play();
        }
        yield return new WaitForSeconds(0.1f);
        ScreenSplash.SetActive(false);
        yield return new WaitForSeconds(1);
        isAttacking = 0;
    }
}
