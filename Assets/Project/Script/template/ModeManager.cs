using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public enum GameMode
{
    load,
    anymode,
}

//ゲームモード変更・通知機能
public class ModeManager : MonoBehaviour
{
    //現在のモード
    static GameMode gameMode;

    //現在のモードの取得変更はどこからでも自由に可能
    public static GameMode GetMode()
    {
        return gameMode;
    }
    public static void SetMode(GameMode changeMode)
    {
        gameMode = changeMode;
        GameModeChange.OnNext(changeMode);
        Debug.Log("GameMode: " + gameMode);
    }

    //モード変更時にはサブスクライブされているオブジェクトに通知が飛ぶ
    private static BehaviorSubject<GameMode> GameModeChange = new BehaviorSubject<GameMode>(GameMode.load);

    //購読はどこからでも可能
    public static IObservable<GameMode> OnModeChanged
    {
        get { return GameModeChange; }
    }
}