using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PointHealer : MonoBehaviour
{
   
    private GameObject[] players;

    public float distance = 5f;

    void Start()
    {
        players = GameObject.FindGameObjectsWithTag("Player");
    }


    void FixedUpdate()
    {
        foreach (var player in players)
        {
            
            var hp = player.GetComponent<PlayerStats>();
            if (Vector3.Distance(player.transform.position, transform.position) <= distance && hp.healthPoints < 100)
            {
                hp.healthPoints += 1;
                Debug.Log(hp.healthPoints);
            }
        }
    }
}
