﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using SharpDX.Direct2D1;
using FDK;

namespace DTXMania
{
    /// <summary>
    ///     一定時間ごとに、選択曲を囲む枠の上下辺を右から左へすーっと走る光。
    /// </summary>
    class 選択曲枠ランナー : IDisposable
    {

        // 生成と終了


        public 選択曲枠ランナー()
        {
            using( Log.Block( FDKUtilities.現在のメソッド名 ) )
            {
                this._ランナー画像 = new テクスチャ( @"$(System)images\選曲\枠ランナー.png" );
            }
        }

        public virtual void Dispose()
        {
            using( Log.Block( FDKUtilities.現在のメソッド名 ) )
            {
                this._ランナー画像?.Dispose();
            }
        }



        // 進行と描画


        public void リセットする()
        {
            // 0～2000ms: 非表示、2000～2300ms: 表示 のループ
            this._カウンタ = new LoopCounter( 0, 2300, 1 );
        }

        public void 進行描画する( DeviceContext dc )
        {
            if( null == this._カウンタ )
                return;

            if( 2000 <= this._カウンタ.現在値 )
            {
                float 割合 = ( this._カウンタ.現在値 - 2000 ) / 300f;    // 0→1

                // 上
                this._ランナー画像.描画する(
                    1920f - 割合 * ( 1920f - 1044f ),
                    485f - this._ランナー画像.サイズ.Height / 2f );

                // 下
                this._ランナー画像.描画する(
                    1920f - 割合 * ( 1920f - 1044f ),
                    598f - this._ランナー画像.サイズ.Height / 2f );
            }
        }



        // private


        private テクスチャ _ランナー画像 = null;

        private LoopCounter _カウンタ = null;
    }
}
