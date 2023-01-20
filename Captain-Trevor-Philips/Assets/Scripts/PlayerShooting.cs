using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject playerBullets;
    public Transform spawnPoint1;
    public Transform spawnPoint2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(playerBullets, spawnPoint1.position, Quaternion.identity);                        
            Instantiate(playerBullets, spawnPoint2.position, Quaternion.identity);

        }
    }
}
