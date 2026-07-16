using JetBrains.Annotations;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else
        {
            Destroy(this.gameObject);
        }
    }

    private AudioSource audioSource;
    private AudioSource seAudioSource;
    public AudioClip[] seAudioClips;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SEPlay(int i)
    { 
        if(seAudioSource == null)
        {
            seAudioSource = this.gameObject.AddComponent<AudioSource>();
        }
        seAudioSource.clip = seAudioClips[i];
        seAudioSource.Play();

    }
       
        public AudioClip[] bgmAudioClips;
    private AudioSource bgmAudioSource;

    public void BGMPlay()
    {
        if(bgmAudioSource == null)
        {
            bgmAudioSource = this.gameObject.AddComponent<AudioSource>();
        }
        bgmAudioSource.clip = bgmAudioClips[0];
        bgmAudioSource.Play();
        bgmAudioSource.loop = true;
    }
    void Start()
    {
        BGMPlay();
    }
}
