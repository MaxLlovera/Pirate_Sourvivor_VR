using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileRed : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();
    public AudioSource audioSource;
    public AudioClip audioClip;
    private int life = 3;
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
        if (collision.collider.gameObject.tag == "Bullet" && life < 0) life--;
        if (life == 0)
        {
            Debug.Log("Toca");
            ScoreScript.scoreValue += 100;
            audioSource.PlayOneShot(audioClip);
            Destroy(this.gameObject);

        }
        //else if (collision.collider.gameObject.tag == "Sword")
        //{
        //    Destroy(this.gameObject);

        //}
    }
}

