using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;


public class HideLabel : MonoBehaviour
{
    
    // Hide label herhangi bir özellikte kullanılabilir ve Inspector'de gizler.
    // Inspector'deki özelliklerin etiketini gizlemek için kullanılabilir.
    
    [Title("Wide Colors")]
    [HideLabel]
    [ColorPalette("Fall")]
    public Color WideColor1;

    [HideLabel]
    [ColorPalette("Fall")]
    public Color WideColor2;

    [Title("Wide Vector")]
    [HideLabel]
    public Vector3 WideVector1;

    [HideLabel]
    public Vector4 WideVector2;

    [Title("Wide String")]
    [HideLabel]
    public string WideString;

    [Title("Wide Multiline Text Field")]
    [HideLabel]
    [MultiLineProperty]
    public string WideMultilineTextField = "";

}
