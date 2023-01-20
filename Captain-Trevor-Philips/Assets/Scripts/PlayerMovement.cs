using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
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

    
}
