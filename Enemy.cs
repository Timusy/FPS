using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{ //stores health of Enemy
   public int EnemyHealth = 10;
    public GameObject Zombie;
    //deducts the health of enemy
    void DeductPoints(int DamageAmount)
    { 
        //Deducts the enemy health by damageAmount
        EnemyHealth -= DamageAmount;

    }
    private void Update()
    { 
        //Detsroys gameObject if enemy health less than or equls toS 0
        if(EnemyHealth<=0)
        {
            // Destroy(gameObject);
            this.gameObject.GetComponent<ZombieFollow>().enabled = false; //disab;es Zombie follow script;
            Zombie.GetComponent<Animation>().Play("Dying");
            StartCoroutine("DestroyAfter3Sec");
        }
    }
    IEnumerator DestroyAfter3Sec()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
