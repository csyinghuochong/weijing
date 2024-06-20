#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace AllIn1VfxToolkit
{
    [CustomEditor(typeof(AllIn1VfxComponent)), CanEditMultipleObjects]
    public class AllIn1VfxEditor : UnityEditor.Editor
    {
        private GUIStyle smallBoldLabel;

        public override void OnInspectorGUI()
        {
            Texture2D imageInspector = Resources.Load<Texture2D>("CustomEditorTransparent");
            if(imageInspector)
            {
                Rect rect = EditorGUILayout.GetControlRect(GUILayout.Height(32));
                GUI.DrawTexture(rect, imageInspector, ScaleMode.ScaleToFit, true);
            }

            if(GUILayout.Button("Deactivate All Effects"))
            {
                for(int i = 0; i < targets.Length; i++) ((AllIn1VfxComponent) targets[i]).ClearAllKeywords();
                AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Deactivated All Effects");
            }

            if(GUILayout.Button("New Clean Material"))
            {
                bool successOperation = true;
                for(int i = 0; i < targets.Length; i++)
                {
                    successOperation &= ((AllIn1VfxComponent) targets[i]).TryCreateNew();
                }
                if(successOperation) AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Clean Material");
            }

            if(GUILayout.Button("Create New Material With Same Properties (SEE DOC)"))
            {
                bool successOperation = true;
                for(int i = 0; i < targets.Length; i++)
                {
                    successOperation &= ((AllIn1VfxComponent) targets[i]).MakeCopy();
                }
                if(successOperation) AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Copy Created");
            }

            if(GUILayout.Button("Save Material To Folder (SEE DOC)"))
            {
                bool successOperation = true;
                for(int i = 0; i < targets.Length; i++)
                {
                    successOperation &= ((AllIn1VfxComponent) targets[i]).SaveMaterial();
                }
                if(successOperation) AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Material Saved");
            }

            if(GUILayout.Button("Apply Material To All Children"))
            {
                bool successOperation = true;
                for(int i = 0; i < targets.Length; i++)
                {
                    successOperation &= ((AllIn1VfxComponent) targets[i]).ApplyMaterialToHierarchy();
                }
                if(successOperation) AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Material Applied To Children");
            }

            if(GUILayout.Button("Render Material To Image"))
            {
                
                bool successOperation = true;
                for(int i = 0; i < targets.Length; i++)
                {
                    successOperation &= ((AllIn1VfxComponent) targets[i]).RenderToImage();
                }
                if(successOperation) AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Material Rendered To Image");
            }

            CheckIfShowParticleSystemHelperUI();

            EditorGUILayout.Space();
            DrawLine(Color.grey, 1, 3);

            if(GUILayout.Button("Remove Component"))
            {
                for(int i = targets.Length - 1; i >= 0; i--)
                {
                    DestroyImmediate(targets[i] as AllIn1VfxComponent);
                    (targets[i] as AllIn1VfxComponent)?.SetSceneDirty();
                }
                AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Component Removed");
            }

            if(GUILayout.Button("REMOVE COMPONENT AND MATERIAL"))
            {
                for(int i = 0; i < targets.Length; i++) ((AllIn1VfxComponent) targets[i]).CleanMaterial();
                for(int i = targets.Length - 1; i >= 0; i--)
                {
                    DestroyImmediate(targets[i] as AllIn1VfxComponent);
                    (targets[i] as AllIn1VfxComponent)?.SetSceneDirty();
                }
                AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Component And Material Removed");
            }
        }

        private void CheckIfShowParticleSystemHelperUI()
        {
            if(Selection.activeGameObject?.GetComponent<ParticleSystem>() == null) return;
            AllIn1ParticleHelperComponent all1VfxPsHelper = Selection.activeGameObject.GetComponent<AllIn1ParticleHelperComponent>();
            if(all1VfxPsHelper != null) return;
            DrawLine(Color.grey, 1, 3);
            EditorGUILayout.Space();
            if(GUILayout.Button("Add Particle System Helper"))
            {
                for(int i = 0; i < targets.Length; i++) ((AllIn1VfxComponent) targets[i]).AddHelperAndPlaceUnderAll1VfxMainComponent();
                AllIn1VfxWindow.ShowSceneViewNotification("AllIn1Vfx: Particle System Helper Added");
            }
        }

        private void DrawLine(Color color, int thickness = 2, int padding = 10)
        {
            Rect r = EditorGUILayout.GetControlRect(GUILayout.Height(padding + thickness));
            r.height = thickness;
            r.y += (padding / 2f);
            r.x -= 2;
            r.width += 6;
            EditorGUI.DrawRect(r, color);
        }
    }
}
#endif