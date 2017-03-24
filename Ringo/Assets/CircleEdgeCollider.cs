using UnityEditor;
using UnityEngine;

// Adapted from http://answers.unity3d.com/questions/683090/rigidbody2d-trap-inside-a-circle.html
public class CircleEdgeCollider : EditorWindow
{
    float radius = 1.0f;
    int vertices = 30;

    [MenuItem("Component/Physics 2D/Circle Edge Collider 2D")]
    public static void ShowWindow()
    {
        //Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow<CircleEdgeCollider>("Add Component");
    }

    [MenuItem("Component/Physics 2D/Circle Edge Collider 2D", true)]
    public static bool IsObjectSelected()
    {
        return Selection.gameObjects.Length != 0;
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField("Circle Edge Collider 2D Properties");
        radius = EditorGUILayout.FloatField("Radius", radius);
        vertices = EditorGUILayout.IntField("Vertices", vertices);

        if (GUILayout.Button("Add Component"))
        {
            AddCircleEdgeCollider();
        }
    }

    void AddCircleEdgeCollider()
    {
        // Get selection
        GameObject[] sel;
        sel = Selection.gameObjects;
        if (sel.Length == 0) return;

        if (vertices < 2)
        {
            Debug.LogError("Can't create a circle edge collider with less than 2 points.");
            return;
        }

        // Create list of points
        Vector2[] pts = new Vector2[vertices];
        for (int i = 0; i < vertices; i++)
        {
            // Points on a circle
            Vector2 pt;
            pt.x = Mathf.Cos((i / ((float)vertices - 1.0f)) * (2f * Mathf.PI)) * radius;
            pt.y = Mathf.Sin((i / ((float)vertices - 1.0f)) * (2f * Mathf.PI)) * radius;
            pts[i] = pt;
        }

        GameObject obj;
        for (int i = 0; i < sel.Length; i++)
        {
            obj = sel[i];
            Debug.Log(obj.name);

            EdgeCollider2D coll = obj.GetComponent<EdgeCollider2D>();
            if (coll == null)
            {
                coll = obj.AddComponent<EdgeCollider2D>();
            }

            coll.points = pts;

        }
    }
}