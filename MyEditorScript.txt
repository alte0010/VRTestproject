 C# example
using UnityEditor;
class MyEditorScript
{
     static void PerformBuild ()
     {
         string[] scenes = { Assets/Scenes/Sample 2.unity };
         BuildPipeline.BuildPlayer(scenes, ...);
     }
}