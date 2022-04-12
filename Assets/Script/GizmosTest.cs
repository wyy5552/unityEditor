using UnityEngine;
using System.Collections;

public class GizmosTest : MonoBehaviour
{


    //  选中时绘制一个方块
    void OnDrawGizmosSelected()
    {
        //Gizmos.DrawCube(transform.position + Vector3.up, Vector3.one);

    }
    //  绘制一个球
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 1.2f);
    }
}
