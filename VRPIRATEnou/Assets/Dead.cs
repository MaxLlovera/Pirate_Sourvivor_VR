using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
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
        if(ProjectileRed.soundDead|| Projectile.soundDead|| ProjectileBlue.soundDead)
        {
            audioSource.PlayOneShot(audioClip);
            ProjectileRed.soundDead=false;
            Projectile.soundDead=false;
            ProjectileBlue.soundDead=false;
        }
    }
}
