const string startIndicator = "Start: {0}";
const string endIndicator = "End: {0}";
const string statusIndicator = "Middle: {0}";

string status = "Healthy";

Console.WriteLine(
    startIndicator,
    status
);

SetHealth(status, false);

Console.WriteLine(
    endIndicator,
    status
);

static void SetHealth(string status, bool isHealthy)
{
    status = isHealthy ? "Healthy" : "Unhealthy";
    Console.WriteLine(
        statusIndicator,
        status
    );
}