using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ColorChange :MonoBehaviour
{
 
    [MenuItem("ITools/colorChange")]
    static  void colorChange() {
        foreach (SpriteRenderer renderer in Selection.GetFiltered<SpriteRenderer>(SelectionMode.Deep)) {
            renderer.color = Color.white; ;
        }
    }
}
