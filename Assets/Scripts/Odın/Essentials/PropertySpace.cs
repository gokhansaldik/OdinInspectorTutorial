using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


public class PropertySpace : MonoBehaviour
{
    // PropertySpace ve Space nitelikleri neredeyse aynıdır.
    [Space]
    public int Space;

    // Ancak PropertySpace adından da anlaşılacağı gibi özelliklere de uygulanabilir.
    [ShowInInspector, PropertySpace]
    public string Property { get; set; }

    // Ayrıca PropertySpace özelliğinden önce ve sonra boşlukları kontrol edebilirsiniz.
    [PropertySpace(SpaceBefore = 0, SpaceAfter = 60), PropertyOrder(2)]
    public int BeforeAndAfter;

}
