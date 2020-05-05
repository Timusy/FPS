using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject player;
    public GameObject Enemy;
    public float EnemySpeed;
    public int MoveTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MoveTrigger <= 1)
        {
            EnemySpeed = 0.02f;
            //moves from current positon to target position
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, EnemySpeed);
        }
    }
}
