using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// BGM(音楽)を格納するScriptableObject
/// </summary>
[CreateAssetMenu(fileName = "BGMData", menuName = "ScriptableObjects/BGMData", order = 0)]
public class BGMData : ScriptableObject
{
    public BGM[] BGMs => _bGM;

    [SerializeField]
    [Header("音楽")]
    private BGM[] _bGM;

    [Serializable]
    public class BGM
    {
        public string Name => _name;
        public AudioClip AudioClip => _audioClip;

        [SerializeField]
        [Header("名前")]
        private string _name;

        [SerializeField]
        [Header("BGM")]
        private AudioClip _audioClip;
    }
}
