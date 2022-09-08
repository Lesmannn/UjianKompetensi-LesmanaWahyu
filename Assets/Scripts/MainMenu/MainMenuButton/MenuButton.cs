using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    [SerializeField] 
    private Button _playButton;

    private void Awake()
    {
        _playButton.onClick.RemoveAllListeners();
        _playButton.onClick.AddListener(OpenGameplay);

    }

    private void OpenGameplay()
    {
        SceneManager.LoadScene("SelectPack");
    }
}
