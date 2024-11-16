using EmbedIO;
using UnityEngine;

public class ServerSceneControl : MonoBehaviour
{
    public enum WebsiteSource
    {
        SimpleWebsite, UnityWebsite
    }

    public WebsiteSource websiteSource = WebsiteSource.SimpleWebsite;

    private WebServer server;

    void Start()
    {
        string url = "http://localhost:8080/";
        string websitePath = $"{Application.streamingAssetsPath}/{websiteSource}";

        server = new WebServer(url);
        server.WithStaticFolder("/", websitePath, true);
        server.StateChanged += (s, e) => Debug.Log($"WebServer New State - {e.NewState}");
        server.RunAsync();

        Debug.Log($"Serving website on {url}");
    }

    void OnDestroy()
    {
        server.Dispose();
    }
}
