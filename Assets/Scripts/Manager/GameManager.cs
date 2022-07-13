using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 1. 게임이 종료되면 GameOverUI를 보여줘야함.
    // 2. 재시작 안내를 해준다 ~
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

        // 데이터 저장
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Math.Max((int)Timer.SurvivalTime, savedBestTime);

        PlayerPrefs.SetInt("BestTime", bestTime);

        // GameOverUI에다가 갱신
        //GameOverUI.SetActive(true);
        gameOverUI.Activate(bestTime);

        // _isOver = true;
        _isOver = true;
    }


}
