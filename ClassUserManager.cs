using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Security.Cryptography;


namespace ProjektBankaHelisek
{
    public class ClassUserManager
    {
        private readonly string _filePath = "users.json";
        public static string CurrentUser { get; private set; }


        public ClassUserManager()
        {
            if (!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath, "[]");
            }
        }

        // Registrace nového uživatele
        // Vrací true, pokud registrace proběhla úspěšně, jinak false
        public bool RegisterUser(string username, string password)
        {
            var users = GetAllUsers();
            if (users.Exists(u => u.Username == username))
            {
                return false; // Uživatelské jméno už existuje
            }

            string passwordHash = HashPassword(password);
            string accountNumber = GenerateAccountNumber();

            users.Add(new User { Username = username, PasswordHash = passwordHash, AccountNumber = accountNumber, AccountBalance = 0 });

            SaveUsers(users);
            return true;
        }

        // Generování jedinečného čísla účtu
        // Zajistí, že číslo účtu nebude duplicitní
        private string GenerateAccountNumber()
        {
            var random = new Random();
            string accountNumber;

            do
            {
                accountNumber = random.Next(1000000000, int.MaxValue).ToString(); // Generuje 10místné číslo
            } while (IsAccountNumberExists(accountNumber)); // Zajistí, že číslo účtu je jedinečné

            return accountNumber;
        }

        // Kontrola existence čísla účtu
        // Vrací true, pokud číslo účtu existuje, jinak false
        private bool IsAccountNumberExists(string accountNumber)
        {
            var users = GetAllUsers();
            return users.Any(u => u.AccountNumber == accountNumber);
        }

        // Aktualizace hesla uživatele
        // Vrací true, pokud bylo heslo úspěšně změněno, jinak false
        public bool UpdatePassword(string username, string newPassword)
        {
            var users = GetAllUsers();

            var user = users.Find(u => u.Username == username);
            if (user == null)
            {
                return false; // Uživatel nenalezen
            }

            user.PasswordHash = HashPassword(newPassword); // Aktualizace hesla
            SaveUsers(users);
            return true; // Heslo úspěšně aktualizováno
        }

        // Aktualizace uživatelského jména
        // Vrací true, pokud bylo jméno úspěšně změněno, jinak false
        public bool UpdateName(string username, string newusername)
        {
            var users = GetAllUsers();

            // Najít uživatele podle aktuálního jména
            var user = users.Find(u => u.Username == username);
            if (user == null)
            {
                return false; // Uživatel nenalezen
            }

            // Kontrola, zda nové uživatelské jméno již neexistuje
            if (users.Any(u => u.Username == newusername))
            {
                return false; // Uživatelské jméno už existuje
            }

            // Aktualizace jména
            user.Username = newusername;

            // Uložit změny zpět do JSON
            SaveUsers(users);
            return true;
        }

        // Aktualizace hesla aktuálně přihlášeného uživatele
        public void UpdatePassword(string newPassword)
        {
            // Instance třídy ClassUserManager
            ClassUserManager userManager = new ClassUserManager();

            // Pokus o aktualizaci hesla
            bool success = userManager.UpdatePassword(ClassUserManager.CurrentUser, newPassword);

            if (success)
            {
                MessageBox.Show("Heslo bylo úspěšně změněno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Autentizace uživatele
        // Vrací true, pokud jsou přihlašovací údaje správné, jinak false
        public bool AuthenticateUser(string username, string password)
        {
            var users = GetAllUsers();
            var user = users.Find(u => u.Username == username);
            if (user != null && user.PasswordHash == HashPassword(password))
            {
                CurrentUser = username; // Uloží aktuálního uživatele
                CurrentSession.Username = username;
                return true;
            }
            return false;
        }

        // Načtení všech uživatelů ze souboru
        // Vrací seznam uživatelů
        public List<User> GetAllUsers()
        {
            var json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<User>>(json);
        }

        // Uložení uživatelů do souboru
        public void SaveUsers(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        // Hashování hesla
        // Vrací hash hesla jako řetězec
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        // Třída reprezentující uživatele
        public class User
        {
            public string Username { get; set; }
            public string PasswordHash { get; set; }
            public string AccountNumber { get; set; }
            public decimal AccountBalance { get; set; }
        }

        // Získání uživatele podle uživatelského jména
        // Vrací instanci uživatele nebo null, pokud uživatel nebyl nalezen
        public User GetUserByUsername(string username)
        {
            var users = GetAllUsers();
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show($"Uživatel '{username}' nebyl nalezen.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return user;
        } 
    }

    // Třída pro správu aktuální relace uživatele
    public static class CurrentSession
    {
        public static string Username { get; set; } // Přihlášený uživatel
    }
}
