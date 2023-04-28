// Editor code gatherred from https://www.sunnyvalleystudio.com/blog/unity-2d-sprite-preview-inspector-custom-editor


using UnityEditor;
using UnityEngine;

//We connect the editor with the Weapon SO class
[CustomEditor(typeof(ItemData))]
//We need to extend the Editor
public class WeaponEditor : Editor
{
    //Here we grab a reference to our Weapon SO
    ItemData item;

    private void OnEnable()
    {
        //target is by default available for you
        //because we inherite Editor
        item = target as ItemData;
    }

    //Here is the meat of the script
    public override void OnInspectorGUI()
    {
        //Draw whatever we already have in SO definition
        base.OnInspectorGUI();
        //Guard clause
        if (item.ItemSprite == null)
            return;

        //Convert the weaponSprite (see SO script) to Texture
        Texture2D texture = AssetPreview.GetAssetPreview(item.ItemSprite);
        //We crate empty space 80x80 (you may need to tweak it to scale better your sprite
        //This allows us to place the image JUST UNDER our default inspector
        GUILayout.Label("", GUILayout.Height(80), GUILayout.Width(80));
        //Draws the texture where we have defined our Label (empty space)
        GUI.DrawTexture(GUILayoutUtility.GetLastRect(), texture);
    }
}