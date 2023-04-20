using UnityEngine;

namespace Platform
{
#if UNITY_ANDROID
    public class AndroidPlatform:MonoBehaviour
    {
        public void Awake()
        {
#if UNITY_ANDROID
               
            AndroidSDKListener.Instance.Startup();
            AndroidSDKHelper.InitSdk();
#endif
        }
        public static void ShowPrivacyAgreementWeb(string url)
        {
            AndroidSDKHelper.FuncCall("ShowWeb", url);
        }

        //获取隐私协议状态0代表未同意1代表已同意
        public static string GetPrivacyAgreementState()
        {
            return AndroidSDKHelper.FuncCall<string>("PrivacyAgreementState");
        }

        // 获取IMEI，只支持Android 10之前的系统，需要READ_PHONE_STATE权限，可能为空
        public static string GetImei()
        {
            return AndroidSDKHelper.FuncCall<string>("getImei");
        }
         // 获取安卓ID，可能为空
        public static string GetAndroidID()
        {
            return AndroidSDKHelper.FuncCall<string>("getAndroidID");
        }
        // 获取数字版权管理ID，可能为空
        public static string GetWidevineID()
        {
            return AndroidSDKHelper.FuncCall<string>("getWidevineID");
        }
         // 获取伪造ID，根据硬件信息生成，不会为空，有大概率会重复
        public static string GetPseudoID()
        {
            return AndroidSDKHelper.FuncCall<string>("getPseudoID");
        }
         // 获取GUID，随机生成，不会为空
        public static string GetGUID()
        {
            return AndroidSDKHelper.FuncCall<string>("getGUID");
        }
        // 是否支持OAID/AAID
        public static bool SupportedOAID()
        {
            return AndroidSDKHelper.FuncCall<bool>("supportedOAID");
        }

        // 获取OAID/AAID，同步调用
        public static string GetOAID()
        {
            return AndroidSDKHelper.FuncCall<string>("getOAID");
        }
        // 获取OAID/AAID，异步回调
        public static void getOAIDAsynchronization()
        {
             AndroidSDKHelper.FuncCall("getOAIDAsynchronization");
        }
        // 获取mac地址
        public static string GetMac()
        {
            return AndroidSDKHelper.FuncCall<string>("getMac");
        }
        // 获取IPv4地址
        public static string GetIPv4()
        {
            return AndroidSDKHelper.FuncCall<string>("getIPv4");
        }

        // 获取IPv6地址，可能为空
        public static string GetIPv6()
        {
            return AndroidSDKHelper.FuncCall<string>("getIPv6");
        }

    }
#endif
}