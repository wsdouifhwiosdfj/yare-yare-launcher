using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Mod
{
    public class Module : ETGModule
    {
        public static readonly string MOD_NAME = "yari launcher rename";
        public static readonly string VERSION = "0.0.0";
        public static readonly string TEXT_COLOR = "#00FFFF";

        public override void Start()
        {
            Log($"{MOD_NAME} v{VERSION} didn't crash etg hooray.", TEXT_COLOR);
            Gun gun3 = PickupObjectDatabase.GetById(16) as Gun;
            gun3.SetName("Yare yare launcher");
        }

        public static void Log(string text, string color="FFFFFF")
        {
            ETGModConsole.Log($"<color={color}>{text}</color>");
        }

        public override void Exit() { }
        public override void Init() { }
    }
}
