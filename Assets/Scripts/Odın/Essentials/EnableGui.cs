using UnityEngine;
using Sirenix.OdinInspector;

namespace Odın.Essentials
{
    public class EnableGui : MonoBehaviour
    {
        // Aksi halde devre dışı bırakılacak olan özelliklerin GUI'sini etkinleştirir.
        [ShowInInspector]
        public int GUIDisabledProperty { get { return 10; } }

        [ShowInInspector, EnableGUI]
        public int GUIEnabledProperty { get { return 10; } }
    }
}