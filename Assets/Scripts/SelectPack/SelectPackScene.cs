using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TriviaGame.Global;

namespace TriviaGame.SelectPack
{
    public class SelectPackScene : MonoBehaviour
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

        private void OpenLevelSelect()
        {
            SceneManager.LoadScene("LevelSelect");
        }

        private void BackMenu()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void ChoiceClick(PackChoice choiceType)
        {
            switch (choiceType)
            {
                case PackChoice.A:
                    PackDatabase.packInstance._packID = 0;
                    OpenLevelSelect();
                    break;
                case PackChoice.B:
                    PackDatabase.packInstance._packID = 1;
                    OpenLevelSelect();
                    break;
                case PackChoice.C:
                    PackDatabase.packInstance._packID = 2;
                    OpenLevelSelect();
                    break;
                case PackChoice.D:
                    PackDatabase.packInstance._packID = 3;
                    OpenLevelSelect();
                    break;
            }

        }
    }
    public enum PackChoice
    {
        A,
        B,
        C,
        D
    }

}