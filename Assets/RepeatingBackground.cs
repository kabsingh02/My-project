using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public float speed;
    public float startX;
    public float endX;

    private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
        if (transform.position.x <= endX) {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }


}
