using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    // 平台初始生成位置
    public Vector3 startSpawnPos;
    // 默认生成平台数量
    private int spawnPlatformCount;
    private ManageVars vars;
    private Vector3 platformSpawnPosition;
    private bool isLeftSpawn = false;
    /// <summary>
    /// 初始每次生成5个 
    /// </summary>
    private void Start()
    {
       platformSpawnPosition = startSpawnPos;
       vars = ManageVars.GetManageVars();
       for(int i=0;i<5;i++)
        {
            spawnPlatformCount = 5;
            DecidePath();
        }

        // 生成人物
        GameObject go = Instantiate(vars.characterPre);
        go.transform.position = new Vector3(0, -1.8f, 0);
    }
    /// <summary>
    /// 确定路径
    /// </summary>
    private void DecidePath()
    {
        if (spawnPlatformCount >= 0)
        {
            spawnPlatformCount--;
            SpawnPlatform();
        }
        else
        {
            isLeftSpawn = !isLeftSpawn; // 反转生成方向
            spawnPlatformCount = Random.Range(1, 4);
            SpawnPlatform(); 
        }
    }
    /// <summary>
    /// 生成平台 
    /// 判断向左边生成还是向右边生成
    /// </summary>
    private void SpawnPlatform()
    {
        SpawnNormalPlatform();

       if(isLeftSpawn)
        {
            // 向左生成
            platformSpawnPosition = new
                Vector3(platformSpawnPosition.x - vars.nextXPos,
                        platformSpawnPosition.y + vars.nextYpos);
        }
       else
        {
            platformSpawnPosition = new
                Vector3(platformSpawnPosition.x + vars.nextXPos,
                        platformSpawnPosition.y + vars.nextYpos);
        }
        
       
    }
    // 生成普通平台(单个）
    private void SpawnNormalPlatform()
    {
        GameObject go = Instantiate(vars.normalPlatfromPre, transform);
        go.transform.position = platformSpawnPosition;
    }
}
