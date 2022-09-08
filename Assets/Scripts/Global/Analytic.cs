using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TriviaGame.GameFlows;

namespace TriviaGame.Global
{
    public class Analytic : MonoBehaviour
    {
        public static Analytic analyticInstance;
        
        private GameFlow flowGame;
        private void Awake()
        {
            if (analyticInstance == null)
            {
                analyticInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
        private void OnEnable()
        {
            flowGame.OnLevelFinished += TrackFinishLevel;
        }
        private void OnDisable()
        {
            flowGame.OnLevelFinished -= TrackFinishLevel;
        }

        public void TrackFinishLevel()
        {
            Debug.Log("Level Finished");
        }
        public void TrackUnlockPack()
        {
            Debug.Log("Pack Unlocked");
        }

    }
}

