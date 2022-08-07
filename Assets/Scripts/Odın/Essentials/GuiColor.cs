using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class GuiColor : MonoBehaviour
{
    // Gui rengini değiştirmede kullanılır.
    
    [GUIColor(0.3f, 0.8f, 0.8f, 1f)]
    public int ColoredInt1;

    [GUIColor(0.3f, 0.8f, 0.8f, 1f)]
    public int ColoredInt2;

    [ButtonGroup]
    [GUIColor(0, 1, 0)]
    private void Apply()
    {
    }

    [ButtonGroup]
    [GUIColor(1, 0.6f, 0.4f)]
    private void Cancel()
    {
    }

    [InfoBox("Bir özelliğin rengini dinamik olarak değiştirmek için")]
    [GUIColor("GetButtonColor")]
    [Button("I Am Fabulous", ButtonSizes.Gigantic)]
    private static void IAmFabulous()
    {
    }

    [Button(ButtonSizes.Large)]
    [GUIColor("@Color.Lerp(Color.red, Color.green, Mathf.Abs(Mathf.Sin((float)EditorApplication.timeSinceStartup)))")]
    private static void Expressive()
    {
    }

    private static Color GetButtonColor()
    {
        Sirenix.Utilities.Editor.GUIHelper.RequestRepaint();
        return Color.HSVToRGB(Mathf.Cos((float)UnityEditor.EditorApplication.timeSinceStartup + 1f) * 0.225f + 0.325f, 1, 1);
    }

}
