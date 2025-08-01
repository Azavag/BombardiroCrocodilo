using UnityEditor;
using System;

public class BuildScript
{
    public static void BuildGame()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };
        string buildPath = "D:/Build";

        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = scenes;
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.StandaloneWindows64;
        buildPlayerOptions.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}