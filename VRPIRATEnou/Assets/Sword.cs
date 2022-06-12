using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject sword;
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(sword.GetComponent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = sword.transform.position;
        transform.rotation = Quaternion.Euler(sword.transform.rotation.x+90, sword.transform.rotation.y, sword.transform.rotation.z);
        if (ProjectileRed.soundSword || Projectile.soundSword || ProjectileBlue.soundSword)
        {
            audioSource.PlayOneShot(audioClip);
            ProjectileRed.soundSword = false;
            Projectile.soundSword = false;
            ProjectileBlue.soundSword = false;
        }
    }
}
