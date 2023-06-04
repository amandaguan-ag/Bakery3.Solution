namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string Description { get; set; }

        // public Machine(string description)
        // {
        //   Description = description;
        // }
        // public Machine(string description, int id)
        // {
        //   Description = description;
        //   Id = id;
        // }

        // public override bool Equals(System.Object otherMachine)
        // {
        //   if (!(otherMachine is Machine))
        //   {
        //     return false;
        //   }
        //   else
        //   {
        //     Machine newMachine = (Machine) otherMachine;
        //     bool idEquality = (this.Id == newMachine.Id);
        //     bool descriptionEquality = (this.Description == newMachine.Description);
        //     return (idEquality && descriptionEquality);
        //   }
        // }

        // public void Save()
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

        //   cmd.CommandText = "INSERT INTO machines (description) VALUES (@MachineDescription);";
        //   MySqlParameter param = new MySqlParameter();
        //   param.ParameterName = "@MachineDescription";
        //   param.Value = this.Description;
        //   cmd.Parameters.Add(param);    
        //   cmd.ExecuteNonQuery();
        //   Id = (int) cmd.LastInsertedId;

        //   conn.Close();
        //   if (conn != null)
        //   {
        //     conn.Dispose();
        //   }
        // }

        // public static Machine Find(int id)
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();

        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "SELECT * FROM `machines` WHERE id = @ThisId;";

        //   MySqlParameter param = new MySqlParameter();
        //   param.ParameterName = "@ThisId";
        //   param.Value = id;
        //   cmd.Parameters.Add(param);

        //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //   int machineId = 0;
        //   string machineDescription = "";
        //   while (rdr.Read())
        //   {
        //     machineId = rdr.GetInt32(0);
        //     machineDescription = rdr.GetString(1);
        //   }
        //   Machine foundMachine = new Machine(machineDescription, machineId);

        //   conn.Close();
        //   if (conn != null)
        //   {
        //     conn.Dispose();
        //   }
        //   return foundMachine;
        // }

        // public static List<Machine> GetAll()
        // {
        //   List<Machine> allMachines = new List<Machine> { };
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "SELECT * FROM machines;";
        //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
        //   while (rdr.Read())
        //   {
        //       int machineId = rdr.GetInt32(0);
        //       string machineDescription = rdr.GetString(1);
        //       Machine newMachine = new Machine(machineDescription, machineId);
        //       allMachines.Add(newMachine);
        //   }
        //   conn.Close();
        //   if (conn != null)
        //   {
        //       conn.Dispose();
        //   }
        //   return allMachines;
        // }

        // public static void ClearAll()
        // {
        //   MySqlConnection conn = DB.Connection();
        //   conn.Open();
        //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
        //   cmd.CommandText = "DELETE FROM machines;";
        //   cmd.ExecuteNonQuery();
        //   conn.Close();
        //   if (conn != null)
        //   {
        //    conn.Dispose();
        //   }
        // }
    }
}