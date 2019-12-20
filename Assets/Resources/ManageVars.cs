using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName ="CreateManagerVarsContainer")]
public class ManageVars : ScriptableObject
{

    public static ManageVars GetManageVars()
    {
        // 加载
        return Resources.Load<ManageVars>("MangaeVarsContainer");
    }

    public List<Sprite> bgThemeSpriteList = new List<Sprite>();

    public GameObject normalPlatfromPre;
    public GameObject characterPre; // 人物预置体
    public float nextXPos = 0.554f, nextYpos = 0.645f;
}
