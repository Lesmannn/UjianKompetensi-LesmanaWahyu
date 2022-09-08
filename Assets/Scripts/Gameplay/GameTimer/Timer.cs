using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace TriviaGame.GameTimer
{
    public class Timer : MonoBehaviour
    {
        public System.Action OnTimeOver;

        [SerializeField]
        private Text timerText;
        [SerializeField]
        private Slider timeSlider;

        [SerializeField]
        float initTime = 300f;

        private void Start()
        {
            timeSlider.maxValue = initTime;
            timeSlider.value = initTime;

        }
        private void Update()
        {
            if (initTime > 0)
            {
                initTime -= Time.deltaTime;
                timeSlider.value = initTime;
            }
            else
            {
                initTime = 0;
                OnTimeOver?.Invoke();
                SceneManager.LoadScene("LevelSelect");
            }
            ShowTimer(initTime);
        }

        private void ShowTimer(float time)
        {
            if (time < 0)
            {
                time = 0;
            }

            float seconds = Mathf.FloorToInt(time);

            timerText.text = seconds.ToString();
        }
    }
}