using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject playerBullets;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public float bulletSpawnTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void Fire()
    {
        Instantiate(playerBullets, spawnPoint1.position, Quaternion.identity);                        
        Instantiate(playerBullets, spawnPoint2.position, Quaternion.identity);
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(bulletSpawnTime);
            Fire();
        }
    }
}
