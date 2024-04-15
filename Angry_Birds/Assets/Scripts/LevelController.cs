using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    private Monster[] _monsters;

    private void OnEnable()
    {
        _monsters = FindObjectsOfType<Monster>();
        var audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (MonstersAreAllDead())
            StartCoroutine(GoToNextLevel());
    }

    private IEnumerator GoToNextLevel()
    {
        yield return new WaitForSeconds(1);
        var audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(_nextLevelName);
    }

    private bool MonstersAreAllDead()
    {
        foreach (var monster in _monsters)
        {
            if (monster.gameObject.activeSelf)
                return false;
        }

        return true;
    }
}
