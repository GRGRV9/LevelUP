using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CatalogManager))]
public class CatalogEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        
    }

}
