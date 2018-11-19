using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace DownloadServiceLib
{
    public static class DownloadService
    {
        public static async Task<string> DownloadAsync(string address)
        {
            using (var client = new HttpClient()) {

                string html;

                try {
                    var responseMessage = await client.GetAsync(address);
                    html = await responseMessage.Content.ReadAsStringAsync();
                } catch (Exception e) {
                    html = e.ToString();
                }

                return html;
            }
        }

        public static async Task<string> DownloadAsync(string address, CancellationToken token)
        {
            using (var client = new HttpClient()) {
                string html;

                try {
                    var responseMessage = await client.GetAsync(address, token);
                    html = await responseMessage.Content.ReadAsStringAsync();
                } catch (TaskCanceledException) {
                    html = "Downloading has been cancelled.";
                } catch (Exception e) {
                    html = e.ToString();
                }

                return html;
            }
        }

        public static string Download(string address)
        {
            using (var client = new WebClient()) {

                string html;

                try
                {
                    html = client.DownloadString(address);
                } catch (Exception e) {
                    html = e.ToString();
                }

                return html;
            }
        }
    }
}