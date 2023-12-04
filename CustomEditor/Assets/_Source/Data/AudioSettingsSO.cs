using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Data
{
   [CreateAssetMenu(fileName = "NewAudioSettingsSO", menuName = "SO/New Audio Settings")]
   public class AudioSettingsSo : ScriptableObject
   {
      [SerializeField] private AudioTypes audioTypes;
      [SerializeField] private List<Audio> audioDangerous;
      [SerializeField] private List<Audio> audioFriendly;
      [SerializeField] private List<Audio> audioNeutral;
   
      [SerializeField, TextArea] private string text;
      [SerializeField] private string id;
   }
   [UnityEditor.CustomEditor(typeof(AudioSettingsSo)), CanEditMultipleObjects]
   public class CustomEditor: Editor
   {
      private SerializedProperty _text;
      private SerializedProperty _audioList;
      private SerializedProperty _idGui;
      private SerializedProperty _audioTypes;
      private bool _textOn;
      private bool _listOn;
   
   
   
   
      private void OnEnable()
      {
         _listOn = false;
         _textOn = false;
    
        
         _text = serializedObject.FindProperty("text");
         _idGui = serializedObject.FindProperty("id");

      }

      public override void OnInspectorGUI()
      {
         serializedObject.Update();
         _audioTypes = serializedObject.FindProperty("audioTypes");
         switch (_audioTypes.enumValueFlag)
         {
            case 0:
               _audioList = serializedObject.FindProperty("audioDangerous");
               break;
            case 1:
               _audioList = serializedObject.FindProperty("audioFriendly");
               break;
            case 2:
               _audioList = serializedObject.FindProperty("audioNeutral");
               break;
               
               
         }



         EditorGUILayout.PropertyField(_idGui);
         EditorGUILayout.PropertyField(_audioTypes);
         EditorGUILayout.BeginHorizontal();
         if (GUILayout.Button("Show List"))
            _listOn = true;
         if (GUILayout.Button("Show Text"))
            _textOn = true;
         if (GUILayout.Button("Hide"))
         {
            _listOn = false;
            _textOn = false;

         }
         EditorGUILayout.EndHorizontal();

         if (_listOn)
            EditorGUILayout.PropertyField(_audioList);
      
      
         if (_textOn)
            EditorGUILayout.PropertyField(_text);
      

         serializedObject.ApplyModifiedProperties();
      }
   }
}