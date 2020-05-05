using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarMonitor : MonoBehaviour
{
    public GameObject health4;
    public GameObject health3;
    public GameObject health2;
    public GameObject health1;
    public GameObject health0;
    public int CurrentHealthCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealthCount = PlayerHealth.Playerhealth;
      //  Debug.Log(CurrentHealthCount);
        if(CurrentHealthCount==8)

        {
            if(health4.transform.localScale.y<=0.0f)
            {
                health4.SetActive(false);
            }
            else
            {
                health4.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            }

        }
        if (CurrentHealthCount == 6)

        {
            if (health3.transform.localScale.y <= 0.0f)
            {
                health3.SetActive(false);
            }
            else
            {
                health3.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            }

        }
        if (CurrentHealthCount == 4)

        {
            if (health2.transform.localScale.y <= 0.0f)
            {
                health2.SetActive(false);
            }
            else
            {
                health2.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            }

        }
        if (CurrentHealthCount == 2)

        {
            if (health1.transform.localScale.y <= 0.0f)
            {
                health1.SetActive(false);
            }
            else
            {
                health1.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            }

        }
        if (CurrentHealthCount == 0)

        {
            if (health0.transform.localScale.y <= 0.0f)
            {
                health0.SetActive(false);
            }
            else
            {
                health0.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
            }

        }

    }
}
