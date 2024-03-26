using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int lives = 3;


    private void Update() {
        if (lives <= 0){
            SceneManager.LoadScene("GameOverScene");
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < maxHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > minHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}






