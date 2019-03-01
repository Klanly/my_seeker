﻿/********************************************************************
	created:  2018-6-11 10:4:27
	filename: FPSDisplay.cs
	author:	  songguangze@fotoable.com
	
	purpose:  显示FPS
*********************************************************************/
using UnityEngine;

namespace EngineCore.Utility
{
    public class FPSDisplay : MonoBehaviour
    {
        private float deltaTime = 0.0f;

        void Update()
        {
            deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        }

        void OnGUI()
        {
            int w = Screen.width, h = Screen.height;

            GUIStyle style = new GUIStyle();
            Rect rect = new Rect(0, 0, w, h * 2 / 100);
            style.alignment = TextAnchor.UpperLeft;
            style.fontSize = h * 2 / 80;
            style.normal.textColor = Color.red;
            float msec = deltaTime * 1000.0f;
            float fps = 1.0f / deltaTime;
            string text = string.Format("{0:0.0} ms ({1:0.} fps)", msec, fps);
            GUI.Label(rect, text, style);
        }

    }
}