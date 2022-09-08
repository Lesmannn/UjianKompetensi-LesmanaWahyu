using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TriviaGame.Global;

namespace TriviaGame.LevelSelect
{
    public class LevelSelectScene : MonoBehaviour
    {
        [SerializeField]
        Button[] choiceButton;
        [SerializeField]
        private Button _backButton;

        private void Awake()
        {
            _backButton.onClick.RemoveAllListeners();
            _backButton.onClick.AddListener(BackMenu);

        }

        private void OpenGameplay()
        {
            SceneManager.LoadScene("Gameplay");
        }

        private void BackMenu()
        {
            SceneManager.LoadScene("SelectPack");
        }

        public void ChoiceClick(LevelChoice choiceType)
        {
            switch (choiceType)
            {
                case LevelChoice.one:
                    PackDatabase.packInstance._levelID = 0;
                    OpenGameplay();
                    break;
                case LevelChoice.two:
                    PackDatabase.packInstance._levelID = 1;
                    OpenGameplay();
                    break;
                case LevelChoice.three:
                    PackDatabase.packInstance._levelID = 2;
                    OpenGameplay();
                    break;
                case LevelChoice.four:
                    PackDatabase.packInstance._levelID = 3;
                    OpenGameplay();
                    break;
                case LevelChoice.five:
                    PackDatabase.packInstance._levelID = 4;
                    OpenGameplay();
                    break;
            }

        }
    }
    public enum LevelChoice
    {
        one,
        two,
        three,
        four,
        five
    }

}