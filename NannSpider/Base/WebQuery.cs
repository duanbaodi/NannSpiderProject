using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace NannSpider
{
	public partial class WebQuery
	{
		#region 单例
		private static WebQuery _instance;
		public static WebQuery Instance
		{
			get
			{
				if(_instance == null)
				{
					_instance = new WebQuery();

					//_instance.IpAddress = GpUtil.Configuration("IpAddress");
				}

				return _instance;
			}
		}
		public WebQuery()
		{

		}
		#endregion


		private HttpClient httpClient;

		private string IpAddress = null;
		private int RepeatQueryCount = 3;


		/// <summary>
		/// 释放HttpClient对象
		/// </summary>
		public void HttpClientDispose()
		{
			//用完要记得释放
			if(httpClient != null)
			{
				httpClient.Dispose();
			}
		}

		public WebQuery SetUri(string uri) {
			if (IpAddress != uri)
			{
				var handler = new HtmlCharSetHandler();
				httpClient = new HttpClient(handler);
				IpAddress = uri;
				String url = IpAddress;
				httpClient.DefaultRequestHeaders.Accept.Clear();
				httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
				httpClient.BaseAddress = new Uri(url);
			}
			return this;
		}

		#region  GetMethod
		public async Task<string> HttpClientDoGet(string suffix)
		{
			var uri = IpAddress + suffix;
			//var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.None };

			//httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			string paramsuffix = "";
			HttpResponseMessage response = await httpClient.GetAsync(suffix + "?" + paramsuffix);

			if(response.IsSuccessStatusCode)
			{
				Stream myResponseStream = await response.Content.ReadAsStreamAsync();
				StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
				string retString = myStreamReader.ReadToEnd();
				//Console.WriteLine(retString);

				myStreamReader.Close();
				myResponseStream.Close();

				return retString;
			}
			else
			{
				Stream myResponseStream = await response.Content.ReadAsStreamAsync();
				StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
				string retString = myStreamReader.ReadToEnd();
				//Console.WriteLine(retString);

				myStreamReader.Close();
				myResponseStream.Close();

				return retString;
			}
		}

		
		/// <summary>
		/// 测试函数
		/// </summary>
		private async void HttpClientDoPost()
		{
			var uri = "http://192.168.1.108";
			var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.None };

			using(var httpclient = new HttpClient(handler))
			{
				httpclient.BaseAddress = new Uri(uri);
				var content = new FormUrlEncodedContent(new Dictionary<string, string>()
						 {
							  {"Id", "65fc7ca4fc441d26f71bf3d691b278c2"},
							  {"Password", "65fc7ca4fc441d26f71bf3d691b278c2"},
							  {"deviceId", "537eb34be4b022b7fbe19471"}
						 });

				var response = await httpclient.PostAsync(uri, content);

				string responseString = await response.Content.ReadAsStringAsync();
			}
		}




		#endregion

		#region PostMehtod
		public async Task<string> Post(string uriname, string title, string content, string deviceId = "UnkownDevice")
		{
			try
			{
				for(int i = 0; i < RepeatQueryCount; i++)
				{
					var handler = new HtmlCharSetHandler();
					String url = IpAddress;
					httpClient.DefaultRequestHeaders.Accept.Clear();
					httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
					//httpClient.BaseAddress = new Uri(url);
					url = IpAddress + uriname;
					List<KeyValuePair<String, String>> paramList = new List<KeyValuePair<String, String>>();
					paramList.Add(new KeyValuePair<string, string>("GpContent", content));
					paramList.Add(new KeyValuePair<string, string>("GpType", "类型"));
					paramList.Add(new KeyValuePair<string, string>("SendTime", DateTime.Now.ToString("yyyyMMddHHmmss")));
					paramList.Add(new KeyValuePair<string, string>("GpTitle", title));
					var response = await httpClient.PostAsync(new Uri(url), new FormUrlEncodedContent(paramList));
					if(response.IsSuccessStatusCode)
					{
						string responseString = await response.Content.ReadAsStringAsync();
						// 判断是否成功
						if(responseString.IndexOf("GpSuccess") != -1)
						{
							return responseString;
						}
						else
						{
							// 失败了
							return responseString;
						}
					}
				}

			}
			catch(Exception ex)
			{
				throw ex;
			}
			return "未知原因失败";
		}
		#endregion


	}
	class HtmlCharSetHandler : HttpClientHandler
	{
		protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			var response = await base.SendAsync(request, cancellationToken);

			var contentType = response.Content.Headers.ContentType;
			contentType.CharSet = await getCharSetAsync(response.Content);

			return response;
		}

		private async Task<string> getCharSetAsync(HttpContent httpContent)
		{
			var charset = httpContent.Headers.ContentType.CharSet;
			if(!string.IsNullOrEmpty(charset))
				return charset;

			var content = await httpContent.ReadAsStringAsync();
			var match = Regex.Match(content, @"charset=(?<charset>.+?)""", RegexOptions.IgnoreCase);
			if(!match.Success)
				return charset;

			return match.Groups["charset"].Value;
		}
	}
}