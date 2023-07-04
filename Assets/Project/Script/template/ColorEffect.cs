using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ColorEffect : MonoBehaviour
{
    /// <summary>
    /// 色を指定色と元の色で点滅させる
    /// </summary>
    public static Tweener colorFlash(Image img, Color color, float time)
    {
        return  DOTween.To(() => img.color, x => img.color = x, color, time).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
