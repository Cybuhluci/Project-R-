using UnityEngine;
using UnityEngine.EventSystems;

public class ProjectRLauncherWindow : MonoBehaviour
{
    public GameObject DefaultBack;
    public GameObject SonicBack;
    public GameObject EchoesBack;
    public GameObject FortressBack;

    public void ShowDefault()
    {
        SetBackground(DefaultBack);
    }

    public void ShowSonic()
    {
        SetBackground(SonicBack);
    }

    public void ShowEchoes()
    {
        SetBackground(EchoesBack);
    }

    public void ShowFortress()
    {
        SetBackground(FortressBack);
    }

    private void SetBackground(GameObject activeBackground)
    {
        // Disable all
        DefaultBack.SetActive(false);
        SonicBack.SetActive(false);
        EchoesBack.SetActive(false);
        FortressBack.SetActive(false);

        // Enable the one we want
        if (activeBackground != null)
            activeBackground.SetActive(true);
    }
}
