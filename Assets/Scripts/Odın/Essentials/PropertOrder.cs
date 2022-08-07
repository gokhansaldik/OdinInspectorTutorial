using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;

using UnityEngine;

public class PropertOrder : MonoBehaviour
{
   // Özelliklerin hangi sıra ile gösterileceğini tanımlamak için kullanabiliriz.
   
   [PropertyOrder(1)]
   public int Second;

   [InfoBox("PropertyOrder, inspector'deki ozelliklerin sirasini degistirmek icin kullanilir.")]
   [PropertyOrder(-1)]
   public int First;

}
