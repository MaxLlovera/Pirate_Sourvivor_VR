using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();
    public AudioSource audioSource;
    public AudioClip audiosword;
    public AudioClip audiobullet;
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
            Destroy(this.gameObject);
            audioSource.PlayOneShot(audiobullet);

        }
        else if (collision.collider.gameObject.tag == "Sword")
        {
            Destroy(this.gameObject);
            audioSource.PlayOneShot(audiosword);

        }
    }
}
