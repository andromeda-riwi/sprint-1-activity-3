using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public decimal Balance { get; private set; }
//constructor
        public BankAccount(string accountNumber, string ownerName, decimal initialBalance)//
        {
            AccountNumber = accountNumber;//asignar valores a las propiedades
            OwnerName = ownerName;
            Balance = initialBalance;
        }
//metodos de la clase
        public decimal CheckBalance()//metodo para consultar el saldo
        {
            return Balance;
        }

        public void Deposit(decimal amount)//metodo para depositar dinero en la cuenta
        {
            if (amount > 0)//verificar que el monto a depositar sea positivo
            {
                Balance += amount;
                Console.WriteLine($"Depositado: {amount}. Nuevo saldo: {Balance}");//mostrar el monto depositado y el nuevo saldo
            }
            else
            {
                Console.WriteLine("El monto a depositar debe ser positivo.");//mensaje de error si el monto es negativo
            }
        }
    }
//clase banco que maneja varias cuentas bancarias
    public class Bank// clase banco
    {
        private List<BankAccount> accounts;// lista de cuentas bancarias

        public Bank()   //constructor
        {
            accounts = new List<BankAccount>();
        }

        public void OpenAccount(string accountNumber, string ownerName, decimal initialBalance)//metodo para abrir una nueva cuenta bancaria
        {
            if (accounts.Any(a => a.AccountNumber == accountNumber))//verificar si el numero de cuenta ya existe
            {
                Console.WriteLine("El número de cuenta ya existe.");
                return;
            }
            BankAccount newAccount = new BankAccount(accountNumber, ownerName, initialBalance);//crear una nueva cuenta bancaria
            accounts.Add(newAccount);//agregar la nueva cuenta a la lista de cuentas
            Console.WriteLine("Cuenta abierta con éxito.");//mensaje de exito
        }
//metodo para consultar el saldo de una cuenta bancaria
        public void CheckAccountBalance(string accountNumber)//metodo para consultar el saldo de una cuenta bancaria
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);//buscar la cuenta por su numero
            if (account != null)
            {
                Console.WriteLine($"Saldo de la cuenta {accountNumber}: {account.CheckBalance()}");
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada.");
            }
        }

        public void DepositToAccount(string accountNumber, decimal amount)
        {
            var account = accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
            if (account != null)
            {
                account.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Cuenta no encontrada.");
            }
        }
    }

    public class Exercise2_Bank// clase ejercicio banco
    {
        public static void Run()//metodo para ejecutar el ejercicio
        {
            Console.WriteLine("\n--- Ejercicio 2: Gestión de Cuentas de Banco ---");
            Bank bank = new Bank();//crear una nueva instancia de la clase banco, una instacia es un objeto que representa una clase, para poder usar sus metodos y propiedades
            string option = "";

            do
            {
                Console.WriteLine("\n1. Abrir nueva cuenta");
                Console.WriteLine("2. Consultar saldo");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Opción: ");
                option = Console.ReadLine() ?? "";

                switch (option)
                {
                    case "1":
                        Console.Write("Número de cuenta: ");
                        string accNumber = Console.ReadLine() ?? "";
                        Console.Write("Nombre del dueño: ");
                        string ownerName = Console.ReadLine() ?? "";
                        Console.Write("Saldo inicial: ");
                        decimal initialBalance;
                        while (!decimal.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
                        {
                            Console.WriteLine("Cantidad inválida. Por favor, ingrese un número positivo.");
                            Console.Write("Saldo inicial: ");
                        }
                        bank.OpenAccount(accNumber, ownerName, initialBalance);
                        break;
                    case "2":
                        Console.Write("Número de cuenta a consultar: ");
                        string checkAccNumber = Console.ReadLine() ?? "";
                        bank.CheckAccountBalance(checkAccNumber);
                        break;
                    case "3":
                        Console.Write("Número de cuenta para depositar: ");
                        string depositAccNumber = Console.ReadLine() ?? "";
                        Console.Write("Cantidad a depositar: ");
                        decimal depositAmount;
                        while (!decimal.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                        {
                            Console.WriteLine("Cantidad inválida. Por favor, ingrese una cantidad positiva.");
                            Console.Write("Cantidad a depositar: ");
                        }
                        bank.DepositToAccount(depositAccNumber, depositAmount);
                        break;
                    case "4":
                        Console.WriteLine("Volviendo al menú principal.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (option != "4");
        }
    }
}