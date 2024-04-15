using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] string _LevelName;

    public GameObject gameOverUI;

    public void RestartLevel()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(_LevelName);
    }

    private LivesManager _livesManager;

    // Start is called before the first frame update
    void Start()
    {
        _livesManager = GameObject.Find("LivesManager").GetComponent<LivesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_livesManager.HP <= 0)
        {
            StartCoroutine(Fail());
        }
    }

    private IEnumerator Fail()
    {
        yield return new WaitForSeconds(6);
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
