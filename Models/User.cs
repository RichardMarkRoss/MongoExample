using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace MongoExample.Models;

public class Users
{
    public string? Id { get; set; }
    public string? User { get; set; };
    public string? Password { get; set; };
}