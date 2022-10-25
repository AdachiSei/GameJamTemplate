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
    public BGM[] BGMs => _bGMs;

    [SerializeField]
    [Header("")]
    private BGM[] _bGMs;

    [Serializable]
    public class BGM
    {
        public string Name => _name;
        public BGMType Type => _type;
        public AudioSource AudioSource => _audioSource;

        [SerializeField]
        [Header("名前")]
        private string _name;

        [SerializeField]
        [Header("BGMの種類")]
        private BGMType _type;

        [SerializeField]
        [Header("BGM")]
        private AudioSource _audioSource;
    }
}
