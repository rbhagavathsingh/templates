namespace DotNetRuntime;
using System.io;
using Appwrite;
using Appwrite.Services;
using Appwrite.Models;

public class Handler {

    // This is your Appwrite function
    // It"s executed each time we get a request
    public async Task<RuntimeOutput> Main(RuntimeContext Context) 
    {
        var appwriteBaseUrl = Environment.GetEnvironmentVariable("APPWRITE_FUNCTION_ENDPOINT");
        var appwriteApiKey = Environment.GetEnvironmentVariable("APPWRITE_DATABASE_API_KEY");
        var appwriteProjectId = Environment.GetEnvironmentVariable("APPWRITE_PROJECT_ID");
        var appwriteDatabaseId = Environment.GetEnvironmentVariable("APPWRITE_DATABASE_ID");
        var appwriteCollectionId = Environment.GetEnvironmentVariable("APPWRITE_COLLECTION_ID");
        

        var meilisearchUrl = Environment.GetEnvironmentVariable("MEILISEARCH_ENDPOINT");
        var meilisearchApiKey = Environment.GetEnvironmentVariable("MEILISEARCH_API_KEY");
        var meilisearchIndex = Environment.GetEnvironmentVariable("MEILISEARCH_INDEX");


        if (string.IsNullOrWhiteSpace(appwriteBaseUrl) ||
            string.IsNullOrWhiteSpace(appwriteApiKey) ||
            string.IsNullOrWhiteSpace(appwriteProjectId) ||
            string.IsNullOrWhiteSpace(appwriteDatabaseId) ||
            string.IsNullOrWhiteSpace(appwriteCollectionId) ||
            string.IsNullOrWhiteSpace(meilisearchUrl) ||
            string.IsNullOrWhiteSpace(meilisearchApiKey) ||
            string.IsNullOrWhiteSpace(meilisearchIndex))
            {
                res.Json(new() {
                { "success", false },
                { "message", "Please provide all required environment variables." }
            });
            return res;
        }
        if (Context.Req.Method != "GET")
        {
            var reqBody = JsonConvert.DeserializeObject<Dictionary<string, string>>(req.Payload);
            var gotRequestVariables =
               // reqBody.TryGetValue("TBD", out string databaseId) &
               // reqBody.TryGetValue("TBD", out string collectionId);
                    if (!gotRequestVariables)
                    {
                        res.Json(new() {
                    { "success", false },
                    { "message", "Payload is invalid." }
                    });
                        return res;
                    }

        }
            //reading Payload
            
        
        
        

        
    }
}