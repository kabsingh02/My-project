using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject[] ObstaclePatterns;

    private float timeSpawn;
    public float startTimeSpawn;

    private void Update() {


        if (timeSpawn <= 0) {
            int random = Random.Range(0, ObstaclePatterns.Length);
            Instantiate(ObstaclePatterns[random], transform.position, Quaternion.identity);
            timeSpawn = startTimeSpawn;
        }
        else {
            timeSpawn -= Time.deltaTime;
        }
    }
}