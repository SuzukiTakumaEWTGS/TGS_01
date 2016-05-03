//---------------------------------------------------------
//　
//	UIController
//
//  2016/04/30作成 永野
//
//---------------------------------------------------------

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// UIの列挙
/// </summary>
public enum UIs
{
    Back,
    Game,
    Front
}

public class UIController : MonoBehaviour
{

    //レイヤー管理用
    private List<GameObject> mUISet;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public UIController()
    {
        mUISet = new List<GameObject>();
    }

    /// <summary>
    /// 初期化
    /// </summary>
    private void Start()
    {
        AddUI();
    }

    /// <summary>
    /// listへ子の追加
    /// </summary>
    private void AddUI()
    {
        foreach (Transform i in GameObject.Find("Canvas").transform)
        {
            mUISet.Add(i.gameObject);
        }
    }

    /// <summary>
    /// UIの生成
    /// </summary>
    /// <param name="instance">生成物</param>
    /// <param name="position">座標</param>
    /// <param name="index">親UI</param>
    /// <returns></returns>
    public GameObject CreateUI(GameObject instance, Vector2 position, UIs index)
    {
        GameObject instanceUI = Instantiate(instance, position, Quaternion.identity) as GameObject;
        instanceUI.transform.parent = SearchUI(index).transform;
        return instance;
    }

    /// <summary>
    /// UIの検索
    /// </summary>
    /// <param name="index">listのindex</param>
    /// <returns></returns>
    public GameObject SearchUI(UIs index)
    {
        return mUISet[(int)index];
    }
}

