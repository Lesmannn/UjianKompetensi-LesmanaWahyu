using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TriviaGame.GameHandler;

namespace TriviaGame.GameFlow
{
    public class GameFlow : MonoBehaviour
    {
        [HideInInspector]
        public int id;
        [SerializeField]
        ScriptablePack[] pack;
        [SerializeField]
        Button[] choiceButton;
        private int packType;

        public System.Action OnLevelFinished;
        public void ChoiceClick(AnswerChoice choiceType)
        {
            switch (choiceType)
            {
                case AnswerChoice.A:
                    id = 1;
                    CheckAnswer(id);
                    break;
                case AnswerChoice.B:
                    id = 2;
                    CheckAnswer(id);
                    break;
                case AnswerChoice.C:
                    id = 3;
                    CheckAnswer(id);
                    break;
                case AnswerChoice.D:
                    id = 4;
                    CheckAnswer(id);
                    break;
            }

        }
        private void CheckAnswer(int id)
        {
            int packIndex = 0;

            while (true)
            {
                if (id == pack[packIndex].levelObject[GameplayHandler.levelIndex].indexCorrect)
                {
                    Debug.Log("Benar");
                    GameplayHandler.levelIndex += 1;
                    OnLevelFinished?.Invoke();
                    if (GameplayHandler.levelIndex < 5)
                    {
                        SceneManager.LoadScene("Gameplay");
                    }
                    else
                    {
                        SceneManager.LoadScene("SelectPack");
                    }
                    break;
                }
                else
                {
                    Debug.Log("Salah");
                    StartCoroutine(WaitTime());
                    break;
                }
            }

        }

        IEnumerator WaitTime()
        {
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("LevelSelect");
        }
    }

    public enum AnswerChoice
    {
        A,
        B,
        C,
        D
    }
}

