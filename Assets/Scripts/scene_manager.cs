using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_manager : MonoBehaviour
{
    public void on_second_scene_button_click()
    {
        SceneManager.LoadScene(scene_name.SECOND_SCENE);
    }

    public void on_first_scene_button_click()
    {
        SceneManager.LoadScene(scene_name.FIRST_SCENE);
    }
}
