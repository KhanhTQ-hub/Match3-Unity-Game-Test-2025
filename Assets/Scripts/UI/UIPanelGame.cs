﻿using com.ktgame.core.di;
using GamManager;
using UnityEngine;
using UnityEngine.UI;

public class UIPanelGame : MonoBehaviour,IMenu
{
    public Text LevelConditionView;

    [SerializeField] private Button btnPause;
    [SerializeField] private Button btnRestart;

    private UIMainManager m_mngr;
    [Inject] private readonly IGameManager m_gameManager;

    private void Awake()
    {
        btnPause.onClick.AddListener(OnClickPause);
        btnRestart.onClick.AddListener(OnClickRestart);
    }

    private void OnClickRestart()
    {
        m_gameManager.RestartLevel();
    }

    private void OnClickPause()
    {
        m_mngr.ShowPauseMenu();
    }

    public void Setup(UIMainManager mngr)
    {
        m_mngr = mngr;
    }
    
    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }
}
