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
        public Uri? url { get; set; }

        public Uri? assets_url { get; set; }

        public string? upload_url { get; set; }

        public Uri? html_url { get; set; }

        public long id { get; set; }

        public Author? author { get; set; }

        public string? node_id { get; set; }

        public string? tag_name { get; set; }

        public string? target_commitish { get; set; }

        public string? name { get; set; }

        public bool draft { get; set; }

        public bool prerelease { get; set; }

        public DateTimeOffset created_at { get; set; }

        public DateTimeOffset publishedat { get; set; }

        public Asset[]? assets { get; set; }

        public Uri? tarball_url { get; set; }

        public Uri? zipball_url { get; set; }

        public string? body { get; set; }
    }

    public partial class Asset
    {
        public Uri? url { get; set; }

        public long id { get; set; }

        public string? node_id { get; set; }

        public string? name { get; set; }

        public object? label { get; set; }

        public Author? uploader { get; set; }

        public string? content_type { get; set; }

        public string? state { get; set; }

        public long size { get; set; }

        public long download_count { get; set; }

        public DateTimeOffset created_at { get; set; }

        public DateTimeOffset updated_at { get; set; }

        public Uri? browser_download_url { get; set; }
    }

    public partial class Author
    {
        public string? login { get; set; }

        public long id { get; set; }

        public string? node_id { get; set; }

        public Uri? avatar_url { get; set; }

        public string? gravatar_id { get; set; }

        public Uri? url { get; set; }

        public Uri? html_url { get; set; }

        public Uri? followers_url { get; set; }

        public string? following_url { get; set; }

        public string? gists_url { get; set; }

        public string? starred_url { get; set; }

        public Uri? subscriptions_url { get; set; }

        public Uri? organizations_url { get; set; }

        public Uri? repos_url { get; set; }

        public string? events_url { get; set; }

        public Uri? received_events_url { get; set; }

        public string? type{ get; set; }

        public bool site_admin { get; set; }
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