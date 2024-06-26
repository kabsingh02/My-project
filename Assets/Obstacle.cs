using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;
    public int damage = 1;


    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")) {

        
            other.GetComponent<Player>().lives -= damage;
            Debug.Log(other.GetComponent<Player>().lives);
            Destroy(gameObject);
            
        }

    }


}