using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static GeoService.Geo;
public class GeoStart : MonoBehaviour
{
    
    private void Start()
    {
        StartCoroutine(StartLocationService());
    }

    IEnumerator StartLocationService()
    {
        // 检查用户是否启用了位置服务
        if (!Input.location.isEnabledByUser)
        {
            Debug.Log("Location services are not enabled.");
            yield break;
        }
        // 启动位置服务
        Input.location.Start();
        
        // 等待位置服务初始化
        int maxWait = 20; // 最大等待时间
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
         // 检查服务是否启动成功
          if (Input.location.status == LocationServiceStatus.Failed)
          {
              yield break;
          }          
        while (true)
        {
            try
            {
                LocationInfo location = Input.location.lastData;
                GetPosition(location.longitude,location.latitude);
            }
            catch (Exception e) 
            {
                yield break;
            }

            yield return new WaitForSeconds(300);
        }
        
    }

}
