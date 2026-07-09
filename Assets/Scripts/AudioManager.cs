using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource secondAudioSource;
    public AudioClip[] seAudioClips;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SEPlay(int i)
    {
        audioSource.clip = seAudioClips[i];
        if(audioSource.isPlaying == false)
        {
            audioSource.Play();
        }else
        {
            secondAudioSource.clip = seAudioClips[i];
            secondAudioSource.Play();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
