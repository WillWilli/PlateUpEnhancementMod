using UnityEngine;

namespace Willi.EnhancementMod.Workshop.Helpers
{
    internal static class GuiStyles
    {
        public static GUIStyle WindowStyle
        {
            get
            {
                // set all text black
                var guiStyle = new GUIStyle(GUI.skin.window);
                guiStyle.normal.textColor = Color.black;
                guiStyle.normal.textColor = Color.black;
                guiStyle.active.textColor = Color.black;
                guiStyle.focused.textColor = Color.black;
                guiStyle.onNormal.textColor = Color.black;
                guiStyle.onActive.textColor = Color.black;
                guiStyle.onFocused.textColor = Color.black;

                // set background
                var tex = new Texture2D(1, 1);
                tex.SetPixel(0, 0, new Color(1, 1, 1, 0f));
                guiStyle.normal.background = tex;
                guiStyle.active.background = tex;
                guiStyle.focused.background = tex;
                guiStyle.hover.background = tex;
                guiStyle.onNormal.background = tex;
                guiStyle.onActive.background = tex;
                guiStyle.onFocused.background = tex;
                guiStyle.onHover.background = tex;
                return guiStyle; 
            }
        }

        public static GUIStyle LabelStyle
        {
            get
            {
                var textStyle = new GUIStyle(GUI.skin.label);
                textStyle.normal.textColor = Color.black;
                textStyle.active.textColor = Color.black;
                textStyle.focused.textColor = Color.black;
                textStyle.onNormal.textColor = Color.black;
                textStyle.onActive.textColor = Color.black;
                textStyle.onFocused.textColor = Color.black;

                textStyle.hover.textColor = Color.grey;
                textStyle.onHover.textColor = Color.grey;
                return textStyle;
            }
        }

        public static GUIStyle ButtonStyle
        {
            get
            {
                var buttonStyle = new GUIStyle(GUI.skin.button);
                buttonStyle.normal.textColor = Color.black;
                buttonStyle.normal.textColor = Color.black;
                buttonStyle.active.textColor = Color.black;
                buttonStyle.focused.textColor = Color.black;
                buttonStyle.onNormal.textColor = Color.black;
                buttonStyle.onActive.textColor = Color.black;
                buttonStyle.onFocused.textColor = Color.black;

                buttonStyle.hover.textColor = Color.yellow;
                buttonStyle.onHover.textColor = Color.yellow;
                return buttonStyle;
            }
        }

        public static GUIStyle ToggleStyle
        {
            get
            {
                var toggleStyle = new GUIStyle(GUI.skin.toggle);
                toggleStyle.normal.textColor = Color.black;
                toggleStyle.active.textColor = Color.black;
                toggleStyle.focused.textColor = Color.black;
                toggleStyle.onNormal.textColor = Color.black;
                toggleStyle.onActive.textColor = Color.black;
                toggleStyle.onFocused.textColor = Color.black;

                toggleStyle.hover.textColor = Color.yellow;
                toggleStyle.onHover.textColor = Color.yellow;
                return toggleStyle;
            }
        }

    }
}
