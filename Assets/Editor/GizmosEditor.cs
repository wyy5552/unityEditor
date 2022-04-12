using UnityEngine;
using UnityEditor;

public class GizmosEditor
{
    //  画一个cub线框，选中时为红色，补选中时为绿色
    [DrawGizmo(GizmoType.NonSelected | GizmoType.Active)]
    static void DrawExampleGizmos(GizmosTest example, GizmoType gizmoType)
    {
        var transform = example.transform;
        Gizmos.color = Color.green;
        //          new Color32 (145, 244, 139, 210);

        //Gizmos选中时为红色
        if ((gizmoType & GizmoType.Active) == GizmoType.Active)
            Gizmos.color = Color.red;

        Gizmos.DrawWireCube(transform.position, transform.lossyScale);
    }

    //  选中物体时画一个线框球
    [DrawGizmo(GizmoType.InSelectionHierarchy)]
    static void DrawExampleGizmos2(GizmosTest example, GizmoType gizmoType)
    {
        var transform = example.transform;
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, 2);
    }
}