using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Model
{
    public class Pracownik
    {
        private static decimal min_salary = 200;
        private static decimal max_salary = 200000;
        private readonly static string[] positions = {
            "tester",
            "projektnat",
            "inzynier",
            "młodszy programista",
            "starszy programista"
        };
        private readonly static string[] contracts ={
            "umowa na czas określony",
            "umowa zlecenie",
            "umowa na czas nieokreślony",
        };
        private string firstname, lastname, position, contract;
        private DateTime birth_date;
        private decimal salary;

        public Pracownik() { }

        public Pracownik(string firstname, string lastname, string position, string contract, decimal salary, DateTime bday)
        {
            Firstname = firstname; Lastname = lastname; Position = position; Contract = contract; Salary = salary; birth_date = bday;
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname}, {Birth_date.ToShortDateString()}, {Position}, {Salary}, {Contract}";
        }

        public Pracownik Copy()
        {
            return new Pracownik(Firstname, Lastname, Position, Contract, Salary, Birth_date);
        }

        public string Firstname { get { return firstname; } 
            set { 
                if (value.Length > 0)
                {
                    firstname = value;
                }
                else
                {
                    throw new ArgumentException("Field firstname cannot be empty");
                }
            } 
        }
        public string Lastname { get { return lastname; } 
            set {
                if (value.Length > 0)
                {
                    lastname = value;
                }
                else
                {
                    throw new ArgumentException("Field lastname cannot be empty");
                }
            } 
        }
        public decimal Salary { get {  return salary; }
            set {
                if (value<=max_salary && value >= min_salary)
                {
                    salary = value;
                }
                else
                {
                    throw new ArgumentException($"Field salary must be between {max_salary} and {min_salary}");
                }
            } 
        }
        public string Contract
        {
            get { return contract; }
            set
            {
                if (contracts.Contains(value))
                {
                    contract = value;
                }
                else
                {
                    throw new ArgumentException($"Field contract must contain valid contract");
                }
            }
        }
        public string Position
        {
            get { return position; }
            set
            {
                if (positions.Contains(value))
                {
                    position = value;
                }
                else
                {
                    throw new ArgumentException($"Field position must contain valid position {value}");
                }
            }
        }

        public DateTime Birth_date { get {  return birth_date; }
            set {
                if (birth_date <= DateTime.Now)
                {
                    birth_date = value;
                }
                else
                {
                    throw new ArgumentException("Field birth_date cannot be grater than current date");
                }
            }
        }
        public static decimal get_min_salary() { return min_salary; }

        public static decimal get_max_salary() { return max_salary; }

        public static string[] get_positions() { return positions; }
    }
}
