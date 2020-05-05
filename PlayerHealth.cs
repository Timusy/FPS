using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public static int Playerhealth=10;
    public int health;
    public GameObject healthDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = Playerhealth;
        healthDisplay.GetComponent<Text>().text = " " + health;
        if(Playerhealth==0)
        {
            SceneManager.LoadScene(1);
        }
        
    }
}
