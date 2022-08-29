using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    string[] nameOfClip;
    public bool isAudioEnabled = false;
    private static AudioManager _instance;
    private AudioSource source;

    public static AudioManager Instance { get { return _instance; } }
    private void Awake() 
    {
        source = GetComponent<AudioSource>();

        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public void PlayBgm()
    {
        int ran = Random.Range(0, nameOfClip.Length);
        source.clip = Resources.Load<AudioClip>("BGM/" + nameOfClip[ran]);
        source.Play();
    }
}
