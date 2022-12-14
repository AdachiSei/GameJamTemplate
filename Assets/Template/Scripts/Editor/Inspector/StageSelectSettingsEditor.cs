using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(StageSelectSettings))]
public class StageSelectSettingsEditor : Editor
{
    #region Private Static Member

    private static bool _isOpening;

    #endregion

    #region Private Member

    private int _minValue = 1;
    private int _maxValue = 10;

    #endregion

    #region Override Method

    public override void OnInspectorGUI()
    {
        EditorGUI.BeginDisabledGroup(true);
        EditorGUILayout.ObjectField("Editor", MonoScript.FromScriptableObject(this), typeof(MonoScript), false);
        EditorGUI.EndDisabledGroup();

        base.OnInspectorGUI();

        var settings = target as StageSelectSettings;
        var style = new GUIStyle(EditorStyles.label);
        style.richText = true;

        EditorGUILayout.Space();

        _isOpening = EditorGUILayout.Foldout(_isOpening, "Settings");
        if (_isOpening)
        {
            EditorGUILayout.Space();

            EditorGUILayout.LabelField("<b>どれくらい離すか</b>", style);
            var floatField = EditorGUILayout.FloatField("スペース", settings.Range);
            settings.ChangeRange(floatField);
            bool isChangingValue = settings.StageParents[0].spacing != settings.Range;
            if (isChangingValue) settings.ChangeSpace(floatField);

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("<b>格納する</b>", style);
            var intField = EditorGUILayout.IntField("いくつずつか", settings.Count);
            var lessThanZero = settings.Count < _minValue;
            var overHundred = settings.Count > _maxValue;
            if (lessThanZero) intField = _minValue;
            else if (overHundred) intField = _maxValue;
            settings.ChangeCount(intField);
            if (GUILayout.Button("Set"))
            {
                settings.Setting(intField);
            }
        }
    }

    #endregion
}
