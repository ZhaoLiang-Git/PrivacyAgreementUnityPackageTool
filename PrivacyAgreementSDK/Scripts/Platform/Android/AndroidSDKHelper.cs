using System;
using UnityEngine;

namespace Platform
{
#if UNITY_ANDROID
    internal static class AndroidSDKHelper
    {

        private static readonly AndroidJavaClass unityPlayer;
        private static readonly AndroidJavaObject currentActivity;
        private static readonly AndroidJavaClass sdkCallHandler;
        static AndroidSDKHelper()
        {
            unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            sdkCallHandler = new AndroidJavaClass("com.gyyx.androidsdk.UAMain");
        }

        public static void InitSdk()
        {
            try
            {
                sdkCallHandler.CallStatic("initContext", currentActivity, currentActivity.Get<AndroidJavaObject>("mUnityPlayer"));
            }
            catch (Exception ex)
            {
                Debug.LogError("call sdk get exception methodName:init" + " message: " + ex.Message);
            }

            Debug.Log("C# AndroidSDKHelper InitSdk");
        }

        public static void FuncCall(string methodName, params object[] param)
        {
            try
            {
                sdkCallHandler.CallStatic(methodName, param);
            }
            catch (Exception ex)
            {
                Debug.LogError("call sdk get exception methodName:" + methodName + " message: " + ex.Message);
            }

        }

        public static T FuncCall<T>(string methodName, params object[] param)
        {
            try
            {
                return sdkCallHandler.CallStatic<T>(methodName, param);
            }
            catch (Exception ex)
            {
                Debug.LogError("call sdk get exception methodName:" + methodName + " message: " + ex.Message);
                return default;
            }
        }
    }
#endif
}