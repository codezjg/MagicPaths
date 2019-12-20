using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgTheme : MonoBehaviour
{
    private SpriteRenderer m_SpriteRenderer;
    private ManageVars vars;
    public void Awake()
    {
        vars = ManageVars.GetManageVars();
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        int ranValue = Random.Range(0,vars.bgThemeSpriteList.Count);
        m_SpriteRenderer.sprite = vars.bgThemeSpriteList[ranValue];
    }



}
