using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ProjektBankaHelisek
{
    public class ClassMoneyManager
    {
        private readonly string _filePath = "loans.json";
        private Dictionary<string, List<Loan>> loans;

        public ClassMoneyManager()
        {
            loans = LoadLoans();
        }

        // Přidání půjčky
        public void AddLoan(string username, decimal amount, DateTime loanDate, decimal interestRate)
        {
            if (!loans.ContainsKey(username))
            {
                loans[username] = new List<Loan>();
            }

            loans[username].Add(new Loan
            {
                Amount = amount,
                LoanDate = loanDate,
                InterestRate = interestRate
            });

            SaveLoans(); // Uloží změny do JSON
        }

        // Přidání půjčky do Učtu uživatele
        public void AddLoanToAccountBalance(string username, decimal amount)
        {
            var users = new ClassUserManager().GetAllUsers();
            var user = users.FirstOrDefault(u => u.Username == username);

            if (user != null)
            {
                user.AccountBalance += amount; // Přičtení částky půjčky k zůstatku
                new ClassUserManager().SaveUsers(users); // Uložení změn
            }
        }

        // Získání všech půjček uživatele
        public List<Loan> GetLoansByUser(string username)
        {
            return loans.ContainsKey(username) ? loans[username] : new List<Loan>();
        }

        // Získání celkové částky půjček uživatele
        public decimal GetTotalLoanAmountByUser(string username)
        {
            return loans.ContainsKey(username) ? loans[username].Sum(loan => loan.Amount) : 0;
        }

        // Uložení půjček do JSON
        private void SaveLoans()
        {
            var json = JsonConvert.SerializeObject(loans, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        // Načtení půjček z JSON
        private Dictionary<string, List<Loan>> LoadLoans()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<Dictionary<string, List<Loan>>>(json) ?? new Dictionary<string, List<Loan>>();
            }

            return new Dictionary<string, List<Loan>>();
        }
    }

    // Třída reprezentující jednu půjčku
    public class Loan
    {
        public decimal Amount { get; set; }         // Částka půjčky
        public DateTime LoanDate { get; set; }     // Datum půjčky
        public decimal InterestRate { get; set; }  // Úroková sazba
    }
}