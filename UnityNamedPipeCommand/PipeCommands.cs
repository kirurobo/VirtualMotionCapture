﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UnityNamedPipe
{
    public class PipeCommands
    {
        public static Type GetCommandType(string commandStr)
        {
            var commands = typeof(PipeCommands).GetNestedTypes(System.Reflection.BindingFlags.Public);
            foreach (var command in commands)
            {
                if (command.Name == commandStr) return command;
            }
            return null;
        }

        public class LoadVRM
        {
            public string Path { get; set; }
        }

        public class ReturnLoadVRM
        {
            public VRMData Data { get; set; }
        }

        public class ImportVRM
        {
            public string Path { get; set; }
            public bool ImportForCalibration { get; set; }
            public bool EnableNormalMapFix { get; set; }
            public bool DeleteHairNormalMap { get; set; }
            public bool UseCurrentFixSetting { get; set; }
        }

        public class LoadVRMPath
        {
            public string Path { get; set; }
        }

        public class Calibrate
        {
            public CalibrateType CalibrateType { get; set; }
        }

        public enum CalibrateType
        {
            Default = 0,
            FixedHand = 1,
            FixedHandWithGround = 2,
        }

        public class EndCalibrate { }

        public class SetFloatValueBase { public float value { get; set; } }

        public class SetLipSyncEnable { public bool enable { get; set; } }
        public class GetLipSyncDevices { }
        public class ReturnGetLipSyncDevices { public string[] Devices { get; set; } }
        public class SetLipSyncDevice { public string device { get; set; } }
        public class SetLipSyncGain : SetFloatValueBase { }
        public class SetLipSyncMaxWeightEnable { public bool enable { get; set; } }
        public class SetLipSyncWeightThreashold : SetFloatValueBase { }
        public class SetLipSyncMaxWeightEmphasis { public bool enable { get; set; } }

        public class ChangeBackgroundColor
        {
            public float r { get; set; }
            public float g { get; set; }
            public float b { get; set; }
            public bool isCustom { get; set; }
        }
        public class SetBackgroundTransparent { }
        public class SetWindowBorder { public bool enable { get; set; } }
        public class SetWindowTopMost { public bool enable { get; set; } }
        public class SetWindowClickThrough { public bool enable { get; set; } }

        public class SetAutoBlinkEnable { public bool enable { get; set; } }
        public class SetBlinkTimeMin : SetFloatValueBase { }
        public class SetBlinkTimeMax : SetFloatValueBase { }
        public class SetCloseAnimationTime : SetFloatValueBase { }
        public class SetOpenAnimationTime : SetFloatValueBase { }
        public class SetClosingTime : SetFloatValueBase { }
        public class SetDefaultFace { public string face { get; set; } }

        public class SaveSettings { }
        public class LoadSettings { }
        public class LoadCurrentSettings { }
        public class LoadCustomBackgroundColor
        {
            public float r { get; set; }
            public float g { get; set; }
            public float b { get; set; }
        }
        public class LoadHideBorder { public bool enable { get; set; } }
        public class LoadIsTopMost { public bool enable { get; set; } }
        public class LoadSetWindowClickThrough { public bool enable { get; set; } }
        public class LoadShowCameraGrid { public bool enable { get; set; } }
        public class LoadCameraMirror { public bool enable { get; set; } }
        public class LoadLipSyncEnable { public bool enable { get; set; } }
        public class LoadLipSyncDevice { public string device { get; set; } }
        public class LoadLipSyncGain { public float gain { get; set; } }
        public class LoadLipSyncMaxWeightEnable { public bool enable { get; set; } }
        public class LoadLipSyncWeightThreashold { public float threashold { get; set; } }
        public class LoadLipSyncMaxWeightEmphasis { public bool enable { get; set; } }
        public class LoadAutoBlinkEnable { public bool enable { get; set; } }
        public class LoadBlinkTimeMin { public float time { get; set; } }
        public class LoadBlinkTimeMax { public float time { get; set; } }
        public class LoadCloseAnimationTime { public float time { get; set; } }
        public class LoadOpenAnimationTime { public float time { get; set; } }
        public class LoadClosingTime { public float time { get; set; } }
        public class LoadDefaultFace { public string face { get; set; } }
        public class LoadHandRotations { public float LeftHandRotation { get; set; } public float RightHandRotation { get; set; } }

        public class LoadControllerTouchPadPoints
        {
            public bool IsOculus { get; set; }
            public List<UPoint> LeftPoints { get; set; }
            public bool LeftCenterEnable { get; set; }
            public List<UPoint> RightPoints { get; set; }
            public bool RightCenterEnable { get; set; }
        }
        public class LoadKeyActions { public List<KeyAction> KeyActions { get; set; } }

        public class ChangeCamera { public CameraTypes type { get; set; } }
        public class SetGridVisible { public bool enable { get; set; } }
        public class SetCameraMirror { public bool enable { get; set; } }

        public class KeyDown
        {
            public KeyConfig Config { get; set; }
        }

        public class KeyUp
        {
            public KeyConfig Config { get; set; }
        }

        public class SetControllerTouchPadPoints
        {
            public bool IsOculus { get; set; }
            public List<UPoint> LeftPoints { get; set; }
            public bool LeftCenterEnable { get; set; }
            public List<UPoint> RightPoints { get; set; }
            public bool RightCenterEnable { get; set; }
        }

        public class StartHandCamera
        {
            public bool IsLeft { get; set; }
        }

        public class EndHandCamera { }

        public class SetHandAngle
        {
            public bool LeftEnable { get; set; }
            public bool RightEnable { get; set; }
            public List<int> HandAngles { get; set; } //小指:第1関節,第3関節,第3関節,第3関節横,薬指:・・・・親指:・・・第3関節横 (20個)
        }

        public class StartKeyConfig { }
        public class EndKeyConfig { }

        public class SetKeyActions
        {
            public List<KeyAction> KeyActions { get; set; }
        }

        public class SetFace
        {
            public List<string> Keys { get; set; }
            public List<float> Strength { get; set; }
        }

        public class GetFaceKeys { }
        public class ReturnFaceKeys
        {
            public List<string> Keys { get; set; }
        }

        public class SetHandRotations { public float LeftHandRotation { get; set; } public float RightHandRotation { get; set; } }

        public class SetExternalCameraConfig
        {
            public float x { get; set; }
            public float y { get; set; }
            public float z { get; set; }
            public float rx { get; set; }
            public float ry { get; set; }
            public float rz { get; set; }
            public float fov { get; set; }
            public string ControllerName { get; set; }
        }
        public class GetExternalCameraConfig
        {
            public string ControllerName { get; set; }
        }


        public class ExitControlPanel { }

        public class GetTrackerSerialNumbers { }
        public class ReturnTrackerSerialNumbers
        {
            public List<Tuple<string, string>> List { get; set; }
            public SetTrackerSerialNumbers CurrentSetting { get; set; }
        }

        public class TrackerMoved
        {
            public string SerialNumber { get; set; }
        }

        public class SetTrackerSerialNumbers
        {
            public Tuple<string, string> Head { get; set; }
            public Tuple<string, string> LeftHand { get; set; }
            public Tuple<string, string> RightHand { get; set; }
            public Tuple<string, string> Pelvis { get; set; }
            public Tuple<string, string> LeftFoot { get; set; }
            public Tuple<string, string> RightFoot { get; set; }
            public Tuple<string, string> LeftElbow { get; set; }
            public Tuple<string, string> RightElbow { get; set; }
            public Tuple<string, string> LeftKnee { get; set; }
            public Tuple<string, string> RightKnee { get; set; }
        }

        public class GetTrackerOffsets { }
        public class SetTrackerOffsets
        {
            public float LeftHandTrackerOffsetToBottom { get; set; }
            public float LeftHandTrackerOffsetToBodySide { get; set; }
            public float RightHandTrackerOffsetToBottom { get; set; }
            public float RightHandTrackerOffsetToBodySide { get; set; }
        }

        public class GetVirtualWebCamConfig { }
        public class SetVirtualWebCamConfig
        {
            public bool Enabled { get; set; }
            public bool Resize { get; set; }
            public bool Mirroring { get; set; }
            public int Buffering { get; set; }
        }

        public class GetResolutions { }
        public class ReturnResolutions
        {
            public List<Tuple<int, int, int>> List { get; set; }
        }
        public class SetResolution
        {
            public int Width { get; set; }
            public int Height { get; set; }
            public int RefreshRate { get; set; }
        }

        public class SetWindowNum
        {
            public int Num { get; set; }
        }
    }


    public enum CameraTypes
    {
        Free, Front, Back, PositionFixed
    }

    public struct UPoint
    {
        public float x;
        public float y;
    }

    public enum KeyTypes
    {
        Controller,
        Keyboard,
        Mouse,
    }

    public enum KeyActionTypes
    {
        Face,
        Hand,
    }

    [Serializable]
    public class KeyConfig
    {
        public static string Language = "Japanese";

        public KeyTypes type;
        public KeyActionTypes actionType;
        public int keyCode;
        public string keyName;
        public bool isLeft;
        public int keyIndex;
        [OptionalField]
        public bool isOculus;
        [OptionalField]
        public bool isTouch;

        public bool IsEqual(KeyConfig k)
        {
            return type == k.type && actionType == k.actionType && keyCode == k.keyCode && isLeft == k.isLeft && keyIndex == k.keyIndex && isOculus == k.isOculus && isTouch == k.isTouch;
        }

        public bool IsEqualKeyCode(KeyConfig k)
        {
            return type == k.type && keyCode == k.keyCode && isLeft == k.isLeft && keyIndex == k.keyIndex && isOculus == k.isOculus && isTouch == k.isTouch;
        }

        private static Dictionary<int, string> EVRButtonIdString = new Dictionary<int, string>
        {
            { 0, "システム" },
            { 1, "メニュー" },
            { 2, "グリップ" },
            { 3, "パッド左" },
            { 4, "パッド上" },
            { 5, "パッド右" },
            { 6, "パッド下" },
            { 7, "Aボタン" },
            { 31, "近接センサ" },
            { 32, "タッチパッド" },
            { 33, "トリガー" },
            { 34, "軸2" },
            { 35, "軸3" },
            { 36, "軸4" },
            { 64, "最大値" }
        };

        private static Dictionary<int, string> EVRButtonIdString_Oculus = new Dictionary<int, string>
        {
            { 0, "システム" },
            { 1, "B/Yボタン" },
            { 2, "中指トリガー" },
            { 3, "パッド左" },
            { 4, "パッド上" },
            { 5, "パッド右" },
            { 6, "パッド下" },
            { 7, "A/Xボタン" },
            { 31, "近接センサ" },
            { 32, "スティック" },
            { 33, "人差し指トリガー" },
            { 34, "軸2" },
            { 35, "軸3" },
            { 36, "軸4" },
            { 64, "最大値" }
        };

        private static Dictionary<int, string> EVRButtonIdString_English = new Dictionary<int, string>
        {
            { 0, "System" },
            { 1, "Menu" },
            { 2, "Grip" },
            { 3, "PadLeft" },
            { 4, "PadUp" },
            { 5, "PadRight" },
            { 6, "PadDown" },
            { 7, "AButton" },
            { 31, "ProximitySensor" },
            { 32, "TouchPad" },
            { 33, "Trigger" },
            { 34, "Axis2" },
            { 35, "Axis3" },
            { 36, "Axis4" },
            { 64, "Max" }
        };

        private static Dictionary<int, string> EVRButtonIdString_Oculus_English = new Dictionary<int, string>
        {
            { 0, "System" },
            { 1, "B/YButton" },
            { 2, "MiddleFingerTrigger" },
            { 3, "PadLeft" },
            { 4, "PadUp" },
            { 5, "PadRight" },
            { 6, "PadDown" },
            { 7, "A/XButton" },
            { 31, "ProximitySensor" },
            { 32, "Stick" },
            { 33, "IndexFingerTrigger" },
            { 34, "Axis2" },
            { 35, "Axis3" },
            { 36, "Axis4" },
            { 64, "Max" }
        };

        private static string[] KeyCodeString = new string[] {
            "",
            "左クリック",
            "右クリック",
            "コントロールブレイク",
            "中クリック",
            "マウス第一拡張",
            "マウス第二拡張",
            "未定義",
            "BackSpace",
            "Tab",
            "予約済",
            "予約済",
            "Clear",
            "Enter",
            "未定義",
            "未定義",
            "Shift",
            "Ctrl",
            "Alt",
            "Pause",
            "CapsLock",
            "IME かな",
            "未定義",
            "IME Junja",
            "IME ファイナル",
            "IME 漢字",
            "未定義",
            "Esc",
            "IME 変換",
            "IME 無変換",
            "IME 使用可能",
            "IME モード変更要求",
            "スペース",
            "Page Up",
            "Page Down",
            "End",
            "Home",
            "←",
            "↑",
            "→",
            "↓",
            "Select",
            "Print",
            "Execute",
            "PrintScreen",
            "Insert",
            "Delete",
            "Help",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "未定義",
            "未定義",
            "未定義",
            "未定義",
            "未定義",
            "未定義",
            "未定義",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "左Windows",
            "右Windows",
            "アプリケーション",
            "予約済",
            "Sleep",
            "テンキー0",
            "テンキー1",
            "テンキー2",
            "テンキー3",
            "テンキー4",
            "テンキー5",
            "テンキー6",
            "テンキー7",
            "テンキー8",
            "テンキー9",
            "テンキー*",
            "テンキー+",
            "区切り記号",
            "テンキー-",
            "テンキー.",
            "テンキー/",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "F13",
            "F14",
            "F15",
            "F16",
            "F17",
            "F18",
            "F19",
            "F20",
            "F21",
            "F22",
            "F23",
            "F24",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "NumLock",
            "ScrollLock",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "未割当",
            "左Shift",
            "右Shift",
            "左Ctrl",
            "右Ctrl",
            "左Alt",
            "右Alt",
            "ブラウザー戻る",
            "ブラウザー進む",
            "ブラウザー更新",
            "ブラウザー停止",
            "ブラウザー検索",
            "ブラウザーお気に入り",
            "ブラウザー開始/ホーム",
            "音量ミュート",
            "音量ダウン",
            "音量アップ",
            "次のトラック",
            "前のトラック",
            "メディア停止",
            "メディア再生/一時停止",
            "メール",
            "メディア選択",
            "アプリケーション1",
            "アプリケーション2",
            "予約済",
            "予約済",
            "[:*]",
            "[;+]",
            "[,<]",
            "[-=]",
            "[.>]",
            "[/?]",
            "[@`]",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "予約済",
            "未割当",
            "未割当",
            "未割当",
            "[[{]",
            "[\\|]",
            "[]}]",
            "[^~]",
            "OEM8",
            "予約済",
            "OEM固有",
            "[＼_]",
            "OEM固有",
            "OEM固有",
            "IME PROCESS",
            "OEM固有",
            "仮想キー下位ワード",
            "未割当",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "英数",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "OEM固有",
            "Attn",
            "CrSel",
            "ExSel",
            "Erase EOF",
            "Play",
            "Zoom",
            "予約済",
            "PA1",
            "Clear",
            ""
        };

        private static string[] KeyCodeString_English = new string[] {
            "",
            "LeftClick",
            "RightClick",
            "ControlBreak",
            "CenterClick",
            "MouseAdditional1",
            "MouseAdditional2",
            "Undefined",
            "BackSpace",
            "Tab",
            "Reserved",
            "Reserved",
            "Clear",
            "Enter",
            "Undefined",
            "Undefined",
            "Shift",
            "Ctrl",
            "Alt",
            "Pause",
            "CapsLock",
            "IME Kana",
            "Undefined",
            "IME Junja",
            "IME Final",
            "IME Kanji",
            "Undefined",
            "Esc",
            "IME Henkan",
            "IME Muhenkan",
            "IME CanUse",
            "IME ChangeModeRequest",
            "Space",
            "Page Up",
            "Page Down",
            "End",
            "Home",
            "←",
            "↑",
            "→",
            "↓",
            "Select",
            "Print",
            "Execute",
            "PrintScreen",
            "Insert",
            "Delete",
            "Help",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "Undefined",
            "Undefined",
            "Undefined",
            "Undefined",
            "Undefined",
            "Undefined",
            "Undefined",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "LeftWindows",
            "RightWindows",
            "Application",
            "Reserved",
            "Sleep",
            "NumPad0",
            "NumPad1",
            "NumPad2",
            "NumPad3",
            "NumPad4",
            "NumPad5",
            "NumPad6",
            "NumPad7",
            "NumPad8",
            "NumPad9",
            "NumPad*",
            "NumPad+",
            "SeparateSymbol",
            "NumPad-",
            "NumPad.",
            "NumPad/",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12",
            "F13",
            "F14",
            "F15",
            "F16",
            "F17",
            "F18",
            "F19",
            "F20",
            "F21",
            "F22",
            "F23",
            "F24",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NumLock",
            "ScrollLock",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "LeftShift",
            "RightShift",
            "LeftCtrl",
            "RightCtrl",
            "LeftAlt",
            "RightAlt",
            "BrowserBack",
            "BrowserNext",
            "BrowserRefresh",
            "BrowserStop",
            "BrowserSearch",
            "BrowserFavorite",
            "BrowserHome",
            "VolumeMute",
            "VolumeDown",
            "VolumeUp",
            "NextTrack",
            "PrevTrack",
            "MediaStop",
            "MediaPlay/Pause",
            "Mail",
            "MediaSelect",
            "Application1",
            "Application2",
            "Reserved",
            "Reserved",
            "[:*]",
            "[;+]",
            "[,<]",
            "[-=]",
            "[.>]",
            "[/?]",
            "[@`]",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "Reserved",
            "NoAssign",
            "NoAssign",
            "NoAssign",
            "[[{]",
            "[\\|]",
            "[]}]",
            "[^~]",
            "OEM8",
            "Reserved",
            "OEM",
            "[＼_]",
            "OEM",
            "OEM",
            "IME PROCESS",
            "OEM",
            "VirtualKeyBottomWord",
            "NoAssign",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "Eisuu",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "OEM",
            "Attn",
            "CrSel",
            "ExSel",
            "Erase EOF",
            "Play",
            "Zoom",
            "Reserved",
            "PA1",
            "Clear",
            ""
        };
        public override string ToString()
        {
            if (Language == "Japanese")
            {
                var isLeftStr = type == KeyTypes.Controller ? (isLeft ? "左" : "右") : "";
                var keyCodeStr = type == KeyTypes.Controller ? (isOculus ? EVRButtonIdString_Oculus[keyCode] : EVRButtonIdString[keyCode]) : KeyCodeString[keyCode];
                var indexStr = keyIndex > 0 ? $"{keyIndex}" : "";
                var keyTypesString = type == KeyTypes.Controller ? "コントローラー" : type == KeyTypes.Keyboard ? "キーボード" : "マウス";
                var isTouchStr = type == KeyTypes.Controller ? (isTouch ? "タッチ" : "") : "";
                return $"{isLeftStr}{keyTypesString}[{keyCodeStr}{indexStr}{isTouchStr}]";
            }
            else
            {
                var isLeftStr = type == KeyTypes.Controller ? (isLeft ? "Left" : "Right") : "";
                var keyCodeStr = type == KeyTypes.Controller ? (isOculus ? EVRButtonIdString_Oculus_English[keyCode] : EVRButtonIdString_English[keyCode]) : KeyCodeString_English[keyCode];
                var indexStr = keyIndex > 0 ? $"{keyIndex}" : "";
                var keyTypesString = type == KeyTypes.Controller ? "Controller" : type == KeyTypes.Keyboard ? "Keyboard" : "Mouse";
                var isTouchStr = type == KeyTypes.Controller ? (isTouch ? "Touch" : "") : "";
                return $"{isLeftStr}{keyTypesString}[{keyCodeStr}{indexStr}{isTouchStr}]";
            }
        }
    }

    public class KeyEventArgs : EventArgs
    {
        public EVRButtonId ButtonId { get; }
        public float AxisX { get; }
        public float AxisY { get; }
        public bool IsLeft { get; }

        public KeyEventArgs(EVRButtonId buttonId, float axisX, float axisY, bool isLeft) : base()
        {
            ButtonId = buttonId; AxisX = axisX; AxisY = axisY; IsLeft = isLeft;
        }
    }

    public class KeyAction
    {
        public List<KeyConfig> KeyConfigs { get; set; }
        public bool IsKeyUp { get; set; }
        public string Name { get; set; }
        public bool OnlyPress { get; set; }
        public bool HandAction { get; set; }
        public List<int> HandAngles { get; set; }
        public Hands Hand { get; set; }
        public bool FaceAction { get; set; }
        public List<string> FaceNames { get; set; }
        public List<float> FaceStrength { get; set; }
        public bool FunctionAction { get; set; }
        public Functions Function { get; set; }
        public bool StopBlink { get; set; }
        public bool SoftChange { get; set; }

        public float HandChangeTime { get; set; } = 0.1f;
        public float LipSyncMaxLevel { get; set; } = 1.0f;
    }

    public enum Functions
    {
        ShowControlPanel = 0,
        ColorGreen = 1,
        ColorBlue = 2,
        ColorWhite = 3,
        ColorCustom = 4,
        ColorTransparent = 5,
        FrontCamera = 6,
        BackCamera = 7,
        FreeCamera = 8,
        PositionFixedCamera = 9,
    }

    public enum Hands
    {
        Left,
        Right,
        Both
    }

    public enum EVRButtonId
    {
        k_EButton_System = 0,
        k_EButton_ApplicationMenu = 1,
        k_EButton_Grip = 2,
        k_EButton_DPad_Left = 3,
        k_EButton_DPad_Up = 4,
        k_EButton_DPad_Right = 5,
        k_EButton_DPad_Down = 6,
        k_EButton_A = 7,
        k_EButton_ProximitySensor = 31,
        k_EButton_Axis0 = 32,
        k_EButton_Axis1 = 33,
        k_EButton_Axis2 = 34,
        k_EButton_Axis3 = 35,
        k_EButton_Axis4 = 36,
        k_EButton_SteamVR_Touchpad = 32,
        k_EButton_SteamVR_Trigger = 33,
        //k_EButton_Dashboard_Back = 2,
        k_EButton_Max = 64,
    }

    public class VRMData
    {
        public string FilePath { get; set; }

        public string ExporterVersion { get; set; }

        // Info
        public string Title { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
        public string ContactInformation { get; set; }
        public string Reference { get; set; }
        public byte[] ThumbnailPNGBytes { get; set; }

        // Permission
        public AllowedUser AllowedUser { get; set; }
        public UssageLicense ViolentUssage { get; set; }
        public UssageLicense SexualUssage { get; set; }
        public UssageLicense CommercialUssage { get; set; }
        public string OtherPermissionUrl { get; set; }

        // Distribution License
        public LicenseType LicenseType { get; set; }
        public string OtherLicenseUrl { get; set; }
    }

    public enum AllowedUser
    {
        OnlyAuthor,
        ExplicitlyLicensedPerson,
        Everyone,
    }

    public enum LicenseType
    {
        Redistribution_Prohibited,
        CC0,
        CC_BY,
        CC_BY_NC,
        CC_BY_SA,
        CC_BY_NC_SA,
        CC_BY_ND,
        CC_BY_NC_ND,
        Other
    }

    public enum UssageLicense
    {
        Disallow,
        Allow,
    }

}
