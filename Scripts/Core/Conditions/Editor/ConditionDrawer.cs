﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ScriptableObjectFramework.Conditions.Editor
{
    [CustomPropertyDrawer(typeof(Condition), true)]
    public class ConditionDrawer : PropertyDrawer
    {
        const float buffer = 5;
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);
            float sectionSize = (position.width) / 4 - buffer;
            Rect executionModePosition = new Rect(position.x, position.y, sectionSize, position.height);
            Rect conditionPosition = new Rect(position.x + (buffer + sectionSize), position.y, sectionSize, position.height);
            Rect argumentPosition = new Rect(position.x + (buffer + sectionSize) * 2, position.y, sectionSize, position.height);
            Rect eventPosition = new Rect(position.x + (buffer + sectionSize) * 3, position.y, sectionSize, position.height);
            EditorGUI.PropertyField(executionModePosition, property.FindPropertyRelative("ExecutionMode"), GUIContent.none);
            EditorGUI.PropertyField(conditionPosition, property.FindPropertyRelative("Condition"), GUIContent.none);
            EditorGUI.PropertyField(argumentPosition, property.FindPropertyRelative("Argument"), GUIContent.none);
            EditorGUI.PropertyField(eventPosition, property.FindPropertyRelative("Event"), GUIContent.none);
            EditorGUI.EndProperty();
        }
    }
}
