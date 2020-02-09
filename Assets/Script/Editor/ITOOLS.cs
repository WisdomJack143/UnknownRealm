using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class ITOOLS :MonoBehaviour
{
 
    [MenuItem("ITools/colorChange")]
    static  void colorChange() {
        foreach (SpriteRenderer renderer in Selection.GetFiltered<SpriteRenderer>(SelectionMode.Deep)) {
            renderer.color = Color.black ;
        }
    }
    [MenuItem("ITools/addRigBo")]
    static void addRigbo()
    {
        foreach (SpriteRenderer renderer in Selection.GetFiltered<SpriteRenderer>(SelectionMode.Deep))
        {
            Rigidbody2D rg = renderer.gameObject.AddComponent<Rigidbody2D>();
            rg.useAutoMass = true;
            rg.angularDrag = 0.05f;
            rg.drag = 0.01f;
        }
    }
    [MenuItem("ITools/addJoint")]
    static void addo()
    {
        foreach (SpriteRenderer renderer in Selection.GetFiltered<SpriteRenderer>(SelectionMode.Deep))
        {
            renderer.gameObject.AddComponent<HingeJoint2D>();
        }
    }
}
