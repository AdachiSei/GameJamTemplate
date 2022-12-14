using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ポーズに必要なScripts
/// </summary>
public class PauseManager : SingletonMonoBehaviour<PauseManager>
{
    #region private Member

    private bool _isPausing;

    #endregion

    #region Events

    public event Action OnPause;
    public event Action OnResume;

    #endregion

    #region Unity Method

    void Update()
    {
        if (Input.GetButtonDown(InputNames.CANCEL))
        {
            if (!_isPausing)
            {
                _isPausing = true;
                OnPause();
            }
            else
            {
                _isPausing = false;
                OnResume();
            }
        }
    }

    #endregion
}
