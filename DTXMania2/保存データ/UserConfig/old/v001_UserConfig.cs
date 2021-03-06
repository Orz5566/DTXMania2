﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Data.Sqlite;

namespace DTXMania2.old.UserConfig
{
    class v001_UserConfig
    {
        public const int VERSION = 1;    // このクラスのバージョン


        // プロパティ


        /// <summary>
        ///     このクラスのバージョン。
        /// </summary>
        public int Version { get; set; }

        /// <summary>
        ///		ユーザを一意に識別する文字列。主キーなので変更不可。
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///		ユーザ名。変更可。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///		譜面スクロール速度の倍率。1.0で等倍。
        /// </summary>
        public double ScrollSpeed { get; set; }

        /// <summary>
        ///		起動直後の表示モード。
        ///		0: ウィンドウモード、その他: 全画面モード。
        /// </summary>
        public int Fullscreen { get; set; }

        /// <summary>
        ///		シンバルフリーモード。
        ///		0: OFF, その他: ON
        /// </summary>
        public int CymbalFree { get; set; }

        // AutoPlay

        /// <summary>
        ///		左シンバルレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_LeftCymbal { get; set; }

        /// <summary>
        ///		ハイハットレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_HiHat { get; set; }

        /// <summary>
        ///		左ペダルレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_LeftPedal { get; set; }

        /// <summary>
        ///		スネアレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_Snare { get; set; }

        /// <summary>
        ///		バスレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_Bass { get; set; }

        /// <summary>
        ///		ハイタムレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_HighTom { get; set; }

        /// <summary>
        ///		ロータムレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_LowTom { get; set; }

        /// <summary>
        ///		フロアタムレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_FloorTom { get; set; }

        /// <summary>
        ///		右シンバルレーンの AutoPlay 。
        ///		0: OFF, その他: ON。
        /// </summary>
        public int AutoPlay_RightCymbal { get; set; }

        // 最大ヒット距離

        /// <summary>
        ///		Perfect の最大ヒット距離[秒]。
        /// </summary>
        public double MaxRange_Perfect { get; set; }

        /// <summary>
        ///		Great の最大ヒット距離[秒]。
        /// </summary>
        public double MaxRange_Great { get; set; }

        /// <summary>
        ///		Good の最大ヒット距離[秒]。
        /// </summary>
        public double MaxRange_Good { get; set; }

        /// <summary>
        ///		Ok の最大ヒット距離[秒]。
        /// </summary>
        public double MaxRange_Ok { get; set; }



        // 生成と終了


        public v001_UserConfig()
        {
            this.Version = VERSION;
            this.Id = "Anonymous";
            this.Name = "Anonymous";
            this.ScrollSpeed = 1.0;
            this.Fullscreen = 0;
            this.CymbalFree = 1;
            this.AutoPlay_LeftCymbal = 1;
            this.AutoPlay_HiHat = 1;
            this.AutoPlay_LeftPedal = 1;
            this.AutoPlay_Snare = 1;
            this.AutoPlay_Bass = 1;
            this.AutoPlay_HighTom = 1;
            this.AutoPlay_LowTom = 1;
            this.AutoPlay_FloorTom = 1;
            this.AutoPlay_RightCymbal = 1;
            this.MaxRange_Perfect = 0.034;
            this.MaxRange_Great = 0.067;
            this.MaxRange_Good = 0.084;
            this.MaxRange_Ok = 0.117;
        }
    }
}
