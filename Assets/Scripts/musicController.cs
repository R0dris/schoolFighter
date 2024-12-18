using UnityEngine;

public class MusicController : MonoBehaviour
{
    // Classe responsável por conrolar qualquer tipo de áudio
    private AudioSource audioSource;

    // AudioClip é o arquivo de audio que será executado
    public AudioClip levelMusic;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        PlayMusic(levelMusic);
    }

    public void PlayMusic(AudioClip music)
    {
        //Define o som que ira ser reproduxido
        audioSource.clip = music;
        //Reproduz o som
        audioSource.Play();
    }
}
