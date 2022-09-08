using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TriviaGame.Global
{
    public class SaveData : MonoBehaviour
    {
        public static SaveData saveInstance;
        private const string _prefsKey = "SaveData";

        private void Awake()
        {
            if (saveInstance == null)
            {
                saveInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            Load();
        }

        public void Save()
        {
            string json = JsonUtility.ToJson(this);
            PlayerPrefs.SetString(_prefsKey, json);
        }

        public void Load()
        {
            if (PlayerPrefs.HasKey(_prefsKey))
            {
                string json = PlayerPrefs.GetString(_prefsKey);
                JsonUtility.FromJsonOverwrite(json, this);
            }
            else
            {
                Save();
            }
        }
    }
}