using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using UnityEditor.MemoryProfiler;

public class SqlReader : MonoBehaviour
{
    private string dbName = "";

    private void Start()
    {
        
    }


    public void CreateDB()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "";
                command.ExecuteNonQuery();
            }

            connection.Close();

        }
    }
    public void ReadDB()
    {

    }
}
