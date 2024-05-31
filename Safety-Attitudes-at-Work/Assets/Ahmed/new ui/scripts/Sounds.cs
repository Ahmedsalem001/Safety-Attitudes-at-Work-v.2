using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource src;
    public AudioClip falling;
    public AudioClip footsteps1;
    public AudioClip footsteps2;
    public AudioClip hey;
    public AudioClip comehere;
    public AudioClip level1speach;
    public AudioClip level2speach;
    public AudioClip Shocked;
    public AudioClip afterShock;

    public void Awake()
    {
        src = GetComponent<AudioSource>();
    }
    public void fallingsignl()
    {
        src.clip = falling;
        src.volume = .3f;
        src.PlayOneShot(src.clip);

    }
    public void playfootstepsL1()
    {
        src.clip = footsteps1;
        src.volume = .2f;
        src.Play();
    }
    public void stopfootstepsL1()
    {
        src.Stop();
    }
    public void starthey()
    {
        src.clip = hey;
        src.volume = .3f;
        src.PlayOneShot(src.clip);
    }
    public void saycomehere()
    {
        src.clip = comehere;
        src.volume = .2f;
        src.PlayOneShot(src.clip);
    }
    public void playfootstepsL2()
    {
        src.clip = footsteps2;
        src.volume = .2f;
        src.Play();
    }
    public void stopfootstepsL2()
    {
        src.Stop();
    }
    public void playlevel1speach()
    { 
        src.clip = level1speach;
        src.volume = .7f;
        src.PlayOneShot(src.clip);
    }
    public void playlevel2speach()
    {
        src.clip = level2speach;
        src.volume = .7f;
        src.PlayOneShot(src.clip);
    }

    public void playShocked()
    {
        src.clip = Shocked;
        src.volume = .1f;
        src.PlayOneShot(src.clip);
    }
    public void playAfterShock()
    {
        src.clip = afterShock;
        src.volume = .1f;
        src.PlayOneShot(src.clip);
    }
}
