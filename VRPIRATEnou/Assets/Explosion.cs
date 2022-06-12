using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ProjectileRed.soundExplosion || Projectile.soundExplosion || ProjectileBlue.soundExplosion)
        {
            audioSource.PlayOneShot(audioClip);
            ProjectileRed.soundExplosion = false;
            Projectile.soundExplosion = false;
            ProjectileBlue.soundExplosion = false;
        }
    }
}
