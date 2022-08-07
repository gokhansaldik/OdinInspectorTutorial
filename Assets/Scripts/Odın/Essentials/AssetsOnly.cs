using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Odın.Essentials
{
    public class AssetsOnly : MonoBehaviour
    {
        // Nesnenin sahnede değil projeden olduğuna emin olmak için kullanabiliriz.
    
        [Title("Assets Only")]   // başlık kısmımız
    
        [AssetsOnly]  //yalnızca assetler için
        public List<GameObject> OnlyPrefabs;
    
        [AssetsOnly]
        public GameObject SomePrefab;
    
        [AssetsOnly]
        public Material MaterialAsset;
    
        [AssetsOnly]
        public MeshRenderer SomeMeshRendererOnPrefab;

        [Title("Scene Objects Only")] // başlık kısmımız
    
        [SceneObjectsOnly]  //yalnızca sahne objeleri için
        public List<GameObject> OnlySceneObjects;
    
        [SceneObjectsOnly]
        public GameObject SomeSceneObject;
    
        [SceneObjectsOnly]
        public MeshRenderer SomeMeshRenderer;

    }
}
