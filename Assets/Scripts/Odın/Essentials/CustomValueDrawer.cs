using System;
using UnityEngine;
using UnityEngine.AI;
using Sirenix.OdinInspector;
using Sirenix.Utilities.Editor;
using UnityEditor;

namespace UnityTemplateProjects.Odın.Essentials
{
    // Tek seferlik değer oluşturmak yerine değeri değiştireceğimiz aralığı oluşturmamıza yarar.
    public class CustomValueDrawer : MonoBehaviour
    {
        public float From;
        public float To;
        
        [CustomValueDrawer("DrawSlider")] 
        public float ValueInBetween;

        private float DrawSlider(float value, GUIContent label)
        {
            return EditorGUILayout.Slider(label, value, this.From, this.To);
        }
    }
}