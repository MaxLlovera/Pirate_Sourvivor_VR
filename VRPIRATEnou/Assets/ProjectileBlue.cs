using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBlue : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();
    public AudioSource audioSource;
    public AudioClip audioClip;
    private int life = 2;
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
        if (collision.collider.gameObject.tag == "Bullet" && life > 0)
        {
            life--;
            audioSource.PlayOneShot(audioClip);
        }
        if (collision.collider.gameObject.tag == "Bullet" && life == 0)
        {
            ScoreScript.scoreValue += 25;
            soundExplosion = true;
            Destroy(this.gameObject);
        }
        if (collision.collider.gameObject.tag == "Sword" && life == 0)
        {
            ScoreScript.scoreValue += 25;
            soundSword = true;
            Destroy(this.gameObject);
        }
        if (collision.collider.gameObject.tag == "Sword" && life > 0)
        {
            life--;
            soundSword = true;
        }
        if (collision.collider.gameObject.tag == "Dead")
        {
            Spawner.counter = 0;
            Spawner.spawnTimer = 8;
            ScoreScript.scoreValue = 0;
            soundDead = true;
            Destroy(this.gameObject);

        }
    }
}