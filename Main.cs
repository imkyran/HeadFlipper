using MelonLoader;
using UnityEngine;

namespace TestMod
{
    public static class BuildInfo
    {
        public const string Name = "HeadFlipper";
        public const string Author = "Kyran";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class TestMod : MelonMod
    {
        public static bool HeadFlipper = false;
        public static bool UIManagerInit = false;
        public override void OnApplicationStart()
        {
            MelonLogger.Log("HeadFlipper v" + BuildInfo.Version + " Loaded.");
        }

        public override void OnUpdate()
        {
            bool ToggleHeadFlipper = Input.GetKeyDown(KeyCode.Tab);
            if (ToggleHeadFlipper)
            {
                HeadFlipper = !HeadFlipper;
                if (HeadFlipper && UIManagerInit == true)
                {
                    VRCVrCamera.field_Private_Static_VRCVrCamera_0.GetComponentInChildren<NeckMouseRotator>().rotationRange = new Vector3(float.MinValue, 0f, float.MaxValue);
                }
                else if (!HeadFlipper && UIManagerInit == true)
                {
                    VRCVrCamera.field_Private_Static_VRCVrCamera_0.GetComponentInChildren<NeckMouseRotator>().rotationRange = new Vector3(0f, 0f, 0f);
                }
            }
        }

        public override void VRChat_OnUiManagerInit()
        {
            UIManagerInit = true;
        }
    }
}
