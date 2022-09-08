using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TriviaGame.Global
{
    public class PackDatabase : MonoBehaviour
    {
        
        [SerializeField]
        public int _levelID;
        [SerializeField]
        public int _packID;

        public int LevelID => _levelID;
        public int PackID => _packID;

        public static PackDatabase packInstance;

        private void Awake()
        {
            if (packInstance == null)
            {
                packInstance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            SaveData.saveInstance.Load();
        }

        private void ChangePack()
        {
            _packID += 1;
        }

    }

    [System.Serializable]
    public struct LevelStruct
    {
        public int LevelID;
        public int PackID;
    }
}

