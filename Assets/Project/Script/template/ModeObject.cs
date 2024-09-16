using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ModeObject : MonoBehaviour
{
    [SerializeField] List<GameMode> gameMode;
    bool active;
    public virtual void Start()
    {
        ModeManager.OnModeChanged.Subscribe(mode =>
        {
            if (gameMode.Contains(mode))
            {
                if (!active)
                {
                    StartMode();
                    active = true;
                }
            }
            else if (active == true)
            {
                CloseMode();
                active = false;
            }
        });
    }
    public virtual void StartMode() { }
    public virtual void CloseMode() { }
    public bool IsModeActive()
    {
        return active;
    }
}
