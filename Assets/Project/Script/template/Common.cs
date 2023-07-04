using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Common : MonoBehaviour
{
    public static Vector2Int CursolPosition_forGrid()
    {
        //マウス座標の取得
        var mousePotitionScr = new Vector2(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue());
        var mousePositionWor = Camera.main.ScreenToWorldPoint(mousePotitionScr);

        //値の加工
        int grid_x = (int)(mousePositionWor.x - (10000 + mousePositionWor.x) % 1f);
        int grid_y = (int)(mousePositionWor.y - (10000 + mousePositionWor.y) % 1f);
        return new Vector2Int(grid_x, grid_y);
    }
    /// <summary>
    /// 現在のマウスが差すワールド座標
    /// </summary>
    public static Vector2 CursolPosition()
    {
        //マウス座標の取得
        var mousePotitionScr = new Vector2(Mouse.current.position.x.ReadValue(), Mouse.current.position.y.ReadValue());
        var mousePositionWor = Camera.main.ScreenToWorldPoint(mousePotitionScr);

        return new Vector2(mousePositionWor.x, mousePositionWor.y);
    }
}
