using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlueWave_Bank
{

    internal class User : Person
    {
        /*
         * Update Mode: The user is already found, or needs to be updated.
         * Add New Mode: The user was not already stored, after the user is stored
         *               it will be in the updated mode.
         */
        public enum enMode { UpdateMode = 1, AddNew = 2 };

        private enMode _Mode;
        private string _Username;
        private string _Password;
        private int _Permissions;  // e.g. -1 for Admin, binary flags for roles

        private const string _USERS_PATH = "C:\\Users\\GO\\Desktop\\programming_files\\BlueWave Bank\\Users.txt";

        public User(enMode Mode, string FirstName, string LastName, string Email, string Phone,
                    string Username, string Password, int Permissions) :
            base(FirstName, LastName, Email, Phone)
        {
            _Mode = Mode;
            _Username = Username;
            _Password = Password;
            _Permissions = Permissions;
        }

        // Username must be read-only
        public string Username
        {
            get { return _Username; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public int Permissions
        {
            get { return _Permissions; }
            set { _Permissions = value; }
        }

        static private User _GetUserObject(string DataLine)
        {
            string[] records = DataLine.Split('#');
            if (records.Length < 7)
                return null;

            User U = new User(enMode.UpdateMode, records[0], records[1], records[2], records[3],
                              records[4], records[5], Convert.ToInt32(records[6]));
            return U;
        }

        static private List<User> _LoadUsersFromFile()
        {
            List<User> _UsersList = new List<User>();
            string[] Lines = File.ReadAllLines(_USERS_PATH);

            foreach (string Line in Lines)
            {
                if (string.IsNullOrWhiteSpace(Line)) continue;

                User U = _GetUserObject(Line);
                if (U != null)
                    _UsersList.Add(U);
            }

            return _UsersList;
        }

        private void _Update()
        {
            List<User> _UsersList = _LoadUsersFromFile();
            for (int i = 0; i < _UsersList.Count; i++)
            {
                if (_UsersList[i].Username == this.Username)
                {
                    _UsersList[i] = this;
                    break;
                }
            }

            _SaveUsersDataInFile(_UsersList);
        }

        private void _AddNew()
        {
            File.AppendAllText(_USERS_PATH, ConvertObjectToDataLine(this) + Environment.NewLine);
        }

        static public string ConvertObjectToDataLine(User U, char Sep = '#')
        {
            string Data = "";
            Data += U.FirstName + Sep;
            Data += U.LastName + Sep;
            Data += U.Email + Sep;
            Data += U.Phone + Sep;
            Data += U.Username + Sep;
            Data += U.Password + Sep;
            Data += U.Permissions;

            return Data;
        }

        static private void _SaveUsersDataInFile(List<User> UsersList)
        {
            List<string> lines = new List<string>();

            foreach (User U in UsersList)
            {
                lines.Add(ConvertObjectToDataLine(U));
            }

            File.WriteAllLines(_USERS_PATH, lines);
        }

        static public User Find(string Username)
        {
            string[] Lines = File.ReadAllLines(_USERS_PATH);
            foreach (string Line in Lines)
            {
                if (string.IsNullOrWhiteSpace(Line)) continue;
                User U = _GetUserObject(Line);
                if (U.Username == Username)
                {
                    return U;
                }
            }

            return null;
        }

        static public User Find(string Username, string Password)
        {
            string[] Lines = File.ReadAllLines(_USERS_PATH);
            foreach (string Line in Lines)
            {
                if (string.IsNullOrWhiteSpace(Line)) continue;
                User U = _GetUserObject(Line);
                if (U.Username == Username && U.Password == Password)
                {
                    return U;
                }
            }

            return null;
        }

        static public bool isUserExist(string Username)
        {
            User U = Find(Username);
            return U != null;
        }

        // Save: For updating, and adding new user.
        public void Save()
        {
            switch (_Mode)
            {
                case enMode.UpdateMode:
                    _Update();
                    break;
                case enMode.AddNew:
                    _AddNew();
                    break;
            }
        }

        public void Delete()
        {
            List<User> UsersList = _LoadUsersFromFile();

            for (int i = 0; i < UsersList.Count(); i++)
            {
                if (UsersList[i].Username == this.Username)
                {
                    UsersList.Remove(UsersList[i]);
                    break;
                }
            }

            _SaveUsersDataInFile(UsersList);
        }

        static public List<User> GetAllUsers()
        {
            return _LoadUsersFromFile();
        }

        public bool HasPermissions(int Permissions)
        {
            return ((Permissions & _Permissions) == Permissions);
        }

        public enum enPermissions
        {
            eManageClients = 1, eClientsTransactions = 2, eManageUsers = 4,
        }
    }

}
