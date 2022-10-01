using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof (EnemyBehavior))]
public class EnemyBehaviorEditor : Editor
{
    private void OnSceneGUI()
    {
        //Reference object
        EnemyBehavior enemyBehavior = (EnemyBehavior)target;
        //Draws viewRadius in Editor (circle)
        Handles.color = Color.white;
        Handles.DrawWireArc(enemyBehavior.transform.position, Vector3.up, Vector3.forward, 360, enemyBehavior.viewRadius);
        Vector3 viewAngleA = enemyBehavior.DirFromAngle(-enemyBehavior.viewAngle / 2, false);
        Vector3 viewAngleB = enemyBehavior.DirFromAngle(enemyBehavior.viewAngle / 2, false);

        //Draws line from origin to circle making the angle "walls"
        Handles.DrawLine(enemyBehavior.transform.position, enemyBehavior.transform.position + viewAngleA * enemyBehavior.viewRadius);
        Handles.DrawLine(enemyBehavior.transform.position, enemyBehavior.transform.position + viewAngleB * enemyBehavior.viewRadius);

        //Draw line to target, if visible
        Handles.color= Color.red;
        foreach(Transform visibleTarget in enemyBehavior.visibleTargets)
        {
            Handles.DrawLine(enemyBehavior.transform.position, visibleTarget.position);
        }
    }
}
