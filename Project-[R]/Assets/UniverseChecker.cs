using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class UniverseChecker : MonoBehaviour
{
    public Button sonicButton;
    public Button echoesButton;
    public Button fortressButton;

    private string basePath;

    void Start()
    {
        basePath = Path.Combine(Application.dataPath, "../Universes");

        // Ensure the Universes folder exists
        if (!Directory.Exists(basePath))
        {
            Directory.CreateDirectory(basePath);
            Debug.Log("Created Universes folder at: " + basePath);
        }

        // Ensure subfolders exist
        CreateSubfolder("Echoes");
        CreateSubfolder("Simulator");
        CreateSubfolder("Fortress");

        // Check for executables in their respective folders
        CheckUniverse("Simulator", "SonicGame.exe", sonicButton);
        CheckUniverse("Echoes", "EchoesEternal.exe", echoesButton);
        CheckUniverse("Fortress", "FortressMurder.exe", fortressButton);
    }

    void CreateSubfolder(string folderName)
    {
        string fullPath = Path.Combine(basePath, folderName);
        if (!Directory.Exists(fullPath))
        {
            Directory.CreateDirectory(fullPath);
            Debug.Log("Created subfolder: " + folderName);
        }
    }

    void CheckUniverse(string folder, string exeName, Button button)
    {
        string fullPath = Path.Combine(basePath, folder, exeName);

        if (!File.Exists(fullPath))
        {
            button.interactable = false;
            Debug.LogWarning($"Missing {exeName} in {folder}.");
        }
        else
        {
            Debug.Log($"Found {exeName} in {folder}.");
        }
    }
}
