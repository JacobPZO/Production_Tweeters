using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] string _LevelName;

    public void GoToLevel()
    {
        SceneManager.LoadScene(_LevelName);
    }
}
