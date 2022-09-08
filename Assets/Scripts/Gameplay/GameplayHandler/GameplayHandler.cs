using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TriviaGame.Global;

namespace TriviaGame.GameHandler
{
    public class GameplayHandler : MonoBehaviour
    {
        [SerializeField]
        ScriptablePack[] pack;
        [SerializeField]
        Text question;
        [SerializeField]
        Text[] answers;
        [SerializeField]
        Image imageHint;
        [SerializeField]
        Button backButton;

        private void Awake()
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(OpenGameplay);

        }

        private void Start()
        {
            Handler();
        }
        private void Handler()
        {

            question.text = pack[PackDatabase.packInstance.PackID].levelObject[PackDatabase.packInstance.LevelID].question;
            imageHint.sprite = pack[PackDatabase.packInstance.PackID].levelObject[PackDatabase.packInstance.LevelID].hintImage;
            for (int i = 0; i < answers.Length; i++)
            {
                answers[i].text = pack[PackDatabase.packInstance.PackID].levelObject[PackDatabase.packInstance.LevelID].answer[i];
            }
        }
        private void OpenGameplay()
        {
            SceneManager.LoadScene("LevelSelect");
        }


    }
}