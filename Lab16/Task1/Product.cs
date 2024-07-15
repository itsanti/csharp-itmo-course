﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Task1
{
    public class Product
    {
        [JsonPropertyName("id")]
        public uint Code { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        public static void SaveToJson(string fileName, Product[] products)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                JsonSerializerOptions options = new JsonSerializerOptions()
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                string json = JsonSerializer.Serialize(products, options);
                sw.WriteLine(json);
            }
        }

        public static Product[] LoadFromJson(string fileName)
        {
            Product[] products;
            using (StreamReader sr = new StreamReader(fileName))
            {
                products = JsonSerializer.Deserialize<Product[]>(sr.ReadToEnd());
            }
            return products;
        }
    }
}

    
