using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] projectiles;
    public Transform[] points;
    private float timer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>6)
        {
            GameObject projectile = Instantiate(projectiles[Random.Range(0, 2)], points[Random.Range(0, 4)]);
            projectile.transform.localPosition = Vector3.zero;
            projectile.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));
            timer -= 6;
        }
        timer += Time.deltaTime;
    }
}
