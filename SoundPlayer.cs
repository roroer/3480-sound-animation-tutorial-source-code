using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip musicClip1;
    public AudioClip musicClip2;

    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) {
            musicSource.clip = musicClip1;
            musicSource.Play();
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.W)) {
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            musicSource.clip = musicClip2;
            musicSource.Play();
            anim.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.R)) {
            musicSource.Stop();
            anim.SetInteger("State", 0);
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
