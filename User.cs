using System;

public class User
{
	
	
        // constructor
        private int id;
		private string username;
		private string email;
		private string password;
		private string role;
		private final string adminpassword = "Password1234";

    public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Username
		{
			get { return username; }
			set { username = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public string Password
		{
			get { return password; }
			set { password = value; }
		}
		public string Role
		{
			get { return role; }
			set { role = value; }
		}
	public string Adminpassword
		{
			get { return adminpassword; }
		set { adminpassword = value; }
    }

    public User(int id, string username, string email, string password, string role)
		{
			this.id = id;
			this.username = username;
			this.email = email;
			this.password = password;
			this.role = role;
		}
		
		public Logout()
		{
			Console.WriteLine("User logged out."); 
		}

		public UpdateProfile()
		{		
			Console.WriteLine("User profile updated.");
		}


    private void LoadUsersFromCsv()
    {
        if (!File.Exists(filePath))
            return;

        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] data = line.Split(',');

            if (data.Length == 2)
            {
                users.Add(new User(data[0], data[1]));
            }
        }
    }

    private void SaveUsersToCsv()
    {
        List<string> lines = new List<string>();

        foreach (User user in users)
        {
            lines.Add($"{user.Username},{user.Password}");
        }

        File.WriteAllLines(filePath, lines);
    }



}
