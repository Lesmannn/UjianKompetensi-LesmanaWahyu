using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TriviaGame.GameFlows;

namespace TriviaGame.Global
{
    public class Analytic : MonoBehaviour
    {
        public static Analytic analyticInstance;
        
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
            
        }
        private void OnDisable()
        {
            
        }

        public void TrackFinishLevel()
        {
            Debug.Log("Level Finished, Analytic Send");
        }
        public void TrackUnlockPack()
        {
            Debug.Log("Pack Unlocked, Analytic Send");
        }

    }
}

