using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TriviaGame.GameHandler;
using TriviaGame.Global;

namespace TriviaGame.GameFlows
{
    public class GameFlow : MonoBehaviour
    {
        [HideInInspector]
        public int id;
        [SerializeField]
        ScriptablePack[] pack;
        [SerializeField]
        Button[] choiceButton;
        

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

            while (true)
            {
                if (id == pack[PackDatabase.packInstance._packID].levelObject[PackDatabase.packInstance._levelID].indexCorrect)
                {
                    Debug.Log("Benar");
                    Currency.currencyInstance.AddGold();
                    SaveData.saveInstance.Save();
                    PackDatabase.packInstance._levelID += 1;
                    OnLevelFinished?.Invoke();
                    if (PackDatabase.packInstance._levelID < 5)
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

