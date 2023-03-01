
using UnityEngine;

public class Sound {
    public string name;
    public AudioClip clip;

    private AudioSource source;

    public float volume = 0.7f;
    public float pitch = 1f;

    public void SetSource (AudioSource _source)
    {
        source = _source;
        source.clip = clip;
    }

    public void Play(){
       
        // source.volume=volume;
        // public.pitch=pitch;
        // source.Play();
    }

}

public class SoundManager : MonoBehaviour
{
    
}
