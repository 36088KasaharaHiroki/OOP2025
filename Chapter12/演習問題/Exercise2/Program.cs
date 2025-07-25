﻿using System.Text.Json.Serialization;
using System.Text.Json;

namespace Exercise2 {
    internal class Program {
        static void Main(string[] args) {
            var jsonString = File.ReadAllText("novelist.json");
            var novelist = Deserialize(jsonString);
            if (novelist is not null) {
                Console.WriteLine(novelist);
                foreach (var item in novelist.Masterpieces) {
                    Console.WriteLine(item);
                }
            }
        }

    //    static Novelist? Deserialize(string jsonString) {
    //        var options = new JsonDocumentOptions {
    //            //PropertyNamePolicy = JsonNamingPolicy.CamelCase,

    //        };
    //    var noverist = JsonSerializer.Deserialize<Novelist>(JsonString, options)
    //    return noverist;
    //    }
    //}

    public record Novelist {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        [JsonPropertyName("birth")]
        public DateTime Birthday { get; init; }
        public string[] Masterpieces { get; init; } = [];//空の配列を作成
    }
}

