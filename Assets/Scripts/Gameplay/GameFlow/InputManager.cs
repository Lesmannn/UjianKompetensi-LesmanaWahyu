using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TriviaGame.GameFlows;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    GameFlow flowHandler;
    [SerializeField]
    AnswerChoice choiceType;

    private void Awake()
    {
        Button choiceButton = GetComponent<Button>();
        choiceButton.onClick.AddListener(delegate { flowHandler.ChoiceClick(choiceType); });
    }
}
