using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SawController : MonoBehaviour
{
    public float rotationSpeed;

    private void Awake()
    {
        
    }
    private void FixedUpdate()
    {
        transform.Rotate(0,0,rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);

            GameManager.instance.GameOver();
        }

        if(collision.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
            GameManager.instance.IncreatmentScore();
        }
    }
}
