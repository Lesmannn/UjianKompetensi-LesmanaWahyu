using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TriviaGame.Global;

namespace TriviaGame.GameHandler
{
    public class GameplayHandler : MonoBehaviour
    {
        [SerializeField]
        ScriptablePack pack;
        [SerializeField]
        Text question;
        [SerializeField]
        Text[] answers;
        [SerializeField]
        Image imageHint;

        int levelIndex;


        private void Start()
        {
            Handler();
        }
        private void Handler()
        {

            question.text = pack.levelObject[levelIndex].question;
            imageHint.sprite = pack.levelObject[levelIndex].hintImage;
            for (int i = 0; i < answers.Length; i++)
            {
                answers[i].text = pack.levelObject[levelIndex].answer[i];
            }
        }

    }
}