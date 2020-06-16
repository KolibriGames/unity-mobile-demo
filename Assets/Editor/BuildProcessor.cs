﻿using UnityEditor;
using UnityEngine.Windows;

namespace Editor
{
    public static class BuildProcessor
    {
        [MenuItem("File/BuildProcessor/Android")]
        public static void PerformBuild()
        {
            var scenes = new[] { "Assets/Scenes/SampleScene.unity" };

            const string buildPath = "./Build/Android";
            Directory.CreateDirectory(buildPath);

            BuildPipeline.BuildPlayer(scenes, buildPath + "/demo.apk", BuildTarget.Android, BuildOptions.Development);
        }
    }
}
