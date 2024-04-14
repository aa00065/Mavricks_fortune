using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }
    public TextMeshProUGUI coinsTXT;
    public float coinsBonusMultiplier = 2;
    float coins;
    public bool GamePaused;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    public void Addcoins(float _coinsToAdd)
    {
        _coinsToAdd = Mathf.Round(_coinsToAdd);
        coins += _coinsToAdd * coinsBonusMultiplier;
        coinsTXT.text = coins.ToString() +"coins";
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        GamePaused = true;

    }
 
    // Start is called before the first frame update
    void Start()
    {
        GamePaused = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}