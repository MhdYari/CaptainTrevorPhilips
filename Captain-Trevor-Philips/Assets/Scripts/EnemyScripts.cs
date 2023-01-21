using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{
    public GameObject EnemyBullets;
    public Transform gunPoint1;
    public Transform gunPoint2;
    public float enemyBulletSpawnTime = 0.5f;
    public float speed = 3f;
    public GameObject enemyExplosionPrefab;
    public GameObject coinPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyShoot());
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.down * speed * Time.deltaTime);  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerBullet")
        {
            Destroy(gameObject);
            GameObject enemyExplosion = Instantiate(enemyExplosionPrefab, transform.position, Quaternion.identity);
            Destroy(enemyExplosion, 0.5f);
            Instantiate(coinPrefabs, transform.position, Quaternion.identity);

        }
    }

    void EnemyFire()
    {
        Instantiate(EnemyBullets, gunPoint1.position, Quaternion.identity);                        
        Instantiate(EnemyBullets, gunPoint2.position, Quaternion.identity);
    }

    IEnumerator EnemyShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(enemyBulletSpawnTime);
            EnemyFire();
        }
    }
}
