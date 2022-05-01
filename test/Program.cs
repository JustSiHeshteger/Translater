using Amazon;
using Amazon.Translate;
using Amazon.Translate.Model;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using YandexLinguistics.NET;
using IronPython;
using Nancy.Json;
using System.Diagnostics;
using System.Linq;

namespace test
{
    class Program
    {
        static string _iam_token = "t1.9euelZqQzpaKxpjMlZPJy4rKyJGbye3rnpWalcnIypDNnYqYlJGXnI6Yjpvl8_ciMUps-e9aT3ww_d3z92JfR2z571pPfDD9.0rsxww3q5SgZ5JECbEAahflqz4wbYhLlEthWJEnqUtDgOI_d8MhbswHzgwKUs8GQWvDCnfr6kIgAm1Zfh81dAg";
        static string _folder_id = "b1ga7hn7202f7sdtdttn";
        static string _target_language = "ru";
        static string _command = "$yandexPassportOauthToken = \"AQAAAAAs4nSBAATuweBUScGhBUi9hjvHfqSCZcg\"\n" + 
                                 "$Body = @{ yandexPassportOauthToken = \"$yandexPassportOauthToken\" } | ConvertTo-Json -Compress\n" +
                                 "Invoke-RestMethod -Method 'POST' -Uri 'https://iam.api.cloud.yandex.net/iam/v1/tokens' -Body $Body -ContentType 'Application/json' | Select-Object -ExpandProperty iamToken\n";



        static void Main(string[] args)
        {
            //var process = Process.Start(new ProcessStartInfo 
            //{
            //    FileName = "powershell",
            //    RedirectStandardOutput = true,
            //    RedirectStandardInput = true,
            //    UseShellExecute = false,
            //    CreateNoWindow = true,
            //});

            //using (var sw = new StreamWriter(process.StandardInput.BaseStream))
            //{
            //    sw.Write(_command);
            //}

            //process.WaitForExit();

            //string[] str = process.StandardOutput.ReadToEnd().Trim().Split('\n');
            //process.Close();

            //Console.WriteLine($"{str[^2]}");
            GetTranslate();
            Console.ReadKey();
        }

        static void GetTranslate()
        {
            var apiKey = "AQVNyCTE12Q70BecRk728ZdqJLMCkr7dNM-p4SxD";
            var headers = new NameValueCollection()
            {
                { "Authorization", $"Bearer {apiKey}" }
            };

            string site = "https://translate.api.cloud.yandex.net/translate/v2/translate";

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(site);
            httpWebRequest.Headers.Add(headers);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json2 = new JavaScriptSerializer().Serialize(new
                {
                    //targetLanguageCode = _target_language,
                    //texts = output_mes,
                    folderId = _folder_id
                });

                streamWriter.Write(json2);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
