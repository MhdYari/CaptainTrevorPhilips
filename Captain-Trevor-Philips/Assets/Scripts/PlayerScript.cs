using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 10f;
    public GameObject explosion;
    public GameObject gameOverPanel;
    public GameObject pausePanel;
    public CoinCounter coinCountScript; 
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
        float deltaY = Input.GetAxis("Vertical")*Time.deltaTime*speed;

        float newXpos = transform.position.x + deltaX;
        float newYpos = transform.position.y + deltaY;

        transform.position = new Vector2(newXpos, newYpos);

        Vector3 posX = transform.position;
        posX.x = Mathf.Clamp(posX.x,-2.5f,2.5f);
        transform.position = posX;

        Vector3 posY = transform.position;
        posY.y = Mathf.Clamp(posY.y,-5.5f,5.5f);
        transform.position = posY;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "EnemyBullet")
         {
            Destroy(gameObject);
            GameObject blast = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(blast, 2f);
            gameOverPanel.SetActive(true);
         }

         if (collision.gameObject.tag == "Coin")
         {
            Destroy(collision.gameObject);
            coinCountScript.AddCount(); 

         }
    }

    
}
