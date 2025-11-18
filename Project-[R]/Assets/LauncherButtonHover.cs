using UnityEngine;
using UnityEngine.EventSystems;

public class LauncherButtonHover : MonoBehaviour, IPointerEnterHandler
{
    public enum LauncherBackground { Default, Sonic, Echoes, Fortress }
    public LauncherBackground backgroundType;
    public ProjectRLauncherWindow launcher;

    public void OnPointerEnter(PointerEventData eventData)
    {
        switch (backgroundType)
        {
            case LauncherBackground.Default:
                launcher.ShowDefault();
                break;
            case LauncherBackground.Sonic:
                launcher.ShowSonic();
                break;
            case LauncherBackground.Echoes:
                launcher.ShowEchoes();
                break;
            case LauncherBackground.Fortress:
                launcher.ShowFortress();
                break;
        }
    }
}
