using UnityEngine;

namespace Platform
{
    
    internal class AndroidSDKListener : MonoSingleton<AndroidSDKListener>
    {

        private void InitContext(string msg)
        {
            Debug.Log("InstallApk with msg : " + msg);
        }
        
        private void UnityLog(string msg)
        {
            Debug.Log("j:"+msg);
        }

        //异步获取oaid不为空就获取到了
        private void OAIDAsynchronization(string msg)
        {
            Debug.Log("异步获取oaid:"+msg);
        }
      
    }
}