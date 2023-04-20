using System.Collections;
using System.Collections.Generic;
using Platform;
using UnityEngine;

namespace GYGameSDK
{
    public class SDKTest : MonoBehaviour
    {

        public GUIStyle styleBtn = null;
        private string buildDate = null;
        public GUIStyle styleTitle;

        void Start()
        {
            styleBtn = null;
            styleTitle.fontSize = 45;
            styleTitle.normal.textColor = Color.red;
        }

        void OnGUI()
        {
            if (styleBtn == null)
            {
                styleBtn = new GUIStyle(GUI.skin.button);
                styleBtn.fontSize = 30;
            }

            //打开内置web
            if (GUI.Button(new Rect(100, 50, 300, 120), "打开内置WebView", styleBtn))
            {
                AndroidPlatform.ShowPrivacyAgreementWeb("http://152.136.179.200:10100/content/Account.html");
            }

            if (GUI.Button(new Rect(100, 175, 300, 120), "获取Oaid", styleBtn))
            {
                if(AndroidPlatform.SupportedOAID()){
                     Debug.Log("支持OAID/AAID");
                     AndroidPlatform.getOAIDAsynchronization();
                     Debug.Log("同步oaid ="+AndroidPlatform.GetOAID()) ;
                }
               
            }

            if (GUI.Button(new Rect(100, 300, 300, 120), "获取安卓id mac ip", styleBtn))
            {
                Debug.Log("aid ="+AndroidPlatform.GetAndroidID()) ;
                Debug.Log("mac ="+AndroidPlatform.GetMac()) ;
                Debug.Log("ipv4 ="+AndroidPlatform.GetIPv4()) ;
                Debug.Log("ipv6 ="+AndroidPlatform.GetIPv6()) ;
                
            }
        }

    }
    
}
