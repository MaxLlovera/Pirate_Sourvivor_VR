using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();
    public AudioSource audioSource;
    public AudioClip audioClip;
    public static bool soundDead = false;
    public static bool soundSword = false;
    public static bool soundExplosion = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * 30;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.tag == "Bullet")
        {
            ScoreScript.scoreValue += 10;
            soundExplosion = true;
            Destroy(this.gameObject);

        }
        if (collision.collider.gameObject.tag == "Sword")
        {
            ScoreScript.scoreValue += 10;
            soundSword = true;
            Destroy(this.gameObject);

        }
        if (collision.collider.gameObject.tag == "Dead")
        {
            Spawner.counter = 0;
            Spawner.spawnTimer = 8;
            ScoreScript.scoreValue = 0;
            soundDead = true;
            Destroy(this.gameObject);

        }
        //else if (collision.collider.gameObject.tag == "Sword")
        //{
        //    Destroy(this.gameObject);

        //}
    }
}
