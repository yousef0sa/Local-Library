using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class GitHubReleaseChecker
{
    private readonly string _repoOwner;
    private readonly string _repoName;
    private readonly HttpClient _httpClient;

    #region Set & Get

    /// <summary>
    /// Gets or sets the URL of the latest release.
    /// </summary>
    public string URL_lastest_release { get; set; }

    #endregion

    public GitHubReleaseChecker(string repoOwner, string repoName)
    {
        _repoOwner = repoOwner;
        _repoName = repoName;
        _httpClient = new HttpClient();
    }

    /// <summary>
    /// Checks if a new release is available for the GitHub repository.
    /// </summary>
    /// <param name="currentVersion">The current version of the software.</param>
    /// <returns>True if a new release is available, false otherwise.</returns>
    public async Task<bool> IsNewReleaseAvailable(string currentVersion)
    {
        var url = $"https://api.github.com/repos/{_repoOwner}/{_repoName}/releases/latest";
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("request"); // Necessary, GitHub requires a user-agent

        var response = await _httpClient.GetStringAsync(url);
        var latestRelease = JObject.Parse(response);
        var latestVersion = latestRelease["tag_name"].ToString();

        // set the URL of the latest release
        URL_lastest_release = latestRelease["html_url"].ToString();

        return !currentVersion.Equals(latestVersion, StringComparison.OrdinalIgnoreCase);
    }
}
