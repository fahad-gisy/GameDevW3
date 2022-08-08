using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundActions : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    public AudioClip jumpSound, winSound, coinCollect;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerJumpSound()
    {
        audioSource.clip = jumpSound;
        audioSource.Play();
    }

    public void PlayerWinSound()
    {
        audioSource.clip = winSound;
        audioSource.PlayOneShot(winSound);
    }

    public void PlayerCoinCollectSound()
    {
        audioSource.clip = coinCollect;
        audioSource.Play();
    }
}
