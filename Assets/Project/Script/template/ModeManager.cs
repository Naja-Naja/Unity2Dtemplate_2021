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

//�Q�[�����[�h�ύX�E�ʒm�@�\
public class ModeManager : MonoBehaviour
{
    //���݂̃��[�h
    static GameMode gameMode;

    //���݂̃��[�h�̎擾�ύX�͂ǂ�����ł����R�ɉ\
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

    //���[�h�ύX���ɂ̓T�u�X�N���C�u����Ă���I�u�W�F�N�g�ɒʒm�����
    private static BehaviorSubject<GameMode> GameModeChange = new BehaviorSubject<GameMode>(GameMode.load);

    //�w�ǂ͂ǂ�����ł��\
    public static IObservable<GameMode> OnModeChanged
    {
        get { return GameModeChange; }
    }
}