using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class UIElementsWindow : EditorWindow
{
    private const string WindowStructurePath = "Assets/Editor/UI/Finestra.uxml";
    private const string StylePath = "Assets/Editor/UI/prova.uss";
    
    [MenuItem("Tools/Finestra di prova")]
    public static void OpenWindow()
    {
        GetWindow<UIElementsWindow>();
    }

    private void CreateGUI()
    {
        VisualTreeAsset windowStructure =
            AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(WindowStructurePath);
        StyleSheet windowStyle = AssetDatabase.LoadAssetAtPath<StyleSheet>(StylePath);
        
        rootVisualElement.Add(windowStructure.Instantiate());
        rootVisualElement.styleSheets.Add(windowStyle);
    }
}
