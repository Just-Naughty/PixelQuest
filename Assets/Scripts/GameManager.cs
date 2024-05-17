using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public float initialGameSpeed = 5.0f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }



    // Start is called before the first frame update
    void Start()
    {
        NewGame();

        if(Instance == null)
        {
            Instance = this;
        }
        else 
            DestroyImmediate(gameObject);
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
    }

    void NewGame()
    {
        gameSpeed = initialGameSpeed;
    }
}
