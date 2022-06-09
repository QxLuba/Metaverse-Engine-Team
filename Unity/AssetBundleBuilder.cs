using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//构建WindowsAssetBundle
public class AssetBundleBuilder : Editor
{
    [MenuItem("Assets/Build AssetBundles")]
    static void BuildAllAssetBundles()
    {
        BuildPipeline.BuildAssetBundles(Application.dataPath+ "\\WindowsAssetBundle", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows);
        //构建WebGL
        //BuildPipeline.BuildAssetBundles(Application.dataPath+ "\\AssetBundle", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.WebGL);
    }
}
