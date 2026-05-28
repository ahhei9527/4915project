using MySql.Data.MySqlClient;
using System.Text.Json;

namespace _4915project
{
    public static class AuditHelper
    {
        private static readonly string ConnectionString =
            "server=localhost;user id=root;password=;database=4915";

        public static void Log(
            string tableName,
            string recordId,
            string action,
            int? userId = null,
            string? username = null,
            object? oldValues = null,
            object? newValues = null,
            string? description = null)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(ConnectionString))
                {
                    con.Open();

                    string query = @"
                        INSERT INTO audit_log 
                        (TableName, RecordId, Action, UserID, Username, OldValues, NewValues, Description, IpAddress, MachineName)
                        VALUES 
                        (@TableName, @RecordId, @Action, @UserID, @Username, @OldValues, @NewValues, @Description, @IpAddress, @MachineName)";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@TableName", tableName);
                        cmd.Parameters.AddWithValue("@RecordId", recordId);
                        cmd.Parameters.AddWithValue("@Action", action);
                        cmd.Parameters.AddWithValue("@UserID", (object?)userId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Username", (object?)(username ?? "System"));
                        cmd.Parameters.AddWithValue("@OldValues", oldValues != null ? JsonSerializer.Serialize(oldValues) : DBNull.Value);
                        cmd.Parameters.AddWithValue("@NewValues", newValues != null ? JsonSerializer.Serialize(newValues) : DBNull.Value);
                        cmd.Parameters.AddWithValue("@Description", (object?)(description ?? ""));
                        cmd.Parameters.AddWithValue("@IpAddress", GetIpAddress());
                        cmd.Parameters.AddWithValue("@MachineName", Environment.MachineName);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Audit Log Error: {ex.Message}");
            }
        }

        private static string GetIpAddress()
        {
            try
            {
                var addresses = System.Net.Dns.GetHostAddresses(Environment.MachineName);
                return addresses.Length > 0 ? addresses[0].ToString() : "Unknown";
            }
            catch
            {
                return "Unknown";
            }
        }
    }
}