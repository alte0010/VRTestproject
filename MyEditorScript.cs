 C# example
using UnityEditor;
class MyEditorScript
{
     static void PerformBuild ()
     {
         string[] scenes = { AssetsMyScene.unity };
         BuildPipeline.BuildPlayer(scenes, ...);
     }
}