using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TriviaGame.SelectPack
{
    public class SelectPackManager : MonoBehaviour
    {
        [SerializeField]
        SelectPackScene flowHandler;
        [SerializeField]
        PackChoice choiceType;

        private void Awake()
        {
            Button choiceButton = GetComponent<Button>();
            choiceButton.onClick.AddListener(delegate { flowHandler.ChoiceClick(choiceType); });
        }
    }
}

