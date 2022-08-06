using UnityEngine;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEditor;

public class EnemyDataEditor : OdinMenuEditorWindow
{
    [MenuItem("Tools/Enemy Data")]
    private static void OpenWindow()
    {
        GetWindow<EnemyDataEditor>().Show();               // Tools Kısmını oluşturdu
    }

    private CreateNewEnemyData createNewEnemyData;

    protected override void OnDestroy()
    {
        base.OnDestroy();
        if (createNewEnemyData != null)
        {
            DestroyImmediate(createNewEnemyData.enemyData);
        }
    }
    
    protected override OdinMenuTree BuildMenuTree()
    {
        var tree = new OdinMenuTree();
        createNewEnemyData = new CreateNewEnemyData();
        tree.Add("Create New",createNewEnemyData);
        tree.AddAllAssetsAtPath("EnemyData", "Assets/Scripts",typeof(EnemyData));
        
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
                EnemyData asset = selected.SelectedValue as EnemyData;
                string path = AssetDatabase.GetAssetPath(asset);
                AssetDatabase.DeleteAsset(path);
                AssetDatabase.SaveAssets();
            }
        }
        
        SirenixEditorGUI.EndHorizontalToolbar();
    }

    public class CreateNewEnemyData
    {
        public CreateNewEnemyData()
        {
            enemyData = ScriptableObject.CreateInstance<EnemyData>();
            enemyData.enemyName = "New Enemy Data";
        }
        [InlineEditor(ObjectFieldMode = InlineEditorObjectFieldModes.Hidden)]
        public EnemyData enemyData;
        
        
        //Create new instance of the CD
        [Button("Add New Enemy CD")]
        private void CreateNewData()
        {
            AssetDatabase.CreateAsset(enemyData,"Assets/Scripts/"+enemyData.enemyName + ".asset");
            AssetDatabase.SaveAssets();

            enemyData = ScriptableObject.CreateInstance<EnemyData>();
            enemyData.enemyName = "New Enemy Data";
        }
    }
  
}
