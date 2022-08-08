using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEditor;
using Data.UnityObject;

namespace OdinEditor
{
    public class HomeBuilder : OdinMenuEditorWindow
    {
        [MenuItem("Tools/Home Data")]
        private static void OpenWindow()
        {
            GetWindow<HomeBuilder>().Show();               // Tools Kısmını oluşturdu
        }

        private CreateNewBuildData _createNewBuildData;

        protected override void OnDestroy()
        {
            base.OnDestroy();
            if (_createNewBuildData != null)
            {
                DestroyImmediate(_createNewBuildData.HomeData);
            }
        }

        

        protected override OdinMenuTree BuildMenuTree()
        {
            var tree = new OdinMenuTree();
            _createNewBuildData = new CreateNewBuildData();
            tree.Add("Create New", _createNewBuildData);
            tree.AddAllAssetsAtPath("HomeData", "Assets/Resources/Data", typeof(CD_Home));

            return tree;
        }

        protected override void OnBeginDrawEditors()
        {
            OdinMenuTreeSelection selected = this.MenuTree.Selection;
            SirenixEditorGUI.BeginHorizontalToolbar();
            {
                GUILayout.FlexibleSpace();

                if (SirenixEditorGUI.ToolbarButton("Delete Current"))
                {
                    CD_Home asset = selected.SelectedValue as CD_Home;
                    string path = AssetDatabase.GetAssetPath(asset);
                    AssetDatabase.DeleteAsset(path);
                    AssetDatabase.SaveAssets();
                }
            }

            SirenixEditorGUI.EndHorizontalToolbar();
        }


        public class CreateNewBuildData
        {
            public CreateNewBuildData()
            {
                HomeData = ScriptableObject.CreateInstance<CD_Home>();
                HomeData.BuildName = "New Build Data";
            }
            [InlineEditor(ObjectFieldMode = InlineEditorObjectFieldModes.Hidden)]
            public CD_Home HomeData;


            //Create new instance of the CD
            [Button("Add New Build CD")]
            private void CreateNewData()
            {
                AssetDatabase.CreateAsset(HomeData, "Assets/Resources/Data/" + HomeData.BuildName + ".asset");
                AssetDatabase.SaveAssets();

                HomeData = ScriptableObject.CreateInstance<CD_Home>();
                HomeData.BuildName = "New Build Data";
            }
        }


    }
}