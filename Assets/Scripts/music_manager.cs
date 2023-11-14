using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class music_manager : MonoBehaviour
{
    [SerializeField]
    private AudioClip first_scene_music;
    [SerializeField]
    private AudioClip second_scene_music;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        PlaySceneMusic();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        PlaySceneMusic();
    }

    private void PlaySceneMusic()
    {
        string sceneName = SceneManager.GetActiveScene().name;

        if (sceneName == scene_name.FIRST_SCENE)
        {
            audioSource.clip = first_scene_music;
        }
        else
        {
            audioSource.clip = second_scene_music;
        }

        audioSource.Play();
    }
    
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
    
