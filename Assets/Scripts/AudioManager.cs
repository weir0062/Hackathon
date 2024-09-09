using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip paddleHitSound;     
    public AudioClip brickHitSound;      
    public AudioClip brickBreakSound;    
    public AudioClip LoseSound;    
    private AudioSource audioSource;

    bool gameover = false;
    float timer = 3.0f;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
     void Update()
    {
        if (gameover)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                audioSource.Stop();  
            }
        }
    }
    // Метод для воспроизведения звука удара о пэддл
    public void PlayPaddleHitSound()
    {
        audioSource.PlayOneShot(paddleHitSound);
    }

    // Метод для воспроизведения звука удара о кирпичик
    public void PlayBrickHitSound()
    {
        audioSource.PlayOneShot(brickHitSound);
    }

    // Метод для воспроизведения звука разрушенного кирпичика
    public void PlayBrickBreakSound()
    {
        audioSource.PlayOneShot(brickBreakSound);
    }



    public void PlayLoseSound()
    {

        audioSource.PlayOneShot(LoseSound);
        gameover = true;
    }
}
