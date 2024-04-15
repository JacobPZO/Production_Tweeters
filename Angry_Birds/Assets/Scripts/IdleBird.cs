using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBird : MonoBehaviour
{
    [SerializeField] int _BirdNumber;
    private LivesManager _livesManager;

    // Start is called before the first frame update
    void Start()
    {
        _livesManager = GameObject.Find("LivesManager").GetComponent<LivesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_livesManager.HP < _BirdNumber)
        {
            gameObject.SetActive(false);
        }
    }
}
