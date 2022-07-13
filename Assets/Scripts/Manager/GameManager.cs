using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 1. ������ ����Ǹ� GameOverUI�� ���������.
    // 2. ����� �ȳ��� ���ش� ~
    public TimerText Timer;
    public GameOverUI gameOverUI;

    private bool _isOver;

    // Start is called before the first frame update
    void Start()
    {
        //_playerhealth = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        Timer.IsOn = false;

        // ������ ����
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max((int)Timer.SurvivalTime, savedBestTime);

        PlayerPrefs.SetInt("BestTime", bestTime);

        // GameOverUI���ٰ� ����
        //GameOverUI.SetActive(true);
        gameOverUI.Activate(bestTime);

        // _isOver = true;
        _isOver = true;
    }


}
