using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BlueWave_Bank;

namespace BlueWave_Bank
{
    internal class BankClient : Person
    {
        /*
         * Update Mode: The client is already found, or needs to be updated.
         * Add New Mode: The client was not already stored, after the client stored
                         it will be in the updated mode.
         */
        public enum enMode {UpdateMode =1, AddNew = 2 };

        private enMode _Mode;
        private string _AccountNumber;
        private string _PinCode;
        private double _Balance;

        private const string _CLIENTS_PATH = "C:\\Users\\GO\\Desktop\\programming_files\\BlueWave Bank\\Clients.txt";
        public BankClient(enMode Mode,string FirstName, string LastName, string Email, 
            string Phone, string AccountNumber, string PinCode, double Balance) :
            base(FirstName, LastName, Email, Phone)
        {
            _Mode = Mode;
            _AccountNumber = AccountNumber;
            _PinCode = PinCode;
            _Balance = Balance;
        }

        // Account number must be read only. No set method.
        public string AccountNumber()
        {
            return _AccountNumber;
        }

        public string PinCode
        {
            get { return _PinCode; }
            set { _PinCode = value; }
        }

        public double Balance
        {
            get { return _Balance; }
            set { _Balance = value; }
        }

        static private BankClient _GetBankClientObject(string DataLine)
        {
            string[] records = DataLine.Split('#');
            if (records.Length < 7)
                return null; 

            BankClient Client1 = new
                BankClient(enMode.UpdateMode,records[0], records[1], records[2], records[3],
                records[4], records[5], Convert.ToDouble(records[6]));
            return Client1;

        }

        static private List<BankClient> _LoadClientsFromFile()
        {
            List<BankClient> _ClientsList = new List<BankClient>();
            string[] Lines = File.ReadAllLines(_CLIENTS_PATH);

            foreach (string Line in Lines)
            {
                if (string.IsNullOrWhiteSpace(Line)) continue; 

                BankClient Client = _GetBankClientObject(Line);
                if (Client != null)
                    _ClientsList.Add(Client);
            }


            return _ClientsList;
        }

        private void _Update()
        {
            List < BankClient> _ClientsList = _LoadClientsFromFile();
            for (int i = 0; i < _ClientsList.Count; i++)
            {
                if (_ClientsList[i].AccountNumber() == this.AccountNumber())
                {
                    _ClientsList[i] = this;
                    break;
                }
            }

            _SaveClientsDataInFile(_ClientsList);
        }
        private void _AddNew()
        {

            File.AppendAllText(_CLIENTS_PATH, ConvertObjectToDataLine(this)+Environment.NewLine);
        }

        static public string ConvertObjectToDataLine(BankClient Client, char Sep = '#')
        {
            string Data = "";
            Data += Client.FirstName + Sep;
            Data += Client.LastName + Sep;
            Data += Client.Email + Sep;
            Data += Client.Phone + Sep;
            Data += Client.AccountNumber() + Sep;
            Data += Client.PinCode + Sep;
            Data += Client.Balance;

            return Data;
        }
        static private void _SaveClientsDataInFile(List<BankClient> ClientsList)
        {
            List<string> lines = new List<string>();

            foreach (BankClient C in ClientsList)
            {
                lines.Add(ConvertObjectToDataLine(C));
            }

            File.WriteAllLines(_CLIENTS_PATH, lines);
        }


        static public BankClient Find(string AccountNumber)
        {
            string[] Lines = File.ReadAllLines(_CLIENTS_PATH);
            foreach (string Line in Lines)
            {
                if (string.IsNullOrWhiteSpace(Line)) continue;
                BankClient Client = _GetBankClientObject(Line);
                if (Client.AccountNumber() == AccountNumber)
                {
                    return Client;
                }
            }

            return null;
        }

        static public BankClient Find(string AccountNumber, string PinCode)
        {
            string[] Lines = File.ReadAllLines("Clients.txt");
            foreach (string Line in Lines)
            {
                if (string.IsNullOrWhiteSpace(Line)) continue;
                BankClient Client = _GetBankClientObject(Line);
                if (Client.AccountNumber() == AccountNumber 
                    && Client.PinCode == PinCode)
                {
                    return Client;
                }
            }

            return null;
        }

        static public bool isClientExist(string AccountNumber)
        {
            BankClient Client = Find(AccountNumber);
            return Client != null;
        }

        //Save: For updating, and adding new client.
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
            List<BankClient> ClientsList = _LoadClientsFromFile();

            for (int i = 0; i < ClientsList.Count(); i++)
            {
                if (ClientsList[i].AccountNumber() == this.AccountNumber())
                {
                    ClientsList.Remove(ClientsList[i]);
                    break;
                }
            }

            _SaveClientsDataInFile(ClientsList);
        }

        static public List<BankClient> GetAllClients()
        {
            return _LoadClientsFromFile();
        }

        public void Deposit(double Amount)
        {
            this._Balance += Amount;
            this.Save();
        }

        public void Withdraw(double Amount)
        {
            this._Balance -= Amount;
            this.Save();
        }

        public void Transfer(double Amount, BankClient Client)
        {
            this.Withdraw(Amount);
            Client.Deposit(Amount);
        }

       static public double TotalBalances()
        {
            double TotalBalances = 0;
            List<BankClient> Clients = _LoadClientsFromFile();

            for (int i = 0; i < Clients.Count(); i++)
                TotalBalances += Clients[i].Balance;

            return TotalBalances;
        }
    }
}
