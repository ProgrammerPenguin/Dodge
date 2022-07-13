using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    public float SurvivalTime { get; private set; }
    public bool IsOn { get; set; }

    private TextMeshProUGUI _ui;
    private float _elapsedTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        _ui = GetComponent<TextMeshProUGUI>();
        _ui.text = $"�ð� : {(int)SurvivalTime}��";
        IsOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOn)
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime >= 1f)
            {
                SurvivalTime += _elapsedTime;
                _elapsedTime = 0f;
                _ui.text = $"�ð� : {(int)SurvivalTime}��";
            }
        }
    }
}
