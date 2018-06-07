using System.Linq;
using UnityEditor;
using UnityEngine;

namespace UnityModule {

    /// <summary>
    /// [SortingLayerName] 用の PropertyDrawer
    /// </summary>
    [CustomPropertyDrawer(typeof(SortingLayerNameAttribute))]
    public class SortingLayerNameDrawer : PropertyDrawer {

        /// <summary>
        /// プルダウンの内容のキャッシュ
        /// </summary>
        private GUIContent[] displayedOptions = new GUIContent[0];

        /// <summary>
        /// Unity lifecycle: OnGUI
        /// </summary>
        /// <param name="position">描画座標</param>
        /// <param name="property">対象プロパティ</param>
        /// <param name="label">ラベル</param>
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            // プルダウンの内容をキャッシュする
            if (this.displayedOptions == default(GUIContent[]) || this.displayedOptions.Length == 0) {
                this.displayedOptions = SortingLayer.layers.Select(x => new GUIContent(x.name)).ToArray();
            }

            int selectedIndex = 0;
            for (int i = 0; i < this.displayedOptions.Length; i++) {
                if (this.displayedOptions[i].text != property.stringValue) {
                    continue;
                }
                selectedIndex = i;
                break;
            }
            selectedIndex = EditorGUI.Popup(
                position,
                label,
                selectedIndex,
                this.displayedOptions
            );
            if (this.displayedOptions.Length <= selectedIndex) {
                return;
            }
            property.stringValue = this.displayedOptions[selectedIndex].text;
        }

    }

}