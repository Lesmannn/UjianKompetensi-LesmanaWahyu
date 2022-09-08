using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TriviaGame.LevelSelect
{
    public class LevelSelectManager : MonoBehaviour
    {
        [SerializeField]
        LevelSelectScene flowHandler;
        [SerializeField]
        LevelChoice choiceType;

        private void Awake()
        {
            Button choiceButton = GetComponent<Button>();
            choiceButton.onClick.AddListener(delegate { flowHandler.ChoiceClick(choiceType); });
        }
    }
}
