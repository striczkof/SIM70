using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;
using Sim70;

namespace Sim70
{

    public partial class GithubRelease
    {
        public Uri? Url { get; set; }

        public Uri? AssetsUrl { get; set; }

        public string? UploadUrl { get; set; }

        public Uri? HtmlUrl { get; set; }

        public long Id { get; set; }

        public Author? Author { get; set; }

        public string? NodeId { get; set; }

        public string? TagName { get; set; }

        public string? TargetCommitish { get; set; }

        public string? Name { get; set; }

        public bool Draft { get; set; }

        public bool Prerelease { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset PublishedAt { get; set; }

        public Asset[]? Assets { get; set; }

        public Uri? TarballUrl { get; set; }

        public Uri? ZipballUrl { get; set; }

        public string? Body { get; set; }
    }

    public partial class Asset
    {
        public Uri? Url { get; set; }

        public long Id { get; set; }

        public string? NodeId { get; set; }

        public string? Name { get; set; }

        public object? Label { get; set; }

        public Author? Uploader { get; set; }

        public string? ContentType { get; set; }

        public string? State { get; set; }

        public long Size { get; set; }

        public long DownloadCount { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public DateTimeOffset UpdatedAt { get; set; }

        public Uri? BrowserDownloadUrl { get; set; }
    }

    public partial class Author
    {
        public string? Login { get; set; }

        public long Id { get; set; }

        public string? NodeId { get; set; }

        public Uri? AvatarUrl { get; set; }

        public string? GravatarId { get; set; }

        public Uri? Url { get; set; }

        public Uri? HtmlUrl { get; set; }

        public Uri? FollowersUrl { get; set; }

        public string? FollowingUrl { get; set; }

        public string? GistsUrl { get; set; }

        public string? StarredUrl { get; set; }

        public Uri? SubscriptionsUrl { get; set; }

        public Uri? OrganizationsUrl { get; set; }

        public Uri? ReposUrl { get; set; }

        public string? EventsUrl { get; set; }

        public Uri? ReceivedEventsUrl { get; set; }

        public string? Type { get; set; }

        public bool SiteAdmin { get; set; }
    }

    class Github
    {

        public GithubRelease? GetCurrentVersion(string repo = "lkd70/sim70")
        {
            using (var client = new HttpClient())
            {

                client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("SIM70", "5"));
                var response = client.GetAsync("https://api.github.com/repos/lkd70/sim70/releases/latest").Result;

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content;
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                    GithubRelease? result = JsonSerializer.Deserialize<GithubRelease>(responseString, options);
                    return result;
                }
                else
                {
                    return null;
                }
            }

            // var data = JsonSerializer.Deserialize<GithubReleaseVersion>(res);
            // return data;
        }
    }
}