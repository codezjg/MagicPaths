using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    private Button btn_Start;
    private Button btn_Shop;
    private Button btn_Rank;
    private Button btn_Sound;

    private void Awake()
    {
        Init();
    }
    private void Init()
    {
        btn_Start = transform.Find("btn_Start").GetComponent<Button>();
        btn_Start.onClick.AddListener(onStartButtonClick);
        btn_Shop = transform.Find("Btns/btn_Shop").GetComponent<Button>();
        btn_Shop.onClick.AddListener(onShopButtonClick);
        btn_Rank = transform.Find("Btns/btn_Rank").GetComponent<Button>();
        btn_Rank.onClick.AddListener(onRankButtonClick);
        btn_Sound = transform.Find("Btns/btn_Sound").GetComponent<Button>();
        btn_Sound.onClick.AddListener(onSoundButtonClick);
    }

    /// <summary>
    /// 开始按钮点击之后调用此方法
    /// </summary>
    private void onStartButtonClick()
    {
        EventCenter.Broadcast(EventDefine.ShowGamePanel);
        gameObject.SetActive(false);
    }
    /// <summary>
    /// 商店按钮点击
    /// </summary>
    private void onShopButtonClick()
    {

    }
    /// <summary>
    /// 排行榜按钮点击
    /// </summary>
    private void onRankButtonClick()
    {

    }
    /// <summary>
    /// 声音调节按钮点击
    /// </summary>
    private void onSoundButtonClick()
    {

    }
}
