using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] projectiles;
    public Transform[] points;
    public float timer;
    public static int counter = 0;
    public static int spawnTimer = 8;
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((timer> spawnTimer) && counter < 15)
        {
            GameObject projectile = Instantiate(projectiles[Random.Range(0, 2)], points[Random.Range(0, 2)]);
            projectile.transform.localPosition = Vector3.zero;
            audioSource.PlayOneShot(audioClip);
            timer -= spawnTimer;
            counter++;
        }
        if (counter == 5) { spawnTimer = 6; }
        if (counter == 10) { spawnTimer = 4; }
        if ((timer > spawnTimer) && counter == 15)
        {
            GameObject projectile = Instantiate(projectiles[2], points[2]);
            projectile.transform.localPosition = Vector3.zero;
            audioSource.PlayOneShot(audioClip);
            counter++;
        }

        timer += Time.deltaTime;
    }
}
