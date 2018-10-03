 C# example
using UnityEditor;
class MyEditorScript
{
     static void PerformBuild ()
     {
         string[] scenes = { Assets/Scenes/Sample2.unity };
         BuildPipeline.BuildPlayer(scenes, ...);
     }
}