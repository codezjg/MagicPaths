using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GamePanel : MonoBehaviour
{
    private Button btn_Pause;
    private Button btn_Play;
    private Text txt_Score;
    private Text txt_DiamondCount;

    public void Awake()
    {
        EventCenter.AddListener(EventDefine.ShowGamePanel,Show);
        Init();
    }

    private void Init()
    {
        btn_Pause = transform.Find("btn_Pause").GetComponent<Button>();
        btn_Pause.onClick.AddListener(onPauseButtonClick);
        btn_Play=transform.Find("btn_Play").GetComponent<Button>();
        btn_Play.onClick.AddListener(onPlayButtonClick);
        txt_Score = transform.Find("txt_Score").GetComponent<Text>();
        txt_DiamondCount = transform.Find("Diamond/txt_DiamondCount").GetComponent<Text>();
        btn_Play.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
    private void OnDestroy()
    {
        EventCenter.RemoveListener(EventDefine.ShowGamePanel, Show);
    }
    private void Show()
    {
        gameObject.SetActive(true);
    }
    /// <summary>
    /// 暂停按钮点击
    /// </summary>
    private void onPauseButtonClick()
    {
        btn_Play.gameObject.SetActive(true);
        btn_Pause.gameObject.SetActive(false);

        // to do 游戏暂停
    }
    /// <summary>
    /// 开始按钮点击
    /// </summary>
    private void onPlayButtonClick()
    {
        btn_Play.gameObject.SetActive(false);
        btn_Pause.gameObject.SetActive(true);
        // to do 游戏开始
    }
}
