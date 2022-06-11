using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] projectiles;
    public Transform[] points;
    private float timer;
    private int counter = 0;
    private int spawnTimer = 8;
    public AudioSource audioSource;
    public AudioClip audioClip;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((timer> spawnTimer) && counter < 2)
        {
            GameObject projectile = Instantiate(projectiles[0], points[Random.Range(0, 2)]);
            projectile.transform.localPosition = Vector3.zero;
            audioSource.PlayOneShot(audioClip);
            timer -= spawnTimer;
            counter++;
        }
        if (counter == 5) { spawnTimer = 6; }
        if (counter == 10) { spawnTimer = 4; }
        if ((timer > spawnTimer) && counter == 2)
        {
            GameObject projectile = Instantiate(projectiles[1], points[2]);
            projectile.transform.localPosition = Vector3.zero;
            audioSource.PlayOneShot(audioClip);
            counter++;
        }

        timer += Time.deltaTime;
    }
}
