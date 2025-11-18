using System.Diagnostics;
using System.IO;
using UnityEngine;

public class GameLauncher : MonoBehaviour
{
    public void LaunchUniverse(string folder, string exeName)
    {
        string exePath = Path.Combine(Application.dataPath, "../Universes", folder, exeName);
        if (File.Exists(exePath))
        {
            Process.Start(exePath);
            Application.Quit(); // Optional: close launcher
        }
        else
        {
            UnityEngine.Debug.LogError("Executable not found: " + exePath);
        }
    }

    public void OnSonicButtonPressed() => LaunchUniverse("Simulator", "SonicGame.exe");
    public void OnEchoesButtonPressed() => LaunchUniverse("Echoes", "EchoesEternal.exe");
    public void OnFortressButtonPressed() => LaunchUniverse("Fortress", "FortressMurder.exe");

}
